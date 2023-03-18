using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame.Snake
{
    class Snake : ISegmentBehavior
    {

        List<Segment> _snake;
        
        public Snake()
        {
            _snake = new List<Segment>();

            _snake.Add(new HeadSnake(120,120,15,Direction.UP));
            _snake.Add(new SegmentSnake(Head.X, Head.Y+2*Head.Radius, Head.Radius, Direction.UP));
            _snake.Add(new TailSnake(Head.X, Head.Y + 4 * Head.Radius, Head.Radius, Direction.UP));
        }

        public List<Segment> BodySnake
        {
            get
            {
                return _snake;
                    
            }
        }

        public HeadSnake Head
        {
            get 
            {
                return (HeadSnake)_snake.FirstOrDefault();
            }
        }

        public void Draw(Graphics graphics)
        {
            
            foreach (var item in _snake) 
            { 
                if(item is HeadSnake) 
                {
                    ((HeadSnake)item).Draw(graphics);
                }
                else if (item is SegmentSnake) 
                { 
                    ((SegmentSnake)item).Draw(graphics);
                }
                else if(item is TailSnake) 
                {
                    ((TailSnake)item).Draw(graphics);
                }
            }
        }

        public void Move()
        {
            int x = 0, y = 0;
            int xlast = 0, ylast = 0;

            Direction currDir = Direction.NULL;
            Direction lastDir = Direction.NULL;

            foreach(var item in _snake) 
            {
                currDir = item.CurrentDirection;
                x = item.X;
                y = item.Y;

                if (item is HeadSnake) 
                {
                     
                    xlast = item.X;
                    ylast = item.Y;

                    if (currDir == Direction.UP) 
                        item.Y -= item.Radius * 2;
                    else if (currDir == Direction.DOWN)
                        item.Y +=  item.Radius * 2;
                    else if (currDir == Direction.LEFT)
                        item.X -= item.Radius * 2;
                    else if (currDir == Direction.RIGHT)
                        item.X += item.Radius * 2;

                }
                else if(item is SegmentSnake)
                {
                    ///Angle UP Right
                    if (lastDir == Direction.RIGHT && currDir == Direction.UP)
                        item.CurrentDirection = Direction.UR;
                    else if (lastDir == Direction.UR && currDir == Direction.UP)
                        item.CurrentDirection = Direction.UR;
                    else if (lastDir == Direction.DOWN && currDir == Direction.UR)
                        item.CurrentDirection = Direction.RD;
                    else if (lastDir == Direction.UP && currDir == Direction.UR)
                        item.CurrentDirection = Direction.RU;
                    else if (lastDir == Direction.RD && currDir == Direction.UR)
                        item.CurrentDirection = Direction.RD;
                    else if (lastDir == Direction.RU && currDir == Direction.UR)
                        item.CurrentDirection = Direction.RU;
                    ///Angle UP LEFT
                    else if (lastDir == Direction.LEFT && currDir == Direction.UP)
                        item.CurrentDirection = Direction.UL;
                    else if (lastDir == Direction.UL && currDir == Direction.UP)
                        item.CurrentDirection = Direction.UL;
                    else if (lastDir == Direction.DOWN && currDir == Direction.UL)
                        item.CurrentDirection = Direction.LD;
                    else if (lastDir == Direction.UP && currDir == Direction.UL)
                        item.CurrentDirection = Direction.LU;
                    else if (lastDir == Direction.LU && currDir == Direction.UL)
                        item.CurrentDirection = Direction.LU;
                    else if (lastDir == Direction.LD && currDir == Direction.UL)
                        item.CurrentDirection = Direction.LD;
                    ///Angle Down Right
                    else if (lastDir == Direction.RIGHT && currDir == Direction.DOWN)
                        item.CurrentDirection = Direction.DR;
                    else if (lastDir == Direction.DR && currDir == Direction.DOWN)
                        item.CurrentDirection = Direction.DR;
                    else if (lastDir == Direction.UP && currDir == Direction.DR)
                        item.CurrentDirection = Direction.RU;
                    else if (lastDir == Direction.DOWN && currDir == Direction.DR)
                        item.CurrentDirection = Direction.RD;
                    else if (lastDir == Direction.RU && currDir == Direction.DR)
                        item.CurrentDirection = Direction.RU;
                    else if (lastDir == Direction.RD && currDir == Direction.DR)
                        item.CurrentDirection = Direction.RD;
                    ///Angle Down Left
                    else if (lastDir == Direction.LEFT && currDir == Direction.DOWN)
                        item.CurrentDirection = Direction.DL;
                    else if (lastDir == Direction.DL && currDir == Direction.DOWN)
                        item.CurrentDirection = Direction.DL;
                    else if (lastDir == Direction.UP && currDir == Direction.DL)
                        item.CurrentDirection = Direction.LU;
                    else if (lastDir == Direction.DOWN && currDir == Direction.DL)
                        item.CurrentDirection = Direction.LD;
                    else if (lastDir == Direction.LU && currDir == Direction.DL)
                        item.CurrentDirection = Direction.LU;
                    else if (lastDir == Direction.LD && currDir == Direction.DL)
                        item.CurrentDirection = Direction.LD;
                    ///Angle Left down!!!!!!!!!!
                    else if (lastDir == Direction.DOWN && currDir == Direction.LEFT)
                        item.CurrentDirection = Direction.LD;
                    else if (lastDir == Direction.LD && currDir == Direction.LEFT)
                        item.CurrentDirection = Direction.LD;
                    else if (lastDir == Direction.RIGHT && currDir == Direction.LD)
                        item.CurrentDirection = Direction.DR;
                    else if (lastDir == Direction.LEFT && currDir == Direction.LD)
                        item.CurrentDirection = Direction.DL;
                    else if (lastDir == Direction.DL && currDir == Direction.LD)
                        item.CurrentDirection = Direction.DL;
                    else if (lastDir == Direction.DR && currDir == Direction.LD)
                        item.CurrentDirection = Direction.DR;
                    ///Angle Left UP
                    else if (lastDir == Direction.UP && currDir == Direction.LEFT)
                        item.CurrentDirection = Direction.LU;
                    else if (lastDir == Direction.LU && currDir == Direction.LEFT)
                        item.CurrentDirection = Direction.LU;
                    else if (lastDir == Direction.LEFT && currDir == Direction.LU)
                        item.CurrentDirection = Direction.UL;
                    else if (lastDir == Direction.RIGHT && currDir == Direction.LU)
                        item.CurrentDirection = Direction.UR;
                    else if (lastDir == Direction.UR && currDir == Direction.LU)
                        item.CurrentDirection = Direction.UR;
                    else if (lastDir == Direction.UL && currDir == Direction.LU)
                        item.CurrentDirection = Direction.UL;
                    ///Angle Right down
                    else if (lastDir == Direction.DOWN && currDir == Direction.RIGHT)
                        item.CurrentDirection = Direction.RD;
                    else if (lastDir == Direction.RD && currDir == Direction.RIGHT)
                        item.CurrentDirection = Direction.RD;
                    else if (lastDir == Direction.LEFT && currDir == Direction.RD)
                        item.CurrentDirection = Direction.DL;
                    else if (lastDir == Direction.RIGHT && currDir == Direction.RD)
                        item.CurrentDirection = Direction.DR;
                    else if (lastDir == Direction.DL && currDir == Direction.RD)
                        item.CurrentDirection = Direction.DL;
                    else if (lastDir == Direction.DR && currDir == Direction.RD)
                        item.CurrentDirection = Direction.DR;
                    /////Angle Right UP
                    else if (lastDir == Direction.UP && currDir == Direction.RIGHT)
                        item.CurrentDirection = Direction.RU;
                    else if (lastDir == Direction.RU && currDir == Direction.RIGHT)
                        item.CurrentDirection = Direction.RU;
                    else if (lastDir == Direction.LEFT && currDir == Direction.RU)
                        item.CurrentDirection = Direction.UL;
                    else if (lastDir == Direction.RIGHT && currDir == Direction.RU)
                        item.CurrentDirection = Direction.UR;
                    else if (lastDir == Direction.UL && currDir == Direction.RU)
                        item.CurrentDirection = Direction.UL;
                    else if (lastDir == Direction.UR && currDir == Direction.RU)
                        item.CurrentDirection = Direction.UR;
                    ///Simple
                    else if (lastDir == Direction.RIGHT)
                        item.CurrentDirection = Direction.RIGHT;
                    else if (lastDir == Direction.UP)
                        item.CurrentDirection = Direction.UP;
                    else if (lastDir == Direction.DOWN)
                        item.CurrentDirection = Direction.DOWN;
                    else if (lastDir == Direction.LEFT)
                        item.CurrentDirection = Direction.LEFT;


                    item.X = xlast;
                    item.Y = ylast;

                }
                else if (item is TailSnake)
                {
                    //Simple UP DOWN LEFT RIGH
                    if(lastDir == Direction.UP)
                        item.CurrentDirection = Direction.UP;
                    else if (lastDir == Direction.DOWN)
                        item.CurrentDirection = Direction.DOWN;
                    else if (lastDir == Direction.LEFT)
                        item.CurrentDirection = Direction.LEFT;
                    else if (lastDir == Direction.RIGHT)
                        item.CurrentDirection = Direction.RIGHT;
                    ///left
                    else if (lastDir == Direction.UL)
                        item.CurrentDirection = Direction.LEFT;
                    else if (lastDir == Direction.DL)
                        item.CurrentDirection = Direction.LEFT;
                    ////right
                    else if (lastDir == Direction.UR)
                        item.CurrentDirection = Direction.RIGHT;
                    else if (lastDir == Direction.DR)
                        item.CurrentDirection = Direction.RIGHT;
                    ////up
                    else if (lastDir == Direction.LU)
                        item.CurrentDirection = Direction.UP;
                    else if (lastDir == Direction.RU)
                        item.CurrentDirection = Direction.UP;
                    ///down
                    else if (lastDir == Direction.RD)
                        item.CurrentDirection = Direction.DOWN;
                    else if (lastDir == Direction.LD)
                        item.CurrentDirection = Direction.DOWN;

                    item.X = xlast;
                    item.Y = ylast;

                }

                xlast = x;
                ylast = y;
                lastDir = currDir;

            }


        }

        public void Grow()
        {
            Segment tail = _snake.ElementAt(_snake.Count - 1);
            
            _snake.Remove(tail);

            _snake.Add(
             new SegmentSnake(tail.X, tail.Y, Head.Radius, tail.CurrentDirection)
            );
            _snake.Add(tail);

        }

        public int eatAppleCount()
        {
            int count = -1;
            foreach (var item in _snake)
            {
                if(item is SegmentSnake)
                    count++;
            }

            return count;
        }
    }
}
