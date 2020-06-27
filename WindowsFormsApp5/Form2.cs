using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void вГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Подтверждение действия", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void обратнаяСвязьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xn----htbcfgnhaz1b.xn--p1ai/");
            //открывает сайт IT-College
        }

        private void помощьАвторуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void оценитьРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void вернутьсяНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
