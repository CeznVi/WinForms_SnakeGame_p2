﻿using SnakeGame.Game;
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
        private bool isGameStart = false;
        private bool isGamePaused = false;

        private GameField _gameField;
        private int keyPressedCount = 0;

        public MainForm()
        {
            InitializeComponent();
            //GameScene.Start();
            toolStripButton1.Visible = false;
            toolStripStatusLabel1.Text = "Для начала игры нажмите старт";

        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void timer_updSnake_Tick(object sender, EventArgs e)
        {
            keyPressedCount = 0;
            toolStripTextBoxAppleByNextLVL.Text = _gameField.appleCountHowMany.ToString();


            //if (_gameField.Snake.Head.isCanMove(_gameField.gameFieldControl.Width, _gameField.gameFieldControl.Height))
            //{
                if (_gameField.Snake.isEatingHimSelf() == false && _gameField.Snake.isEatingIron(_gameField.Irons) == false)
                {
                    toolStripTextBoxAppleCount.Text = _gameField.GetAppleCountEating().ToString();
                    toolStripTextBoxLVL.Text = _gameField.Lvl.ToString();
                    _gameField.Update();
                }
                else
                {

                    timer_updSnake.Stop();
                    isGameStart = false;
                    toolStripButton_StartStop.Text = "Старт";
                    toolStripStatusLabel1.Text = "Для начала игры нажмите старт";
                    panelMainWindow.Controls.Clear();
                    toolStripButton1.Visible = false;
                    toolStripButton_StartStop.BackColor = Color.White;

                    MessageBox.Show("Game over", "Уведомление");
                }
            //}

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyPressedCount == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                    case Keys.A:
                        {

                            if (_gameField.Snake.Head.CurrentDirection != Direction.RIGHT)
                            {
                                _gameField.Snake.Head.CurrentDirection = _gameField.Snake.Head.CurrentDirection = Snake.Direction.LEFT;
                                keyPressedCount++;
                            }
                            break;
                        }
                    case Keys.Right:
                    case Keys.D:
                        {
                            if (_gameField.Snake.Head.CurrentDirection != Direction.LEFT)
                            {
                                _gameField.Snake.Head.CurrentDirection = Snake.Direction.RIGHT;
                                keyPressedCount++;
                            }
                            break;
                        }
                    case Keys.W:
                    case Keys.Up:
                        {
                            if (_gameField.Snake.Head.CurrentDirection != Direction.DOWN)
                            {
                                _gameField.Snake.Head.CurrentDirection = Snake.Direction.UP;
                                keyPressedCount++;
                            }
                            break;
                        }
                    case Keys.S:
                    case Keys.Down:
                        {
                            if (_gameField.Snake.Head.CurrentDirection != Direction.UP)
                            {
                                _gameField.Snake.Head.CurrentDirection = Snake.Direction.DOWN;
                                keyPressedCount++;
                            }
                            break;
                        }
                }
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton_StartStop_Click(object sender, EventArgs e)
        {
            toolStripTextBoxAppleCount.Text = "0";
            toolStripTextBoxLVL.Text = "0";
            toolStripTextBoxAppleByNextLVL.Text = "-=-";

            if (isGameStart == false)
            {
                isGameStart = true;
                toolStripButton_StartStop.Text = "Стоп";
                toolStripStatusLabel1.Text = "Идет игра";
                toolStripButton_StartStop.Checked = false;
                toolStripButton1.Visible = true;

                _gameField = new GameField(timer_updApple, timer_updSnake);
                panelMainWindow.Controls.Add(_gameField.gameFieldControl);
                timer_updSnake.Enabled = true;
                timer_updSnake.Interval = _gameField.GameTickTime;

                timer_updApple.Enabled = true;
                toolStripButton_StartStop.BackColor = Color.Red;
                
            }
            else
            {
                isGameStart = false;
                toolStripButton_StartStop.Text = "Сарт";
                toolStripStatusLabel1.Text = "Для начала игры нажмите старт";
                panelMainWindow.Controls.Clear();
                toolStripButton1.Visible = false;
                isGamePaused = false;
                toolStripButton1.Text = "Пауза";
                toolStripButton1.ToolTipText = "Нажмите чтобы поставить игру на паузу";
                toolStripButton_StartStop.BackColor = Color.White;
                toolStripButton1.BackColor = Color.White;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (isGameStart == true)
            {
                if (isGamePaused == false)
                {
                    isGamePaused = true;
                    toolStripButton1.Text = "Продолжить";
                    toolStripStatusLabel1.Text = "Игра на паузе";
                    timer_updSnake.Enabled = false;
                    timer_updApple.Enabled = false;
                    toolStripButton1.ToolTipText = "Нажмите чтобы продолжить игру";
                    toolStripButton1.BackColor = Color.LightGreen;
                }
                else
                {
                    isGamePaused = false;
                    toolStripButton1.Text = "Пауза";
                    toolStripStatusLabel1.Text = "Идет игра";
                    timer_updSnake.Enabled = true;
                    timer_updApple.Enabled = true;
                    toolStripButton1.ToolTipText = "Нажмите чтобы поставить игру на паузу";
                    toolStripButton1.BackColor = Color.White;
                }
            }
        }

        private void timer_updApple_Tick(object sender, EventArgs e)
        {
            if (isGameStart == true)
            {
                _gameField.Food.Respawn(_gameField.gameFieldControl.Width,
                             _gameField.gameFieldControl.Height,
                             _gameField.Snake,
                             _gameField.Irons);
                
            }
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (isGameStart == false)
            {
                isGameStart = true;
                toolStripButton_StartStop.Text = "Стоп";
                toolStripStatusLabel1.Text = "Идет игра";
                toolStripButton_StartStop.Checked = false;
                toolStripButton1.Visible = true;

                _gameField = new GameField(timer_updApple, timer_updSnake);
                panelMainWindow.Controls.Add(_gameField.gameFieldControl);
                timer_updSnake.Enabled = true;
                timer_updSnake.Interval = _gameField.GameTickTime;

                timer_updApple.Enabled = true;
                toolStripButton_StartStop.BackColor = Color.Red;
            }
            else
            {
                toolStripButton_StartStop_Click(sender, e);
            }
        }
    }
}
