namespace DolunaySuAritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bakimFormuBtn_Click(object sender, EventArgs e)
        {
            BakimFormlari form = new BakimFormlari();
            form.Show();
        }
    }
}
