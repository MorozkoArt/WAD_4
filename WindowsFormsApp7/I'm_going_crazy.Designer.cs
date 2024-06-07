namespace WindowsFormsApp7
{
    partial class I_SHOJU_S_UMA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new WpfControlLibrary1.UserControl1();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl21 = new WpfControlLibrary2.UserControl2();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.Transparent;
            this.elementHost1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Font = new System.Drawing.Font("Times New Roman", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(2519, 1376);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "rtyrty";
            this.elementHost1.Child = this.userControl11;
            // 
            // elementHost3
            // 
            this.elementHost3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost3.BackColor = System.Drawing.Color.Transparent;
            this.elementHost3.BackColorTransparent = true;
            this.elementHost3.Location = new System.Drawing.Point(2280, 80);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(227, 189);
            this.elementHost3.TabIndex = 0;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.userControl21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2280, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 42);
            this.label1.TabIndex = 1;
            // 
            // I_SHOJU_S_UMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2519, 1376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementHost3);
            this.Controls.Add(this.elementHost1);
            this.Name = "I_SHOJU_S_UMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I\'m going crazy";
            this.Load += new System.EventHandler(this.I_SHOJU_S_UMA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Integration.ElementHost elementHost1;
        public WpfControlLibrary1.UserControl1 userControl11;
        public System.Windows.Forms.Integration.ElementHost elementHost3;
        public WpfControlLibrary2.UserControl2 userControl21;
        private System.Windows.Forms.Label label1;
    }
}

