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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("Ornek.txt", FileMode.OpenOrCreate);
            //StreamWriter sw = new StreamWriter(fs);
            StreamWriter sw = new StreamWriter("Ornek.txt"); //Dosyayı her seferinde yeniden baştan oluşturur.
            sw.Write("1.satır");
            sw.Write("2.satır");
            sw.WriteLine("3.satır");
            sw.WriteLine("4.satır");
            sw.Close(); //İşimiz bittiğinde dosyayı kapatıyoruz (böylece veri kaybı önlenir, nesne hafızada sonlandırılır).

            StreamReader sr = new StreamReader("Ornek.txt");
            //MessageBox.Show(sr.ReadLine());
            //MessageBox.Show(sr.ReadLine());
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();

        }
    }
}
