using SnakeGame.Snake;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class GameField
    {
        private Timer _timerUpdApple;
        private Timer _timerUpdSnake;

        
        public int GameTickTime = 600;
        private int appleCountEating = 0;

        private PictureBox _gameFieldControl;
        
        public Food Food { get; set; }
        public Irons Irons { get; set; }
        public int Lvl { get; set; }

        public int appleCountHowMany = 4;


        private Snake.Snake _snake;

        public Snake.Snake Snake
        {
            get 
            { 
                return _snake; 
            }

        }

        public PictureBox gameFieldControl
        {
            get { return _gameFieldControl; }
        }

        public GameField(Timer t, Timer timerUpdSnake)
        {
            _gameFieldControl = new PictureBox();
            _gameFieldControl.BackColor = Color.LightGray;
            _gameFieldControl.Dock = DockStyle.Fill;
            _gameFieldControl.Paint += _gameFieldControl_Paint;

            _timerUpdApple = t;

            _snake = new Snake.Snake();

            Food = new Food(Snake.Head.Radius);

            Irons = new Irons();

            _timerUpdSnake = timerUpdSnake;
        }

        private void _gameFieldControl_Paint(object sender, PaintEventArgs e)
        {
            _snake.Draw(e.Graphics);
            Food.Draw(e.Graphics);
            Irons.Draw(e.Graphics);
        }

        public int GetAppleCountEating()
        {
            return appleCountEating;
        }

        public void Update() 
        {
            _snake.Move();
            appleCountEating = _snake.eatAppleCount();

            if (Snake.Head.IsCanEath(Food))
            {
                Snake.Grow();
                Food.Respawn(
                             gameFieldControl.Width,
                             gameFieldControl.Height,
                             Snake,
                             Irons);
                
                _timerUpdApple.Stop();
                _timerUpdApple.Start();
                appleCountHowMany--;


                if (appleCountEating % 3 == 0 && appleCountEating > 0)
                {
                    Lvl++;

                    Irons.AddIron(gameFieldControl.Width,
                             gameFieldControl.Height,
                             Snake,
                             Food);

                    if (GameTickTime >= 30)
                    {
                        GameTickTime -= 25;
                        _timerUpdSnake.Interval = GameTickTime;
                    }
                }

                if (appleCountHowMany == 0)
                    appleCountHowMany = 4;
            }


            _gameFieldControl.Refresh();
           
        }

    }
}
