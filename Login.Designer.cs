using System.Windows.Forms;

namespace CodeX
{
    partial class Login
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
            this.UserNameTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.PasswordTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.InformationLB1 = new System.Windows.Forms.Label();
            this.LoginBT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.SignUpBT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LogicLB1 = new System.Windows.Forms.Label();
            this.LoginLB3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(391, 176);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(297, 31);
            this.UserNameTB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UserNameTB.StateActive.Border.Rounding = 12;
            this.UserNameTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.UserNameTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UserNameTB.TabIndex = 0;
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
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(391, 253);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(297, 31);
            this.PasswordTB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PasswordTB.StateActive.Border.Rounding = 12;
            this.PasswordTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.PasswordTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PasswordTB.TabIndex = 1;
            // 
            // InformationLB1
            // 
            this.InformationLB1.AutoSize = true;
            this.InformationLB1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLB1.Location = new System.Drawing.Point(386, 61);
            this.InformationLB1.Name = "InformationLB1";
            this.InformationLB1.Size = new System.Drawing.Size(279, 60);
            this.InformationLB1.TabIndex = 5;
            this.InformationLB1.Text = "The Ultimate \r\nLibrary Mangagement Tool";
            // 
            // LoginBT
            // 
            this.LoginBT.Location = new System.Drawing.Point(391, 318);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(126, 45);
            this.LoginBT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.LoginBT.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.LoginBT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.LoginBT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.LoginBT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoginBT.StateCommon.Border.Rounding = 15;
            this.LoginBT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.LoginBT.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.LoginBT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBT.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.LoginBT.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.LoginBT.TabIndex = 6;
            this.LoginBT.Values.Text = "Login";
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(571, 290);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(117, 20);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Forgot Password ?";
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.Image = global::CodeX.Properties.Resources.Login_Icon;
            this.LoginPictureBox.Location = new System.Drawing.Point(12, 61);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(303, 332);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPictureBox.TabIndex = 9;
            this.LoginPictureBox.TabStop = false;
            // 
            // SignUpBT
            // 
            this.SignUpBT.Location = new System.Drawing.Point(562, 318);
            this.SignUpBT.Name = "SignUpBT";
            this.SignUpBT.Size = new System.Drawing.Size(126, 45);
            this.SignUpBT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SignUpBT.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SignUpBT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.SignUpBT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.SignUpBT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignUpBT.StateCommon.Border.Rounding = 15;
            this.SignUpBT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.SignUpBT.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.SignUpBT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBT.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.SignUpBT.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.SignUpBT.TabIndex = 13;
            this.SignUpBT.Values.Text = "Sign Up";
            this.SignUpBT.Click += new System.EventHandler(this.SiginUp_click);
            // 
            // LogicLB1
            // 
            this.LogicLB1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogicLB1.Location = new System.Drawing.Point(488, 150);
            this.LogicLB1.Name = "LogicLB1";
            this.LogicLB1.Size = new System.Drawing.Size(100, 23);
            this.LogicLB1.TabIndex = 14;
            this.LogicLB1.Text = "Username";
            // 
            // LoginLB3
            // 
            this.LoginLB3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLB3.Location = new System.Drawing.Point(488, 227);
            this.LoginLB3.Name = "LoginLB3";
            this.LoginLB3.Size = new System.Drawing.Size(100, 23);
            this.LoginLB3.TabIndex = 15;
            this.LoginLB3.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginLB3);
            this.Controls.Add(this.LogicLB1);
            this.Controls.Add(this.SignUpBT);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.InformationLB1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Name = "Login";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox UserNameTB;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PasswordTB;
        private System.Windows.Forms.Label InformationLB1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton LoginBT;
        private System.Windows.Forms.PictureBox LoginPictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SignUpBT;
        private Label LogicLB1;
        private Label LoginLB3;
    }
}

