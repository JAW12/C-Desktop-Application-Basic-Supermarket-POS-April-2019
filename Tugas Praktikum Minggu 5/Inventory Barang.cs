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
    public partial class Inventory_Barang : Form
    {
        public Inventory_Barang()
        {
            InitializeComponent();
        }

        string kode_jenis;
        string nomor_urutan;

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            if(tbJenis.Text != "")
            {
                int jumlah = 1;
                for (int i = 0; i < Form1.Barang.Count; i++)
                {
                    if (kode_jenis == Form1.Barang[i][0].Substring(0,1))
                    {
                        jumlah++;
                    }
                }
                nomor_urutan = jumlah.ToString().PadLeft(2, '0');
                lblKode.Text = kode_jenis + nomor_urutan;
            }
        }

        private void tbJenis_TextChanged(object sender, EventArgs e)
        {
            if(tbJenis.Text.Length > 0)
            {
                kode_jenis = tbJenis.Text.Substring(0, 1).ToUpper();
                int jumlah = 1;
                for (int i = 0; i < Form1.Barang.Count; i++)
                {
                    if (kode_jenis == Form1.Barang[i][0].Substring(0,1))
                    {
                        jumlah++;
                    }
                }
                nomor_urutan = jumlah.ToString().PadLeft(2, '0');
                if(tbNama.Text != "")
                {
                    lblKode.Text = kode_jenis + nomor_urutan;
                }
            }
            else
            {
                lblKode.Text = "-";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "" && tbHarga.Text != "" && tbJenis.Text != "")
            {
                bool kembarnama = false;
                for(int i = 0; i < Form1.Barang.Count; i++)
                {
                    if(tbNama.Text == Form1.Barang[i][1])
                    {
                        kembarnama = true;
                    }
                }
                if (kembarnama)
                {
                    MessageBox.Show("Tidak Boleh Ada Nama Kembar");
                }
                else
                {
                    string[] brg = new string[] { lblKode.Text, tbNama.Text, tbJenis.Text, tbHarga.Text, "0" };
                    Form1.Barang.Add(brg);
                    SaveXML();
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox tb = (TextBox)c;
                        if (tb.Text == "")
                        {
                            MessageBox.Show(tb.Name.Substring(2, tb.Name.Length) + " Belum Diisi");
                        }
                    }
                }
            }
            tbNama.Clear();
            tbJenis.Clear();
            tbHarga.Clear();
            lblKode.Text = "-";
            changeIsi();
        }

        int idxInsert = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            idxInsert = cbKode.SelectedIndex;
            if(idxInsert != -1)
            {
                Form1.Barang[idxInsert][4] = (int.Parse(Form1.Barang[idxInsert][4]) + nudJumlah.Value).ToString();
            }
            cbKode.SelectedIndex = -1;
            nudJumlah.Value = 0;
            changeIsi();
            SaveXML();
        }

        private void changeIsi()
        {
            cbKode.Items.Clear();
            for (int i = 0; i < Form1.Barang.Count(); i++)
            {
                cbKode.Items.Add(Form1.Barang[i][0]);
            }
            lbList.Items.Clear();
            for (int i = 0; i < Form1.Barang.Count(); i++)
            {
                if (int.Parse(Form1.Barang[i][4]) > 0)
                {
                    lbList.Items.Add(Form1.Barang[i][0] + " - " + Form1.Barang[i][1] + " - " + Form1.Barang[i][2] + " - " + Form1.Barang[i][3] + " - " + Form1.Barang[i][4]);
                }
            }
            lbHabis.Items.Clear();
            for (int i = 0; i < Form1.Barang.Count(); i++)
            {
                if (int.Parse(Form1.Barang[i][4]) == 0)
                {
                    lbHabis.Items.Add(Form1.Barang[i][0] + " - " + Form1.Barang[i][1] + " - " + Form1.Barang[i][2] + " - " + Form1.Barang[i][3] + " - " + Form1.Barang[i][4]);
                }
            }
        }

        private void Inventory_Barang_Load(object sender, EventArgs e)
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
                    MessageBox.Show("XML Load Salah / Tidak Ada Data");
                    Form1.FilePathBarang = null;
                }
                else
                {
                    if (ctr + 1 > 0)
                    {
                        MessageBox.Show("Barang Loaded : " + (ctr + 1) + " Barang");
                    }
                }
            } while (KosongBarang);
            changeIsi();
        }

        private void Inventory_Barang_FormClosed(object sender, FormClosedEventArgs e)
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
