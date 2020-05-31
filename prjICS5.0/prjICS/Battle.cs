using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace prjICS
{
    public partial class Battle : Form
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.Grand_Finale___MLBIS);//Initialize the music player
        Random r = new Random();
        int completion = 0;//Completion level of assignment, the enemy's "health"
        int sanity = 100;//Sanity of the player, the player's "health"
        int question = 0;//Used to randomly select a question to "attack" the enemy
        int errors = 0;//Total number of build errors (wrong answers)
        double assignmentMark = 0;//Stores the player's mark on the assignment
        Boolean lastKill = false;//Set to true if the final boss has been defeated




        String glitchText = "c̴̨̢̡̡̨̡̨̢̧̡̡̧̨̡̡̨̛͚̣̦͖͉̳̺̖̯̗̹̬̱̲̗͉̠͈̙̬̳̞̥̯̥̮̠̥͚̬̫͓̖̳̱̪̯͈͎̝̬̺̺̻͙̦͈͚̹͔͔̩̜̩͔̪̱̼͖̭̰̘͕̼̲͉̭̤̼̻͚̩͎̤͈̙̻̬̯̼̜̲̮̦̪̗͍̫͔̰̹̘̥̦͉̖̘̘̻̲͉̳̘̤͉̯͇͈͎̜͎͔̻͙̘̱̮͚͎̟̱͇̣̙̖̮̪̮̭̻̲̩͔͍̤̻͈͚͗͛̌̌̐̅̀͑̔̆̿̇̊̇̋̏̔͐̉̀͆̓̓́̆͑̿́̒̆̂̀̾̈́̈͐̾̾̊̽̈́̀̀͊̓́̓͌͂̈́͐̚͘̚͜͜͜͜͜͜͠͝ͅͅͅͅͅơ̶̡̧̡̡̧̢̢̧̛̛̛̛̻̜̖̳̳̦͓̠̘̫̘͎͎̗̻͈̲̩̭̫͙̱̰̳͚̞̙̺̺̝̜͉͍͓̲͎̟̝̳̬̱͚͕̪̝͎̗͇͎͍͖̰͕̦͍̮̬̻̜̦̞͙̗̥͍͓̙̱̖̟̩̮̲̮̟̼͍͔͎̘͓̼̭͕̝͍̻̜̹̖̦̟̙͇̹̥͚͕͍̹̤̞͈̬͓̭̫̼̖̤͈̭̬̠͉̙̩̥̠̬̮̮͚̰̖̫̙̈͌̑͌̏̐̌̋̓͂̈́̏͑̍̊̈̀̒͂̒́̃̒̓͂̇̎̃͒̓͋̃͆̌̇̆̃̎͗̈́͊̍̀̄̿̐́̏͊̈̄̊͒̑͗͌̀̆̊͂͛̐̓̈́̂͆̍̈́́͌̀̄̊́͛͗͒̂̉͗̍̈́̓̇̊̅͂̏̍͆͒͂͗͑͆̌̒̈̽̈́̔́̓̂́̈́̈́́͒̾͗̈̆̾́́̈́̉̿̄̀̐̊̇̽͂̐̾̃̂̃̎͒̅͋̿̾͊͛́͊̎̅̇̎͐̓̐͋̆̔̆̈̈́̀̐̆̉̀̎̆̿̒̆͒̅̅̐̾̉͂̊̇̆̿̄̈̈́͊̍̎̉̑̄̈́͋̉̌̉̆̂̀̉́̂̐͋̇̃̽̍̈̓̓̄̏͑̈́̈́̄́̿́̓̈́̎͑̅̏̈́̓̽̚̚͘͘͘̕̚͘̕͘̕͝͝͝͝͝͠͝͝͝͝͝͠͠͠͠͝͝͠͝ͅͅͅͅͅṃ̴̧̡̧̧̧̡̢̢̨̧̢̢̨̡̛̛̛̛̛̛̛̛͚̼͎̝͍͚̜̼͍͎̙̯͉̙̣͎͎̠͈̱̹̣̤̗͕̪̮̱̱̖̫͓̥͙͚̼̪͚̲͖̪̰͕͎̠̯̳͓͙͇̙̙̱̝͉̥̪͈̺̜̰͚̗̬͓͚̘͇͇̖̻̦̲͙̭̝̟̰͔̻͎̼̙̳̹̻͓͚̫͎̩̰̹̠̱̥͈̬͎̼͕̻̰͖͖̘̰̫͍̼̟̰̟̳̝̥̪̙̬͇̮̤̬̥̗͉͖͉̊́̊̈̇́͌͋̓̀͆̀̓̑̾͂͑͛͒̀̇̾͊̓́̐̇̾̑̇͑̀̒̔͊͊̾͑͆͋͛̂͋̎̓̀̏̓͋̒̃̉͗̋̈́̃̏̉̐̈́͗͌̀͆̌̓̃̎̾̐̀͋͂̎̂̏̐̓͐̌́̃́̑̔̅̑̑͑͆̐̌̇̇̏̈́̐̉̿̍͑̉̓͒̉̉́̓̊̌́̽̽͊̾͌̎̃̎̑̑̄͌̒̓̊̈́͌̊̂̈̓͐̓̓̋̊̃̎͛̋̃͛̑̈́͗̽̽́͑̆̏̽̊̒̏͂͑̆̿̓́͋̄̋͌̊̾̆̽̒͐͘͘̕͘͘̕͘̚͘̚͘͘͜͜͜͝͠͝͠͠͠͠͝͠͝ͅͅͅͅͅp̷̡̧̡̡̡̡̢̨̢̨̧̡̢̡̢̡̛͚̩̟̗͖̥̗̝͓͙͔̳̦̘̹͉͙̜̰̟̰̹͙̪̗̭͙͓̯͓̝̟̞̙̘̟̜̬̤̦̻̝̲͓̗̺͓̺̗̦͍̜͓͇̤̼̲̗̯̫̼̦̬͙̪̥̖̼͙͖̪̙̜̫̜͖̝̮̳̜̪̣͍͉̳̫̥̯̱̰̪̹̬̗̻͉̻͍̺̻̮̤̙̖̳͚͔̠͓̲͖͓̼̳̪̤̺̖̫͎̺̻͉͇̯̙̥̘̫͎̫̮̖͗̅͆̈́̽͌̓̈́̆̊̏̽̎͋͐͆̽́̆͒̀̎͆̓̋͋̓̀̽̓̎̃͑͑͌̂͆̂̏̀͒͐͋͌͆̉̒̐̍̽̿͑́̀̓́̀̅́̑̉̂͆͆̏͆̾̾̉̌́̏̈͗̾͑̒̾͗̓̈́́͊̔̂̎̏́̈́̋̓̾̆̌̃͂̒̿͐͘͘̕͘͘̚̚̚̚̚͜͜͠͝͝͠͠͝͝ͅͅͅͅͅͅl̶̢̢̧̨̡̮̭͙̲̹͎̤̜̺͉͔͚̜̯͎̻̙͖̮̞͇̪̳͙̤̘͔̟̙̘̗̘͎̩̰͙̣̺̬̼̙̯̪͔̜͈̳͔̥̖̜̙̫̹̹̖̯̣͖̹̗̥̦̟̩͈͖̭̫͍̮̗͎͎͍̜͚̬͕̥̣̗̝̖͂͂̋́̓̂̐̈́̾̿̒̑̐́͐͆̍͒̄́̀̃̾̈̏̎̔́̍̄̄̇̀̄͗̑̐̏̏͋͑͊̂̀̌̆͋͋̔̀̐̀̽́̏͋͛͋̀̉̐̋̃̀̏́̐̽̊͑̌̽̔̔͒̈́̔͐̐̿̓̇̆͂̈̈́̓́͒͊́́̉͗̽̀̓̐̑̀̍̿́͛͑̌̂͂͆̀̓̋̊͛͋̀̇̐̂̔̉͂͋̎̌̀̈́̊͗̅͂̿̔͑͌̃͑̾̐͑̐͗͗̉̌͌͆̿̈́͐̈́̽̓̏̓̓̒̽̀͒̽̌̓́̆̈́̃͛̔̎͌̄͒̈̀̏̄̈́̎͐̓̓͗̆̅̓̄͆̔̄̏̿̍̕͘̚͘͘̕̕͘͘͘̕̚͘̚͘͘̚͘͜͜͝͝͠͝͝͝͝͠͝͝͝͝͠͝͠͝͠͠͝͝ͅͅe̴̡̨̡̢̧̧̢̧̡̡̢̨̡̧̢̢̧̧̡̢̧̨̨̢̧̧̢̡̛̛̛͈̪͖̦͈̬͔̳̲̬͈͍̟̻̰̜̮̤͔̗̮̣͍̼͎̠̜̲̲̜̼͕̰͙͓̭̮̭̰̮̦̰̞̘͖̳͙̫̹̩͇̹̰̬̳̱̙͉̭̖̺̘̻̬̬̯͙͕͉͙͍̥̫̼̯̱̬̯̘̖̳̞̖͎͔̺̲̭̻̮͇͇̼̙̬̝̺͇̙͎̤̜̯̜̼̻͎̻̗̲͙̰̹͕̮̗̦̖̳͕͕̪̟̝̠̫̳͉̦̭̝͓͈̣̪̼̰̥̩͈̪̞͖͍͕̰̥̙̖̖̼̹̜̤̟͇̦͎̹̩̪͔̙̱̹̙̖̯͇͚̮͈̖̬͓̬̖̳̬͚̭̩͈̪̫͙̣͓̞̫̦̻͔̖̤͈͔̬̞͎͎̙̰̤͎̥̺̥͇̩̝̝͔̙͚̝̭͙̼̱̙̙̠̟̬̭̞̰̭̯̖͍̫̪̻̜̻̼̩̮̻̥͍͙̭͕̝̰̟̝̘̩̱̣̣̻͍̘͔̼͌̏̿͋̆̊̒̓̃̈̊̅̄̇̔̆̆̐̃̄͒̊̆͑̈́͛̈́́͑͛͂̈́́̐̌̈́̇̅̍̑́̆̒̾͛͐̄́̅̉̓͋̀̐́̓̾͗̇̊̑̎̑̆̓̀̑͌̂͌̃͌̈̎́̃̃̓͑̃͑͗̈́́̋̆͋͂̊́͒͒͒͂͋̍̿̒̓̔̈̒̽̏̄̚̚͘̕̚͘̚͜͜͜͜͜͜͠͝͝͝͝͠ͅͅͅͅͅͅt̸̨̢̡̧̧̡̨̨̧̢̧̛̛̛̛̛̛͔̱̮̘̞̗̩̣͖̭̥̞̗̳͔͍̣̦̰͚͔̩̰̦̳͈̠̬̙͚͚͎̹̖̟͖̲̹̪̼̳̺̠͇̞͖̱̞̠͙͖͖̰̞̭̩̳̤͚̖̼̞̤̮̟̗̜͕̝͈͖͉͖͖͙̤̜͙̖̩̘̗͔͇̜̯̞̙̟͎̙̩̠̭̦̫̺̥̳̯͖̺̯̲̲͚̗̘̟̙͚̫̞̳̟͔̥͍͖͎̟͔͙̎̒͆͌̇͂̒̃͗̽̀̀̊͒͋͒̓̅̋̀͂̇́̅͋̍̾́̔̆͊̆͊̈́́͆͂̾͗̆̾͐͒̏͌̾͑̿͒̎̀͑͊͐̓̄̈́͗̏̽̑͒̾̀̇̆̎́̈́͌̆͑͒̉̀͑̈́̔̈̊̈̏̊̈̾̒̓͌̈́̏̒̌̑̿̑͒̌̇̽̉͊͌̾́͗̄̈́̔̈́̓́̏̀͛̾͗̃̽͆̐̓͛͌̓͗͌̒̉̄̋͌̎́͐͂́̆̐̈́̈̀̾̿̂̈́̾͛͛̈́͋̃̒̿͂̿́͛̓̈́́̊̈́̽̍̔̃̍͂̾̏̔̾̐̽̐̈́͑́̂͆̾͐̓̉̉̀̃̔͐̔́͛̋͐̃̒̈̎͋̋̎͒͗͆̾̂͐̈́̇̅̔͛͛͋͋͒͆̔̏̅͌̔̀̆̇́̓̀̑͒̍́̅͘̕̕͘̚͘̕͘̚̚͘͘͘͘̚̚̕̕̚͜͜͜͝͝͠͝͝͠͝͝͝͝͝͠͝͠͝ͅͅͅȩ̶̧̛̛͎̦͔̩̺̱̪͚̪̰̻̫͎̣͈̦̦̼̭̣͕͉̻̥̗͈̏̇̌͊̌͆̎̎͊̀̇̓͆̏̀͗͊͆̈̃͑͗̄́̓̔́́́̈́̐̌̑̈́͊̂̂̿̋̀̏̇̿̍͌̽̾̃̽̂̽̈͆̀̏͐̃̌̉̋̉͑̄͂̀̓̃̾̈́̈́̈́̈́͑̈́̊̓͂̔̈̔̍͊͗͑͊͋̈́̌̓̑͑̈́͋̄̇̀̓͐̀̅̇͗͑̒̀̒̋́̅͊̄̅̎̉̈́̆̂̀̋̋̅̂̋̍͒́̎͂͛̈́̃̋̽̓̉̑̓̋͛̍̉̎̈́̇́̽̆̅̈́̆̾̽͐͊̆̿͊͆̋͋͐̐̌́̒́̎͂͒̂̆̆̓̏̈́̈́̌̇̑͒̑͐̏̽̇̈̒̅̒͊̈͑͛̈̄̔͋̀̄̉͊̒͊̒̎̍̀̋̍́́͂̑͛̄͊̀̉̓̂̀́̋̉͒̽͒̿͘͘̕͘͘͘̕̚̚̕̕̕̚̕̚͘͝͝͝͠͝͝͝͠͝͝͝͝͝͝͝ͅd̵̨̧̡̢̢̢̧̧̨̨̛̛̛̛̛̛̰̣̟̪̬͚̮͈̹̳̲̩͚̟̖̖̱̮͙̦̥̥̟̰̝̣͚̲͎̤̼͓̺͇̣̪̻̣̖͓͓̝͓̗̘͖̗̜̩̙͈̮͓̲̪̪̳̖̻̩̺̰̝̈́̊̿̍̈́̈́̃͆̂̌̿̒́͒̎̈̏̔͗̃̐̽͊̏̐̒̊̌̂̈́̾͋̾̍̍͛͗̍̉̌̍̈́̈́̂̌̿̂̃̇̈́͗̄͑̉̆̓͑̍̓̅͐̽͐̀͗͒͂͑̒͋̀̏̅́̄̆̿̒̑̋̾͆̑̉͗̈́̈̀̐̐̃̇̍́͑̀̓̊͑̾̇̄̽͋̓͗̓̉͊͗͘̚͘͘͘͘͜͜͠͝͠͠͝ͅͅ";//Just some glitchy text we display at the end.





        void textScroll(int milliseconds, string text, Label label)//TextScroll function, writes text to a label one letter at a time
        {
            if (lastKill == true)//check if the final boss has been defeated
            {
                milliseconds = 1;//If so, lower our delay for text scroll
            }
            label.Text = "";//Clear the label of all text
            for (int x = 0; x < text.Length; x++)
            {
                String character = text.Substring(x, 1);//Get the next character of the text we are writing to the label
                label.Text += character;//Write one letter to the label
                Thread.Sleep(milliseconds);//Small delay before continuing
                label.Update();//Force the label to be redrawn
            }
        }

        void battleEntry()//Animations at the start of the battle
        {
            pbAvatar.Image = Properties.Resources.AvatarBack;//Load the avatar's sprite
            pbAvatar.Refresh();//Force graphics update
            if (SebnicMenu.currentUnitTab == 2)//This if statement will load the correct boss sprite depending on which assignment is being taken
            {
                pbEnemy.Image = Properties.Resources.jackblack;//Jack Black, the Blackjack assignment
                pbEnemy.Refresh();
            }
            else if (SebnicMenu.currentUnitTab == 4)
            {
                pbEnemy.Image = Properties.Resources.hungman;//The Hung Man, hangman assignment
                pbEnemy.Refresh();
            }
            else if (SebnicMenu.currentUnitTab ==5)
            {
                pbEnemy.Image = Properties.Resources.AvatarFront;//The player, final assignment
                pbEnemy.Refresh();
            }

            int xEnemy = 0;//These 4 variables are used in the following for loop to control the location of the two sprites
            int yEnemy = 123;
            int xAvatar = 338;
            int yAvatar = 359;

            for (int z = 0; z < 26; z++)
            {
                this.Refresh();//Force update
                xEnemy += 10;//Move the enemy to the right 10px
                xAvatar -= 10;//Move the player to the left 10px
                pbEnemy.Location = new Point(xEnemy, yEnemy);//Redraw the enemy's sprite
                pbAvatar.Location = new Point(xAvatar, yAvatar);//Redraw the player's sprite             
            }
        }

        void error()//Enemy attack animation
        {
            pbError.Visible = true;//Make the error sprite visible
            int xError = 245;//Set it's position to the start of it's path at the enemy
            int yError = 215;

            for (int z = 0; z < 18; z++)
            {
                this.Refresh();//Force update
                xError -= 10;//Move is on a diagonal path down and to the left
                yError += 10;
                pbError.Location = new Point(xError, yError);//Redraw the sprite
            }
            pbError.Visible = false;//Make the sprite invisible again
            sanity -= 5;//Subtract 5 from the player's health
            pgbSanity.Value = sanity;//Display the health in the progress bar
            pgbSanity.Refresh();//Force update
            lblSanity.Text = "Sanity: " + sanity + "%";//Display the player's current health
            lblSanity.Refresh();//Force update
            errors++;//Add one to the errors total
            lblErrorTotal.Text = "x " + errors;//Display the errors total
            lblErrorTotal.Refresh();//Force update
        }

        void check()//Player attack animation
        {
            pbCheck.Visible = true;//Make the checkmark sprite visible
            int xCheck = 101;//Set the sprite's location to the start o fits path by the player
            int yCheck = 391;

            for (int z = 0; z < 21; z++)
            {
                this.Refresh();//Force update
                xCheck += 10;//Move the sprite on a diagonal path up and to the right
                yCheck -= 10;
                pbCheck.Location = new Point(xCheck, yCheck);//Redraw the sprite
            }
            pbCheck.Visible = false;//Make the sprite invisible again
            completion += 5;//Add 5 to the completion meter
            pgbCompletion.Value = completion;//Display the completion value in the progress bar
            pgbCompletion.Refresh();//Force update
            lblCompletion.Text = "Completion: " + completion + "%";//Display the assignment's completeion
            lblCompletion.Refresh();//Force update
        }

        void newQuestion()//Display a new question
        {           
            if (SebnicMenu.currentUnitTab == 2)//Questions for the blackjack assignment
            {
                /*The code in this function is extremely repetitive*/
                question = r.Next(1, 11);//Get a new question
                if (question == 1)//This if statement will determine which question to display
                //This is SUPER repetitive   
                {
                    textScroll(40, "Which of these is a programming language?", lblDialogue);//Display question and answers in labels
                    lblAttack1.Text = "C#";//Correct
                    lblAttack2.Text = "D#";
                    lblAttack3.Text = "A#";
                    lblAttack4.Text = "Z#";
                }
                else if (question == 2)
                {
                    textScroll(40, "Which file extension do webpage files have?", lblDialogue);
                    lblAttack1.Text = ".exe";
                    lblAttack2.Text = ".html";//Correct
                    lblAttack3.Text = ".web";
                    lblAttack4.Text = ".bat";
                }
                else if (question == 3)
                {
                    textScroll(40, "What tag can you use to identify CSS code in a webpage?", lblDialogue);
                    lblAttack1.Text = "<css>";
                    lblAttack2.Text = "<code>";
                    lblAttack3.Text = "<style>";//Correct
                    lblAttack4.Text = "<script>";
                }
                else if (question == 4)
                {
                    textScroll(40, "What type of file path always begins with a drive letter?", lblDialogue);
                    lblAttack1.Text = "Relative";
                    lblAttack2.Text = "None";
                    lblAttack3.Text = "Both";
                    lblAttack4.Text = "Absolute";//Correct
                }
                else if (question == 5)
                {
                    textScroll(40, "What symbol reprsents the parent directory in a relative path?", lblDialogue);
                    lblAttack1.Text = "../";//Correct
                    lblAttack2.Text = "./";
                    lblAttack3.Text = "*/";
                    lblAttack4.Text = "/.";
                }
                else if (question == 6)
                {
                    textScroll(40, "Which of these is not a number system?", lblDialogue);
                    lblAttack1.Text = "Binary";
                    lblAttack2.Text = "Boolean";//Correct
                    lblAttack3.Text = "Decimal";
                    lblAttack4.Text = "Hex";
                }
                else if (question == 7)
                {
                    textScroll(40, "What is the largest digit in the hexadecimal system?", lblDialogue);
                    lblAttack1.Text = "6";
                    lblAttack2.Text = "15";
                    lblAttack3.Text = "F";//Correct
                    lblAttack4.Text = "H";
                }
                else if (question == 8)
                {
                    textScroll(40, "What property will change whether an object can be seen?", lblDialogue);
                    lblAttack1.Text = "Checked";
                    lblAttack2.Text = "Name";
                    lblAttack3.Text = "Enabled";
                    lblAttack4.Text = "Visible";//Correct
                }
                else if (question == 9)
                {
                    textScroll(40, "Which is not a standard object property?", lblDialogue);
                    lblAttack1.Text = "Alive";//Correct
                    lblAttack2.Text = "Location";
                    lblAttack3.Text = "Size";
                    lblAttack4.Text = "Enabled";
                }
                else if (question == 10)
                {
                    textScroll(40, "What would be the proper name for a textbox accepting the user's name?", lblDialogue);
                    lblAttack1.Text = "Namebox";
                    lblAttack2.Text = "txtName";//Correct
                    lblAttack3.Text = "textName";
                    lblAttack4.Text = "Name";
                }
            }
            else if (SebnicMenu.currentUnitTab == 4)//Questions for the hangman assignment
            {
                question = r.Next(1, 11);
                if (question == 1)
                {
                    textScroll(40, "What does the P in IPO stand for?", lblDialogue);
                    lblAttack1.Text = "Processing";//Correct
                    lblAttack2.Text = "Programming";
                    lblAttack3.Text = "Privacy";
                    lblAttack4.Text = "Pirates";
                }
                else if (question == 2)
                {
                    textScroll(40, "Which is not a part of the algorithm process?", lblDialogue);
                    lblAttack1.Text = "IPO Chart";
                    lblAttack2.Text = "Downloading";//Correct
                    lblAttack3.Text = "Pseudocode";
                    lblAttack4.Text = "Flowchart";
                }
                else if (question == 3)
                {
                    textScroll(40, "In the function 'Substring (int, int)', which int represents the length of the substring?", lblDialogue);
                    lblAttack1.Text = "First";
                    lblAttack2.Text = "Both";
                    lblAttack3.Text = "Second";//Correct
                    lblAttack4.Text = "None";
                }
                else if (question == 4)
                {
                    textScroll(40, "How many parameters can a void-type function have?", lblDialogue);
                    lblAttack1.Text = "None";
                    lblAttack2.Text = "Two";
                    lblAttack3.Text = "One";
                    lblAttack4.Text = "Infinite";//Correct
                }
                else if (question == 5)
                {
                    textScroll(40, "Which type of function cannot return a value?", lblDialogue);
                    lblAttack1.Text = "Void";//Correct
                    lblAttack2.Text = "String";
                    lblAttack3.Text = "Double";
                    lblAttack4.Text = "Boolean";
                }
                else if (question == 6)
                {
                    textScroll(40, "Can an array be resized after it is created?", lblDialogue);
                    lblAttack1.Text = "Only once";
                    lblAttack2.Text = "Never";//Correct
                    lblAttack3.Text = "Yes";
                    lblAttack4.Text = "Only Twice";
                }
                else if (question == 7)
                {
                    textScroll(40, "A minimum of how many for loops are required to implement bubble sorting?", lblDialogue);
                    lblAttack1.Text = "1";
                    lblAttack2.Text = "3";
                    lblAttack3.Text = "2";//Correct
                    lblAttack4.Text = "4";
                }
                else if (question == 8)
                {
                    textScroll(40, "What do you call a function that calls itself?", lblDialogue);
                    lblAttack1.Text = "Algorithm";
                    lblAttack2.Text = "Looping";
                    lblAttack3.Text = "Repetetive";
                    lblAttack4.Text = "Recursive";//Correct
                }
                else if (question == 9)
                {
                    textScroll(40, "If a program contains an instance variable 'x' and a local variable 'x', what keyword is used to identify the instance variable?", lblDialogue);
                    lblAttack1.Text = "This";//Correct
                    lblAttack2.Text = "That";
                    lblAttack3.Text = "Instance";
                    lblAttack4.Text = "Local";
                }
                else if (question == 10)
                {
                    textScroll(40, "What is the final step in the software development life cycle?", lblDialogue);
                    lblAttack1.Text = "Create algorithm";
                    lblAttack2.Text = "Obsolete";//Correct
                    lblAttack3.Text = "Maintenance";
                    lblAttack4.Text = "Identify problem";
                }
            }
            else if (SebnicMenu.currentUnitTab == 5)//Questions for the final assignment. This has questions from both of the previous assignments
            {
                question = r.Next(1, 21);
                if (question == 1)
                {
                    textScroll(40, "Which of these is a programming language?", lblDialogue);
                    lblAttack1.Text = "C#";//Correct
                    lblAttack2.Text = "D#";
                    lblAttack3.Text = "A#";
                    lblAttack4.Text = "Z#";
                }
                else if (question == 2)
                {
                    textScroll(40, "Which file extension do webpage files have?", lblDialogue);
                    lblAttack1.Text = ".exe";
                    lblAttack2.Text = ".html";//Correct
                    lblAttack3.Text = ".web";
                    lblAttack4.Text = ".bat";
                }
                else if (question == 3)
                {
                    textScroll(40, "What tag can you use to identify CSS code in a webpage?", lblDialogue);
                    lblAttack1.Text = "<css>";
                    lblAttack2.Text = "<code>";
                    lblAttack3.Text = "<style>";//Correct
                    lblAttack4.Text = "<script>";
                }
                else if (question == 4)
                {
                    textScroll(40, "What type of file path always begins with a drive letter?", lblDialogue);
                    lblAttack1.Text = "Relative";
                    lblAttack2.Text = "None";
                    lblAttack3.Text = "Both";
                    lblAttack4.Text = "Absolute";//Correct
                }
                else if (question == 5)
                {
                    textScroll(40, "What symbol reprsents the parent directory in a relative path?", lblDialogue);
                    lblAttack1.Text = "../";//Correct
                    lblAttack2.Text = "./";
                    lblAttack3.Text = "*/";
                    lblAttack4.Text = "/.";
                }
                else if (question == 6)
                {
                    textScroll(40, "Which of these is not a number system?", lblDialogue);
                    lblAttack1.Text = "Binary";
                    lblAttack2.Text = "Boolean";//Correct
                    lblAttack3.Text = "Decimal";
                    lblAttack4.Text = "Hex";
                }
                else if (question == 7)
                {
                    textScroll(40, "What is the largest digit in the hexadecimal system?", lblDialogue);
                    lblAttack1.Text = "6";
                    lblAttack2.Text = "15";
                    lblAttack3.Text = "F";//Correct
                    lblAttack4.Text = "H";
                }
                else if (question == 8)
                {
                    textScroll(40, "What property will change whether an object can be seen?", lblDialogue);
                    lblAttack1.Text = "Checked";
                    lblAttack2.Text = "Name";
                    lblAttack3.Text = "Enabled";
                    lblAttack4.Text = "Visible";//Correct
                }
                else if (question == 9)
                {
                    textScroll(40, "Which is not a standard object property?", lblDialogue);
                    lblAttack1.Text = "Alive";//Correct
                    lblAttack2.Text = "Location";
                    lblAttack3.Text = "Size";
                    lblAttack4.Text = "Enabled";
                }
                else if (question == 10)
                {
                    textScroll(40, "What would be the proper name for a textbox accepting the user's name?", lblDialogue);
                    lblAttack1.Text = "Namebox";
                    lblAttack2.Text = "txtName";//Correct
                    lblAttack3.Text = "textName";
                    lblAttack4.Text = "Name";
                }
                else if (question == 11)
                {
                    textScroll(40, "What does the P in IPO stand for?", lblDialogue);
                    lblAttack1.Text = "Processing";//Correct
                    lblAttack2.Text = "Programming";
                    lblAttack3.Text = "Privacy";
                    lblAttack4.Text = "Pirates";
                }
                else if (question == 12)
                {
                    textScroll(40, "Which is not a part of the algorithm process?", lblDialogue);
                    lblAttack1.Text = "IPO Chart";
                    lblAttack2.Text = "Downloading";//Correct
                    lblAttack3.Text = "Pseudocode";
                    lblAttack4.Text = "Flowchart";
                }
                else if (question == 13)
                {
                    textScroll(40, "In the function 'Substring (int, int)', which int represents the length of the substring?", lblDialogue);
                    lblAttack1.Text = "First";
                    lblAttack2.Text = "Both";
                    lblAttack3.Text = "Second";//Correct
                    lblAttack4.Text = "None";
                }
                else if (question == 14)
                {
                    textScroll(40, "How many parameters can a void-type function have?", lblDialogue);
                    lblAttack1.Text = "None";
                    lblAttack2.Text = "Two";
                    lblAttack3.Text = "One";
                    lblAttack4.Text = "Infinite";//Correct
                }
                else if (question == 15)
                {
                    textScroll(40, "Which type of function cannot return a value?", lblDialogue);
                    lblAttack1.Text = "Void";//Correct
                    lblAttack2.Text = "String";
                    lblAttack3.Text = "Double";
                    lblAttack4.Text = "Boolean";
                }
                else if (question == 16)
                {
                    textScroll(40, "Can an array be resized after it is created?", lblDialogue);
                    lblAttack1.Text = "Only once";
                    lblAttack2.Text = "Never";//Correct
                    lblAttack3.Text = "Yes";
                    lblAttack4.Text = "Only Twice";
                }
                else if (question == 17)
                {
                    textScroll(40, "A minimum of how many for loops are required to implement bubble sorting?", lblDialogue);
                    lblAttack1.Text = "1";
                    lblAttack2.Text = "3";
                    lblAttack3.Text = "2";//Correct
                    lblAttack4.Text = "4";
                }
                else if (question == 18)
                {
                    textScroll(40, "What do you call a function that calls itself?", lblDialogue);
                    lblAttack1.Text = "Algorithm";
                    lblAttack2.Text = "Looping";
                    lblAttack3.Text = "Repetetive";
                    lblAttack4.Text = "Recursive";//Correct
                }
                else if (question == 19)
                {
                    textScroll(40, "If a program contains an instance variable 'x' and a local variable 'x', what keyword is used to identify the instance variable?", lblDialogue);
                    lblAttack1.Text = "This";//Correct
                    lblAttack2.Text = "That";
                    lblAttack3.Text = "Instance";
                    lblAttack4.Text = "Local";
                }
                else if (question == 20)
                {
                    textScroll(40, "What is the final step in the software development life cycle?", lblDialogue);
                    lblAttack1.Text = "Create algorithm";
                    lblAttack2.Text = "Obsolete";//Correct
                    lblAttack3.Text = "Maintenance";
                    lblAttack4.Text = "Identify problem";
                }
            }
        }

        void checkAnswer(Label label)//Check the answer
        {
            if (question == 1)//Depending on the question number, the correct label will change. 
            {
                if (label.Name == lblAttack1.Name)//If it's the right label..
                {
                    check();//correct answer
                }
                else
                {
                    error();//else wrong answer
                }
            }
            else if (question == 2)
            {
                if (label.Name == lblAttack2.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 3)
            {
                if (label.Name == lblAttack3.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 4)
            {
                if (label.Name == lblAttack4.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 5)
            {
                if (label.Name == lblAttack1.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 6)
            {
                if (label.Name == lblAttack2.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 7)
            {
                if (label.Name == lblAttack3.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 8)
            {
                if (label.Name == lblAttack4.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 9)
            {
                if (label.Name == lblAttack1.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 10)
            {
                if (label.Name == lblAttack2.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 11)
            {
                if (label.Name == lblAttack1.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 12)
            {
                if (label.Name == lblAttack2.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 13)
            {
                if (label.Name == lblAttack3.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 14)
            {
                if (label.Name == lblAttack4.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 15)
            {
                if (label.Name == lblAttack1.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 16)
            {
                if (label.Name == lblAttack2.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 17)
            {
                if (label.Name == lblAttack3.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 18)
            {
                if (label.Name == lblAttack4.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 19)
            {
                if (label.Name == lblAttack1.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }
            else if (question == 20)
            {
                if (label.Name == lblAttack2.Name)
                {
                    check();
                }
                else
                {
                    error();
                }
            }

        }

        void checkDeath()//Check if either the player or boss has "died"
        {
            if (completion >= 100)//If the boss has died
            {
                if (SebnicMenu.currentUnitTab == 2)//Display a message, different for each boss
                {
                    textScroll(40, "Jack Black fainted! Unit 2 assignment complete!                    ", lblDialogue);
                    assignmentMark = assignmentMark - (errors  * 1.5);//Calculate the assignment mark
                    Classroom.courseMark = (Classroom.courseMark + assignmentMark) / 2;
                    SebnicMenu.lesson1Attempted = false;//Reset lessons for new unit
                    SebnicMenu.lesson2Attempted = false;
                    SebnicMenu.lesson3Attempted = false;
                    SebnicMenu.lesson4Attempted = false;
                    SebnicMenu.lesson5Attempted = false;
                    Classroom.unit++;//Next unit!
                    SebnicMenu frm = new SebnicMenu();//Take the player back to sebnic
                    frm.Show();
                    this.Hide();
                }
                else if (SebnicMenu.currentUnitTab == 4)
                {
                    textScroll(40, "The Hung Man fainted! Unit 4 assignment complete!                    ", lblDialogue);
                    assignmentMark = assignmentMark - (errors * 1.5);
                    Classroom.courseMark = (Classroom.courseMark + assignmentMark) / 2;
                    SebnicMenu.lesson1Attempted = false;//Reset lessons for new unit
                    SebnicMenu.lesson2Attempted = false;
                    SebnicMenu.lesson3Attempted = false;
                    SebnicMenu.lesson4Attempted = false;
                    SebnicMenu.lesson5Attempted = false;
                    Classroom.unit++;//Next unit!
                    SebnicMenu frm = new SebnicMenu();//Take the player back to sebnic
                    frm.Show();
                    this.Hide();
                }
                else if (SebnicMenu.currentUnitTab == 5)
                {
                    lastKill = true;
                    textScroll(40, TitleScreen.playerName + " fainted! Final assignment com-\n" + glitchText, lblDialogue);
                    assignmentMark = assignmentMark - (errors * 1.5);
                    Classroom.courseMark = (Classroom.courseMark + assignmentMark) / 2;
                    EndScreen frm = new EndScreen();//Load the end screen. The game is over.
                    frm.Show();
                    this.Hide();
                }

            }
            else if (sanity <= 0)//The player has died
            {
                textScroll(40, "Too many build errors!\n" + TitleScreen.playerName + " lost his mind!\n", lblDialogue);//Display message
                assignmentMark = 0;
                Classroom.courseMark = (Classroom.courseMark + assignmentMark) / 2;                
                SebnicMenu.lesson1Attempted = false;//Reset lessons for new unit
                SebnicMenu.lesson2Attempted = false;
                SebnicMenu.lesson3Attempted = false;
                SebnicMenu.lesson4Attempted = false;
                SebnicMenu.lesson5Attempted = false;
                Classroom.unit++;//Next unit!
                SebnicMenu frm = new SebnicMenu();//take them back to sebnic
                frm.Show();
                this.Hide();
            }
        }

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

        public Battle()
        {
            InitializeComponent();
        }
        
        private void Battle_Shown(object sender, EventArgs e)
        {
            battleEntry();//Battle entry animations
            newQuestion();//Givce the user a new question
        }

        private void Battle_Load(object sender, EventArgs e)
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

            lblName.Text = TitleScreen.playerName;//Load in the player's name            
            lblName.Refresh();//Force update
            if (SebnicMenu.currentUnitTab == 2)//Change the enemy's name and the message, depending on which assignment is being worked on.
            {
                lblEnemy.Text = "Jack Black";
                lblEnemy.Refresh();
                textScroll(40, "Jack Black entered the battle!", lblDialogue);
            }
            else if (SebnicMenu.currentUnitTab == 4)
            {
                lblEnemy.Text = "The Hung Man";
                lblEnemy.Refresh();
                textScroll(40, "The Hung Man entered the battle!\nWhat attack will " + TitleScreen.playerName + " use?", lblDialogue);
            }
            else if (SebnicMenu.currentUnitTab == 5)
            {
                lblEnemy.Text = TitleScreen.playerName;
                lblEnemy.Refresh();
                textScroll(40, TitleScreen.playerName + " entered the battle!\nWhat attack will " + TitleScreen.playerName + " use?", lblDialogue);
            }
        }

        //These next 4 events are for the labels that display the answers. They are nearly identical.
        private void lblAttack1_Click(object sender, EventArgs e)
        {
            checkAnswer(lblAttack1);//Check if this was the right label to click
            checkDeath();//Check if either the player or boss has died
            newQuestion();//New question
        }

        private void lblAttack2_Click(object sender, EventArgs e)
        {
            checkAnswer(lblAttack2);
            checkDeath();
            newQuestion();
        }

        private void lblAttack3_Click(object sender, EventArgs e)
        {
            checkAnswer(lblAttack3);
            checkDeath();
            newQuestion();
        }

        private void lblAttack4_Click(object sender, EventArgs e)
        {
            checkAnswer(lblAttack4);
            checkDeath();
            newQuestion();
        }

        private void pbMusic_Click(object sender, EventArgs e)
        {
            toggleMusic();
        }
    }
}
