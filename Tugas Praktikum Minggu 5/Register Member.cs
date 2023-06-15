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
    public partial class Register_Member : Form
    {
        public Register_Member()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "" && tbNama.Text != "" && tbAlamat.Text != "" && (rbBronze.Checked || rbSilver.Checked || rbGold.Checked)) {
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
                    string jenis = "";
                    foreach (Control c in gbInput.Controls)
                    {
                        if (c is RadioButton)
                        {
                            RadioButton rb = (RadioButton)c;
                            if (rb.Checked)
                            {
                                jenis = rb.Text;
                            }
                        }
                    }
                    string[] member = { tbUsername.Text, tbPassword.Text, tbNama.Text, tbAlamat.Text, jenis, "0" };
                    Form1.Member.Add(member);
                    ChangeIsi();
                    SaveXML();
                }
            }
            else
            {
                if (tbUsername.Text == "")
                {
                    MessageBox.Show("Username Belum Diisi");
                }
                if (tbPassword.Text == "")
                {
                    MessageBox.Show("Password Belum Diisi");
                }
                if (tbNama.Text == "")
                {
                    MessageBox.Show("Nama Belum Diisi");
                }
                if (tbAlamat.Text == "")
                {
                    MessageBox.Show("Alamat Belum Diisi");
                }
            }
            rbGold.Checked = true;
        }

        private void Register_Member_Load(object sender, EventArgs e)
        {

            bool KosongMember;
            do
            {
                KosongMember = false;
                Form1.Member.Clear();
                int ctr = -1;
                if (Form1.FilePathMember != null)
                {
                    XmlTextReader reader = new XmlTextReader(Form1.FilePathMember);
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
                                    Form1.Member.Add(new string[6]);
                                }
                                break;
                            case XmlNodeType.Text:
                                if (nodeName == "Username_Member")
                                {
                                    Form1.Member[ctr][0] = reader.Value;
                                }
                                else if (nodeName == "Password_Member")
                                {
                                    Form1.Member[ctr][1] = reader.Value;
                                }
                                else if (nodeName == "Nama_Member")
                                {
                                    Form1.Member[ctr][2] = reader.Value;
                                }
                                else if (nodeName == "Alamat_Member")
                                {
                                    Form1.Member[ctr][3] = reader.Value;
                                }
                                else if (nodeName == "Jenis_Member")
                                {
                                    Form1.Member[ctr][4] = reader.Value;
                                }
                                else if (nodeName == "Poin")
                                {
                                    Form1.Member[ctr][5] = reader.Value;
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
                    of.Title = "Open XML Member";
                    of.Filter = "XML Files|*.xml";
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        Form1.FilePathMember = of.FileName;
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
                                        Form1.Member.Add(new string[6]);
                                    }
                                    break;
                                case XmlNodeType.Text:
                                    if (nodeName == "Username_Member")
                                    {
                                        Form1.Member[ctr][0] = reader.Value;
                                    }
                                    else if (nodeName == "Password_Member")
                                    {
                                        Form1.Member[ctr][1] = reader.Value;
                                    }
                                    else if (nodeName == "Nama_Member")
                                    {
                                        Form1.Member[ctr][2] = reader.Value;
                                    }
                                    else if (nodeName == "Alamat_Member")
                                    {
                                        Form1.Member[ctr][3] = reader.Value;
                                    }
                                    else if (nodeName == "Jenis_Member")
                                    {
                                        Form1.Member[ctr][4] = reader.Value;
                                    }
                                    else if (nodeName == "Poin")
                                    {
                                        Form1.Member[ctr][5] = reader.Value;
                                    }
                                    break;
                            }
                        }
                        reader.Close();
                    }
                }
                for (int i = 0; i < Form1.Member.Count; i++)
                {
                    for (int j = 0; j < Form1.Member[i].Count(); j++)
                    {
                        if (Form1.Member[i][j] == null)
                        {
                            KosongMember = true;
                        }
                    }
                }
                if (KosongMember)
                {
                    MessageBox.Show("XML Load Salah / Tidak Ada Data");
                    Form1.FilePathMember = null;
                }
                else
                {
                    if (ctr + 1 > 0)
                    {
                        MessageBox.Show("Member Loaded : " + (ctr + 1) + " Member");
                    }
                }
            } while (KosongMember);
            ChangeIsi();
        }

        private void ChangeIsi()
        {
            lbMember.Items.Clear();
            for (int i = 0; i < Form1.Member.Count; i++)
            {
                lbMember.Items.Add(Form1.Member[i][0]);
            }
        }

        private void lbMember_Click(object sender, EventArgs e)
        {
            int idxPilih = lbMember.SelectedIndex;
            if (idxPilih != -1)
            {
                lblUsername.Text = Form1.Member[idxPilih][0];
                lblPassword.Text = Form1.Member[idxPilih][1];
                lblNama.Text = Form1.Member[idxPilih][2];
                lblAlamat.Text = Form1.Member[idxPilih][3];
                lblJenis.Text = Form1.Member[idxPilih][4];
            }
        }

        private void Register_Member_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveXML();
        }

        private void SaveXML()
        {
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
            else
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.InitialDirectory = Application.StartupPath;
                sf.Title = "Save XML Member";
                sf.Filter = "XML Files|*.xml";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    XmlWriterSettings writerset = new XmlWriterSettings();
                    writerset.Indent = true;

                    XmlWriter writer = XmlWriter.Create(sf.FileName, writerset);
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
                    MessageBox.Show("Member Saved : " + (Form1.Member.Count) + " Member");
                }
            }
            for (int i = 0; i < Form1.Member.Count; i++)
            {
                Form1.Cart.Add(new List<string[]>());
            }
        }
    }
}
