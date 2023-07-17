namespace TDD_work
{
    partial class login
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
            this.התחלה = new System.Windows.Forms.Button();
            this.כפתור_סגירה = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // התחלה
            // 
            this.התחלה.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.התחלה.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.התחלה.ForeColor = System.Drawing.Color.White;
            this.התחלה.Location = new System.Drawing.Point(12, 7);
            this.התחלה.Name = "התחלה";
            this.התחלה.Size = new System.Drawing.Size(203, 50);
            this.התחלה.TabIndex = 0;
            this.התחלה.Text = "התחלה";
            this.התחלה.UseVisualStyleBackColor = false;
            this.התחלה.Click += new System.EventHandler(this.button1_Click);
            // 
            // כפתור_סגירה
            // 
            this.כפתור_סגירה.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.כפתור_סגירה.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.כפתור_סגירה.ForeColor = System.Drawing.Color.White;
            this.כפתור_סגירה.Location = new System.Drawing.Point(379, 7);
            this.כפתור_סגירה.Name = "כפתור_סגירה";
            this.כפתור_סגירה.Size = new System.Drawing.Size(203, 50);
            this.כפתור_סגירה.TabIndex = 3;
            this.כפתור_סגירה.Text = "סגירה";
            this.כפתור_סגירה.UseVisualStyleBackColor = false;
            this.כפתור_סגירה.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.כפתור_סגירה);
            this.panelMenu.Controls.Add(this.התחלה);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 365);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(594, 69);
            this.panelMenu.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TDD_work.Properties.Resources.לוגוTDD;
            this.pictureBox1.Location = new System.Drawing.Point(-45, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(594, 60);
            this.panelTitleBar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -7);
            this.label1.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 305);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button התחלה;
        private System.Windows.Forms.Button כפתור_סגירה;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

