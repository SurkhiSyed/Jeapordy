
namespace Jeapordy
{
    partial class GameScreen
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
            this.Team_Label = new System.Windows.Forms.Label();
            this.Team1_btn = new System.Windows.Forms.Button();
            this.Team2_btn = new System.Windows.Forms.Button();
            this.Question_Label = new System.Windows.Forms.Label();
            this.OptionA_btn = new System.Windows.Forms.Button();
            this.OptionB_btn = new System.Windows.Forms.Button();
            this.OptionC_btn = new System.Windows.Forms.Button();
            this.OptionD_btn = new System.Windows.Forms.Button();
            this.ChoiceA_Label = new System.Windows.Forms.Label();
            this.ChoiceB_label = new System.Windows.Forms.Label();
            this.ChoiceC_label = new System.Windows.Forms.Label();
            this.ChoiceD_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Team_Label
            // 
            this.Team_Label.AutoSize = true;
            this.Team_Label.BackColor = System.Drawing.Color.Transparent;
            this.Team_Label.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team_Label.ForeColor = System.Drawing.Color.White;
            this.Team_Label.Location = new System.Drawing.Point(364, 22);
            this.Team_Label.Name = "Team_Label";
            this.Team_Label.Size = new System.Drawing.Size(102, 34);
            this.Team_Label.TabIndex = 0;
            this.Team_Label.Text = "Team:";
            // 
            // Team1_btn
            // 
            this.Team1_btn.BackColor = System.Drawing.Color.White;
            this.Team1_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1_btn.ForeColor = System.Drawing.Color.Black;
            this.Team1_btn.Location = new System.Drawing.Point(153, 77);
            this.Team1_btn.Name = "Team1_btn";
            this.Team1_btn.Size = new System.Drawing.Size(178, 46);
            this.Team1_btn.TabIndex = 1;
            this.Team1_btn.Text = "Team 1";
            this.Team1_btn.UseVisualStyleBackColor = false;
            this.Team1_btn.Click += new System.EventHandler(this.Team1_btn_Click);
            // 
            // Team2_btn
            // 
            this.Team2_btn.BackColor = System.Drawing.Color.White;
            this.Team2_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2_btn.ForeColor = System.Drawing.Color.Black;
            this.Team2_btn.Location = new System.Drawing.Point(488, 77);
            this.Team2_btn.Name = "Team2_btn";
            this.Team2_btn.Size = new System.Drawing.Size(178, 46);
            this.Team2_btn.TabIndex = 2;
            this.Team2_btn.Text = "Team 2";
            this.Team2_btn.UseVisualStyleBackColor = false;
            this.Team2_btn.Click += new System.EventHandler(this.Team2_btn_Click);
            // 
            // Question_Label
            // 
            this.Question_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Question_Label.AutoSize = true;
            this.Question_Label.BackColor = System.Drawing.Color.Transparent;
            this.Question_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question_Label.ForeColor = System.Drawing.Color.White;
            this.Question_Label.Location = new System.Drawing.Point(16, 151);
            this.Question_Label.Name = "Question_Label";
            this.Question_Label.Size = new System.Drawing.Size(113, 30);
            this.Question_Label.TabIndex = 3;
            this.Question_Label.Text = "Question";
            // 
            // OptionA_btn
            // 
            this.OptionA_btn.BackColor = System.Drawing.Color.White;
            this.OptionA_btn.Enabled = false;
            this.OptionA_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionA_btn.Location = new System.Drawing.Point(97, 204);
            this.OptionA_btn.Name = "OptionA_btn";
            this.OptionA_btn.Size = new System.Drawing.Size(52, 42);
            this.OptionA_btn.TabIndex = 4;
            this.OptionA_btn.Tag = "0";
            this.OptionA_btn.Text = "A";
            this.OptionA_btn.UseVisualStyleBackColor = false;
            this.OptionA_btn.Click += new System.EventHandler(this.AnswerChosen_btn);
            // 
            // OptionB_btn
            // 
            this.OptionB_btn.BackColor = System.Drawing.Color.White;
            this.OptionB_btn.Enabled = false;
            this.OptionB_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionB_btn.Location = new System.Drawing.Point(97, 265);
            this.OptionB_btn.Name = "OptionB_btn";
            this.OptionB_btn.Size = new System.Drawing.Size(52, 42);
            this.OptionB_btn.TabIndex = 5;
            this.OptionB_btn.Tag = "1";
            this.OptionB_btn.Text = "B";
            this.OptionB_btn.UseVisualStyleBackColor = false;
            this.OptionB_btn.Click += new System.EventHandler(this.AnswerChosen_btn);
            // 
            // OptionC_btn
            // 
            this.OptionC_btn.BackColor = System.Drawing.Color.White;
            this.OptionC_btn.Enabled = false;
            this.OptionC_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionC_btn.Location = new System.Drawing.Point(97, 324);
            this.OptionC_btn.Name = "OptionC_btn";
            this.OptionC_btn.Size = new System.Drawing.Size(52, 42);
            this.OptionC_btn.TabIndex = 6;
            this.OptionC_btn.Tag = "2";
            this.OptionC_btn.Text = "C";
            this.OptionC_btn.UseVisualStyleBackColor = false;
            this.OptionC_btn.Click += new System.EventHandler(this.AnswerChosen_btn);
            // 
            // OptionD_btn
            // 
            this.OptionD_btn.BackColor = System.Drawing.Color.White;
            this.OptionD_btn.Enabled = false;
            this.OptionD_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionD_btn.Location = new System.Drawing.Point(97, 382);
            this.OptionD_btn.Name = "OptionD_btn";
            this.OptionD_btn.Size = new System.Drawing.Size(52, 42);
            this.OptionD_btn.TabIndex = 7;
            this.OptionD_btn.Tag = "3";
            this.OptionD_btn.Text = "D";
            this.OptionD_btn.UseVisualStyleBackColor = false;
            this.OptionD_btn.Click += new System.EventHandler(this.AnswerChosen_btn);
            // 
            // ChoiceA_Label
            // 
            this.ChoiceA_Label.AutoSize = true;
            this.ChoiceA_Label.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceA_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceA_Label.ForeColor = System.Drawing.Color.White;
            this.ChoiceA_Label.Location = new System.Drawing.Point(155, 213);
            this.ChoiceA_Label.Name = "ChoiceA_Label";
            this.ChoiceA_Label.Size = new System.Drawing.Size(98, 27);
            this.ChoiceA_Label.TabIndex = 8;
            this.ChoiceA_Label.Text = "Option A";
            // 
            // ChoiceB_label
            // 
            this.ChoiceB_label.AutoSize = true;
            this.ChoiceB_label.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceB_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceB_label.ForeColor = System.Drawing.Color.White;
            this.ChoiceB_label.Location = new System.Drawing.Point(155, 274);
            this.ChoiceB_label.Name = "ChoiceB_label";
            this.ChoiceB_label.Size = new System.Drawing.Size(97, 27);
            this.ChoiceB_label.TabIndex = 9;
            this.ChoiceB_label.Text = "Option B";
            // 
            // ChoiceC_label
            // 
            this.ChoiceC_label.AutoSize = true;
            this.ChoiceC_label.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceC_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceC_label.ForeColor = System.Drawing.Color.White;
            this.ChoiceC_label.Location = new System.Drawing.Point(155, 333);
            this.ChoiceC_label.Name = "ChoiceC_label";
            this.ChoiceC_label.Size = new System.Drawing.Size(97, 27);
            this.ChoiceC_label.TabIndex = 10;
            this.ChoiceC_label.Text = "Option C";
            // 
            // ChoiceD_label
            // 
            this.ChoiceD_label.AutoSize = true;
            this.ChoiceD_label.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceD_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceD_label.ForeColor = System.Drawing.Color.White;
            this.ChoiceD_label.Location = new System.Drawing.Point(155, 391);
            this.ChoiceD_label.Name = "ChoiceD_label";
            this.ChoiceD_label.Size = new System.Drawing.Size(99, 27);
            this.ChoiceD_label.TabIndex = 11;
            this.ChoiceD_label.Text = "Option D";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jeapordy.Properties.Resources.MkLdje;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoiceD_label);
            this.Controls.Add(this.ChoiceC_label);
            this.Controls.Add(this.ChoiceB_label);
            this.Controls.Add(this.ChoiceA_Label);
            this.Controls.Add(this.OptionD_btn);
            this.Controls.Add(this.OptionC_btn);
            this.Controls.Add(this.OptionB_btn);
            this.Controls.Add(this.OptionA_btn);
            this.Controls.Add(this.Question_Label);
            this.Controls.Add(this.Team2_btn);
            this.Controls.Add(this.Team1_btn);
            this.Controls.Add(this.Team_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameScreen";
            this.Text = "Game Screen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Team_Label;
        private System.Windows.Forms.Button Team1_btn;
        private System.Windows.Forms.Button Team2_btn;
        private System.Windows.Forms.Label Question_Label;
        private System.Windows.Forms.Button OptionA_btn;
        private System.Windows.Forms.Button OptionB_btn;
        private System.Windows.Forms.Button OptionC_btn;
        private System.Windows.Forms.Button OptionD_btn;
        private System.Windows.Forms.Label ChoiceA_Label;
        private System.Windows.Forms.Label ChoiceB_label;
        private System.Windows.Forms.Label ChoiceC_label;
        private System.Windows.Forms.Label ChoiceD_label;
    }
}