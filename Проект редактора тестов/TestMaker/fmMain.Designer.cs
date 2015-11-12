namespace TestMaker
{
    partial class fmMain
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
            this.btAddTest = new System.Windows.Forms.Button();
            this.btEditTest = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAddTest
            // 
            this.btAddTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddTest.Location = new System.Drawing.Point(12, 12);
            this.btAddTest.Name = "btAddTest";
            this.btAddTest.Size = new System.Drawing.Size(197, 23);
            this.btAddTest.TabIndex = 0;
            this.btAddTest.Text = "Создать тест";
            this.btAddTest.UseVisualStyleBackColor = true;
            this.btAddTest.Click += new System.EventHandler(this.btAddTest_Click);
            // 
            // btEditTest
            // 
            this.btEditTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditTest.Location = new System.Drawing.Point(12, 41);
            this.btEditTest.Name = "btEditTest";
            this.btEditTest.Size = new System.Drawing.Size(197, 23);
            this.btEditTest.TabIndex = 1;
            this.btEditTest.Text = "Редактировать тест";
            this.btEditTest.UseVisualStyleBackColor = true;
            this.btEditTest.Click += new System.EventHandler(this.btEditTest_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(12, 124);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(197, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 159);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btEditTest);
            this.Controls.Add(this.btAddTest);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestMaker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddTest;
        private System.Windows.Forms.Button btEditTest;
        private System.Windows.Forms.Button btClose;
    }
}

