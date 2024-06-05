namespace Test
{
    partial class Locomotion
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locomotion));
            this.LevelNameTimer = new System.Windows.Forms.Timer(this.components);
            this.TrainMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.TileMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.StopwatchTimer = new System.Windows.Forms.Timer(this.components);
            this.MainGameTimer = new System.Windows.Forms.Timer(this.components);
            this.TrainWreckTimer = new System.Windows.Forms.Timer(this.components);
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pbLevel = new System.Windows.Forms.PictureBox();
            this.pbLife1 = new System.Windows.Forms.PictureBox();
            this.pbLife2 = new System.Windows.Forms.PictureBox();
            this.pbLife3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbStopwatch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStopwatch)).BeginInit();
            this.SuspendLayout();
            // 
            // LevelNameTimer
            // 
            this.LevelNameTimer.Enabled = true;
            this.LevelNameTimer.Interval = 500;
            this.LevelNameTimer.Tick += new System.EventHandler(this.LevelNameTimer_Tick);
            // 
            // TrainMoveTimer
            // 
            this.TrainMoveTimer.Enabled = true;
            this.TrainMoveTimer.Interval = 20;
            this.TrainMoveTimer.Tick += new System.EventHandler(this.TrainMoveTimer_Tick);
            // 
            // TileMoveTimer
            // 
            this.TileMoveTimer.Enabled = true;
            this.TileMoveTimer.Interval = 20;
            this.TileMoveTimer.Tick += new System.EventHandler(this.TileMoveTimer_Tick);
            // 
            // StopwatchTimer
            // 
            this.StopwatchTimer.Enabled = true;
            this.StopwatchTimer.Interval = 1000;
            this.StopwatchTimer.Tick += new System.EventHandler(this.StopwatchTimer_Tick);
            // 
            // MainGameTimer
            // 
            this.MainGameTimer.Enabled = true;
            this.MainGameTimer.Interval = 20;
            this.MainGameTimer.Tick += new System.EventHandler(this.MainGameTimer_Tick);
            // 
            // TrainWreckTimer
            // 
            this.TrainWreckTimer.Enabled = true;
            this.TrainWreckTimer.Interval = 1000;
            this.TrainWreckTimer.Tick += new System.EventHandler(this.TrainWreckTimer_Tick);
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbMenu.Location = new System.Drawing.Point(0, 0);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(550, 400);
            this.pbMenu.TabIndex = 37;
            this.pbMenu.TabStop = false;
            this.pbMenu.Visible = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox32.BackgroundImage = global::Test.Properties.Resources.station1;
            this.pictureBox32.Location = new System.Drawing.Point(300, 350);
            this.pictureBox32.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(50, 50);
            this.pictureBox32.TabIndex = 36;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Tag = "start";
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox31.BackgroundImage = global::Test.Properties.Resources.station2;
            this.pictureBox31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox31.Location = new System.Drawing.Point(350, 350);
            this.pictureBox31.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(50, 50);
            this.pictureBox31.TabIndex = 35;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Tag = "end";
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox30.BackgroundImage = global::Test.Properties.Resources.horizontal;
            this.pictureBox30.Location = new System.Drawing.Point(400, 350);
            this.pictureBox30.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(50, 50);
            this.pictureBox30.TabIndex = 34;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.Tag = "5";
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox29.BackgroundImage = global::Test.Properties.Resources.turn2;
            this.pictureBox29.Location = new System.Drawing.Point(450, 350);
            this.pictureBox29.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(50, 50);
            this.pictureBox29.TabIndex = 33;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.Tag = "2";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.BackgroundImage = global::Test.Properties.Resources.turn1;
            this.pictureBox25.Location = new System.Drawing.Point(450, 300);
            this.pictureBox25.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(50, 50);
            this.pictureBox25.TabIndex = 29;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "1";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BackgroundImage = global::Test.Properties.Resources.turn4;
            this.pictureBox18.Location = new System.Drawing.Point(0, 0);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(50, 50);
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "4";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.BackgroundImage = global::Test.Properties.Resources.vertical;
            this.pictureBox17.Location = new System.Drawing.Point(0, 50);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(50, 50);
            this.pictureBox17.TabIndex = 16;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "6";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox16.BackgroundImage")));
            this.pictureBox16.Location = new System.Drawing.Point(0, 100);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(50, 50);
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "6";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox15.BackgroundImage")));
            this.pictureBox15.Location = new System.Drawing.Point(0, 150);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(50, 50);
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "6";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox14.BackgroundImage")));
            this.pictureBox14.Location = new System.Drawing.Point(0, 200);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(50, 50);
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "6";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.Location = new System.Drawing.Point(0, 250);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(50, 50);
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "6";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.Location = new System.Drawing.Point(0, 300);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "6";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::Test.Properties.Resources.turn3;
            this.pictureBox11.Location = new System.Drawing.Point(0, 350);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 50);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "3";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::Test.Properties.Resources.horizontal;
            this.pictureBox10.Location = new System.Drawing.Point(50, 350);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "5";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.Location = new System.Drawing.Point(100, 350);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "5";
            // 
            // pbLevel
            // 
            this.pbLevel.Location = new System.Drawing.Point(450, 0);
            this.pbLevel.Margin = new System.Windows.Forms.Padding(0);
            this.pbLevel.Name = "pbLevel";
            this.pbLevel.Size = new System.Drawing.Size(100, 50);
            this.pbLevel.TabIndex = 7;
            this.pbLevel.TabStop = false;
            // 
            // pbLife1
            // 
            this.pbLife1.Image = ((System.Drawing.Image)(resources.GetObject("pbLife1.Image")));
            this.pbLife1.Location = new System.Drawing.Point(450, 150);
            this.pbLife1.Margin = new System.Windows.Forms.Padding(0);
            this.pbLife1.Name = "pbLife1";
            this.pbLife1.Size = new System.Drawing.Size(100, 50);
            this.pbLife1.TabIndex = 6;
            this.pbLife1.TabStop = false;
            // 
            // pbLife2
            // 
            this.pbLife2.Image = ((System.Drawing.Image)(resources.GetObject("pbLife2.Image")));
            this.pbLife2.Location = new System.Drawing.Point(450, 200);
            this.pbLife2.Margin = new System.Windows.Forms.Padding(0);
            this.pbLife2.Name = "pbLife2";
            this.pbLife2.Size = new System.Drawing.Size(100, 50);
            this.pbLife2.TabIndex = 5;
            this.pbLife2.TabStop = false;
            // 
            // pbLife3
            // 
            this.pbLife3.Image = ((System.Drawing.Image)(resources.GetObject("pbLife3.Image")));
            this.pbLife3.Location = new System.Drawing.Point(450, 250);
            this.pbLife3.Margin = new System.Windows.Forms.Padding(0);
            this.pbLife3.Name = "pbLife3";
            this.pbLife3.Size = new System.Drawing.Size(100, 50);
            this.pbLife3.TabIndex = 4;
            this.pbLife3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(250, 350);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(150, 350);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(200, 350);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "5";
            // 
            // pbStopwatch
            // 
            this.pbStopwatch.Image = global::Test.Properties.Resources.clock1;
            this.pbStopwatch.Location = new System.Drawing.Point(450, 50);
            this.pbStopwatch.Margin = new System.Windows.Forms.Padding(0);
            this.pbStopwatch.Name = "pbStopwatch";
            this.pbStopwatch.Size = new System.Drawing.Size(100, 100);
            this.pbStopwatch.TabIndex = 0;
            this.pbStopwatch.TabStop = false;
            // 
            // Locomotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pbLevel);
            this.Controls.Add(this.pbLife1);
            this.Controls.Add(this.pbLife2);
            this.Controls.Add(this.pbLife3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbStopwatch);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(566, 439);
            this.MinimumSize = new System.Drawing.Size(566, 439);
            this.Name = "Locomotion";
            this.Text = "Locomotion";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPressed);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStopwatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStopwatch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbLife3;
        private System.Windows.Forms.PictureBox pbLife2;
        private System.Windows.Forms.PictureBox pbLife1;
        private System.Windows.Forms.PictureBox pbLevel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.Timer LevelNameTimer;
        private System.Windows.Forms.Timer TrainMoveTimer;
        private System.Windows.Forms.Timer TileMoveTimer;
        private System.Windows.Forms.Timer StopwatchTimer;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Timer MainGameTimer;
        private System.Windows.Forms.Timer TrainWreckTimer;
    }
}

