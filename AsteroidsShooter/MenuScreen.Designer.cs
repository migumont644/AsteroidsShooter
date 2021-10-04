
namespace AsteroidsShooter
{
    partial class MenuScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.HowToPlayLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(783, 391);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(403, 52);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Asteroriod Shooter";
            // 
            // HowToPlayLabel
            // 
            this.HowToPlayLabel.AutoSize = true;
            this.HowToPlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlayLabel.ForeColor = System.Drawing.Color.Red;
            this.HowToPlayLabel.Location = new System.Drawing.Point(552, 483);
            this.HowToPlayLabel.Name = "HowToPlayLabel";
            this.HowToPlayLabel.Size = new System.Drawing.Size(858, 52);
            this.HowToPlayLabel.TabIndex = 1;
            this.HowToPlayLabel.Text = "Shoot the asteroriods before they hit you!";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTitleLabel.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.ForeColor = System.Drawing.Color.Green;
            this.subTitleLabel.Location = new System.Drawing.Point(393, 567);
            this.subTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(1302, 44);
            this.subTitleLabel.TabIndex = 6;
            this.subTitleLabel.Text = "Press Space to Start or Escape to Exit ";
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.HowToPlayLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(2050, 1065);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label HowToPlayLabel;
        private System.Windows.Forms.Label subTitleLabel;
    }
}
