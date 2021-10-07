using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AsteroidsShooter
{
    public partial class GameScreen : UserControl
    {
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, spaceDown;
      
        List<Asteroids> asteroids = new List<Asteroids>();

        int newAsteroidsCounter = 0;

        Random randGen = new Random();
      
        Asteroids hero;

        SoundPlayer appearSound = new SoundPlayer(Properties.Resources.meteor_whoosh);
        SoundPlayer boomSound = new SoundPlayer(Properties.Resources.explosion_hit2);
        SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.sad_game_over);

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush brownBrush = new SolidBrush(Color.Brown);

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            appearSound.Play();
            CreateAsteroids();

            hero = new Asteroids(this.Width / 2 - 100, this.Height - 100, 25, 15, redBrush);
        }

        public void CreateAsteroids()
        {
            int randomLocationX = randGen.Next(0, this.Width);
            int randomLocationY = randGen.Next(0, this.Height);
            Asteroids a = new Asteroids(randomLocationX, randomLocationY, 40, 0, brownBrush);
            asteroids.Add(a);
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            newAsteroidsCounter++;
          //  asteroidBigger++;

            //move hero
            if (leftArrowDown)
            {
                hero.Move("left");
            }
            if (rightArrowDown)
            {
                hero.Move("right");
            }
            if (upArrowDown)
            {
                hero.Move("up");
            }
            if (downArrowDown)
            {
                hero.Move("down");
            }
            foreach (Asteroids a in asteroids)
            {
                if (hero.Collision(a) && spaceDown)
                {
                    
                    Form1.score++;
                    scoreLabel.Text = $"Score: {Form1.score}";
                    asteroids.Remove(a);
                    boomSound.Play();
                    break;
                    
                }
            }
           
            if (newAsteroidsCounter == 90)
            {
                appearSound.Play();
                CreateAsteroids();
                newAsteroidsCounter = 0;
            }

            foreach (Asteroids a in asteroids)
            {
                a.size += 2;
                a.x -= 1;
                a.y -= 1;
                if (a.size == 250)
                {
                    gameOverSound.Play();
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameOverScreen gos = new GameOverScreen();
                    f.Controls.Add(gos);
                    gos.Focus();
                    gameTimer.Enabled = false;
                }
            }

            Refresh();

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Asteroids a in asteroids)
            {
                e.Graphics.FillRectangle(brownBrush, a.x, a.y, a.size, a.size);
            }
            e.Graphics.FillRectangle(redBrush, hero.x, hero.y, hero.size, hero.size);
           
        }
    }
}
