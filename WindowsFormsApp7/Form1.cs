using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string targetData = dataGridView1.Rows[0].Cells[0].Value.ToString();

            Form2 fm2 = new Form2(targetData);
            fm2.Show();
        }
    }
}
