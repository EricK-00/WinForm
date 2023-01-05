using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
	class Player
	{
		public int X { get; private set; } = 0;
		public int Y { get; private set; } = 0;
		public int Width { get; private set; } = 50;
		public int Height { get; private set; } = 50;
		public const int DEFAULT_SPEED = 10;
		public int Speed { get; private set; } = DEFAULT_SPEED;

		public Rectangle Shape { get; private set; }

		public Player()
		{
			Shape = new Rectangle(X, Y, Width, Height);
		}

		public void Move(int xDirection, int yDirection)
		{
			X += xDirection * Speed;
			Y += yDirection * Speed;
			Shape = new Rectangle(X, Y, Width, Height);
		}
	}
}
