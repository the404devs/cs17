using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace prjICS
{
    public partial class TitleScreen : Form
    {
        /************
        **Variables**
        ************/
        SoundPlayer player = new SoundPlayer(Properties.Resources.Fawful___MLBIS);//Initialize the music player
        public static String playerName = "";//player's name
        public static Boolean loadLastGame = false;//if you have a save file
        public static Boolean music = false;//Represents whether or not the music is on or off

        /************
        **Functions**
        ************/

        void textScroll(int milliseconds, string text, Label label)//scrolls the input text at the speed of the inputed number of milliseconds. this is assigned to an inputed label
        {
            label.Text = "";//resets the label to have no string
            for (int x = 0; x < text.Length; x++)//for loop to gain each character from the input string and add it to the label with a delay. this causes the text scroll effect.
            {
                String character = text.Substring(x, 1);//gets the character at the position of the number of iterations the for loop had gone through
                label.Text += character;//adds the character to the label string
                Thread.Sleep(milliseconds);//delay
                label.Update();//updates screen
            }
        }

        void setFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();//variable for the font file
            pfc.AddFontFile("acme_explosive.TTF");//font file
            foreach(Control c in Controls)//cycles through the diffrent contols and sets the font
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size - 4);
            }            
        }

        void toggleMusic()
        {
            if (music == true)
            {
                pbMusic.Image = Properties.Resources.musicoff;
                music = false;
                player.Stop();//Stop the music
            }
            else
            {
                pbMusic.Image = Properties.Resources.musicon;
                music = true;
                player.PlayLooping();//Play the music
            }
        }

        public TitleScreen()
        {
            InitializeComponent();            
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            /*This section sets the playerName variable to 
             * whatever the user inputted, then loads the game 
             * (Form1) and hides the name input window (Form2).*/

            playerName = txtName.Text;//gets the player name from txtName.Text;

            Classroom frm = new Classroom();//changes to the classroom form
            frm.Show();
            this.Hide();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {            
            HelpMenu frm = new HelpMenu();//Load the help menu
            frm.Show();
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            player.Stop();
            setFont();//sets the font of the form
            lblTitle.Text = "";
            textScroll(40, "Interactive Course Simulator: Computer Science 2017", lblTitle);//scrolls the title screen text

            lblNew.Visible = true;//turns on the controls of the form
            lblLoad.Visible = true;
            pbMusic.Visible = true;
            lblHelp.Visible = true;     
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 15)//limits your name to 15 characters
            {
                txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1, 1);//removes the last character of the string
            }

            if (txtName.Text!="")//turns on the start game button when txt.Name does not equal to a blank string
            {
                lblStart.Visible = true;
                lblWarning.Visible = true;
            }
            else//otherwise, it will not
            {
                lblStart.Visible = false;
                lblWarning.Visible = false;
            }
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            loadLastGame = false;//sets loadLastGame to false so when the classroom loads, it does not load your save file
            lblNamePrompt.Visible = true;//this makes the namePrompt label visible
            lblNamePrompt.Text = "";//resets the namePrompt label to a blank string
            textScroll(40, "Enter Your Name:", lblNamePrompt);//scrolls the enter name text
            txtName.Visible = true;//makes the textbox for the input of your name visible
        }

        private void lblLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("data.txt"))//checks if data.txt exists in the files
            {
                loadLastGame = true;//sets loadLastGame to true so when the classroom loads, it loads your save file

                Classroom frm = new Classroom();//opens the classroom form
                frm.Show();
                this.Hide();
            }
            else
            {
                lblNoSave.Visible = true;//makes the noSave label visible. (shows that you have no save file)
            }
        }

        private void pbMusic_Click(object sender, EventArgs e)
        {
            toggleMusic();//Toggle the music
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {
            if (music == true)//Check if the music was already playing
            {
                pbMusic.Image = Properties.Resources.musicon;
            }
            else
            {
                pbMusic.Image = Properties.Resources.musicoff;
            }
        }
    }
}
