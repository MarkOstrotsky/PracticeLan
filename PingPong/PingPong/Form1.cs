using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{

    public partial class Form1 : Form
    {
        private object currentobj = null;       //Объект ракетки игрока
        public int speedballleft = 3;        //Скорость шарика
        public int speedballtop = 1;
        public int pointComp = 0;       //Очки компьютера
        public int pointPlayer = 0;    //Очки игрока
       
        public Form1()
        { 
            InitializeComponent();

            timer1.Enabled = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            racketP.Left = playground.Right - (playground.Right / 20);
            this.MouseClick += new MouseEventHandler(mouseClick);

        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
                currentobj = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ball.Top += speedballtop;
            ball.Left += speedballleft;
            racketC.Location = new Point(15, ball.Location.Y-55);
            
            if (ball.Right >= racketP.Left && ball.Right <= racketP.Right && ball.Bottom <= racketP.Bottom && ball.Top >= racketP.Top)
            {
                speedballleft += 1;
                speedballtop += 1;
                speedballleft = -speedballleft;
            }
            if (speedballleft == 14 | speedballtop == 14)
            {
                speedballleft -= 1;
                speedballtop -= 1;
            }

            if (ball.Bottom >= playground.Bottom)
            
            {
                speedballtop =- speedballtop;
            }

            if (ball.Left <= playground.Left)
            {
                speedballleft = -speedballleft; 
            }

            if (ball.Top <= playground.Top)
            {
                speedballtop = -speedballtop;
            }

            if (ball.Right >= playground.Right)
            {
                speedballleft = -speedballleft;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)           //Выход на клавишу escape
            { 
                this.Close(); 
            } 
        }

        private void racketP_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void racketP_Paint(object sender, PaintEventArgs e)     //Отрисовка ракетки игрока
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(System.Drawing.Color.Red);
            Rectangle rect = new Rectangle(0, 0, 15, 135);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void racketC_Paint(object sender, PaintEventArgs e)     //Отрисовка ракетки компьютера
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(System.Drawing.Color.Red);
            Rectangle rect = new Rectangle(0, 0, 15, 135);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void racketP_Click(object sender, EventArgs e)
        {
            currentobj = sender;        //Выделение ракетки игроком
           
        }

        private void playground_MouseMove(object sender, MouseEventArgs e)      //Перемещение ракетки за курсором игрока
        {
            if (currentobj != null)
                currentobj.GetType().GetProperty("Location").SetValue(currentobj, new Point(e.X, e.Y));
        }

        private void ball_Paint(object sender, PaintEventArgs e)        //Отрисовка шарика
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(System.Drawing.Color.Black);
            Rectangle rect = new Rectangle(0, 0, 16, 16);
            e.Graphics.FillEllipse(brush, rect);
        }

        private void playground_Paint(object sender, PaintEventArgs e)      //Отрисовка цетровой линии 
        {
            Graphics g = e.Graphics;
            Pen blackpen = new Pen(Color.Black, 2);
            PointF point1 = new PointF(375.0F, 600.0F);
            PointF point2 = new PointF(375.0F, 0.0F);
            e.Graphics.DrawLine(blackpen, point1, point2);
        }
    }
}
