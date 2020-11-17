namespace WP_2020_01_HW02_9a713032
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(353, 121);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(123, 175);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnDraw.Location = new System.Drawing.Point(533, 121);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(114, 175);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "抽牌";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(64, 121);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(181, 175);
            this.rtb.TabIndex = 2;
            this.rtb.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 32F);
            this.textBox1.Location = new System.Drawing.Point(251, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 52);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "撲克牌抽牌機";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox2.Location = new System.Drawing.Point(251, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "抽到的牌:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox3.Location = new System.Drawing.Point(12, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 26);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "歷程:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 343);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.picResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

