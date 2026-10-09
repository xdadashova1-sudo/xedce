namespace xdc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            Application.Exit();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                // Tablonun sütunlarını tanımlıyoruz
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("AdSoyad", "AD SOYAD");
                dataGridView1.Columns.Add("TelebeNo", "TƏLƏBƏ NÖMRƏSİ");
                dataGridView1.Columns.Add("Netice", "NƏTİCƏ");
                dataGridView1.Columns.Add("Kateqoriya", "KATEQORİYA");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // MaskedTextBox'lardan değerleri alıyoruz (Boş bırakılırsa 0 kabul edilir)
                double sf1 = string.IsNullOrWhiteSpace(mtbSF1.Text) ? 0 : Convert.ToDouble(mtbSF1.Text);
                double sf2 = string.IsNullOrWhiteSpace(mtbSF2.Text) ? 0 : Convert.ToDouble(mtbSF2.Text);
                double ff = string.IsNullOrWhiteSpace(mtbFF.Text) ? 0 : Convert.ToDouble(mtbFF.Text);
                double lab = string.IsNullOrWhiteSpace(mtbLAB.Text) ? 0 : Convert.ToDouble(mtbLAB.Text);
                double final = string.IsNullOrWhiteSpace(mtbFINAL.Text) ? 0 : Convert.ToDouble(mtbFINAL.Text);

                // Toplam puan hesabı (Maksimum 100)
                double umumiBal = sf1 + sf2 + ff + lab + final;

                // Harf notu / Harf kategorisi belirleme
                string kateqoriya = "";
                if (umumiBal >= 91 && umumiBal <= 100) kateqoriya = "A (Əla)";
                else if (umumiBal >= 81) kateqoriya = "B (Çox Yaxşı)";
                else if (umumiBal >= 71) kateqoriya = "C (Yaxşı)";
                else if (umumiBal >= 61) kateqoriya = "D (Kafi)";
                else if (umumiBal >= 51) kateqoriya = "E (Qənaətbəxş)";
                else kateqoriya = "F (Kəsildi)";

                // Sonuçları DataGridView tablosuna ekleme
                dataGridView1.Rows.Add(txtAdSoyad.Text, mtbTelebeNo.Text, umumiBal, kateqoriya);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
     
        {
            txtAdSoyad.Clear();
            mtbTelebeNo.Clear();
            mtbSF1.Clear();
            mtbSF2.Clear();
            mtbFF.Clear();
            mtbLAB.Clear();
            mtbFINAL.Clear();
        }
    }
    }
}

