using System;
using System.Media;
using System.Windows.Forms;

namespace prjICS
{
    public partial class Lesson : Form
    {
        /************
        **Variables**
        ************/
        SoundPlayer player = new SoundPlayer(Properties.Resources.Oki_Doki___MLBIS);//Initialize the music player
        public static int rightAnswers = 0;//number of correct answers
        int question = 1;//determines what question you are on

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

        void correctAnswer()//on correct answer
        {
            MessageBox.Show("Correct");
            rightAnswers++;
            question++;
            if (question >= 6)//checks if you went through all 5 questions
            {
                //changes form to the TaskEnd form
                TaskEnd frm = new TaskEnd();
                frm.Show();
                this.Hide();
            }            
            else
            {
                //this function will load the next question
                loadQuestion(SebnicMenu.currentUnitTab, SebnicMenu.lessonNum, question);
            }
        }

        void wrongAnswer()//on wrong answer
        {
            MessageBox.Show("Incorrect");
            question++;
            if (question >= 6)//CheckState if you went through all 5 questions
            {
                //changes form to the TaskEnd form
                TaskEnd frm = new TaskEnd();
                frm.Show();
                this.Hide();
            }
            else
            {
                //this function will load the next question
                loadQuestion(SebnicMenu.currentUnitTab, SebnicMenu.lessonNum, question);
            }
        }

        void uncheckButtons()//unchecks all the radio buttons
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        void checkAnswer(RadioButton rb)//this function checks if the radio button parameter had been checked or not
        {
            if (rb.Checked == true)
            {
                //function for the correct answer
                correctAnswer();
            }
            else
            {
                //function for the wrong answer
                wrongAnswer();
            }
        }

        void loadQuestion(int unit, int lesson, int question)
        {
            uncheckButtons();
            if (unit == 1)//this function will load the next question depending on the unit number, the lesson selected, and what question it is.
            {
                if (lesson == 1)//UNIT 1 LESSON 1
                {
                    if (question == 1)//UNIT 1 LESSON 1 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What will you NOT be learning in Computer Science?";
                        rb1.Text = "Basic programming with C#, HTML";
                        rb2.Text = "How to build a computer";//Correct
                        rb3.Text = "Ethical use of computers";
                        rb4.Text = "Problem solving, practical applications of computers in society.";
                    }
                    else if (question == 2)//UNIT 1 LESSON 1 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "One of the following is not a programming language";
                        rb1.Text = "C#";
                        rb2.Text = "F#";
                        rb3.Text = "Microsoft Word";//Correct
                        rb4.Text = "Java";
                    }
                    else if (question == 3)//UNIT 1 LESSON 1 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How much of your course mark is your final project worth?";
                        rb1.Text = "15%";//Correct
                        rb2.Text = "100%";
                        rb3.Text = "30%";
                        rb4.Text = "5%";
                    }
                    else if (question == 4)//UNIT 1 LESSON 1 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is your teacher's name?";
                        rb1.Text = "Mr. Goodwin";
                        rb2.Text = "Mr. Krnic";//Correct
                        rb3.Text = "Mr. Hajatri";
                        rb4.Text = "Mr. Cacarovski";
                    }
                    else if (question == 5)//UNIT 1 LESSON 1 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Are you going to do well in this course?";
                        rb1.Text = "Yes";//Correct
                        rb2.Text = "No";
                        rb3.Text = "No";
                        rb4.Text = "No";
                    }
                }
                else if (lesson == 2)//UNIT 1 LESSON 2
                {
                    if (question == 1)//UNIT 1 LESSON 2 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is code?";
                        rb1.Text = "A secret message sent from one computer to another";
                        rb2.Text = "A set of instructions that tell a computer what to do";//Correct
                        rb3.Text = "Numbers";
                        rb4.Text = "The components inside the computer";
                    }
                    else if (question == 2)//UNIT 1 LESSON 2 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is the difference between markup and programming languages?";
                        rb1.Text = "Programming determines how something looks, \nmarkup determines how it behaves";
                        rb2.Text = "They are the same";
                        rb3.Text = "Markup determines how something looks, \nprogramming determines how it behaves";//Correct
                        rb4.Text = "A programming language is for robots, \nmarkup languages are for computers.";
                    }
                    else if (question == 3)//UNIT 1 LESSON 2 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What HTML tag will insert a horizontal line?";
                        rb1.Text = "<hr>";//Correct
                        rb2.Text = "<br>";
                        rb3.Text = "<h2>";
                        rb4.Text = "<line>";
                    }
                    else if (question == 4)//UNIT 1 LESSON 2 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What HTML tag will create a link to another file?";
                        rb1.Text = "<link>";
                        rb2.Text = "<img>";
                        rb3.Text = "<b>";
                        rb4.Text = "<a>";//Correct
                    }
                    else if (question == 5)//UNIT 1 LESSON 2 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What file extension is given to webpage files?";
                        rb1.Text = ".docx";
                        rb2.Text = ".exe";
                        rb3.Text = ".html";//Correct
                        rb4.Text = ".bat";
                    }
                }
                else if (lesson == 3)//UNIT 1 LESSON 3
                {
                    if (question == 1)//UNIT 1 LESSON 3 QUESTION 1
                    {
                        pbImage.Image = Properties.Resources.filepaths;
                        lblDialogue.Text = "What is the difference between relative and absolute paths?";
                        rb1.Text = "Absolute are for PCs, relative paths are for Macs";
                        rb2.Text = "Relative paths always start with the drive letter (C:/, D:/, etc.)";
                        rb3.Text = "Relative paths are relative to the file accepting the path";//Correct
                        rb4.Text = "Absolute paths are relative to the file accepting the path";
                    }
                    else if (question == 2)//UNIT 1 LESSON 3 QUESTION 2
                    {
                        pbImage.Image = Properties.Resources.filepaths;
                        lblDialogue.Text = "What is the RELATIVE path from 'Base' to 'Soils'?";
                        rb1.Text = "../Shapefiles/Soils";//Correct
                        rb2.Text = "D:/Data/Shapefiles/Soils";
                        rb3.Text = "D:/Maps/Posters/Soils";
                        rb4.Text = "../../Shapefiles/Soils";
                    }
                    else if (question == 3)//UNIT 1 LESSON 3 QUESTION 3
                    {
                        pbImage.Image = Properties.Resources.filepaths;
                        lblDialogue.Text = "What is the ABOSLUTE path to 'Posters'?";
                        rb1.Text = "../Maps/Posters";
                        rb2.Text = "D:/Data/Shapefiles/Soils";
                        rb3.Text = "D:/Maps/Posters";//Correct
                        rb4.Text = "../../D:/Data/Posters";
                    }
                    else if (question == 4)//UNIT 1 LESSON 3 QUESTION 4
                    {
                        pbImage.Image = Properties.Resources.filepaths;
                        lblDialogue.Text = "What is the ABOSLUTE path to 'Posters'?";
                        rb1.Text = "../Maps/Posters";
                        rb2.Text = "D:/Data/Shapefiles/Soils";
                        rb3.Text = "D:/Maps/Posters";//Correct
                        rb4.Text = "../../D:/Data/Posters";
                    }
                    else if (question == 5)//UNIT 1 LESSON 3 QUESTION 5
                    {
                        pbImage.Image = Properties.Resources.filepaths;
                        lblDialogue.Text = "What is the RELATIVE path from 'D:' to 'Infrastructure'?";
                        rb1.Text = "../Data/Final/Infrastructure";
                        rb2.Text = "Landuse/Shapefiles/Final/Infrastructure";
                        rb3.Text = "Data/Final/Infrastructure";//Correct
                        rb4.Text = "D:/Data/Final/Infrastructure";
                    }
                }
                else if (lesson == 4)//UNIT 1 LESSON 4
                {
                    if (question == 1)//UNIT 1 LESSON 4 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many digits are there in the binary number system?";
                        rb1.Text = "10";
                        rb2.Text = "2";//Correct
                        rb3.Text = "1";
                        rb4.Text = "11";
                    }
                    else if (question == 2)//UNIT 1 LESSON 4 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many digits are there in the hexadecimal number system?";
                        rb1.Text = "6";
                        rb2.Text = "2";
                        rb3.Text = "15";//Correct
                        rb4.Text = "18";
                    }
                    else if (question == 3)//UNIT 1 LESSON 4 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Convert '9C' from hex to binary.";
                        rb1.Text = "10011100";//Correct
                        rb2.Text = "156";
                        rb3.Text = "10011101";
                        rb4.Text = "912";
                    }
                    else if (question == 4)//UNIT 1 LESSON 4 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Convert '100101010' from binary to decimal.";
                        rb1.Text = "542";
                        rb2.Text = "562";
                        rb3.Text = "12A";
                        rb4.Text = "298";//Correct
                    }
                    else if (question == 5)//UNIT 1 LESSON 4 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Convert '10010' from decimal to hex.";
                        rb1.Text = "342";
                        rb2.Text = "271A";//Correct
                        rb3.Text = "12";
                        rb4.Text = "FF";
                    }
                }
                else if (lesson == 5)//UNIT 1 LESSON 5
                {
                    if (question == 1)//UNIT 1 LESSON 5 QUESTION 1
                    {

                        pbImage.Image = Properties.Resources.css;
                        lblDialogue.Text = "What html tag is used to embed CSS?";
                        rb1.Text = "<body>";
                        rb2.Text = "<style>";//Correct
                        rb3.Text = "<css>";
                        rb4.Text = "<embed>";

                    }
                    else if (question == 2)//UNIT 1 LESSON 5 QUESTION 2
                    {
                        pbImage.Image = Properties.Resources.css;
                        lblDialogue.Text = "In the image to the left, in what colour is the SELECTOR highlighted?";
                        rb1.Text = "Green";//Correct
                        rb2.Text = "Orange";
                        rb3.Text = "Blue";
                        rb4.Text = "Teal";
                    }
                    else if (question == 3)//UNIT 1 LESSON 5 QUESTION 3
                    {
                        pbImage.Image = Properties.Resources.css;
                        lblDialogue.Text = "In the image to the left, in what colour is the PROPERTY highlighted?";
                        rb1.Text = "Green";
                        rb2.Text = "Orange";//Correct
                        rb3.Text = "Blue";
                        rb4.Text = "Teal";
                    }
                    else if (question == 4)//UNIT 1 LESSON 5 QUESTION 4
                    {
                        pbImage.Image = Properties.Resources.css;
                        lblDialogue.Text = "In the image to the left, in what colour is the VALUE highlighted?";
                        rb1.Text = "Green";
                        rb2.Text = "Orange";
                        rb3.Text = "Blue";
                        rb4.Text = "Teal";//Correct
                    }
                    else if (question == 5)//UNIT 1 LESSON 5 QUESTION 5
                    {
                        pbImage.Image = Properties.Resources.css;
                        lblDialogue.Text = "In the image at left, what HTML object is being affected by the CSS code?";
                        rb1.Text = "Header";//Correct
                        rb2.Text = "Paragraph";
                        rb3.Text = "Image";
                        rb4.Text = "Link";
                    }
                }
            }
            else if (unit == 2)
            {
                if (lesson == 1)
                {
                    if (question == 1)//UNIT 2 LESSON 1 QUESTION 1
                    {
                        pbImage.Image = Properties.Resources.solutionsExplorer;
                        lblDialogue.Text = "Given the picture, what is the name of this component?";
                        rb1.Text = "Properties Window";
                        rb2.Text = "Solutions Explorer";//Correct
                        rb3.Text = "Toolbox";
                        rb4.Text = "Form";
                    }
                    else if (question == 2)//UNIT 2 LESSON 1 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Properties effect the _____ and _____ of a control";
                        rb1.Text = "Event, Code";
                        rb2.Text = "Authouity, Properties";
                        rb3.Text = "Appearance, Behavior";//Correct
                        rb4.Text = "Memory, Computing";
                    }
                    else if (question == 3)//UNIT 2 LESSON 1 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Properties can be changed during _____ and _____";
                        rb1.Text = "Run Time, Design Time";//Correct
                        rb2.Text = "Launch, Exit";
                        rb3.Text = "Christmas, 1815";
                        rb4.Text = "Noon, Midnight";
                    }
                    else if (question == 4)//UNIT 2 LESSON 1 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What property will make a control invisible?";
                        rb1.Text = "Locked";
                        rb2.Text = "Font";
                        rb3.Text = "Visible";//Correct
                        rb4.Text = "Enabled";
                    }
                    else if (question == 5)//UNIT 2 LESSON 1 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "To execute code, the code must be written in _____";
                        rb1.Text = "Visual Basic";
                        rb2.Text = "A Design Window";
                        rb3.Text = "Visual Studio";
                        rb4.Text = "An Event Function";//Correct
                    }
                }
                else if (lesson == 2)
                {
                    if (question == 1)//UNIT 2 LESSON 2 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is not a variable type?: string int boolean double font…";
                        rb1.Text = "String";
                        rb2.Text = "Double";
                        rb3.Text = "Font";//Correct
                        rb4.Text = "Int";
                    }
                    else if (question == 2)//UNIT 2 LESSON 2 QUESTION 2
                    {
                        pbImage.Image = Properties.Resources.textboxName;
                        lblDialogue.Text = "Given the picture, what is the proper name of the textbox";
                        rb1.Text = "textbox1";
                        rb2.Text = "tbName";
                        rb3.Text = "lblName";
                        rb4.Text = "txtName";//Correct
                    }
                    else if (question == 3)//UNIT 2 LESSON 2 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What can be used to change a variable type to a different type?";
                        rb1.Text = "An Event";
                        rb2.Text = "A Loop";
                        rb3.Text = "A Function";
                        rb4.Text = "The Convert Object";//Correct
                    }
                    else if (question == 4)//UNIT 2 LESSON 2 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What variable type does textbox.Text accept?";
                        rb1.Text = "A Boolean";//Correct
                        rb2.Text = "An Int";
                        rb3.Text = "A String";
                        rb4.Text = "A Double";
                    }
                    else if (question == 5)//UNIT 2 LESSON 2 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What variable type does radiobutton.Checked accept?";
                        rb1.Text = "A Boolean";
                        rb2.Text = "An Int";
                        rb3.Text = "A String";//Correct
                        rb4.Text = "A Double";
                    }
                }
                else if (lesson == 3)//UNIT 2 LESSON 3 QUESTION 1
                {
                    if (question == 1)
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Code in an if statement is only executed when:";
                        rb1.Text = "The Condition Is False";
                        rb2.Text = "The Condition Is True";//Correct
                        rb3.Text = "The Condition Is Sort Of True";
                        rb4.Text = "It Is Always Executed";
                    }
                    else if (question == 2)//UNIT 2 LESSON 3 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the if statement be executed?  If (20 – 2 == 18)";
                        rb1.Text = "Yes";//Correct
                        rb2.Text = "No";
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                    else if (question == 3)//UNIT 2 LESSON 3 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the if statement be executed?  If (25 * 5 >= 100)";
                        rb1.Text = "Yes";//Correct
                        rb2.Text = "No";
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                    else if (question == 4)//UNIT 2 LESSON 3 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the if statement be executed?  If ((10 * 4) / 2 < 17)";
                        rb1.Text = "Yes";
                        rb2.Text = "No";//Correct
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                    else if (question == 5)//UNIT 2 LESSON 3 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the if statement be executed?  If (20 + 30 – 10 + 40 != 35 -15 + 55 + 5)";
                        rb1.Text = "Yes";
                        rb2.Text = "No";//Correct
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                }
                else if (lesson == 4)//UNIT 2 LESSON 4 QUESTION 1
                {
                    if (question == 1)
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the if statement be executed?  If(1 + 4 == 5 || 15 – 5 != 10)";
                        rb1.Text = "Yes";//Correct
                        rb2.Text = "No";
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                    else if (question == 2)//UNIT 2 LESSON 4 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the if statement be executed?  If ((30 - 25) * 6 >= 35 || 20 + (2 * 4) == 26)";
                        rb1.Text = "Yes";
                        rb2.Text = "No";//Correct
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                    else if (question == 3)//UNIT 2 LESSON 4 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the if statement be executed?  If ((4 * (2-2) == 24 – (12 * 2) && 69 – 69 + 1 == 2 – 2)";
                        rb1.Text = "Yes";
                        rb2.Text = "No";//Correct
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                    else if (question == 4)//UNIT 2 LESSON 4 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the if statement be executed?  If ((40 * 3) / 2 <= 360 / 6 && 32 – 4 > 63 / 3)";
                        rb1.Text = "Yes";//Correct
                        rb2.Text = "No";
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                    else if (question == 5)//UNIT 2 LESSON 4 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Will the code in the if statement be executed?  If ((245 / 5) / 7 == 9 / 3 + 4 || 5 – 2 < 78 – 70 && 96 * 0 + 2 == (5 – 4) * 2)";
                        rb1.Text = "Yes";
                        rb2.Text = "No";//Correct
                        rb3.Text = "Maybe";
                        rb4.Text = "I'm Stumped";
                    }
                }
                else if (lesson == 5)
                {
                    if (question == 1)//UNIT 2 LESSON 5 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many times will this for loop iterate\n for (int x=0; x<3 ; x++) 3 times";
                        rb1.Text = "3 Times";//Correct
                        rb2.Text = "2 Times";
                        rb3.Text = "6 Times";
                        rb4.Text = "Infinite Times";
                    }
                    else if (question == 2)//UNIT 2 LESSON 5 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many times will this for loop iterate\n for (int x=0; x != 7; x += 2)";
                        rb1.Text = "3 Times";
                        rb2.Text = "4 Times";
                        rb3.Text = "1 Time";
                        rb4.Text = "Infinite Times";//Correct
                    }
                    else if (question == 3)//UNIT 2 LESSON 5 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many times will this for loop iterate\n for (int x=2; x * 5 <= 10 ; x++)";
                        rb1.Text = "2 Times";
                        rb2.Text = "0 Times";
                        rb3.Text = "1 Time";//Correct
                        rb4.Text = "Infinite Times";
                    }
                    else if (question == 4)//UNIT 2 LESSON 5 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many times will this for loop iterate\n for (int x=0; x < 2 * 2 * 2 ; x++)";
                        rb1.Text = "4 Times";
                        rb2.Text = "8 Times";//Correct
                        rb3.Text = "2 times";
                        rb4.Text = "Infinite Times";
                    }
                    else if (question == 5)//UNIT 2 LESSON 5 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many times will this for loop iterate\n for (int x=7; x<3 ; x -= 1)";
                        rb1.Text = "0 Times";//Correct
                        rb2.Text = "4 Times";
                        rb3.Text = "5 Times";
                        rb4.Text = "Infinite Times";
                    }
                }
            }
            else if (unit == 3)
            {
                if (lesson == 1)//UNIT 3 LESSON 1
                {
                    if (question == 1)//UNIT 3 LESSON 1 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What Does PDT Stand for?";
                        rb1.Text = "Programming Data Transfer";
                        rb2.Text = "Point Data Table";
                        rb3.Text = "Problem Definition Table";//this one.
                        rb4.Text = "Pretty Dumb Thing";

                    }
                    else if (question == 2)//UNIT 3 LESSON 1 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Which of these is not a column in a PDT?";
                        rb1.Text = "Data Gathered";//this one
                        rb2.Text = "Known Facts";
                        rb3.Text = "User Requirements";
                        rb4.Text = "Necessary Processing";
                    }
                    else if (question == 3)//UNIT 3 LESSON 1 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What’s the first step in the Software Development Cycle?";
                        rb1.Text = "Create Algorithm";
                        rb2.Text = "Identify the Problem ";//this one
                        rb3.Text = "Implement the Algorithm";
                        rb4.Text = "Maintenance";

                    }
                    else if (question == 4)//UNIT 3 LESSON 1 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "The population of a city is 500 000 and increases at a rate of 6% annually. It needs to be calculated for how many years it will take till the population exceeds 1 million. From the information given, which of the following is a KNOWN FACT?  ";
                        rb1.Text = "The rate of increase";
                        rb2.Text = "The population is 500 000";
                        rb3.Text = "How many years it will take to reach 1 million";
                        rb4.Text = "Both a and b";//this one

                    }
                    else if (question == 5)//UNIT 3 LESSON 1 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Same problem as before: The population of a city is 500 000 and increases at a rate of 6%. It needs to be calculated for how many years it will take till the population exceeds 1 million. From the information given, which of the following is a USER REQUIREMENT?  ";
                        rb1.Text = "The rate of increase";
                        rb2.Text = "The population is 500 000";
                        rb3.Text = "How many years it will take to reach 1 million";//this one
                        rb4.Text = "None of the above.";

                    }
                }
                else if (lesson == 2)//UNIT 3 LESSON 2
                {
                    if (question == 1)//UNIT 3 LESSON 2 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What does IPO Stand for?";
                        rb1.Text = "Inside Present Outside";
                        rb2.Text = "Integrated Percentage Output";
                        rb3.Text = "Input Processing Output";//this one
                        rb4.Text = "Industrial Pollution Omitted";
                    }
                    else if (question == 2)//UNIT 3 LESSON 2 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Which column is used for equations?";
                        rb1.Text = "Input";
                        rb2.Text = "Processing";//this one
                        rb3.Text = "Output";
                        rb4.Text = "No equations required.";
                    }
                    else if (question == 3)//UNIT 3 LESSON 2 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "If a user inputs 50 and the program makes the number multiplied by 2, the output will be?";
                        rb1.Text = "50 50";
                        rb2.Text = "100";//this one
                        rb3.Text = "25";
                        rb4.Text = "IT'S OVER 9000!";

                    }
                    else if (question == 4)//UNIT 3 LESSON 2 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "If the number outputted was 500 and the processing was to divide the number by 4, the inputted number was:";
                        rb1.Text = "125";
                        rb2.Text = "250";
                        rb3.Text = "500";
                        rb4.Text = "2000";//this one
                    }
                    else if (question == 5)//UNIT 3 LESSON 2 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "You input 100. The output was 1000. What are the possible equations for processing?";
                        rb1.Text = "+ 900";
                        rb2.Text = " x 10";
                        rb3.Text = " - 900";
                        rb4.Text = "both a and b";//this one
                    }
                }
                else if (lesson == 3)//UNIT 3 LESSON 3
                {
                    if (question == 1)//UNIT 3 LESSON 3 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "In a flowchart, what shape is used for multiple outcomes?";
                        rb1.Text = "Parallelogram";
                        rb2.Text = "Diamond";//this one
                        rb3.Text = " Rectangle";
                        rb4.Text = "Oval";
                    }
                    else if (question == 2)//UNIT 3 LESSON 3 QUESTION 2
                    {
                        pbImage.Image = Properties.Resources.Oval;//this will be an image of an oval
                        lblDialogue.Text = "What does this shape represent in a flowchart";
                        rb1.Text = "Indicates Start and Finish.";//this one
                        rb2.Text = "Calculations/Processing";
                        rb3.Text = " Input/Output";
                        rb4.Text = "Multiple outcomes";
                    }
                    else if (question == 3)//UNIT 3 LESSON 3 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "True or False: Pseudocode is the same as C#.";
                        rb1.Text = " True";
                        rb2.Text = "False";//this one
                        rb3.Enabled = false;
                        rb4.Enabled = false;
                        rb3.Text = "";
                        rb4.Text = "";
                    }
                    else if (question == 4)//UNIT 3 LESSON 3 QUESTION 4
                    {
                        rb3.Enabled = true;
                        rb4.Enabled = true;
                        pbImage.Image = null;
                        lblDialogue.Text = "Which of these is not used for Output in Pseudocode?";
                        rb1.Text = "Write";
                        rb2.Text = "Display";
                        rb3.Text = "Print";
                        rb4.Text = "Read";//this one
                    }
                    else if (question == 5)//UNIT 3 LESSON 3 QUESTION 5
                    {
                        pbImage.Image = null;
                        rb3.Enabled = true;
                        rb4.Enabled = true;
                        pbImage.Image = null;
                        lblDialogue.Text = "Which of these is not used for Input in Pseudocode?";
                        rb1.Text = "Input";
                        rb2.Text = "Get";
                        rb3.Text = "Print";//this one
                        rb4.Text = "Read";

                    }
                }
                else if (lesson == 4)//UNIT 3 LESSON 4
                {
                    if (question == 1)//UNIT 3 LESSON 4 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Why is internet piracy considered illegal?";
                        rb1.Text = "It’s considered stealing over the internet.";//this one
                        rb2.Text = "It’s illegal to be a pirate. ARRGH!";
                        rb3.Text = "It is not considered a crime.";
                        rb4.Text = "It is not considered a crime.";

                    }
                    else if (question == 2)//UNIT 3 LESSON 4 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Internet piracy is no different than stealing from stores. Why do people not steal from stores?";
                        rb1.Text = "Different type of offense.";
                        rb2.Text = "It’s indirect.";
                        rb3.Text = "It’s easier to get caught.";//this one.
                        rb4.Text = "None of the Above.";

                    }
                    else if (question == 3)//UNIT 3 LESSON 4 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is the basic definition of hacking?";
                        rb1.Text = "Obtaining cheat codes for video games";
                        rb2.Text = "Gaining unauthorized access to a computer."; ;//this one.
                        rb3.Text = "Stealing someone’s USB.";
                        rb4.Text = "Looking through security cameras.";
                    }
                    else if (question == 4)//UNIT 3 LESSON 4 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What’s the difference between logic bombs and worms?";
                        rb1.Text = "Worms are viruses that will execute with pre-determined \nconditions and logic bombs are viruses that will replicate itself.";
                        rb2.Text = "Logic Bomb is a bomb that will explode your computer and Worms are \nwhat stop it from exploding.";
                        rb3.Text = "Logic bombs are what destroys logic and worms are critters on the floor.";
                        rb4.Text = "Logic bomb is a virus that will execute with pre-determined \nconditions and worms are viruses that will replicate itself.";//this one.
                    }
                    else if (question == 5)//UNIT 3 LESSON 4 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What steps can be taken to prevent infection by a virus?";
                        rb1.Text = "Anti-Malware Software.";//this one.
                        rb2.Text = "Download Malware.";
                        rb3.Text = "Download another virus.";
                        rb4.Text = "Sell your Computer.";
                    }
                }
                else if (lesson == 5)//UNIT 3 LESSON 5
                {
                    if (question == 1)//UNIT 3 LESSON 5 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "True or False: To get into computer science university, you need 12U Computer Science.";
                        rb1.Text = "True.";
                        rb2.Text = "False."; //this one
                        rb3.Text = "";
                        rb4.Text = "";
                        rb3.Enabled = false;
                        rb4.Enabled = false;

                    }
                    else if (question == 2)//UNIT 3 LESSON 5 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Which of these careers can you get into with a degree in Computer Science?";
                        rb3.Enabled = true;
                        rb4.Enabled = true;
                        rb1.Text = "Software Engineer.";
                        rb2.Text = "Systems Analyst.";
                        rb3.Text = "Web developer";
                        rb4.Text = "All of the Above.";//this one


                    }
                    else if (question == 3)//UNIT 3 LESSON 5 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is a Co-Op placement in University?";
                        rb1.Text = "You buddy up with someone and pass through the semester together.";
                        rb2.Text = "Work in the workforce while in school and earn money.";//this one.
                        rb3.Text = "Work in the workforce while in school, but earn no money.";
                        rb4.Text = "You co-operate and get help from a teacher.";

                    }
                    else if (question == 4)//UNIT 3 LESSON 5 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is e-waste?";
                        rb1.Text = "Digitally removing old files from your computer.";
                        rb2.Text = "Throwing out your computer.";
                        rb3.Text = "Re-using components of electronics for future life.";//this one.
                        rb4.Text = "Removing Hard Drive from computer.";
                    }
                    else if (question == 5)//UNIT 3 LESSON 5 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is Cloud Computing?";
                        rb1.Text = "Using network servers hosted on the internet to store, \nmanage, and process data.";//this one
                        rb2.Text = "Using computers outside of internet access.";
                        rb3.Text = "Using local servers to transfer data.";
                        rb4.Text = "Connecting to someone else’s internet worldwide.";

                    }
                }
            }
            else if (unit == 4)
            {
                if (lesson == 1)//UNIT 4 LESSON 1
                {
                    if (question == 1)//UNIT 4 LESSON 1 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What does a scope of a variable determine?";
                        rb1.Text = "Its accessibility.";//this one.
                        rb2.Text = "How Large the variable is.";
                        rb3.Text = "The type";
                        rb4.Text = "None of the Above.";

                    }
                    else if (question == 2)//UNIT 4 LESSON 1 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is a variable's scope normally limited to?";
                        rb1.Text = "Its Value";
                        rb2.Text = "Its Block";//this one
                        rb3.Text = "Whether or not it is a Boolean";
                        rb4.Text = "If it's a int or a double.";
                    }
                    else if (question == 3)//UNIT 4 LESSON 1 QUESTION 3
                    {
                        pbImage.Image = null;//Display an example here.
                        lblDialogue.Text = "Where is it safe to access the variable 'target?'";
                        rb1.Text = "cMethod";
                        rb2.Text = "bMethod";
                        rb3.Text = "aMethod";
                        rb4.Text = "All of The Above.";//this one

                    }
                    else if (question == 4)//UNIT 4 LESSON 1 QUESTION 4
                    {
                        pbImage.Image = null;//Display an example here.
                        lblDialogue.Text = "In which blanks is it safe to place 'value = 5'";
                        rb1.Text = "A only.";//this one
                        rb2.Text = "B only.";
                        rb3.Text = "C only.";
                        rb4.Text = "Both A and C";

                    }
                    else if (question == 5)//UNIT 4 LESSON 1 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = " If you had a varible 'x' as a local variable AND another 'x' as an instance variable, how would you call the instance one in a function? ";
                        rb1.Text = "x";
                        rb2.Text = "call x";
                        rb3.Text = "MessageBox.Show(x)";
                        rb4.Text = "this.x";//this one

                    }
                }
                else if (lesson == 2)//UNIT 4 LESSON 2
                {
                    if (question == 1)//UNIT 4 LESSON 2 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is Modular Programming?";
                        rb1.Text = "A method for modding games.";
                        rb2.Text = "A method for reusing blocks of code.";//this one
                        rb3.Text = "A method for solving Algorithms.";
                        rb4.Text = "A method to average the sum of numbers.";
                    }
                    else if (question == 2)//UNIT 4 LESSON 2 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is a benefit of Modular Programming?";
                        rb1.Text = "Efficient programming";
                        rb2.Text = "Code is more readable and easier to understand";
                        rb3.Text = "Smaller file size, therefore faster";
                        rb4.Text = "All of the above.";//this one
                    }
                    else if (question == 3)//UNIT 4 LESSON 2 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What are Parameters in a function?";
                        rb1.Text = "The barriers of a function.";
                        rb2.Text = "They are looping functions.";
                        rb3.Text = "They allow a programmer to customize the functionality \nof a function based on the given info.";//this one
                        rb4.Text = "They change values of a function.";

                    }
                    else if (question == 4)//UNIT 4 LESSON 2 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many parameters do you need in a function?";
                        rb1.Text = "1";
                        rb2.Text = "2";
                        rb3.Text = "As many as you need.";//this one
                        rb4.Text = "OVER 9000!";
                    }
                    else if (question == 5)//UNIT 4 LESSON 2 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How many values can be returned from this function?";
                        rb1.Text = "1";//this one
                        rb2.Text = "2";
                        rb3.Text = "900";
                        rb4.Text = "As many as needed";
                    }
                }
                else if (lesson == 3)//UNIT 4 LESSON 3
                {
                    if (question == 1)//UNIT 4 LESSON 3 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Which of these String Functions doesn't exist?";
                        rb1.Text = "Compare";
                        rb2.Text = "Concat";
                        rb3.Text = "ToUpper";
                        rb4.Text = "LowerLetters";//this one
                    }
                    else if (question == 2)//UNIT 4 LESSON 3 QUESTION 2
                    {
                        pbImage.Image = null;//this will be an image of an oval
                        lblDialogue.Text = "In the Function Substring (int, int), what does the first int represent?";
                        rb1.Text = "The length of the characters.";
                        rb2.Text = "Position of the character.";//this one
                        rb3.Text = "How many characters there are total.";
                        rb4.Text = "How many seconds it will take to read the characters.";
                    }
                    else if (question == 3)//UNIT 4 LESSON 3 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "Let's use the word 'Computerized.' Using the function, IndexOf('e',5) will return:";
                        rb1.Text = "1";
                        rb2.Text = "6";//this one
                        rb3.Text = "10";
                        rb4.Text = "e";
                    }
                    else if (question == 4)//UNIT 4 LESSON 3 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "How would the term 'Boolean' look with the function: Insert(3,'t')";
                        rb1.Text = "Bootlean";//this one
                        rb2.Text = "Booltean";
                        rb3.Text = "Booleanttt";
                        rb4.Text = "Botolean";
                    }
                    else if (question == 5)//UNIT 4 LESSON 3 QUESTION 5
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "In the term, 'Recursion', what's the returned value for LastIndexOf('t') ";
                        rb1.Text = "Recurstion";
                        rb2.Text = "4";
                        rb3.Text = "-1";//this one
                        rb4.Text = "1";

                    }
                }
                else if (lesson == 4)//UNIT 4 LESSON 4
                {
                    if (question == 1)//UNIT 4 LESSON 4 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "True or False: Recursion is an algorithm. ";
                        rb1.Text = "True";
                        rb2.Text = "False";//this one
                        rb3.Enabled = false;
                        rb4.Enabled = false;
                        rb3.Text = "";
                        rb4.Text = "";

                    }
                    else if (question == 2)//UNIT 4 LESSON 4 QUESTION 2
                    {
                        pbImage.Image = null;
                        rb3.Enabled = true;
                        rb4.Enabled = true;
                        lblDialogue.Text = "What is a factorial?";
                        rb1.Text = "The product of an integer and all the integers below it.";//this one
                        rb2.Text = "The sum of an integer and all the integers below it.";
                        rb3.Text = "The quotient of an integer and all the integers below it.";
                        rb4.Text = "The difference of an integer and all the integers below it.";

                    }
                    else if (question == 3)//UNIT 4 LESSON 4 QUESTION 3
                    {
                        pbImage.Image = Properties.Resources.lesson4q3;
                        lblDialogue.Text = "Let's trace the code with factorial(5). What will the final result be? ";
                        rb1.Text = "15";
                        rb2.Text = "5";
                        rb3.Text = "120";//this one
                        rb4.Text = "1";
                    }
                    else if (question == 4)//UNIT 4 LESSON 4 QUESTION 4
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is a Base case?";
                        rb1.Text = "A function calling itself.";
                        rb2.Text = "Case in a recursive function where the function is not called.";//this one
                        rb3.Text = "A case where the base value is doubled.";
                        rb4.Text = "A case where the base value is halved.";
                    }
                    else if (question == 5)//UNIT 4 LESSON 4 QUESTION 5
                    {
                        pbImage.Image = Properties.Resources.lesson4q5;
                        lblDialogue.Text = "After going through this loop, What will p1(5) equal? ";
                        rb1.Text = "3.";//this one
                        rb2.Text = "4.";
                        rb3.Text = "5";
                        rb4.Text = "0.";
                    }
                }
                else if (lesson == 5)//UNIT 4 LESSON 5
                {
                    if (question == 1)//UNIT 4 LESSON 5 QUESTION 1
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What are arrays?";
                        rb1.Text = "Functions that calls itself.";
                        rb2.Text = "A data structure, which can store a fixed-size collection \nof elements of the same data type.";//this one
                        rb3.Text = "A collection of functions with several parameters.";
                        rb4.Text = "A combination of all variable types. (int, string, double, boolean)";

                    }
                    else if (question == 2)//UNIT 4 LESSON 5 QUESTION 2
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What type of loop normally goes with arrays?";
                        rb1.Text = "While Loop.";
                        rb2.Text = "Continuous Loop.";
                        rb3.Text = "Do loop.";
                        rb4.Text = "For loop.";//this one

                    }
                    else if (question == 3)//UNIT 4 LESSON 5 QUESTION 3
                    {
                        pbImage.Image = null;
                        lblDialogue.Text = "What is the format for making an array?";
                        rb1.Text = "type name = new type.";
                        rb2.Text = "type[] name = value.";
                        rb3.Text = "type[] name = new type[].";//this one
                        rb4.Text = "type[] name = []value.";
                    }
                    else if (question == 4)//UNIT 4 LESSON 5 QUESTION 4
                    {
                        pbImage.Image = Properties.Resources.lesson5q4;
                        lblDialogue.Text = "What will go in the blank? [_]";
                        rb1.Text = "mass.";
                        rb2.Text = "x.";//this one
                        rb3.Text = "total.";
                        rb4.Text = "length.";
                    }
                    else if (question == 5)//UNIT 4 LESSON 5 QUESTION 5
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
        }

        public Lesson()
        {
            InitializeComponent();
        }

        private void Lesson_Load(object sender, EventArgs e)
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
            lblName.Text = TitleScreen.playerName;//puts the player name into the form
            lblDay.Text = "Day " + Classroom.day;//puts the day number into the form
            lblUnit.Text = "Unit " + SebnicMenu.currentUnitTab;//puts the unit number of this lesson into the form
            lblLesson.Text = "Lesson " + SebnicMenu.lessonNum;//put the lesson number into the form
            question = 1;//sets question to one (ensures that it starts with the first question)
            rightAnswers = 0;//sets the number of rightAnswers for this lesson to 0 because you haven't answered anything for this lesson yet
            loadQuestion(SebnicMenu.currentUnitTab, SebnicMenu.lessonNum, question);//loads the first question of the lesson
            uncheckButtons();//unchecks all radio buttons (one would always be checked otherwise)
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            //determines exactly what question you answered (eg. unit 2 lesson 3 question 4) and checks if you got the question right or not
            if (SebnicMenu.currentUnitTab == 1)
            {
                if (SebnicMenu.lessonNum == 1)//UNIT 1 LESSON 1
                { 
                    if (question == 1)//UNIT 1 LESSON 1 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 1 LESSON 1 QUESTION 2
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 3)//UNIT 1 LESSON 1 QUESTION 3
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 4)//UNIT 1 LESSON 1 QUESTION 4
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 5)//UNIT 1 LESSON 1 QUESTION 5
                    {
                        checkAnswer(rb1);
                    }
                }
                else if (SebnicMenu.lessonNum == 2)//UNIT 1 LESSON 2
                {
                    if (question == 1)//UNIT 1 LESSON 2 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 1 LESSON 2 QUESTION 2
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 3)//UNIT 1 LESSON 2 QUESTION 3
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 4)//UNIT 1 LESSON 2 QUESTION 4
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 5)//UNIT 1 LESSON 2 QUESTION 5
                    {
                        checkAnswer(rb3);
                    }
                }
                else if (SebnicMenu.lessonNum == 3)//UNIT 1 LESSON 3
                {
                    if (question == 1)//UNIT 1 LESSON 3 QUESTION 1
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 2)//UNIT 1 LESSON 3 QUESTION 2
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 3)//UNIT 1 LESSON 3 QUESTION 3
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 4)//UNIT 1 LESSON 3 QUESTION 4
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 5)//UNIT 1 LESSON 3 QUESTION 5
                    {
                        checkAnswer(rb3);
                    }
                }
                else if (SebnicMenu.lessonNum == 4)//UNIT 1 LESSON 4
                {
                    if (question == 1)//UNIT 1 LESSON 4 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 1 LESSON 4 QUESTION 2
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 3)//UNIT 1 LESSON 4 QUESTION 3
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 4)//UNIT 1 LESSON 4 QUESTION 4
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 5)//UNIT 1 LESSON 4 QUESTION 5
                    {
                        checkAnswer(rb2);
                    }
                }
                else if (SebnicMenu.lessonNum == 5)//UNIT 1 LESSON 5
                {
                    if (question == 1)//UNIT 1 LESSON 5 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 1 LESSON 5 QUESTION 2
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 3)//UNIT 1 LESSON 5 QUESTION 3
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 4)//UNIT 1 LESSON 5 QUESTION 4
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 5)//UNIT 1 LESSON 5 QUESTION 5
                    {
                        checkAnswer(rb1);
                    }
                }
            }
            else if (SebnicMenu.currentUnitTab == 2)//UNIT 2
            {
                if (SebnicMenu.lessonNum == 1)//UNIT 2 LESSON 1
                {
                    if (question == 1)//UNIT 2 LESSON 1 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 2 LESSON 1 QUESTION 2
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 3)//UNIT 2 LESSON 1 QUESTION 3
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 4)//UNIT 2 LESSON 1 QUESTION 4
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 5)//UNIT 2 LESSON 1 QUESTION 5
                    {
                        checkAnswer(rb4);
                    }
                }
                else if (SebnicMenu.lessonNum == 2)//UNIT 2 LESSON 2
                {
                    if (question == 1)//UNIT 2 LESSON 2 QUESTION 1
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 2)//UNIT 2 LESSON 2 QUESTION 2
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 3)//UNIT 2 LESSON 2 QUESTION 3
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 4)//UNIT 2 LESSON 2 QUESTION 4
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 5)//UNIT 2 LESSON 2 QUESTION 5
                    {
                        checkAnswer(rb3);
                    }
                }
                else if (SebnicMenu.lessonNum == 3)//UNIT 2 LESSON 3
                {
                    if (question == 1)//UNIT 2 LESSON 3 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 2 LESSON 3 QUESTION 2
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 3)//UNIT 2 LESSON 3 QUESTION 3
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 4)//UNIT 2 LESSON 3 QUESTION 4
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 5)//UNIT 2 LESSON 3 QUESTION 5
                    {
                        checkAnswer(rb2);
                    }
                }
                else if (SebnicMenu.lessonNum == 4)//UNIT 2 LESSON 4
                {
                    if (question == 1)//UNIT 2 LESSON 4 QUESTION 1
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 2)//UNIT 2 LESSON 4 QUESTION 2
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 3)//UNIT 2 LESSON 4 QUESTION 3
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 4)//UNIT 2 LESSON 4 QUESTION 4
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 5)//UNIT 2 LESSON 4 QUESTION 5
                    {
                        checkAnswer(rb2);
                    }
                }
                else if (SebnicMenu.lessonNum == 5)//UNIT 2 LESSON 5
                {
                    if (question == 1)//UNIT 2 LESSON 5 QUESTION 1
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 2)//UNIT 2 LESSON 5 QUESTION 2
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 3)//UNIT 2 LESSON 5 QUESTION 3
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 4)//UNIT 2 LESSON 5 QUESTION 4
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 5)//UNIT 2 LESSON 5 QUESTION 5
                    {
                        checkAnswer(rb1);
                    }
                }
            }
            else if (SebnicMenu.currentUnitTab == 3)
            {
                if (SebnicMenu.lessonNum == 1)//UNIT 3 LESSON 1
                {
                    if (question == 1)//UNIT 3 LESSON 1 QUESTION 1
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 2)//UNIT 3 LESSON 1 QUESTION 2
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 3)//UNIT 3 LESSON 1 QUESTION 3
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 4)//UNIT 3 LESSON 1 QUESTION 4
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 5)//UNIT 3 LESSON 1 QUESTION 5
                    {
                        checkAnswer(rb3);
                    }
                }
                else if (SebnicMenu.lessonNum == 2)//UNIT 3 LESSON 2
                {
                    if (question == 1)//UNIT 3 LESSON 2 QUESTION 1
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 2)//UNIT 3 LESSON 2 QUESTION 2
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 3)//UNIT 3 LESSON 2 QUESTION 3
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 4)//UNIT 3 LESSON 2 QUESTION 4
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 5)//UNIT 3 LESSON 1 QUESTION 5
                    {
                        checkAnswer(rb4);
                    }
                }
                else if (SebnicMenu.lessonNum == 3)//UNIT 3 LESSON 3
                {
                    if (question == 1)//UNIT 3 LESSON 3 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 3 LESSON 3 QUESTION 2
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 3)//UNIT 3 LESSON 3 QUESTION 3
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 4)//UNIT 3 LESSON 3 QUESTION 4
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 5)//UNIT 3 LESSON 3 QUESTION 5
                    {
                        checkAnswer(rb3);
                    }
                }
                else if (SebnicMenu.lessonNum == 4)//UNIT 3 LESSON 4
                {
                    if (question == 1)//UNIT 3 LESSON 4 QUESTION 1
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 2)//UNIT 3 LESSON 4 QUESTION 2
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 3)//UNIT 3 LESSON 4 QUESTION 3
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 4)//UNIT 3 LESSON 4 QUESTION 4
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 5)//UNIT 3 LESSON 4 QUESTION 5
                    {
                        checkAnswer(rb1);
                    }
                }
                else if (SebnicMenu.lessonNum == 5)//UNIT 3 LESSON 5
                {
                    if (question == 1)//UNIT 3 LESSON 5 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 3 LESSON 5 QUESTION 2
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 3)//UNIT 3 LESSON 5 QUESTION 3
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 4)//UNIT 3 LESSON 5 QUESTION 4
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 5)//UNIT 3 LESSON 5 QUESTION 5
                    {
                        checkAnswer(rb1);
                    }
                }
            }
            else if (SebnicMenu.currentUnitTab == 4)
            {
                if (SebnicMenu.lessonNum == 1)//UNIT 4 LESSON 1
                {
                    if (question == 1)//UNIT 4 LESSON 1 QUESTION 1
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 2)//UNIT 4 LESSON 1 QUESTION 2
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 3)//UNIT 4 LESSON 1 QUESTION 3
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 4)//UNIT 4 LESSON 1 QUESTION 4
                    {
                        checkAnswer(rb1);
                    }
                    else if (question == 5)//UNIT 4 LESSON 1 QUESTION 5
                    {
                        checkAnswer(rb4);
                    }
                }
                else if (SebnicMenu.lessonNum == 2)//UNIT 4 LESSON 2
                {
                    if (question == 1)//UNIT 4 LESSON 2 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 4 LESSON 2 QUESTION 2
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 3)//UNIT 4 LESSON 2 QUESTION 3
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 4)//UNIT 4 LESSON 2 QUESTION 4
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 5)//UNIT 4 LESSON 2 QUESTION 5
                    {
                        checkAnswer(rb1);
                    }
                }
                else if (SebnicMenu.lessonNum == 3)//UNIT 4 LESSON 3
                {
                    if (question == 1)//UNIT 4 LESSON 3 QUESTION 1
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 2)//UNIT 4 LESSON 3 QUESTION 2
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 3)//UNIT 4 LESSON 3 QUESTION 3
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 4)//UNIT 4 LESSON 3 QUESTION 4
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 5)//UNIT 4 LESSON 3 QUESTION 5
                    {
                        checkAnswer(rb3);
                    }
                }
                else if (SebnicMenu.lessonNum == 4)//UNIT 4 LESSON 4
                {
                    if (question == 1)//UNIT 4 LESSON 4 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 4 LESSON 4 QUESTION 2
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 3)//UNIT 4 LESSON 4 QUESTION 3
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 4)//UNIT 4 LESSON 4 QUESTION 4
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 5)//UNIT 4 LESSON 4 QUESTION 5
                    {
                        checkAnswer(rb1);
                    }
                }
                else if (SebnicMenu.lessonNum == 5)//UNIT 4 LESSON 5
                {
                    if (question == 1)//UNIT 4 LESSON 5 QUESTION 1
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 2)//UNIT 4 LESSON 5 QUESTION 2
                    {
                        checkAnswer(rb4);
                    }
                    else if (question == 3)//UNIT 4 LESSON 5 QUESTION 3
                    {
                        checkAnswer(rb3);
                    }
                    else if (question == 4)//UNIT 4 LESSON 5 QUESTION 4
                    {
                        checkAnswer(rb2);
                    }
                    else if (question == 5)//UNIT 4 LESSON 1 QUESTION 5
                    {
                        checkAnswer(rb2);
                    }
                }
            }
            uncheckButtons();//unchecks the radio buttons
        }

        private void pbMusic_Click(object sender, EventArgs e)
        {
            toggleMusic();
        }
    }
}
