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


        //public Food(int x, int y, int radius) : base(x, y, radius)
        //{
        //    _random = new Random();
        //}

        public void Draw(Graphics graphics)
        {
            Bitmap bitmap = new Bitmap(GameResource.snake_apple);

            bitmap.MakeTransparent();
            graphics.DrawImage(bitmap, new Rectangle(this.X - Radius, this.Y - Radius, this.Radius * 2, this.Radius * 2));

        }

        public void Respawn(int width, int hight, Snake snake)
        {
            //не за пределами игрового поля!!++
            //Координаті кратніе радиусу сегмента++
            //не должна біть в теле змеи

            int px; ; 
            int py;


            bool isValidPosition = false;

            do
            {
                px = _random.Next(Radius, width - Radius) / (Radius *2 ) * (Radius*2);
                py = _random.Next(Radius, hight - Radius) / (Radius * 2) * (Radius * 2);

               foreach(Segment item in snake.BodySnake)
                {
                    if(item.X == px && item.Y == py)
                    {
                        isValidPosition = false;
                        break;
                    }
                }

               if(isValidPosition)
                {
                    X = px;
                    Y = py;
                    isValidPosition = true;
                }


            } while (!isValidPosition);    
        }
    }
}
