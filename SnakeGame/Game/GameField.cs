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
        public int GameTickTime = 600;


        private PictureBox _gameFieldControl;
        
        public Food Food { get; set; }

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

        public GameField()
        {
            _gameFieldControl = new PictureBox();
            _gameFieldControl.BackColor = Color.LightGray;
            _gameFieldControl.Dock = DockStyle.Fill;
            _gameFieldControl.Paint += _gameFieldControl_Paint;

            _snake = new Snake.Snake();

            Food = new Food(Snake.Head.Radius);

        }

        private void _gameFieldControl_Paint(object sender, PaintEventArgs e)
        {
            _snake.Draw(e.Graphics);
            Food.Draw(e.Graphics);

        }

        public void Update() 
        {
            _snake.Move();

            if(Snake.Head.IsCanEath(Food)) 
            {
                Snake.Grow();
                Food.Respawn(
                             gameFieldControl.Width,
                             gameFieldControl.Height,
                             Snake);
            }



            

            _gameFieldControl.Refresh();
           
        }

    }
}
