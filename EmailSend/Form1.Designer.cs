namespace EmailSend
{
    partial class Form1
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
            this.recieve_txt = new System.Windows.Forms.TextBox();
            this.sender_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.content_txt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recieve_txt
            // 
            this.recieve_txt.Location = new System.Drawing.Point(244, 39);
            this.recieve_txt.Name = "recieve_txt";
            this.recieve_txt.Size = new System.Drawing.Size(272, 22);
            this.recieve_txt.TabIndex = 0;
            // 
            // sender_txt
            // 
            this.sender_txt.Location = new System.Drawing.Point(244, 83);
            this.sender_txt.Name = "sender_txt";
            this.sender_txt.Size = new System.Drawing.Size(272, 22);
            this.sender_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(244, 131);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(272, 22);
            this.password_txt.TabIndex = 2;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // content_txt
            // 
            this.content_txt.Location = new System.Drawing.Point(244, 182);
            this.content_txt.Name = "content_txt";
            this.content_txt.Size = new System.Drawing.Size(272, 117);
            this.content_txt.TabIndex = 3;
            this.content_txt.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.content_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.sender_txt);
            this.Controls.Add(this.recieve_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recieve_txt;
        private System.Windows.Forms.TextBox sender_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.RichTextBox content_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

