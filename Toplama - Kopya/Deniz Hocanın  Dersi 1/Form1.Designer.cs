namespace Deniz_Hocanın__Dersi_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.FormTopla = new System.Windows.Forms.TabControl();
            this.tabTopla = new System.Windows.Forms.TabPage();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.FormTopla.SuspendLayout();
            this.tabTopla.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirinciSayi.Location = new System.Drawing.Point(295, 45);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(154, 20);
            this.txtBirinciSayi.TabIndex = 0;
            this.txtBirinciSayi.TextChanged += new System.EventHandler(this.txtBirinciSayi_TextChanged);
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirinciSayi_KeyPress);
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.BackColor = System.Drawing.Color.Transparent;
            this.lblBirinciSayi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBirinciSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirinciSayi.Location = new System.Drawing.Point(73, 45);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(131, 25);
            this.lblBirinciSayi.TabIndex = 1;
            this.lblBirinciSayi.Text = "Birinci Sayı";
            // 
            // lblİkinciSayi
            // 
            this.lblİkinciSayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblİkinciSayi.AutoSize = true;
            this.lblİkinciSayi.BackColor = System.Drawing.Color.Transparent;
            this.lblİkinciSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİkinciSayi.Location = new System.Drawing.Point(73, 106);
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            this.lblİkinciSayi.Size = new System.Drawing.Size(120, 25);
            this.lblİkinciSayi.TabIndex = 2;
            this.lblİkinciSayi.Text = "İkinci Sayı";
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtİkinciSayi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtİkinciSayi.Location = new System.Drawing.Point(295, 106);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.Size = new System.Drawing.Size(154, 20);
            this.txtİkinciSayi.TabIndex = 1;
            this.txtİkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtİkinciSayi_KeyPress);
            // 
            // btnTopla
            // 
            this.btnTopla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTopla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(295, 209);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(154, 51);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // FormTopla
            // 
            this.FormTopla.Controls.Add(this.tabTopla);
            this.FormTopla.Controls.Add(this.tabLog);
            this.FormTopla.Location = new System.Drawing.Point(12, 12);
            this.FormTopla.Name = "FormTopla";
            this.FormTopla.SelectedIndex = 0;
            this.FormTopla.Size = new System.Drawing.Size(801, 489);
            this.FormTopla.TabIndex = 3;
            // 
            // tabTopla
            // 
            this.tabTopla.BackColor = System.Drawing.Color.White;
            this.tabTopla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabTopla.Controls.Add(this.txtSonuc);
            this.tabTopla.Controls.Add(this.lblSonuc);
            this.tabTopla.Controls.Add(this.lblBirinciSayi);
            this.tabTopla.Controls.Add(this.btnTopla);
            this.tabTopla.Controls.Add(this.txtBirinciSayi);
            this.tabTopla.Controls.Add(this.txtİkinciSayi);
            this.tabTopla.Controls.Add(this.lblİkinciSayi);
            this.tabTopla.Location = new System.Drawing.Point(4, 22);
            this.tabTopla.Name = "tabTopla";
            this.tabTopla.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopla.Size = new System.Drawing.Size(793, 463);
            this.tabTopla.TabIndex = 0;
            this.tabTopla.Text = "Topla";
            // 
            // tabLog
            // 
            this.tabLog.BackColor = System.Drawing.Color.Wheat;
            this.tabLog.Controls.Add(this.btnSıfırla);
            this.tabLog.Controls.Add(this.btnTemizle);
            this.tabLog.Controls.Add(this.ListView1);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(793, 463);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Log";
            // 
            // lblSonuc
            // 
            this.lblSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(73, 317);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(78, 25);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "Sonuç";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(295, 317);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(154, 20);
            this.txtSonuc.TabIndex = 4;
            this.txtSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged);
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.White;
            this.ListView1.Location = new System.Drawing.Point(-4, 0);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(797, 463);
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.List;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(95, 330);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 44);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Seçileni Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.Location = new System.Drawing.Point(285, 330);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(112, 44);
            this.btnSıfırla.TabIndex = 2;
            this.btnSıfırla.Text = " Hepsini Temizle";
            this.btnSıfırla.UseVisualStyleBackColor = true;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTopla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 520);
            this.Controls.Add(this.FormTopla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTopla";
            this.Load += new System.EventHandler(this.FormTopla_Load);
            this.Shown += new System.EventHandler(this.FormTopla_Shown);
            this.FormTopla.ResumeLayout(false);
            this.tabTopla.ResumeLayout(false);
            this.tabTopla.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TabControl FormTopla;
        private System.Windows.Forms.TabPage tabTopla;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.Button btnTemizle;
    }
}

