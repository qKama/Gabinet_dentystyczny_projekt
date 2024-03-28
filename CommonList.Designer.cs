namespace lista5
{
    partial class CommonList
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_child = new System.Windows.Forms.Button();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_serialization = new System.Windows.Forms.Button();
            this.btn_Deserialization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(148, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 264);
            this.listBox1.TabIndex = 0;
            // 
            // btn_child
            // 
            this.btn_child.Location = new System.Drawing.Point(480, 345);
            this.btn_child.Name = "btn_child";
            this.btn_child.Size = new System.Drawing.Size(104, 23);
            this.btn_child.TabIndex = 1;
            this.btn_child.Text = "Odśwież";
            this.btn_child.UseVisualStyleBackColor = true;
            this.btn_child.Click += new System.EventHandler(this.btn_child_Click);
            // 
            // pictureBoxList
            // 
            this.pictureBoxList.Location = new System.Drawing.Point(148, 316);
            this.pictureBoxList.Name = "pictureBoxList";
            this.pictureBoxList.Size = new System.Drawing.Size(270, 208);
            this.pictureBoxList.TabIndex = 3;
            this.pictureBoxList.TabStop = false;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(425, 316);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(93, 23);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "<- Poprzednie";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(554, 316);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(79, 23);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = " Następne ->";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "|| LISTA PACJENTÓW ||";
            // 
            // btn_serialization
            // 
            this.btn_serialization.Location = new System.Drawing.Point(12, 45);
            this.btn_serialization.Name = "btn_serialization";
            this.btn_serialization.Size = new System.Drawing.Size(120, 23);
            this.btn_serialization.TabIndex = 7;
            this.btn_serialization.Text = "Serializacja";
            this.btn_serialization.UseVisualStyleBackColor = true;
            this.btn_serialization.Click += new System.EventHandler(this.btn_serialization_Click);
            // 
            // btn_Deserialization
            // 
            this.btn_Deserialization.Location = new System.Drawing.Point(12, 74);
            this.btn_Deserialization.Name = "btn_Deserialization";
            this.btn_Deserialization.Size = new System.Drawing.Size(120, 23);
            this.btn_Deserialization.TabIndex = 8;
            this.btn_Deserialization.Text = "Deserializacja";
            this.btn_Deserialization.UseVisualStyleBackColor = true;
            this.btn_Deserialization.Click += new System.EventHandler(this.button2_Click);
            // 
            // CommonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btn_Deserialization);
            this.Controls.Add(this.btn_serialization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.pictureBoxList);
            this.Controls.Add(this.btn_child);
            this.Controls.Add(this.listBox1);
            this.Name = "CommonList";
            this.Size = new System.Drawing.Size(643, 537);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_child;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_serialization;
        private System.Windows.Forms.Button btn_Deserialization;
    }
}
