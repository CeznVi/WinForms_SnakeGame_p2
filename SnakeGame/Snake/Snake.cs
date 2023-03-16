﻿using System;
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

            _snake.Add(new HeadSnake(60,60,15,Direction.UP));
            _snake.Add(new SegmentSnake(60, 90, Head.Radius, Direction.UP));
            //_snake.Add(new SegmentSnake(30, 560, 15, Direction.UP));
            //_snake.Add(new SegmentSnake(60, 560, 15, Direction.UP));
            _snake.Add(new TailSnake(60, 120, Head.Radius, Direction.UP));
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


                    //if (item.Y <= 0)
                    //    item.Y = 585;
                    //else if (item.Y >= 585)
                    //    item.Y = 0;

                    //else if (item.X >= 953)
                    //    item.X = 0;
                    //else if (item.X <= 0)
                    //    item.X = 953;

                }
                else if(item is SegmentSnake)
                {
                    item.CurrentDirection = lastDir;

                    item.X = xlast;
                    item.Y = ylast;

                }
                else if (item is TailSnake)
                {
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

 
    }
}
