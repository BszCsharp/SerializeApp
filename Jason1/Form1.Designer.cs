namespace Jason1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonJSONSerialize = new System.Windows.Forms.Button();
            this.buttonFillListe = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonDesJson = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJSONSerialize
            // 
            this.buttonJSONSerialize.Location = new System.Drawing.Point(41, 75);
            this.buttonJSONSerialize.Name = "buttonJSONSerialize";
            this.buttonJSONSerialize.Size = new System.Drawing.Size(158, 29);
            this.buttonJSONSerialize.TabIndex = 0;
            this.buttonJSONSerialize.Text = "JSON";
            this.buttonJSONSerialize.UseVisualStyleBackColor = true;
            this.buttonJSONSerialize.Click += new System.EventHandler(this.buttonJSONSerialize_Click);
            // 
            // buttonFillListe
            // 
            this.buttonFillListe.Location = new System.Drawing.Point(44, 33);
            this.buttonFillListe.Name = "buttonFillListe";
            this.buttonFillListe.Size = new System.Drawing.Size(154, 29);
            this.buttonFillListe.TabIndex = 1;
            this.buttonFillListe.Text = "Kontakliste";
            this.buttonFillListe.UseVisualStyleBackColor = true;
            this.buttonFillListe.Click += new System.EventHandler(this.buttonFillListe_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(699, 140);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttonDesJson
            // 
            this.buttonDesJson.Location = new System.Drawing.Point(47, 280);
            this.buttonDesJson.Name = "buttonDesJson";
            this.buttonDesJson.Size = new System.Drawing.Size(151, 30);
            this.buttonDesJson.TabIndex = 3;
            this.buttonDesJson.Text = "Des. JSON";
            this.buttonDesJson.UseVisualStyleBackColor = true;
            this.buttonDesJson.Click += new System.EventHandler(this.buttonDesJson_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 83);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDesJson);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonFillListe);
            this.Controls.Add(this.buttonJSONSerialize);
            this.Name = "Form1";
            this.Text = "JSON";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonJSONSerialize;
        private System.Windows.Forms.Button buttonFillListe;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonDesJson;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

