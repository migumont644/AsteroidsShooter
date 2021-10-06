
namespace AsteroidsShooter
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.scoreTwoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.gameOverLabel.Location = new System.Drawing.Point(884, 430);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(304, 51);
            this.gameOverLabel.TabIndex = 2;
            this.gameOverLabel.Text = "GAME OVER!";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTitleLabel.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.ForeColor = System.Drawing.Color.Green;
            this.subTitleLabel.Location = new System.Drawing.Point(201, 503);
            this.subTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(1705, 67);
            this.subTitleLabel.TabIndex = 7;
            this.subTitleLabel.Text = "Press Space to go back to the main menu or Escape to Exit ";
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreTwoLabel
            // 
            this.scoreTwoLabel.AutoSize = true;
            this.scoreTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTwoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreTwoLabel.Location = new System.Drawing.Point(937, 582);
            this.scoreTwoLabel.Name = "scoreTwoLabel";
            this.scoreTwoLabel.Size = new System.Drawing.Size(165, 54);
            this.scoreTwoLabel.TabIndex = 8;
            this.scoreTwoLabel.Text = "Score:";
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.scoreTwoLabel);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(2050, 1065);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Label scoreTwoLabel;
    }
}
