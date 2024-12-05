namespace CodeX
{
    partial class FindForm
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
            this.AuthorTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.YearTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.GenreTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PublisherTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ISBN_TB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TitleTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BooksGridview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.FindBT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CoverPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicBox)).BeginInit();
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
            // AuthorTB
            // 
            this.AuthorTB.Location = new System.Drawing.Point(283, 75);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(175, 31);
            this.AuthorTB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AuthorTB.StateActive.Border.Rounding = 12;
            this.AuthorTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.AuthorTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AuthorTB.TabIndex = 1;
            // 
            // YearTB
            // 
            this.YearTB.Location = new System.Drawing.Point(574, 200);
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(175, 31);
            this.YearTB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.YearTB.StateActive.Border.Rounding = 12;
            this.YearTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.YearTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.YearTB.TabIndex = 2;
            // 
            // GenreTB
            // 
            this.GenreTB.Location = new System.Drawing.Point(574, 138);
            this.GenreTB.Name = "GenreTB";
            this.GenreTB.Size = new System.Drawing.Size(175, 31);
            this.GenreTB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GenreTB.StateActive.Border.Rounding = 12;
            this.GenreTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.GenreTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GenreTB.TabIndex = 3;
            // 
            // PublisherTB
            // 
            this.PublisherTB.Location = new System.Drawing.Point(574, 75);
            this.PublisherTB.Name = "PublisherTB";
            this.PublisherTB.Size = new System.Drawing.Size(175, 31);
            this.PublisherTB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PublisherTB.StateActive.Border.Rounding = 12;
            this.PublisherTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.PublisherTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PublisherTB.TabIndex = 4;
            // 
            // ISBN_TB
            // 
            this.ISBN_TB.Location = new System.Drawing.Point(283, 200);
            this.ISBN_TB.Name = "ISBN_TB";
            this.ISBN_TB.Size = new System.Drawing.Size(175, 31);
            this.ISBN_TB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ISBN_TB.StateActive.Border.Rounding = 12;
            this.ISBN_TB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.ISBN_TB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ISBN_TB.TabIndex = 5;
            // 
            // TitleTB
            // 
            this.TitleTB.Location = new System.Drawing.Point(283, 138);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(175, 31);
            this.TitleTB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TitleTB.StateActive.Border.Rounding = 12;
            this.TitleTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.TitleTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TitleTB.TabIndex = 6;
            // 
            // BooksGridview
            // 
            this.BooksGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGridview.Location = new System.Drawing.Point(29, 278);
            this.BooksGridview.Name = "BooksGridview";
            this.BooksGridview.Size = new System.Drawing.Size(720, 154);
            this.BooksGridview.TabIndex = 8;
            // 
            // FindBT
            // 
            this.FindBT.Location = new System.Drawing.Point(472, 237);
            this.FindBT.Name = "FindBT";
            this.FindBT.Size = new System.Drawing.Size(90, 35);
            this.FindBT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FindBT.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FindBT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.FindBT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.FindBT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FindBT.StateCommon.Border.Rounding = 15;
            this.FindBT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.FindBT.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.FindBT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.FindBT.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.FindBT.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.FindBT.TabIndex = 14;
            this.FindBT.Values.Text = "Find ";
            this.FindBT.Click += new System.EventHandler(this.FindBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Find To Book That Fit To You";
            // 
            // lb1
            // 
            this.lb1.AutoSize = false;
            this.lb1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lb1.Location = new System.Drawing.Point(331, 53);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(73, 20);
            this.lb1.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.lb1.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb1.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb1.TabIndex = 16;
            this.lb1.Values.Text = "Author";
            // 
            // lb2
            // 
            this.lb2.AutoSize = false;
            this.lb2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lb2.Location = new System.Drawing.Point(331, 112);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(73, 20);
            this.lb2.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.lb2.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb2.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb2.TabIndex = 17;
            this.lb2.Values.Text = "Title";
            // 
            // lb3
            // 
            this.lb3.AutoSize = false;
            this.lb3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lb3.Location = new System.Drawing.Point(331, 175);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(73, 20);
            this.lb3.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.lb3.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb3.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb3.TabIndex = 18;
            this.lb3.Values.Text = "ISBN";
            // 
            // lb4
            // 
            this.lb4.AutoSize = false;
            this.lb4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lb4.Location = new System.Drawing.Point(628, 49);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(73, 20);
            this.lb4.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.lb4.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb4.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb4.TabIndex = 19;
            this.lb4.Values.Text = "Publisher";
            // 
            // lb5
            // 
            this.lb5.AutoSize = false;
            this.lb5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lb5.Location = new System.Drawing.Point(628, 112);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(73, 20);
            this.lb5.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.lb5.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb5.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb5.TabIndex = 20;
            this.lb5.Values.Text = "Genre";
            // 
            // lb6
            // 
            this.lb6.AutoSize = false;
            this.lb6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lb6.Location = new System.Drawing.Point(628, 175);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(73, 20);
            this.lb6.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.lb6.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb6.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lb6.TabIndex = 21;
            this.lb6.Values.Text = "Year";
            // 
            // CoverPicBox
            // 
            this.CoverPicBox.Location = new System.Drawing.Point(29, 31);
            this.CoverPicBox.Name = "CoverPicBox";
            this.CoverPicBox.Size = new System.Drawing.Size(248, 241);
            this.CoverPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CoverPicBox.TabIndex = 22;
            this.CoverPicBox.TabStop = false;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoverPicBox);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindBT);
            this.Controls.Add(this.BooksGridview);
            this.Controls.Add(this.TitleTB);
            this.Controls.Add(this.ISBN_TB);
            this.Controls.Add(this.PublisherTB);
            this.Controls.Add(this.GenreTB);
            this.Controls.Add(this.YearTB);
            this.Controls.Add(this.AuthorTB);
            this.Name = "FindForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox AuthorTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox YearTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox GenreTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PublisherTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ISBN_TB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TitleTB;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView BooksGridview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton FindBT;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb6;
        private System.Windows.Forms.PictureBox CoverPicBox;
    }
}