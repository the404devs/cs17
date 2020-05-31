using System;
using System.Drawing;
using System.Windows.Forms;

namespace prjICS
{
    public partial class SebnicMenu : Form
    {
        /************
        **Variables**
        ************/
        public static int currentUnitTab = 1;//the unit tab that you are on
        public static int lessonNum = 1;//the lesson number you picked
        public static int unitTestSelected = 0;//the unit test number you picked
        public static Boolean lesson1Attempted = false;//*self explanitory
        public static Boolean lesson2Attempted = false;//
        public static Boolean lesson3Attempted = false;//
        public static Boolean lesson4Attempted = false;//
        public static Boolean lesson5Attempted = false;//
        public static Boolean lesson = false;//if you are doing a lesson
        public static Boolean test = false;//if you are doing a test
        public static Boolean showAssignment = false;//should the game show an assignment
        public static int daysBeforeTest = 0;//number of days before a test is manditory

        /************
        **Functions**
        ************/

        void allVisibilityOff()//turns the visibility off for all lesson, test, and assignment labels, and the tabel panel.
        {
            visibilityOff();
            lblUnit4Test.Visible = false;
            lblUnit3Test.Visible = false;
            lblUnit2Test.Visible = false;
            lblUnit1Test.Visible = false;
            //lblUnit2Assignment.Visible = false;
            //lblUnit4Assignment.Visible = false;
            //lblFinal.Visible = false;
        }

        void visibilityOff()//turns the visibility off for all lesson labels
        {
            lblLesson5.Visible = false;
            lblLesson4.Visible = false;
            lblLesson3.Visible = false;
            lblLesson2.Visible = false;
            lblLesson1.Visible = false;
        }

        void visibilityOn()//turns the visibility on for all lesson labels
        {
            lblLesson5.Visible = true;
            lblLesson4.Visible = true;
            lblLesson3.Visible = true;
            lblLesson2.Visible = true;
            lblLesson1.Visible = true;
        }

        void unboldUnits()//unbold all unit tab labels
        {
            lblUnit1.Font = new Font(lblUnit1.Font, FontStyle.Regular);
            lblUnit2.Font = new Font(lblUnit2.Font, FontStyle.Regular);
            lblUnit3.Font = new Font(lblUnit3.Font, FontStyle.Regular);
            lblUnit4.Font = new Font(lblUnit4.Font, FontStyle.Regular);
        }

        void unitVisibilityCheck()//determines what label should be visible depending on what unit you are on
        {           
            if (lesson5Attempted == true)//if lesson 5 has been attempted
            {
                visibilityOn();
                if (Classroom.unit == 5)
                {
                    lblFinal.Visible = true;
                }
                if (Classroom.unit == 4)
                {
                    if (daysBeforeTest != 3)//this lets you do the test and the lessons
                    {
                        //lblUnit4Assignment.Visible = true;
                        lblUnit4Test.Visible = true;
                    }
                    else//this hides everything except for the test
                    {
                        allVisibilityOff();
                        lblUnit4Test.Visible = true;
                    }
                }
                else if (Classroom.unit == 3)
                {
                    if (daysBeforeTest != 3)//this lets you do the test and the lessons
                    {
                        lblUnit3Test.Visible = true;
                    }
                    else//this hides everything except for the test
                    {
                        allVisibilityOff();
                        lblUnit3Test.Visible = true;
                    }
                }
                else if (Classroom.unit == 2)
                {
                    if (daysBeforeTest != 3)//etc..............
                    {
                        lblUnit2Test.Visible = true;
                    }
                    else
                    {
                        allVisibilityOff();
                        lblUnit2Test.Visible = true;
                    }
                }
                else if (Classroom.unit == 1)
                {
                    if (daysBeforeTest != 3)
                    {
                        lblUnit1Test.Visible = true;
                    }
                    else
                    {
                        allVisibilityOff();
                        lblUnit1Test.Visible = true;
                    }
                }
            }
            else if (Classroom.unit == currentUnitTab)//if the unit is equal to the unit tab that you are on
            {
                lessonVisibilityCheck();//checks what lessons should be shown
            }
            else if (Classroom.unit > currentUnitTab)//if the unit is greater than the unit tab that you are on
            {
                visibilityOn();
            }
            else
            {
                visibilityOff();
            }
        }

        void lessonVisibilityCheck()
        {
            allVisibilityOff();
            if (showAssignment == true)
            {
                if (Classroom.unit == 2)
                {
                    lblUnit2Assignment.Visible = true;
                }
                else if (Classroom.unit == 4)
                {
                    lblUnit4Assignment.Visible = true;
                }
                else if (Classroom.unit == 5)
                {
                    lblFinal.Visible = true;
                }
            }
            if (lesson5Attempted == true)
            {
                visibilityOn();
                if (Classroom.unit == 4)//checks what unit you are on and picks what test should be shown
                {
                    if (daysBeforeTest != 3)//shows test with lessons
                    {
                        lblUnit4Test.Visible = true;
                        daysBeforeTest++;//adds to the days before a test
                    }
                    else//shows test without lessons
                    {
                        allVisibilityOff();
                        lblUnit4Test.Visible = true;
                    }
                }
                else if (Classroom.unit == 3)//etc.............
                {
                    if (daysBeforeTest != 3)
                    {
                        lblUnit3Test.Visible = true;
                        daysBeforeTest++;
                    }
                    else
                    {
                        allVisibilityOff();
                        lblUnit3Test.Visible = true;
                    }
                }
                else if (Classroom.unit == 2)
                {
                    if (daysBeforeTest != 3)
                    {
                        lblUnit2Test.Visible = true;
                        daysBeforeTest++;
                    }
                    else
                    {
                        allVisibilityOff();
                        lblUnit2Test.Visible = true;
                    }
                }
                else if (Classroom.unit == 1)
                {
                    if (daysBeforeTest != 3)
                    {
                        lblUnit1Test.Visible = true;
                        daysBeforeTest++;
                    }
                    else
                    {
                        allVisibilityOff();
                        lblUnit1Test.Visible = true;
                    }
                }
            }
            else if (lesson4Attempted == true || currentUnitTab < Classroom.unit)//if lesson4 had been attempted or the current unit tab is less than the actual unit
            {
                visibilityOn();//turn all lesson labels on
            }
            else if (lesson3Attempted == true)//if lesson 3 has been attempted
            {
                lblLesson5.Visible = false;//turns all lesson labels on except for #5
                lblLesson4.Visible = true;
                lblLesson3.Visible = true;
                lblLesson2.Visible = true;
                lblLesson1.Visible = true;
            }
            else if (lesson2Attempted == true)
            {
                lblLesson5.Visible = false;//turns all lesson labels on except for #5, #4
                lblLesson4.Visible = false;
                lblLesson3.Visible = true;
                lblLesson2.Visible = true;
                lblLesson1.Visible = true;
            }
            else if (lesson1Attempted == true)
            {
                lblLesson5.Visible = false;//turns all lesson labels on except for #5, #4 #3
                lblLesson4.Visible = false;
                lblLesson3.Visible = false;
                lblLesson2.Visible = true;
                lblLesson1.Visible = true;
            }
            else
            {
                lblLesson5.Visible = false;//turns all lesson labels off except for #1
                lblLesson4.Visible = false;
                lblLesson3.Visible = false;
                lblLesson2.Visible = false;
                lblLesson1.Visible = true;
            }

        }
        
        public SebnicMenu()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            //sends you to the classroom form
            Classroom frm = new Classroom();
            frm.Show();
            this.Hide();
        }

        private void SebnicMenu_Load(object sender, EventArgs e)
        {
            lblMark.Text = "Current Mark: " + Classroom.courseMark + "%";//shows your current mark
            lesson = false;
            test = false;
            //showAssignment = false;
            currentUnitTab = Classroom.unit;
            unboldUnits();
            if (currentUnitTab == 1)
            {
                lblUnit1.Font = new Font(lblUnit1.Font, FontStyle.Bold);
            }
            else if (currentUnitTab == 2)
            {
                lblUnit2.Font = new Font(lblUnit2.Font, FontStyle.Bold);
            }
            else if (currentUnitTab == 3)
            {
                lblUnit3.Font = new Font(lblUnit3.Font, FontStyle.Bold);
            }
            else if (currentUnitTab == 4)
            {
                lblUnit4.Font = new Font(lblUnit4.Font, FontStyle.Bold);
            }
            //unit description
            lblDescription.Text = "This unit focuses on basic computer and information science skills. Students identify hardware components, research ergonomic considerations, practise file management skills, access resources through local and wide area networks, and research the evolution of programming languages. They develop skills for success in the computer and information science environment. Students focus on the Computer and Information Science environment; students also examine respect for the environment and wise use of resources from a responsible perspective.";
            unitVisibilityCheck();//check what units should be visible
            lessonVisibilityCheck();//checks what lessons should be visible
        }


        private void lblUnit1_Click(object sender, EventArgs e)
        {
            unboldUnits();//unbolds all unit tabs
            lblUnit1.Font = new Font(lblUnit1.Font, FontStyle.Bold);//makes the unit 1 tab bolded
            currentUnitTab = 1;

            //unit description
            lblDescription.Text = "This unit focuses on basic computer and information science skills. Students identify hardware components, research ergonomic considerations, practise file management skills, access resources through local and wide area networks, and research the evolution of programming languages. They develop skills for success in the computer and information science environment. Students focus on the Computer and Information Science environment; students also examine respect for the environment and wise use of resources from a responsible perspective.";
            unitVisibilityCheck();//determines what label should be visible depending on what unit you are on
            lessonNum = 0;
        }

        private void lblUnit2_Click(object sender, EventArgs e)
        {
            unboldUnits();//etc.....................
            lblUnit2.Font = new Font(lblUnit2.Font, FontStyle.Bold);
            currentUnitTab = 2;
            lblDescription.Text = "This unit focuses on basic programming structures. Students write simple programs, using variable assignment, repetition, and decision structures, and develop effective testing, validating, and documenting skills. They also explore roles of effective communicators and reflective thinkers when following a problem-solving model (e.g., user inputs a series of marks, each value is validated, the average is calculated, and a grade is assigned).";
            unitVisibilityCheck();
            lessonNum = 0;
        }

        private void lblUnit3_Click(object sender, EventArgs e)
        {
            unboldUnits();
            lblUnit3.Font = new Font(lblUnit3.Font, FontStyle.Bold);
            currentUnitTab = 3;
            lblDescription.Text = "This unit focuses on using problem solving strategies in the computer science field as well as investigation into societal issues involving computer technology.  This includes an exploration of careers in computer studies. Students also examine issues surrounding privacy, security, and ethical use of information.";
            unitVisibilityCheck();
            lessonNum = 0;
        }

        private void lblUnit4_Click(object sender, EventArgs e)
        {
            unboldUnits();
            lblUnit4.Font = new Font(lblUnit4.Font, FontStyle.Bold);
            currentUnitTab = 4;
            lblDescription.Text = "This unit focuses on the advanced features of programming. For example students learn about data storage and manipulation. They also write programs that input data from existing files, process the data, and create files for external data storage, following an appropriate problem-solving model (e.g., Create a data file containing employee information including hours worked and rate of pay. Read from the file, compute, display, and write to a new file the gross pay for each employee.). In addition modular programming is introduced. Data structures such as arrays are taught. Common algorithms like the Bubble Sort are examined. Students are expected to incorporate as many of these more complex programming features in their final summative project.";
            unitVisibilityCheck();
            lessonNum = 0;
        }

        private void lblLesson1_Click(object sender, EventArgs e)
        {
            //lesson # for lesson form
            lessonNum = 1;
            lesson = true;
            //opens the lesson form
            Lesson frm = new Lesson();
            frm.Show();
            this.Hide();
        }

        private void lblLesson2_Click(object sender, EventArgs e)
        {
            //lesson # for lesson form
            lessonNum = 2;
            lesson = true;
            //opens the lesson form
            Lesson frm = new Lesson();
            frm.Show();
            this.Hide();
        }

        private void lblLesson3_Click(object sender, EventArgs e)
        {
            //lesson # for lesson form
            lessonNum = 3;
            lesson = true;
            //opens the lesson form
            Lesson frm = new Lesson();
            frm.Show();
            this.Hide();
        }

        private void lblLesson4_Click(object sender, EventArgs e)
        {
            //lesson # for lesson form
            lessonNum = 4;
            lesson = true;
            //opens the lesson form
            Lesson frm = new Lesson();
            frm.Show();
            this.Hide();
        }

        private void lblLesson5_Click(object sender, EventArgs e)
        {
            //lesson # for lesson form
            lessonNum = 5;
            lesson = true;
            //opens the lesson form
            Lesson frm = new Lesson();
            frm.Show();
            this.Hide();
        }


        private void lblUnit1Test_Click(object sender, EventArgs e)
        {
            daysBeforeTest = 0;
            unitTestSelected = 1;
            test = true;
            //opens the test form
            Test frm = new Test();
            frm.Show();
            this.Hide();
            
        }

        private void lblFinal_Click(object sender, EventArgs e)
        {
            currentUnitTab = 5;
            Battle frm = new Battle();
            frm.Show();
            this.Hide();
        }

        private void lblUnit2Assignment_Click(object sender, EventArgs e)
        {
            currentUnitTab = 2;
            Battle frm = new Battle();
            frm.Show();
            this.Hide();
        }

        private void lblUnit3Test_Click(object sender, EventArgs e)
        {
            daysBeforeTest = 0;
            unitTestSelected = 3;
            test = true;
            //opens the test form
            Test frm = new Test();
            frm.Show();
            this.Hide();
        }

        private void lblUnit4Assignment_Click(object sender, EventArgs e)
        {
            currentUnitTab = 4;
            Battle frm = new Battle();
            frm.Show();
            this.Hide();
        }

        private void lblUnit4Test_Click(object sender, EventArgs e)
        {
            daysBeforeTest = 0;
            unitTestSelected = 4;
            test = true;
            //opens the test form
            Test frm = new Test();
            frm.Show();
            this.Hide();
        }

        private void lblUnit2Test_Click(object sender, EventArgs e)
        {
            daysBeforeTest = 0;
            unitTestSelected = 2;
            test = true;
            //opens the test form
            Test frm = new Test();
            frm.Show();
            this.Hide();
        }
    }
}
