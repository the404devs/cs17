using System;
using System.Media;
using System.Windows.Forms;

namespace prjICS
{
    public partial class Test : Form
    {
        //Basicly a copy and paste of the lesson form except for minor changes. Any changes will be documented. Otherwise, it is already documented in the lesson form.

        /************
        **Variables**
        ************/

        SoundPlayer player = new SoundPlayer(Properties.Resources.Tough_Guy_Alert___MLBIS);//Initialize the music player
        public static int rightAnswers = 0;
        int question = 1;

        /************
        **Functions**
        ************/

        void toggleMusic()
        {
            if (TitleScreen.music == true)
            {
                pbMusic.Image = Properties.Resources.musicoff;
                TitleScreen.music = false;
                player.Stop();//Stop the music
            }
            else
            {
                pbMusic.Image = Properties.Resources.musicon;
                TitleScreen.music = true;
                player.PlayLooping();//Play the music
            }
        }

        void correctAnswer()
        {
            MessageBox.Show("Correct");
            rightAnswers++;
            question++;
            if (question >= 11)//checks if you went through all 10 questions
            {
                TaskEnd frm = new TaskEnd();
                frm.Show();
                this.Hide();
            }
            else
            {
                loadQuestion(SebnicMenu.unitTestSelected, question);
            }
        }

        void wrongAnswer()
        {
            MessageBox.Show("Incorrect");
            question++;
            if (question >= 11)//checks if you went through all 10 questions
            {
                TaskEnd frm = new TaskEnd();
                frm.Show();
                this.Hide();
            }
            else
            {
                loadQuestion(SebnicMenu.unitTestSelected, question);
            }
        }

        void uncheckButtons()
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        void checkAnswer(RadioButton rb)
        {
            if (rb.Checked == true)
            {
                correctAnswer();
            }
            else
            {
                wrongAnswer();
            }
        }

        void loadQuestion(int unit, int question)//these questions are from the lesson forms.
        {
            if (unit == 1)
            {
                if (question == 1)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "One of the following is not a programming language";
                    rb1.Text = "C#";
                    rb2.Text = "F#";
                    rb3.Text = "Microsoft Word";//Correct
                    rb4.Text = "Java";
                }
                else if (question == 2)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is your teacher's name?";
                    rb1.Text = "Mr. Goodwin";
                    rb2.Text = "Mr. Krnic";//Correct
                    rb3.Text = "Mr. Hajatri";
                    rb4.Text = "Mr. Cacarovski";
                }
                else if (question == 3)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is code?";
                    rb1.Text = "A secret message sent from one computer to another";
                    rb2.Text = "A set of instructions that tell a computer what to do";//Correct
                    rb3.Text = "Numbers";
                    rb4.Text = "The components inside the computer";
                }
                else if (question == 4)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is the difference between markup and programming languages?";
                    rb1.Text = "Programming determines how something looks, \nmarkup determines how it behaves";
                    rb2.Text = "They are the same";
                    rb3.Text = "Markup determines how something looks, \nprogramming determines how it behaves";//Correct
                    rb4.Text = "A programming language is for robots, \nmarkup languages are for computers.";
                }
                else if (question == 5)
                {
                    pbImage.Image = Properties.Resources.filepaths;
                    lblDialogue.Text = "What is the RELATIVE path from 'D:' to 'Infrastructure'?";
                    rb1.Text = "../Data/Final/Infrastructure";
                    rb2.Text = "Landuse/Shapefiles/Final/Infrastructure";
                    rb3.Text = "Data/Final/Infrastructure";//Correct
                    rb4.Text = "D:/Data/Final/Infrastructure";
                }
                else if (question == 6)
                {
                    pbImage.Image = Properties.Resources.filepaths;
                    lblDialogue.Text = "What is the ABOSLUTE path to 'Posters'?";
                    rb1.Text = "../Maps/Posters";
                    rb2.Text = "D:/Data/Shapefiles/Soils";
                    rb3.Text = "D:/Maps/Posters";//Correct
                    rb4.Text = "../../D:/Data/Posters";
                }
                else if (question == 7)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Convert '100101010' from binary to decimal.";
                    rb1.Text = "542";
                    rb2.Text = "562";
                    rb3.Text = "12A";
                    rb4.Text = "298";//Correct
                }
                else if (question == 8)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Convert '10010' from decimal to hex.";
                    rb1.Text = "342";
                    rb2.Text = "271A";//Correct
                    rb3.Text = "12";
                    rb4.Text = "FF";
                }
                else if (question == 9)
                {
                    pbImage.Image = Properties.Resources.css;
                    lblDialogue.Text = "In the image to the left, in what colour is the PROPERTY highlighted?";
                    rb1.Text = "Green";
                    rb2.Text = "Orange";//Correct
                    rb3.Text = "Blue";
                    rb4.Text = "Teal";
                }
                else if (question == 10)
                {
                    pbImage.Image = Properties.Resources.css;
                    lblDialogue.Text = "In the image to the left, in what colour is the VALUE highlighted?";
                    rb1.Text = "Green";
                    rb2.Text = "Orange";
                    rb3.Text = "Blue";
                    rb4.Text = "Teal";//Correct
                }
            }
            else if (unit == 2)
            {
                if (question == 1)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Properties effect the _____ and _____ of a control";
                    rb1.Text = "Event, Code";
                    rb2.Text = "Authouity, Properties";
                    rb3.Text = "Appearance, Behavior";//Correct
                    rb4.Text = "Memory, Computing";
                }
                else if (question == 2)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Properties can be changed during _____ and _____";
                    rb1.Text = "Run Time, Design Time";//Correct
                    rb2.Text = "Launch, Exit";
                    rb3.Text = "Christmas, 1815";
                    rb4.Text = "Noon, Midnight";
                }
                else if (question == 3)
                {
                    pbImage.Image = Properties.Resources.textboxName;
                    lblDialogue.Text = "Given the picture, what is the proper name of the textbox";
                    rb1.Text = "textbox1";
                    rb2.Text = "tbName";
                    rb3.Text = "lblName";
                    rb4.Text = "txtName";//Correct
                }
                else if (question == 4)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What variable type does textbox.Text accept?";
                    rb1.Text = "A Boolean";
                    rb2.Text = "An Int";
                    rb3.Text = "A String";//Correct
                    rb4.Text = "A Double";
                }
                else if (question == 5)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Code in an if statement is only executed when:";
                    rb1.Text = "The Condition Is False";
                    rb2.Text = "The Condition Is True";//Correct
                    rb3.Text = "The Condition Is Sort Of True";
                    rb4.Text = "It Is Always Executed";
                }
                else if (question == 6)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Will the if statement be executed?  If ((10 * 4) / 2 < 17)";
                    rb1.Text = "Yes";
                    rb2.Text = "No";//Correct
                    rb3.Text = "Maybe";
                    rb4.Text = "I'm Stumped";
                }
                else if (question == 7)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Will the if statement be executed?  If ((40 * 3) / 2 <= 360 / 6 && 32 – 4 > 63 / 3)";
                    rb1.Text = "Yes";//Correct
                    rb2.Text = "No";
                    rb3.Text = "Maybe";
                    rb4.Text = "I'm Stumped";
                }
                else if (question == 8)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Will the code in the if statement be executed?  If ((245 / 5) / 7 == 9 / 3 + 4 || 5 – 2 < 78 – 70 && 96 * 0 + 2 == (5 – 4) * 2)";
                    rb1.Text = "Yes";
                    rb2.Text = "No";//Correct
                    rb3.Text = "Maybe";
                    rb4.Text = "I'm Stumped";
                }
                else if (question == 9)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "How many times will this for loop iterate: for (int x=7; x<3 ; x -= 1)";
                    rb1.Text = "0 Times";//Correct
                    rb2.Text = "4 Times";
                    rb3.Text = "5 Times";
                    rb4.Text = "Infinite Times";
                }
                else if (question == 10)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "How many times will this for loop iterate: for (int x=0; x < 2 * 2 * 2 ; x++)";
                    rb1.Text = "4 Times";
                    rb2.Text = "8 Times";//Correct
                    rb3.Text = "2 times";
                    rb4.Text = "Infinite Times";
                }
            }
            else if (unit == 3)
            {
                if (question == 1)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What Does PDT Stand for?";
                    rb1.Text = "Programming Data Transfer";
                    rb2.Text = "Point Data Table";
                    rb3.Text = "Problem Definition Table";//this one.
                    rb4.Text = "Pretty Dumb Thing";
                }
                else if (question == 2)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What’s the first step in the Software Development Cycle?";
                    rb1.Text = "Create Algorithm";
                    rb2.Text = "Identify the Problem ";//this one
                    rb3.Text = "Implement the Algorithm";
                    rb4.Text = "Maintenance";
                }
                else if (question == 3)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What does IPO Stand for?";
                    rb1.Text = "Inside Present Outside";
                    rb2.Text = "Integrated Percentage Output";
                    rb3.Text = "Input Processing Output";//this one
                    rb4.Text = "Industrial Pollution Omitted";
                }
                else if (question == 4)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Which column is used for equations?";
                    rb1.Text = "Input";
                    rb2.Text = "Processing";//this one
                    rb3.Text = "Output";
                    rb4.Text = "No equations required.";
                }
                else if (question == 5)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "In a flowchart, what shape is used for multiple outcomes?";
                    rb1.Text = "Parallelogram";
                    rb2.Text = "Diamond";//this one
                    rb3.Text = " Rectangle";
                    rb4.Text = "Oval";
                }
                else if (question == 6)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "True or False: Pseudocode is the same as C#.";
                    rb1.Text = " True";
                    rb2.Text = "False";//this one
                    rb3.Text = "random garbage";
                    rb4.Text = "random garbage";
                }
                else if (question == 7)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Why is internet piracy considered illegal?";
                    rb1.Text = "It’s considered stealing over the internet.";//this one
                    rb2.Text = "It’s illegal to be a pirate. ARRGH!";
                    rb3.Text = "It is not considered a crime.";
                    rb4.Text = "It is not considered a crime.";
                }
                else if (question == 8)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is the basic definition of hacking?";
                    rb1.Text = "Obtaining cheat codes for video games";
                    rb2.Text = "Gaining unauthorized access to a computer."; ;//this one.
                    rb3.Text = "Stealing someone’s USB.";
                    rb4.Text = "Looking through security cameras.";
                }
                else if (question == 9)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Which of these careers can you get into with a degree in Computer Science?";
                    rb1.Text = "Software Engineer.";
                    rb2.Text = "Systems Analyst.";
                    rb3.Text = "Web developer";
                    rb4.Text = "All of the Above.";//this one
                }
                else if (question == 10)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is e-waste?";
                    rb1.Text = "Digitally removing old files from your computer.";
                    rb2.Text = "Throwing out your computer.";
                    rb3.Text = "Re-using components of electronics for future life.";//this one.
                    rb4.Text = "Removing Hard Drive from computer.";
                }
            }
            else if (unit == 4)
            {
                if (question == 1)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What does a scope of a variable determine?";
                    rb1.Text = "Its accessibility.";//this one.
                    rb2.Text = "How Large the variable is.";
                    rb3.Text = "The type";
                    rb4.Text = "None of the Above.";
                }
                else if (question == 2)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is a variable's scope normally limited to?";
                    rb1.Text = "Its Value";
                    rb2.Text = "Its Block";//this one
                    rb3.Text = "Whether or not it is a Boolean";
                    rb4.Text = "If it's a int or a double.";
                }
                else if (question == 3)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is Modular Programming?";
                    rb1.Text = "A method for modding games.";
                    rb2.Text = "A method for reusing blocks of code.";//this one
                    rb3.Text = "A method for solving Algorithms.";
                    rb4.Text = "A method to average the sum of numbers.";
                }
                else if (question == 4)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is a benefit of Modular Programming?";
                    rb1.Text = "Efficient programming";
                    rb2.Text = "Code is more readable and easier to understand";
                    rb3.Text = "Smaller file size, therefore faster";
                    rb4.Text = "All of the above.";//this one
                }
                else if (question == 5)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Which of these String Functions doesn't exist?";
                    rb1.Text = "Compare";
                    rb2.Text = "Concat";
                    rb3.Text = "ToUpper";
                    rb4.Text = "LowerLetters";//this one
                }
                else if (question == 6)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "Let's use the word 'Computerized.' Using the function, IndexOf('e',5) will return:";
                    rb1.Text = "1";
                    rb2.Text = "6";//this one
                    rb3.Text = "10";
                    rb4.Text = "e";
                }
                else if (question == 7)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is a Base case?";
                    rb1.Text = "A function calling itself.";
                    rb2.Text = "Case in a recursive function where the function is not called.";//this one
                    rb3.Text = "A case where the base value is doubled.";
                    rb4.Text = "A case where the base value is halved.";
                }
                else if (question == 8)
                {
                    pbImage.Image = Properties.Resources.lesson4q5;
                    lblDialogue.Text = "After going through this loop, What will p1(5) equal? ";
                    rb1.Text = "3.";//this one
                    rb2.Text = "4.";
                    rb3.Text = "5";
                    rb4.Text = "0.";
                }
                else if (question == 9)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What are arrays?";
                    rb1.Text = "Functions that calls itself.";
                    rb2.Text = "A data structure, which can store a fixed-size \ncollection of elements of the same data type.";//this one
                    rb3.Text = "A collection of functions with several parameters.";
                    rb4.Text = "A combination of all variable types. (int, string, double, boolean)";
                }
                else if (question == 10)
                {
                    pbImage.Image = null;
                    lblDialogue.Text = "What is bubble sorting?";
                    rb1.Text = "Sorting bubbles.";
                    rb2.Text = "Putting a list of values in a sequential order.";//this one
                    rb3.Text = "Outputting the highest and lowest numbers.";
                    rb4.Text = "Another term for an 'array'.";
                }
            }
        }
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            if (TitleScreen.music == true)//Check if the music was already playing
            {
                pbMusic.Image = Properties.Resources.musicon;
                player.Stop();//Stop the current music, play the music for this form
                player.PlayLooping();
            }
            else
            {
                pbMusic.Image = Properties.Resources.musicoff;
            }
            uncheckButtons();
            lblUnitTest.Text = "Unit " + SebnicMenu.unitTestSelected + " Test";//shows what unit test you are being tested on
            lblName.Text = TitleScreen.playerName;
            question = 1;
            rightAnswers = 0;
            loadQuestion(SebnicMenu.unitTestSelected, question);
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            if (SebnicMenu.unitTestSelected == 1)
            {
                if (question == 1)
                {
                    checkAnswer(rb3);
                }
                else if (question == 2)
                {
                    checkAnswer(rb2);
                }
                else if (question == 3)
                {
                    checkAnswer(rb2);
                }
                else if (question == 4)
                {
                    checkAnswer(rb3);
                }
                else if (question == 5)
                {
                    checkAnswer(rb3);
                }
                else if (question == 6)
                {
                    checkAnswer(rb3);
                }
                else if (question == 7)
                {
                    checkAnswer(rb4);
                }
                else if (question == 8)
                {
                    checkAnswer(rb2);
                }
                else if (question == 9)
                {
                    checkAnswer(rb2);
                }
                else if (question == 10)
                {
                    checkAnswer(rb4);
                }
            }
            else if (SebnicMenu.unitTestSelected == 2)
            {
                if (question == 1)
                {
                    checkAnswer(rb3);
                }
                else if (question == 2)
                {
                    checkAnswer(rb1);
                }
                else if (question == 3)
                {
                    checkAnswer(rb4);
                }
                else if (question == 4)
                {
                    checkAnswer(rb3);
                }
                else if (question == 5)
                {
                    checkAnswer(rb2);
                }
                else if (question == 6)
                {
                    checkAnswer(rb2);
                }
                else if (question == 7)
                {
                    checkAnswer(rb1);
                }
                else if (question == 8)
                {
                    checkAnswer(rb2);
                }
                else if (question == 9)
                {
                    checkAnswer(rb1);
                }
                else if (question == 10)
                {
                    checkAnswer(rb2);
                }
            }
            if (SebnicMenu.unitTestSelected == 3)
            {
                if (question == 1)
                {
                    checkAnswer(rb3);
                }
                else if (question == 2)
                {
                    checkAnswer(rb2);
                }
                else if (question == 3)
                {
                    checkAnswer(rb3);
                }
                else if (question == 4)
                {
                    checkAnswer(rb2);
                }
                else if (question == 5)
                {
                    checkAnswer(rb2);
                }
                else if (question == 6)
                {
                    checkAnswer(rb2);
                }
                else if (question == 7)
                {
                    checkAnswer(rb1);
                }
                else if (question == 8)
                {
                    checkAnswer(rb2);
                }
                else if (question == 9)
                {
                    checkAnswer(rb4);
                }
                else if (question == 10)
                {
                    checkAnswer(rb3);
                }
            }
            if (SebnicMenu.unitTestSelected == 4)
            {
                if (question == 1)
                {
                    checkAnswer(rb1);
                }
                else if (question == 2)
                {
                    checkAnswer(rb2);
                }
                else if (question == 3)
                {
                    checkAnswer(rb2);
                }
                else if (question == 4)
                {
                    checkAnswer(rb4);
                }
                else if (question == 5)
                {
                    checkAnswer(rb4);
                }
                else if (question == 6)
                {
                    checkAnswer(rb2);
                }
                else if (question == 7)
                {
                    checkAnswer(rb2);
                }
                else if (question == 8)
                {
                    checkAnswer(rb1);
                }
                else if (question == 9)
                {
                    checkAnswer(rb2);
                }
                else if (question == 10)
                {
                    checkAnswer(rb2);
                }
            }
            uncheckButtons();
        }

        private void pbMusic_Click(object sender, EventArgs e)
        {
            toggleMusic();
        }
    }
}
