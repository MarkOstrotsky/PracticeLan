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
            this.playground = new System.Windows.Forms.Panel();
            this.racketC = new System.Windows.Forms.PictureBox();
            this.racketP = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racketC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.racketC);
            this.playground.Controls.Add(this.racketP);
            this.playground.Controls.Add(this.ball);
            this.playground.Location = new System.Drawing.Point(0, 55);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(724, 407);
            this.playground.TabIndex = 0;
            this.playground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playground_MouseMove);
            // 
            // racketC
            // 
            this.racketC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.racketC.Location = new System.Drawing.Point(3, 133);
            this.racketC.Name = "racketC";
            this.racketC.Size = new System.Drawing.Size(15, 135);
            this.racketC.TabIndex = 1;
            this.racketC.TabStop = false;
            this.racketC.Paint += new System.Windows.Forms.PaintEventHandler(this.racketC_Paint);
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
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(328, 191);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 16);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racketC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox racketC;
        private System.Windows.Forms.PictureBox racketP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

