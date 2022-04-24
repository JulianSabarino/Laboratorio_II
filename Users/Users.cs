using System;
using System.Collections.Generic;
using System.Text;
namespace Users
{
    public enum genre
    {
        Masculino,
        Femenino
    }
    public class User
    {
        private string name;
        private string surname;
        private string dir;
        private DateTime borndate;
        private string country;
        private genre genero;
        private List<string> cursos;

        public string csvCourses
        {
            get
            {
                StringBuilder courseList = new StringBuilder();
                foreach (string curso in cursos)
                {
                    courseList.AppendFormat("{0},",curso);
                }

                return courseList.ToString();
            }
        }

        public void setCourses(List<string> courseList)
        {
            cursos = courseList;
        }

        public User(string nName, string nSurname, string nDir, string nHalt, DateTime nBDate, string nCountry, genre nGenero)
        {
            name = nName;
            surname = nSurname;
            dir = nDir + " " +nHalt;
            borndate = nBDate;
            country = nCountry;
            genero = nGenero;
        }

        public string GetData()
        {
            StringBuilder data = new StringBuilder();
            data.AppendFormat("Full Name: {0} {1} {2}" +
                "Direction: {3} {4}" +
                "Born Info: {5} {6} {7} {8}" +
                "Courses {9}",
                name,surname,Environment.NewLine,
                dir, Environment.NewLine,
                country, borndate.ToString("dd MMM yyyy"),genero, Environment.NewLine,
                csvCourses);

            return data.ToString();
        
        }

    }
}
