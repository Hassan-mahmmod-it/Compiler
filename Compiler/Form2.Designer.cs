namespace Compiler
{
    partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(1107, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(57, 56);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBox2.ForeColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(580, 59);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(479, 440);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(191, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 39);
			this.label1.TabIndex = 3;
			this.label1.Text = "Src. Code";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(724, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 39);
			this.label2.TabIndex = 4;
			this.label2.Text = "Pre. Code";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBox3.ForeColor = System.Drawing.Color.White;
			this.textBox3.Location = new System.Drawing.Point(66, 59);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(479, 440);
			this.textBox3.TabIndex = 1;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1176, 518);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Comment & Macro";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox3;
	}
}