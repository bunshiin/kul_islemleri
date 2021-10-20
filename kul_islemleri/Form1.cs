using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace kul_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] tcno = new string[100];
        string[] isimler = new string[100];
        string[] soydad = new string[100];
        string[] bolum = new string[100];
        string[] sınıf = new string[100];
        string[] telno = new string[100];
        string[] cins = new string[100];
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTC.Text == "")
            {
                MessageBox.Show("Kimlik Bilgisi Boş Bırakılmamlı");
            }
            else if (textBoxAD.Text == "")
            {
                MessageBox.Show("İsim Bilgisi Boş Bırakılmamlı");
            }
            else if (textBoxSOYAD.Text == "")
            {
                MessageBox.Show("Soyad Bilgisi Boş Bırakılmamlı");

            }
            
            else if (comboBoxBOLUM.Text == "")
            {
                MessageBox.Show("Bölüm Bilgisi Boş Bırakılmamlı");
            }
            else if (comboBoxSINIF.Text == "")
            {
                MessageBox.Show("Sınıf Bilgisi Boş Bırakılmamlı");
            }
            else if (maskedTextBoxTEL.Text == "")
            {
                MessageBox.Show("Telefon Bilgisi Boş Bırakılmamlı");
            }
            


            tcno[i] = textBoxTC.Text;
            isimler[i] = textBoxAD.Text;
            soydad[i] = textBoxSOYAD.Text;
            bolum[i] = comboBoxBOLUM.Text;
            sınıf[i] = comboBoxSINIF.Text;
            telno[i] = maskedTextBoxTEL.Text;



            if (radioButtonERKEK.Checked == true)
            {
                cins[i] = "erkek";
            }
            if (radioButtonKADIN.Checked == true)
            {
                cins[i] = "kadın";
            }
            label8.Text = "Veriler Kaydedildi";


            i++;






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölmüler Eklendi
            comboBoxBOLUM.Items.Add("Bilişim");
            comboBoxBOLUM.Items.Add("Makina");
            comboBoxBOLUM.Items.Add("Kimya");
            comboBoxBOLUM.Items.Add("Elektrik");
            //Sınıflar Eklendi
            comboBoxSINIF.Items.Add("9");
            comboBoxSINIF.Items.Add("10");
            comboBoxSINIF.Items.Add("11");
            comboBoxSINIF.Items.Add("12");

            
            




        }

        private void radioButtonERKEK_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonKADIN_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTC.Clear();
            textBoxAD.Clear();
            textBoxSOYAD.Clear();
            maskedTextBoxTEL.Clear();
            comboBoxBOLUM.Items.Clear();
            comboBoxSINIF.Items.Clear();
            maskedTextBoxTEL.Clear();
            radioButtonERKEK.Checked = false;
            radioButtonKADIN.Checked = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tcno.Length; i++)
            {
                listBox1.Items.Add(tcno[i] + " " + isimler[i] + " " + soydad[i] + " " + bolum[i] + " " + sınıf[i] + " " + cins[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tcgiris = Interaction.InputBox("Bilgi Girişi", "Tc giriniz");
            for (int i = 0; i < tcno.Length; i++)
            {
                if (tcgiris == tcno[i])
                {
                    lbl_tc.Text = tcno[i];
                    lbl_ad.Text = isimler[i];
                    lbl_soyad.Text = soydad[i];
                    lbl_bolum.Text = bolum[i];
                    lbl_sınıf.Text = sınıf[i].ToString();
                    lbl_tel.Text = telno[i];
                    lbl_cınsıyet.Text = cins[i];
                }   
            }
            
        }
    }
}
