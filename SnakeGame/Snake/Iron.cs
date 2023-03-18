using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Snake
{
    class Iron : Segment, ISegmentBehavior
    {
        private Random _random;

        public Iron(int radius)
        {
            _random = new Random();
            Radius = radius;

        }

        public void Draw(Graphics graphics)
        {
            Bitmap bitmap = new Bitmap(GameResource.Iron);

            bitmap.MakeTransparent();
            graphics.DrawImage(bitmap, new Rectangle(this.X - Radius, this.Y - Radius, this.Radius * 2, this.Radius * 2));

        }



    }
}
