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
        public MainForm()
        {
            InitializeComponent();
        }
        public static double maxSpeed = 3500.0;
        private void HizlanBtn_Click(object sender, EventArgs e)
        {
            int checkResult = CheckSpeedControl(Convert.ToDouble(HizTxt.Text));
            if (IlaveCheckBox.Checked == false)
            {
                AnaProgramBaslat(checkResult);
            }
            else
            {
                IlaveProgramBaslat(checkResult);
            }

        }
        private static string TextHazirla(string command, string t1, string t2, string t3)
        {
            return command + t1 + " " + t2 + " " + t3;
        }
        private static int CheckSpeedControl(double speed)
        {
            if (speed > maxSpeed)
            {
                MessageBox.Show("Hız en fazla " + maxSpeed + " olabilir.");
                return 1;
            }
            else return 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HizTxt.Text = "1000";
            ExtraStepAnaTxt.Text = "10000";
            ExtraStepIlaveLbl.Visible = false;
            ExtraStepIlaveTxt.Visible = false;
            try
            {
                arduino.Open();
                Text = Text+" (BAĞLANDI)";
            }
            catch (Exception)
            {
                MessageBox.Show("COM bağlantısı kapalı. Lütfen tekrar deneyin.");
                Application.Exit();
            }
            

        }

        private void DurdurBtn_Click(object sender, EventArgs e)
        {
            string command = TextHazirla("D", HizTxt.Text, ExtraStepAnaTxt.Text, ExtraStepIlaveTxt.Text);
            arduino.Write(command);
        }

        private void AnaProgramBaslat(int checkResult)
        {
            if (checkResult == 0)
            {
                string command = TextHazirla("B", HizTxt.Text, ExtraStepAnaTxt.Text, ExtraStepIlaveTxt.Text);
                arduino.Write(command);
                Thread.Sleep(100);
                //StepLbl.Text = arduino.ReadLine();
                ExtraStepAnaTxt.Text = "0";
            }
        }
        private void IlaveProgramBaslat(int checkResult)
        {
            if (checkResult == 0)
            {
                string command = TextHazirla("C", HizTxt.Text, ExtraStepAnaTxt.Text, ExtraStepIlaveTxt.Text);
                arduino.Write(command);
                Thread.Sleep(100);
                StepLbl.Text = arduino.ReadLine();
                ExtraStepAnaTxt.Text = "0";

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //button1.Text = arduino.ReadLine();
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
    }

}
