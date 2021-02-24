using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_Asg11_Structures
{
    //the book told me to put the structure here but
    //declaring my structure
    struct Course
    {
        public String courseNumber;
        public String courseName;
        public int numberOfCredits;
        public String grade;
        public Course(String courseNumber, String courseName,
            int numberOfCredits, String grade)
        {
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.numberOfCredits = numberOfCredits;
            this.grade = grade;
        }

    }
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        //declaring my list to hold the data
        List<Course> courseList = new List<Course>();
        int indexCourseList = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //declaring a course object to load all our courses on app start
            Course course;
            //text editor coming in clutch
            course = new Course("10152100", "Database Concepts and SQL", 3, "NA");
            courseList.Add(course);
            course = new Course("10152101", "Web Design and Development", 3, "NA");
            courseList.Add(course);
            course = new Course("10152102", "Advanced Web Site Development", 3, "NA");
            courseList.Add(course);
            course = new Course("10152106", "Java Programming - Beginning", 3, "NA");
            courseList.Add(course);
            course = new Course("10152107", "Java Programming - Advanced", 3, "NA");
            courseList.Add(course);
            course = new Course("10152108", "Enterprise Java Programming", 3, "NA");
            courseList.Add(course);
            course = new Course("10152110", "Programming in SQL", 3, "NA");
            courseList.Add(course);
            course = new Course("10152111", "Systems Analysis and Design", 3, "NA");
            courseList.Add(course);
            course = new Course("10152112", "Server-Side Web Development", 3, "NA");
            courseList.Add(course);
            course = new Course("10152113", "Applications Development", 3, "NA");
            courseList.Add(course);
            course = new Course("10152115", "Beginning .NET Programming", 3, "NA");
            courseList.Add(course);
            course = new Course("10152116", "Web Tools of the Trade", 3, "NA");
            courseList.Add(course);
            course = new Course("10152117", "Advanced .NET Programming", 3, "NA");
            courseList.Add(course);
            course = new Course("10152118", "Enterprise Programming in .NET", 3, "NA");
            courseList.Add(course);
            course = new Course("10152119", "Development in Emerging Technologies", 3, "NA");
            courseList.Add(course);
            course = new Course("10152135", "Program Logic", 3, "NA");
            courseList.Add(course);

            loadNextClass();
        }
        private void loadNextClass()
        {
            //displaying our data from the list
            textBoxDisplayNumber.Text = courseList[indexCourseList].courseNumber;
            textBoxDisplayName.Text = courseList[indexCourseList].courseName;
            textBoxDisplayCredits.Text = courseList[indexCourseList].numberOfCredits.ToString();
            textBoxDisplayGrade.Text = courseList[indexCourseList].grade;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //logic for updating the course we are viewing
            //since we are going forward in the list with
            //this button we want to know when we're at the
            //end of the list and reset the index to zero
            //to display the first item in the list
            if (indexCourseList == courseList.Count -1)
            {
                indexCourseList = 0;
                loadNextClass();
            }
            else
            {
                indexCourseList++;
                loadNextClass();
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //logic for updating the course we are viewing
            //Since we are going backwards we want to know when we 
            //reach index zero and then set our index to the last 
            //item in the list
            if (indexCourseList == 0)
            {
                indexCourseList = courseList.Count -1;
                loadNextClass();
            }
            else
            {
                indexCourseList--;
                loadNextClass();
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //declaring a temporary Course to hold updated info
            Course currentCourse = courseList[indexCourseList];
            //getting user input for their grade
            currentCourse.grade = textBoxDisplayGrade.Text;
            //updating the current course in the list
            courseList[indexCourseList] = currentCourse;

        }
    }
}
