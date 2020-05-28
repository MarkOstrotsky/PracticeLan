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
        public int speedball = 5;        //Скорость шарика
        public int pointComp = 0;       //Очки компьютера
        public int pointPlayer = 0;    //Очки игрока
       
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
           // Cursor.Hide();
            racketP.Left = playground.Right - (playground.Right / 20);

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //racketP.Top = Cursor.Position.Y - (racketP.Height / 2);
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
            Point pos = e.Location;
            
        }

        private void racketP_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(System.Drawing.Color.Red);
            Rectangle rect = new Rectangle(0, 0, 15, 135);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void racketC_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(System.Drawing.Color.Red);
            Rectangle rect = new Rectangle(0, 0, 15, 135);
            e.Graphics.FillRectangle(brush, rect);
        }
    }
}
