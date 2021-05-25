
namespace Kuliah_Manager
{
    partial class frmTaskRemin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskRemin));
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.clearF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDueMin = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbDueHour = new System.Windows.Forms.ComboBox();
            this.lblDueTime = new System.Windows.Forms.Label();
            this.lblDueDay = new System.Windows.Forms.Label();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.tbTaskDesc = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbDueDay = new System.Windows.Forms.ComboBox();
            this.lblNotif = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDate.Location = new System.Drawing.Point(65, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 32);
            this.lblDate.TabIndex = 67;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(851, 703);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(35, 35);
            this.axWindowsMediaPlayer1.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(172, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 32);
            this.label6.TabIndex = 65;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(112, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 32);
            this.label5.TabIndex = 64;
            this.label5.Text = ":";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSec.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSec.Location = new System.Drawing.Point(192, 55);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(43, 32);
            this.lblSec.TabIndex = 63;
            this.lblSec.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblMin.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMin.Location = new System.Drawing.Point(129, 54);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(43, 32);
            this.lblMin.TabIndex = 62;
            this.lblMin.Text = "00";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblHour.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHour.Location = new System.Drawing.Point(67, 54);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(43, 32);
            this.lblHour.TabIndex = 61;
            this.lblHour.Text = "00";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(163, 614);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 40);
            this.btnRefresh.TabIndex = 60;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(675, 208);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 36);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(143, 210);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(514, 34);
            this.tbSearch.TabIndex = 58;
            this.tbSearch.Text = "Enter Full Task Name";
            // 
            // clearF
            // 
            this.clearF.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clearF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearF.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.clearF.ForeColor = System.Drawing.Color.White;
            this.clearF.Location = new System.Drawing.Point(262, 614);
            this.clearF.Name = "clearF";
            this.clearF.Size = new System.Drawing.Size(164, 40);
            this.clearF.TabIndex = 56;
            this.clearF.Text = "Clear Form";
            this.clearF.UseVisualStyleBackColor = false;
            this.clearF.Click += new System.EventHandler(this.clearF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label1.Location = new System.Drawing.Point(237, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = ":";
            // 
            // cbDueMin
            // 
            this.cbDueMin.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cbDueMin.FormattingEnabled = true;
            this.cbDueMin.Items.AddRange(new object[] {
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
            this.cbDueMin.Location = new System.Drawing.Point(255, 509);
            this.cbDueMin.Name = "cbDueMin";
            this.cbDueMin.Size = new System.Drawing.Size(65, 33);
            this.cbDueMin.TabIndex = 54;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(366, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(267, 560);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 40);
            this.btnEdit.TabIndex = 52;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(163, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 40);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbDueHour
            // 
            this.cbDueHour.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cbDueHour.FormattingEnabled = true;
            this.cbDueHour.Items.AddRange(new object[] {
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
            this.cbDueHour.Location = new System.Drawing.Point(164, 509);
            this.cbDueHour.Name = "cbDueHour";
            this.cbDueHour.Size = new System.Drawing.Size(65, 33);
            this.cbDueHour.TabIndex = 49;
            // 
            // lblDueTime
            // 
            this.lblDueTime.AutoSize = true;
            this.lblDueTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDueTime.Location = new System.Drawing.Point(36, 509);
            this.lblDueTime.Name = "lblDueTime";
            this.lblDueTime.Size = new System.Drawing.Size(96, 28);
            this.lblDueTime.TabIndex = 48;
            this.lblDueTime.Text = "Due Hour";
            // 
            // lblDueDay
            // 
            this.lblDueDay.AutoSize = true;
            this.lblDueDay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDueDay.Location = new System.Drawing.Point(36, 465);
            this.lblDueDay.Name = "lblDueDay";
            this.lblDueDay.Size = new System.Drawing.Size(86, 28);
            this.lblDueDay.TabIndex = 46;
            this.lblDueDay.Text = "Due Day";
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.AutoSize = true;
            this.lblTaskDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTaskDesc.Location = new System.Drawing.Point(36, 328);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(91, 28);
            this.lblTaskDesc.TabIndex = 44;
            this.lblTaskDesc.Text = "Deskripsi";
            // 
            // tbTaskDesc
            // 
            this.tbTaskDesc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.tbTaskDesc.Location = new System.Drawing.Point(165, 328);
            this.tbTaskDesc.Multiline = true;
            this.tbTaskDesc.Name = "tbTaskDesc";
            this.tbTaskDesc.Size = new System.Drawing.Size(278, 128);
            this.tbTaskDesc.TabIndex = 43;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblClassName.Location = new System.Drawing.Point(36, 287);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(114, 28);
            this.lblClassName.TabIndex = 42;
            this.lblClassName.Text = "Nama Kelas";
            // 
            // tbClassName
            // 
            this.tbClassName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.tbClassName.Location = new System.Drawing.Point(165, 287);
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(278, 31);
            this.tbClassName.TabIndex = 41;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTaskName.Location = new System.Drawing.Point(36, 245);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(120, 28);
            this.lblTaskName.TabIndex = 40;
            this.lblTaskName.Text = "Nama Tugas";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.tbTaskName.Location = new System.Drawing.Point(165, 245);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(278, 31);
            this.tbTaskName.TabIndex = 39;
            // 
            // dgvTask
            // 
            this.dgvTask.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTask.Location = new System.Drawing.Point(37, 258);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.RowTemplate.Height = 24;
            this.dgvTask.Size = new System.Drawing.Size(836, 406);
            this.dgvTask.TabIndex = 37;
            this.dgvTask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClass_MouseClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(77, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(331, 54);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "TASK MANAGER";
            // 
            // cbDueDay
            // 
            this.cbDueDay.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cbDueDay.FormattingEnabled = true;
            this.cbDueDay.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.cbDueDay.Location = new System.Drawing.Point(165, 467);
            this.cbDueDay.Name = "cbDueDay";
            this.cbDueDay.Size = new System.Drawing.Size(121, 33);
            this.cbDueDay.TabIndex = 68;
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNotif.Location = new System.Drawing.Point(73, 12);
            this.lblNotif.MaximumSize = new System.Drawing.Size(649, 0);
            this.lblNotif.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(200, 28);
            this.lblNotif.TabIndex = 69;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(11, 698);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(109, 40);
            this.Back.TabIndex = 70;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dgvTask);
            this.panel3.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Location = new System.Drawing.Point(489, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 755);
            this.panel3.TabIndex = 78;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNotif);
            this.panel2.Location = new System.Drawing.Point(37, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 49);
            this.panel2.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 30);
            this.label2.TabIndex = 81;
            this.label2.Text = "🔔";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 28);
            this.label4.TabIndex = 80;
            this.label4.Text = "🕔";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 28);
            this.label3.TabIndex = 79;
            this.label3.Text = "📆";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblSec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblHour);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(17, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 111);
            this.panel1.TabIndex = 82;
            // 
            // frmTaskRemin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1387, 747);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.cbDueDay);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.clearF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDueMin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbDueHour);
            this.Controls.Add(this.lblDueTime);
            this.Controls.Add(this.lblDueDay);
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.tbTaskDesc);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.tbClassName);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTaskRemin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.Load += new System.EventHandler(this.frmTaskRemin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button clearF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDueMin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbDueHour;
        private System.Windows.Forms.Label lblDueTime;
        private System.Windows.Forms.Label lblDueDay;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.TextBox tbTaskDesc;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbDueDay;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}