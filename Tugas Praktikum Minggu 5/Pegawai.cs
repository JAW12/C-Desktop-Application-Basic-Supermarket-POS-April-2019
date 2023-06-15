using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Praktikum_Minggu_5
{
    public partial class Pegawai : Form
    {
        public Pegawai()
        {
            InitializeComponent();
        }

        private void inputPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input_Penjualan inp = new Input_Penjualan();
            inp.MdiParent = this;
            inp.Show();
        }

        private void registerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Member regm = new Register_Member();
            regm.MdiParent = this;
            regm.Show();
        }
    }
}
