using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupCategoryInfo;
using ProjectInfo;
using StudentInfo;

namespace GroupInfo
{
    //Group class declaration
    public class Group
    {
        //Field declaration and only in this class they can be used because they are private
        private int numOfStudent;
        private GroupCategory groupCategory;
        private Project project;

        //Constructor declaration (perementer call "GroupCategory")
        public Group(GroupCategory groupCategory)
        {
            this.groupCategory = groupCategory;
        }

        //Methods declaration (non-static)
        public void AssignProject(Project project)
        {
            this.project = project;
        }

        public void AddStudent(Student student)
        {
            numOfStudent++;
        }

        //This method with return all the information declared and it returns a string in the console screen
        public override string ToString()
        {
            return string.Format("Group category: " + groupCategory + "\n" + "Number of student is " + numOfStudent);

            //Output:

            //Group category: Medium 
            //Number of student is 1
        }
    }
}
