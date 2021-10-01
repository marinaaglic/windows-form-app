using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zavrsni
{
    public partial class Pregled : Form
    {
        public Pregled()
        {
            InitializeComponent();
        }

        static string connstring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        private void Pregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fakultetDataSet.GetOcjene' table. You can move, or remove it, as needed.
            this.getOcjeneTableAdapter.Fill(this.fakultetDataSet.GetOcjene);
            // TODO: This line of code loads data into the 'fakultetDataSet1.STATUSI' table. You can move, or remove it, as needed.
            //this.sTATUSITableAdapter.Fill(this.fakultetDataSet1.STATUSI);
            lblPrijavljeniKorisnik.Text = Zavrsni.Prijava.LoginInfo.username;

            fillCmbKolegiji();

        }

        private void cmbKolegiji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKolegiji.SelectedIndex > 0)
            {
                fillDgvStatus();
            }

        }

        /// <summary>
        /// popunjavanje cmbKolegiji prema prijavljenom korisniku
        /// </summary>
        private void fillCmbKolegiji()
        {
            try
            {
                conn.Open();
                cmbKolegiji.Items.Clear();
                SqlCommand cmd = new SqlCommand("getKolegijProf", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_profesor", SqlDbType.Int).Value = Zavrsni.Prijava.LoginInfo.id_profesora;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                da.Fill(dt);

                DataRow row = dt.NewRow();
                row["Naziv"] = "<---Odaberite kolegij--->";
                dt.Rows.InsertAt(row, 0);
                cmbKolegiji.DataSource = dt;
                cmbKolegiji.DisplayMember = "Naziv";
                cmbKolegiji.ValueMember = "ID_kolegij";
                cmbKolegiji.DataSource = dt;

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// prikaz statusa odabranog kolegija
        /// </summary>
        private void fillDgvStatus()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("getStatusiByKolegij", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_kolegij", SqlDbType.VarChar).Value = cmbKolegiji.SelectedValue;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.SelectCommand = cmd;
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                dgvStatus.DataSource = dtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// provjera unosa za bodove, postotak i tip ispita
        /// je li se unosi tekst ili broj
        /// </summary>
        private void dgvStatus_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            //provjera za stupce bodovi i postotak
            if (dgvStatus.CurrentCell.ColumnIndex == 3 || dgvStatus.CurrentCell.ColumnIndex == 4)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            //provjera za stupac kolokvij/ispit
            else if(dgvStatus.CurrentCell.ColumnIndex==6)
            {
                TextBox tb = e.Control as TextBox;
                if(tb!=null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
          
        }

        //provjera unosa brojeva za stupce bodovi i postotak
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Možete unijeti samo brojeve.");
                e.Handled = true;
            }

        }

        //provjera unosa teksta za stupac kolokvij/ispit
        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Možete unijeti samo tekst.");
                e.Handled = true;
            }
        }

        /// <summary>
        /// provjera unosa za stupce bodovi i postotak
        /// je li uneseni broj veci od troznamenkastog za bodove
        /// i je li uneseni broj veci od 100 za postotak
        /// </summary>

        private void dgvStatus_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int newInt;
            if(dgvStatus.CurrentCell.ColumnIndex == 3)
            {
               if(Int32.TryParse(e.FormattedValue.ToString(), out newInt) || newInt < 0 || newInt > 999)
               {
                    MessageBox.Show("Krivi unos. Morate unijeti broj između 0-999.");
                    e.Cancel = true;
                    return;
               }
            }
            else if (dgvStatus.CurrentCell.ColumnIndex == 4)
            {
                if (Int32.TryParse(e.FormattedValue.ToString(), out newInt) || newInt < 0 || newInt > 100)
                {
                    MessageBox.Show("Krivi unos. Morate unijeti broj između 0-100.");
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
