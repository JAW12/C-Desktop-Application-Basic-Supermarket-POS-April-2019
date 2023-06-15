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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string FilePathPegawai;
        // Pegawai [Nomer Pegawai]
        // 0 -> Username
        // 1 -> Password
        // 2 -> Jumlah Layanan
        // 3 -> Total Penjualan
        public static List<string[]> Pegawai = new List<string[]>();
        public static int idxPegawai = -1;

        public static string FilePathMember;
        // Member [Nomer Member]
        // 0 -> Username
        // 1 -> Password
        // 2 -> Nama
        // 3 -> Alamat
        // 4 -> Jenis Member
        // 5 -> Poin Member
        public static List<string[]> Member = new List<string[]>();
        public static int idxMember = -1;

        public static string FilePathBarang;
        // Barang [Nomer Barang]
        // 0 -> Kode Barang
        // 1 -> Nama Barang
        // 2 -> Jenis Barang
        // 3 -> Harga Barang
        // 4 -> Stok Barang
        public static List<string[]> Barang = new List<string[]>();

        // Cart [Nomer Member] [Nomer Transaksi]
        // 0 -> Kode Barang
        // 1 -> Nama Barang
        // 2 -> Jumlah Barang
        // 3 -> Harga Satuan
        // 4 -> Sub Total
        public static List<List<string[]>> Cart = new List<List<string[]>>();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "admin" && tbPassword.Text == "admin")
            {
                Admin adm = new Admin();
                adm.Show();
            }
            else
            {
                idxPegawai = -1;
                for (int i = 0; i < Pegawai.Count; i++)
                {
                    if (tbUsername.Text == Pegawai[i][0])
                    {
                        idxPegawai = i;
                    }
                }
                if (idxPegawai != -1)
                {
                    if (tbPassword.Text == Pegawai[idxPegawai][1])
                    {
                        Pegawai pegawai = new Pegawai();
                        pegawai.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Sebagai Pegawai " + tbUsername.Text + " Salah");
                    }
                }

                idxMember = -1;
                for (int i = 0; i < Member.Count; i++)
                {
                    if (tbUsername.Text == Member[i][0])
                    {
                        idxMember = i;
                    }
                }
                if (idxMember != -1)
                {
                    if (tbPassword.Text == Member[idxMember][1])
                    {
                        Member member = new Member();
                        member.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Sebagai Member " + tbUsername.Text + " Salah");
                    }
                }

                if (idxPegawai == -1 && idxMember == -1)
                {
                    MessageBox.Show("Tidak Ada User Pegawai & Member Yang Terdaftar Sebagai " + tbUsername.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pegawai.Clear();
            timer1.Start();
        }

        private void LoadXMLPegawai()
        {
            bool KosongPegawai;
            do
            {
                KosongPegawai = false;
                Pegawai.Clear();
                OpenFileDialog of = new OpenFileDialog();
                of.InitialDirectory = Application.StartupPath;
                of.Title = "Open XML Pegawai";
                of.Filter = "XML Files|*.xml";

                if (of.ShowDialog() == DialogResult.OK)
                {
                    int ctr = -1;
                    FilePathPegawai = of.FileName;
                    XmlTextReader reader = new XmlTextReader(of.FileName);
                    string nodeName = "";
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                nodeName = reader.Name;
                                if (nodeName == "Data")
                                {
                                    ctr++;
                                    Pegawai.Add(new string[4]);
                                }
                                break;
                            case XmlNodeType.Text:
                                if (nodeName == "Username_Pegawai")
                                {
                                    Pegawai[ctr][0] = reader.Value;
                                }
                                else if (nodeName == "Password_Pegawai")
                                {
                                    Pegawai[ctr][1] = reader.Value;
                                }
                                else if (nodeName == "Jumlah_Layanan")
                                {
                                    Pegawai[ctr][2] = reader.Value;
                                }
                                else if (nodeName == "Total_Penjualan")
                                {
                                    Pegawai[ctr][3] = reader.Value;
                                }
                                break;
                        }
                    }
                    reader.Close();

                    for (int i = 0; i < Pegawai.Count; i++)
                    {
                        for (int j = 0; j < Pegawai[i].Count(); j++)
                        {
                            if (Pegawai[i][j] == null)
                            {
                                KosongPegawai = true;
                            }
                        }
                    }
                    if (KosongPegawai)
                    {
                        MessageBox.Show("XML Load Salah / Tidak Ada Data");
                        FilePathPegawai = null;
                    }
                    else
                    {
                        MessageBox.Show("Pegawai Loaded : " + (ctr + 1) + " Pegawai");
                    }
                }
            } while (KosongPegawai);
        }
        private void btnLoadPegawai_Click(object sender, EventArgs e)
        {
            LoadXMLPegawai();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FilePathBarang != null)
            {
                btnLoadBarang.Visible = false;
            }
            else
            {
                btnLoadBarang.Visible = true;
            }
            if (FilePathPegawai != null)
            {
                btnLoadPegawai.Visible = false;
            }
            else
            {
                btnLoadPegawai.Visible = true;
            }
            if (FilePathMember != null)
            {
                btnLoadMember.Visible = false;
            }
            else
            {
                btnLoadMember.Visible = true;
            }
            if (FilePathBarang != null && FilePathPegawai != null && FilePathMember != null)
            {
                btnLoadSemua.Visible = false;
            }
            else
            {
                btnLoadSemua.Visible = true;
            }
        }

        private void LoadXMLBarang()
        {
            bool KosongBarang;
            do
            {
                KosongBarang = false;
                Barang.Clear();
                OpenFileDialog of = new OpenFileDialog();
                of.InitialDirectory = Application.StartupPath;
                of.Title = "Open XML Barang";
                of.Filter = "XML Files|*.xml";

                if (of.ShowDialog() == DialogResult.OK)
                {
                    int ctr = -1;
                    FilePathBarang = of.FileName;
                    XmlTextReader reader = new XmlTextReader(of.FileName);
                    string nodeName = "";
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                nodeName = reader.Name;
                                if (nodeName == "Data")
                                {
                                    ctr++;
                                    Barang.Add(new string[5]);
                                }
                                break;
                            case XmlNodeType.Text:
                                if (nodeName == "Kode_Barang")
                                {
                                    Barang[ctr][0] = reader.Value;
                                }
                                else if (nodeName == "Nama_Barang")
                                {
                                    Barang[ctr][1] = reader.Value;
                                }
                                else if (nodeName == "Jenis_Barang")
                                {
                                    Barang[ctr][2] = reader.Value;
                                }
                                else if (nodeName == "Harga_Barang")
                                {
                                    Barang[ctr][3] = reader.Value;
                                }
                                else if (nodeName == "Jumlah_Barang")
                                {
                                    Barang[ctr][4] = reader.Value;
                                }
                                break;
                        }
                    }
                    reader.Close();

                    for (int i = 0; i < Barang.Count; i++)
                    {
                        for (int j = 0; j < Barang[i].Count(); j++)
                        {
                            if (Barang[i][j] == null)
                            {
                                KosongBarang = true;
                            }
                        }
                    }
                    if (KosongBarang)
                    {
                        MessageBox.Show("XML Load Salah / Tidak Ada Data");
                        FilePathBarang = null;
                    }
                    else
                    {
                        MessageBox.Show("Barang Loaded : " + (ctr + 1) + " Barang");
                    }
                }
            } while (KosongBarang);
        }

        private void btnLoadBarang_Click(object sender, EventArgs e)
        {
            LoadXMLBarang();
        }

        private void LoadXMLMember()
        {
            bool KosongMember;
            do
            {
                KosongMember = false;
                Member.Clear();
                OpenFileDialog of = new OpenFileDialog();
                of.InitialDirectory = Application.StartupPath;
                of.Title = "Open XML Member";
                of.Filter = "XML Files|*.xml";

                if (of.ShowDialog() == DialogResult.OK)
                {
                    int ctr = -1;
                    FilePathMember = of.FileName;
                    XmlTextReader reader = new XmlTextReader(of.FileName);
                    string nodeName = "";
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                nodeName = reader.Name;
                                if (nodeName == "Data")
                                {
                                    ctr++;
                                    Member.Add(new string[6]);
                                }
                                break;
                            case XmlNodeType.Text:
                                if (nodeName == "Username_Member")
                                {
                                    Member[ctr][0] = reader.Value;
                                }
                                else if (nodeName == "Password_Member")
                                {
                                    Member[ctr][1] = reader.Value;
                                }
                                else if (nodeName == "Nama_Member")
                                {
                                    Member[ctr][2] = reader.Value;
                                }
                                else if (nodeName == "Alamat_Member")
                                {
                                    Member[ctr][3] = reader.Value;
                                }
                                else if (nodeName == "Jenis_Member")
                                {
                                    Member[ctr][4] = reader.Value;
                                }
                                else if (nodeName == "Poin")
                                {
                                    Member[ctr][5] = reader.Value;
                                }
                                break;
                        }
                    }
                    reader.Close();
                    for (int i = 0; i < Member.Count; i++)
                    {
                        for (int j = 0; j < Member[i].Count(); j++)
                        {
                            if (Member[i][j] == null)
                            {
                                KosongMember = true;
                            }
                        }
                    }
                    if (KosongMember)
                    {
                        MessageBox.Show("XML Load Salah / Tidak Ada Data");
                        FilePathMember = null;
                    }
                    else
                    {
                        MessageBox.Show("Member Loaded : " + (ctr + 1) + " Member");
                    }
                }
            } while (KosongMember);
        }

        private void btnLoadMember_Click(object sender, EventArgs e)
        {
            LoadXMLMember();
        }

        private void btnLoadSemua_Click(object sender, EventArgs e)
        {
            LoadXMLBarang();
            LoadXMLPegawai();
            LoadXMLMember();
        }
    }
}