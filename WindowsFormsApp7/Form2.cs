using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2(string targetData)
        {
            InitializeComponent();

            dataGridView1.Rows[0].Cells[0].Value = targetData;
        }
    }
}
