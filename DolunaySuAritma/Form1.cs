namespace DolunaySuAritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.Location = new Point(0, 0);

        }

        private void bakimFormuBtn_Click(object sender, EventArgs e)
        {
            fdf form = new fdf();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BakimFormlariListesi form = new BakimFormlariListesi();
            form.Show();
        }
    }
}
