using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
	internal class Utility
	{
		public static bool DetectRectCollision(Rectangle rect1, Rectangle rect2)
		{
			int maxX = Math.Max(rect1.Right, rect2.Right);
			int minX = Math.Min(rect1.Left, rect2.Left);
			int maxY = Math.Max(rect1.Bottom, rect2.Bottom);
			int minY = Math.Min(rect1.Top, rect2.Top);

			if (maxX - minX < rect1.Width + rect2.Width &&
				maxY - minY < rect1.Height + rect2.Height)
				return true;
			else
				return false;
		}
	}
}
