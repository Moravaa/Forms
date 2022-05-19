namespace Teht9
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
            this.bt_luoLista = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_haku = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_luoLista
            // 
            this.bt_luoLista.Location = new System.Drawing.Point(46, 78);
            this.bt_luoLista.Name = "bt_luoLista";
            this.bt_luoLista.Size = new System.Drawing.Size(75, 27);
            this.bt_luoLista.TabIndex = 0;
            this.bt_luoLista.Text = "Luo Lista";
            this.bt_luoLista.UseVisualStyleBackColor = true;
            this.bt_luoLista.Click += new System.EventHandler(this.bt_luoLista_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 338);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(187, 200);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(72, 26);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "Lisää";
            this.bt_add.UseVisualStyleBackColor = true;
            // 
            // bt_haku
            // 
            this.bt_haku.Location = new System.Drawing.Point(187, 338);
            this.bt_haku.Name = "bt_haku";
            this.bt_haku.Size = new System.Drawing.Size(75, 27);
            this.bt_haku.TabIndex = 4;
            this.bt_haku.Text = "Haku";
            this.bt_haku.UseVisualStyleBackColor = true;
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(32, 204);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(88, 20);
            this.tb_add.TabIndex = 5;
            this.tb_add.TextChanged += new System.EventHandler(this.tb_add_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.bt_haku);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_luoLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_luoLista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_haku;
        private System.Windows.Forms.TextBox tb_add;
    }
}

