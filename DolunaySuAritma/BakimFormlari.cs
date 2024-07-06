using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DolunaySuAritma
{
    public partial class fdf : Form
    {
        Dictionary<string, List<string>> citiesAndDistricts;
        public fdf()
        {
            InitializeComponent();
            citiesAndDistricts = new Dictionary<string, List<string>>
        {
             {"İzmir", new List<string> { "Aliağa, Balçova, Bayındır, Bayraklı, Bergama, Beydağ, Bornova, Buca, Çeşme, Çiğli, Dikili, Foça, Gaziemir, Güzelbahçe, Karabağlar, Karaburun, Karşıyaka, Kemalpaşa, Kınık, Kiraz, Konak, Menderes, Menemen, Narlıdere, Ödemiş, Seferihisar, Selçuk, Tire, Torbalı, Urla" } },
                 {"Balıkesir", new List<string> { "Altıeylül, Ayvalık, Balya, Bandırma, Bigadiç, Burhaniye, Dursunbey, Edremit, Erdek, Gömeç, Gönen, Havran, İvrindi, Karesi, Manyas, Marmara, Savaştepe, Sındırgı, Susurluk\r\n" } },
                 {"Manisa", new List<string> { "Ahmetli, Akhisar, Alaşehir, Demirci, Gölmarmara, Gördes, Kırkağaç, Köprübaşı, Kula, Salihli, Sarıgöl, Saruhanlı, Selendi, Soma, Şehzadeler, Turgutlu, Yunusemre\r\n" } },
                  {"Aydın", new List<string> { "Bozdoğan, Buharkent, Çine, Didim, Efeler, Germencik, Karacasu, Karpuzlu, Koçarlı, Köşk, Kuşadası, Kuyucak, Nazilli, Söke, Sultanhisar, Yenipazar\r\n" } }
            };
        }
        private void BakimFormlari_Load(object sender, EventArgs e)
        {
            foreach (var city in citiesAndDistricts.Keys)
            {
                sehirComboBox.Items.Add(city);
            }
        }
        private void sehirComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = sehirComboBox.SelectedItem.ToString();

            // Seçilen şehre göre ilçeleri ilçe ComboBox'ına ekleyin
            ilceComboBox.Items.Clear(); // Önceki seçimleri temizleyin

            if (selectedCity == "İzmir")
            {
                ilceComboBox.Items.Add("Aliağa");
                ilceComboBox.Items.Add("Balçova");
                ilceComboBox.Items.Add("Bayındır");
                ilceComboBox.Items.Add("Bayraklı");
                ilceComboBox.Items.Add("Bergama");
                ilceComboBox.Items.Add("Beydağ");
                ilceComboBox.Items.Add("Bornova");
                ilceComboBox.Items.Add("Buca");
                ilceComboBox.Items.Add("Çeşme");
                ilceComboBox.Items.Add("Çiğli");
                ilceComboBox.Items.Add("Dikili");
                ilceComboBox.Items.Add("Foça");
                ilceComboBox.Items.Add("Gaziemir");
                ilceComboBox.Items.Add("Güzelbahçe");
                ilceComboBox.Items.Add("Karabağlar");
                ilceComboBox.Items.Add("Karaburun");
                ilceComboBox.Items.Add("Karşıyaka");
                ilceComboBox.Items.Add("Kemalpaşa");
                ilceComboBox.Items.Add("Kınık");
                ilceComboBox.Items.Add("Kiraz");
                ilceComboBox.Items.Add("Konak");
                ilceComboBox.Items.Add("Menderes");
                ilceComboBox.Items.Add("Menemen");
                ilceComboBox.Items.Add("Narlıdere");
                ilceComboBox.Items.Add("Ödemiş");
                ilceComboBox.Items.Add("Seferihisar");
                ilceComboBox.Items.Add("Selçuk");
                ilceComboBox.Items.Add("Tire");
                ilceComboBox.Items.Add("Torbalı");
                ilceComboBox.Items.Add("Urla");
            }
            else if (selectedCity == "Balıkesir")
            {
                ilceComboBox.Items.Add("Altıeylül");
                ilceComboBox.Items.Add("Ayvalık");
                ilceComboBox.Items.Add("Balya");
                ilceComboBox.Items.Add("Bandırma");
                ilceComboBox.Items.Add("Bigadiç");
                ilceComboBox.Items.Add("Burhaniye");
                ilceComboBox.Items.Add("Dursunbey");
                ilceComboBox.Items.Add("Edremit");
                ilceComboBox.Items.Add("Erdek");
                ilceComboBox.Items.Add("Gömeç");
                ilceComboBox.Items.Add("Gönen");
                ilceComboBox.Items.Add("Havran");
                ilceComboBox.Items.Add("İvrindi");
                ilceComboBox.Items.Add("Karesi");
                ilceComboBox.Items.Add("Manyas");
                ilceComboBox.Items.Add("Marmara");
                ilceComboBox.Items.Add("Savaştepe");
                ilceComboBox.Items.Add("Sındırgı");
                ilceComboBox.Items.Add("Susurluk");
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Buraya gerekli kodu ekleyin
        }
        private void BakimFormlari_Load_1(object sender, EventArgs e)
        {
            //Buraya gerekli kodu ekleyin
        }
        private void label3_Click(object sender, EventArgs e)
        {
            // Bu alana tıklama ile ilgili yapılacak işlemleri ekleyin
        }
        private void label4_Click(object sender, EventArgs e)
        {
            // Bu alana tıklama ile ilgili yapılacak işlemleri ekleyin
        }
 
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Buraya gerekli kodu ekleyin
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Buraya gerekli kodu ekleyin
        }
        private void ilceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
