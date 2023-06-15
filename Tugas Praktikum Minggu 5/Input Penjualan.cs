using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tugas_Praktikum_Minggu_5
{
    public partial class Input_Penjualan : Form
    {
        public Input_Penjualan()
        {
            InitializeComponent();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            Form1.Pegawai[Form1.idxPegawai][2] = (int.Parse(Form1.Pegawai[Form1.idxPegawai][2]) + 1).ToString();
            Form1.Pegawai[Form1.idxPegawai][3] = (int.Parse(Form1.Pegawai[Form1.idxPegawai][3]) + Total).ToString();
            if(idxPilih != -1)
            {
                Form1.Member[idxPilih][5] = (int.Parse(Form1.Member[idxPilih][5]) + Poin).ToString();
                Form1.Cart[idxPilih] = new List<string[]>();
                SaveXML();
            }
            Diskon = 0;
            Total = 0;
            lblDiskon.Text = "Rp " + Diskon.ToString();
            lblTotal.Text = "Rp " + Total.ToString();
            Poin = 0;
            cbCustomer.Text = "";
            cbCustomer.SelectedIndex = -1;
            ChangeCustomer();
            ChangeIsi();
        }


        int idxPilih = -1;
        int Subtotal = 0;
        private void ChangeIsi()
        {
            lbSedia.Items.Clear();
            for (int i = 0; i < Form1.Barang.Count(); i++)
            {
                if (int.Parse(Form1.Barang[i][4]) > 0)
                {
                    lbSedia.Items.Add(Form1.Barang[i][0] + " - " + Form1.Barang[i][1] + " - " + Form1.Barang[i][3]);
                }
            }

            Subtotal = 0;
            lbBarang.Items.Clear();
            if(idxPilih != -1)
            {
                for(int i = 0; i < Form1.Cart[idxPilih].Count; i++)
                {
                    lbBarang.Items.Add(Form1.Cart[idxPilih][i][0] + " - " + Form1.Cart[idxPilih][i][1] + " - " + Form1.Cart[idxPilih][i][3] + " - " + Form1.Cart[idxPilih][i][2] + " - " + Form1.Cart[idxPilih][i][4]);
                    Subtotal += int.Parse(Form1.Cart[idxPilih][i][4]);
                }
            }

            lblDiskon.Text = "Rp " + Diskon.ToString();
            lblTotal.Text = "Rp " + Total.ToString();
        }

        private void ChangeCustomer()
        {
            cbCustomer.Items.Clear();
            for(int i =0; i< Form1.Member.Count; i++)
            {
                cbCustomer.Items.Add(Form1.Member[i][0]);
            }
        }
        public static int Diskon;
        public static int Total;
        public static int Poin;

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diskon = 0;
            Poin = 0;
            Total = 0;
            if (cbCustomer.SelectedIndex != -1)
            {
                idxPilih = cbCustomer.SelectedIndex;
            }
            if(idxPilih != -1)
            {
                ChangeIsi();
                if (Form1.Member[idxPilih][4] == "Gold")
                {
                    Diskon = (int)(Subtotal * 0.25);
                    Poin += 250;
                }
                else if (Form1.Member[idxPilih][4] == "Silver")
                {
                    Diskon = (int)(Subtotal * 0.15);
                    Poin += 150;
                }
                else if (Form1.Member[idxPilih][4] == "Bronze")
                {
                    Diskon = (int)(Subtotal * 0.05);
                    Poin += 50;
                }
                Total = Subtotal - Diskon;
                lblDiskon.Text = "Rp " + Diskon.ToString();
                lblTotal.Text = "Rp " + Total.ToString();
                Poin += (int)(0.01 * Total);
                ChangeIsi();
            }
        }

        private void Input_Penjualan_Load(object sender, EventArgs e)
        {
            if (Form1.Cart.Count < Form1.Member.Count)
            {
                for (int i = 0; i < Form1.Member.Count; i++)
                {
                    Form1.Cart.Add(new List<string[]>());
                }
            }
            ChangeIsi();
            ChangeCustomer();
        }

        private void Input_Penjualan_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveXML();
        }

        private void SaveXML()
        {
            if (Form1.FilePathBarang != null)
            {
                XmlWriterSettings writerset = new XmlWriterSettings();
                writerset.Indent = true;

                XmlWriter writer = XmlWriter.Create(Form1.FilePathBarang, writerset);
                writer.WriteStartDocument();
                writer.WriteStartElement("Barang");
                for (int i = 0; i < Form1.Barang.Count; i++)
                {
                    writer.WriteStartElement("Data");
                    writer.WriteElementString("Kode_Barang", Form1.Barang[i][0]);
                    writer.WriteElementString("Nama_Barang", Form1.Barang[i][1]);
                    writer.WriteElementString("Jenis_Barang", Form1.Barang[i][2]);
                    writer.WriteElementString("Harga_Barang", Form1.Barang[i][3]);
                    writer.WriteElementString("Jumlah_Barang", Form1.Barang[i][4]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show("Barang Replaced : " + (Form1.Barang.Count) + " Barang");
            }

            if (Form1.FilePathPegawai != null)
            {
                XmlWriterSettings writerset = new XmlWriterSettings();
                writerset.Indent = true;

                XmlWriter writer = XmlWriter.Create(Form1.FilePathPegawai, writerset);
                writer.WriteStartDocument();
                writer.WriteStartElement("Pegawai");
                for (int i = 0; i < Form1.Pegawai.Count; i++)
                {
                    writer.WriteStartElement("Data");
                    writer.WriteElementString("Username_Pegawai", Form1.Pegawai[i][0]);
                    writer.WriteElementString("Password_Pegawai", Form1.Pegawai[i][1]);
                    writer.WriteElementString("Jumlah_Layanan", Form1.Pegawai[i][2]);
                    writer.WriteElementString("Total_Penjualan", Form1.Pegawai[i][3]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show("Pegawai Replaced : " + (Form1.Pegawai.Count) + " Pegawai");
            }

            if (Form1.FilePathMember != null)
            {
                XmlWriterSettings writerset = new XmlWriterSettings();
                writerset.Indent = true;

                XmlWriter writer = XmlWriter.Create(Form1.FilePathMember, writerset);
                writer.WriteStartDocument();
                writer.WriteStartElement("Member");
                for (int i = 0; i < Form1.Member.Count; i++)
                {
                    writer.WriteStartElement("Data");
                    writer.WriteElementString("Nama_Member", Form1.Member[i][2]);
                    writer.WriteElementString("Username_Member", Form1.Member[i][0]);
                    writer.WriteElementString("Password_Member", Form1.Member[i][1]);
                    writer.WriteElementString("Alamat_Member", Form1.Member[i][3]);
                    writer.WriteElementString("Jenis_Member", Form1.Member[i][4]);
                    writer.WriteElementString("Poin", Form1.Member[i][5]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show("Member Replaced : " + (Form1.Member.Count) + " Member");
            }
        }
    }
}
