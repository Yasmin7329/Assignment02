using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInfo
{
    //Project class declaration
    public class Project
    {
        //Field declaration and only in this class they can be used because they are private
        private string name;
        private string status;
        private string description;

        //Contructor declaration (parameters: nameProject, statusProject, and descriptionProject. All are string type
        public Project(string nameProject, string statusProject, string descriptionProject)
        {
            this.name = nameProject;
            this.status = statusProject;
            this.description = descriptionProject;
        }

        //This method with return all the information declared and it returns a string in the console screen
        public override string ToString()
        {
            return this.name + " \n<" + this.status + "," + this.description + ">";

            //Output:

            //Project 4                                                                               
            //<On hold,This project is reviewing the nonfunctional and functional requirements> 

        }
    }
}
