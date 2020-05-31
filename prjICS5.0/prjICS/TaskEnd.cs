/*Interactive Course Simulator: Computer Science 2017
 * June 15th, 2017
 * By Kevin, Owen and Jatin
 * This is the TaskEnd form, it pops up when you complete a lesson or test
 * and displays how well you did on the task*/
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

namespace prjICS
{
    public partial class TaskEnd : Form
    {

        void textScroll(int milliseconds, string text, Label label)//Same Textscroll from the title screen form. see documentation in that form
        {
            label.Text = "";
            for (int x = 0; x < text.Length; x++)
            {
                String character = text.Substring(x, 1);
                label.Text += character;
                Thread.Sleep(milliseconds);
                label.Update();
            }
        }

        public TaskEnd()
        {
            InitializeComponent();
        }

        private void LessonEnd_Shown(object sender, EventArgs e)
        {
            lblLessonEndText.Text = "";
            this.Refresh();
            if (SebnicMenu.lesson == true)//if you did a lesson
            {
                Double rightAnswers = Lesson.rightAnswers;
                Double lessonMark = (rightAnswers / 5) * 100;//calculates your mark
                if (SebnicMenu.lessonNum == 1)//sets what lesson was just attempted
                {
                    SebnicMenu.lesson1Attempted = true;
                }
                else if (SebnicMenu.lessonNum == 2)
                {
                    SebnicMenu.lesson2Attempted = true;
                }
                else if (SebnicMenu.lessonNum == 3)
                {
                    SebnicMenu.lesson3Attempted = true;
                }
                else if (SebnicMenu.lessonNum == 4)
                {
                    SebnicMenu.lesson4Attempted = true;
                }
                else if (SebnicMenu.lessonNum == 5)
                {
                    SebnicMenu.lesson5Attempted = true;
                }
                //textscroll the unit, lesson and your score
                textScroll(30, "Unit " + SebnicMenu.currentUnitTab + " Lesson " + SebnicMenu.lessonNum + " completed!\nYou scored:\n\n" + Lesson.rightAnswers + " out of 5\n" + lessonMark + "%", lblLessonEndText);
            }
            else if (SebnicMenu.test == true)
            {
                Double rightAnswers = Test.rightAnswers;
                Double testMark = (rightAnswers / 10) * 100;//calculates your mark
                Classroom.courseMark = (Classroom.courseMark + testMark) / 2;
                //textscroll unit, and score
                textScroll(30, "Unit " + Classroom.unit + " Test completed!\nYou scored:\n\n" + Test.rightAnswers + " out of 10\n" + testMark + "%", lblLessonEndText);
                //resets what lessons have been attempted
                if (SebnicMenu.currentUnitTab != 2 && SebnicMenu.currentUnitTab != 4 && SebnicMenu.currentUnitTab != 5)
                {
                    SebnicMenu.lesson1Attempted = false;
                    SebnicMenu.lesson2Attempted = false;
                    SebnicMenu.lesson3Attempted = false;
                    SebnicMenu.lesson4Attempted = false;
                    SebnicMenu.lesson5Attempted = false;
                    Classroom.unit++;
                }
                else
                {
                    SebnicMenu.showAssignment = true;
                }
            }         
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Classroom.day++;//moves on to the next day
            //shows the clasroom form
            Classroom frm = new Classroom();
            frm.Show();
            this.Hide();
        }
    }
}