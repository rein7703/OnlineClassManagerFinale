
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.Class = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Class
            // 
            this.Class.BackColor = System.Drawing.Color.White;
            this.Class.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Class.BackgroundImage")));
            this.Class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Class.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.ForeColor = System.Drawing.Color.DarkOrange;
            this.Class.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Class.Location = new System.Drawing.Point(144, 191);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(178, 157);
            this.Class.TabIndex = 1;
            this.Class.Text = "Kelas";
            this.Class.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Class.UseVisualStyleBackColor = false;
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.Color.White;
            this.Task.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Task.BackgroundImage")));
            this.Task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Task.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task.ForeColor = System.Drawing.Color.DarkOrange;
            this.Task.Location = new System.Drawing.Point(447, 191);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(165, 157);
            this.Task.TabIndex = 2;
            this.Task.Text = "Tugas";
            this.Task.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Task.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 446);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Class;
        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}