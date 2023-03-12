﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Snake
{
    abstract class Segment
    {
        private int _x;
        private int _y;
        private Direction _direction;

        public Color Color;
        private int _radius;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Segment() 
        { 
            Radius = 15;
            X = 15;
            Y = 15;
            CurrentDirection = Direction.UP;
        }



        public Direction CurrentDirection
        {
            get 
            { 
                return _direction; 
            }

            set
            {

                if (DirectionOperation.Check(value))
                  //_direction = ((int)_direction % 2 == (int)value % 2) ? _direction : value;

                _direction = value;

            }
        }

        public Segment(int x, int y, int radius, Direction dir)
        {
            X = x;
            Y = y;
            Radius = radius;
            CurrentDirection = dir;
        }

        protected Segment(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override string ToString() 
        {
            return $"X: {X}; Y: {Y}; Radius: {Radius}.";
        }

    }
}
