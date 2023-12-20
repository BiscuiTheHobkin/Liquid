namespace LiquidLaunchpad
{
	// Token: 0x02000002 RID: 2
	public partial class FormKeyInput : global::System.Windows.Forms.Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020BE File Offset: 0x000002BE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020E0 File Offset: 0x000002E0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::LiquidLaunchpad.FormKeyInput));
			this.TextKey = new global::System.Windows.Forms.TextBox();
			this.ButtonOk = new global::System.Windows.Forms.Button();
			this.ButtonCancel = new global::System.Windows.Forms.Button();
			this.LinkKey = new global::System.Windows.Forms.LinkLabel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.TextKey.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextKey.Location = new global::System.Drawing.Point(12, 33);
			this.TextKey.Name = "TextKey";
			this.TextKey.Size = new global::System.Drawing.Size(311, 25);
			this.TextKey.TabIndex = 0;
			this.TextKey.TextChanged += new global::System.EventHandler(this.OnTextChangedTextKey);
			this.ButtonOk.BackColor = global::System.Drawing.Color.FromArgb(41, 41, 41);
			this.ButtonOk.Enabled = false;
			this.ButtonOk.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(51, 51, 51);
			this.ButtonOk.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(58, 58, 58);
			this.ButtonOk.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.ButtonOk.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ButtonOk.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ButtonOk.ForeColor = global::System.Drawing.Color.White;
			this.ButtonOk.Location = new global::System.Drawing.Point(12, 70);
			this.ButtonOk.Name = "ButtonOk";
			this.ButtonOk.Size = new global::System.Drawing.Size(204, 28);
			this.ButtonOk.TabIndex = 3;
			this.ButtonOk.Text = "OK (Inject)";
			this.ButtonOk.UseVisualStyleBackColor = false;
			this.ButtonOk.Click += new global::System.EventHandler(this.OnClickButtonOk);
			this.ButtonCancel.BackColor = global::System.Drawing.Color.FromArgb(41, 41, 41);
			this.ButtonCancel.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(51, 51, 51);
			this.ButtonCancel.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(58, 58, 58);
			this.ButtonCancel.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.ButtonCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ButtonCancel.ForeColor = global::System.Drawing.Color.White;
			this.ButtonCancel.Location = new global::System.Drawing.Point(222, 70);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new global::System.Drawing.Size(101, 28);
			this.ButtonCancel.TabIndex = 3;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = false;
			this.ButtonCancel.Click += new global::System.EventHandler(this.OnClickButtonCancel);
			this.LinkKey.ActiveLinkColor = global::System.Drawing.Color.White;
			this.LinkKey.AutoSize = true;
			this.LinkKey.LinkColor = global::System.Drawing.Color.White;
			this.LinkKey.Location = new global::System.Drawing.Point(229, 132);
			this.LinkKey.Name = "LinkKey";
			this.LinkKey.Size = new global::System.Drawing.Size(94, 13);
			this.LinkKey.TabIndex = 4;
			this.LinkKey.TabStop = true;
			this.LinkKey.Text = "Don't have a key?";
			this.LinkKey.VisitedLinkColor = global::System.Drawing.Color.White;
			this.LinkKey.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnClickLinkKey);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(34, 34, 34);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label1.Location = new global::System.Drawing.Point(10, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(106, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Enter Activation Key:";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.FromArgb(34, 34, 34);
			this.label2.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label2.Location = new global::System.Drawing.Point(10, 132);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(159, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Have GTA Opened and Loaded";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(34, 34, 34);
			base.ClientSize = new global::System.Drawing.Size(335, 154);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.LinkKey);
			base.Controls.Add(this.ButtonCancel);
			base.Controls.Add(this.ButtonOk);
			base.Controls.Add(this.TextKey);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormKeyInput";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Key Needed";
			base.Load += new global::System.EventHandler(this.FormKeyInput_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.TextBox TextKey;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button ButtonOk;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button ButtonCancel;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.LinkLabel LinkKey;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label2;
	}
}
