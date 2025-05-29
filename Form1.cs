using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace javitozhgyakorlas
{
    public partial class Form1 : Form
    {
        BindingList<Repcsik> repülõk = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void betöltésButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("repulojaratok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Repcsik>();

                foreach (var item in tömb)
                {
                    repülõk.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mentésButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(repülõk);
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
            repcsikBindingSource.DataSource = repülõk;
        }

        private void törlésButton_Click(object sender, EventArgs e)
        {
            if (repcsikBindingSource == null || repcsikBindingSource.Current == null)
            {
                MessageBox.Show("Hiba történt, nincs kijelölt sor!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Biztosan törli a kijelölt sort?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repcsikBindingSource.RemoveCurrent();
            }
        }

        private void újsorButton_Click(object sender, EventArgs e)
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

        private void érdekességekButton_Click(object sender, EventArgs e)
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
                    $"A leghosszabb menetidejû járat {leghosszabbJarat.IndulasiHely}-ból/-bõl indul {leghosszabbJarat.CelHely}-ba/-be.\n" +
                    $"Átlagosan {Math.Round(atlagUtasNewYork)} utas utazik a New York-i végállomású járatokon.","Érdekességek", MessageBoxButtons.OK);
            }

        }
    }

