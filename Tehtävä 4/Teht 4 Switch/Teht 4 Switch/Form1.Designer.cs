namespace Teht_4_Switch
{
    partial class PaaForms
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
            this.bt_Valinta1 = new System.Windows.Forms.Button();
            this.bt_Valinta2 = new System.Windows.Forms.Button();
            this.bt_Valinta3 = new System.Windows.Forms.Button();
            this.bt_Valinta4 = new System.Windows.Forms.Button();
            this.bt_Default = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Valinta1
            // 
            this.bt_Valinta1.Location = new System.Drawing.Point(18, 39);
            this.bt_Valinta1.Name = "bt_Valinta1";
            this.bt_Valinta1.Size = new System.Drawing.Size(110, 30);
            this.bt_Valinta1.TabIndex = 0;
            this.bt_Valinta1.Text = "Valinta1";
            this.bt_Valinta1.UseVisualStyleBackColor = true;
            this.bt_Valinta1.Click += new System.EventHandler(this.bt_Valinta1_Click);
            // 
            // bt_Valinta2
            // 
            this.bt_Valinta2.Location = new System.Drawing.Point(18, 75);
            this.bt_Valinta2.Name = "bt_Valinta2";
            this.bt_Valinta2.Size = new System.Drawing.Size(110, 30);
            this.bt_Valinta2.TabIndex = 1;
            this.bt_Valinta2.Text = "Valinta2";
            this.bt_Valinta2.UseVisualStyleBackColor = true;
            this.bt_Valinta2.Click += new System.EventHandler(this.bt_Valinta2_Click);
            // 
            // bt_Valinta3
            // 
            this.bt_Valinta3.Location = new System.Drawing.Point(18, 111);
            this.bt_Valinta3.Name = "bt_Valinta3";
            this.bt_Valinta3.Size = new System.Drawing.Size(110, 30);
            this.bt_Valinta3.TabIndex = 2;
            this.bt_Valinta3.Text = "Valinta3";
            this.bt_Valinta3.UseVisualStyleBackColor = true;
            this.bt_Valinta3.Click += new System.EventHandler(this.bt_Valinta3_Click);
            // 
            // bt_Valinta4
            // 
            this.bt_Valinta4.Location = new System.Drawing.Point(18, 147);
            this.bt_Valinta4.Name = "bt_Valinta4";
            this.bt_Valinta4.Size = new System.Drawing.Size(110, 30);
            this.bt_Valinta4.TabIndex = 3;
            this.bt_Valinta4.Text = "Valinta4";
            this.bt_Valinta4.UseVisualStyleBackColor = true;
            this.bt_Valinta4.Click += new System.EventHandler(this.bt_Valinta4_Click);
            // 
            // bt_Default
            // 
            this.bt_Default.Location = new System.Drawing.Point(18, 183);
            this.bt_Default.Name = "bt_Default";
            this.bt_Default.Size = new System.Drawing.Size(110, 30);
            this.bt_Default.TabIndex = 4;
            this.bt_Default.Text = "Default";
            this.bt_Default.UseVisualStyleBackColor = true;
            this.bt_Default.Click += new System.EventHandler(this.bt_Default_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // PaaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Default);
            this.Controls.Add(this.bt_Valinta4);
            this.Controls.Add(this.bt_Valinta3);
            this.Controls.Add(this.bt_Valinta2);
            this.Controls.Add(this.bt_Valinta1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaaForms";
            this.Text = "PaaForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Valinta1;
        private System.Windows.Forms.Button bt_Valinta2;
        private System.Windows.Forms.Button bt_Valinta3;
        private System.Windows.Forms.Button bt_Valinta4;
        private System.Windows.Forms.Button bt_Default;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

