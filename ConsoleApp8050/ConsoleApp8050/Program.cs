using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Here, we will call all the classes with the methods and variables corresponded
using StudentInfo;
using ProjectInfo;
using GroupInfo;
using GroupCategoryInfo;

namespace PROG8050Assignment2
{
    //Test class declaration
    public class TestClassAssignment
    {
        public static void Main(string[] args)
        {
            Project project1 = new Project("Project 1:", "New", "This project will be fix interface issues in the main page");

            Group group1 = new Group(GroupCategory.Small);
            Student student1 = new Student("Yasmin Bitar", "8687239", group1);
            group1.AddStudent(student1);
            group1.AssignProject(project1);
            
            
            Console.WriteLine(student1);
            Console.WriteLine(project1);



            Console.WriteLine("\n\t...................................................................\n");


            Project project2 = new Project("Project 2:", "In progress", "This project is doing the UNit tests in the user page (automated testing)");

            Group group2 = new Group(GroupCategory.Medium);
            Student student2 = new Student("Kate Morrison", "3123412", group2);
            group2.AddStudent(student2);
            group2.AssignProject(project2);
            
            
            Console.WriteLine(student2);
            Console.WriteLine(project2);


            Console.WriteLine("\n\t...................................................................\n");


            Project project3 = new Project("Project 3", "Completed", "This project reviewed the key features in three pages (user, login, and information page)");
            Group group3 = new Group(GroupCategory.Advance);
            Student student3 = new Student("Lucy Smith", "6725312", group3);
            group3.AddStudent(student3);
            group3.AssignProject(project3);

            Console.WriteLine(student3);
            Console.WriteLine(project3);

            
            Console.WriteLine("\n\t...................................................................\n");


            Project project4 = new Project("Project 4", "On hold", "This project is reviewing the nonfunctional and functional requirements");
            Group group4 = new Group(GroupCategory.Medium);
            Student student4 = new Student("James Lopez", "6541355", group4);
            group4.AddStudent(student4);
            group4.AssignProject(project4);

            Console.WriteLine(student4);
            Console.WriteLine(project4);

            Console.WriteLine("\n\t...................................................................\n");
        }
    }
}
