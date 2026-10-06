namespace Robot
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.butdangxuat = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbocom = new System.Windows.Forms.ComboBox();
            this.butketnoi = new System.Windows.Forms.Button();
            this.butngat = new System.Windows.Forms.Button();
            this.cbobaudrate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sercom = new System.IO.Ports.SerialPort(this.components);
            this.butToggleMode = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.butStart1 = new System.Windows.Forms.Button();
            this.butStart2 = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.trackServo1 = new System.Windows.Forms.TrackBar();
            this.trackServo2 = new System.Windows.Forms.TrackBar();
            this.trackServo3 = new System.Windows.Forms.TrackBar();
            this.trackServo4 = new System.Windows.Forms.TrackBar();
            this.txtServo1 = new System.Windows.Forms.TextBox();
            this.txtServo2 = new System.Windows.Forms.TextBox();
            this.txtServo3 = new System.Windows.Forms.TextBox();
            this.txtServo4 = new System.Windows.Forms.TextBox();
            this.txtStepperX = new System.Windows.Forms.TextBox();
            this.txtStepperY = new System.Windows.Forms.TextBox();
            this.txtRobotState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lvRobotLog = new System.Windows.Forms.ListView();
            this.ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trucx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trucy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servo1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servo2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servo3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servo4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerLog = new System.Windows.Forms.Timer(this.components);
            this.butreset = new System.Windows.Forms.Button();
            this.lbgio = new System.Windows.Forms.Label();
            this.lbngay = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlLedManualHW = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlLedManualGUI = new System.Windows.Forms.Panel();
            this.pnlLedStop = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlLedRunning = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlLedReady = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.joystickControl1 = new Robot.JoystickControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // butdangxuat
            // 
            this.butdangxuat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butdangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdangxuat.Location = new System.Drawing.Point(15, 523);
            this.butdangxuat.Name = "butdangxuat";
            this.butdangxuat.Size = new System.Drawing.Size(186, 42);
            this.butdangxuat.TabIndex = 32;
            this.butdangxuat.Text = "Đăng Xuất";
            this.butdangxuat.UseVisualStyleBackColor = false;
            this.butdangxuat.Click += new System.EventHandler(this.butdangxuat_Click);
            // 
            // butthoat
            // 
            this.butthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthoat.Location = new System.Drawing.Point(207, 523);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(121, 43);
            this.butthoat.TabIndex = 33;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = false;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.AutoSize = true;
            this.lbtrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrangthai.Location = new System.Drawing.Point(117, 254);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(142, 32);
            this.lbtrangthai.TabIndex = 122;
            this.lbtrangthai.Text = "Trạng thái";
            this.lbtrangthai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(254, 3);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(72, 62);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 125;
            this.pictureBox16.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 32);
            this.label4.TabIndex = 126;
            this.label4.Text = "CÀI ĐẶT KẾT NỐI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 123;
            this.label2.Text = "Chọn COM";
            // 
            // cbocom
            // 
            this.cbocom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocom.FormattingEnabled = true;
            this.cbocom.Location = new System.Drawing.Point(63, 46);
            this.cbocom.Name = "cbocom";
            this.cbocom.Size = new System.Drawing.Size(244, 37);
            this.cbocom.TabIndex = 119;
            // 
            // butketnoi
            // 
            this.butketnoi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butketnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butketnoi.ForeColor = System.Drawing.Color.White;
            this.butketnoi.Location = new System.Drawing.Point(63, 164);
            this.butketnoi.Name = "butketnoi";
            this.butketnoi.Size = new System.Drawing.Size(244, 42);
            this.butketnoi.TabIndex = 120;
            this.butketnoi.Text = "Kết nối";
            this.butketnoi.UseVisualStyleBackColor = false;
            this.butketnoi.Click += new System.EventHandler(this.butketnoi_Click);
            // 
            // butngat
            // 
            this.butngat.BackColor = System.Drawing.Color.Red;
            this.butngat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butngat.ForeColor = System.Drawing.Color.White;
            this.butngat.Location = new System.Drawing.Point(63, 205);
            this.butngat.Name = "butngat";
            this.butngat.Size = new System.Drawing.Size(244, 42);
            this.butngat.TabIndex = 121;
            this.butngat.Text = "Ngắt kết nối";
            this.butngat.UseVisualStyleBackColor = false;
            this.butngat.Click += new System.EventHandler(this.butngat_Click);
            // 
            // cbobaudrate
            // 
            this.cbobaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobaudrate.FormattingEnabled = true;
            this.cbobaudrate.Location = new System.Drawing.Point(63, 121);
            this.cbobaudrate.Name = "cbobaudrate";
            this.cbobaudrate.Size = new System.Drawing.Size(244, 37);
            this.cbobaudrate.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 32);
            this.label6.TabIndex = 124;
            this.label6.Text = "Chọn Baurate";
            // 
            // butToggleMode
            // 
            this.butToggleMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butToggleMode.Location = new System.Drawing.Point(90, 22);
            this.butToggleMode.Name = "butToggleMode";
            this.butToggleMode.Size = new System.Drawing.Size(186, 55);
            this.butToggleMode.TabIndex = 127;
            this.butToggleMode.Text = "Chuyển chế độ";
            this.butToggleMode.UseVisualStyleBackColor = true;
            this.butToggleMode.Click += new System.EventHandler(this.butToggleMode_Click_1);
            // 
            // butHome
            // 
            this.butHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHome.Location = new System.Drawing.Point(90, 163);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(183, 55);
            this.butHome.TabIndex = 128;
            this.butHome.Text = "Home";
            this.butHome.UseVisualStyleBackColor = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click_1);
            // 
            // butStart1
            // 
            this.butStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart1.Location = new System.Drawing.Point(16, 228);
            this.butStart1.Name = "butStart1";
            this.butStart1.Size = new System.Drawing.Size(156, 55);
            this.butStart1.TabIndex = 129;
            this.butStart1.Text = "Start1";
            this.butStart1.UseVisualStyleBackColor = true;
            this.butStart1.Click += new System.EventHandler(this.butStart1_Click_1);
            // 
            // butStart2
            // 
            this.butStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart2.Location = new System.Drawing.Point(187, 228);
            this.butStart2.Name = "butStart2";
            this.butStart2.Size = new System.Drawing.Size(156, 55);
            this.butStart2.TabIndex = 130;
            this.butStart2.Text = "Start2";
            this.butStart2.UseVisualStyleBackColor = true;
            this.butStart2.Click += new System.EventHandler(this.butStart2_Click_1);
            // 
            // butStop
            // 
            this.butStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStop.Location = new System.Drawing.Point(90, 93);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(183, 55);
            this.butStop.TabIndex = 131;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click_1);
            // 
            // trackServo1
            // 
            this.trackServo1.Location = new System.Drawing.Point(193, 174);
            this.trackServo1.Maximum = 180;
            this.trackServo1.Name = "trackServo1";
            this.trackServo1.Size = new System.Drawing.Size(223, 56);
            this.trackServo1.TabIndex = 132;
            this.trackServo1.Scroll += new System.EventHandler(this.trackServo_Scroll);
            // 
            // trackServo2
            // 
            this.trackServo2.Location = new System.Drawing.Point(193, 235);
            this.trackServo2.Maximum = 180;
            this.trackServo2.Name = "trackServo2";
            this.trackServo2.Size = new System.Drawing.Size(223, 56);
            this.trackServo2.TabIndex = 133;
            this.trackServo2.Scroll += new System.EventHandler(this.trackServo_Scroll);
            // 
            // trackServo3
            // 
            this.trackServo3.Location = new System.Drawing.Point(193, 297);
            this.trackServo3.Maximum = 180;
            this.trackServo3.Name = "trackServo3";
            this.trackServo3.Size = new System.Drawing.Size(223, 56);
            this.trackServo3.TabIndex = 134;
            this.trackServo3.Scroll += new System.EventHandler(this.trackServo_Scroll);
            // 
            // trackServo4
            // 
            this.trackServo4.Location = new System.Drawing.Point(193, 359);
            this.trackServo4.Maximum = 180;
            this.trackServo4.Name = "trackServo4";
            this.trackServo4.Size = new System.Drawing.Size(223, 56);
            this.trackServo4.TabIndex = 135;
            this.trackServo4.Scroll += new System.EventHandler(this.trackServo_Scroll);
            // 
            // txtServo1
            // 
            this.txtServo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServo1.Location = new System.Drawing.Point(480, 7);
            this.txtServo1.Name = "txtServo1";
            this.txtServo1.Size = new System.Drawing.Size(195, 45);
            this.txtServo1.TabIndex = 136;
            this.txtServo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServo2
            // 
            this.txtServo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServo2.Location = new System.Drawing.Point(480, 83);
            this.txtServo2.Name = "txtServo2";
            this.txtServo2.Size = new System.Drawing.Size(195, 45);
            this.txtServo2.TabIndex = 137;
            this.txtServo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServo3
            // 
            this.txtServo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServo3.Location = new System.Drawing.Point(480, 156);
            this.txtServo3.Name = "txtServo3";
            this.txtServo3.Size = new System.Drawing.Size(195, 45);
            this.txtServo3.TabIndex = 138;
            this.txtServo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServo4
            // 
            this.txtServo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServo4.Location = new System.Drawing.Point(480, 235);
            this.txtServo4.Name = "txtServo4";
            this.txtServo4.Size = new System.Drawing.Size(195, 45);
            this.txtServo4.TabIndex = 139;
            this.txtServo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStepperX
            // 
            this.txtStepperX.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStepperX.Location = new System.Drawing.Point(28, 89);
            this.txtStepperX.Name = "txtStepperX";
            this.txtStepperX.Size = new System.Drawing.Size(224, 45);
            this.txtStepperX.TabIndex = 140;
            this.txtStepperX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStepperY
            // 
            this.txtStepperY.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStepperY.Location = new System.Drawing.Point(28, 209);
            this.txtStepperY.Name = "txtStepperY";
            this.txtStepperY.Size = new System.Drawing.Size(224, 45);
            this.txtStepperY.TabIndex = 141;
            this.txtStepperY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRobotState
            // 
            this.txtRobotState.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRobotState.Location = new System.Drawing.Point(689, 508);
            this.txtRobotState.Name = "txtRobotState";
            this.txtRobotState.Size = new System.Drawing.Size(743, 61);
            this.txtRobotState.TabIndex = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 32);
            this.label3.TabIndex = 146;
            this.label3.Text = "Trạng thái Robot:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(288, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 36);
            this.label11.TabIndex = 152;
            this.label11.Text = "Góc Servo1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(288, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 36);
            this.label12.TabIndex = 153;
            this.label12.Text = "Góc Servo2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(288, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 36);
            this.label13.TabIndex = 154;
            this.label13.Text = "Góc Servo3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(288, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 36);
            this.label14.TabIndex = 155;
            this.label14.Text = "Góc Servo4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(78, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 36);
            this.label15.TabIndex = 156;
            this.label15.Text = "Trục X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(79, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 36);
            this.label16.TabIndex = 157;
            this.label16.Text = "Trục Y";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(56, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 32);
            this.label17.TabIndex = 158;
            this.label17.Text = "Servo1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(56, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 32);
            this.label18.TabIndex = 159;
            this.label18.Text = "Servo2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(56, 297);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 32);
            this.label19.TabIndex = 160;
            this.label19.Text = "Servo3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(56, 359);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 32);
            this.label20.TabIndex = 161;
            this.label20.Text = "Servo4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(56, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 32);
            this.label21.TabIndex = 162;
            this.label21.Text = "Trục X Y";
            // 
            // lvRobotLog
            // 
            this.lvRobotLog.BackColor = System.Drawing.Color.Honeydew;
            this.lvRobotLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ngay,
            this.gio,
            this.trucx,
            this.trucy,
            this.servo1,
            this.servo2,
            this.servo3,
            this.servo4,
            this.tt});
            this.lvRobotLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRobotLog.FullRowSelect = true;
            this.lvRobotLog.GridLines = true;
            this.lvRobotLog.HideSelection = false;
            this.lvRobotLog.Location = new System.Drawing.Point(14, 84);
            this.lvRobotLog.Name = "lvRobotLog";
            this.lvRobotLog.Size = new System.Drawing.Size(1500, 276);
            this.lvRobotLog.TabIndex = 163;
            this.lvRobotLog.UseCompatibleStateImageBehavior = false;
            this.lvRobotLog.View = System.Windows.Forms.View.Details;
            // 
            // ngay
            // 
            this.ngay.Text = "Ngày";
            this.ngay.Width = 90;
            // 
            // gio
            // 
            this.gio.Text = "Giờ";
            this.gio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gio.Width = 120;
            // 
            // trucx
            // 
            this.trucx.Tag = "Trục X";
            this.trucx.Text = "Trục X";
            this.trucx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trucx.Width = 120;
            // 
            // trucy
            // 
            this.trucy.Text = "Trục Y";
            this.trucy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trucy.Width = 120;
            // 
            // servo1
            // 
            this.servo1.Text = "Servo1";
            this.servo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servo1.Width = 120;
            // 
            // servo2
            // 
            this.servo2.Tag = "Servo2";
            this.servo2.Text = "Servo2";
            this.servo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servo2.Width = 120;
            // 
            // servo3
            // 
            this.servo3.Text = "Servo3";
            this.servo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servo3.Width = 120;
            // 
            // servo4
            // 
            this.servo4.Text = "Servo4";
            this.servo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servo4.Width = 120;
            // 
            // tt
            // 
            this.tt.Text = "Trạng thái";
            this.tt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tt.Width = 200;
            // 
            // timerLog
            // 
            this.timerLog.Interval = 1000;
            this.timerLog.Tick += new System.EventHandler(this.timerLog_Tick);
            // 
            // butreset
            // 
            this.butreset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butreset.Location = new System.Drawing.Point(1342, 26);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(155, 49);
            this.butreset.TabIndex = 164;
            this.butreset.Text = "Xóa nhật ký";
            this.butreset.UseVisualStyleBackColor = false;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // lbgio
            // 
            this.lbgio.AutoSize = true;
            this.lbgio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgio.Location = new System.Drawing.Point(1383, 67);
            this.lbgio.Name = "lbgio";
            this.lbgio.Size = new System.Drawing.Size(18, 25);
            this.lbgio.TabIndex = 168;
            this.lbgio.Text = ".";
            // 
            // lbngay
            // 
            this.lbngay.AutoSize = true;
            this.lbngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngay.Location = new System.Drawing.Point(1383, 32);
            this.lbngay.Name = "lbngay";
            this.lbngay.Size = new System.Drawing.Size(18, 25);
            this.lbngay.TabIndex = 167;
            this.lbngay.Text = ".";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1348, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 166;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1348, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 165;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(35, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(167, 32);
            this.label22.TabIndex = 163;
            this.label22.Text = "Điều khiển ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(99, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 32);
            this.label24.TabIndex = 146;
            this.label24.Text = "Công tắc";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(143, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(322, 32);
            this.label25.TabIndex = 158;
            this.label25.Text = "Thông số chuyển động";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.10818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.89182F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 382);
            this.tableLayoutPanel1.TabIndex = 175;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Honeydew;
            this.panel7.Controls.Add(this.lbtrangthai);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.cbocom);
            this.panel7.Controls.Add(this.cbobaudrate);
            this.panel7.Controls.Add(this.butketnoi);
            this.panel7.Controls.Add(this.butngat);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 83);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(371, 296);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.pictureBox16);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(371, 74);
            this.panel8.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(453, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.37203F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.62797F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 385);
            this.tableLayoutPanel2.TabIndex = 176;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label24);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 76);
            this.panel2.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Honeydew;
            this.panel9.Controls.Add(this.butStart2);
            this.panel9.Controls.Add(this.butToggleMode);
            this.panel9.Controls.Add(this.butStart1);
            this.panel9.Controls.Add(this.butStop);
            this.panel9.Controls.Add(this.butHome);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 85);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(355, 297);
            this.panel9.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(838, 103);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.87629F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.12371F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(703, 388);
            this.tableLayoutPanel4.TabIndex = 178;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.label25);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 75);
            this.panel3.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Honeydew;
            this.panel10.Controls.Add(this.txtServo1);
            this.panel10.Controls.Add(this.txtServo4);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Controls.Add(this.label15);
            this.panel10.Controls.Add(this.txtServo2);
            this.panel10.Controls.Add(this.txtStepperX);
            this.panel10.Controls.Add(this.txtServo3);
            this.panel10.Controls.Add(this.txtStepperY);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 84);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(697, 301);
            this.panel10.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(35, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(345, 32);
            this.label26.TabIndex = 180;
            this.label26.Text = "Trạng thái và Điều khiển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 145;
            this.label1.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 147;
            this.label5.Text = "Home/Ready";
            // 
            // pnlLedManualHW
            // 
            this.pnlLedManualHW.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLedManualHW.Location = new System.Drawing.Point(301, 165);
            this.pnlLedManualHW.Name = "pnlLedManualHW";
            this.pnlLedManualHW.Size = new System.Drawing.Size(50, 50);
            this.pnlLedManualHW.TabIndex = 143;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 32);
            this.label7.TabIndex = 148;
            this.label7.Text = "Đang chạy...";
            // 
            // pnlLedManualGUI
            // 
            this.pnlLedManualGUI.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLedManualGUI.Location = new System.Drawing.Point(301, 221);
            this.pnlLedManualGUI.Name = "pnlLedManualGUI";
            this.pnlLedManualGUI.Size = new System.Drawing.Size(50, 50);
            this.pnlLedManualGUI.TabIndex = 143;
            // 
            // pnlLedStop
            // 
            this.pnlLedStop.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLedStop.Location = new System.Drawing.Point(301, 277);
            this.pnlLedStop.Name = "pnlLedStop";
            this.pnlLedStop.Size = new System.Drawing.Size(50, 50);
            this.pnlLedStop.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 32);
            this.label9.TabIndex = 150;
            this.label9.Text = "Điều khiển web";
            // 
            // pnlLedRunning
            // 
            this.pnlLedRunning.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLedRunning.Location = new System.Drawing.Point(301, 109);
            this.pnlLedRunning.Name = "pnlLedRunning";
            this.pnlLedRunning.Size = new System.Drawing.Size(50, 50);
            this.pnlLedRunning.TabIndex = 143;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(81, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 32);
            this.label10.TabIndex = 151;
            this.label10.Text = "Dừng khẩn cấp";
            // 
            // pnlLedReady
            // 
            this.pnlLedReady.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLedReady.Location = new System.Drawing.Point(301, 53);
            this.pnlLedReady.Name = "pnlLedReady";
            this.pnlLedReady.Size = new System.Drawing.Size(50, 50);
            this.pnlLedReady.TabIndex = 142;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 32);
            this.label8.TabIndex = 149;
            this.label8.Text = "Điều khiển tay";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Controls.Add(this.panel11, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel12, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1553, 37);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.33811F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.66189F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(479, 931);
            this.tableLayoutPanel5.TabIndex = 181;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Honeydew;
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.pnlLedManualHW);
            this.panel11.Controls.Add(this.pnlLedReady);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.pnlLedManualGUI);
            this.panel11.Controls.Add(this.pnlLedRunning);
            this.panel11.Controls.Add(this.pnlLedStop);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(11, 84);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(457, 354);
            this.panel11.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Honeydew;
            this.panel12.Controls.Add(this.label22);
            this.panel12.Controls.Add(this.label20);
            this.panel12.Controls.Add(this.joystickControl1);
            this.panel12.Controls.Add(this.label19);
            this.panel12.Controls.Add(this.trackServo1);
            this.panel12.Controls.Add(this.label21);
            this.panel12.Controls.Add(this.trackServo2);
            this.panel12.Controls.Add(this.label18);
            this.panel12.Controls.Add(this.trackServo3);
            this.panel12.Controls.Add(this.label17);
            this.panel12.Controls.Add(this.trackServo4);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(11, 468);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(457, 447);
            this.panel12.TabIndex = 1;
            // 
            // joystickControl1
            // 
            this.joystickControl1.Location = new System.Drawing.Point(215, 29);
            this.joystickControl1.Name = "joystickControl1";
            this.joystickControl1.Size = new System.Drawing.Size(136, 130);
            this.joystickControl1.TabIndex = 34;
            this.joystickControl1.OnJoystickMove += new System.Action<int, int>(this.joystickControl1_OnJoystickMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label26);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 75);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.7251154F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.27489F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel6.Controls.Add(this.lvRobotLog, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel13, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.panel14, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel15, 2, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(12, 591);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.13115F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.86885F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1529, 377);
            this.tableLayoutPanel6.TabIndex = 182;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.butreset);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(14, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1500, 75);
            this.panel5.TabIndex = 164;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(588, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(249, 32);
            this.label23.TabIndex = 159;
            this.label23.Text = "Nhật ký vận hành";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(14, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1500, 4);
            this.panel4.TabIndex = 165;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 280);
            this.panel6.TabIndex = 166;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.AliceBlue;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(3, 370);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 4);
            this.panel13.TabIndex = 167;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.AliceBlue;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(1520, 84);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(6, 280);
            this.panel14.TabIndex = 168;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.AliceBlue;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(1520, 370);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(6, 4);
            this.panel15.TabIndex = 169;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(42, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(1071, 54);
            this.label27.TabIndex = 183;
            this.label27.Text = "GIAO DIỆN GIÁM SÁT VÀ ĐIỀU KHIỂN ROBOT";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.butdangxuat);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbgio);
            this.Controls.Add(this.lbngay);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRobotState);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butdangxuat;
        private System.Windows.Forms.Button butthoat;
        private JoystickControl joystickControl1;
        private System.Windows.Forms.Label lbtrangthai;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbocom;
        private System.Windows.Forms.Button butketnoi;
        private System.Windows.Forms.Button butngat;
        private System.Windows.Forms.ComboBox cbobaudrate;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort sercom;
        private System.Windows.Forms.Button butToggleMode;
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button butStart1;
        private System.Windows.Forms.Button butStart2;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.TrackBar trackServo1;
        private System.Windows.Forms.TrackBar trackServo2;
        private System.Windows.Forms.TrackBar trackServo3;
        private System.Windows.Forms.TrackBar trackServo4;
        private System.Windows.Forms.TextBox txtServo1;
        private System.Windows.Forms.TextBox txtServo2;
        private System.Windows.Forms.TextBox txtServo3;
        private System.Windows.Forms.TextBox txtServo4;
        private System.Windows.Forms.TextBox txtStepperX;
        private System.Windows.Forms.TextBox txtStepperY;
        private System.Windows.Forms.TextBox txtRobotState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListView lvRobotLog;
        private System.Windows.Forms.Timer timerLog;
        private System.Windows.Forms.ColumnHeader ngay;
        private System.Windows.Forms.ColumnHeader gio;
        private System.Windows.Forms.ColumnHeader trucx;
        private System.Windows.Forms.ColumnHeader trucy;
        private System.Windows.Forms.ColumnHeader servo1;
        private System.Windows.Forms.ColumnHeader servo2;
        private System.Windows.Forms.ColumnHeader servo3;
        private System.Windows.Forms.ColumnHeader servo4;
        private System.Windows.Forms.ColumnHeader tt;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.Label lbgio;
        private System.Windows.Forms.Label lbngay;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlLedReady;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlLedRunning;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlLedStop;
        private System.Windows.Forms.Panel pnlLedManualGUI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlLedManualHW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
    }
}