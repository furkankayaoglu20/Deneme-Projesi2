using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Streams
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            StreamWriter DosyaYaz = new StreamWriter("Metin.txt");
            DosyaYaz.WriteLine(txtSatir.Text);
            DosyaYaz.Close();
        }
        private void btnOku_Click(object sender, EventArgs e)
        {
            StreamReader DosyaOku = new StreamReader("Metin.txt");
            txtMetin.Text = DosyaOku.ReadLine() + "\n";
            txtMetin.Text += DosyaOku.ReadLine() + "\n";
            DosyaOku.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            StreamWriter DosyaYaz = new StreamWriter("Metin.txt", true); //append özelliği aktif olur.
            DosyaYaz.WriteLine(txtSatir.Text);
            DosyaYaz.Close();
        }
        private void btnHepsiniOku_Click(object sender, EventArgs e)
        {
            StreamReader DosyaOku = new StreamReader("Metin.txt");
            //txtMetin.Text = DosyaOku.ReadToEnd();
            txtMetin.Text = "";
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                txtMetin.Text += okunan + "\n";
                okunan= DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
