using System.Windows.Forms;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace WinFormsApp
{

	public partial class WindowsForm : Form
	{

		Graphics graphics;
		Pen pen;
		int lineCount;
		int triangleCount;
		int rectangleCount;

		Player? player;

		public WindowsForm()
		{
			InitializeComponent();

			graphics = CreateGraphics();
			pen = new Pen(Color.Black);

			lineCount = 0;
			triangleCount = 0;
			rectangleCount = 0;
			textBox_LinePoint1X.Text = "0";
			textBox_LinePoint1Y.Text = "0";
			textBox_LinePoint2X.Text = "0";
			textBox_LinePoint2Y.Text = "0";
			textBox_TrianglePoint1X.Text = "0";
			textBox_TrianglePoint1Y.Text = "0";
			textBox_TrianglePoint2X.Text = "0";
			textBox_TrianglePoint2Y.Text = "0";
			textBox_TrianglePoint3X.Text = "0";
			textBox_TrianglePoint3Y.Text = "0";
			textBox_RectangleUpperLeftX.Text = "0";
			textBox_RectangleUpperLeftY.Text = "0";
			textBox_RectangleWidth.Text = "0";
			textBox_RectangleHeight.Text = "0";
		}

		private void button_DrawLine_Click(object sender, EventArgs e)
		{
			int p1X = 0, p1Y = 0;
			int p2X = 0, p2Y = 0;
			bool isValidValue =
				int.TryParse(textBox_LinePoint1X.Text, out p1X) &&
				int.TryParse(textBox_LinePoint1Y.Text, out p1Y) &&
				int.TryParse(textBox_LinePoint2X.Text, out p2X) &&
				int.TryParse(textBox_LinePoint2Y.Text, out p2Y);
			Point p1 = new Point(p1X, p1Y);
			Point p2 = new Point(p2X, p2Y);

			if (!isValidValue || p1 == p2)
				return;
			else
				graphics.DrawLine(pen, p1, p2);

			++lineCount;
			if (lineCount >= 2)
				label_LineCount.Text = $"{lineCount} lines drawn";
			else if (lineCount == 1)
				label_LineCount.Text = $"{lineCount} line drawn";
			else
				label_LineCount.Text = $"no line";
		}

		private void button_DrawTriangle_Click(object sender, EventArgs e)
		{
			int p1X = 0, p1Y = 0;
			int p2X = 0, p2Y = 0;
			int p3X = 0, p3Y = 0;
			bool isValidValue =
				int.TryParse(textBox_TrianglePoint1X.Text, out p1X) &&
				int.TryParse(textBox_TrianglePoint1Y.Text, out p1Y) &&
				int.TryParse(textBox_TrianglePoint2X.Text, out p2X) &&
				int.TryParse(textBox_TrianglePoint3X.Text, out p3X) &&
				int.TryParse(textBox_TrianglePoint2Y.Text, out p2Y) &&
				int.TryParse(textBox_TrianglePoint3Y.Text, out p3Y);
			Point p1 = new Point(p1X, p1Y);
			Point p2 = new Point(p2X, p2Y);
			Point p3 = new Point(p3X, p3Y);

			if (!isValidValue || p1 == p2 || p2 == p3 || p3 == p1)
				return;

			double length1, length2, length3;
			length1 = Math.Sqrt(Math.Pow(p2X - p1X, 2) + Math.Pow(p2Y - p1Y, 2));
			length2 = Math.Sqrt(Math.Pow(p3X - p2X, 2) + Math.Pow(p3Y - p2Y, 2));
			length3 = Math.Sqrt(Math.Pow(p3X - p1X, 2) + Math.Pow(p3Y - p1Y, 2));
			bool isValidTriangle = !(Math.Abs(length1 - (length2 + length3)) < double.Epsilon) &&
									!(Math.Abs(length2 - (length1 + length3)) < double.Epsilon) &&
									!(Math.Abs(length3 - (length1 + length2)) < double.Epsilon);

			if (!isValidTriangle)
				return;
			else
			{
				graphics.DrawLine(pen, p1, p2);
				graphics.DrawLine(pen, p2, p3);
				graphics.DrawLine(pen, p3, p1);
			}

			++triangleCount;
			if (triangleCount >= 2)
				label_TriangleCount.Text = $"{triangleCount} triangles drawn";
			else if (triangleCount == 1)
				label_TriangleCount.Text = $"{triangleCount} triangle drawn";
			else
				label_TriangleCount.Text = $"no triangle";
		}
		private void button_DrawRectangle_Click(object sender, EventArgs e)
		{
			int UpperLeftX = 0, UpperLeftY = 0;
			int width = 0, height = 0;
			bool isValidValue =
				int.TryParse(textBox_RectangleUpperLeftX.Text, out UpperLeftX) &&
				int.TryParse(textBox_RectangleUpperLeftY.Text, out UpperLeftY) &&
				int.TryParse(textBox_RectangleWidth.Text, out width) &&
				int.TryParse(textBox_RectangleHeight.Text, out height);
			Rectangle rect = new Rectangle(UpperLeftX, UpperLeftY, width, height);

			if (!isValidValue || width == 0 || height == 0)
				return;
			else
				graphics.DrawRectangle(pen, rect);

			++rectangleCount;
			if (rectangleCount >= 2)
				label_RectangleCount.Text = $"{rectangleCount} rectangles drawn";
			else if (rectangleCount == 1)
				label_RectangleCount.Text = $"{rectangleCount} rectangle drawn";
			else
				label_RectangleCount.Text = $"no rectangle";
		}

		private void button_Clear_Click(object sender, EventArgs e)
		{
			graphics.Clear(Color.White);
			player = default;

			lineCount = 0;
			triangleCount = 0;
			rectangleCount = 0;
			label_LineCount.Text = "no line";
			label_TriangleCount.Text = "no triangle";
			label_RectangleCount.Text = "no rectangle";
		}

		private void button_CreatePlayer_Click(object sender, EventArgs e)
		{
			player = new Player(pen, graphics);
		}

		private void GetKeyDown(object sender, KeyEventArgs e)
		{
			Refresh();
			if (player != null)
			{
				if (e.KeyCode == Keys.A)
				{
					player.Move(-1, 0);
				}
				if (e.KeyCode == Keys.D)
				{
					player.Move(+1, 0);
				}
				if (e.KeyCode == Keys.W)
				{
					player.Move(0, -1);
				}
				if (e.KeyCode == Keys.S)
				{
					player.Move(0, +1);
				}
			}

			//switch (e.KeyCode)
			//{
			//	case Keys.Left:
			//		player.MovePlayer(-1, 0);
			//		break;
			//	case Keys.Right:
			//		player.MovePlayer(+1, 0);
			//		break;
			//	case Keys.Up:
			//		player.MovePlayer(0, -1);
			//		break;
			//	case Keys.Down:
			//		player.MovePlayer(0, +1);
			//		break;
			//}
		}
	}

	class Player
	{
		public const int PLAYER_WIDTH = 50;
		public const int PLAYER_HEIGHT = 50;
		public const int PLAYER_SPEED = 10;

		public Rectangle playerShape;
		private int playerX = 0;
		private int playerY = 0;

		Pen pen;
		Graphics graphics;

		public Player(Pen pen_, Graphics graphics_)
		{
			pen = pen_;
			graphics = graphics_;

			playerShape = new Rectangle(playerX, playerY, PLAYER_WIDTH, PLAYER_HEIGHT);
			Draw();
		}

		public void Move(int xDirection, int yDirection)
		{
			playerX += xDirection * PLAYER_SPEED;
			playerY += yDirection * PLAYER_SPEED;
			playerShape = new Rectangle(playerX, playerY, PLAYER_WIDTH, PLAYER_HEIGHT);
			Draw();
		}

		private void Draw()
		{
			graphics.DrawRectangle(pen, playerShape);
		}
	}
}