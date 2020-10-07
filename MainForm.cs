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
            try
            {
                arduino.Open();
                Text = Text + " (BAĞLANDI)";
            }
            catch (Exception)
            {
                MessageBox.Show("COM bağlantısı kapalı. Lütfen tekrar deneyin.");
                Application.Exit();
            }
        }
        
        private void HizlanBtn_Click(object sender, EventArgs e)
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
       
        private void AnaProgramBaslat()
        {
            string command = TextHazirla("B", HizTxt.Text, ExtraStepAnaTxt.Text, ExtraStepIlaveTxt.Text);
            arduino.Write(command);
            Thread.Sleep(100);
            //StepLbl.Text = arduino.ReadLine();
            ExtraStepAnaTxt.Text = "0";
        }
        private void IlaveProgramBaslat()
        {
            string command = TextHazirla("C", HizTxt.Text, ExtraStepAnaTxt.Text, ExtraStepIlaveTxt.Text);
            arduino.Write(command);
            Thread.Sleep(100);
            //StepLbl.Text = arduino.ReadLine();
            ExtraStepAnaTxt.Text = "0";
        }

        private void DurdurBtn_Click(object sender, EventArgs e)
        {
            string command = TextHazirla("D", HizTxt.Text, ExtraStepAnaTxt.Text, ExtraStepIlaveTxt.Text);
            arduino.Write(command);
        }

        private static string TextHazirla(string command, string t1, string t2, string t3)
        {
            return command + t1 + " " + t2 + " " + t3;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //PERİYODİK;
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
            if (System.Text.RegularExpressions.Regex.IsMatch(HizTxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece tam sayı girilebilir.");
                HizTxt.Text = HizTxt.Text.Remove(HizTxt.Text.Length - 1);
            }
            if (Convert.ToInt32(HizTxt.Text) > maxSpeed)
            {
                MessageBox.Show("Hız en fazla "+maxSpeed+" olabilir.");
                HizTxt.Text = HizTxt.Text.Remove(HizTxt.Text.Length - 1);
            }
        }

        private void ExtraStepAnaTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ExtraStepAnaTxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece tam sayı girilebilir.");
                ExtraStepAnaTxt.Text = ExtraStepAnaTxt.Text.Remove(ExtraStepAnaTxt.Text.Length - 1);
            }
        }

        private void ExtraStepIlaveTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ExtraStepIlaveTxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece tam sayı girilebilir.");
                ExtraStepIlaveTxt.Text = ExtraStepIlaveTxt.Text.Remove(ExtraStepIlaveTxt.Text.Length - 1);
            }
        }
    }

}
