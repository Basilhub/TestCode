namespace Test
{
    partial class FmMain
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
            this.btStartTest = new System.Windows.Forms.Button();
            this.btOpenTestMaterial = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStartTest
            // 
            this.btStartTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btStartTest.Location = new System.Drawing.Point(9, 12);
            this.btStartTest.Name = "btStartTest";
            this.btStartTest.Size = new System.Drawing.Size(263, 23);
            this.btStartTest.TabIndex = 0;
            this.btStartTest.Text = "Пройти тест...";
            this.btStartTest.UseVisualStyleBackColor = true;
            this.btStartTest.Click += new System.EventHandler(this.btStartTest_Click);
            // 
            // btOpenTestMaterial
            // 
            this.btOpenTestMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenTestMaterial.Location = new System.Drawing.Point(9, 41);
            this.btOpenTestMaterial.Name = "btOpenTestMaterial";
            this.btOpenTestMaterial.Size = new System.Drawing.Size(263, 23);
            this.btOpenTestMaterial.TabIndex = 1;
            this.btOpenTestMaterial.Text = "Открыть учебный материал";
            this.btOpenTestMaterial.UseVisualStyleBackColor = true;
            this.btOpenTestMaterial.Click += new System.EventHandler(this.btOpenTestMaterial_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(9, 226);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(263, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOpenTestMaterial);
            this.Controls.Add(this.btStartTest);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStartTest;
        private System.Windows.Forms.Button btOpenTestMaterial;
        private System.Windows.Forms.Button btClose;
    }
}

