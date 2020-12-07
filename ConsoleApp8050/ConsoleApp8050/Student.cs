using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupInfo;

namespace StudentInfo
{
    //Student class declaration
    public class Student
    {
        //Field declaration and only in this class they can be used because they are private
        private string name;
        private string studentId;
        private Group group;

        //Constructor declaration (perementers: nameStudent, studentId, and the class "Group")
        public Student(string nameStudent, string studentId, Group group)
        {
            this.name = nameStudent;
            this.studentId = studentId;
            this.group = group;
        }

        //This method with return all the information declared and it returns a string in the console screen
        public override string ToString()
        {
                    
         return ("*STUDENT INFORMATION*" + "\n" + "Student name: " + name + "\n" + "Student ID: " + studentId + "\n\n" + "*GROUP INFORMATION: *" + "\n" + group );

            //Output:
            //*STUDENT INFORMATION*                                                                         
            //Student name: James Lopez                                                     
            //Student ID: 6541355 
            
            //*GROUP INFORMATION: *
            //Group category: Medium 
            //Number of student is 1                                                                     
            //Project 4 
            //< On hold,This project is reviewing the nonfunctional and functional requirements>
        }
    }
}
