using System.Text;

namespace WFA24072501
{
    public partial class FrmMain : Form
    {
        private List<Szemely> szemelyek = new();

        public FrmMain()
        {
            InitializeComponent();
            tbxNev.TextChanged += TbxNev_TextChanged;
            btnRogzit.Click += BtnRogzit_Click;
            this.FormClosing += FrmMain_FormClosing;
            this.Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("..\\..\\..\\src\\rawdata.txt"))
            {
                using StreamReader sr = new("..\\..\\..\\src\\rawdata.txt", Encoding.UTF8);
                while (!sr.EndOfStream)
                {
                    string row = sr.ReadLine();
                    szemelyek.Add(new(row));
                    rtbNyersAdatok.Text += $"{row}\n";
                }
                lblAtlagFizu.Text = $"{szemelyek.Average(sz => sz.Fizetes):0.00} HUF";
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            using StreamWriter sw = new("..\\..\\..\\src\\rawdata.txt", false, Encoding.UTF8);
            sw.WriteLine(rtbNyersAdatok.Text.TrimEnd());
        }

        private void BtnRogzit_Click(object sender, EventArgs e)
        {
            string nev = tbxNev.Text;
            string szul = dtpSzulDat.Value.ToString("yyyy-MM-dd");
            string jogsi = chbJogsi.Checked ? "V" : "N";
            string fizu = $"{nudFizu.Value}";
            string status = null;
            if (rdbAlk.Checked) status = "A";
            else if (rdbVez.Checked) status = "V";
            else if (rdbTul.Checked) status = "T";

            string raw = $"{nev};{szul};{jogsi};{fizu};{status}";

            rtbNyersAdatok.Text += $"{raw}\n";
            szemelyek.Add(new(raw));
            lblAtlagFizu.Text = $"{szemelyek.Average(sz => sz.Fizetes):0.00} HUF";
        }

        private void TbxNev_TextChanged(object sender, EventArgs e) => 
            btnRogzit.Enabled = !string.IsNullOrWhiteSpace(tbxNev.Text);
    }
}
