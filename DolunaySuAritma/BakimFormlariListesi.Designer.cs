namespace DolunaySuAritma
{
    partial class BakimFormlariListesi
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            bakimFormlariBindingSource2 = new BindingSource(components);
            bakimFormlariBindingSource = new BindingSource(components);
            bakimFormlariBindingSource1 = new BindingSource(components);
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AdSoyad = new DataGridViewTextBoxColumn();
            Sehir = new DataGridViewTextBoxColumn();
            Ilce = new DataGridViewTextBoxColumn();
            telNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ucFiltreTarihDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            membranTarihDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tatlandiriciTarihDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cesmeTarihDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tankTarihDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bakimFormlariBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bakimFormlariBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bakimFormlariBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, AdSoyad, Sehir, Ilce, telNoDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, ucFiltreTarihDataGridViewTextBoxColumn, membranTarihDataGridViewTextBoxColumn, tatlandiriciTarihDataGridViewTextBoxColumn, cesmeTarihDataGridViewTextBoxColumn, tankTarihDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bakimFormlariBindingSource2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1359, 733);
            dataGridView1.TabIndex = 0;
            // 
            // bakimFormlariBindingSource2
            // 
            bakimFormlariBindingSource2.DataSource = typeof(Models.BakimFormlari);
            // 
            // bakimFormlariBindingSource
            // 
            bakimFormlariBindingSource.DataSource = typeof(Models.BakimFormlari);
            // 
            // bakimFormlariBindingSource1
            // 
            bakimFormlariBindingSource1.DataSource = typeof(Models.BakimFormlari);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdSoyad
            // 
            AdSoyad.DataPropertyName = "AdSoyad";
            AdSoyad.HeaderText = "Ad Soyad";
            AdSoyad.MinimumWidth = 6;
            AdSoyad.Name = "AdSoyad";
            AdSoyad.Width = 125;
            // 
            // Sehir
            // 
            Sehir.DataPropertyName = "Sehir";
            Sehir.HeaderText = "Şehir";
            Sehir.MinimumWidth = 6;
            Sehir.Name = "Sehir";
            Sehir.Width = 125;
            // 
            // Ilce
            // 
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 6;
            Ilce.Name = "Ilce";
            Ilce.Width = 125;
            // 
            // telNoDataGridViewTextBoxColumn
            // 
            telNoDataGridViewTextBoxColumn.DataPropertyName = "TelNo";
            telNoDataGridViewTextBoxColumn.HeaderText = "TelNo";
            telNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
            telNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucFiltreTarihDataGridViewTextBoxColumn
            // 
            ucFiltreTarihDataGridViewTextBoxColumn.DataPropertyName = "UcFiltreTarih";
            ucFiltreTarihDataGridViewTextBoxColumn.HeaderText = "UcFiltreTarih";
            ucFiltreTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            ucFiltreTarihDataGridViewTextBoxColumn.Name = "ucFiltreTarihDataGridViewTextBoxColumn";
            ucFiltreTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // membranTarihDataGridViewTextBoxColumn
            // 
            membranTarihDataGridViewTextBoxColumn.DataPropertyName = "MembranTarih";
            membranTarihDataGridViewTextBoxColumn.HeaderText = "MembranTarih";
            membranTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            membranTarihDataGridViewTextBoxColumn.Name = "membranTarihDataGridViewTextBoxColumn";
            membranTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // tatlandiriciTarihDataGridViewTextBoxColumn
            // 
            tatlandiriciTarihDataGridViewTextBoxColumn.DataPropertyName = "TatlandiriciTarih";
            tatlandiriciTarihDataGridViewTextBoxColumn.HeaderText = "TatlandiriciTarih";
            tatlandiriciTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            tatlandiriciTarihDataGridViewTextBoxColumn.Name = "tatlandiriciTarihDataGridViewTextBoxColumn";
            tatlandiriciTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // cesmeTarihDataGridViewTextBoxColumn
            // 
            cesmeTarihDataGridViewTextBoxColumn.DataPropertyName = "CesmeTarih";
            cesmeTarihDataGridViewTextBoxColumn.HeaderText = "CesmeTarih";
            cesmeTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            cesmeTarihDataGridViewTextBoxColumn.Name = "cesmeTarihDataGridViewTextBoxColumn";
            cesmeTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // tankTarihDataGridViewTextBoxColumn
            // 
            tankTarihDataGridViewTextBoxColumn.DataPropertyName = "TankTarih";
            tankTarihDataGridViewTextBoxColumn.HeaderText = "TankTarih";
            tankTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            tankTarihDataGridViewTextBoxColumn.Name = "tankTarihDataGridViewTextBoxColumn";
            tankTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // BakimFormlariListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 733);
            Controls.Add(dataGridView1);
            Name = "BakimFormlariListesi";
            Text = "BakimFormlariListesi";
            Load += BakimFormlariListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bakimFormlariBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bakimFormlariBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bakimFormlariBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bakimFormlariBindingSource;
        private BindingSource bakimFormlariBindingSource1;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private BindingSource bakimFormlariBindingSource2;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AdSoyad;
        private DataGridViewTextBoxColumn Sehir;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ucFiltreTarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn membranTarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tatlandiriciTarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cesmeTarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tankTarihDataGridViewTextBoxColumn;
    }
}