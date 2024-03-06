namespace LiquidLaunchpad
{
	// Token: 0x02000003 RID: 3
	public partial class FormLaunchpad
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.ButtonInject = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.TimerGameRunning = new System.Windows.Forms.Timer(this.components);
            this.TimerAutoInject = new System.Windows.Forms.Timer(this.components);
            this.ButtonKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonInject
            // 
            this.ButtonInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ButtonInject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonInject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ButtonInject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInject.ForeColor = System.Drawing.Color.White;
            this.ButtonInject.Location = new System.Drawing.Point(15, 101);
            this.ButtonInject.Name = "ButtonInject";
            this.ButtonInject.Size = new System.Drawing.Size(302, 45);
            this.ButtonInject.TabIndex = 0;
            this.ButtonInject.Text = "Login";
            this.ButtonInject.UseVisualStyleBackColor = false;
            this.ButtonInject.Click += new System.EventHandler(this.OnClickInject);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.ForeColor = System.Drawing.Color.White;
            this.LabelStatus.Location = new System.Drawing.Point(12, 206);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(138, 15);
            this.LabelStatus.TabIndex = 2;
            this.LabelStatus.Text = "made with ❤ by bypass_";
            this.LabelStatus.Click += new System.EventHandler(this.LabelStatus_Click);
            // 
            // TimerGameRunning
            // 
            this.TimerGameRunning.Tick += new System.EventHandler(this.OnTickGameRunning);
            // 
            // ButtonKey
            // 
            this.ButtonKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ButtonKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ButtonKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonKey.ForeColor = System.Drawing.Color.White;
            this.ButtonKey.Location = new System.Drawing.Point(15, 164);
            this.ButtonKey.Name = "ButtonKey";
            this.ButtonKey.Size = new System.Drawing.Size(302, 34);
            this.ButtonKey.TabIndex = 0;
            this.ButtonKey.Text = "Get Key";
            this.ButtonKey.UseVisualStyleBackColor = false;
            this.ButtonKey.Click += new System.EventHandler(this.OnClickGetKey);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the Key";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkViolet;
            this.richTextBox1.Location = new System.Drawing.Point(340, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(406, 199);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Loading Changelog...";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FormLaunchpad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(745, 231);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.ButtonKey);
            this.Controls.Add(this.ButtonInject);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLaunchpad";
            this.ShowIcon = false;
            this.Text = "Liquid Launchpad";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Button ButtonInject;

		private global::System.Windows.Forms.Label LabelStatus;

		private global::System.Windows.Forms.Timer TimerGameRunning;

		private global::System.Windows.Forms.Timer TimerAutoInject;

		private global::System.Windows.Forms.Button ButtonKey;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.TextBox textBox1;

		private global::System.Windows.Forms.RichTextBox richTextBox1;
	}
}
