
namespace ARCANOID
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
            this.score1 = new System.Windows.Forms.Label();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lifes1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.record1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score1.Location = new System.Drawing.Point(12, 504);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(69, 17);
            this.score1.TabIndex = 0;
            this.score1.Text = "Score: 0";
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paddle.Location = new System.Drawing.Point(400, 475);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(100, 25);
            this.paddle.TabIndex = 1;
            this.paddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.BlueViolet;
            this.ball.Location = new System.Drawing.Point(440, 450);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // lifes1
            // 
            this.lifes1.AutoSize = true;
            this.lifes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lifes1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lifes1.Location = new System.Drawing.Point(12, 527);
            this.lifes1.Name = "lifes1";
            this.lifes1.Size = new System.Drawing.Size(62, 17);
            this.lifes1.TabIndex = 3;
            this.lifes1.Text = "Lifes: 0";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name1.Location = new System.Drawing.Point(785, 504);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(54, 17);
            this.name1.TabIndex = 4;
            this.name1.Text = "Name:";
            // 
            // record1
            // 
            this.record1.AutoSize = true;
            this.record1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.record1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.record1.Location = new System.Drawing.Point(785, 527);
            this.record1.Name = "record1";
            this.record1.Size = new System.Drawing.Size(79, 17);
            this.record1.TabIndex = 5;
            this.record1.Text = "Record: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.record1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.lifes1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.score1);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label score1;
        public System.Windows.Forms.PictureBox paddle;
        public System.Windows.Forms.PictureBox ball;
        public System.Windows.Forms.Timer gameTimer;
        public System.Windows.Forms.Label lifes1;
        public System.Windows.Forms.Label name1;
        public System.Windows.Forms.Label record1;
    }
}

