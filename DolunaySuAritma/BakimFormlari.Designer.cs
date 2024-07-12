namespace DolunaySuAritma
{
    partial class fdf
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            adTextBox = new TextBox();
            sehirComboBox = new ComboBox();
            ilceComboBox = new ComboBox();
            mahalleTextBox = new TextBox();
            adresTextBox = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            telefonTextBox = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ucFiltreDateTime = new DateTimePicker();
            membranDateTime = new DateTimePicker();
            tatDateTime = new DateTimePicker();
            cesmeDateTime = new DateTimePicker();
            tankDateTime = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            ucFiltreUcretTextBox = new TextBox();
            tankUcretTextBox = new TextBox();
            tatUcretTextBox = new TextBox();
            membranUcretTextBox = new TextBox();
            cesmeUcretTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            ekleBtn = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            checkBox6 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            label17 = new Label();
            label18 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(5, 203);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 1;
            label2.Text = "Mahalle/Semt";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(51, 141);
            label3.Name = "label3";
            label3.Size = new Size(41, 28);
            label3.TabIndex = 2;
            label3.Text = "İlçe";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(44, 79);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 3;
            label4.Text = "Şehir";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(24, 251);
            label7.Name = "label7";
            label7.Size = new Size(95, 56);
            label7.TabIndex = 6;
            label7.Text = "Telefon Numarası";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(44, 48);
            label8.Name = "label8";
            label8.Size = new Size(62, 28);
            label8.TabIndex = 7;
            label8.Text = "Adres";
            // 
            // adTextBox
            // 
            adTextBox.Anchor = AnchorStyles.Left;
            adTextBox.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            adTextBox.Location = new Point(147, 16);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(239, 29);
            adTextBox.TabIndex = 8;
            adTextBox.TextChanged += textBox1_TextChanged;
            // 
            // sehirComboBox
            // 
            sehirComboBox.Anchor = AnchorStyles.Left;
            sehirComboBox.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sehirComboBox.FormattingEnabled = true;
            sehirComboBox.Items.AddRange(new object[] { "İzmir", "Manisa", "Aydın", "Balıkesir" });
            sehirComboBox.Location = new Point(147, 78);
            sehirComboBox.Name = "sehirComboBox";
            sehirComboBox.Size = new Size(239, 30);
            sehirComboBox.TabIndex = 10;
            sehirComboBox.SelectedIndexChanged += sehirComboBox_SelectedIndexChanged;
            // 
            // ilceComboBox
            // 
            ilceComboBox.Anchor = AnchorStyles.Left;
            ilceComboBox.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ilceComboBox.FormattingEnabled = true;
            ilceComboBox.Location = new Point(147, 140);
            ilceComboBox.Name = "ilceComboBox";
            ilceComboBox.Size = new Size(239, 30);
            ilceComboBox.TabIndex = 11;
            ilceComboBox.SelectedIndexChanged += ilceComboBox_SelectedIndexChanged;
            // 
            // mahalleTextBox
            // 
            mahalleTextBox.Anchor = AnchorStyles.Left;
            mahalleTextBox.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mahalleTextBox.Location = new Point(147, 202);
            mahalleTextBox.Name = "mahalleTextBox";
            mahalleTextBox.Size = new Size(239, 29);
            mahalleTextBox.TabIndex = 12;
            mahalleTextBox.TextChanged += textBox3_TextChanged;
            // 
            // adresTextBox
            // 
            adresTextBox.Location = new Point(154, 3);
            adresTextBox.Name = "adresTextBox";
            adresTextBox.Size = new Size(239, 119);
            adresTextBox.TabIndex = 13;
            adresTextBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(adTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(mahalleTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(ilceComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(sehirComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(telefonTextBox, 1, 4);
            tableLayoutPanel1.Location = new Point(20, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(480, 311);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // telefonTextBox
            // 
            telefonTextBox.Anchor = AnchorStyles.Left;
            telefonTextBox.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            telefonTextBox.Location = new Point(147, 265);
            telefonTextBox.Name = "telefonTextBox";
            telefonTextBox.Size = new Size(239, 29);
            telefonTextBox.TabIndex = 13;
            telefonTextBox.TextChanged += textBox2_TextChanged;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(26, 11);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 15;
            label5.Text = "3 Filtre";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(13, 62);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 16;
            label6.Text = "Membran";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(9, 113);
            label9.Name = "label9";
            label9.Size = new Size(106, 28);
            label9.TabIndex = 17;
            label9.Text = "Tatlandırıcı";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(27, 164);
            label10.Name = "label10";
            label10.Size = new Size(69, 28);
            label10.TabIndex = 18;
            label10.Text = "Çeşme";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(36, 217);
            label11.Name = "label11";
            label11.Size = new Size(51, 28);
            label11.TabIndex = 19;
            label11.Text = "Tank";
            // 
            // ucFiltreDateTime
            // 
            ucFiltreDateTime.Anchor = AnchorStyles.Left;
            ucFiltreDateTime.CalendarFont = new Font("Segoe UI", 10.8F);
            ucFiltreDateTime.Location = new Point(127, 12);
            ucFiltreDateTime.Name = "ucFiltreDateTime";
            ucFiltreDateTime.Size = new Size(242, 27);
            ucFiltreDateTime.TabIndex = 20;
            ucFiltreDateTime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // membranDateTime
            // 
            membranDateTime.Anchor = AnchorStyles.Left;
            membranDateTime.CalendarFont = new Font("Segoe UI", 10.8F);
            membranDateTime.Location = new Point(127, 63);
            membranDateTime.Name = "membranDateTime";
            membranDateTime.Size = new Size(242, 27);
            membranDateTime.TabIndex = 21;
            // 
            // tatDateTime
            // 
            tatDateTime.Anchor = AnchorStyles.Left;
            tatDateTime.CalendarFont = new Font("Segoe UI", 10.8F);
            tatDateTime.Location = new Point(127, 114);
            tatDateTime.Name = "tatDateTime";
            tatDateTime.Size = new Size(242, 27);
            tatDateTime.TabIndex = 22;
            // 
            // cesmeDateTime
            // 
            cesmeDateTime.Anchor = AnchorStyles.Left;
            cesmeDateTime.CalendarFont = new Font("Segoe UI", 10.8F);
            cesmeDateTime.Location = new Point(127, 165);
            cesmeDateTime.Name = "cesmeDateTime";
            cesmeDateTime.Size = new Size(242, 27);
            cesmeDateTime.TabIndex = 23;
            // 
            // tankDateTime
            // 
            tankDateTime.Anchor = AnchorStyles.Left;
            tankDateTime.CalendarFont = new Font("Segoe UI", 10.8F);
            tankDateTime.Location = new Point(127, 217);
            tankDateTime.Name = "tankDateTime";
            tankDateTime.Size = new Size(242, 27);
            tankDateTime.TabIndex = 24;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(404, 11);
            label12.Name = "label12";
            label12.Size = new Size(59, 28);
            label12.TabIndex = 25;
            label12.Text = "Ücret";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(404, 164);
            label13.Name = "label13";
            label13.Size = new Size(59, 28);
            label13.TabIndex = 26;
            label13.Text = "Ücret";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(404, 113);
            label14.Name = "label14";
            label14.Size = new Size(59, 28);
            label14.TabIndex = 27;
            label14.Text = "Ücret";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(404, 62);
            label15.Name = "label15";
            label15.Size = new Size(59, 28);
            label15.TabIndex = 28;
            label15.Text = "Ücret";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(404, 217);
            label16.Name = "label16";
            label16.Size = new Size(59, 28);
            label16.TabIndex = 29;
            label16.Text = "Ücret";
            // 
            // ucFiltreUcretTextBox
            // 
            ucFiltreUcretTextBox.Anchor = AnchorStyles.Left;
            ucFiltreUcretTextBox.Location = new Point(499, 12);
            ucFiltreUcretTextBox.Name = "ucFiltreUcretTextBox";
            ucFiltreUcretTextBox.Size = new Size(120, 27);
            ucFiltreUcretTextBox.TabIndex = 30;
            // 
            // tankUcretTextBox
            // 
            tankUcretTextBox.Anchor = AnchorStyles.Left;
            tankUcretTextBox.Location = new Point(499, 217);
            tankUcretTextBox.Name = "tankUcretTextBox";
            tankUcretTextBox.Size = new Size(120, 27);
            tankUcretTextBox.TabIndex = 31;
            // 
            // tatUcretTextBox
            // 
            tatUcretTextBox.Anchor = AnchorStyles.Left;
            tatUcretTextBox.Location = new Point(499, 114);
            tatUcretTextBox.Name = "tatUcretTextBox";
            tatUcretTextBox.Size = new Size(120, 27);
            tatUcretTextBox.TabIndex = 32;
            // 
            // membranUcretTextBox
            // 
            membranUcretTextBox.Anchor = AnchorStyles.Left;
            membranUcretTextBox.Location = new Point(499, 63);
            membranUcretTextBox.Name = "membranUcretTextBox";
            membranUcretTextBox.Size = new Size(120, 27);
            membranUcretTextBox.TabIndex = 33;
            // 
            // cesmeUcretTextBox
            // 
            cesmeUcretTextBox.Anchor = AnchorStyles.Left;
            cesmeUcretTextBox.Location = new Point(499, 165);
            cesmeUcretTextBox.Name = "cesmeUcretTextBox";
            cesmeUcretTextBox.Size = new Size(120, 27);
            cesmeUcretTextBox.TabIndex = 34;
            cesmeUcretTextBox.TextChanged += textBox8_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(tankUcretTextBox, 3, 4);
            tableLayoutPanel2.Controls.Add(cesmeUcretTextBox, 3, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(tatUcretTextBox, 3, 2);
            tableLayoutPanel2.Controls.Add(membranUcretTextBox, 3, 1);
            tableLayoutPanel2.Controls.Add(label9, 0, 2);
            tableLayoutPanel2.Controls.Add(label10, 0, 3);
            tableLayoutPanel2.Controls.Add(label11, 0, 4);
            tableLayoutPanel2.Controls.Add(ucFiltreUcretTextBox, 3, 0);
            tableLayoutPanel2.Controls.Add(ucFiltreDateTime, 1, 0);
            tableLayoutPanel2.Controls.Add(label16, 2, 4);
            tableLayoutPanel2.Controls.Add(membranDateTime, 1, 1);
            tableLayoutPanel2.Controls.Add(label13, 2, 3);
            tableLayoutPanel2.Controls.Add(label14, 2, 2);
            tableLayoutPanel2.Controls.Add(label15, 2, 1);
            tableLayoutPanel2.Controls.Add(tatDateTime, 1, 2);
            tableLayoutPanel2.Controls.Add(cesmeDateTime, 1, 3);
            tableLayoutPanel2.Controls.Add(tankDateTime, 1, 4);
            tableLayoutPanel2.Controls.Add(label12, 2, 0);
            tableLayoutPanel2.Location = new Point(544, 61);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(622, 258);
            tableLayoutPanel2.TabIndex = 35;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(label8, 0, 0);
            tableLayoutPanel3.Controls.Add(adresTextBox, 1, 0);
            tableLayoutPanel3.Location = new Point(20, 378);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(505, 125);
            tableLayoutPanel3.TabIndex = 36;
            // 
            // button1
            // 
            button1.Location = new Point(636, 370);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 37;
            button1.Text = "dekont pdf yükle";
            button1.UseVisualStyleBackColor = true;
            // 
            // ekleBtn
            // 
            ekleBtn.Location = new Point(898, 392);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(94, 29);
            ekleBtn.TabIndex = 38;
            ekleBtn.Text = "Ekle";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 39;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Left;
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox2.ForeColor = SystemColors.ButtonHighlight;
            checkBox2.Location = new Point(3, 17);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(17, 17);
            checkBox2.TabIndex = 40;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel4.Controls.Add(textBox2, 1, 3);
            tableLayoutPanel4.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel4.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel4.Controls.Add(checkBox6, 0, 4);
            tableLayoutPanel4.Controls.Add(checkBox3, 0, 3);
            tableLayoutPanel4.Controls.Add(checkBox4, 0, 2);
            tableLayoutPanel4.Controls.Add(checkBox5, 0, 1);
            tableLayoutPanel4.Controls.Add(checkBox2, 0, 0);
            tableLayoutPanel4.Location = new Point(1169, 61);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(118, 258);
            tableLayoutPanel4.TabIndex = 41;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(32, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(77, 27);
            textBox5.TabIndex = 44;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(32, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 27);
            textBox2.TabIndex = 44;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(32, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(77, 27);
            textBox3.TabIndex = 45;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(32, 63);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(77, 27);
            textBox4.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(32, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 27);
            textBox1.TabIndex = 43;
            // 
            // checkBox6
            // 
            checkBox6.Anchor = AnchorStyles.Left;
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox6.ForeColor = SystemColors.ButtonHighlight;
            checkBox6.Location = new Point(3, 222);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(17, 17);
            checkBox6.TabIndex = 45;
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Left;
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox3.ForeColor = SystemColors.ButtonHighlight;
            checkBox3.Location = new Point(3, 170);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(17, 17);
            checkBox3.TabIndex = 42;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.Anchor = AnchorStyles.Left;
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox4.ForeColor = SystemColors.ButtonHighlight;
            checkBox4.Location = new Point(3, 119);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(17, 17);
            checkBox4.TabIndex = 43;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.Anchor = AnchorStyles.Left;
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox5.ForeColor = SystemColors.ButtonHighlight;
            checkBox5.Location = new Point(3, 68);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(17, 17);
            checkBox5.TabIndex = 44;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(687, 19);
            label17.Name = "label17";
            label17.Size = new Size(208, 28);
            label17.TabIndex = 42;
            label17.Text = "En sonki değişim tarihi";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(1165, 19);
            label18.Name = "label18";
            label18.Size = new Size(135, 23);
            label18.TabIndex = 43;
            label18.Text = "Kaçıncı değişim?";
            // 
            // fdf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 21, 37);
            ClientSize = new Size(1308, 610);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(checkBox1);
            Controls.Add(ekleBtn);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "fdf";
            Text = "BakimFormlarıi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox adTextBox;
        private ComboBox sehirComboBox;
        private ComboBox ilceComboBox;
        private TextBox mahalleTextBox;
        private RichTextBox adresTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox telefonTextBox;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker ucFiltreDateTime;
        private DateTimePicker membranDateTime;
        private DateTimePicker tatDateTime;
        private DateTimePicker cesmeDateTime;
        private DateTimePicker tankDateTime;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox ucFiltreUcretTextBox;
        private TextBox tankUcretTextBox;
        private TextBox tatUcretTextBox;
        private TextBox membranUcretTextBox;
        private TextBox cesmeUcretTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button ekleBtn;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox checkBox6;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label17;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label18;
    }
}