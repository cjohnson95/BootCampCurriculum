using System;

namespace BootCampCurriculum {
    class Program {
      

       

        static void Main(string[] args) 
        {

            var gitgithub = new Topic();
            
            gitgithub.Name = "Git/Github";
            gitgithub.Category = "SCM";
            gitgithub.Difficulty = 2;
            gitgithub.Print();

            var sqlserver = new Topic() {
                Name = "SQL Server",
                Category = "Database",
                Difficulty = 3
            };
            sqlserver.Print(); 
            
        }
    }
}

