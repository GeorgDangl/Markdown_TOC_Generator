namespace GenerateMarkdownTOC
{
    partial class MainForm
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
            this.button_Generate = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_Copy = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(13, 13);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(257, 23);
            this.button_Generate.TabIndex = 0;
            this.button_Generate.Text = "Select file and generate TOC for Markdown";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(13, 42);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(637, 374);
            this.textBox.TabIndex = 1;
            // 
            // button_Copy
            // 
            this.button_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Copy.Location = new System.Drawing.Point(505, 13);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(144, 23);
            this.button_Copy.TabIndex = 2;
            this.button_Copy.Text = "Copy to Clipboard";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(276, 17);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(103, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "Direct file modify";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 428);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_Generate);
            this.Name = "MainForm";
            this.Text = "Markdown TOC Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

