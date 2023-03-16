using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Snake
{
    class Food : Segment, ISegmentBehavior
    {
        private Random _random;

        public Food(int radius)
        {
            _random = new Random();
            Radius = radius;
           
        }

        public void Draw(Graphics graphics)
        {
            Bitmap bitmap = new Bitmap(GameResource.snake_apple);

            bitmap.MakeTransparent();
            graphics.DrawImage(bitmap, new Rectangle(this.X - Radius, this.Y - Radius, this.Radius * 2, this.Radius * 2));

        }

        public void Respawn(int width, int hight, Snake snake)
        {
            int px; 
            int py;

            bool isValidPosition = false;

            do
            {
                px = _random.Next(Radius, width - Radius) / (Radius * 2) * (Radius * 2);
                py = _random.Next(Radius, hight - Radius) / (Radius * 2) * (Radius * 2);

                bool isNoBodySnake = true;

               foreach(Segment item in snake.BodySnake)
                {
                    if(item.X == px && item.Y == py)
                    {
                        isNoBodySnake = false;
                        break;
                    }
                }

               if(isNoBodySnake)
                {
                    X = px;
                    Y = py;
                    isValidPosition = true;
                }


            } while (!isValidPosition);    
        }
    }
}
