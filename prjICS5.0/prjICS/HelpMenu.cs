using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace prjICS
{
    public partial class HelpMenu : Form
    {
        public static Double[] marks = new double[7];
        public static String[] names = new String[7];
        void setFont()//Loads our custom font
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("acme_explosive.TTF");
            foreach (Control c in Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size - 4);
            }
        }

        void readMarks()
        {
            int x = 0;
            string line;
            if (File.Exists("marks.txt") == true)//Check if there are any highscores saved. If there are, load them
            {
                // Read the file line by line, putting each value into the highScore array
                StreamReader file = new StreamReader("marks.txt");
                while ((line = file.ReadLine()) != null)
                {
                    marks[x] = Convert.ToDouble(line);
                    x++;
                }
                file.Close();
            }
        }

        void readNames()
        {
            int x = 0;
            string line;
            if (File.Exists("names.txt") == true)//Check if there are any highscores saved. If there are, load them
            {
                // Read the file line by line, putting each value into the highScore array
                StreamReader file = new StreamReader("names.txt");
                while ((line = file.ReadLine()) != null)
                {
                    names[x] = line;
                    x++;
                }
                file.Close();
            }
        }

        void saveMarks()
        {
            //Output the scores to a text file.
            StreamWriter file = new StreamWriter("marks.txt");
            for (int x = 0; x < marks.Length; x++)
            {
                file.WriteLine(marks[x]);
            }
            file.Close();
        }

        void saveNames()
        {
            //Output the scores to a text file.
            StreamWriter file = new StreamWriter("names.txt");
            for (int x = 0; x < names.Length; x++)
            {
                file.WriteLine(names[x]);
            }
            file.Close();
        }

        void sortScores()
        {
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    //checks if highScore is less than the highScore above it in the array
                    if (marks[y] < marks[y + 1])
                    {
                        //highscores switch places
                        double tempMark = marks[y];
                        marks[y] = marks[y + 1];
                        marks[y + 1] = tempMark;
                        //Switch the corresponding names to the scores just swapped.
                        String tempName = "";
                        tempName = names[y];
                        names[y] = names[y + 1];
                        names[y + 1] = tempName;

                    }
                }
            }
            //sets the marks to the labels
            lblMark1.Text = marks[0] + "%";
            lblMark2.Text = marks[1] + "%";
            lblMark3.Text = marks[2] + "%";
            lblMark4.Text = marks[3] + "%";
            lblMark5.Text = marks[4] + "%";
            lblMark6.Text = marks[5] + "%";
            //sets the names to the labels
            lblName1.Text = names[0];
            lblName2.Text = names[1];
            lblName3.Text = names[2];
            lblName4.Text = names[3];
            lblName5.Text = names[4];
            lblName6.Text = names[5];
        }

        public HelpMenu()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HelpMenu_Load(object sender, EventArgs e)
        {
            setFont();
            readMarks();
            readNames();
            sortScores();
        }

        private void lnlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://sdsscomputers.com/GoodwinOwen/index.html");//Opens our website
        }
    }
}
