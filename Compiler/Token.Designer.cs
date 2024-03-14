namespace Compiler
{
	partial class Token
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Token));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(106, 43);
			this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(402, 158);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.ForeColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(106, 256);
			this.textBox2.Margin = new System.Windows.Forms.Padding(6);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(402, 158);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.ForeColor = System.Drawing.Color.White;
			this.textBox3.Location = new System.Drawing.Point(662, 43);
			this.textBox3.Margin = new System.Windows.Forms.Padding(6);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(402, 158);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.ForeColor = System.Drawing.Color.White;
			this.textBox4.Location = new System.Drawing.Point(662, 256);
			this.textBox4.Margin = new System.Windows.Forms.Padding(6);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(402, 158);
			this.textBox4.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(1073, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 84);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Token
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 39F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1174, 476);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Token";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Token";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox3;
		public System.Windows.Forms.TextBox textBox4;
	}
}