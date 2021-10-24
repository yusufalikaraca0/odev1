using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
namespace odevzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            string mylocation = Environment.CurrentDirectory;
            mylocation = mylocation.Substring(0, mylocation.Length - 9);
            pfc.AddFontFile(mylocation + "cairo.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size + 2, FontStyle.Regular);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool firstchecked = true;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dikdortgenSonuc.Visible = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kareSonuc.Visible = radioButton2.Checked;
        }
        string seciliislem = "";
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            daireSonuc.Visible = radioButton3.Checked;
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBox1.Text == "Kenar")
            {
                textBox1.Text = "";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                seciliislem = "Alan";
            foreach (RadioButton c in groupBox1.Controls)
            {
                if (c.Checked)
                {
                  
                    if (c.Text == "Kare")
                        textBox1_TextChanged(sender, e);
                    else if (c.Text == "Dikdörtgen")
                        textBox3_TextChanged(sender, e);
                    else if (c.Text == "Daire")
                        textBox5_TextChanged(sender, e);
                }
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                seciliislem = "Çevre";
            foreach (RadioButton c in groupBox1.Controls)
            {
                if (c.Checked)
                {
                    if (c.Text == "Kare")
                        textBox1_TextChanged(sender, e);
                    else if (c.Text == "Dikdörtgen")
                        textBox2_TextChanged(sender,e);
                    else if (c.Text == "Daire")
                        textBox5_TextChanged(sender, e);
                }

            }

        }

        void hesapla(Label label, TextBox textbox)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (seciliislem != "")
                {
                    if (seciliislem == "Alan")
                    {
                        float sayi = float.Parse(textBox1.Text);
                        if (float.IsNaN(sayi))
                            label2.Text = "NaN";
                        else
                        {
                            label2.Text = (sayi * sayi).ToString();
                        }
                    }
                    else if(seciliislem == "Çevre")
                    {
                        float sayi = float.Parse(textBox1.Text);
                        if (float.IsNaN(sayi))
                            label2.Text = "NaN";
                        else
                        {
                            label2.Text = (sayi * 4).ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Seçiniz");
                }
            }
            catch (Exception)
            {
                label2.Text = "NaN";

            }

        }

        private void kareSonuc_Enter(object sender, EventArgs e)
        {

        }
        
        void dikdortgen(TextBox textbox,Label label,TextBox textbox2)
        {
            try
            {
                if (seciliislem != "")
                {
                    if (seciliislem == "Alan")
                    {
                        float sayi1 = float.Parse(textbox.Text);
                        float sayi2 = float.Parse(textbox2.Text);
                        if (float.IsNaN(sayi1))
                            label.Text = "NaN";
                        else
                        {
                            label.Text = (sayi1* sayi2).ToString();
                        }
                    }
                    else if(seciliislem == "Çevre")
                    {
                        float sayi1 = float.Parse(textbox.Text);
                        float sayi2 = float.Parse(textbox2.Text);
                        if (float.IsNaN(sayi1))
                            label.Text = "NaN";
                        else
                        {
                            label.Text = (sayi1*2 + sayi2*2).ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Seçiniz");
                }
            }
            catch (Exception)
            {
                label.Text = "NaN";

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dikdortgen(textBox2, label4, textBox3);

        }

        private void textBox3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBox3.Text == "Kısa kenar")
            {
                textBox3.Text = "";
            }
        }

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBox2.Text == "Uzun kenar")
            {
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dikdortgen(textBox2, label4, textBox3);
        }

        private void textBox5_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBox5.Text == "Yarıçap")
                textBox5.Text = ""; 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (seciliislem != "")
                {
                    if (seciliislem == "Alan")
                    {
                        double sayi1 = double.Parse(textBox5.Text);
                        
                        if (double.IsNaN(sayi1))
                            label6.Text = "NaN";
                        else
                        {
                            label6.Text = Math.Round(Math.PI * (sayi1 * sayi1),2).ToString();
                        }
                    }
                     if (seciliislem == "Çevre")
                    {
                        double sayi1 = float.Parse(textBox5.Text);
                        
                        if (double.IsNaN(sayi1))
                            label6.Text = "NaN";
                        else
                        {
                             label6.Text = Math.Round(Math.PI * (sayi1 + sayi1),2).ToString();
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Seçiniz");
                }
            }
            catch (Exception)
            {
                label6.Text = "NaN";

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
