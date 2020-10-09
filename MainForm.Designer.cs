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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PositionBtn = new System.Windows.Forms.Button();
            this.RunningBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgramBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.IlaveAdetLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DurdurBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IlaveCheckBox = new System.Windows.Forms.CheckBox();
            this.ExtraStepIlaveTxt = new System.Windows.Forms.TextBox();
            this.ExtraStepIlaveLbl = new System.Windows.Forms.Label();
            this.TersYonCheck = new System.Windows.Forms.CheckBox();
            this.baglanBtn = new System.Windows.Forms.Button();
            this.baglantiKesBtn = new System.Windows.Forms.Button();
            this.baglantiStatus = new System.Windows.Forms.Button();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // arduino
            // 
            this.arduino.PortName = "COM3";
            this.arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduino_DataReceived);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.PositionBtn);
            this.panel1.Controls.Add(this.RunningBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProgramBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.IlaveAdetLbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 98);
            this.panel1.TabIndex = 13;
            // 
            // PositionBtn
            // 
            this.PositionBtn.BackColor = System.Drawing.Color.Khaki;
            this.PositionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PositionBtn.Location = new System.Drawing.Point(162, 5);
            this.PositionBtn.Name = "PositionBtn";
            this.PositionBtn.Size = new System.Drawing.Size(94, 26);
            this.PositionBtn.TabIndex = 31;
            this.PositionBtn.Text = "0";
            this.PositionBtn.UseVisualStyleBackColor = false;
            // 
            // RunningBtn
            // 
            this.RunningBtn.BackColor = System.Drawing.Color.DarkGray;
            this.RunningBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunningBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RunningBtn.Location = new System.Drawing.Point(162, 34);
            this.RunningBtn.Name = "RunningBtn";
            this.RunningBtn.Size = new System.Drawing.Size(94, 26);
            this.RunningBtn.TabIndex = 30;
            this.RunningBtn.Text = "DURUYOR";
            this.RunningBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Program : ";
            // 
            // ProgramBtn
            // 
            this.ProgramBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ProgramBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgramBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProgramBtn.Location = new System.Drawing.Point(162, 63);
            this.ProgramBtn.Name = "ProgramBtn";
            this.ProgramBtn.Size = new System.Drawing.Size(94, 26);
            this.ProgramBtn.TabIndex = 23;
            this.ProgramBtn.Text = "YOK";
            this.ProgramBtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(300, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "İlave Adet : ";
            // 
            // IlaveAdetLbl
            // 
            this.IlaveAdetLbl.AutoSize = true;
            this.IlaveAdetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlaveAdetLbl.Location = new System.Drawing.Point(423, 65);
            this.IlaveAdetLbl.Name = "IlaveAdetLbl";
            this.IlaveAdetLbl.Size = new System.Drawing.Size(20, 24);
            this.IlaveAdetLbl.TabIndex = 25;
            this.IlaveAdetLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Running : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 5);
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
            this.baglantiStatus.BackColor = System.Drawing.Color.Red;
            this.baglantiStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.baglantiStatus.FlatAppearance.BorderSize = 0;
            this.baglantiStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baglantiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglantiStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.baglantiStatus.Location = new System.Drawing.Point(0, 0);
            this.baglantiStatus.Name = "baglantiStatus";
            this.baglantiStatus.Size = new System.Drawing.Size(464, 24);
            this.baglantiStatus.TabIndex = 20;
            this.baglantiStatus.Text = "BAĞLANTI KESİLDİ";
            this.baglantiStatus.UseVisualStyleBackColor = false;
            // 
            // PortComboBox
            // 
            this.PortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(244, 39);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(189, 24);
            this.PortComboBox.TabIndex = 22;
            this.PortComboBox.Text = "Port Seçin";
            this.PortComboBox.SelectedValueChanged += new System.EventHandler(this.PortComboBox_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(464, 366);
            this.Controls.Add(this.PortComboBox);
            this.Controls.Add(this.baglantiStatus);
            this.Controls.Add(this.baglantiKesBtn);
            this.Controls.Add(this.baglanBtn);
            this.Controls.Add(this.TersYonCheck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HizlanBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DurdurBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DurdurBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ExtraStepIlaveTxt;
        private System.Windows.Forms.Label ExtraStepIlaveLbl;
        private System.Windows.Forms.CheckBox IlaveCheckBox;
        private System.Windows.Forms.CheckBox TersYonCheck;
        private System.Windows.Forms.Button baglanBtn;
        private System.Windows.Forms.Button baglantiKesBtn;
        private System.Windows.Forms.Button baglantiStatus;
        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.Label IlaveAdetLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProgramBtn;
        private System.Windows.Forms.Button RunningBtn;
        private System.Windows.Forms.Button PositionBtn;
    }
}