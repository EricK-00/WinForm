namespace WinFormsApp
{
	partial class WindowsForm
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
			this.button_DrawLine = new System.Windows.Forms.Button();
			this.label_LineCount = new System.Windows.Forms.Label();
			this.label_TriangleCount = new System.Windows.Forms.Label();
			this.button_DrawTriangle = new System.Windows.Forms.Button();
			this.button_Clear = new System.Windows.Forms.Button();
			this.label_RectangleCount = new System.Windows.Forms.Label();
			this.button_DrawRectangle = new System.Windows.Forms.Button();
			this.label_TrianglePointY = new System.Windows.Forms.Label();
			this.label_TrianglePointX = new System.Windows.Forms.Label();
			this.textBox_LinePoint1X = new System.Windows.Forms.TextBox();
			this.textBox_LinePoint2X = new System.Windows.Forms.TextBox();
			this.label_LinePoint1 = new System.Windows.Forms.Label();
			this.textBox_LinePoint1Y = new System.Windows.Forms.TextBox();
			this.textBox_LinePoint2Y = new System.Windows.Forms.TextBox();
			this.label_LinePoint2 = new System.Windows.Forms.Label();
			this.label_LinePointX = new System.Windows.Forms.Label();
			this.label_LinePointY = new System.Windows.Forms.Label();
			this.textBox_TrianglePoint1X = new System.Windows.Forms.TextBox();
			this.textBox_TrianglePoint2X = new System.Windows.Forms.TextBox();
			this.label_TrianglePoint1 = new System.Windows.Forms.Label();
			this.textBox_TrianglePoint1Y = new System.Windows.Forms.TextBox();
			this.textBox_RectangleUpperLeftY = new System.Windows.Forms.TextBox();
			this.label_TrianglePoint2 = new System.Windows.Forms.Label();
			this.textBox_TrianglePoint3X = new System.Windows.Forms.TextBox();
			this.textBox_TrianglePoint3Y = new System.Windows.Forms.TextBox();
			this.label_TrianglePoint3 = new System.Windows.Forms.Label();
			this.label_RectangleWidth = new System.Windows.Forms.Label();
			this.textBox_RectangleWidth = new System.Windows.Forms.TextBox();
			this.textBox_RectangleHeight = new System.Windows.Forms.TextBox();
			this.label_RectangleHeight = new System.Windows.Forms.Label();
			this.label_RectangleUpperLeftX = new System.Windows.Forms.Label();
			this.label_RectangleUpperLeftY = new System.Windows.Forms.Label();
			this.textBox_RectangleUpperLeftX = new System.Windows.Forms.TextBox();
			this.label_RectangleUpperLeft = new System.Windows.Forms.Label();
			this.textBox_TrianglePoint2Y = new System.Windows.Forms.TextBox();
			this.button_CreatePlayer = new System.Windows.Forms.Button();
			this.label_PlayerControlDescription = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_DrawLine
			// 
			this.button_DrawLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_DrawLine.Location = new System.Drawing.Point(19, 509);
			this.button_DrawLine.Name = "button_DrawLine";
			this.button_DrawLine.Size = new System.Drawing.Size(110, 37);
			this.button_DrawLine.TabIndex = 1;
			this.button_DrawLine.Text = "선 그리기";
			this.button_DrawLine.UseVisualStyleBackColor = true;
			this.button_DrawLine.Click += new System.EventHandler(this.button_DrawLine_Click);
			// 
			// label_LineCount
			// 
			this.label_LineCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_LineCount.Location = new System.Drawing.Point(19, 549);
			this.label_LineCount.Name = "label_LineCount";
			this.label_LineCount.Size = new System.Drawing.Size(110, 25);
			this.label_LineCount.TabIndex = 3;
			this.label_LineCount.Text = "선 개수: 0";
			this.label_LineCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_TriangleCount
			// 
			this.label_TriangleCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label_TriangleCount.Location = new System.Drawing.Point(411, 549);
			this.label_TriangleCount.Name = "label_TriangleCount";
			this.label_TriangleCount.Size = new System.Drawing.Size(133, 25);
			this.label_TriangleCount.TabIndex = 5;
			this.label_TriangleCount.Text = "삼각형 개수: 0";
			this.label_TriangleCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_DrawTriangle
			// 
			this.button_DrawTriangle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_DrawTriangle.Location = new System.Drawing.Point(411, 509);
			this.button_DrawTriangle.Name = "button_DrawTriangle";
			this.button_DrawTriangle.Size = new System.Drawing.Size(133, 37);
			this.button_DrawTriangle.TabIndex = 4;
			this.button_DrawTriangle.Text = "삼각형 그리기";
			this.button_DrawTriangle.UseVisualStyleBackColor = true;
			this.button_DrawTriangle.Click += new System.EventHandler(this.button_DrawTriangle_Click);
			// 
			// button_Clear
			// 
			this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_Clear.Location = new System.Drawing.Point(803, 12);
			this.button_Clear.Name = "button_Clear";
			this.button_Clear.Size = new System.Drawing.Size(75, 33);
			this.button_Clear.TabIndex = 6;
			this.button_Clear.Text = "Clear";
			this.button_Clear.UseVisualStyleBackColor = true;
			this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
			// 
			// label_RectangleCount
			// 
			this.label_RectangleCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_RectangleCount.Location = new System.Drawing.Point(735, 549);
			this.label_RectangleCount.Name = "label_RectangleCount";
			this.label_RectangleCount.Size = new System.Drawing.Size(133, 25);
			this.label_RectangleCount.TabIndex = 13;
			this.label_RectangleCount.Text = "사각형 개수: 0";
			this.label_RectangleCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_DrawRectangle
			// 
			this.button_DrawRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_DrawRectangle.Location = new System.Drawing.Point(735, 509);
			this.button_DrawRectangle.Name = "button_DrawRectangle";
			this.button_DrawRectangle.Size = new System.Drawing.Size(133, 37);
			this.button_DrawRectangle.TabIndex = 12;
			this.button_DrawRectangle.Text = "사각형 그리기";
			this.button_DrawRectangle.UseVisualStyleBackColor = true;
			this.button_DrawRectangle.Click += new System.EventHandler(this.button_DrawRectangle_Click);
			// 
			// label_TrianglePointY
			// 
			this.label_TrianglePointY.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label_TrianglePointY.AutoSize = true;
			this.label_TrianglePointY.Location = new System.Drawing.Point(506, 406);
			this.label_TrianglePointY.Name = "label_TrianglePointY";
			this.label_TrianglePointY.Size = new System.Drawing.Size(13, 15);
			this.label_TrianglePointY.TabIndex = 31;
			this.label_TrianglePointY.Text = "y";
			// 
			// label_TrianglePointX
			// 
			this.label_TrianglePointX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label_TrianglePointX.AutoSize = true;
			this.label_TrianglePointX.Location = new System.Drawing.Point(477, 406);
			this.label_TrianglePointX.Name = "label_TrianglePointX";
			this.label_TrianglePointX.Size = new System.Drawing.Size(13, 15);
			this.label_TrianglePointX.TabIndex = 30;
			this.label_TrianglePointX.Text = "x";
			// 
			// textBox_LinePoint1X
			// 
			this.textBox_LinePoint1X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox_LinePoint1X.Location = new System.Drawing.Point(71, 451);
			this.textBox_LinePoint1X.Name = "textBox_LinePoint1X";
			this.textBox_LinePoint1X.Size = new System.Drawing.Size(34, 23);
			this.textBox_LinePoint1X.TabIndex = 7;
			// 
			// textBox_LinePoint2X
			// 
			this.textBox_LinePoint2X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox_LinePoint2X.Location = new System.Drawing.Point(71, 480);
			this.textBox_LinePoint2X.Name = "textBox_LinePoint2X";
			this.textBox_LinePoint2X.Size = new System.Drawing.Size(34, 23);
			this.textBox_LinePoint2X.TabIndex = 8;
			// 
			// label_LinePoint1
			// 
			this.label_LinePoint1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_LinePoint1.AutoSize = true;
			this.label_LinePoint1.Location = new System.Drawing.Point(19, 454);
			this.label_LinePoint1.Name = "label_LinePoint1";
			this.label_LinePoint1.Size = new System.Drawing.Size(30, 15);
			this.label_LinePoint1.TabIndex = 18;
			this.label_LinePoint1.Text = "점 1";
			// 
			// textBox_LinePoint1Y
			// 
			this.textBox_LinePoint1Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox_LinePoint1Y.Location = new System.Drawing.Point(103, 451);
			this.textBox_LinePoint1Y.Name = "textBox_LinePoint1Y";
			this.textBox_LinePoint1Y.Size = new System.Drawing.Size(34, 23);
			this.textBox_LinePoint1Y.TabIndex = 19;
			// 
			// textBox_LinePoint2Y
			// 
			this.textBox_LinePoint2Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox_LinePoint2Y.Location = new System.Drawing.Point(103, 480);
			this.textBox_LinePoint2Y.Name = "textBox_LinePoint2Y";
			this.textBox_LinePoint2Y.Size = new System.Drawing.Size(34, 23);
			this.textBox_LinePoint2Y.TabIndex = 20;
			// 
			// label_LinePoint2
			// 
			this.label_LinePoint2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_LinePoint2.AutoSize = true;
			this.label_LinePoint2.Location = new System.Drawing.Point(19, 483);
			this.label_LinePoint2.Name = "label_LinePoint2";
			this.label_LinePoint2.Size = new System.Drawing.Size(30, 15);
			this.label_LinePoint2.TabIndex = 21;
			this.label_LinePoint2.Text = "점 2";
			// 
			// label_LinePointX
			// 
			this.label_LinePointX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_LinePointX.AutoSize = true;
			this.label_LinePointX.Location = new System.Drawing.Point(71, 433);
			this.label_LinePointX.Name = "label_LinePointX";
			this.label_LinePointX.Size = new System.Drawing.Size(13, 15);
			this.label_LinePointX.TabIndex = 22;
			this.label_LinePointX.Text = "x";
			// 
			// label_LinePointY
			// 
			this.label_LinePointY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_LinePointY.AutoSize = true;
			this.label_LinePointY.Location = new System.Drawing.Point(103, 433);
			this.label_LinePointY.Name = "label_LinePointY";
			this.label_LinePointY.Size = new System.Drawing.Size(13, 15);
			this.label_LinePointY.TabIndex = 23;
			this.label_LinePointY.Text = "y";
			// 
			// textBox_TrianglePoint1X
			// 
			this.textBox_TrianglePoint1X.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_TrianglePoint1X.Location = new System.Drawing.Point(476, 424);
			this.textBox_TrianglePoint1X.Name = "textBox_TrianglePoint1X";
			this.textBox_TrianglePoint1X.Size = new System.Drawing.Size(31, 23);
			this.textBox_TrianglePoint1X.TabIndex = 24;
			// 
			// textBox_TrianglePoint2X
			// 
			this.textBox_TrianglePoint2X.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_TrianglePoint2X.Location = new System.Drawing.Point(476, 453);
			this.textBox_TrianglePoint2X.Name = "textBox_TrianglePoint2X";
			this.textBox_TrianglePoint2X.Size = new System.Drawing.Size(31, 23);
			this.textBox_TrianglePoint2X.TabIndex = 25;
			// 
			// label_TrianglePoint1
			// 
			this.label_TrianglePoint1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label_TrianglePoint1.AutoSize = true;
			this.label_TrianglePoint1.Location = new System.Drawing.Point(425, 427);
			this.label_TrianglePoint1.Name = "label_TrianglePoint1";
			this.label_TrianglePoint1.Size = new System.Drawing.Size(30, 15);
			this.label_TrianglePoint1.TabIndex = 26;
			this.label_TrianglePoint1.Text = "점 1";
			// 
			// textBox_TrianglePoint1Y
			// 
			this.textBox_TrianglePoint1Y.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_TrianglePoint1Y.Location = new System.Drawing.Point(506, 424);
			this.textBox_TrianglePoint1Y.Name = "textBox_TrianglePoint1Y";
			this.textBox_TrianglePoint1Y.Size = new System.Drawing.Size(30, 23);
			this.textBox_TrianglePoint1Y.TabIndex = 27;
			// 
			// textBox_RectangleUpperLeftY
			// 
			this.textBox_RectangleUpperLeftY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_RectangleUpperLeftY.Location = new System.Drawing.Point(829, 451);
			this.textBox_RectangleUpperLeftY.Name = "textBox_RectangleUpperLeftY";
			this.textBox_RectangleUpperLeftY.Size = new System.Drawing.Size(39, 23);
			this.textBox_RectangleUpperLeftY.TabIndex = 48;
			// 
			// label_TrianglePoint2
			// 
			this.label_TrianglePoint2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label_TrianglePoint2.AutoSize = true;
			this.label_TrianglePoint2.Location = new System.Drawing.Point(425, 456);
			this.label_TrianglePoint2.Name = "label_TrianglePoint2";
			this.label_TrianglePoint2.Size = new System.Drawing.Size(30, 15);
			this.label_TrianglePoint2.TabIndex = 29;
			this.label_TrianglePoint2.Text = "점 2";
			// 
			// textBox_TrianglePoint3X
			// 
			this.textBox_TrianglePoint3X.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_TrianglePoint3X.Location = new System.Drawing.Point(476, 482);
			this.textBox_TrianglePoint3X.Name = "textBox_TrianglePoint3X";
			this.textBox_TrianglePoint3X.Size = new System.Drawing.Size(31, 23);
			this.textBox_TrianglePoint3X.TabIndex = 32;
			// 
			// textBox_TrianglePoint3Y
			// 
			this.textBox_TrianglePoint3Y.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_TrianglePoint3Y.Location = new System.Drawing.Point(505, 482);
			this.textBox_TrianglePoint3Y.Name = "textBox_TrianglePoint3Y";
			this.textBox_TrianglePoint3Y.Size = new System.Drawing.Size(31, 23);
			this.textBox_TrianglePoint3Y.TabIndex = 33;
			// 
			// label_TrianglePoint3
			// 
			this.label_TrianglePoint3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label_TrianglePoint3.AutoSize = true;
			this.label_TrianglePoint3.Location = new System.Drawing.Point(425, 485);
			this.label_TrianglePoint3.Name = "label_TrianglePoint3";
			this.label_TrianglePoint3.Size = new System.Drawing.Size(30, 15);
			this.label_TrianglePoint3.TabIndex = 34;
			this.label_TrianglePoint3.Text = "점 3";
			// 
			// label_RectangleWidth
			// 
			this.label_RectangleWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_RectangleWidth.AutoSize = true;
			this.label_RectangleWidth.Location = new System.Drawing.Point(707, 482);
			this.label_RectangleWidth.Name = "label_RectangleWidth";
			this.label_RectangleWidth.Size = new System.Drawing.Size(31, 15);
			this.label_RectangleWidth.TabIndex = 37;
			this.label_RectangleWidth.Text = "너비";
			// 
			// textBox_RectangleWidth
			// 
			this.textBox_RectangleWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_RectangleWidth.Location = new System.Drawing.Point(752, 480);
			this.textBox_RectangleWidth.Name = "textBox_RectangleWidth";
			this.textBox_RectangleWidth.Size = new System.Drawing.Size(38, 23);
			this.textBox_RectangleWidth.TabIndex = 38;
			// 
			// textBox_RectangleHeight
			// 
			this.textBox_RectangleHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_RectangleHeight.Location = new System.Drawing.Point(845, 480);
			this.textBox_RectangleHeight.Name = "textBox_RectangleHeight";
			this.textBox_RectangleHeight.Size = new System.Drawing.Size(33, 23);
			this.textBox_RectangleHeight.TabIndex = 39;
			// 
			// label_RectangleHeight
			// 
			this.label_RectangleHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_RectangleHeight.AutoSize = true;
			this.label_RectangleHeight.Location = new System.Drawing.Point(796, 483);
			this.label_RectangleHeight.Name = "label_RectangleHeight";
			this.label_RectangleHeight.Size = new System.Drawing.Size(31, 15);
			this.label_RectangleHeight.TabIndex = 40;
			this.label_RectangleHeight.Text = "높이";
			// 
			// label_RectangleUpperLeftX
			// 
			this.label_RectangleUpperLeftX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_RectangleUpperLeftX.AutoSize = true;
			this.label_RectangleUpperLeftX.Location = new System.Drawing.Point(752, 454);
			this.label_RectangleUpperLeftX.Name = "label_RectangleUpperLeftX";
			this.label_RectangleUpperLeftX.Size = new System.Drawing.Size(13, 15);
			this.label_RectangleUpperLeftX.TabIndex = 41;
			this.label_RectangleUpperLeftX.Text = "x";
			// 
			// label_RectangleUpperLeftY
			// 
			this.label_RectangleUpperLeftY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_RectangleUpperLeftY.AutoSize = true;
			this.label_RectangleUpperLeftY.Location = new System.Drawing.Point(810, 454);
			this.label_RectangleUpperLeftY.Name = "label_RectangleUpperLeftY";
			this.label_RectangleUpperLeftY.Size = new System.Drawing.Size(13, 15);
			this.label_RectangleUpperLeftY.TabIndex = 42;
			this.label_RectangleUpperLeftY.Text = "y";
			// 
			// textBox_RectangleUpperLeftX
			// 
			this.textBox_RectangleUpperLeftX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_RectangleUpperLeftX.Location = new System.Drawing.Point(771, 450);
			this.textBox_RectangleUpperLeftX.Name = "textBox_RectangleUpperLeftX";
			this.textBox_RectangleUpperLeftX.Size = new System.Drawing.Size(39, 23);
			this.textBox_RectangleUpperLeftX.TabIndex = 46;
			// 
			// label_RectangleUpperLeft
			// 
			this.label_RectangleUpperLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_RectangleUpperLeft.AutoSize = true;
			this.label_RectangleUpperLeft.Location = new System.Drawing.Point(703, 453);
			this.label_RectangleUpperLeft.Name = "label_RectangleUpperLeft";
			this.label_RectangleUpperLeft.Size = new System.Drawing.Size(43, 15);
			this.label_RectangleUpperLeft.TabIndex = 47;
			this.label_RectangleUpperLeft.Text = "좌상단";
			// 
			// textBox_TrianglePoint2Y
			// 
			this.textBox_TrianglePoint2Y.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_TrianglePoint2Y.Location = new System.Drawing.Point(505, 453);
			this.textBox_TrianglePoint2Y.Name = "textBox_TrianglePoint2Y";
			this.textBox_TrianglePoint2Y.Size = new System.Drawing.Size(31, 23);
			this.textBox_TrianglePoint2Y.TabIndex = 28;
			// 
			// button_CreatePlayer
			// 
			this.button_CreatePlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button_CreatePlayer.Location = new System.Drawing.Point(410, 12);
			this.button_CreatePlayer.Name = "button_CreatePlayer";
			this.button_CreatePlayer.Size = new System.Drawing.Size(126, 23);
			this.button_CreatePlayer.TabIndex = 49;
			this.button_CreatePlayer.Text = "플레이어 생성";
			this.button_CreatePlayer.UseVisualStyleBackColor = true;
			this.button_CreatePlayer.Click += new System.EventHandler(this.button_CreatePlayer_Click);
			// 
			// label_PlayerControlDescription
			// 
			this.label_PlayerControlDescription.Location = new System.Drawing.Point(410, 38);
			this.label_PlayerControlDescription.Name = "label_PlayerControlDescription";
			this.label_PlayerControlDescription.Size = new System.Drawing.Size(126, 46);
			this.label_PlayerControlDescription.TabIndex = 50;
			this.label_PlayerControlDescription.Text = "Keys: W A S D\r\n사각형은 밀 수 있음";
			this.label_PlayerControlDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WindowsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(896, 585);
			this.Controls.Add(this.label_PlayerControlDescription);
			this.Controls.Add(this.button_CreatePlayer);
			this.Controls.Add(this.textBox_RectangleUpperLeftY);
			this.Controls.Add(this.label_RectangleUpperLeft);
			this.Controls.Add(this.textBox_RectangleUpperLeftX);
			this.Controls.Add(this.label_RectangleUpperLeftY);
			this.Controls.Add(this.label_RectangleUpperLeftX);
			this.Controls.Add(this.label_RectangleHeight);
			this.Controls.Add(this.textBox_RectangleHeight);
			this.Controls.Add(this.textBox_RectangleWidth);
			this.Controls.Add(this.label_RectangleWidth);
			this.Controls.Add(this.label_TrianglePoint3);
			this.Controls.Add(this.textBox_TrianglePoint3Y);
			this.Controls.Add(this.textBox_TrianglePoint3X);
			this.Controls.Add(this.label_TrianglePointY);
			this.Controls.Add(this.label_TrianglePointX);
			this.Controls.Add(this.label_TrianglePoint2);
			this.Controls.Add(this.textBox_TrianglePoint2Y);
			this.Controls.Add(this.textBox_TrianglePoint1Y);
			this.Controls.Add(this.label_TrianglePoint1);
			this.Controls.Add(this.textBox_TrianglePoint2X);
			this.Controls.Add(this.textBox_TrianglePoint1X);
			this.Controls.Add(this.label_LinePointY);
			this.Controls.Add(this.label_LinePointX);
			this.Controls.Add(this.label_LinePoint2);
			this.Controls.Add(this.textBox_LinePoint2Y);
			this.Controls.Add(this.textBox_LinePoint1Y);
			this.Controls.Add(this.label_LinePoint1);
			this.Controls.Add(this.label_RectangleCount);
			this.Controls.Add(this.button_DrawRectangle);
			this.Controls.Add(this.textBox_LinePoint2X);
			this.Controls.Add(this.textBox_LinePoint1X);
			this.Controls.Add(this.button_Clear);
			this.Controls.Add(this.label_TriangleCount);
			this.Controls.Add(this.button_DrawTriangle);
			this.Controls.Add(this.label_LineCount);
			this.Controls.Add(this.button_DrawLine);
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			this.Name = "WindowsForm";
			this.Text = "WindowsForm";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.WindowsForm_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GetKeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Button button_DrawLine;
		private Label label_LineCount;
		private Label label_TriangleCount;
		private Button button_DrawTriangle;
		private Button button_Clear;
		private Label label_RectangleCount;
		private Button button_DrawRectangle;
		private Label label_TrianglePointY;
		private Label label_TrianglePointX;
		private TextBox textBox_LinePoint1X;
		private TextBox textBox_LinePoint2X;
		private Label label_LinePoint1;
		private TextBox textBox_LinePoint1Y;
		private TextBox textBox_LinePoint2Y;
		private Label label_LinePoint2;
		private Label label_LinePointX;
		private Label label_LinePointY;
		private TextBox textBox_TrianglePoint1X;
		private TextBox textBox_TrianglePoint2X;
		private Label label_TrianglePoint1;
		private TextBox textBox_TrianglePoint1Y;
		private TextBox textBox_RectangleUpperLeftY;
		private Label label_TrianglePoint2;
		private TextBox textBox_TrianglePoint3X;
		private TextBox textBox_TrianglePoint3Y;
		private Label label_TrianglePoint3;
		private Label label_RectangleWidth;
		private TextBox textBox_RectangleWidth;
		private TextBox textBox_RectangleHeight;
		private Label label_RectangleHeight;
		private Label label_RectangleUpperLeftX;
		private Label label_RectangleUpperLeftY;
		private TextBox textBox_RectangleUpperLeftX;
		private Label label_RectangleUpperLeft;
		private TextBox textBox_TrianglePoint2Y;
		private Button button_CreatePlayer;
		private Label label_PlayerControlDescription;
	}
}