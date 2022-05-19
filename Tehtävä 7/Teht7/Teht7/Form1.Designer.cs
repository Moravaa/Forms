namespace Teht7
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
            this.tb_number1 = new System.Windows.Forms.TextBox();
            this.bt_luoTaulukko = new System.Windows.Forms.Button();
            this.tb_tallennettava = new System.Windows.Forms.TextBox();
            this.tb_index1 = new System.Windows.Forms.TextBox();
            this.tb_tallenna = new System.Windows.Forms.Button();
            this.bt_hae = new System.Windows.Forms.Button();
            this.tb_haku = new System.Windows.Forms.TextBox();
            this.tb_palautettuLuku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_number1
            // 
            this.tb_number1.Location = new System.Drawing.Point(135, 65);
            this.tb_number1.Name = "tb_number1";
            this.tb_number1.Size = new System.Drawing.Size(78, 20);
            this.tb_number1.TabIndex = 0;
            this.tb_number1.TextChanged += new System.EventHandler(this.tb_number1_TextChanged);
            // 
            // bt_luoTaulukko
            // 
            this.bt_luoTaulukko.Location = new System.Drawing.Point(240, 60);
            this.bt_luoTaulukko.Name = "bt_luoTaulukko";
            this.bt_luoTaulukko.Size = new System.Drawing.Size(104, 28);
            this.bt_luoTaulukko.TabIndex = 1;
            this.bt_luoTaulukko.Text = "Luo taulukko";
            this.bt_luoTaulukko.UseVisualStyleBackColor = true;
            this.bt_luoTaulukko.Click += new System.EventHandler(this.bt_luoTaulukko_Click);
            // 
            // tb_tallennettava
            // 
            this.tb_tallennettava.Location = new System.Drawing.Point(135, 172);
            this.tb_tallennettava.Name = "tb_tallennettava";
            this.tb_tallennettava.Size = new System.Drawing.Size(78, 20);
            this.tb_tallennettava.TabIndex = 2;
            // 
            // tb_index1
            // 
            this.tb_index1.Location = new System.Drawing.Point(135, 210);
            this.tb_index1.Name = "tb_index1";
            this.tb_index1.Size = new System.Drawing.Size(78, 20);
            this.tb_index1.TabIndex = 3;
            // 
            // tb_tallenna
            // 
            this.tb_tallenna.Location = new System.Drawing.Point(240, 205);
            this.tb_tallenna.Name = "tb_tallenna";
            this.tb_tallenna.Size = new System.Drawing.Size(104, 28);
            this.tb_tallenna.TabIndex = 4;
            this.tb_tallenna.Text = "Tallenna";
            this.tb_tallenna.UseVisualStyleBackColor = true;
            // 
            // bt_hae
            // 
            this.bt_hae.Location = new System.Drawing.Point(231, 324);
            this.bt_hae.Name = "bt_hae";
            this.bt_hae.Size = new System.Drawing.Size(104, 28);
            this.bt_hae.TabIndex = 5;
            this.bt_hae.Text = "Hae";
            this.bt_hae.UseVisualStyleBackColor = true;
            // 
            // tb_haku
            // 
            this.tb_haku.Location = new System.Drawing.Point(135, 329);
            this.tb_haku.Name = "tb_haku";
            this.tb_haku.Size = new System.Drawing.Size(78, 20);
            this.tb_haku.TabIndex = 6;
            // 
            // tb_palautettuLuku
            // 
            this.tb_palautettuLuku.Location = new System.Drawing.Point(135, 390);
            this.tb_palautettuLuku.Name = "tb_palautettuLuku";
            this.tb_palautettuLuku.Size = new System.Drawing.Size(78, 20);
            this.tb_palautettuLuku.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_palautettuLuku);
            this.Controls.Add(this.tb_haku);
            this.Controls.Add(this.bt_hae);
            this.Controls.Add(this.tb_tallenna);
            this.Controls.Add(this.tb_index1);
            this.Controls.Add(this.tb_tallennettava);
            this.Controls.Add(this.bt_luoTaulukko);
            this.Controls.Add(this.tb_number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_number1;
        private System.Windows.Forms.Button bt_luoTaulukko;
        private System.Windows.Forms.TextBox tb_tallennettava;
        private System.Windows.Forms.TextBox tb_index1;
        private System.Windows.Forms.Button tb_tallenna;
        private System.Windows.Forms.Button bt_hae;
        private System.Windows.Forms.TextBox tb_haku;
        private System.Windows.Forms.TextBox tb_palautettuLuku;
    }
}

