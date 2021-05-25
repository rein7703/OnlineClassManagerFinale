
namespace Kuliah_Manager
{
    partial class frmClassReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassReminder));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.tbMatkul = new System.Windows.Forms.TextBox();
            this.lblMatkul = new System.Windows.Forms.Label();
            this.lblMeeting = new System.Windows.Forms.Label();
            this.tbMeeting = new System.Windows.Forms.TextBox();
            this.lblPresensi = new System.Windows.Forms.Label();
            this.tbPresensi = new System.Windows.Forms.TextBox();
            this.lblDrive = new System.Windows.Forms.Label();
            this.tbDrive = new System.Windows.Forms.TextBox();
            this.cbHari = new System.Windows.Forms.ComboBox();
            this.lblHari = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbMin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearF = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNotif = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(591, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Class Manager";
            this.lblTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(30, 247);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(836, 406);
            this.dgvClass.TabIndex = 2;
            this.dgvClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            this.dgvClass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClass_MouseClick);
            // 
            // tbMatkul
            // 
            this.tbMatkul.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatkul.Location = new System.Drawing.Point(177, 240);
            this.tbMatkul.Name = "tbMatkul";
            this.tbMatkul.Size = new System.Drawing.Size(291, 31);
            this.tbMatkul.TabIndex = 4;
            // 
            // lblMatkul
            // 
            this.lblMatkul.AutoSize = true;
            this.lblMatkul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkul.Location = new System.Drawing.Point(32, 240);
            this.lblMatkul.Name = "lblMatkul";
            this.lblMatkul.Size = new System.Drawing.Size(130, 28);
            this.lblMatkul.TabIndex = 5;
            this.lblMatkul.Text = "Nama Matkul";
            // 
            // lblMeeting
            // 
            this.lblMeeting.AutoSize = true;
            this.lblMeeting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeeting.Location = new System.Drawing.Point(32, 291);
            this.lblMeeting.Name = "lblMeeting";
            this.lblMeeting.Size = new System.Drawing.Size(125, 28);
            this.lblMeeting.TabIndex = 7;
            this.lblMeeting.Text = "Link Meeting";
            // 
            // tbMeeting
            // 
            this.tbMeeting.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMeeting.Location = new System.Drawing.Point(177, 278);
            this.tbMeeting.Multiline = true;
            this.tbMeeting.Name = "tbMeeting";
            this.tbMeeting.Size = new System.Drawing.Size(291, 60);
            this.tbMeeting.TabIndex = 6;
            // 
            // lblPresensi
            // 
            this.lblPresensi.AutoSize = true;
            this.lblPresensi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresensi.Location = new System.Drawing.Point(32, 357);
            this.lblPresensi.Name = "lblPresensi";
            this.lblPresensi.Size = new System.Drawing.Size(122, 28);
            this.lblPresensi.TabIndex = 9;
            this.lblPresensi.Text = "Link Presensi";
            // 
            // tbPresensi
            // 
            this.tbPresensi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPresensi.Location = new System.Drawing.Point(177, 345);
            this.tbPresensi.Multiline = true;
            this.tbPresensi.Name = "tbPresensi";
            this.tbPresensi.Size = new System.Drawing.Size(291, 60);
            this.tbPresensi.TabIndex = 8;
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive.Location = new System.Drawing.Point(32, 424);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(98, 28);
            this.lblDrive.TabIndex = 11;
            this.lblDrive.Text = "Link Drive";
            // 
            // tbDrive
            // 
            this.tbDrive.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDrive.Location = new System.Drawing.Point(177, 411);
            this.tbDrive.Multiline = true;
            this.tbDrive.Name = "tbDrive";
            this.tbDrive.Size = new System.Drawing.Size(291, 60);
            this.tbDrive.TabIndex = 10;
            // 
            // cbHari
            // 
            this.cbHari.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHari.FormattingEnabled = true;
            this.cbHari.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.cbHari.Location = new System.Drawing.Point(177, 477);
            this.cbHari.Name = "cbHari";
            this.cbHari.Size = new System.Drawing.Size(122, 33);
            this.cbHari.TabIndex = 12;
            this.cbHari.SelectedIndexChanged += new System.EventHandler(this.cbHari_SelectedIndexChanged);
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHari.Location = new System.Drawing.Point(32, 477);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(48, 28);
            this.lblHari.TabIndex = 13;
            this.lblHari.Text = "Hari";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.Location = new System.Drawing.Point(32, 522);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(68, 28);
            this.lblWaktu.TabIndex = 15;
            this.lblWaktu.Text = "Waktu";
            // 
            // cbHour
            // 
            this.cbHour.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
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
            "24"});
            this.cbHour.Location = new System.Drawing.Point(177, 517);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(50, 33);
            this.cbHour.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(175, 567);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 33);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(277, 567);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 33);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(378, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbMin
            // 
            this.cbMin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMin.FormattingEnabled = true;
            this.cbMin.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbMin.Location = new System.Drawing.Point(248, 516);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(51, 33);
            this.cbMin.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = ":";
            // 
            // clearF
            // 
            this.clearF.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clearF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearF.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearF.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearF.Location = new System.Drawing.Point(277, 613);
            this.clearF.Name = "clearF";
            this.clearF.Size = new System.Drawing.Size(191, 33);
            this.clearF.TabIndex = 23;
            this.clearF.Text = "Clear Form";
            this.clearF.UseVisualStyleBackColor = false;
            this.clearF.Click += new System.EventHandler(this.clearF_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(138, 197);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(514, 34);
            this.tbSearch.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(658, 194);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 40);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Location = new System.Drawing.Point(177, 613);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 33);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHour.Location = new System.Drawing.Point(54, 59);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(43, 32);
            this.lblHour.TabIndex = 28;
            this.lblHour.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMin.Location = new System.Drawing.Point(124, 59);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(43, 32);
            this.lblMin.TabIndex = 29;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSec.Location = new System.Drawing.Point(194, 60);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(43, 32);
            this.lblSec.TabIndex = 30;
            this.lblSec.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(99, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(174, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1337, 21);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(38, 30);
            this.axWindowsMediaPlayer1.TabIndex = 34;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDate.Location = new System.Drawing.Point(53, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 32);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Date";
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNotif.Location = new System.Drawing.Point(58, 11);
            this.lblNotif.MaximumSize = new System.Drawing.Size(649, 0);
            this.lblNotif.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(100, 28);
            this.lblNotif.TabIndex = 70;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.back.Location = new System.Drawing.Point(8, 698);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 39);
            this.back.TabIndex = 71;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblSec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblHour);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(24, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 115);
            this.panel1.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 32);
            this.label4.TabIndex = 74;
            this.label4.Text = "🕔";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 32);
            this.label3.TabIndex = 73;
            this.label3.Text = "📆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 30);
            this.label2.TabIndex = 75;
            this.label2.Text = "🔔";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNotif);
            this.panel2.Location = new System.Drawing.Point(522, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 49);
            this.panel2.TabIndex = 76;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.dgvClass);
            this.panel3.Location = new System.Drawing.Point(492, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 755);
            this.panel3.TabIndex = 77;
            // 
            // frmClassReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1387, 747);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.clearF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.lblHari);
            this.Controls.Add(this.cbHari);
            this.Controls.Add(this.lblDrive);
            this.Controls.Add(this.tbDrive);
            this.Controls.Add(this.lblPresensi);
            this.Controls.Add(this.tbPresensi);
            this.Controls.Add(this.lblMeeting);
            this.Controls.Add(this.tbMeeting);
            this.Controls.Add(this.lblMatkul);
            this.Controls.Add(this.tbMatkul);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmClassReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmClassReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.TextBox tbMatkul;
        private System.Windows.Forms.Label lblMatkul;
        private System.Windows.Forms.Label lblMeeting;
        private System.Windows.Forms.TextBox tbMeeting;
        private System.Windows.Forms.Label lblPresensi;
        private System.Windows.Forms.TextBox tbPresensi;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.TextBox tbDrive;
        private System.Windows.Forms.ComboBox cbHari;
        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearF;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

