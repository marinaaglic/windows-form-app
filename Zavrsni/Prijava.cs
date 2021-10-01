using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Zavrsni
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        public static class LoginInfo
        {
            public static string username;
            public static string id_korisnika;
            public static string id_profesora;
        }


        //CONNECTION STRING
        static string connstring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);     
       
        //VARIJABLE
        string korisnicko_ime;
        string lozinka;
        string idKorisnika;
        string idStudenta;
        string idProfesora;
        private void btnPrijava_Click(object sender, EventArgs e)
        {

            try
            {
                korisnicko_ime = txtKorisnickoIme.Text;
                lozinka = txtLozinka.Text;
                if (korisnicko_ime == "" || lozinka == "")
                {
                    throw new ArgumentException("Korisničko ime i lozinka ne smiju biti prazni!");
                }
                else if (Regex.IsMatch(korisnicko_ime, @"^[a-zA-Z]+$") == false)
                {
                    throw new ArgumentException("Korisničko ime smije sadržavati samo slova!");
                }
              
                conn.Open();
                SqlCommand cmd = new SqlCommand("Prijava", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usr", SqlDbType.VarChar).Value = korisnicko_ime;
                cmd.Parameters.Add("@pwd", SqlDbType.VarChar).Value = lozinka;
                SqlDataAdapter da = new SqlDataAdapter(cmd);    
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Za ispis ID-a od korisnika
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idKorisnika = dr.GetValue(0).ToString();
                    idStudenta = dr.GetValue(1).ToString();
                    idProfesora = dr.GetValue(2).ToString();
                }
                
                Zavrsni.Prijava.LoginInfo.id_korisnika = idKorisnika;
                Zavrsni.Prijava.LoginInfo.id_profesora = idProfesora;

                //Provjera je li postoji u bazi 
                if (dt.Rows.Count == 1)
                {            
                    this.Hide();
                    Pregled pregled = new Pregled();
                    pregled.FormClosed += (s, args) => this.Close();
                    //spremanje username-a za prikaz na form2
                    LoginInfo.username = korisnicko_ime;
                    pregled.Show();

                }
                else if (dt.Rows.Count > 1)
                {
                    MessageBox.Show("Ne mogu postojati dva korisnika sa istim korisničkim imenom.");
                }
                else
                {
                    MessageBox.Show("Nevažeće korisničko ime ili lozinka.");
                    txtKorisnickoIme.Text = "";
                    txtLozinka.Text = "";
                }
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

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
