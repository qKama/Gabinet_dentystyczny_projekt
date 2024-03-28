namespace lista5
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_apCh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_apAd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NFZ = new System.Windows.Forms.Button();
            this.btn_CommonList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_apCh
            // 
            this.btn_apCh.Location = new System.Drawing.Point(3, 32);
            this.btn_apCh.Name = "btn_apCh";
            this.btn_apCh.Size = new System.Drawing.Size(251, 23);
            this.btn_apCh.TabIndex = 1;
            this.btn_apCh.Text = "Wizyta Dziecko";
            this.btn_apCh.UseVisualStyleBackColor = true;
            this.btn_apCh.Click += new System.EventHandler(this.btn_apCh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "|| Gabinet Dentystyczny ||";
            // 
            // btn_apAd
            // 
            this.btn_apAd.Location = new System.Drawing.Point(3, 3);
            this.btn_apAd.Name = "btn_apAd";
            this.btn_apAd.Size = new System.Drawing.Size(251, 23);
            this.btn_apAd.TabIndex = 3;
            this.btn_apAd.Text = "Wizyta Dorosły";
            this.btn_apAd.UseVisualStyleBackColor = true;
            this.btn_apAd.Click += new System.EventHandler(this.btn_apAd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NFZ);
            this.panel1.Controls.Add(this.btn_CommonList);
            this.panel1.Controls.Add(this.btn_apCh);
            this.panel1.Controls.Add(this.btn_apAd);
            this.panel1.Location = new System.Drawing.Point(157, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 121);
            this.panel1.TabIndex = 4;
            // 
            // NFZ
            // 
            this.NFZ.Location = new System.Drawing.Point(4, 89);
            this.NFZ.Name = "NFZ";
            this.NFZ.Size = new System.Drawing.Size(250, 23);
            this.NFZ.TabIndex = 5;
            this.NFZ.Text = "NFZ";
            this.NFZ.UseVisualStyleBackColor = true;
            this.NFZ.Click += new System.EventHandler(this.NFZ_Click);
            // 
            // btn_CommonList
            // 
            this.btn_CommonList.Location = new System.Drawing.Point(3, 59);
            this.btn_CommonList.Name = "btn_CommonList";
            this.btn_CommonList.Size = new System.Drawing.Size(251, 23);
            this.btn_CommonList.TabIndex = 4;
            this.btn_CommonList.Text = "Lista";
            this.btn_CommonList.UseVisualStyleBackColor = true;
            this.btn_CommonList.Click += new System.EventHandler(this.btn_CommonList_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 621);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(600, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apCh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_apAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CommonList;
        private System.Windows.Forms.Button NFZ;
    }
}

