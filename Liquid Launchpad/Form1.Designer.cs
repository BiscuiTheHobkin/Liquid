namespace LiquidLaunchpad
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
        public Form1()
        {
            this.InitializeComponent();
        }
        private void InitializeComponent()
		{
            this.label2 = new System.Windows.Forms.Label();
            this.IconLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Have GTA Opened and Loaded";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IconLogo
            // 
            this.IconLogo.Location = new System.Drawing.Point(13, 12);
            this.IconLogo.Name = "IconLogo";
            this.IconLogo.Size = new System.Drawing.Size(302, 97);
            this.IconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconLogo.TabIndex = 7;
            this.IconLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inject Liquid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonInject);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(322, 156);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Key Needed ??? x3";
            this.Load += new System.EventHandler(this.FormKeyInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.PictureBox IconLogo;
        private System.Windows.Forms.Button button1;
    }
}
