namespace AccelStepperSample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.ExtraStepAnaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HizTxt = new System.Windows.Forms.TextBox();
            this.HizlanBtn = new System.Windows.Forms.Button();
            this.StepLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DurdurBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IlaveCheckBox = new System.Windows.Forms.CheckBox();
            this.ExtraStepIlaveTxt = new System.Windows.Forms.TextBox();
            this.ExtraStepIlaveLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TersYonCheck = new System.Windows.Forms.CheckBox();
            this.baglanBtn = new System.Windows.Forms.Button();
            this.baglantiKesBtn = new System.Windows.Forms.Button();
            this.baglantiStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // arduino
            // 
            this.arduino.PortName = "COM3";
            // 
            // ExtraStepAnaTxt
            // 
            this.ExtraStepAnaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExtraStepAnaTxt.Location = new System.Drawing.Point(105, 67);
            this.ExtraStepAnaTxt.Name = "ExtraStepAnaTxt";
            this.ExtraStepAnaTxt.Size = new System.Drawing.Size(81, 23);
            this.ExtraStepAnaTxt.TabIndex = 12;
            this.ExtraStepAnaTxt.TextChanged += new System.EventHandler(this.ExtraStepAnaTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ekstra Step : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Set Speed : ";
            // 
            // HizTxt
            // 
            this.HizTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HizTxt.Location = new System.Drawing.Point(105, 33);
            this.HizTxt.Name = "HizTxt";
            this.HizTxt.Size = new System.Drawing.Size(81, 23);
            this.HizTxt.TabIndex = 9;
            this.HizTxt.TextChanged += new System.EventHandler(this.HizTxt_TextChanged);
            // 
            // HizlanBtn
            // 
            this.HizlanBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HizlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HizlanBtn.Location = new System.Drawing.Point(285, 229);
            this.HizlanBtn.Name = "HizlanBtn";
            this.HizlanBtn.Size = new System.Drawing.Size(148, 33);
            this.HizlanBtn.TabIndex = 8;
            this.HizlanBtn.Text = "Hızlan";
            this.HizlanBtn.UseVisualStyleBackColor = false;
            this.HizlanBtn.Click += new System.EventHandler(this.HizlanBtn_Click);
            // 
            // StepLbl
            // 
            this.StepLbl.AutoSize = true;
            this.StepLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StepLbl.Location = new System.Drawing.Point(240, 5);
            this.StepLbl.Name = "StepLbl";
            this.StepLbl.Size = new System.Drawing.Size(20, 24);
            this.StepLbl.TabIndex = 5;
            this.StepLbl.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.StepLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 38);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Position :";
            // 
            // DurdurBtn
            // 
            this.DurdurBtn.BackColor = System.Drawing.Color.Tomato;
            this.DurdurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurdurBtn.Location = new System.Drawing.Point(39, 229);
            this.DurdurBtn.Name = "DurdurBtn";
            this.DurdurBtn.Size = new System.Drawing.Size(148, 33);
            this.DurdurBtn.TabIndex = 14;
            this.DurdurBtn.Text = "Durdur";
            this.DurdurBtn.UseVisualStyleBackColor = false;
            this.DurdurBtn.Click += new System.EventHandler(this.DurdurBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ExtraStepAnaTxt);
            this.groupBox1.Controls.Add(this.HizTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(30, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 108);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Program";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IlaveCheckBox);
            this.groupBox2.Controls.Add(this.ExtraStepIlaveTxt);
            this.groupBox2.Controls.Add(this.ExtraStepIlaveLbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(241, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 108);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlave Program";
            // 
            // IlaveCheckBox
            // 
            this.IlaveCheckBox.AutoSize = true;
            this.IlaveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlaveCheckBox.Location = new System.Drawing.Point(9, 33);
            this.IlaveCheckBox.Name = "IlaveCheckBox";
            this.IlaveCheckBox.Size = new System.Drawing.Size(81, 21);
            this.IlaveCheckBox.TabIndex = 13;
            this.IlaveCheckBox.Text = "Devrede";
            this.IlaveCheckBox.UseVisualStyleBackColor = true;
            this.IlaveCheckBox.CheckedChanged += new System.EventHandler(this.IlaveCheckBox_CheckedChanged);
            // 
            // ExtraStepIlaveTxt
            // 
            this.ExtraStepIlaveTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExtraStepIlaveTxt.Location = new System.Drawing.Point(105, 67);
            this.ExtraStepIlaveTxt.Name = "ExtraStepIlaveTxt";
            this.ExtraStepIlaveTxt.Size = new System.Drawing.Size(81, 23);
            this.ExtraStepIlaveTxt.TabIndex = 12;
            this.ExtraStepIlaveTxt.TextChanged += new System.EventHandler(this.ExtraStepIlaveTxt_TextChanged);
            // 
            // ExtraStepIlaveLbl
            // 
            this.ExtraStepIlaveLbl.AutoSize = true;
            this.ExtraStepIlaveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExtraStepIlaveLbl.Location = new System.Drawing.Point(6, 70);
            this.ExtraStepIlaveLbl.Name = "ExtraStepIlaveLbl";
            this.ExtraStepIlaveLbl.Size = new System.Drawing.Size(93, 17);
            this.ExtraStepIlaveLbl.TabIndex = 11;
            this.ExtraStepIlaveLbl.Text = "Ekstra Step : ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TersYonCheck
            // 
            this.TersYonCheck.AutoSize = true;
            this.TersYonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TersYonCheck.Location = new System.Drawing.Point(346, 202);
            this.TersYonCheck.Name = "TersYonCheck";
            this.TersYonCheck.Size = new System.Drawing.Size(85, 21);
            this.TersYonCheck.TabIndex = 14;
            this.TersYonCheck.Text = "Ters Yön";
            this.TersYonCheck.UseVisualStyleBackColor = true;
            // 
            // baglanBtn
            // 
            this.baglanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglanBtn.Location = new System.Drawing.Point(30, 39);
            this.baglanBtn.Name = "baglanBtn";
            this.baglanBtn.Size = new System.Drawing.Size(87, 29);
            this.baglanBtn.TabIndex = 17;
            this.baglanBtn.Text = "Bağlan";
            this.baglanBtn.UseVisualStyleBackColor = true;
            this.baglanBtn.Click += new System.EventHandler(this.baglanBtn_Click);
            // 
            // baglantiKesBtn
            // 
            this.baglantiKesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglantiKesBtn.Location = new System.Drawing.Point(123, 39);
            this.baglantiKesBtn.Name = "baglantiKesBtn";
            this.baglantiKesBtn.Size = new System.Drawing.Size(106, 29);
            this.baglantiKesBtn.TabIndex = 18;
            this.baglantiKesBtn.Text = "Bağlantıyı Kes";
            this.baglantiKesBtn.UseVisualStyleBackColor = true;
            this.baglantiKesBtn.Click += new System.EventHandler(this.baglantiKesBtn_Click);
            // 
            // baglantiStatus
            // 
            this.baglantiStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.baglantiStatus.FlatAppearance.BorderSize = 0;
            this.baglantiStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baglantiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglantiStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.baglantiStatus.Location = new System.Drawing.Point(0, 0);
            this.baglantiStatus.Name = "baglantiStatus";
            this.baglantiStatus.Size = new System.Drawing.Size(464, 24);
            this.baglantiStatus.TabIndex = 20;
            this.baglantiStatus.Text = "BAĞLANDI";
            this.baglantiStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baglantiStatus);
            this.Controls.Add(this.baglantiKesBtn);
            this.Controls.Add(this.baglanBtn);
            this.Controls.Add(this.TersYonCheck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HizlanBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DurdurBtn);
            this.Name = "MainForm";
            this.Text = "Pompa Uygulaması";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.TextBox ExtraStepAnaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HizTxt;
        private System.Windows.Forms.Button HizlanBtn;
        private System.Windows.Forms.Label StepLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DurdurBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ExtraStepIlaveTxt;
        private System.Windows.Forms.Label ExtraStepIlaveLbl;
        private System.Windows.Forms.CheckBox IlaveCheckBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox TersYonCheck;
        private System.Windows.Forms.Button baglanBtn;
        private System.Windows.Forms.Button baglantiKesBtn;
        private System.Windows.Forms.Button baglantiStatus;
        private System.Windows.Forms.Label label3;
    }
}