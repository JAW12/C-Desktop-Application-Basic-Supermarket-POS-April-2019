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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNama.SelectedIndex != -1)
            {
                idxPilih = cbNama.SelectedIndex;
                lblHarga.Text = "Rp " + Form1.Barang[idxPilih][3].ToString();
            }
        }
        int idxPilih;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            idxPilih = cbNama.SelectedIndex;
            if (idxPilih != -1)
            {
                int idxAda = -1;
                for (int i = 0; i < Form1.Cart[Form1.idxMember].Count; i++)
                {
                    if (cbNama.Text == Form1.Cart[Form1.idxMember][i][1])
                    {
                        idxAda = i;
                        break;
                    }
                }
                if (idxAda != -1)
                {
                    if (int.Parse(Form1.Cart[Form1.idxMember][idxAda][2]) + nudJumlah.Value > int.Parse(Form1.Barang[idxPilih][4]) && nudJumlah.Value != 0)
                    {
                        MessageBox.Show("Barang " + Form1.Barang[idxPilih][1] + " Tidak Cukup Stock" + "\n" + Form1.Barang[idxPilih][1] + " Sisa : " + Form1.Barang[idxPilih][4]);
                    }
                    else if(nudJumlah.Value != 0)
                    {
                        Form1.Barang[idxPilih][4] = (int.Parse(Form1.Barang[idxPilih][4]) - nudJumlah.Value).ToString();
                        Form1.Cart[Form1.idxMember][idxAda][2] = (int.Parse(Form1.Cart[Form1.idxMember][idxAda][2]) + nudJumlah.Value).ToString();
                        Form1.Cart[Form1.idxMember][idxAda][4] = (int.Parse(Form1.Cart[Form1.idxMember][idxAda][2]) * int.Parse(Form1.Cart[Form1.idxMember][idxAda][3])).ToString();
                        SaveXML();
                    }
                    else
                    {
                        MessageBox.Show("Inputan Jumlah Harus > 0");
                    }
                }
                else
                {
                    if(nudJumlah.Value <= int.Parse(Form1.Barang[idxPilih][4]) && nudJumlah.Value != 0)
                    {
                        Form1.Barang[idxPilih][4] = (int.Parse(Form1.Barang[idxPilih][4]) - nudJumlah.Value).ToString();
                        string[] cart = { Form1.Barang[idxPilih][0], Form1.Barang[idxPilih][1], nudJumlah.Value.ToString(), Form1.Barang[idxPilih][3], (int.Parse(nudJumlah.Value.ToString()) * int.Parse(Form1.Barang[idxPilih][3])).ToString() };
                        Form1.Cart[Form1.idxMember].Add(cart);
                        SaveXML();
                    }
                    else if(nudJumlah.Value != 0)
                    {
                        MessageBox.Show("Barang " + Form1.Barang[idxPilih][1] + " Tidak Cukup Stock" + "\n" + Form1.Barang[idxPilih][1] + " Sisa : " + Form1.Barang[idxPilih][4]);
                    }
                    else
                    {
                        MessageBox.Show("Inputan Jumlah Harus > 0");
                    }
                }
            }
            cbNama.SelectedIndex = -1;
            lblHarga.Text = "Rp 0";
            nudJumlah.Value = 0;
            ChangeIsi();
            //LoadXML(false);
        }

        private void ChangeIsi()
        {
            cbNama.Items.Clear();
            for(int i = 0; i < Form1.Barang.Count; i++)
            {
                cbNama.Items.Add(Form1.Barang[i][1]);
            }
            lbCart.Items.Clear();
            for(int i = 0; i < Form1.Cart[Form1.idxMember].Count; i++)
            {
                lbCart.Items.Add(Form1.Cart[Form1.idxMember][i][1] + " - " + Form1.Cart[Form1.idxMember][i][2]);
            }
            lblNama.Text = Form1.Member[Form1.idxMember][2];
            lblAlamat.Text = Form1.Member[Form1.idxMember][3];
            lblJenis.Text = Form1.Member[Form1.idxMember][4];
            lblPoin.Text = Form1.Member[Form1.idxMember][5];
            lblUsername.Text = Form1.Member[Form1.idxMember][0];
            tbNama.Text = Form1.Member[Form1.idxMember][2];
            tbPassword.Text = Form1.Member[Form1.idxMember][1];
            tbAlamat.Text = Form1.Member[Form1.idxMember][3];
        }

        private void Member_Load(object sender, EventArgs e)
        {
            if(Form1.Cart.Count < Form1.Member.Count)
            {
                for(int i =0; i < Form1.Member.Count; i++)
                {
                    Form1.Cart.Add(new List<string[]>());
                }
            }
            gbEdit.Visible = false;
            ChangeIsi();
            LoadXML(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(tbNama.Text != "" && tbPassword.Text != "" && tbAlamat.Text != "")
            {
                Form1.Member[Form1.idxMember][2] = tbNama.Text;
                Form1.Member[Form1.idxMember][1] = tbPassword.Text;
                Form1.Member[Form1.idxMember][3] = tbAlamat.Text;
                ChangeIsi();
                SaveXML();
                gbEdit.Visible = false;
            }
            else
            {
                if(tbNama.Text == "")
                {
                    MessageBox.Show("Nama Lengkap Tidak Boleh Kosong");
                }
                if(tbPassword.Text == "")
                {
                    MessageBox.Show("Password Tidak Boleh Kosong");
                }
                if(tbAlamat.Text == "")
                {
                    MessageBox.Show("Alamat Tidak Boleh Kosong");
                }
            }
            
        }

        private void Member_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveXML();
        }

        private void LoadXML(bool Notif)
        {
            bool KosongBarang;
            do
            {
                KosongBarang = false;
                Form1.Barang.Clear();
                int ctr = -1;
                if (Form1.FilePathBarang != null)
                {
                    XmlTextReader reader = new XmlTextReader(Form1.FilePathBarang);
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
                                    Form1.Barang.Add(new string[5]);
                                }
                                break;
                            case XmlNodeType.Text:
                                if (nodeName == "Kode_Barang")
                                {
                                    Form1.Barang[ctr][0] = reader.Value;
                                }
                                else if (nodeName == "Nama_Barang")
                                {
                                    Form1.Barang[ctr][1] = reader.Value;
                                }
                                else if (nodeName == "Jenis_Barang")
                                {
                                    Form1.Barang[ctr][2] = reader.Value;
                                }
                                else if (nodeName == "Harga_Barang")
                                {
                                    Form1.Barang[ctr][3] = reader.Value;
                                }
                                else if (nodeName == "Jumlah_Barang")
                                {
                                    Form1.Barang[ctr][4] = reader.Value;
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
                    of.Title = "Open XML Barang";
                    of.Filter = "XML Files|*.xml";
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        Form1.FilePathBarang = of.FileName;
                        XmlTextReader reader = new XmlTextReader(of.FileName);
                        string nodeName = "";
                        ctr = -1;
                        while (reader.Read())
                        {
                            switch (reader.NodeType)
                            {
                                case XmlNodeType.Element:
                                    nodeName = reader.Name;
                                    if (nodeName == "Data")
                                    {
                                        ctr++;
                                        Form1.Barang.Add(new string[5]);
                                    }
                                    break;
                                case XmlNodeType.Text:
                                    if (nodeName == "Kode_Barang")
                                    {
                                        Form1.Barang[ctr][0] = reader.Value;
                                    }
                                    else if (nodeName == "Nama_Barang")
                                    {
                                        Form1.Barang[ctr][1] = reader.Value;
                                    }
                                    else if (nodeName == "Jenis_Barang")
                                    {
                                        Form1.Barang[ctr][2] = reader.Value;
                                    }
                                    else if (nodeName == "Harga_Barang")
                                    {
                                        Form1.Barang[ctr][3] = reader.Value;
                                    }
                                    else if (nodeName == "Jumlah_Barang")
                                    {
                                        Form1.Barang[ctr][4] = reader.Value;
                                    }
                                    break;
                            }
                        }
                        reader.Close();
                    }
                }
                for (int i = 0; i < Form1.Barang.Count; i++)
                {
                    for (int j = 0; j < Form1.Barang[i].Count(); j++)
                    {
                        if (Form1.Barang[i][j] == null)
                        {
                            KosongBarang = true;
                        }
                    }
                }
                
                if (KosongBarang)
                {
                    if (Notif)
                    {
                        MessageBox.Show("XML Load Salah / Tidak Ada Data");
                    }
                    Form1.FilePathBarang = null;
                }
                else
                {
                    if (Notif)
                    {
                        if (ctr + 1 > 0)
                        {
                            MessageBox.Show("Barang Loaded : " + (ctr + 1) + " Barang");
                        }
                    }    
                }
            } while (KosongBarang);
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
            else
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.InitialDirectory = Application.StartupPath;
                sf.Title = "Save XML Barang";
                sf.Filter = "XML Files|*.xml";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Form1.FilePathBarang = sf.FileName;
                    XmlWriterSettings writerset = new XmlWriterSettings();
                    writerset.Indent = true;

                    XmlWriter writer = XmlWriter.Create(sf.FileName, writerset);
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
                    MessageBox.Show("Barang Saved : " + (Form1.Barang.Count) + " Barang");
                }
            }
        }
    }
}
