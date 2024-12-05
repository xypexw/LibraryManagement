namespace CodeX
{
    partial class OTPForm
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.InformationLB1 = new System.Windows.Forms.Label();
            this.InformationLB2 = new System.Windows.Forms.Label();
            this.otpTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.veriflyBT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Option1LB = new System.Windows.Forms.Label();
            this.RequestLB = new System.Windows.Forms.Label();
            this.InformationLB4 = new System.Windows.Forms.Label();
            this.Re_EnterBT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TimeBT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            // 
            // InformationLB1
            // 
            this.InformationLB1.Font = new System.Drawing.Font("Segoe UI Black", 22.75F, System.Drawing.FontStyle.Bold);
            this.InformationLB1.Location = new System.Drawing.Point(289, 53);
            this.InformationLB1.Name = "InformationLB1";
            this.InformationLB1.Size = new System.Drawing.Size(237, 50);
            this.InformationLB1.TabIndex = 20;
            this.InformationLB1.Text = "Confirm OTP";
            this.InformationLB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationLB2
            // 
            this.InformationLB2.AutoSize = true;
            this.InformationLB2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLB2.Location = new System.Drawing.Point(258, 117);
            this.InformationLB2.Name = "InformationLB2";
            this.InformationLB2.Size = new System.Drawing.Size(297, 30);
            this.InformationLB2.TabIndex = 21;
            this.InformationLB2.Text = "Enter the OTP we just sent you";
            // 
            // otpTextBox
            // 
            this.otpTextBox.Location = new System.Drawing.Point(208, 169);
            this.otpTextBox.Name = "otpTextBox";
            this.otpTextBox.Size = new System.Drawing.Size(399, 31);
            this.otpTextBox.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.otpTextBox.StateActive.Border.Rounding = 12;
            this.otpTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.otpTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.otpTextBox.TabIndex = 22;
            // 
            // veriflyBT
            // 
            this.veriflyBT.Location = new System.Drawing.Point(208, 245);
            this.veriflyBT.Name = "veriflyBT";
            this.veriflyBT.Size = new System.Drawing.Size(399, 45);
            this.veriflyBT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.veriflyBT.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.veriflyBT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.veriflyBT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.veriflyBT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.veriflyBT.StateCommon.Border.Rounding = 15;
            this.veriflyBT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.veriflyBT.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.veriflyBT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veriflyBT.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.veriflyBT.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.veriflyBT.TabIndex = 23;
            this.veriflyBT.Values.Text = "Verifly the OTP";
            this.veriflyBT.Click += new System.EventHandler(this.veriflyBT_Click);
            // 
            // Option1LB
            // 
            this.Option1LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Option1LB.Location = new System.Drawing.Point(260, 211);
            this.Option1LB.Name = "Option1LB";
            this.Option1LB.Size = new System.Drawing.Size(175, 19);
            this.Option1LB.TabIndex = 24;
            this.Option1LB.Text = "Didn\'t receive the code?";
            // 
            // RequestLB
            // 
            this.RequestLB.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.RequestLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.RequestLB.Location = new System.Drawing.Point(421, 210);
            this.RequestLB.Name = "RequestLB";
            this.RequestLB.Size = new System.Drawing.Size(134, 19);
            this.RequestLB.TabIndex = 25;
            this.RequestLB.Text = "Request again";
            // 
            // InformationLB4
            // 
            this.InformationLB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.InformationLB4.Location = new System.Drawing.Point(205, 311);
            this.InformationLB4.Name = "InformationLB4";
            this.InformationLB4.Size = new System.Drawing.Size(230, 58);
            this.InformationLB4.TabIndex = 26;
            this.InformationLB4.Text = "\"If the email address is wrong. \r\nDo you want to provide a different email?\"";
            // 
            // Re_EnterBT
            // 
            this.Re_EnterBT.Location = new System.Drawing.Point(441, 311);
            this.Re_EnterBT.Name = "Re_EnterBT";
            this.Re_EnterBT.Size = new System.Drawing.Size(166, 58);
            this.Re_EnterBT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Re_EnterBT.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Re_EnterBT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Re_EnterBT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Re_EnterBT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Re_EnterBT.StateCommon.Border.Rounding = 15;
            this.Re_EnterBT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Re_EnterBT.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Re_EnterBT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re_EnterBT.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Re_EnterBT.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Re_EnterBT.TabIndex = 27;
            this.Re_EnterBT.Values.Text = "Re-enter";
            this.Re_EnterBT.Click += new System.EventHandler(this.Re_EnterBT_Click);
            // 
            // TimeBT
            // 
            this.TimeBT.Enabled = false;
            this.TimeBT.Location = new System.Drawing.Point(613, 169);
            this.TimeBT.Name = "TimeBT";
            this.TimeBT.Size = new System.Drawing.Size(38, 31);
            this.TimeBT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TimeBT.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TimeBT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.TimeBT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.TimeBT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeBT.StateCommon.Border.Rounding = 15;
            this.TimeBT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.TimeBT.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.TimeBT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.TimeBT.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.TimeBT.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.TimeBT.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.TimeBT.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.TimeBT.TabIndex = 28;
            this.TimeBT.Values.Text = "300";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeBT);
            this.Controls.Add(this.Re_EnterBT);
            this.Controls.Add(this.InformationLB4);
            this.Controls.Add(this.RequestLB);
            this.Controls.Add(this.Option1LB);
            this.Controls.Add(this.veriflyBT);
            this.Controls.Add(this.otpTextBox);
            this.Controls.Add(this.InformationLB2);
            this.Controls.Add(this.InformationLB1);
            this.Name = "OTPForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label InformationLB1;
        internal System.Windows.Forms.Label InformationLB2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox otpTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton veriflyBT;
        internal System.Windows.Forms.Label Option1LB;
        internal System.Windows.Forms.Label RequestLB;
        internal System.Windows.Forms.Label InformationLB4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Re_EnterBT;
        protected ComponentFactory.Krypton.Toolkit.KryptonButton TimeBT;
        private System.Windows.Forms.Timer timer1;
    }
}