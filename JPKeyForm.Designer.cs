
namespace BTL_HDH
{
    partial class JPKeyForm
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
            this.SQJPKey_button = new System.Windows.Forms.Button();
            this.TextType_btn = new System.Windows.Forms.Button();
            this.HideWindow_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQJPKey_button
            // 
            this.SQJPKey_button.Location = new System.Drawing.Point(136, 204);
            this.SQJPKey_button.Name = "SQJPKey_button";
            this.SQJPKey_button.Size = new System.Drawing.Size(128, 42);
            this.SQJPKey_button.TabIndex = 0;
            this.SQJPKey_button.Text = "Bật";
            this.SQJPKey_button.UseVisualStyleBackColor = true;
            this.SQJPKey_button.Click += new System.EventHandler(this.SQJPKey_button_Click);
            // 
            // TextType_btn
            // 
            this.TextType_btn.Location = new System.Drawing.Point(293, 204);
            this.TextType_btn.Name = "TextType_btn";
            this.TextType_btn.Size = new System.Drawing.Size(128, 42);
            this.TextType_btn.TabIndex = 1;
            this.TextType_btn.Text = "Hiragana";
            this.TextType_btn.UseVisualStyleBackColor = true;
            // 
            // HideWindow_btn
            // 
            this.HideWindow_btn.Location = new System.Drawing.Point(474, 43);
            this.HideWindow_btn.Name = "HideWindow_btn";
            this.HideWindow_btn.Size = new System.Drawing.Size(89, 36);
            this.HideWindow_btn.TabIndex = 2;
            this.HideWindow_btn.Text = "Ẩn";
            this.HideWindow_btn.UseVisualStyleBackColor = true;
            // 
            // JPKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 496);
            this.Controls.Add(this.HideWindow_btn);
            this.Controls.Add(this.TextType_btn);
            this.Controls.Add(this.SQJPKey_button);
            this.Name = "JPKeyForm";
            this.Text = "JPKey";
            this.Load += new System.EventHandler(this.JPKeyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SQJPKey_button;
        private System.Windows.Forms.Button TextType_btn;
        private System.Windows.Forms.Button HideWindow_btn;
    }
}

