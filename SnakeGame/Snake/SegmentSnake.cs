﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Snake
{
    class SegmentSnake : Segment, ISegmentBehavior
    {

        public SegmentSnake(int x, int y, int radius, Direction direction) : base(x, y, radius, direction)
        {
            
        }

        public void Draw(Graphics graphics)
        {
            Bitmap bitmap;

            ///В зависимости от директа используем разные картинки
            if (CurrentDirection == Direction.HORIZONTAL
                || CurrentDirection == Direction.VERTICAL)
                bitmap = new Bitmap(GameResource.body);
            else if(CurrentDirection == Direction.LEFT
                    || CurrentDirection == Direction.RIGHT)
                bitmap = new Bitmap(GameResource.body);
            else if (CurrentDirection == Direction.UP
                    || CurrentDirection == Direction.DOWN)
                bitmap = new Bitmap(GameResource.body);
            else
                bitmap = new Bitmap(GameResource.snake_angle);

            bitmap.MakeTransparent();

            switch (CurrentDirection)
            {

                case Direction.RIGHT:
                case Direction.LEFT:
                case Direction.HORIZONTAL:
                    bitmap = ImageAction.Rotate(bitmap, 0);
                    break;
                case Direction.UP:
                case Direction.DOWN:
                case Direction.VERTICAL:
                    bitmap = ImageAction.Rotate(bitmap, 90);
                    break;

                case Direction.RD:
                case Direction.UL:
                    bitmap = ImageAction.Rotate(bitmap, 270);
                    break;
                case Direction.RU:
                case Direction.DL:
                    bitmap = ImageAction.Rotate(bitmap, 0);
                    break;
                case Direction.LU:
                case Direction.DR:
                    bitmap = ImageAction.Rotate(bitmap, 90);
                    break;
                case Direction.UR:
                case Direction.LD:
                    bitmap = ImageAction.Rotate(bitmap, 180);
                    break;
            }
            graphics.DrawImage(bitmap, new Rectangle(this.X - Radius, this.Y - Radius, this.Radius * 2, this.Radius * 2));

        }
    }
}
