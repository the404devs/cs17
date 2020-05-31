/*Interactive Course Simulator: Computer Science 2017
 * June 15th, 2017
 * By Kevin, Owen and Jatin
 * This is the Classroom form, the central element of the game.
 * You can wader around and talk to classmates, as well as use your own computer.*/
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace prjICS
{
    public partial class Classroom : Form
    {
        /*****************
        *Global Variables*
        *****************/

        public static int day = 1;//Represents the current day
        public static int unit = 1;//Represents the current unit
        public static double courseMark = 100;//Represents the player's mark in the course

        /*******************
        *Instance Variables*
        *******************/

        static int playerX = 1;//The player's X value on the grid
        static int playerY = 1;//The player's Y value on the grid
        static int lastX = 0;//Previous X value
        static int lastY = 0;//Previous Y value
        static String playerLocation = "1-1";//Current location, combination of X and Y values
        static String computer = "";//Location of the player's computer
        static Boolean welcome = true;//Represents whether or not the welcome message should be shown

        int milliseconds = 30;//Used as a delay in the textScroll() function
        String direction = "up";//The direction the player is facing
        String npcLocation = "";//Location of the object is interacting with
                                //Go to the getNpcLocation() function for more info on how this works
        String lastLocation = "1-1";//The player's previous location
        Boolean canMove = true;//Whether or not the player should be able to move
        Boolean zeeshanFirst = true;//Whether or not we are meeting Zeeshan for the first time
        Boolean onIntro = true;//Whether or not we are in the intro
        Image character = Properties.Resources.AvatarFront;//store the image of our avatar
        SoundPlayer player = new SoundPlayer(Properties.Resources.Coffee_Shop___CP);//Initialize the music player

        /*******
        *Arrays*
        *******/

        String[] loader = new String[10];//Used to load saved data into the game
        String[] badSteps = { "0-2", "1-4", "1-5", "1-6", "1-7", "1-8", "1-10", "1-11", "3-3", "3-5", "3-7", "3-9", "3-11", "4-3", "4-5", "4-7", "4-9", "4-11", "3-12", "5-3", "5-5", "5-7", "5-9", "5-11", "6-3", "6-5", "6-7", "6-9", "7-3", "7-5", "7-7", "7-9", "8-3", "8-5", "8-7", "8-9", "9-1", "9-3", "9-5", "9-7", "9-9", "9-11", "10-1", "10-11",  "11-1", "11-3", "11-4", "11-5", "11-6", "11-7", "11-8", "11-9", "11-10", "11-11" };
        //The above array is a list of all possible locations on the grid we should not be allowed to stand on

        /****************************
        *Function without Parameters*
        ****************************/

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

        void loadData()//Load saved game
        {
            int x = 0;
            string line;
            if (File.Exists("data.txt") == true)//Check if the file exists
            {//If yes, load data
                StreamReader file = new StreamReader("data.txt");//Tell the game what file we want to load from
                while ((line = file.ReadLine()) != null)
                {
                    loader[x] = line;                    
                    if (x == 0)
                    {
                        unit = Convert.ToInt32(line);//Load the current unit
                    }
                    else if (x == 1)
                    {
                        day = Convert.ToInt32(line);//Load the current day
                    }
                    else if (x == 2)
                    {
                        courseMark = Convert.ToDouble(line);//Load the current course mark
                    }
                    else if (x == 3)
                    {
                        TitleScreen.playerName = line;//Load the player's name
                    }
                    else if (x == 4)
                    {
                        computer = line;//Load the player's computer
                    }
                    else if (x == 5)
                    {
                        SebnicMenu.lesson1Attempted = Convert.ToBoolean(line);//Load in the lessons that have been attempted
                    }
                    else if (x == 6)
                    {
                        SebnicMenu.lesson2Attempted = Convert.ToBoolean(line);
                    }
                    else if (x == 7)
                    {
                        SebnicMenu.lesson3Attempted = Convert.ToBoolean(line);
                    }
                    else if (x == 8)
                    {
                        SebnicMenu.lesson4Attempted = Convert.ToBoolean(line);
                    }
                    else if (x == 9)
                    {
                        SebnicMenu.lesson5Attempted = Convert.ToBoolean(line);
                    }
                    x++;
                }
                file.Close();//Close the file. Need this, or else it'll crash if we try to use the file again
            }
        }

        void saveData()//Save the game
        {
            StreamWriter file = new StreamWriter("data.txt");//Tell the game what file we are writing to
            for (int x = 0; x < loader.Length; x++)
            {                
                if (x == 0)
                {
                    loader[x] = unit + "";//Save the current unit
                    file.WriteLine(loader[x]);
                }
                else if (x == 1)
                {
                    loader[x] = day + "";//Save the current day
                    file.WriteLine(loader[x]);
                }
                else if (x == 2)
                {
                    loader[x] = courseMark + "";//Save the current mark
                    file.WriteLine(loader[x]);
                }
                else if (x == 3)
                {
                    loader[x] = TitleScreen.playerName;//Save the player's name
                    file.WriteLine(loader[x]);
                }
                else if (x == 4)
                {
                    loader[x] = computer;//Save the player's computer 
                    file.WriteLine(loader[x]);
                }
                else if (x == 5)
                {
                    loader[x] = SebnicMenu.lesson1Attempted + "";//Save the lessons that the player has attempted
                    file.WriteLine(loader[x]);
                }
                else if (x == 6)
                {
                    loader[x] = SebnicMenu.lesson2Attempted + "";
                    file.WriteLine(loader[x]);
                }
                else if (x == 7)
                {
                    loader[x] = SebnicMenu.lesson3Attempted + "";
                    file.WriteLine(loader[x]);
                }
                else if (x == 8)
                {
                    loader[x] = SebnicMenu.lesson4Attempted + "";
                    file.WriteLine(loader[x]);
                }
                else if (x == 9)
                {
                    loader[x] = SebnicMenu.lesson5Attempted + "";
                    file.WriteLine(loader[x]);
                }
            }
            file.Close();//Close the file
        }   

        void setFont()//Loads our custom font
        {
            PrivateFontCollection pfc = new PrivateFontCollection();//Make a variable to store the new font
            pfc.AddFontFile("acme_explosive.TTF");//Load the new font 
            foreach (Control c in pnlDisplay.Controls)//cycle through each control on the form
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size - 1);//change the font of the current control
            }
        }

        void newLesson()
        {
            foreach (Control c in pnlRoom.Controls)//Loop through each control in the Classroom panel
            {
                if (c is PictureBox)//Check if the current control is a Picturebox
                {
                    if (c.Tag + "" == playerLocation)//Check if it's the picturebox the user is currently in
                    {
                        PictureBox pb = (PictureBox)c;//Create a picturebox-type variable, so we can change picture box-specific properties
                        pb.Image = null;//Draw our stickman in the new box
                    }
                }
            }
            lblDay.Text = "Day " + day;//Dislplay the current day            
            lblName.Text = TitleScreen.playerName;//Display the player's name
            lblSpeaker.Text = "";//Clear the speaker and dialogue labels
            lblDialogue.Text = "";
            this.ActiveControl = null;//Set the focus to nothing
            canMove = true;//By default you can mvoe
            playerX = 1;//Set the player's X and Y coordinates
            playerY = 1;
            playerLocation = "1-1";//And set the playe's first position
            lastX = 1;//Set the last position variables, these will change once the player starts moving around.
            lastY = 1;
            lastLocation = "1-1";
            pbUser1.Image = Properties.Resources.AvatarFront;//Load in the players' sprite
            direction = "up";//Set the character's direction to up
        }

        void getCurrentLocation()//Find the player's location
        {
            if (playerX >= 10)//Determine whether or not the X value is 2 digits long
            {
                playerX = Convert.ToInt32(playerLocation.Substring(0, 2));//Add the X value to playerLocation
                if (playerY >=10)//Check if the Y value is also 2 digits
                {
                    playerY = Convert.ToInt32(playerLocation.Substring(3, 2));//Add the Y value to playerLocation
                }
                else
                {
                    playerY = Convert.ToInt32(playerLocation.Substring(3, 1));//Add the Y value to playerLocation
                }
            }
            else
            {
                playerX = Convert.ToInt32(playerLocation.Substring(0, 1));//Add the X value to playerLocation
                if (playerY >= 10)//Check if the Y value is also 2 digits
                {
                    playerY = Convert.ToInt32(playerLocation.Substring(2, 2));//Add the Y value to playerLocation
                }
                else
                {
                    playerY = Convert.ToInt32(playerLocation.Substring(2, 1));//Add the Y value to playerLocation
                }
            }   

            foreach (Control c in pnlRoom.Controls)//Loop through each control in the Classroom panel
            {
                if (c is PictureBox)//Check if the current control is a Picturebox
                {
                    if (c.Tag + "" == playerLocation)//Check if it's the picturebox the user is currently in
                    {//^Each picturebox has a tag which represents it's location on the grid
                        PictureBox pb = (PictureBox)c;//Create a picturebox-type variable, so we can change picture box-specific properties
                        pb.Image = null;//Clear that picturebox
                    }
                }
            }
        }

        /*The next 4 functions (moveDown, moveUp, moveLeft and moveRight) are all very similar. The major difference is whether 1 is added to or subtacted from playerX or playerY*/
        /*The variable that is changed depends on which way the user is moving*/
        void moveDown()
        {
            lastX = playerX;//Update our last X and last Y
            lastY = playerY;
            playerY += 1;//Add one to the Y value
            playerLocation = playerX + "-" + playerY;//Update the current location
            lastLocation = lastX + "-" + lastY;//Update the last location
            checkLocation();//Check location. This uses the last location to determine if we should be standing in the current spot
            playerLocation = playerX + "-" + playerY;//After checking the location, update the current and last locations again
            lastLocation = lastX + "-" + lastY;

            foreach (Control c in pnlRoom.Controls)//Loop through each control in the Classroom panel
            {
                if (c is PictureBox)//Check if the current control is a Picturebox
                {
                    if (c.Tag + "" == playerLocation)//Check if it's the picturebox the user is currently in
                    {
                        PictureBox pb = (PictureBox)c;//Create a picturebox-type variable, so we can change picture box-specific properties
                        pb.Image = character;//Draw our avatar in the new box
                    }
                }
            }
        }

        void moveUp()
        {
            lastX = playerX;
            lastY = playerY;
            playerY -= 1;
            playerLocation = playerX + "-" + playerY;
            lastLocation = lastX + "-" + lastY;
            checkLocation();
            playerLocation = playerX + "-" + playerY;
            lastLocation = lastX + "-" + lastY;

            foreach (Control c in pnlRoom.Controls)//Loop through each control in the Classroom panel
            {
                if (c is PictureBox)//Check if the current control is a Picturebox
                {
                    if (c.Tag + "" == playerLocation)//Check if it's the picturebox the user is currently in
                    {
                        PictureBox pb = (PictureBox)c;//Create a picturebox-type variable, so we can change picture box-specific properties
                        pb.Image = character;//Draw our avatar in the new box
                    }
                }
            }
        }

        void moveRight()
        {
            lastX = playerX;
            lastY = playerY;
            playerX += 1;
            playerLocation = playerX + "-" + playerY;
            lastLocation = lastX + "-" + lastY;
            checkLocation();
            playerLocation = playerX + "-" + playerY;
            lastLocation = lastX + "-" + lastY;

            foreach (Control c in pnlRoom.Controls)//Loop through each control in the Classroom panel
            {
                if (c is PictureBox)//Check if the current control is a Picturebox
                {
                    if (c.Tag + "" == playerLocation)//Check if it's the picturebox the user is currently in
                    {
                        PictureBox pb = (PictureBox)c;//Create a picturebox-type variable, so we can change picture box-specific properties
                        pb.Image = character;//Draw our avatar in the new box
                    }
                }
            }
        }

        void moveLeft()
        {
            lastX = playerX;
            lastY = playerY;
            playerX -= 1;
            playerLocation = playerX + "-" + playerY;
            lastLocation = lastX + "-" + lastY;
            checkLocation();
            playerLocation = playerX + "-" + playerY;
            lastLocation = lastX + "-" + lastY;

            foreach (Control c in pnlRoom.Controls)//Loop through each control in the Classroom panel
            {
                if (c is PictureBox)//Check if the current control is a Picturebox
                {
                    if (c.Tag + "" == playerLocation)//Check if it's the picturebox the user is currently in
                    {
                        PictureBox pb = (PictureBox)c;//Create a picturebox-type variable, so we can change picture box-specific properties
                        pb.Image = character;//Draw our avatar in the new box
                    }
                }
            }
        }            

        void checkLocation()//To check if we should be standing in the current spot
        {
            for (int x = 0; x < badSteps.Length; x++)
            {
                if (playerLocation == badSteps[x])//If we are standing in a bad spot, move us back to our last location
                {
                    playerX = lastX;
                    playerY = lastY;                   
                }
            }
            //If we aren't in a bad square, check if went out of bounds
            if (playerY > 12 && playerX < 3)//Bottom of room, first 2 columns 
            {
                playerY = 12;
            }
            else if (playerY > 11 && playerX>2)//Bottom of room, everywhere else
            {
                playerY = 11;
            }
            else if (playerY < 1)//Top of room
            {
                playerY = 1;
            }            
            else if (playerX <= 0 && playerY == 1)//Left Side, first row
            {
                playerX = 0;
            }
            else if(playerX < 1 && playerY != 1)//Left side, everywhere else
            {
                playerX = 1;
            }
            else if (playerX > 11)//Right side
            {
                playerX = 11;
            }

        }

        void getNpcLocation()//Get the location of the object we are interacting with
        {
            npcLocation = "";
            if (direction == "up")//Depending on which direction the character is facing, get the location of the object we are interacting with.
            {
                npcLocation = playerX + "-" + (playerY - 1);
            }
            else if (direction == "down")
            {
                npcLocation = playerX + "-" + (playerY + 1);
            }
            else if (direction == "right")
            {
                npcLocation = (playerX + 1) + "-" + playerY;
            }
            else if (direction == "left")
            {
                npcLocation = (playerX - 1) + "-" + playerY;
            }
        }

        void interact()
        {
            getNpcLocation();//Gets the location of the object we are interacting with
            if (unit == 1 && day == 1)//Check if it's the first day
            {
                introPt2(npcLocation);//Special interactions for the first day
            }
            else
            {
                if (npcLocation == computer)//Check if the object is your assigned computer
                {
                    SebnicMenu frm = new SebnicMenu();//Show sebnic
                    frm.Show();
                    this.Hide();
                }
                else if (npcLocation == "-1-1")//Check if the object is the door
                {
                    textScroll(milliseconds, "Mr. Krnic", lblSpeaker);//Mr. Krnic tells you to come back
                    textScroll(milliseconds, "Hey! Class isn't over yet!", lblDialogue);
                    canMove = true;
                }
                else if (npcLocation == "0-12")//Check if the object is Zeeshan's cabinet
                {
                    if (onIntro == false)//check to make sure we're not on the intro, he says different stuff then
                    {
                        getCurrentLocation();//Get our location
                        moveRight();//Move us to the right so Z can pop out of the cabinet
                        pbAvatar.Image = Properties.Resources.NPC3;
                        pbUser12.Image = Properties.Resources.NPC3SideR;//Load in Z's sprite
                        this.Update();//Force graphic update
                        textScroll(milliseconds, "Zeeshan", lblSpeaker);//Z asks if you want help with stuff
                        textScroll(milliseconds, "Psssssst, wanna buy some code?          ", lblDialogue);
                        pbUser12.Image = null;//Z leaves
                        canMove = true;
                    }
                }
                /*The following cases are very repetitive, so only the first will be documented in full*/
                else if (npcLocation == "1-4")//Check if the object is Christopher
                {
                    pbAvatar.Image = Properties.Resources.NPC13Front;//Depending on which side of Christopher we are on, he will turn in a different direction.
                    if (direction == "down")
                    {
                        pbUser4.Image = Properties.Resources.NPC13Back;
                    }
                    else if (direction == "left")
                    {
                        pbUser4.Image = Properties.Resources.NPC13SideR;
                    }
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Christopher", lblSpeaker);//Christopher's message
                    textScroll(milliseconds, "Happy Birthday!          ", lblDialogue);
                    canMove = true;
                    pbUser4.Image = Properties.Resources.NPC13;//Reset his sprite
                }
                else if (npcLocation == "1-5")
                {
                    pbAvatar.Image = Properties.Resources.NPC20Front;
                    pbUser5.Image = Properties.Resources.NPC20SideR;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Carson", lblSpeaker);//Carson's message
                    textScroll(milliseconds, "Wanna buy a fidget spinner?          ", lblDialogue);
                    canMove = true;
                    pbUser5.Image = Properties.Resources.NPC20;

                }
                else if (npcLocation == "1-6")
                {
                    pbAvatar.Image = Properties.Resources.NPC16Front;
                    pbUser6.Image = Properties.Resources.NPC16SideR;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Mitchell", lblSpeaker);//Mitchell's message
                    textScroll(milliseconds, "Gabe is a whale.          ", lblDialogue);
                    canMove = true;
                    pbUser6.Image = Properties.Resources.NPC16;

                }
                else if (npcLocation == "1-7")
                {
                    pbAvatar.Image = Properties.Resources.NPC6Front;
                    pbUser7.Image = Properties.Resources.NPC6SideR;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Matthew", lblSpeaker);//Matt's message
                    textScroll(milliseconds, "Computer science is pretty decent.          ", lblDialogue);
                    canMove = true;
                    pbUser7.Image = Properties.Resources.NPC6Side;

                }
                else if (npcLocation == "1-8")
                {
                    pbAvatar.Image = Properties.Resources.NPC15Front;
                    if (direction == "up")
                    {

                        pbUser8.Image = Properties.Resources.NPC15Front;
                    }
                    else if (direction == "left")
                    {
                        pbUser8.Image = Properties.Resources.NPC15SideR;
                    }
                    pbAvatar.Image = Properties.Resources.NPC15Front;
                    pbUser8.Image = Properties.Resources.NPC15SideR;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Kevin", lblSpeaker);//Kevin's message
                    textScroll(milliseconds, "Varuunan shut off my computer!          ", lblDialogue);
                    canMove = true;
                    pbUser8.Image = Properties.Resources.NPC15;

                }
                else if (npcLocation == "1-10")
                {
                    pbAvatar.Image = Properties.Resources.NPC7Front;
                    if (direction == "down")
                    {
                        pbUser10.Image = Properties.Resources.NPC7Back;
                    }
                    else if (direction == "left")
                    {
                        pbUser10.Image = Properties.Resources.NPC7SideR;
                    }
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Owen", lblSpeaker);//Owen's message
                    textScroll(milliseconds, "I broke my computer….again!!          ", lblDialogue);
                    canMove = true;
                    pbUser10.Image = Properties.Resources.NPC7;

                }
                else if (npcLocation == "1-11")
                {
                    pbAvatar.Image = Properties.Resources.NPC9;
                    if (direction == "up")
                    {
                        pbUser11.Image = Properties.Resources.NPC9;
                    }
                    else if (direction == "left")
                    {
                        pbUser11.Image = Properties.Resources.NPC9sideR;
                    }
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Jatin", lblSpeaker);//Jatin's message
                    textScroll(milliseconds, "I learned that 0==1 is actually false!          ", lblDialogue);
                    canMove = true;
                    pbUser11.Image = Properties.Resources.NPC9side;

                }
                else if (npcLocation == "3-11")
                {
                    pbAvatar.Image = Properties.Resources.NPC1;
                    if (direction == "down")
                    {
                        pbUser31.Image = Properties.Resources.NPC1Back;
                    }
                    else if (direction == "right")
                    {
                        pbUser31.Image = Properties.Resources.NPC1Side;
                    }
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Elisa", lblSpeaker);//Elisa's message
                    textScroll(milliseconds, "As a friend.          ", lblDialogue);
                    canMove = true;
                    pbUser31.Image = Properties.Resources.NPC1;

                }
                else if (npcLocation == "4-11")
                {
                    pbAvatar.Image = Properties.Resources.NPC14;
                    pbUser38.Image = Properties.Resources.NPC14back;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Madison", lblSpeaker);//Madison's message
                    textScroll(milliseconds, "I try but it never works out.          ", lblDialogue);
                    canMove = true;
                    pbUser38.Image = Properties.Resources.NPC14;

                }
                else if (npcLocation == "5-11")
                {
                    pbAvatar.Image = Properties.Resources.NPC2;
                    if (direction == "down")
                    {
                        pbUser45.Image = Properties.Resources.NPC2Back;
                    }
                    else if (direction == "left")
                    {
                        pbUser45.Image = Properties.Resources.NPC2SideR;
                    }
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Niyanta", lblSpeaker);//Niyanta's message
                    textScroll(milliseconds, "I wish I wasn't here.          ", lblDialogue);
                    canMove = true;
                    pbUser45.Image = Properties.Resources.NPC2;
                }
                else if (npcLocation == "9-11")
                {
                    pbAvatar.Image = Properties.Resources.NPC8;
                    if (direction == "down")
                    {
                        pbUser73.Image = Properties.Resources.NPC8Back;
                    }
                    else if (direction == "right")
                    {
                        pbUser73.Image = Properties.Resources.NPC8Side;
                    }
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Peter", lblSpeaker);//Peter's message
                    textScroll(milliseconds, "What's up?          ", lblDialogue);
                    canMove = true;
                    pbUser73.Image = Properties.Resources.NPC8;
                }
                else if (npcLocation == "10-11")
                {
                    pbAvatar.Image = Properties.Resources.NPC5;
                    pbUser83.Image = Properties.Resources.NPC5Back;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Nick", lblSpeaker);//Nick's message
                    textScroll(milliseconds, "Ey boy, nice to meet you!          ", lblDialogue);
                    canMove = true;
                    pbUser83.Image = Properties.Resources.NPC5;
                }
                else if (npcLocation == "11-10")
                {
                    pbAvatar.Image = Properties.Resources.NPC11Front;
                    pbUser92.Image = Properties.Resources.NPC11;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Gawshan", lblSpeaker);//Gawshan's message
                    textScroll(milliseconds, "This game’s a joke, man!          ", lblDialogue);
                    canMove = true;
                    pbUser92.Image = Properties.Resources.NPC11SideR;
                }
                else if (npcLocation == "11-9")
                {
                    pbAvatar.Image = Properties.Resources.NPC24Front;
                    pbUser91.Image = Properties.Resources.NPC24SideL;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Sharuga", lblSpeaker);//Sharuga's message
                    textScroll(milliseconds, "Why am I here?          ", lblDialogue);
                    canMove = true;
                    pbUser91.Image = Properties.Resources.NPC24SideR;
                }
                else if (npcLocation == "11-8")
                {
                    pbAvatar.Image = Properties.Resources.NPC17Front;
                    pbUser90.Image = Properties.Resources.NPC17;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Vipneet", lblSpeaker);//Vipneet's message
                    textScroll(milliseconds, "'I still think I am the greatest.' - Kanye West          ", lblDialogue);
                    canMove = true;
                    pbUser90.Image = Properties.Resources.NPC17SideR;
                }
                else if (npcLocation == "11-7")
                {
                    pbAvatar.Image = Properties.Resources.NPC18Front;
                    pbUser89.Image = Properties.Resources.NPC18;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Mahaksh", lblSpeaker);//Mahaksh's message
                    textScroll(milliseconds, "I'm not ready yet.          ", lblDialogue);
                    canMove = true;
                    pbUser89.Image = Properties.Resources.NPC18SideR;
                }
                else if (npcLocation == "11-6")
                {
                    pbAvatar.Image = Properties.Resources.NPC19Front;
                    pbUser88.Image = Properties.Resources.NPC19;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Chris", lblSpeaker);//Chris's message
                    textScroll(milliseconds, "...          ", lblDialogue);
                    canMove = true;
                    pbUser88.Image = Properties.Resources.NPC19SideR;
                }
                else if (npcLocation == "11-5")
                {
                    pbAvatar.Image = Properties.Resources.NPC22Front;
                    pbUser87.Image = Properties.Resources.NPC22;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Bilal", lblSpeaker);//Bilal's message
                    textScroll(milliseconds, "ulu top kek dat cheffy          ", lblDialogue);
                    canMove = true;
                    pbUser87.Image = Properties.Resources.NPC22SideR;
                }
                else if (npcLocation == "11-4")
                {
                    pbAvatar.Image = Properties.Resources.NPC21Front;
                    pbUser86.Image = Properties.Resources.NPC21;
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Ethan", lblSpeaker);//Ethan's message
                    textScroll(milliseconds, "Wow Ethan! Great moves, keep it up, proud of you!          ", lblDialogue);
                    canMove = true;
                    pbUser86.Image = Properties.Resources.NPC21SideR;
                }
                else if (npcLocation == "11-3")
                {
                    pbAvatar.Image = Properties.Resources.NPC10Front;
                    if (direction == "down")
                    {
                        pbUser85.Image = Properties.Resources.NPC10back;
                    }
                    else if (direction == "right")
                    {
                        pbUser85.Image = Properties.Resources.NPC10;
                    }
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Josh", lblSpeaker);//Josh's message
                    textScroll(milliseconds, "Forehead.          ", lblDialogue);
                    canMove = true;
                    pbUser85.Image = Properties.Resources.NPC10SideR;
                }
                else if (npcLocation == "9-1")
                {
                    pbAvatar.Image = Properties.Resources.KRNIC;
                    if (direction == "up")
                    {
                        pbUser85.Image = Properties.Resources.KRNIC;
                    }
                    else if (direction == "right")
                    {
                        pbUser85.Image = Properties.Resources.KRNICSIDE;
                    }
                    this.Update();//Force graphic update
                    textScroll(milliseconds, "Mr. Krnic", lblSpeaker);//Mr. Krnic's message
                    textScroll(milliseconds, "Everybody listen up!          ", lblDialogue);
                    canMove = true;
                    pbUser85.Image = Properties.Resources.KRNIC;
                }
            }
        }

        void intro()//A sort of tutorial
        {
            if (unit == 1 && day == 1)//Check if it's the first day
            {
                if (welcome == true)
                {
                    pbUser67.Image = Properties.Resources.KRNICSIDE;
                    pbAvatar.Image = Properties.Resources.KRNIC;
                    this.Refresh();
                    textScroll(milliseconds, "Mr. Krnic", lblSpeaker);//Mr. Krnic's welcome mesage
                    textScroll(milliseconds, "Hello there,  " + TitleScreen.playerName + ". Welcome to Computer Science!\nYou're a little late to class, so go stand by one of the open computers. The school has had some budget cuts, so we have no chairs. That computer will be yours for the rest of the semester, so choose wisely.\n                      \nOne more thing. Do NOT look in the back closet under any circumstances.          ", lblDialogue);
                    pbUser67.Image = Properties.Resources.KRNIC;
                    pbAvatar.Image = null;
                    this.Refresh();
                    textScroll(milliseconds, "Objective:", lblSpeaker);//Tell you to find a computer
                    textScroll(milliseconds, "Find a computer.", lblDialogue);
                    canMove = true;//We can move now
                    welcome = false;//Welcome message is over
                }
            }
        }

        /**************************
        *Functions with Parameters*
        **************************/

        void introPt2(string npcLocation)//Second part of the tutorial, contains the special interactions for the first day.
        {
            onIntro = true; //Tell the game we're in the intro  
            if (npcLocation == "0-3" || npcLocation == "0-9" || npcLocation == "6-12" || npcLocation == "7-12" || npcLocation == "8-12")
            {//^Check if the object we are interacting with is one of the open computers^

                computer = npcLocation;//Assign the location of the computer to the computer variable, this allows us to remember which computer is ours.
                pbAvatar.Image = Properties.Resources.KRNIC;
                this.Refresh();
                textScroll(30, "Mr. Krnic", lblSpeaker);//Mr. Krnic tells you about sebnic
                textScroll(40, "Very good!\nWhen you go to use your computer, you'll see the SEBNIC menu pop up on your screen.\nFrom this menu you can learn today's lesson, take a test, or work on any projects you may have.\nThat's all I have to say, so get to work!          ", lblDialogue);
                pbAvatar.Image = null;
                this.Refresh();
                canMove = false;
                SebnicMenu frm = new SebnicMenu();//Load sebnic
                frm.Show();
                this.Hide();
            }

            else if (npcLocation == "3-12")//Check if the location is the computer by the bottom left
            {
                if (lblSpeaker.Text != "Objective:")//Check to see if lblSpeaker is already displaying "Objective:", we don't want to write it again
                {
                    textScroll(milliseconds, "Objective:", lblSpeaker);//Display "Objective:", the label is saying something else
                }
                textScroll(milliseconds, "Nice try, but this computer is taken.          ", lblDialogue);//Tell the user to get a computer that isn't taken
                textScroll(milliseconds, "Find a computer.", lblDialogue);
                canMove = true;
            }
            else if (npcLocation == "10-1")//Check if the location is Mr. Krnic's computer.
            {
                pbAvatar.Image = Properties.Resources.KRNIC;
                this.Refresh();
                textScroll(milliseconds, "Mr. Krnic", lblSpeaker);//Mr. Krnic won't let you take his computer. Oh well.
                textScroll(milliseconds, "Hey! You can't take my computer!          ", lblDialogue);
                pbAvatar.Image = null;
                this.Refresh();
                textScroll(milliseconds, "Objective:", lblSpeaker);
                textScroll(milliseconds, "Find a computer.", lblDialogue);
                canMove = true;
            }
            else if (npcLocation == "-1-1")//Check if the user is trying to leave the room
            {
                pbAvatar.Image = Properties.Resources.KRNIC;
                this.Refresh();
                textScroll(milliseconds, "Mr. Krnic", lblSpeaker);//Mr. Krnic tells them to come back
                textScroll(milliseconds, "Come back! Class just started!          ", lblDialogue);
                pbAvatar.Image = null;
                this.Refresh();
                textScroll(milliseconds, "Objective:", lblSpeaker);
                textScroll(milliseconds, "Find a computer.", lblDialogue);
                canMove = true;
            }
            else if (npcLocation == "0-12")//Check if the location is Z's cabinet
            {
                if (zeeshanFirst == true)//Check if this is our first time meeting him
                {

                    if (TitleScreen.playerName == "Zeeshan")//Easter egg. If your name is Zeeshan, he says a slightly different message. You'll see.
                    {
                        getCurrentLocation();
                        moveRight();
                        pbAvatar.Image = Properties.Resources.NPC3;
                        pbUser12.Image = Properties.Resources.NPC3SideR;
                        this.Refresh();
                        textScroll(milliseconds, "Zeeshan", lblSpeaker);
                        textScroll(milliseconds, "Hey there, I'm Zeeshan. I'm technically not - wait a minute, how can you be Zeeshan? I'm Zeeshan. We can't both be Zeeshan, there can be only one!           ", lblDialogue);
                        pbAvatar.Image = null;
                        pbUser12.Image = null;
                        this.Refresh();
                        zeeshanFirst = false;
                        canMove = true;
                        MessageBox.Show("You died!");
                        TitleScreen frm = new TitleScreen();
                        frm.Show();
                        this.Hide();
                    }
                    else//Base case, when your name is not "Zeeshan"
                    {
                        getCurrentLocation();//Get the player's location
                        moveRight();//Move us to the right
                        pbAvatar.Image = Properties.Resources.NPC3;
                        pbUser12.Image = Properties.Resources.NPC3SideR;
                        this.Refresh();
                        textScroll(milliseconds, "Zeeshan", lblSpeaker);//Write Z's message
                        textScroll(milliseconds, "Hey there, I'm Zeeshan. I'm technically not in this class, but who cares, right?\nListen, if you come back later, maybe I can help you if you're having trouble. Maybe. I'll think about it.\nBye!          ", lblDialogue);
                        pbAvatar.Image = null;
                        pbUser12.Image = null;
                        this.Refresh();
                        zeeshanFirst = false;//Tell the game we've already met him.
                        canMove = true;
                    }
                }
                else//If we've already met Z
                {
                    pbAvatar.Image = Properties.Resources.AvatarFront;
                    this.Refresh();
                    textScroll(milliseconds, "You", lblSpeaker);//Your thoughts on Z
                    textScroll(milliseconds, "Looks like Zeeshan isn't coming back today...         ", lblDialogue);
                    pbAvatar.Image = null;
                    this.Refresh();
                    canMove = true;
                }
            }
            else if (npcLocation == "12-2")//Check if we're looking at the other cabinet by Mr. Krnic's desk
            {
                //do nothing, we have code for this in the interact() function
            }
            else//else we are interacting with nothing important, tell the user they need to find a computer.
            {
                if (lblSpeaker.Text != "Objective:")
                {
                    textScroll(milliseconds, "Objective:", lblSpeaker);
                }
                textScroll(milliseconds, "That is not a computer.          ", lblDialogue);
                textScroll(milliseconds, "Find a computer.", lblDialogue);
                canMove = true;
            }
        }

        void textScroll(int milliseconds, string text, Label label)//This function draws text in a label one letter at a time
        {
            canMove = false;//Can't move during dialogue
            label.Text = "";//Clear the label
            for (int x = 0; x < text.Length; x++)//Loop through each character in the string
            {
                String character = text.Substring(x, 1);//Get a single character, using the substring function
                label.Text += character;//Write the character
                Thread.Sleep(milliseconds);//Delay
                label.Update();//Force graphic update
            }
        }

        /**************
        *End Functions*
        **************/

        public Classroom()
        {
            InitializeComponent();
        }

        private void Classroom_Load(object sender, EventArgs e)//When the form loads
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
            setFont();//Set the font of the controls
            if (TitleScreen.loadLastGame == true)//If the player selected load game on the title screen...
            {
                loadData();//...load the saved game
                TitleScreen.loadLastGame = false;
            }
            pbUser1.Image = Properties.Resources.AvatarFront;//Load the avatar
            this.Refresh();//Force update
            lblDay.Text = "Day " + day;//Load the current day         
            lblName.Text = TitleScreen.playerName;//Load the player's name
            lblMark.Text = courseMark + "%";
            this.ActiveControl = null;//Set the focus to none
            onIntro = false;//Not on the intro
        }

        private void Classroom_Shown(object sender, EventArgs e)//When the form is shown on the screen, after it loads
        {
            this.Refresh();//force update
            if (unit == 1 && day == 1)//if its the first day...
            {
                intro();//...do the intro
            }
            else
            {
                newLesson();//...or else its just a regular day
            }
        }

        private void Classroom_KeyDown(object sender, KeyEventArgs e)
        {
            if (canMove == true)//If we are allowed to move
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.W || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
                {//^You can use both the arrow keys and WASD to move
                    getCurrentLocation();//Get our location
                    if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                    {
                        character = Properties.Resources.AvatarFront;//Change the sprite depending on the direction we are facing
                        direction = "down";//Change the direction variable to reflect this change
                        moveDown();//move the player in the desired direction
                    }
                    else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                    {
                        character = Properties.Resources.AvatarBack;
                        direction = "up";
                        moveUp();
                    }
                    else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                    {
                        character = Properties.Resources.AvatarSideL;
                        direction = "left";
                        moveLeft();
                    }
                    else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                    {
                        character = Properties.Resources.AvatarSideR;
                        direction = "right";
                        moveRight();
                    }

                }
                else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)//Enter or space to interact
                {
                    interact();//initiate interaction with the object
                }
            }
        }

        private void Classroom_FormClosed(object sender, FormClosedEventArgs e)//When the form is closed
        {
            saveData();//Save the game
            Application.Exit();//Close the program
        }

        private void lblHelp_Click(object sender, EventArgs e)//When the help button is clicked
        {
            HelpMenu frm = new HelpMenu();//Show the help menu
            frm.Show();
        }

        private void lblQuit_Click(object sender, EventArgs e)//When the user hits the "quit" button
        {            
            saveData();//Save the game
            Application.Exit();//Close the program
        }

        private void pbMusic_Click(object sender, EventArgs e)
        {
            toggleMusic();
        }
    }
}