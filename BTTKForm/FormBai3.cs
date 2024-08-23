using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTKForm
{
    public partial class FormBai3 : Form
    {
        List<String> list = new List<String>(); 
        public FormBai3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormBai3_Load(object sender, EventArgs e)
        {

        }

        private void btnThemtu_Click(object sender, EventArgs e)
        {
            var tu =txtTuMoi.Text;
            var nghia= txtNghiaTu.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);

            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaTu.Text = "";
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            textBox1.Text = nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;
            txtNghiaTu.Text = list[stt];
        }
    }
}
