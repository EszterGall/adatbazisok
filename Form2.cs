using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace javitozhgyakorlas
{
    public partial class Form2 : Form
    {
        public Repcsik UjJarat { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UjJarat = new Repcsik
                {
                    JaratID = int.Parse(textBox1.Text),
                    Legitarsasag = textBox2.Text,
                    IndulasiHely = textBox3.Text,
                    CelHely = textBox4.Text,
                    UtasokSzama = int.Parse(textBox5.Text),
                    IdotartamOra = int.Parse(textBox6.Text)
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hibás adatbevitel: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
