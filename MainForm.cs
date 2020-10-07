using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccelStepperSample
{
    public partial class MainForm : Form
    {
        public static double maxSpeed = 3500.0;
        public static string hiz, extraStepAna, extraStepIlave;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            HizTxt.Text = "1000";
            ExtraStepAnaTxt.Text = "10000";
            ExtraStepIlaveTxt.Text = "0";
            ExtraStepIlaveLbl.Visible = false;
            ExtraStepIlaveTxt.Visible = false;
            
            arduinoConnect();
        }
        
        private void HizlanBtn_Click(object sender, EventArgs e)
        {
            YonCheck();
            if (arduino.IsOpen)
            {
                if (IlaveCheckBox.Checked == true)
                {
                    IlaveProgramBaslat();
                }
                else
                {
                    AnaProgramBaslat();
                }
            }
            else
            {
                MessageBox.Show("Port bağlantısı kapalı. Açıp tekrar deneyin.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void AnaProgramBaslat()
        {
            string command = TextHazirla("B", hiz, extraStepAna, extraStepIlave);
            //MessageBox.Show(command);
            arduino.Write(command);
            Thread.Sleep(100);
            StepLbl.Text = arduino.ReadLine();
            ExtraStepAnaTxt.Text = "0";
        }
        private void IlaveProgramBaslat()
        {
            string command = TextHazirla("C", hiz, extraStepAna, extraStepIlave);
            //MessageBox.Show(command);
            arduino.Write(command);
            Thread.Sleep(100);
            StepLbl.Text = arduino.ReadLine();
            ExtraStepAnaTxt.Text = "0";
        }

        private void DurdurBtn_Click(object sender, EventArgs e)
        {
            if (arduino.IsOpen)
            {
                string command = TextHazirla("D", HizTxt.Text, ExtraStepAnaTxt.Text, ExtraStepIlaveTxt.Text);
                arduino.Write(command);
            }
            else
            {
                MessageBox.Show("Port bağlantısı kapalı. Açıp tekrar deneyin.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private static string TextHazirla(string command, string t1, string t2, string t3)
        {
            return command + t1 + " " + t2 + " " + t3;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (arduino.IsOpen)
            {
                label3.Text = arduino.ReadExisting();
            }      
        }

        private void IlaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IlaveCheckBox.Checked)
            {
                ExtraStepIlaveLbl.Visible = true;
                ExtraStepIlaveTxt.Visible = true;
            }
            else
            {
                ExtraStepIlaveLbl.Visible = false;
                ExtraStepIlaveTxt.Visible = false;
            }
        }

        private void HizTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(HizTxt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Sadece tam sayı girilebilir.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HizTxt.Text = HizTxt.Text.Remove(HizTxt.Text.Length - 1);
                }
                if (Convert.ToInt32(HizTxt.Text) > maxSpeed)
                {
                    MessageBox.Show("Hız en fazla " + maxSpeed + " olabilir.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HizTxt.Text = HizTxt.Text.Remove(HizTxt.Text.Length - 1);
                }
            }
            catch (FormatException)
            {
                HizTxt.Text = "0";
            }
            
        }

        private void ExtraStepAnaTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(ExtraStepAnaTxt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Sadece tam sayı girilebilir.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExtraStepAnaTxt.Text = ExtraStepAnaTxt.Text.Remove(ExtraStepAnaTxt.Text.Length - 1);
                }
                if(ExtraStepAnaTxt.Text == "")
                {
                    ExtraStepAnaTxt.Text = "0";
                }
            }
            catch (FormatException)
            {
                ExtraStepAnaTxt.Text = "0";
            }
            
        }

        private void ExtraStepIlaveTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(ExtraStepIlaveTxt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Sadece tam sayı girilebilir.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExtraStepIlaveTxt.Text = ExtraStepIlaveTxt.Text.Remove(ExtraStepIlaveTxt.Text.Length - 1);
                }
                if (ExtraStepIlaveTxt.Text == "")
                {
                    ExtraStepIlaveTxt.Text = "0";
                }
            }
            catch (FormatException)
            {
                ExtraStepIlaveTxt.Text = "0";
            }
            
        }

        private void YonCheck()
        {
            if (TersYonCheck.Checked)
            {
                hiz = HizTxt.Text;
                extraStepAna = (Convert.ToInt32(ExtraStepAnaTxt.Text) * -1).ToString();
                extraStepIlave = (Convert.ToInt32(ExtraStepIlaveTxt.Text) * -1).ToString();
            }
            else
            {
                hiz = HizTxt.Text;
                extraStepAna = ExtraStepAnaTxt.Text;
                extraStepIlave = ExtraStepIlaveTxt.Text;
            }
        }

        private void baglanBtn_Click(object sender, EventArgs e)
        {
            if (!arduino.IsOpen)
            {
                arduinoConnect();
            }
            else
            {
                MessageBox.Show("Zaten bağlı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void baglantiKesBtn_Click(object sender, EventArgs e)
        {
            if (arduino.IsOpen)
            {
                arduinoDisconnect();
            }
            else
            {
                MessageBox.Show("Zaten bağlantı kapalı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arduinoConnect()
        {
            try
            {
                arduino.Open();
                Text = "Pompa Uygulaması (BAĞLANDI)";
                baglantiStatus.BackColor = Color.Green;
                baglantiStatus.Text = "BAĞLANDI";
            }
            catch (Exception)
            {
                MessageBox.Show("COM bağlantısı kapalı. Lütfen tekrar deneyin.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }
        private void arduinoDisconnect()
        {
            try
            {
                arduino.Close();
                Text = "Pompa Uygulaması (BAĞLANTI KESİLDİ)";
                baglantiStatus.BackColor = Color.Red;
                baglantiStatus.Text = "BAĞLANTI KESİLDİ";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }

}
