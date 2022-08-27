
namespace EnglishDictionary
{
    partial class play
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
            this.plai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plai
            // 
            this.plai.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plai.Location = new System.Drawing.Point(664, 409);
            this.plai.Name = "plai";
            this.plai.Size = new System.Drawing.Size(124, 29);
            this.plai.TabIndex = 0;
            this.plai.Text = "Загрузить";
            this.plai.UseVisualStyleBackColor = false;
            this.plai.Click += new System.EventHandler(this.plai_Click);
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plai);
            this.Name = "play";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plai;
    }
}

