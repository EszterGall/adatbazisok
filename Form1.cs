using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace javitozhgyakorlas
{
    public partial class Form1 : Form
    {
        BindingList<Repcsik> rep�l�k = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void bet�lt�sButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("repulojaratok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<Repcsik>();

                foreach (var item in t�mb)
                {
                    rep�l�k.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ment�sButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(rep�l�k);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repcsikBindingSource.DataSource = rep�l�k;
        }

        private void t�rl�sButton_Click(object sender, EventArgs e)
        {
            if (repcsikBindingSource == null || repcsikBindingSource.Current == null)
            {
                MessageBox.Show("Hiba t�rt�nt, nincs kijel�lt sor!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Biztosan t�rli a kijel�lt sort?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repcsikBindingSource.RemoveCurrent();
            }
        }

        private void �jsorButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                if (form2.UjJarat != null)
                {
                    repcsikBindingSource.Add(form2.UjJarat);
                }
            }
        }

        private void �rdekess�gekButton_Click(object sender, EventArgs e)
        {
                var adatok = repcsikBindingSource.Cast<Repcsik>();

                var leghosszabbJarat = (
                    from j in adatok
                    orderby j.IdotartamOra descending
                    select j
                ).FirstOrDefault();

                var atlagUtasNewYork = (
                    from j in adatok
                    where j.CelHely == "New York"
                    select j.UtasokSzama
                ).DefaultIfEmpty(0).Average();

                MessageBox.Show(
                    $"A leghosszabb menetidej� j�rat {leghosszabbJarat.IndulasiHely}-b�l/-b�l indul {leghosszabbJarat.CelHely}-ba/-be.\n" +
                    $"�tlagosan {Math.Round(atlagUtasNewYork)} utas utazik a New York-i v�g�llom�s� j�ratokon.","�rdekess�gek", MessageBoxButtons.OK);
            }

        }
    }

