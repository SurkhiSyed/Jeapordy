//Syed Kaab Surkhi
//April 28, 2023
//Mr. A. Mayer
//A program that runs a jeapordy styled game application

using System;
using System.Windows.Forms;

namespace Jeapordy
{
    public partial class MenuScreen : Form
    {

        public static MenuScreen instance;
        public MenuScreen()
        {
            InitializeComponent();
            instance = this;
        }

        //All of these value holders below are to be accessed by GameScreen form
        public int Prize;
        public int scoreHolder1 = 0;
        public int scoreHolder2 = 0;
        public string store;
        public int score1;
        public int score2;
        public int index;
        public string question;
        public string Choice1;
        public string Choice2;
        public string Choice3;
        public string Choice4;
        public int Team1Max = 0;
        public int Team2Max = 0;
        public Button num;
        public int buttonNumCount = 0;

        //This array holds all the questions that will be accessed using the GameScreen form using the Tag of each button as the index
        public string[] QuestionsList = 
        {
                "What is the capital of Canada?",
                "What country has the most natural lakes?",
                "Which country has the largest population in the world?",
                "What is the name of the smallest country in the world?",
                "How many countries are there in the world?",
             
                "Who is Canada's first Prime Minister?",
                "When was the first World war started?",
                "When did World War II start and end?",
                "What was the reason for Black Plague?",
                "Who invented the automobile?",
             
                "Solve: 2 + 10 x 2",
                "Solve: sin^2(x) + cos^2(x)",
                "Solve for x: x^2 + 1 = 0",
                "Find the derivative of y = 4x - 1",
                "Maximum height of a ball in equation y = -(x-2)^2 + 4",
             
                "Which team won the 2022 world cup?",
                "Who won the NBA championship in 2019?",
                "How many holes are there in a typical golf course?",
                "Where will the next world cup take place?",
                "Which basketball player has the most points?",

                "Who is the most the most awarded Indian Actor?",
                "What is the name of the classical Dinosaur film series?",
                "Who is the main character of the Movie 'Home Alone'?",
                "Who is the main actor of the movie 'Rambo'?",
                "Movie involves traveling through space and finding a new planet?"
        };
        //This 2 dimensional array holds al of the choices given to the user and will be accessed through the GameScreen form 
        public string[,] choicesList =
        {
            {"Toronto","Ontario","The Parliament Building","Ottawa"},
            {"Egypt","Pakistan","Brazil","Canada"},
            {"Russia","China","India","Saudi Arabia"},
            {"The Vatican City","The Bahamas","Monaco","Thailand"},
            {"121","195","240","350"},

            {"John A. Macdonald", "Pierre Trudeau", "Alexandar the Great", "Wilfrid Laurier"},
            {"1918", "1950", "1945", "1914"},
            {"1914 and 1925", "1925 and 1935", "1939 and 1945", "1935 and 1945"},
            {"Yersinia Pestis", "Infected Rats", "Mosquitos", "Spanish Disease"},
            {"Albert Einstein", "Nicola Tesla", "Carl Benz", "Henry Ford"},

            {"24", "22", "40", "14" },
            {"2sin(x) + 2cos(x)", "tan^x", "cos2x", "1"},
            {"x = 1", "x = -1", "x = 1,-1", "x = i" },
            {"4", "4x - 1", "1/4", "0" },
            {"x = 4", "x = 2", "x = 4,0", "x = 0"},

            {"France", "Brazil", "Argentina", "Spain" },
            {"Toronto Raptors", "Los Angeles Lakers", "Chicago Bulls", "Golden state Warriors" },
            {"20", "19", "18", "17" },
            {"Brazil", "Potrugal", "North America", "Spain" },
            {"Kobe Bryant", "LeBron James", "Kawhi Leonard", "Stephen Curry"},

            { "Amir Khan", "Shah Rukh Khan", "Salman Khan", "Irrfan Khan"},
            {"Jurassic World", "Land of the Lost", "Jurassic Park", "Godzilla" },
            {"Kevin McCallister", "Steven Tran", "Buzz McCallister", "Harry Lime" },
            {"Richard Crenna", "Johnny Depp", "Jackie Chan", "Sylvester Stallone"},
            {"E.T.", "Moonfall", "InterStellar", "The Martian" }
        };
        //This 2 dimensional array holds if the options in the choiceList array provided are correct or wrong and will be accessed through the GameScreen form
        public string[,] correctOrWrong =
        {
            {"Wrong", "Wrong", "Wrong", "Correct" },
            {"Wrong", "Wrong", "Wrong", "Correct" },
            {"Wrong", "Wrong", "Correct", "Wrong" },
            {"Correct", "Wrong", "Wrong", "Wrong" },
            {"Wrong", "Correct", "Wrong", "Wrong" },

            {"Correct", "Wrong", "Wrong", "Wrong" },
            {"Wrong", "Wrong","Wrong", "Correct" },
            {"Wrong", "Wrong", "Correct", "Wrong" },
            {"Correct", "Wrong","Wrong","Wrong" },
            {"Wrong", "Wrong", "Correct", "Wrong" },

            {"Wrong", "Correct", "Wrong", "Wrong"},
            {"Wrong","Wrong","Wrong", "Correct" },
            {"Wrong","Wrong","Wrong", "Correct" },
            {"Correct","Wrong","Wrong","Wrong" },
            {"Wrong", "Correct","Wrong","Wrong" },

            {"Wrong","Wrong", "Correct","Wrong" },
            {"Correct","Wrong","Wrong","Wrong" },
            {"Wrong","Wrong", "Correct","Wrong" },
            {"Wrong", "Wrong","Correct","Wrong"},
            {"Wrong", "Correct", "Wrong","Wrong" },

            {"Wrong", "Correct","Wrong","Wrong" },
            {"Wrong", "Wrong", "Correct", "Wrong" },
            {"Correct", "Wrong","Wrong","Wrong" },
            {"Wrong","Wrong","Wrong", "Correct" },
            {"Wrong","Wrong", "Correct","Wrong" }
        };

        //When the form first loads
        private void Menu_Load(object sender, EventArgs e)
        {
            Team1Name_Label.Text = WelcomeForm.instance.TeamNAme1;
            Team2Name_Label.Text = WelcomeForm.instance.TeamName2;
            
            scoreHolder1 = scoreHolder1 + GameScreen.instance.score1;
            Score1_Label.Text = scoreHolder1.ToString();
            
            scoreHolder2 = scoreHolder2 + GameScreen.instance.score2;
            Score2_Label.Text = scoreHolder2.ToString();

            Team1Max = GameScreen.instance.Team1Max;
            Team2Max = GameScreen.instance.Team2Max;

            if (scoreHolder1 > Team1Max)
            {
                Team1Max = scoreHolder1;
            }
            if(scoreHolder2 > Team2Max)
            {
                Team2Max = scoreHolder2;
            }

            HighScore1_Label.Text = Convert.ToString(Team1Max);
            HighScore2_Label.Text = Convert.ToString(Team2Max);

        }

        //When any button is clicked
        private void QuestionSelector_btn(object sender, EventArgs e)
        {
            //Takes the value of the button selected and stores it under button num that was created earlier
            num = (Button)sender;
            store = num.Text;
            Prize = Convert.ToInt32(store);
            //Takes the Tag value of the button selected and stores it as index
            if (!int.TryParse(num.Tag.ToString(), out index))
            {
                // handle error case where Tag is not a valid integer
                return;
            }
            //Question selected is chosen from the questions array above using index as the index
            question = QuestionsList[index];
            //[[ammar, syed, wasif],[98, 96,99],[boy, boy,boy]]
            Choice1 = (choicesList[index, 0]);
            Choice2 = (choicesList[index, 1]);
            Choice3 = (choicesList[index, 2]);
            Choice4 = (choicesList[index, 3]);

            //Turn the button selected invisible
            num.Visible = false;
            buttonNumCount += 1;

            new GameScreen().Show();
            //this.Hide();
            this.Visible = false;
        }

        private void MenuScreen_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void MenuScreen_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void MenuScreen_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            GameScreen.instance.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
