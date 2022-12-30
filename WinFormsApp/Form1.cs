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

		List<Point[]> lines;
		List<Point[]> triangles;
		List<Rectangle> rectangles;

		Player? player;

		public WindowsForm()
		{
			InitializeComponent();

			graphics = CreateGraphics();
			pen = new Pen(Color.Black);

			lines = new List<Point[]>();
			triangles = new List<Point[]>();
			rectangles = new List<Rectangle>();

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
			{
				Point[] line = new Point[2] { p1, p2 };
				lines.Add(line);
				Refresh();

				label_LineCount.Text = $"선 개수: {lines.Count}";
			}
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

			//세 점이 한 직선 위에 있는지 판단
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
				Point[] tri = new Point[3] { p1, p2, p3 };
				triangles.Add(tri);
				Refresh();

				label_TriangleCount.Text = $"삼각형 개수: {triangles.Count}";
			}
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
			{
				rectangles.Add(rect);
				Refresh();

				label_RectangleCount.Text = $"사각형 개수: {rectangles.Count}";
			}
		}

		private void button_Clear_Click(object sender, EventArgs e)
		{
			graphics.Clear(Color.White);
			player = default;

			lines.Clear();
			triangles.Clear();
			rectangles.Clear();

			label_LineCount.Text = $"선 개수: {lines.Count}";
			label_TriangleCount.Text = $"삼각형 개수: {triangles.Count}";
			label_RectangleCount.Text = $"사각형 개수: {rectangles.Count}";
		}

		private void button_CreatePlayer_Click(object sender, EventArgs e)
		{
			if (player == null)
				player = new Player();

			Refresh();
		}

		private void GetKeyDown(object sender, KeyEventArgs e)
		{
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

			Refresh();
		}

		private void WindowsForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;

			if (player != null)
			{
				graphics.DrawRectangle(pen, player.PlayerShape);
			}

			if (lines != null)
			{
				for (int i = 0; i < lines.Count; i++)
					graphics.DrawLine(pen, lines[i][0], lines[i][1]);
			}
			if (triangles != null)
			{
				for (int i = 0; i < triangles.Count; i++)
					graphics.DrawPolygon(pen, triangles[i]);
			}
			if (rectangles != null)
			{
				foreach (var rect in rectangles)
					graphics.DrawRectangle(pen, rect);
			}
		}
	}

	class Player
	{
		const int PLAYER_WIDTH = 50;
		const int PLAYER_HEIGHT = 50;
		const int PLAYER_SPEED = 10;

		public Rectangle PlayerShape { get; private set; }
		private int playerX = 0;
		private int playerY = 0;

		public Player()
		{
			PlayerShape = new Rectangle(playerX, playerY, PLAYER_WIDTH, PLAYER_HEIGHT);
		}

		public void Move(int xDirection, int yDirection)
		{
			playerX += xDirection * PLAYER_SPEED;
			playerY += yDirection * PLAYER_SPEED;
			PlayerShape = new Rectangle(playerX, playerY, PLAYER_WIDTH, PLAYER_HEIGHT);
		}
	}
}