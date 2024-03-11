namespace WindowsFormsApp1
{
    partial class HomePage
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.TittleBarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeBox = new System.Windows.Forms.PictureBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.MenuBox = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.TittleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(45)))), ((int)(((byte)(229)))));
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.MenuBox);
            this.MenuPanel.Location = new System.Drawing.Point(-1, -2);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(303, 976);
            this.MenuPanel.TabIndex = 0;
            // 
            // TittleBarPanel
            // 
            this.TittleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(45)))), ((int)(((byte)(229)))));
            this.TittleBarPanel.Controls.Add(this.MinimizeBox);
            this.TittleBarPanel.Controls.Add(this.CloseBox);
            this.TittleBarPanel.Location = new System.Drawing.Point(302, 0);
            this.TittleBarPanel.Name = "TittleBarPanel";
            this.TittleBarPanel.Size = new System.Drawing.Size(1500, 63);
            this.TittleBarPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Image = global::WindowsFormsApp1.Properties.Resources.minus1;
            this.MinimizeBox.Location = new System.Drawing.Point(1388, 27);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(25, 22);
            this.MinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeBox.TabIndex = 1;
            this.MinimizeBox.TabStop = false;
            this.MinimizeBox.Click += new System.EventHandler(this.MinimizeBox_Click);
            // 
            // CloseBox
            // 
            this.CloseBox.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.CloseBox.Location = new System.Drawing.Point(1445, 21);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(21, 20);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBox.TabIndex = 0;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // MenuBox
            // 
            this.MenuBox.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.MenuBox.Location = new System.Drawing.Point(14, 80);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(30, 35);
            this.MenuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuBox.TabIndex = 0;
            this.MenuBox.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 974);
            this.Controls.Add(this.TittleBarPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.TittleBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel TittleBarPanel;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.PictureBox MinimizeBox;
        private System.Windows.Forms.PictureBox MenuBox;
        private System.Windows.Forms.Label label1;
    }
}

