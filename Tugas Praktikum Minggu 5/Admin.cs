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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void inventoryBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_Barang inv = new Inventory_Barang();
            inv.MdiParent = this;
            inv.Show();
        }

        private void registerPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Pegawai regp = new Register_Pegawai();
            regp.MdiParent = this;
            regp.Show();
        }
    }
}
