namespace if_else_2.örnek_836
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
            this.cbMavi = new System.Windows.Forms.CheckBox();
            this.cbKirmizi = new System.Windows.Forms.CheckBox();
            this.cbMor = new System.Windows.Forms.CheckBox();
            this.cbPembe = new System.Windows.Forms.CheckBox();
            this.cbSiyah = new System.Windows.Forms.CheckBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMavi.Location = new System.Drawing.Point(13, 31);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(77, 29);
            this.cbMavi.TabIndex = 0;
            this.cbMavi.Text = "Mavi";
            this.cbMavi.UseVisualStyleBackColor = true;
            this.cbMavi.CheckedChanged += new System.EventHandler(this.cbMavi_CheckedChanged);
            // 
            // cbKirmizi
            // 
            this.cbKirmizi.AutoSize = true;
            this.cbKirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKirmizi.Location = new System.Drawing.Point(13, 66);
            this.cbKirmizi.Name = "cbKirmizi";
            this.cbKirmizi.Size = new System.Drawing.Size(95, 29);
            this.cbKirmizi.TabIndex = 1;
            this.cbKirmizi.Text = "Kırmızı";
            this.cbKirmizi.UseVisualStyleBackColor = true;
            this.cbKirmizi.CheckedChanged += new System.EventHandler(this.cbKirmizi_CheckedChanged);
            // 
            // cbMor
            // 
            this.cbMor.AutoSize = true;
            this.cbMor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMor.Location = new System.Drawing.Point(13, 101);
            this.cbMor.Name = "cbMor";
            this.cbMor.Size = new System.Drawing.Size(68, 29);
            this.cbMor.TabIndex = 2;
            this.cbMor.Text = "Mor";
            this.cbMor.UseVisualStyleBackColor = true;
            this.cbMor.CheckedChanged += new System.EventHandler(this.cbMor_CheckedChanged);
            // 
            // cbPembe
            // 
            this.cbPembe.AutoSize = true;
            this.cbPembe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPembe.Location = new System.Drawing.Point(13, 136);
            this.cbPembe.Name = "cbPembe";
            this.cbPembe.Size = new System.Drawing.Size(98, 29);
            this.cbPembe.TabIndex = 3;
            this.cbPembe.Text = "Pembe";
            this.cbPembe.UseVisualStyleBackColor = true;
            this.cbPembe.CheckedChanged += new System.EventHandler(this.cbPembe_CheckedChanged);
            // 
            // cbSiyah
            // 
            this.cbSiyah.AutoSize = true;
            this.cbSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSiyah.Location = new System.Drawing.Point(12, 171);
            this.cbSiyah.Name = "cbSiyah";
            this.cbSiyah.Size = new System.Drawing.Size(85, 29);
            this.cbSiyah.TabIndex = 4;
            this.cbSiyah.Text = "Siyah";
            this.cbSiyah.UseVisualStyleBackColor = true;
            this.cbSiyah.CheckedChanged += new System.EventHandler(this.cbSiyah_CheckedChanged);
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.Location = new System.Drawing.Point(12, 242);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(196, 25);
            this.lblRenk.TabIndex = 5;
            this.lblRenk.Text = "Hangi renk yapıldı: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 320);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.cbSiyah);
            this.Controls.Add(this.cbPembe);
            this.Controls.Add(this.cbMor);
            this.Controls.Add(this.cbKirmizi);
            this.Controls.Add(this.cbMavi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbMavi;
        private System.Windows.Forms.CheckBox cbKirmizi;
        private System.Windows.Forms.CheckBox cbMor;
        private System.Windows.Forms.CheckBox cbPembe;
        private System.Windows.Forms.CheckBox cbSiyah;
        private System.Windows.Forms.Label lblRenk;
    }
}

