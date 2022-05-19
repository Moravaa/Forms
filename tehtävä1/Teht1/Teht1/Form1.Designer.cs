namespace Teht1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Elokuva_id = new System.Windows.Forms.TextBox();
            this.tb_ElokuvaNimi = new System.Windows.Forms.TextBox();
            this.tb_release = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.btTietue = new System.Windows.Forms.Button();
            this.btTallenna = new System.Windows.Forms.Button();
            this.btPoista = new System.Windows.Forms.Button();
            this.btEdelinen = new System.Windows.Forms.Button();
            this.btSeuraava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_arvio = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostotToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostotToolStripMenuItem
            // 
            this.tiedostotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostotToolStripMenuItem.Name = "tiedostotToolStripMenuItem";
            this.tiedostotToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tiedostotToolStripMenuItem.Text = "Tiedostot";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            this.tietojaToolStripMenuItem.Click += new System.EventHandler(this.tietojaToolStripMenuItem_Click);
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Release date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time (min):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_Elokuva_id
            // 
            this.tb_Elokuva_id.Location = new System.Drawing.Point(127, 26);
            this.tb_Elokuva_id.Name = "tb_Elokuva_id";
            this.tb_Elokuva_id.Size = new System.Drawing.Size(126, 20);
            this.tb_Elokuva_id.TabIndex = 5;
            this.tb_Elokuva_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_ElokuvaNimi
            // 
            this.tb_ElokuvaNimi.Location = new System.Drawing.Point(127, 55);
            this.tb_ElokuvaNimi.Name = "tb_ElokuvaNimi";
            this.tb_ElokuvaNimi.Size = new System.Drawing.Size(126, 20);
            this.tb_ElokuvaNimi.TabIndex = 6;
            this.tb_ElokuvaNimi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_release
            // 
            this.tb_release.Location = new System.Drawing.Point(127, 93);
            this.tb_release.Name = "tb_release";
            this.tb_release.Size = new System.Drawing.Size(126, 20);
            this.tb_release.TabIndex = 7;
            this.tb_release.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(127, 140);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(126, 20);
            this.tb_time.TabIndex = 8;
            this.tb_time.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btTietue
            // 
            this.btTietue.Location = new System.Drawing.Point(21, 29);
            this.btTietue.Name = "btTietue";
            this.btTietue.Size = new System.Drawing.Size(239, 54);
            this.btTietue.TabIndex = 9;
            this.btTietue.Text = "Uusi tietue";
            this.btTietue.UseVisualStyleBackColor = true;
            this.btTietue.Click += new System.EventHandler(this.btTietue_Click);
            // 
            // btTallenna
            // 
            this.btTallenna.BackColor = System.Drawing.Color.Lime;
            this.btTallenna.Location = new System.Drawing.Point(21, 96);
            this.btTallenna.Name = "btTallenna";
            this.btTallenna.Size = new System.Drawing.Size(239, 54);
            this.btTallenna.TabIndex = 10;
            this.btTallenna.Text = "Tallenna";
            this.btTallenna.UseVisualStyleBackColor = false;
            this.btTallenna.Click += new System.EventHandler(this.btTallenna_Click);
            // 
            // btPoista
            // 
            this.btPoista.BackColor = System.Drawing.Color.Red;
            this.btPoista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPoista.Location = new System.Drawing.Point(21, 171);
            this.btPoista.Name = "btPoista";
            this.btPoista.Size = new System.Drawing.Size(239, 54);
            this.btPoista.TabIndex = 11;
            this.btPoista.Text = "Poista";
            this.btPoista.UseVisualStyleBackColor = false;
            this.btPoista.Click += new System.EventHandler(this.btPoista_Click);
            // 
            // btEdelinen
            // 
            this.btEdelinen.Location = new System.Drawing.Point(18, 184);
            this.btEdelinen.Name = "btEdelinen";
            this.btEdelinen.Size = new System.Drawing.Size(137, 38);
            this.btEdelinen.TabIndex = 12;
            this.btEdelinen.Text = "Edellinen";
            this.btEdelinen.UseVisualStyleBackColor = true;
            // 
            // btSeuraava
            // 
            this.btSeuraava.Location = new System.Drawing.Point(174, 184);
            this.btSeuraava.Name = "btSeuraava";
            this.btSeuraava.Size = new System.Drawing.Size(137, 38);
            this.btSeuraava.TabIndex = 13;
            this.btSeuraava.Text = "Seuraava";
            this.btSeuraava.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSeuraava);
            this.groupBox1.Controls.Add(this.btEdelinen);
            this.groupBox1.Controls.Add(this.tb_time);
            this.groupBox1.Controls.Add(this.tb_release);
            this.groupBox1.Controls.Add(this.tb_ElokuvaNimi);
            this.groupBox1.Controls.Add(this.tb_Elokuva_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 272);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ELokuvan tiedot";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btPoista);
            this.groupBox2.Controls.Add(this.btTallenna);
            this.groupBox2.Controls.Add(this.btTietue);
            this.groupBox2.Location = new System.Drawing.Point(395, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 510);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toiminnallisuus";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lb_arvio);
            this.groupBox3.Location = new System.Drawing.Point(13, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 229);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arvio";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(140, 189);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(79, 189);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Arvosana:";
            // 
            // lb_arvio
            // 
            this.lb_arvio.FormattingEnabled = true;
            this.lb_arvio.Location = new System.Drawing.Point(18, 19);
            this.lb_arvio.Name = "lb_arvio";
            this.lb_arvio.Size = new System.Drawing.Size(319, 160);
            this.lb_arvio.TabIndex = 0;
            this.lb_arvio.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 625);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Elokuva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Elokuva_id;
        private System.Windows.Forms.TextBox tb_ElokuvaNimi;
        private System.Windows.Forms.TextBox tb_release;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Button btTietue;
        private System.Windows.Forms.Button btTallenna;
        private System.Windows.Forms.Button btPoista;
        private System.Windows.Forms.Button btEdelinen;
        private System.Windows.Forms.Button btSeuraava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_arvio;
    }
}

