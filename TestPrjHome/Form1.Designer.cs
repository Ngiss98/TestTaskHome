namespace TestPrjHome
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			timer1 = new System.Windows.Forms.Timer(components);
			button1 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(12, 198);
			button1.Name = "button1";
			button1.Size = new Size(207, 31);
			button1.TabIndex = 0;
			button1.Text = "Узнать погоду";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(41, 21);
			label1.TabIndex = 1;
			label1.Text = " 123";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 169);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(207, 23);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(12, 145);
			label2.Name = "label2";
			label2.Size = new Size(114, 21);
			label2.TabIndex = 3;
			label2.Text = "Введите город";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(12, 41);
			label3.Name = "label3";
			label3.Size = new Size(41, 21);
			label3.TabIndex = 4;
			label3.Text = " 123";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(12, 69);
			label4.Name = "label4";
			label4.Size = new Size(41, 21);
			label4.TabIndex = 5;
			label4.Text = " 123";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(16, 99);
			label5.Name = "label5";
			label5.Size = new Size(37, 21);
			label5.TabIndex = 6;
			label5.Text = "123";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(231, 241);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Погода в городе";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private Button button1;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
	}
}