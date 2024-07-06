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
            textBox1 = new TextBox();
            sehirComboBox = new ComboBox();
            ilceComboBox = new ComboBox();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox2 = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker5 = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 17);
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
            label2.Location = new Point(8, 203);
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
            label3.Location = new Point(55, 141);
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
            label4.Location = new Point(47, 79);
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
            label7.Location = new Point(28, 251);
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(154, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 29);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // sehirComboBox
            // 
            sehirComboBox.Anchor = AnchorStyles.Left;
            sehirComboBox.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sehirComboBox.FormattingEnabled = true;
            sehirComboBox.Items.AddRange(new object[] { "İzmir", "Manisa", "Aydın", "Balıkesir" });
            sehirComboBox.Location = new Point(154, 78);
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
            ilceComboBox.Location = new Point(154, 140);
            ilceComboBox.Name = "ilceComboBox";
            ilceComboBox.Size = new Size(239, 30);
            ilceComboBox.TabIndex = 11;
            ilceComboBox.SelectedIndexChanged += ilceComboBox_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(154, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 29);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(154, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(239, 119);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(ilceComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(sehirComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 4);
            tableLayoutPanel1.Location = new Point(74, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(505, 311);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(154, 265);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 29);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10.8F);
            dateTimePicker1.Location = new Point(127, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 27);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Left;
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 10.8F);
            dateTimePicker2.Location = new Point(127, 63);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(242, 27);
            dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Anchor = AnchorStyles.Left;
            dateTimePicker3.CalendarFont = new Font("Segoe UI", 10.8F);
            dateTimePicker3.Location = new Point(127, 114);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(242, 27);
            dateTimePicker3.TabIndex = 22;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Anchor = AnchorStyles.Left;
            dateTimePicker4.CalendarFont = new Font("Segoe UI", 10.8F);
            dateTimePicker4.Location = new Point(127, 165);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(242, 27);
            dateTimePicker4.TabIndex = 23;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Anchor = AnchorStyles.Left;
            dateTimePicker5.CalendarFont = new Font("Segoe UI", 10.8F);
            dateTimePicker5.Location = new Point(127, 217);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(242, 27);
            dateTimePicker5.TabIndex = 24;
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
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.Location = new Point(499, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 27);
            textBox4.TabIndex = 30;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left;
            textBox5.Location = new Point(499, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 27);
            textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Left;
            textBox6.Location = new Point(499, 114);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 27);
            textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Location = new Point(499, 63);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(120, 27);
            textBox7.TabIndex = 33;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Left;
            textBox8.Location = new Point(499, 165);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(120, 27);
            textBox8.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox5, 3, 4);
            tableLayoutPanel2.Controls.Add(textBox8, 3, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox6, 3, 2);
            tableLayoutPanel2.Controls.Add(textBox7, 3, 1);
            tableLayoutPanel2.Controls.Add(label9, 0, 2);
            tableLayoutPanel2.Controls.Add(label10, 0, 3);
            tableLayoutPanel2.Controls.Add(label11, 0, 4);
            tableLayoutPanel2.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel2.Controls.Add(label16, 2, 4);
            tableLayoutPanel2.Controls.Add(dateTimePicker2, 1, 1);
            tableLayoutPanel2.Controls.Add(label13, 2, 3);
            tableLayoutPanel2.Controls.Add(label14, 2, 2);
            tableLayoutPanel2.Controls.Add(label15, 2, 1);
            tableLayoutPanel2.Controls.Add(dateTimePicker3, 1, 2);
            tableLayoutPanel2.Controls.Add(dateTimePicker4, 1, 3);
            tableLayoutPanel2.Controls.Add(dateTimePicker5, 1, 4);
            tableLayoutPanel2.Controls.Add(label12, 2, 0);
            tableLayoutPanel2.Location = new Point(615, 61);
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
            tableLayoutPanel3.Controls.Add(richTextBox1, 1, 0);
            tableLayoutPanel3.Location = new Point(74, 378);
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
            // fdf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 21, 37);
            ClientSize = new Size(1308, 610);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "fdf";
            Text = "BakimFormlarıi";
            Load += BakimFormlari_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private ComboBox sehirComboBox;
        private ComboBox ilceComboBox;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker5;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
    }
}