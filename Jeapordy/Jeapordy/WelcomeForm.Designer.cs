
namespace Jeapordy
{
    partial class WelcomeForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.NameInputLabel = new System.Windows.Forms.Label();
            this.Team1Name_txt = new System.Windows.Forms.TextBox();
            this.Team2Name_txt = new System.Windows.Forms.TextBox();
            this.Team1Label = new System.Windows.Forms.Label();
            this.Team2NameLabel = new System.Windows.Forms.Label();
            this.SingIn_btn = new System.Windows.Forms.Button();
            this.Minimize_btn = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(98, 62);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(609, 59);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to Jeapordized!";
            // 
            // NameInputLabel
            // 
            this.NameInputLabel.AutoSize = true;
            this.NameInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameInputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInputLabel.ForeColor = System.Drawing.Color.White;
            this.NameInputLabel.Location = new System.Drawing.Point(219, 133);
            this.NameInputLabel.Name = "NameInputLabel";
            this.NameInputLabel.Size = new System.Drawing.Size(332, 30);
            this.NameInputLabel.TabIndex = 1;
            this.NameInputLabel.Text = "Please enter Team Names:";
            // 
            // Team1Name_txt
            // 
            this.Team1Name_txt.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Name_txt.Location = new System.Drawing.Point(129, 286);
            this.Team1Name_txt.Name = "Team1Name_txt";
            this.Team1Name_txt.Size = new System.Drawing.Size(217, 40);
            this.Team1Name_txt.TabIndex = 2;
            this.Team1Name_txt.TextChanged += new System.EventHandler(this.Team1Name_txt_TextChanged);
            // 
            // Team2Name_txt
            // 
            this.Team2Name_txt.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Name_txt.Location = new System.Drawing.Point(445, 286);
            this.Team2Name_txt.Name = "Team2Name_txt";
            this.Team2Name_txt.Size = new System.Drawing.Size(217, 40);
            this.Team2Name_txt.TabIndex = 3;
            this.Team2Name_txt.TextChanged += new System.EventHandler(this.Team2Name_txt_TextChanged);
            // 
            // Team1Label
            // 
            this.Team1Label.AutoSize = true;
            this.Team1Label.BackColor = System.Drawing.Color.Transparent;
            this.Team1Label.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Label.ForeColor = System.Drawing.Color.White;
            this.Team1Label.Location = new System.Drawing.Point(191, 232);
            this.Team1Label.Name = "Team1Label";
            this.Team1Label.Size = new System.Drawing.Size(91, 25);
            this.Team1Label.TabIndex = 4;
            this.Team1Label.Text = "Team 1";
            // 
            // Team2NameLabel
            // 
            this.Team2NameLabel.AutoSize = true;
            this.Team2NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.Team2NameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2NameLabel.ForeColor = System.Drawing.Color.White;
            this.Team2NameLabel.Location = new System.Drawing.Point(509, 248);
            this.Team2NameLabel.Name = "Team2NameLabel";
            this.Team2NameLabel.Size = new System.Drawing.Size(91, 25);
            this.Team2NameLabel.TabIndex = 5;
            this.Team2NameLabel.Text = "Team 2";
            // 
            // SingIn_btn
            // 
            this.SingIn_btn.BackColor = System.Drawing.Color.White;
            this.SingIn_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingIn_btn.ForeColor = System.Drawing.Color.Black;
            this.SingIn_btn.Location = new System.Drawing.Point(285, 367);
            this.SingIn_btn.Name = "SingIn_btn";
            this.SingIn_btn.Size = new System.Drawing.Size(211, 42);
            this.SingIn_btn.TabIndex = 6;
            this.SingIn_btn.Text = "Continue";
            this.SingIn_btn.UseVisualStyleBackColor = false;
            this.SingIn_btn.Click += new System.EventHandler(this.SingIn_btn_Click);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize_btn.Image = global::Jeapordy.Properties.Resources.minimize_window;
            this.Minimize_btn.Location = new System.Drawing.Point(701, 8);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(44, 45);
            this.Minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize_btn.TabIndex = 7;
            this.Minimize_btn.TabStop = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_btn.Image = global::Jeapordy.Properties.Resources.cross;
            this.Close_btn.Location = new System.Drawing.Point(751, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(37, 36);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_btn.TabIndex = 8;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jeapordy.Properties.Resources._1440x900_Cool_blue_glare_backgrounds_for_windows_wide_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.SingIn_btn);
            this.Controls.Add(this.Team2NameLabel);
            this.Controls.Add(this.Team1Label);
            this.Controls.Add(this.Team2Name_txt);
            this.Controls.Add(this.Team1Name_txt);
            this.Controls.Add(this.NameInputLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "Welcome Screen";
            this.Activated += new System.EventHandler(this.WelcomeForm_Activated);
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResizeEnd += new System.EventHandler(this.WelcomeForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.WelcomeForm_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WelcomeForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WelcomeForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label NameInputLabel;
        private System.Windows.Forms.TextBox Team1Name_txt;
        private System.Windows.Forms.TextBox Team2Name_txt;
        private System.Windows.Forms.Label Team1Label;
        private System.Windows.Forms.Label Team2NameLabel;
        private System.Windows.Forms.Button SingIn_btn;
        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.PictureBox Close_btn;
    }
}

