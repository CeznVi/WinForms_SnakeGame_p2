using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Snake
{
    class Irons : ISegmentBehavior
    {
        private Random _random;

        public Irons()
        {
            _random = new Random();
        }

        public List<Iron> irons = new List<Iron>();





        public void Draw(Graphics graphics)
        {
            foreach (var item in irons)
            {
                if(item is Iron)
                    item.Draw(graphics);
            }
        }
        



        public void AddIron(int width, int hight, Snake snake, Food food)
        {
            Iron iron = new Iron();
            int px = 0;
            int py = 0;

            bool isValidPosition = false;

            do
            {
                px = _random.Next(iron.Radius * 2, width - iron.Radius) / (iron.Radius * 2) * (iron.Radius * 2);
                py = _random.Next(iron.Radius * 2, hight - iron.Radius) / (iron.Radius * 2) * (iron.Radius * 2);

                bool isNoBodySnakeAndFood = true;

                foreach (Segment item in snake.BodySnake)
                {
                    if (item.X == px && item.Y == py && food.X == px && food.Y == py)
                    {
                        isNoBodySnakeAndFood = false;
                        break;
                    }
                }

                bool isNoIrons = true;

                foreach(Iron item in irons)
                {
                    if(item.X == px && item.Y == py)
                    {
                        isNoIrons = false;
                        break;
                    }
                }

                if (isNoBodySnakeAndFood && isNoIrons)
                {
                    iron.X = px;
                    iron.Y = py;
                    isValidPosition = true;
                }


            } while (!isValidPosition);

            irons.Add(iron);
        }


    }
}
