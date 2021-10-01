namespace Zavrsni
{
    partial class Pregled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbKolegiji = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrijavljeniKorisnik = new System.Windows.Forms.Label();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.getOcjeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakultetDataSet = new Zavrsni.fakultetDataSet();
            this.getStatusiByKolegijBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getStatusiByKolegijTableAdapter = new Zavrsni.fakultetDataSetTableAdapters.getStatusiByKolegijTableAdapter();
            this.getOcjeneTableAdapter = new Zavrsni.fakultetDataSetTableAdapters.GetOcjeneTableAdapter();
            this.getStatusiByKolegijBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getOcjeneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postotakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCJENEIDocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOcjeneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStatusiByKolegijBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStatusiByKolegijBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOcjeneBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKolegiji
            // 
            this.cmbKolegiji.FormattingEnabled = true;
            this.cmbKolegiji.Location = new System.Drawing.Point(298, 78);
            this.cmbKolegiji.Name = "cmbKolegiji";
            this.cmbKolegiji.Size = new System.Drawing.Size(478, 28);
            this.cmbKolegiji.TabIndex = 0;
            this.cmbKolegiji.Text = "Odaberite kolegij";
            this.cmbKolegiji.SelectedIndexChanged += new System.EventHandler(this.cmbKolegiji_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite kolegij:";
            // 
            // lblPrijavljeniKorisnik
            // 
            this.lblPrijavljeniKorisnik.AutoSize = true;
            this.lblPrijavljeniKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljeniKorisnik.Location = new System.Drawing.Point(13, 13);
            this.lblPrijavljeniKorisnik.Name = "lblPrijavljeniKorisnik";
            this.lblPrijavljeniKorisnik.Size = new System.Drawing.Size(0, 25);
            this.lblPrijavljeniKorisnik.TabIndex = 3;
            // 
            // dgvStatus
            // 
            this.dgvStatus.AutoGenerateColumns = false;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.bodoviDataGridViewTextBoxColumn,
            this.postotakDataGridViewTextBoxColumn,
            this.oCJENEIDocjenaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.dgvStatus.DataSource = this.getStatusiByKolegijBindingSource1;
            this.dgvStatus.Location = new System.Drawing.Point(44, 126);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.RowHeadersWidth = 62;
            this.dgvStatus.RowTemplate.Height = 28;
            this.dgvStatus.Size = new System.Drawing.Size(1757, 841);
            this.dgvStatus.TabIndex = 4;
            this.dgvStatus.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvStatus_CellValidating);
            this.dgvStatus.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvStatus_EditingControlShowing);
            // 
            // getOcjeneBindingSource
            // 
            this.getOcjeneBindingSource.DataMember = "GetOcjene";
            this.getOcjeneBindingSource.DataSource = this.fakultetDataSet;
            // 
            // fakultetDataSet
            // 
            this.fakultetDataSet.DataSetName = "fakultetDataSet";
            this.fakultetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getStatusiByKolegijBindingSource
            // 
            this.getStatusiByKolegijBindingSource.DataMember = "getStatusiByKolegij";
            this.getStatusiByKolegijBindingSource.DataSource = this.fakultetDataSet;
            // 
            // getStatusiByKolegijTableAdapter
            // 
            this.getStatusiByKolegijTableAdapter.ClearBeforeFill = true;
            // 
            // getOcjeneTableAdapter
            // 
            this.getOcjeneTableAdapter.ClearBeforeFill = true;
            // 
            // getStatusiByKolegijBindingSource1
            // 
            this.getStatusiByKolegijBindingSource1.DataMember = "getStatusiByKolegij";
            this.getStatusiByKolegijBindingSource1.DataSource = this.fakultetDataSet;
            // 
            // getOcjeneBindingSource1
            // 
            this.getOcjeneBindingSource1.DataMember = "GetOcjene";
            this.getOcjeneBindingSource1.DataSource = this.fakultetDataSet;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 150;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 150;
            // 
            // bodoviDataGridViewTextBoxColumn
            // 
            this.bodoviDataGridViewTextBoxColumn.DataPropertyName = "Bodovi";
            this.bodoviDataGridViewTextBoxColumn.HeaderText = "Bodovi";
            this.bodoviDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bodoviDataGridViewTextBoxColumn.Name = "bodoviDataGridViewTextBoxColumn";
            this.bodoviDataGridViewTextBoxColumn.Width = 150;
            // 
            // postotakDataGridViewTextBoxColumn
            // 
            this.postotakDataGridViewTextBoxColumn.DataPropertyName = "Postotak";
            this.postotakDataGridViewTextBoxColumn.HeaderText = "Postotak";
            this.postotakDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postotakDataGridViewTextBoxColumn.Name = "postotakDataGridViewTextBoxColumn";
            this.postotakDataGridViewTextBoxColumn.Width = 150;
            // 
            // oCJENEIDocjenaDataGridViewTextBoxColumn
            // 
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.DataPropertyName = "OCJENE_ID_ocjena";
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.DataSource = this.getOcjeneBindingSource1;
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.DisplayMember = "Oznaka";
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.Name = "oCJENEIDocjenaDataGridViewTextBoxColumn";
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.ValueMember = "ID_ocjena";
            this.oCJENEIDocjenaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Kolokvij/ispit";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 150;
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 1013);
            this.Controls.Add(this.dgvStatus);
            this.Controls.Add(this.lblPrijavljeniKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKolegiji);
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.Load += new System.EventHandler(this.Pregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOcjeneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStatusiByKolegijBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStatusiByKolegijBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOcjeneBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKolegiji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrijavljeniKorisnik;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.BindingSource getStatusiByKolegijBindingSource;
        private fakultetDataSet fakultetDataSet;
        private fakultetDataSetTableAdapters.getStatusiByKolegijTableAdapter getStatusiByKolegijTableAdapter;
        private System.Windows.Forms.BindingSource getOcjeneBindingSource;
        private fakultetDataSetTableAdapters.GetOcjeneTableAdapter getOcjeneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodoviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postotakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oCJENEIDocjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getOcjeneBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getStatusiByKolegijBindingSource1;
    }
}