using SnakeGame.Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class MainForm : Form
    {
        private GameField _gameField;
        

        public MainForm()
        {
            InitializeComponent();
            _gameField = new GameField();
            panelMainWindow.Controls.Add(_gameField.gameFieldControl);
            timer_updSnake.Enabled = true;
            timer_updSnake.Interval = _gameField.GameTickTime;
        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void timer_updSnake_Tick(object sender, EventArgs e)
        {
            if(_gameField.Snake.Head.isCanMove(_gameField.gameFieldControl.Width, _gameField.gameFieldControl.Height))
                _gameField.Update();
            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode) 
            {   

                case Keys.Left:
                case Keys.A:
                    {
                        if(_gameField.Snake.Head.CurrentDirection != Direction.RIGHT)
                           _gameField.Snake.Head.CurrentDirection = _gameField.Snake.Head.CurrentDirection = Snake.Direction.LEFT;
                        break;
                    }
                case Keys.Right:
                case Keys.D:
                    {
                        if (_gameField.Snake.Head.CurrentDirection != Direction.LEFT)
                            _gameField.Snake.Head.CurrentDirection = Snake.Direction.RIGHT;
                        break;
                    }
                case Keys.W:
                case Keys.Up:
                    {
                        if (_gameField.Snake.Head.CurrentDirection != Direction.DOWN)
                            _gameField.Snake.Head.CurrentDirection = Snake.Direction.UP;
                        break;
                    }
                case Keys.S:
                case Keys.Down:
                    {
                        if (_gameField.Snake.Head.CurrentDirection != Direction.UP)
                            _gameField.Snake.Head.CurrentDirection = Snake.Direction.DOWN;
                         break;
                    }
            }



        }
    }
}
