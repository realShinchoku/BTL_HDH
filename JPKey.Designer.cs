
namespace JPKey
{
    partial class JpKey
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
            this.btn_JPKey = new System.Windows.Forms.Button();
            this.btn_typeOfChar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_JPKey
            // 
            this.btn_JPKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_JPKey.Location = new System.Drawing.Point(106, 34);
            this.btn_JPKey.Name = "btn_JPKey";
            this.btn_JPKey.Size = new System.Drawing.Size(75, 46);
            this.btn_JPKey.TabIndex = 0;
            this.btn_JPKey.Text = "Tắt";
            this.btn_JPKey.UseVisualStyleBackColor = true;
            this.btn_JPKey.Click += new System.EventHandler(this.JPKey_btn_Click);
            // 
            // btn_typeOfChar
            // 
            this.btn_typeOfChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_typeOfChar.Location = new System.Drawing.Point(281, 34);
            this.btn_typeOfChar.Name = "btn_typeOfChar";
            this.btn_typeOfChar.Size = new System.Drawing.Size(103, 48);
            this.btn_typeOfChar.TabIndex = 1;
            this.btn_typeOfChar.Text = "Hiragana";
            this.btn_typeOfChar.UseVisualStyleBackColor = true;
            this.btn_typeOfChar.Click += new System.EventHandler(this.typeOfBtnChar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tình trạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(201, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiểu chữ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chào mừng bạn tới với JPKey ver cây nhà lá vườn";
            // 
            // JPKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 92);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_typeOfChar);
            this.Controls.Add(this.btn_JPKey);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JpKey";
            this.Text = "JPKey";
            this.Load += new System.EventHandler(this.JPKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_JPKey;
        private System.Windows.Forms.Button btn_typeOfChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}