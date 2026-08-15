namespace SearchExtension
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lTime = new System.Windows.Forms.Label();
            this.cbChoicePeriod = new System.Windows.Forms.ComboBox();
            this.lMinutes = new System.Windows.Forms.Label();
            this.lPeriod = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDCoIlePeriod = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bEditExt = new System.Windows.Forms.Button();
            this.tBExtId = new System.Windows.Forms.TextBox();
            this.tBEditExt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bAddExt = new System.Windows.Forms.Button();
            this.tBAddExt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bDeleteRecords = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBHour = new System.Windows.Forms.ComboBox();
            this.cBMinute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tBPath = new System.Windows.Forms.TextBox();
            this.cBSecond = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationAccountEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMsgRecipientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicInProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bLoadPath = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bRun = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIlePeriod)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lTime);
            this.groupBox4.Location = new System.Drawing.Point(7, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 77);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktualny czas:";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTime.Location = new System.Drawing.Point(8, 28);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(79, 29);
            this.lTime.TabIndex = 8;
            this.lTime.Text = "label2";
            // 
            // cbChoicePeriod
            // 
            this.cbChoicePeriod.FormattingEnabled = true;
            this.cbChoicePeriod.Items.AddRange(new object[] {
            "O określonej godzinie",
            "Co określony czas"});
            this.cbChoicePeriod.Location = new System.Drawing.Point(6, 19);
            this.cbChoicePeriod.Name = "cbChoicePeriod";
            this.cbChoicePeriod.Size = new System.Drawing.Size(363, 21);
            this.cbChoicePeriod.TabIndex = 22;
            this.cbChoicePeriod.SelectedIndexChanged += new System.EventHandler(this.CbChoicePeriod_SelectedIndexChanged);
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Enabled = false;
            this.lMinutes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lMinutes.Location = new System.Drawing.Point(301, 106);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(33, 13);
            this.lMinutes.TabIndex = 21;
            this.lMinutes.Text = "Minut";
            // 
            // lPeriod
            // 
            this.lPeriod.AutoSize = true;
            this.lPeriod.Enabled = false;
            this.lPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lPeriod.Location = new System.Drawing.Point(145, 104);
            this.lPeriod.Name = "lPeriod";
            this.lPeriod.Size = new System.Drawing.Size(67, 13);
            this.lPeriod.TabIndex = 20;
            this.lPeriod.Text = "Wykonuj co:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(301, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sekunda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(223, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Minuta:";
            // 
            // nUDCoIlePeriod
            // 
            this.nUDCoIlePeriod.Enabled = false;
            this.nUDCoIlePeriod.Location = new System.Drawing.Point(229, 102);
            this.nUDCoIlePeriod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDCoIlePeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCoIlePeriod.Name = "nUDCoIlePeriod";
            this.nUDCoIlePeriod.Size = new System.Drawing.Size(62, 20);
            this.nUDCoIlePeriod.TabIndex = 12;
            this.nUDCoIlePeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(145, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Godzina:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.bDeleteRecords);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(390, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(427, 254);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menu szukania rozszerzeń plików";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bEditExt);
            this.groupBox6.Controls.Add(this.tBExtId);
            this.groupBox6.Controls.Add(this.tBEditExt);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(221, 104);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 107);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Edycja rozszerzenia:";
            // 
            // bEditExt
            // 
            this.bEditExt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEditExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditExt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bEditExt.Location = new System.Drawing.Point(5, 67);
            this.bEditExt.Name = "bEditExt";
            this.bEditExt.Size = new System.Drawing.Size(189, 33);
            this.bEditExt.TabIndex = 37;
            this.bEditExt.Text = "Edytuj/Wpisz E-mail";
            this.bEditExt.UseVisualStyleBackColor = false;
            this.bEditExt.Click += new System.EventHandler(this.BEditExt_Click);
            // 
            // tBExtId
            // 
            this.tBExtId.Enabled = false;
            this.tBExtId.Location = new System.Drawing.Point(34, 15);
            this.tBExtId.Name = "tBExtId";
            this.tBExtId.Size = new System.Drawing.Size(160, 20);
            this.tBExtId.TabIndex = 38;
            // 
            // tBEditExt
            // 
            this.tBEditExt.Enabled = false;
            this.tBEditExt.Location = new System.Drawing.Point(34, 41);
            this.tBEditExt.Name = "tBEditExt";
            this.tBEditExt.Size = new System.Drawing.Size(160, 20);
            this.tBEditExt.TabIndex = 35;
            this.tBEditExt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBEditExt_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ext:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAddExt);
            this.groupBox2.Controls.Add(this.tBAddExt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(220, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj rozszerzenie:";
            // 
            // bAddExt
            // 
            this.bAddExt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddExt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bAddExt.Location = new System.Drawing.Point(5, 45);
            this.bAddExt.Name = "bAddExt";
            this.bAddExt.Size = new System.Drawing.Size(189, 32);
            this.bAddExt.TabIndex = 34;
            this.bAddExt.Text = "Dodaj rozszerzenie";
            this.bAddExt.UseVisualStyleBackColor = false;
            this.bAddExt.Click += new System.EventHandler(this.BAddExt_Click);
            // 
            // tBAddExt
            // 
            this.tBAddExt.Location = new System.Drawing.Point(35, 17);
            this.tBAddExt.Name = "tBAddExt";
            this.tBAddExt.Size = new System.Drawing.Size(159, 20);
            this.tBAddExt.TabIndex = 29;
            this.tBAddExt.Text = "np: mp4";
            this.tBAddExt.Click += new System.EventHandler(this.TBAddExt_Click);
            this.tBAddExt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBAddExt_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(4, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ext:";
            // 
            // bDeleteRecords
            // 
            this.bDeleteRecords.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDeleteRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteRecords.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bDeleteRecords.Location = new System.Drawing.Point(6, 214);
            this.bDeleteRecords.Name = "bDeleteRecords";
            this.bDeleteRecords.Size = new System.Drawing.Size(415, 34);
            this.bDeleteRecords.TabIndex = 26;
            this.bDeleteRecords.Text = "Usuń wszystkie rekordy";
            this.bDeleteRecords.UseVisualStyleBackColor = false;
            this.bDeleteRecords.Click += new System.EventHandler(this.BDeleteRecords_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(208, 190);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // cBHour
            // 
            this.cBHour.DisplayMember = "0";
            this.cBHour.DropDownHeight = 290;
            this.cBHour.Enabled = false;
            this.cBHour.FormattingEnabled = true;
            this.cBHour.IntegralHeight = false;
            this.cBHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cBHour.Location = new System.Drawing.Point(148, 66);
            this.cBHour.Name = "cBHour";
            this.cBHour.Size = new System.Drawing.Size(65, 21);
            this.cBHour.TabIndex = 14;
            // 
            // cBMinute
            // 
            this.cBMinute.DropDownHeight = 290;
            this.cBMinute.Enabled = false;
            this.cBMinute.FormattingEnabled = true;
            this.cBMinute.IntegralHeight = false;
            this.cBMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBMinute.Location = new System.Drawing.Point(226, 66);
            this.cBMinute.Name = "cBMinute";
            this.cBMinute.Size = new System.Drawing.Size(65, 21);
            this.cBMinute.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(224, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Otwórz lokalizację:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ścieżka:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 108);
            this.listBox1.TabIndex = 1;
            // 
            // tBPath
            // 
            this.tBPath.Enabled = false;
            this.tBPath.Location = new System.Drawing.Point(6, 163);
            this.tBPath.Name = "tBPath";
            this.tBPath.Size = new System.Drawing.Size(313, 20);
            this.tBPath.TabIndex = 2;
            // 
            // cBSecond
            // 
            this.cBSecond.DropDownHeight = 290;
            this.cBSecond.Enabled = false;
            this.cBSecond.FormattingEnabled = true;
            this.cBSecond.IntegralHeight = false;
            this.cBSecond.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBSecond.Location = new System.Drawing.Point(304, 66);
            this.cBSecond.Name = "cBSecond";
            this.cBSecond.Size = new System.Drawing.Size(65, 21);
            this.cBSecond.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cbChoicePeriod);
            this.groupBox3.Controls.Add(this.lMinutes);
            this.groupBox3.Controls.Add(this.lPeriod);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nUDCoIlePeriod);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cBSecond);
            this.groupBox3.Controls.Add(this.cBHour);
            this.groupBox3.Controls.Add(this.cBMinute);
            this.groupBox3.Location = new System.Drawing.Point(4, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 132);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje - czas sprawdzania:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(821, 43);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationAccountEmailToolStripMenuItem,
            this.listOfMsgRecipientsToolStripMenuItem});
            this.configurationToolStripMenuItem.Image = global::SearchExtension.Properties.Resources.icons8_administrative_tools_35;
            this.configurationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(85, 39);
            this.configurationToolStripMenuItem.Text = "Menu";
            // 
            // configurationAccountEmailToolStripMenuItem
            // 
            this.configurationAccountEmailToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.configurationAccountEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configurationAccountEmailToolStripMenuItem.Name = "configurationAccountEmailToolStripMenuItem";
            this.configurationAccountEmailToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.configurationAccountEmailToolStripMenuItem.Text = "Konfiguracja konta E-mail - nadawca";
            this.configurationAccountEmailToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.configurationAccountEmailToolStripMenuItem.Click += new System.EventHandler(this.ConfigurationAccountEmailToolStripMenuItem_Click);
            // 
            // listOfMsgRecipientsToolStripMenuItem
            // 
            this.listOfMsgRecipientsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.listOfMsgRecipientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listOfMsgRecipientsToolStripMenuItem.Name = "listOfMsgRecipientsToolStripMenuItem";
            this.listOfMsgRecipientsToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.listOfMsgRecipientsToolStripMenuItem.Text = "Lista E-mail - odbiorcy";
            this.listOfMsgRecipientsToolStripMenuItem.Click += new System.EventHandler(this.ListOfMsgRecipientsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorInfoToolStripMenuItem,
            this.graphicInProjectToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::SearchExtension.Properties.Resources.icons8_information_35;
            this.helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(111, 39);
            this.helpToolStripMenuItem.Text = "Informacje";
            // 
            // authorInfoToolStripMenuItem
            // 
            this.authorInfoToolStripMenuItem.Name = "authorInfoToolStripMenuItem";
            this.authorInfoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.authorInfoToolStripMenuItem.Text = "Informacja o autorze";
            this.authorInfoToolStripMenuItem.Click += new System.EventHandler(this.AuthorInfoToolStripMenuItem_Click);
            // 
            // graphicInProjectToolStripMenuItem
            // 
            this.graphicInProjectToolStripMenuItem.Name = "graphicInProjectToolStripMenuItem";
            this.graphicInProjectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.graphicInProjectToolStripMenuItem.Text = "Grafika użyta w projekcie";
            this.graphicInProjectToolStripMenuItem.Click += new System.EventHandler(this.GraphicInProjectToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.tBPath);
            this.groupBox1.Controls.Add(this.bLoadPath);
            this.groupBox1.Location = new System.Drawing.Point(4, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 192);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podgląd listy profili:";
            // 
            // bLoadPath
            // 
            this.bLoadPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLoadPath.BackgroundImage = global::SearchExtension.Properties.Resources.icons8_open_50_1_;
            this.bLoadPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLoadPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bLoadPath.Location = new System.Drawing.Point(324, 137);
            this.bLoadPath.Name = "bLoadPath";
            this.bLoadPath.Size = new System.Drawing.Size(49, 48);
            this.bLoadPath.TabIndex = 0;
            this.bLoadPath.UseVisualStyleBackColor = false;
            this.bLoadPath.Click += new System.EventHandler(this.BLoadPath_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 22);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "Status: Nie uruchomiony";
            // 
            // bRun
            // 
            this.bRun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bRun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bRun.Location = new System.Drawing.Point(390, 303);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(427, 66);
            this.bRun.TabIndex = 46;
            this.bRun.Text = "Uruchom";
            this.bRun.UseVisualStyleBackColor = false;
            this.bRun.Click += new System.EventHandler(this.RRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(821, 395);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MD - Automatyczny monitoring danych - Rozszerzeń";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIlePeriod)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.ComboBox cbChoicePeriod;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Label lPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDCoIlePeriod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tBExtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bEditExt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBEditExt;
        private System.Windows.Forms.Button bAddExt;
        private System.Windows.Forms.Button bDeleteRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBAddExt;
        private System.Windows.Forms.ComboBox cBHour;
        private System.Windows.Forms.ComboBox cBMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tBPath;
        private System.Windows.Forms.Button bLoadPath;
        private System.Windows.Forms.ComboBox cBSecond;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationAccountEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfMsgRecipientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorInfoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem graphicInProjectToolStripMenuItem;
    }
}

