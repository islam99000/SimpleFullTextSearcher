namespace SimpleFullTextSearcher
    
    
{
    using System.IO;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string filecontent = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog islam = new OpenFileDialog();
            islam.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (islam.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = islam.FileName;
                filecontent = File.ReadAllText(islam.FileName);
                listBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text;


            if (string.IsNullOrEmpty(filecontent))
            {
                MessageBox.Show("يرجى فتح ملف أولاً.");
                return;
            }
            if (filecontent.Contains(search))
            {
                var foundLines = filecontent.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                           .Where(line => line.Contains(search))
                                           .ToList();

                foreach (var line in foundLines)
                {
                    listBox1.Items.Add(line); // إضافة الأسطر التي تحتوي على النص
                }

                MessageBox.Show("تم العثور على النص!");
            }
            else
            {
                MessageBox.Show("النص غير موجود في الملف.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            filecontent = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
