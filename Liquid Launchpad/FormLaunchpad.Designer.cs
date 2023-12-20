namespace LiquidLaunchpad
{
	// Token: 0x02000003 RID: 3
	public partial class FormLaunchpad : global::System.Windows.Forms.Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000027C0 File Offset: 0x000009C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000027E0 File Offset: 0x000009E0
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.ButtonInject = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.TimerGameRunning = new System.Windows.Forms.Timer(this.components);
            this.TimerAutoInject = new System.Windows.Forms.Timer(this.components);
            this.ButtonKey = new System.Windows.Forms.Button();
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
            this.ButtonInject.Location = new System.Drawing.Point(12, 76);
            this.ButtonInject.Name = "ButtonInject";
            this.ButtonInject.Size = new System.Drawing.Size(302, 45);
            this.ButtonInject.TabIndex = 0;
            this.ButtonInject.Text = "Inject";
            this.ButtonInject.UseVisualStyleBackColor = false;
            this.ButtonInject.Click += new System.EventHandler(this.OnClickInject);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.ForeColor = System.Drawing.Color.White;
            this.LabelStatus.Location = new System.Drawing.Point(12, 136);
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
            this.ButtonKey.Location = new System.Drawing.Point(12, 26);
            this.ButtonKey.Name = "ButtonKey";
            this.ButtonKey.Size = new System.Drawing.Size(302, 34);
            this.ButtonKey.TabIndex = 0;
            this.ButtonKey.Text = "Get Key";
            this.ButtonKey.UseVisualStyleBackColor = false;
            this.ButtonKey.Click += new System.EventHandler(this.OnClickGetKey);
            // 
            // FormLaunchpad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(326, 161);
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

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button ButtonInject;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label LabelStatus;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Timer TimerGameRunning;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Timer TimerAutoInject;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button ButtonKey;
	}
}
