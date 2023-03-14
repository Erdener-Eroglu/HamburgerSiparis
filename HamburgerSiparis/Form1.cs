namespace HamburgerSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HamburgerOzellikleri _ozellikler = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in _ozellikler.Cesitler)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item;
                flpCesitler.Controls.Add(checkBox);
            }
            cmbHamburgerSize.DataSource = _ozellikler.HamburgerSize;
            cmbIcecekler.DataSource = _ozellikler.Icecekler;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi()
            {
                AdSoyad = txtAdSoyad.Text,
                Adres = txtAdres.Text,
                Telefon = txtTelefon.Text
            };
            lstAdSoyad.Items.Add(kisi.AdSoyad);
            lstAdres.Items.Add(kisi.Adres);
            lstTelefon.Items.Add(kisi.Telefon);
            Hamburger hamburger = new Hamburger()
            {
                HamburgerSize = cmbHamburgerSize.SelectedItem.ToString(),
                Icecek = cmbIcecekler.SelectedItem.ToString()
            };
            foreach (var item in flpCesitler.Controls)
            {
                if (item is CheckBox chc)
                {
                    if (chc.Checked)
                    {
                        hamburger.Cesitler.Add(chc.Text);
                    }
                }
            }
            string cesitler = "";
            lstHamburgerSize.Items.Add(hamburger.HamburgerSize);
            lstIcecekler.Items.Add(hamburger.Icecek);
            foreach (var item in hamburger.Cesitler)
            {
                cesitler = cesitler + " " + item.ToString();


            }
            lstCesitler.Items.Add(cesitler);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle(this.Controls);
            FormuTemizle(flpCesitler.Controls);
        }
        private void FormuTemizle(Control.ControlCollection controls)
        {
            foreach (var item in controls)
            {
                if (item is TextBox txt)
                    txt.Text = string.Empty;
                else if (item is ComboBox cmb)
                    cmb.SelectedIndex = -1;
                else if(item is CheckBox chc)
                    chc.Checked = false;
            }       
        }
    }
}