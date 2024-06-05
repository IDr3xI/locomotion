using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Locomotion : Form
    {
        List<Image> levelImages = new List<Image> {Properties.Resources.London1, Properties.Resources.London2, Properties.Resources.Paris1, Properties.Resources.Paris2, Properties.Resources.Brussels1, Properties.Resources.Brussels2, Properties.Resources.Bonn1, Properties.Resources.Bonn2, Properties.Resources.Vienna1, Properties.Resources.Vienna2, Properties.Resources.Bern1, Properties.Resources.Bern2, Properties.Resources.Roma1, Properties.Resources.Roma2, Properties.Resources.Madrid1, Properties.Resources.Madrid2};
        List<Image> railImages = new List<Image> {Properties.Resources.turn1_black, Properties.Resources.turn2_black, Properties.Resources.turn3_black, Properties.Resources.turn4_black, Properties.Resources.horizontal_black, Properties.Resources.vertical_black, Properties.Resources.junction_black};
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        Image menu1 = Properties.Resources.menu1;
        Image menu2 = Properties.Resources.menu2;
        SoundPlayer trainSound = new SoundPlayer(Properties.Resources.train_sound);
        PictureBox emptyTile = null;
        PictureBox adjacentTile = null;
        PictureBox currentTile = null;
        PictureBox nextTile = null;
        PictureBox locomotive = null;
        Image train = Properties.Resources.locomotive;
        int stopwatchTime = 0;
        int wreckTime = 0;
        int trainDirectionX = -1;
        int trainDirectionY = 0;
        int[,] rails = {{5,5,5,5,5,5,1,6,4,5,5,5,5,1,6,6,3,5,5,5,5,2,6,3,5,5,5,5,5,5,2,4,5,5,1,4,5,5,1,6,7,7,6,6,7,7,6,3,5,5,2,3,5,5,2},
                        {1,2,4,7,7,4,6,6,6,1,3,1,6,6,6,6,4,6,6,6,2,5,2,1,5,5,2,6,6,3,2,2,1,5,1,5,5,6,2,6,3,1,6,1,4,4,7,6,4,2,2,4,7,2,5},
                        {6,4,3,5,4,7,4,6,2,2,6,6,5,2,6,5,5,1,1,2,7,1,6,1,7,2,4,1,6,4,5,6,5,5,5,1,2,1,2,1,2,1,7,3,4,3,5,3,3,2,1,6,7,5,7}};
        //turn1 - 1//turn2 - 2//turn3 - 3//turn4 - 4// horizontal - 5//vertical - 6// junction - 7
        Point empty = new Point(50, 0);
        Point currentLocation, originalLocation, targetLocation;
        int level = 1;
        public Locomotion()
        {
            InitializeComponent();
            StopwatchTimer.Stop();
            TrainWreckTimer.Stop();
            StopwatchTimer.Tag = "off";
            InitializeGame();
            TileMoveTimer.Stop();
            currentTile = pictureBox32;
            nextTile = pictureBox4;
            MainMenu();
        }
        private void MainMenu()
        {
            pbMenu.Visible = true;
            pbMenu.BringToFront();
            TrainMoveTimer.Stop();
        }
        private void InitializeGame()
        {
            InitializeTiles();
            InitializeTrain();
        }
        private void LevelNameTimer_Tick(object sender, EventArgs e)
        {
            if(pbLevel.Image == levelImages[(level * 2) - 2])
            {
                pbLevel.Image = levelImages[(level * 2) - 1];
            }
            else
            {
                pbLevel.Image = levelImages[(level * 2) - 2];
            }
            if (pbMenu.BackgroundImage == menu1)
            {
                pbMenu.BackgroundImage = menu2;
            }
            else
            {
                pbMenu.BackgroundImage = menu1;
            }
        }
        private void InitializeTiles()
        {
            for (int i = 0; i < 56; i++)
            {
                if(i == 0)
                {
                    PictureBox pb = new PictureBox
                    {
                        Size = new Size(48, 48),
                        Margin = new Padding(1),
                        Location = new Point(50 * (i % 8) + 50, 50 * (i / 8)),
                        Tag = "emptyTile",
                    };
                    pictureBoxes.Add(pb);
                }
                else
                {
                    PictureBox pb = new PictureBox
                    {
                        Size = new Size(48, 48),
                        Margin = new Padding(1),
                        BackColor = Color.LimeGreen,
                        Location = new Point(50 * (i % 8) + 50, 50 * (i / 8)),
                    };
                    pictureBoxes.Add(pb);
                    switch(rails[level-1,i-1])
                    {
                        case 1:
                            pictureBoxes[i].BackgroundImage = railImages[0];
                            this.pictureBoxes[i].Tag = "1";
                            break;
                        case 2:
                            pictureBoxes[i].BackgroundImage = railImages[1];
                            this.pictureBoxes[i].Tag = "2";
                            break;
                        case 3:
                            pictureBoxes[i].BackgroundImage = railImages[2];
                            this.pictureBoxes[i].Tag = "3";
                            break;
                        case 4:
                            pictureBoxes[i].BackgroundImage = railImages[3];
                            this.pictureBoxes[i].Tag = "4";
                            break;
                        case 5:
                            pictureBoxes[i].BackgroundImage = railImages[4];
                            this.pictureBoxes[i].Tag = "5";
                            break;
                        case 6:
                            pictureBoxes[i].BackgroundImage = railImages[5];
                            this.pictureBoxes[i].Tag = "6";
                            break;
                        case 7:
                            pictureBoxes[i].BackgroundImage = railImages[6];
                            this.pictureBoxes[i].Tag = "7";
                            break;
                    }
                }
                this.Controls.Add(pictureBoxes[i]);
            }
            TrainMoveTimer.Start();
        }
        private void InitializeTrain()
        {
            trainDirectionX = -1;
            trainDirectionY = 0;
            currentTile = pictureBox32;
            nextTile = pictureBox4;
            locomotive = new PictureBox()
            {
                Size = new Size(34, 34),
                Image = RotateImage(Properties.Resources.locomotive, -90),
                BackColor = Color.Transparent,
                Location = new Point(308, 358),
                Tag = "locomotive",
            };
            this.Controls.Add(locomotive);
            locomotive.BringToFront();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (pbMenu.Visible == false)
            {
                Point adjacent = empty;
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        adjacent.Y += 50;
                        break;
                    case Keys.Down:
                        adjacent.Y -= 50;
                        break;
                    case Keys.Left:
                        adjacent.X += 50;
                        break;
                    case Keys.Right:
                        adjacent.X -= 50;
                        break;
                }
                if (adjacent.X >= 50 && adjacent.X <= 400 && adjacent.Y >= 0 && adjacent.Y <= 300)
                {
                    MoveTile(adjacent);
                }
            }
        }
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
        private void TrainMoveTimer_Tick(object sender, EventArgs e)
        {
            int step = 2;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (x.Location == new Point(currentTile.Location.X + trainDirectionX * 50, currentTile.Location.Y + trainDirectionY * 50)))
                {
                    nextTile = (PictureBox)x;
                }
            }
            CheckCollision();
            if(locomotive.BackColor == Color.Red)
            {
                return;
            }
            if(nextTile.BackColor == Color.LimeGreen)
            {
                nextTile.BackColor = Color.Gold;
            }
            LevelWon();
            if (locomotive.Location.X-8 != nextTile.Location.X || locomotive.Location.Y-8 != nextTile.Location.Y)
            {
                locomotive.Location = new Point(
                    locomotive.Location.X + (trainDirectionX) * step,
                    locomotive.Location.Y + (trainDirectionY) * step);
            }
            else
            {
                currentTile = nextTile;
                switch ((string)currentTile.Tag)
                {
                    case "1":
                        if(trainDirectionX == 1)
                        {
                            trainDirectionX = 0;
                            trainDirectionY = 1;
                            locomotive.Image = RotateImage(train, 180);
                        }
                        else
                        {
                            trainDirectionX = -1;
                            trainDirectionY = 0;
                            locomotive.Image = RotateImage(train, -90);
                        }
                        break;
                    case "2":
                        if(trainDirectionX == 1)
                        {
                            trainDirectionX = 0;
                            trainDirectionY = -1;
                            locomotive.Image = RotateImage(train, 0);
                        }
                        else
                        {
                            trainDirectionX = -1;
                            trainDirectionY = 0;
                            locomotive.Image = RotateImage(train, -90);
                        }
                        break;
                    case "3":
                        if(trainDirectionY == 1)
                        {
                            trainDirectionX = 1;
                            trainDirectionY = 0;
                            locomotive.Image = RotateImage(train, 90);

                        }
                        else
                        {
                            trainDirectionX = 0;
                            trainDirectionY = -1;
                            locomotive.Image = RotateImage(train, 0);
                        }
                        break;
                    case "4":
                        if(trainDirectionX == -1)
                        {
                            trainDirectionX = 0;
                            trainDirectionY = 1;
                            locomotive.Image = RotateImage(train, 180);
                        }
                        else
                        {
                            trainDirectionX = 1;
                            trainDirectionY = 0;
                            locomotive.Image = RotateImage(train, 90);
                        }
                        break;
                    case "5":
                        if(trainDirectionX == 1)
                        {
                            locomotive.Image = RotateImage(train, 90);
                        }
                        else if(trainDirectionX == -1)
                        {
                            locomotive.Image = RotateImage(train, -90);
                        }
                        else if (trainDirectionY == 1)
                        {
                            locomotive.Image = RotateImage(train, 180);
                        }
                        else if (trainDirectionY == -1)
                        {
                            locomotive.Image = RotateImage(train, 0);
                        }
                        break;
                    case "6":
                        if (trainDirectionX == 1)
                        {
                            locomotive.Image = RotateImage(train, 90);
                        }
                        else if (trainDirectionX == -1)
                        {
                            locomotive.Image = RotateImage(train, -90);
                        }
                        else if (trainDirectionY == 1)
                        {
                            locomotive.Image = RotateImage(train, 180);
                        }
                        else if (trainDirectionY == -1)
                        {
                            locomotive.Image = RotateImage(train, 0);
                        }
                        break;
                    case "7":
                        if (trainDirectionX == 1)
                        {
                            locomotive.Image = RotateImage(train, 90);
                        }
                        else if (trainDirectionX == -1)
                        {
                            locomotive.Image = RotateImage(train, -90);
                        }
                        else if (trainDirectionY == 1)
                        {
                            locomotive.Image = RotateImage(train, 180);
                        }
                        else if (trainDirectionY == -1)
                        {
                            locomotive.Image = RotateImage(train, 0);
                        }
                        break;
                }
            }
        }
        private void UpdateStopwatch()
        {
            if (stopwatchTime == 0)
            {
                pbStopwatch.Image = Properties.Resources.clock1;
            }
            if (stopwatchTime > 7 && stopwatchTime <= 15)
            {
                pbStopwatch.Image = Properties.Resources.clock2;
            }
            if (stopwatchTime > 15 && stopwatchTime <= 22)
            {
                pbStopwatch.Image = Properties.Resources.clock3;
            }
            if (stopwatchTime > 22 && stopwatchTime <= 30)
            {
                pbStopwatch.Image = Properties.Resources.clock4;
            }
            if (stopwatchTime > 30 && stopwatchTime <= 37)
            {
                pbStopwatch.Image = Properties.Resources.clock5;
            }
            if (stopwatchTime > 37 && stopwatchTime <= 45)
            {
                pbStopwatch.Image = Properties.Resources.clock6;
            }
            if (stopwatchTime > 45 && stopwatchTime <= 52)
            {
                pbStopwatch.Image = Properties.Resources.clock7;
            }
            if (stopwatchTime > 52 && stopwatchTime < 60)
            {
                pbStopwatch.Image = Properties.Resources.clock8;
            }
            if (stopwatchTime == 60)
            {
                pbStopwatch.Image = Properties.Resources.clock1;
            }
            if (stopwatchTime >= 60)
            {
                TrainMoveTimer.Start();
            }
        }
        private void CheckCollision()
        {
            if (nextTile.Tag == "emptyTile")
            {
                currentTile.Image = Properties.Resources.wreck;
                locomotive.Visible = false;
                TrainMoveTimer.Stop();
                TrainWreckTimer.Start();
            }
            if(nextTile.Tag == "start" && trainDirectionX != -1)
            {
                currentTile.Image = Properties.Resources.wreck;
                locomotive.Visible = false;
                TrainMoveTimer.Stop();
                TrainWreckTimer.Start();
            }
            if(nextTile.Tag == null)
            {
                currentTile.Image = Properties.Resources.wreck;
                locomotive.Visible = false;
                TrainMoveTimer.Stop();
                TrainWreckTimer.Start();
            }
            if (trainDirectionX == 1 && (nextTile.Tag == "3" || nextTile.Tag == "4" || nextTile.Tag == "6"))
            {
                currentTile.Image = Properties.Resources.wreck;
                locomotive.Visible = false;
                TrainMoveTimer.Stop();
                TrainWreckTimer.Start();
            }
            if (trainDirectionX == -1 && (nextTile.Tag == "1" || nextTile.Tag == "2" || nextTile.Tag == "6"))
            {
                currentTile.Image = Properties.Resources.wreck;
                locomotive.Visible = false;
                TrainMoveTimer.Stop();
                TrainWreckTimer.Start();
            }
            if (trainDirectionY == 1 && (nextTile.Tag == "1" || nextTile.Tag == "4" || nextTile.Tag == "5"))
            {
                currentTile.Image = Properties.Resources.wreck;
                locomotive.Visible = false;
                TrainMoveTimer.Stop();
                TrainWreckTimer.Start();
            }
            if (trainDirectionY == -1 && (nextTile.Tag == "2" || nextTile.Tag == "3" || nextTile.Tag == "5"))
            {
                currentTile.Image = Properties.Resources.wreck;
                locomotive.Visible = false;
                TrainMoveTimer.Stop();
                TrainWreckTimer.Start();
            }
        }
        private void LifeDown()
        {
            if(pbLife1.Image != null)
            {
                pbLife1.Image = null;
                locomotive.Visible = false;
                InitializeTrain();
                TrainMoveTimer.Start();
            }
            else if (pbLife2.Image != null)
            {
                pbLife2.Image = null;
                locomotive.Visible = false;
                InitializeTrain();
                TrainMoveTimer.Start();
            }
            else
            {
                GameOver();
            }
        }
        private void MoveTile(Point adjacent)
        {
            originalLocation = adjacent;
            currentLocation = adjacent;
            targetLocation = empty;
            TileMoveTimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Location == targetLocation)
                {
                    emptyTile = (PictureBox)x;
                }
                if (x is PictureBox && x.Location == originalLocation)
                {
                    adjacentTile = (PictureBox)x;
                }
            }
            emptyTile.Visible = false;
        }
        private void TileMoveTimer_Tick(object sender, EventArgs e)
        {
            int step = 5;

            if(currentLocation != targetLocation)
            {
                currentLocation.X += (targetLocation.X - originalLocation.X) / step;
                currentLocation.Y += (targetLocation.Y - originalLocation.Y) / step;
                adjacentTile.Location = currentLocation;
            }
            else
            {
                adjacentTile.Location = targetLocation;
                emptyTile.Location = originalLocation;
                emptyTile.Visible = true;

                empty = originalLocation;
                TileMoveTimer.Stop();
            }
        }
        private void Stopwatch()
        {
            if(StopwatchTimer.Tag == "off" && stopwatchTime < 60)
            {
                StopwatchTimer.Start();
                StopwatchTimer.Tag = "on";
                TrainMoveTimer.Stop();
            }
            else
            {
                StopwatchTimer.Stop();
                StopwatchTimer.Tag = "off";
                TrainMoveTimer.Start();
            }
        }
        private void GameOver()
        {
            Controls.Clear();
            foreach (Control x in this.Controls)
            {
                if (pictureBoxes.Contains(x))
                {
                    x.Visible = false;
                }
            }
            locomotive.Visible = false;
            Label label = new Label();
            label.Text = "GAME OVER";
            label.Location = new Point(250, 250);
            label.Size = new Size(50, 50);
        }
        private void ResetGame()
        {
            foreach(Control x in this.Controls)
            {
                if (pictureBoxes.Contains(x))
                {
                    x.Visible = false;
                }
            }
            locomotive.Visible = false;
            trainDirectionX = -1;
            trainDirectionY = 0;
            pictureBoxes.Clear();
            stopwatchTime = 0;
            StopwatchTimer.Start();
            StopwatchTimer.Stop();
            empty = new Point(50, 0);
            InitializeTiles();
            InitializeTrain();
        }
        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            stopwatchTime += 1;
        }
        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
            pbMenu.Visible = false;
            if(e.KeyChar == ' ')
            {
                Stopwatch();
            }
        }

        private void MainGameTimer_Tick(object sender, EventArgs e)
        {
            UpdateStopwatch();
            if(wreckTime == 3)
            {
                currentTile.Image = null;
                LifeDown();
                ResetGame();
                wreckTime = 0;
                TrainWreckTimer.Stop();
            }
            if(pbMenu.Visible == false && nextTile== pictureBox4)
            {
                TrainMoveTimer.Start();
                stopwatchTime = 0;
                StopwatchTimer.Stop();
                StopwatchTimer.Tag = "off";
            }
            if(locomotive.Location.X >= 50 && locomotive.Location.X <= 450 && locomotive.Location.Y >= 0 && locomotive.Location.Y <= 350)
            {
                train = Properties.Resources.locomotive_black;
            }
            else
            {
                train = Properties.Resources.locomotive;
            }
        }

        private void TrainWreckTimer_Tick(object sender, EventArgs e)
        {
            wreckTime += 1;
        }

        private void LevelWon()
        {
            if(nextTile.Tag == "start")
            {
                level++;
                ResetGame();
            }
        }
        private void GameWon()
        {

        }
    }
}