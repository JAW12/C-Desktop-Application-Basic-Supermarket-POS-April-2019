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
    public partial class Register_Pegawai : Form
    {
        public Register_Pegawai()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text != "" && tbPassword.Text != "")
            {
                bool adaPegawai = false;
                bool adaMember = false;
                for (int i = 0; i < Form1.Pegawai.Count; i++)
                {
                    if (tbUsername.Text == Form1.Pegawai[i][0])
                    {
                        adaPegawai = true;
                    }
                }
                for (int i = 0; i < Form1.Member.Count; i++)
                {
                    if (tbUsername.Text == Form1.Member[i][0])
                    {
                        adaMember = true;
                    }
                }
                if (adaPegawai || adaMember)
                {
                    if (adaPegawai)
                    {
                        MessageBox.Show("Username Sudah Terdaftar di Pegawai");
                    }
                    else if (adaMember)
                    {
                        MessageBox.Show("Username Sudah Terdaftar di Member");
                    }
                }
                else
                {
                    string[] pegawai = { tbUsername.Text, tbPassword.Text, "0", "0" };
                    Form1.Pegawai.Add(pegawai);
                    ChangeIsi();
                    SaveXML();
                }
            }
            else
            {
                if(tbUsername.Text == "")
                {
                    MessageBox.Show("Username Belum Diisi");
                }
                if (tbPassword.Text == "")
                {
                    MessageBox.Show("Password Belum Diisi");
                }
            }
            
        }

        private void ChangeIsi()
        {
            lbPegawai.Items.Clear();
            for(int i = 0; i < Form1.Pegawai.Count; i++)
            {
                lbPegawai.Items.Add(Form1.Pegawai[i][0]);
            }
        }

        private void lbPegawai_Click(object sender, EventArgs e)
        {
            int idxPilih = lbPegawai.SelectedIndex;
            if(idxPilih != -1)
            {
                lblUsername.Text = Form1.Pegawai[idxPilih][0];
                lblPassword.Text = Form1.Pegawai[idxPilih][1];
                lblJumlah.Text = Form1.Pegawai[idxPilih][2];
                lblTotal.Text = "Rp " + Form1.Pegawai[idxPilih][3];
            }
        }

        private void Register_Pegawai_Load(object sender, EventArgs e)
        {
            bool KosongPegawai;
            do
            {
                int ctr = -1;
                KosongPegawai = false;
                Form1.Pegawai.Clear();
                if (Form1.FilePathPegawai != null)
                {
                    XmlTextReader reader = new XmlTextReader(Form1.FilePathPegawai);
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
                                    Form1.Pegawai.Add(new string[4]);
                                }
                                break;
                            case XmlNodeType.Text:
                                if (nodeName == "Username_Pegawai")
                                {
                                    Form1.Pegawai[ctr][0] = reader.Value;
                                }
                                else if (nodeName == "Password_Pegawai")
                                {
                                    Form1.Pegawai[ctr][1] = reader.Value;
                                }
                                else if (nodeName == "Jumlah_Layanan")
                                {
                                    Form1.Pegawai[ctr][2] = reader.Value;
                                }
                                else if (nodeName == "Total_Penjualan")
                                {
                                    Form1.Pegawai[ctr][3] = reader.Value;
                                }
                                break;
                        }
                    }
                    reader.Close();
                }
                else
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.InitialDirectory = Application.StartupPath;
                    of.Title = "Open XML Pegawai";
                    of.Filter = "XML Files|*.xml";
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        Form1.FilePathPegawai = of.FileName;
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
                                        Form1.Pegawai.Add(new string[4]);
                                    }
                                    break;
                                case XmlNodeType.Text:
                                    if (nodeName == "Username_Pegawai")
                                    {
                                        Form1.Pegawai[ctr][0] = reader.Value;
                                    }
                                    else if (nodeName == "Password_Pegawai")
                                    {
                                        Form1.Pegawai[ctr][1] = reader.Value;
                                    }
                                    else if (nodeName == "Jumlah_Layanan")
                                    {
                                        Form1.Pegawai[ctr][2] = reader.Value;
                                    }
                                    else if (nodeName == "Total_Penjualan")
                                    {
                                        Form1.Pegawai[ctr][3] = reader.Value;
                                    }
                                    break;
                            }
                        }
                        reader.Close();
                    }
                }
                for (int i = 0; i < Form1.Pegawai.Count; i++)
                {
                    for (int j = 0; j < Form1.Pegawai[i].Count(); j++)
                    {
                        if (Form1.Pegawai[i][j] == null)
                        {
                            KosongPegawai = true;
                        }
                    }
                }
                if (KosongPegawai)
                {
                    MessageBox.Show("XML Load Salah / Tidak Ada Data");
                    Form1.FilePathPegawai = null;
                }
                else
                {
                    if (ctr + 1 > 0)
                    {
                        MessageBox.Show("Pegawai Loaded : " + (ctr + 1) + " Pegawai");
                    }
                }
            } while (KosongPegawai);
            ChangeIsi();
        }

        private void Register_Pegawai_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveXML();
        }

        private void SaveXML()
        {
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
            else
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.InitialDirectory = Application.StartupPath;
                sf.Title = "Save XML Pegawai";
                sf.Filter = "XML Files|*.xml";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    XmlWriterSettings writerset = new XmlWriterSettings();
                    writerset.Indent = true;

                    XmlWriter writer = XmlWriter.Create(sf.FileName, writerset);
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
                    MessageBox.Show("Pegawai Saved : " + (Form1.Pegawai.Count) + " Pegawai");
                }
            }
        }
    }
}
