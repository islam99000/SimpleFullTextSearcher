namespace SimpleFullTextSearcher
    
    
{
    using System.IO;
    using System.Windows.Forms;
    using UglyToad.PdfPig;
    public partial class Form1 : Form
    {
        private string filecontent = "";
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog islam = new OpenFileDialog();
            islam.Filter = "Text Files (*.txt)|*.txt|PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";



            if (islam.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = islam.FileName;
                textBox3.Clear();
                string fileExtension = Path.GetExtension(islam.FileName);
                if (fileExtension == ".txt")
                {

                    using (StreamReader sr = new StreamReader(islam.FileName))
                    {
                        filecontent = sr.ReadToEnd();
                    }
                }
                else if (fileExtension == ".pdf")
                {
                    using (PdfDocument document = PdfDocument.Open(islam.FileName))
                    {
                        filecontent = string.Join(Environment.NewLine,document.GetPages().Select(page => page.Text));
                    }
                }
                else
                {
                    MessageBox.Show("الملف غير مدعوم", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text;
            if (string.IsNullOrEmpty(filecontent))
            {
                MessageBox.Show("يرجي فتح الملف اولا", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                using (StringReader sr = new StringReader(filecontent))

                {
                    string line;
                    bool found = false;
                   textBox3.Clear();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(search))
                    {
                        textBox3.AppendText(line + Environment.NewLine);
                        found = true;
                    }
                }

                    if (found)
                    {
                      MessageBox.Show("تم العثور علي النص", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                      MessageBox.Show("لم يتم العثور علي النص", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    

                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            filecontent = "";
            textBox2.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
