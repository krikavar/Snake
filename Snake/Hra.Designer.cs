
namespace Snake
{
    partial class Hra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hra));
            this.button_close = new System.Windows.Forms.Button();
            this.NejScore = new System.Windows.Forms.Label();
            this.Skore = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timer_pohyb = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(596, 6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(120, 46);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // NejScore
            // 
            this.NejScore.AutoSize = true;
            this.NejScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NejScore.Location = new System.Drawing.Point(256, 6);
            this.NejScore.Name = "NejScore";
            this.NejScore.Size = new System.Drawing.Size(148, 25);
            this.NejScore.TabIndex = 6;
            this.NejScore.Text = "Největší skóre";
            // 
            // Skore
            // 
            this.Skore.AutoSize = true;
            this.Skore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skore.Location = new System.Drawing.Point(151, 6);
            this.Skore.Name = "Skore";
            this.Skore.Size = new System.Drawing.Size(94, 25);
            this.Skore.TabIndex = 7;
            this.Skore.Text = "Skóre: 0";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picBox.Location = new System.Drawing.Point(10, 58);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(704, 509);
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(10, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 46);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startButton_KeyDown);
            this.startButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.startButton_KeyUp);
            // 
            // timer_pohyb
            // 
            this.timer_pohyb.Tick += new System.EventHandler(this.timer_pohyb_Tick);
            // 
            // Hra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(724, 573);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.NejScore);
            this.Controls.Add(this.Skore);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hra";
            this.Text = "Hra";
            this.Load += new System.EventHandler(this.Hra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hra_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Hra_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label NejScore;
        private System.Windows.Forms.Label Skore;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer_pohyb;
    }
}