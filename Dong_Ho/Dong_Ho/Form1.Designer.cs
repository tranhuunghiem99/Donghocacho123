
namespace Dong_Ho
{
    partial class frmmain
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.lbltime = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grsettime = new System.Windows.Forms.GroupBox();
            this.numgio = new System.Windows.Forms.NumericUpDown();
            this.numphut = new System.Windows.Forms.NumericUpDown();
            this.numgiay = new System.Windows.Forms.NumericUpDown();
            this.groption = new System.Windows.Forms.GroupBox();
            this.raddoinhac = new System.Windows.Forms.RadioButton();
            this.radTheme = new System.Windows.Forms.RadioButton();
            this.radTime = new System.Windows.Forms.RadioButton();
            this.radCount_down = new System.Windows.Forms.RadioButton();
            this.grcontrol = new System.Windows.Forms.GroupBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grluachon = new System.Windows.Forms.GroupBox();
            this.grluuy = new System.Windows.Forms.GroupBox();
            this.lblluuy = new System.Windows.Forms.Label();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.btnfilechoise = new System.Windows.Forms.Button();
            this.radother = new System.Windows.Forms.RadioButton();
            this.radDefault = new System.Windows.Forms.RadioButton();
            this.lstchon = new System.Windows.Forms.ListBox();
            this.btncan = new System.Windows.Forms.Button();
            this.btnOki = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.grmonth = new System.Windows.Forms.GroupBox();
            this.grcolor = new System.Windows.Forms.GroupBox();
            this.lbldark = new System.Windows.Forms.Label();
            this.btnchangecolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltimer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grsettime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numgio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numphut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgiay)).BeginInit();
            this.groption.SuspendLayout();
            this.grcontrol.SuspendLayout();
            this.grluachon.SuspendLayout();
            this.grluuy.SuspendLayout();
            this.grmonth.SuspendLayout();
            this.grcolor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltime
            // 
            this.lbltime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltime.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(0, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(712, 129);
            this.lbltime.TabIndex = 0;
            this.lbltime.Text = "00:00:00";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 129);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grsettime);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groption);
            this.splitContainer1.Panel2.Controls.Add(this.grcontrol);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitContainer1.Size = new System.Drawing.Size(712, 263);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 1;
            // 
            // grsettime
            // 
            this.grsettime.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.grsettime.Controls.Add(this.numgio);
            this.grsettime.Controls.Add(this.numphut);
            this.grsettime.Controls.Add(this.numgiay);
            this.grsettime.Location = new System.Drawing.Point(31, 15);
            this.grsettime.Margin = new System.Windows.Forms.Padding(4);
            this.grsettime.Name = "grsettime";
            this.grsettime.Padding = new System.Windows.Forms.Padding(4);
            this.grsettime.Size = new System.Drawing.Size(651, 60);
            this.grsettime.TabIndex = 3;
            this.grsettime.TabStop = false;
            this.grsettime.Text = "SetTime";
            // 
            // numgio
            // 
            this.numgio.Location = new System.Drawing.Point(28, 23);
            this.numgio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numgio.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numgio.Name = "numgio";
            this.numgio.Size = new System.Drawing.Size(120, 22);
            this.numgio.TabIndex = 0;
            this.numgio.ValueChanged += new System.EventHandler(this.numgio_ValueChanged);
            // 
            // numphut
            // 
            this.numphut.Location = new System.Drawing.Point(263, 23);
            this.numphut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numphut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numphut.Name = "numphut";
            this.numphut.Size = new System.Drawing.Size(120, 22);
            this.numphut.TabIndex = 1;
            this.numphut.ValueChanged += new System.EventHandler(this.numphut_ValueChanged);
            // 
            // numgiay
            // 
            this.numgiay.Location = new System.Drawing.Point(479, 23);
            this.numgiay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numgiay.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numgiay.Name = "numgiay";
            this.numgiay.Size = new System.Drawing.Size(120, 22);
            this.numgiay.TabIndex = 2;
            this.numgiay.ValueChanged += new System.EventHandler(this.numgiay_ValueChanged);
            // 
            // groption
            // 
            this.groption.Controls.Add(this.raddoinhac);
            this.groption.Controls.Add(this.radTheme);
            this.groption.Controls.Add(this.radTime);
            this.groption.Controls.Add(this.radCount_down);
            this.groption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groption.Location = new System.Drawing.Point(487, 16);
            this.groption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groption.Name = "groption";
            this.groption.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groption.Size = new System.Drawing.Size(172, 140);
            this.groption.TabIndex = 4;
            this.groption.TabStop = false;
            this.groption.Text = "Option";
            // 
            // raddoinhac
            // 
            this.raddoinhac.AutoSize = true;
            this.raddoinhac.Location = new System.Drawing.Point(21, 102);
            this.raddoinhac.Margin = new System.Windows.Forms.Padding(4);
            this.raddoinhac.Name = "raddoinhac";
            this.raddoinhac.Size = new System.Drawing.Size(130, 21);
            this.raddoinhac.TabIndex = 1;
            this.raddoinhac.TabStop = true;
            this.raddoinhac.Text = "Change Music";
            this.raddoinhac.UseVisualStyleBackColor = true;
            this.raddoinhac.CheckedChanged += new System.EventHandler(this.raddoinhac_CheckedChanged);
            // 
            // radTheme
            // 
            this.radTheme.AutoSize = true;
            this.radTheme.Location = new System.Drawing.Point(21, 74);
            this.radTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTheme.Name = "radTheme";
            this.radTheme.Size = new System.Drawing.Size(78, 21);
            this.radTheme.TabIndex = 0;
            this.radTheme.Text = "Theme";
            this.radTheme.UseVisualStyleBackColor = true;
            this.radTheme.CheckedChanged += new System.EventHandler(this.radTheme_CheckedChanged);
            // 
            // radTime
            // 
            this.radTime.AutoSize = true;
            this.radTime.Location = new System.Drawing.Point(21, 48);
            this.radTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTime.Name = "radTime";
            this.radTime.Size = new System.Drawing.Size(64, 21);
            this.radTime.TabIndex = 0;
            this.radTime.Text = "Time";
            this.radTime.UseVisualStyleBackColor = true;
            this.radTime.CheckedChanged += new System.EventHandler(this.radTime_CheckedChanged);
            // 
            // radCount_down
            // 
            this.radCount_down.AutoSize = true;
            this.radCount_down.Checked = true;
            this.radCount_down.Location = new System.Drawing.Point(21, 20);
            this.radCount_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCount_down.Name = "radCount_down";
            this.radCount_down.Size = new System.Drawing.Size(115, 21);
            this.radCount_down.TabIndex = 0;
            this.radCount_down.TabStop = true;
            this.radCount_down.Text = "Count Down";
            this.radCount_down.UseVisualStyleBackColor = true;
            this.radCount_down.CheckedChanged += new System.EventHandler(this.radCount_down_CheckedChanged);
            // 
            // grcontrol
            // 
            this.grcontrol.BackColor = System.Drawing.SystemColors.Control;
            this.grcontrol.Controls.Add(this.btnstop);
            this.grcontrol.Controls.Add(this.btnreset);
            this.grcontrol.Controls.Add(this.btnstart);
            this.grcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcontrol.Location = new System.Drawing.Point(31, 63);
            this.grcontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcontrol.Name = "grcontrol";
            this.grcontrol.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcontrol.Size = new System.Drawing.Size(400, 94);
            this.grcontrol.TabIndex = 3;
            this.grcontrol.TabStop = false;
            this.grcontrol.Text = "Control";
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(277, 21);
            this.btnstop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(92, 58);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(140, 21);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(92, 58);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(11, 21);
            this.btnstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(92, 58);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grluachon
            // 
            this.grluachon.Controls.Add(this.grluuy);
            this.grluachon.Controls.Add(this.txtlink);
            this.grluachon.Controls.Add(this.btnfilechoise);
            this.grluachon.Controls.Add(this.radother);
            this.grluachon.Controls.Add(this.radDefault);
            this.grluachon.Controls.Add(this.lstchon);
            this.grluachon.Controls.Add(this.btncan);
            this.grluachon.Controls.Add(this.btnOki);
            this.grluachon.Location = new System.Drawing.Point(0, 0);
            this.grluachon.Margin = new System.Windows.Forms.Padding(4);
            this.grluachon.Name = "grluachon";
            this.grluachon.Padding = new System.Windows.Forms.Padding(4);
            this.grluachon.Size = new System.Drawing.Size(480, 385);
            this.grluachon.TabIndex = 4;
            this.grluachon.TabStop = false;
            this.grluachon.Text = "Lựa Chọn";
            this.grluachon.Visible = false;
            // 
            // grluuy
            // 
            this.grluuy.Controls.Add(this.lblluuy);
            this.grluuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grluuy.ForeColor = System.Drawing.Color.Red;
            this.grluuy.Location = new System.Drawing.Point(24, 255);
            this.grluuy.Margin = new System.Windows.Forms.Padding(4);
            this.grluuy.Name = "grluuy";
            this.grluuy.Padding = new System.Windows.Forms.Padding(4);
            this.grluuy.Size = new System.Drawing.Size(444, 76);
            this.grluuy.TabIndex = 7;
            this.grluuy.TabStop = false;
            this.grluuy.Text = "Lưu ý:";
            // 
            // lblluuy
            // 
            this.lblluuy.ForeColor = System.Drawing.Color.Black;
            this.lblluuy.Location = new System.Drawing.Point(19, 17);
            this.lblluuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblluuy.Name = "lblluuy";
            this.lblluuy.Size = new System.Drawing.Size(387, 34);
            this.lblluuy.TabIndex = 6;
            this.lblluuy.Text = "Bro! Không muốn rắc rối thì liệu hồn mà chọn file có đuôi .mav đi";
            // 
            // txtlink
            // 
            this.txtlink.Enabled = false;
            this.txtlink.Location = new System.Drawing.Point(24, 225);
            this.txtlink.Margin = new System.Windows.Forms.Padding(4);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(401, 22);
            this.txtlink.TabIndex = 5;
            // 
            // btnfilechoise
            // 
            this.btnfilechoise.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnfilechoise.Location = new System.Drawing.Point(436, 224);
            this.btnfilechoise.Margin = new System.Windows.Forms.Padding(4);
            this.btnfilechoise.Name = "btnfilechoise";
            this.btnfilechoise.Size = new System.Drawing.Size(32, 25);
            this.btnfilechoise.TabIndex = 4;
            this.btnfilechoise.Text = "...";
            this.btnfilechoise.UseVisualStyleBackColor = true;
            this.btnfilechoise.Click += new System.EventHandler(this.btnfilechoise_Click);
            // 
            // radother
            // 
            this.radother.AutoSize = true;
            this.radother.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radother.Location = new System.Drawing.Point(27, 197);
            this.radother.Margin = new System.Windows.Forms.Padding(4);
            this.radother.Name = "radother";
            this.radother.Size = new System.Drawing.Size(99, 21);
            this.radother.TabIndex = 3;
            this.radother.Text = "Other file...";
            this.radother.UseVisualStyleBackColor = true;
            this.radother.CheckedChanged += new System.EventHandler(this.radother_CheckedChanged);
            // 
            // radDefault
            // 
            this.radDefault.AutoSize = true;
            this.radDefault.Checked = true;
            this.radDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radDefault.Location = new System.Drawing.Point(24, 20);
            this.radDefault.Margin = new System.Windows.Forms.Padding(4);
            this.radDefault.Name = "radDefault";
            this.radDefault.Size = new System.Drawing.Size(74, 21);
            this.radDefault.TabIndex = 3;
            this.radDefault.TabStop = true;
            this.radDefault.Text = "Default";
            this.radDefault.UseVisualStyleBackColor = true;
            this.radDefault.CheckedChanged += new System.EventHandler(this.radDefault_CheckedChanged);
            // 
            // lstchon
            // 
            this.lstchon.FormattingEnabled = true;
            this.lstchon.ItemHeight = 16;
            this.lstchon.Items.AddRange(new object[] {
            "Alarm01",
            "Alarm02",
            "Alarm03",
            "Alarm04",
            "Alarm05",
            "Alarm06",
            "Alarm07",
            "Alarm08",
            "Alarm09",
            "Alarm10"});
            this.lstchon.Location = new System.Drawing.Point(24, 49);
            this.lstchon.Margin = new System.Windows.Forms.Padding(4);
            this.lstchon.Name = "lstchon";
            this.lstchon.Size = new System.Drawing.Size(149, 132);
            this.lstchon.TabIndex = 2;
            this.lstchon.SelectedIndexChanged += new System.EventHandler(this.lstchon_SelectedIndexChanged);
            // 
            // btncan
            // 
            this.btncan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btncan.Location = new System.Drawing.Point(237, 337);
            this.btncan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(128, 23);
            this.btncan.TabIndex = 1;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btnOki
            // 
            this.btnOki.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOki.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOki.Location = new System.Drawing.Point(39, 337);
            this.btnOki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOki.Name = "btnOki";
            this.btnOki.Size = new System.Drawing.Size(128, 23);
            this.btnOki.TabIndex = 1;
            this.btnOki.Text = "OK";
            this.btnOki.UseVisualStyleBackColor = true;
            this.btnOki.Click += new System.EventHandler(this.btnOki_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(33, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // grmonth
            // 
            this.grmonth.Controls.Add(this.monthCalendar1);
            this.grmonth.Location = new System.Drawing.Point(31, 129);
            this.grmonth.Name = "grmonth";
            this.grmonth.Size = new System.Drawing.Size(369, 245);
            this.grmonth.TabIndex = 4;
            this.grmonth.TabStop = false;
            this.grmonth.Text = "Lịch";
            this.grmonth.Visible = false;
            // 
            // grcolor
            // 
            this.grcolor.Controls.Add(this.lbldark);
            this.grcolor.Controls.Add(this.btnchangecolor);
            this.grcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcolor.Location = new System.Drawing.Point(0, 128);
            this.grcolor.Name = "grcolor";
            this.grcolor.Size = new System.Drawing.Size(411, 264);
            this.grcolor.TabIndex = 5;
            this.grcolor.TabStop = false;
            this.grcolor.Text = "Choise Background";
            this.grcolor.Visible = false;
            // 
            // lbldark
            // 
            this.lbldark.AutoSize = true;
            this.lbldark.Location = new System.Drawing.Point(70, 158);
            this.lbldark.Name = "lbldark";
            this.lbldark.Size = new System.Drawing.Size(0, 17);
            this.lbldark.TabIndex = 1;
            // 
            // btnchangecolor
            // 
            this.btnchangecolor.Location = new System.Drawing.Point(64, 80);
            this.btnchangecolor.Name = "btnchangecolor";
            this.btnchangecolor.Size = new System.Drawing.Size(152, 56);
            this.btnchangecolor.TabIndex = 0;
            this.btnchangecolor.Text = "Change Colors";
            this.btnchangecolor.UseVisualStyleBackColor = true;
            this.btnchangecolor.Click += new System.EventHandler(this.btnchangecolor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grcolor);
            this.panel1.Controls.Add(this.grluachon);
            this.panel1.Controls.Add(this.grmonth);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.lbltimer);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 392);
            this.panel1.TabIndex = 8;
            // 
            // lbltimer
            // 
            this.lbltimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltimer.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(3, 0);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(712, 129);
            this.lbltimer.TabIndex = 9;
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltimer.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 393);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồng Hồ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grsettime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numgio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numphut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgiay)).EndInit();
            this.groption.ResumeLayout(false);
            this.groption.PerformLayout();
            this.grcontrol.ResumeLayout(false);
            this.grluachon.ResumeLayout(false);
            this.grluachon.PerformLayout();
            this.grluuy.ResumeLayout(false);
            this.grmonth.ResumeLayout(false);
            this.grcolor.ResumeLayout(false);
            this.grcolor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.NumericUpDown numgio;
        private System.Windows.Forms.NumericUpDown numgiay;
        private System.Windows.Forms.NumericUpDown numphut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.GroupBox groption;
        private System.Windows.Forms.RadioButton radTheme;
        private System.Windows.Forms.RadioButton radTime;
        private System.Windows.Forms.RadioButton radCount_down;
        private System.Windows.Forms.GroupBox grcontrol;
        private System.Windows.Forms.GroupBox grsettime;
        private System.Windows.Forms.RadioButton raddoinhac;
        private System.Windows.Forms.GroupBox grluachon;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Button btnfilechoise;
        private System.Windows.Forms.RadioButton radother;
        private System.Windows.Forms.RadioButton radDefault;
        private System.Windows.Forms.ListBox lstchon;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btnOki;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grluuy;
        private System.Windows.Forms.Label lblluuy;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox grmonth;
        private System.Windows.Forms.GroupBox grcolor;
        private System.Windows.Forms.Button btnchangecolor;
        
        private System.Windows.Forms.Label lbldark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Timer timer2;
    }
}

