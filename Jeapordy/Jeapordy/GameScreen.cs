//Syed Kaab Surkhi
//April 28, 2023
//Mr. A. Mayer
//A program that runs a jeapordy styled game application

using System;
using System.Windows.Forms;

namespace Jeapordy
{
    public partial class GameScreen : Form
    {
        public string condition;
        public int Answerindex;
        public string teamChosen;
        public int score1 = 0;
        public int score2 = 0;
        public int Team1Max = 0;
        public int Team2Max = 0;
        public string Team1Condition;
        public string Team2Condition;
        public int buttonNumCount;
        public string winner;

        public static GameScreen instance;
        public GameScreen()
        {
            InitializeComponent();
            instance = this;

        }

        public string question;

        private void Team1_btn_Click(object sender, EventArgs e)
        {
            teamChosen = "Team1";
            Team2_btn.Enabled = false;
            OptionA_btn.Enabled = true;
            OptionB_btn.Enabled = true;
            OptionC_btn.Enabled = true;
            OptionD_btn.Enabled = true;
            condition = "Team1";
        }

        private void Team2_btn_Click(object sender, EventArgs e)
        {
            teamChosen = "Team2";
            Team1_btn.Enabled = false;
            OptionA_btn.Enabled = true;
            OptionB_btn.Enabled = true;
            OptionC_btn.Enabled = true;
            OptionD_btn.Enabled = true;
            condition = "Team2";
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Question_Label.Text = MenuScreen.instance.question;
            ChoiceA_Label.Text = MenuScreen.instance.Choice1;
            ChoiceB_label.Text = MenuScreen.instance.Choice2;
            ChoiceC_label.Text = MenuScreen.instance.Choice3;
            ChoiceD_label.Text = MenuScreen.instance.Choice4;

            score1 = MenuScreen.instance.scoreHolder1;
            score2 = MenuScreen.instance.scoreHolder2;
            Team1Max = MenuScreen.instance.Team1Max;
            Team2Max = MenuScreen.instance.Team2Max;
        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            new MenuScreen().Show();
            this.Hide();
        }

        private void AnswerChosen_btn(object sender, EventArgs e)
        {
            Button answer = (Button)sender;
            if (!int.TryParse(answer.Tag.ToString(), out Answerindex))
            {
                // handle error case where Tag is not a valid integer
                return;
            }


            if (MenuScreen.instance.correctOrWrong[MenuScreen.instance.index, Convert.ToInt32(Answerindex)] == "Correct")
            {
                MessageBox.Show("Correct");
                if (condition == "Team1")
                {
                    Team1Condition = "Correct";
                }
                else if(condition == "Team2")
                {
                    Team2Condition = "Correct";
                }

                if(Team1Condition == "Correct")
                {
                    score1 = score1 + Convert.ToInt32(MenuScreen.instance.store);
                    MenuScreen.instance.Score1_Label.Text = (Convert.ToInt32(MenuScreen.instance.Score1_Label.Text) + score1).ToString();
                }
                else if(Team1Condition == "Wrong")
                {
                    score1 = score1 - Convert.ToInt32(MenuScreen.instance.store);
                    MenuScreen.instance.Score1_Label.Text = (Convert.ToInt32(MenuScreen.instance.Score1_Label.Text) + score1).ToString();
                }
                if(Team2Condition == "Correct")
                {
                    score2 = score2 + Convert.ToInt32(MenuScreen.instance.store);
                    MenuScreen.instance.Score2_Label.Text = (Convert.ToInt32(MenuScreen.instance.Score2_Label.Text) + score2).ToString();
                }
                else if(Team2Condition == "Wrong")
                {
                    score2 = score2 - Convert.ToInt32(MenuScreen.instance.store);
                    MenuScreen.instance.Score2_Label.Text = (Convert.ToInt32(MenuScreen.instance.Score2_Label.Text) + score2).ToString();
                }

                if(Convert.ToInt32(MenuScreen.instance.Score1_Label.Text) > Convert.ToInt32(MenuScreen.instance.HighScore1_Label.Text))
                {
                    MenuScreen.instance.HighScore1_Label.Text = MenuScreen.instance.Score1_Label.Text;
                }
                if (Convert.ToInt32(MenuScreen.instance.Score2_Label.Text) > Convert.ToInt32(MenuScreen.instance.HighScore2_Label.Text))
                {
                    MenuScreen.instance.HighScore2_Label.Text = MenuScreen.instance.Score2_Label.Text;
                }
                this.Hide();
                MenuScreen.instance.Visible = true;


            }
            else if(MenuScreen.instance.correctOrWrong[MenuScreen.instance.index, Convert.ToInt32(Answerindex)] == "Wrong")
            {
                MessageBox.Show("Wrong");
                if (condition == "Team1")
                {
                    Team1Condition = "Wrong";
                }
                else if (condition == "Team2")
                {
                    Team2Condition = "Wrong";
                }
                Team1_btn.Enabled = true;
                Team2_btn.Enabled = true;
                OptionA_btn.Enabled = false;
                OptionB_btn.Enabled = false;
                OptionC_btn.Enabled = false;
                OptionD_btn.Enabled = false;
            }

            if(MenuScreen.instance.buttonNumCount == 25)
            {
                if (Convert.ToInt32(MenuScreen.instance.Score1_Label.Text) > Convert.ToInt32(MenuScreen.instance.Score2_Label.Text))
                {
                    MessageBox.Show("The winner is Team 1");
                }
                else if(Convert.ToInt32(MenuScreen.instance.Score2_Label.Text) > Convert.ToInt32(MenuScreen.instance.Score1_Label.Text))
                {
                    MessageBox.Show("The winner is Team 2");
                }
                this.Close();
                MenuScreen.instance.Close();
                System.Windows.Forms.Application.Exit();
            }
            
        }
    }
}
