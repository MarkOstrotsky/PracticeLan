namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.racketP = new System.Windows.Forms.PictureBox();
            this.racketC = new System.Windows.Forms.PictureBox();
            this.playground = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ScoreComp = new System.Windows.Forms.Label();
            this.ScorePlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketC)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(367, 200);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 16);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            this.ball.Paint += new System.Windows.Forms.PaintEventHandler(this.ball_Paint);
            // 
            // racketP
            // 
            this.racketP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.racketP.Location = new System.Drawing.Point(676, 133);
            this.racketP.Name = "racketP";
            this.racketP.Size = new System.Drawing.Size(15, 135);
            this.racketP.TabIndex = 1;
            this.racketP.TabStop = false;
            this.racketP.Click += new System.EventHandler(this.racketP_Click);
            this.racketP.Paint += new System.Windows.Forms.PaintEventHandler(this.racketP_Paint);
            this.racketP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.racketP_MouseMove);
            // 
            // racketC
            // 
            this.racketC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.racketC.Location = new System.Drawing.Point(31, 133);
            this.racketC.Name = "racketC";
            this.racketC.Size = new System.Drawing.Size(15, 135);
            this.racketC.TabIndex = 1;
            this.racketC.TabStop = false;
            this.racketC.Paint += new System.Windows.Forms.PaintEventHandler(this.racketC_Paint);
            // 
            // playground
            // 
            this.playground.Controls.Add(this.ScoreComp);
            this.playground.Controls.Add(this.ScorePlayer);
            this.playground.Controls.Add(this.racketC);
            this.playground.Controls.Add(this.racketP);
            this.playground.Controls.Add(this.ball);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(724, 477);
            this.playground.TabIndex = 0;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            this.playground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playground_MouseMove);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ScoreComp
            // 
            this.ScoreComp.AutoSize = true;
            this.ScoreComp.Location = new System.Drawing.Point(353, 9);
            this.ScoreComp.Name = "ScoreComp";
            this.ScoreComp.Size = new System.Drawing.Size(13, 13);
            this.ScoreComp.TabIndex = 1;
            this.ScoreComp.Text = "0";
            // 
            // ScorePlayer
            // 
            this.ScorePlayer.AutoSize = true;
            this.ScorePlayer.Location = new System.Drawing.Point(384, 9);
            this.ScorePlayer.Name = "ScorePlayer";
            this.ScorePlayer.Size = new System.Drawing.Size(13, 13);
            this.ScorePlayer.TabIndex = 2;
            this.ScorePlayer.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 477);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketC)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racketP;
        private System.Windows.Forms.PictureBox racketC;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label ScoreComp;
        private System.Windows.Forms.Label ScorePlayer;
    }
}

