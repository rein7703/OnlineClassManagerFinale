
namespace Kuliah_Manager
{
    partial class Option
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
            this.checkLbl = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkLbl
            // 
            this.checkLbl.AutoSize = true;
            this.checkLbl.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLbl.Location = new System.Drawing.Point(107, 125);
            this.checkLbl.Name = "checkLbl";
            this.checkLbl.Size = new System.Drawing.Size(594, 56);
            this.checkLbl.TabIndex = 0;
            this.checkLbl.Text = "Mau ngecek apa hari ini?";
            // 
            // Class
            // 
            this.Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Class.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Class.Location = new System.Drawing.Point(159, 208);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(182, 121);
            this.Class.TabIndex = 1;
            this.Class.Text = "Kelas";
            this.Class.UseVisualStyleBackColor = false;
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Task.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Task.Location = new System.Drawing.Point(451, 208);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(182, 121);
            this.Task.TabIndex = 2;
            this.Task.Text = "Tugas";
            this.Task.UseVisualStyleBackColor = false;
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(696, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.checkLbl);
            this.Name = "Option";
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkLbl;
        private System.Windows.Forms.Button Class;
        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Button Exit;
    }
}