using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOme
{
    public partial class HomeBall : Form
    {
       private int verVel = 0;
       private int horVel = 0;
       private int speed = 2;
        bool mouseDown = false;

       private Timer mainTimer = null;
       private Point MouseDownLocation;


        public HomeBall()
        {
            InitializeComponent();
            InitializeField();
            InitializeMainTimer();
        }

        private void InitializeField()
        {
            verVel = speed;
            horVel = speed;
            this.BackColor = Color.White;
            this.KeyDown += new KeyEventHandler(Field_KeyDown);
            UpdateSpeedLable();
            Ball.Image = Properties.Resources.dvd;
            Ball.Height = 100;
            Ball.Width = 100;
            Ball.BackColor = Color.Transparent;
        }

        private void InitializeMainTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
            mainTimer.Interval = 10;
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            MoveTheBall();
            BallBorderColusion();
            RacketColusion();
            updateVelocities();
            
        }

        private void MoveTheBall()
        {
            Ball.Top += verVel;
            Ball.Left += horVel;      
        }

        private void BallBorderColusion()
        {
            if (Ball.Top + Ball.Height > ClientRectangle.Height)
            {
                verVel = -speed;
            }
            else if (Ball.Top < 0)
            {
                verVel = speed;
            }
            if (Ball.Left + Ball.Width > ClientRectangle.Width)
            {
                horVel = -speed;
            }
            else if (Ball.Left < 0)
            {
                horVel = speed;
            }

        }
       
        
        private void Field_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.X)
            {
                speed += 1;
                UpdateSpeedLable();
            }
            else if(e.KeyCode == Keys.Z)
            {
                if (speed > 1)
                {
                    speed -= 1;
                    UpdateSpeedLable();
                }
            }
               
        }

        private void UpdateSpeedLable()
        {
            LabS.Text = "Ball Speed: " + speed;
        }
       
        private void updateVelocities()
        {
            verVel = speed * (verVel / Math.Abs(verVel));
            horVel = speed * (horVel / Math.Abs(horVel));

        }

        private void RacketColusion()
        {
            if (Ball.Bounds.IntersectsWith(racket.Bounds))
            {
                verVel = -verVel;
            }

        }


        private void racket_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void racket_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                racket.Left = e.X + racket.Left - MouseDownLocation.X;
                racket.Top = e.Y + racket.Top - MouseDownLocation.Y;
            }
        }
    }
}

