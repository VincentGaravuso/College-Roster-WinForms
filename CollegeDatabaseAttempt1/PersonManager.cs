using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDatabaseAttempt1
{
    public class PersonManager
    {
        public List<Person> p = new List<Person>();
        

        public List<String> DisplayAll()//displays all the people in the database
        {

            List<String> Display = new List<String>();
            Display.Add("\n");
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i] is Student)
                {
                    Student s = (Student)p[i];
                    Display.Add("Student: " + s.name);
                }
                else if (p[i] is Professor)
                {
                    Professor x = (Professor)p[i];
                    Display.Add("Professor: " + x.name);
                }
            }
            return Display;
        }

        public List<String> DisplayAllStudents()
        {
            List<String> Display = new List<String>();
            Display.Add("\n");
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i] is Student)
                {
                    Student s = (Student)p[i];
                    Display.Add("Name: " + s.name);
                }
            }
            return Display;

        }

        public List<String> DisplayAllProfessors()
        {
            List<String> Display = new List<String>();
            Display.Add("\n");
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i] is Professor)
                {
                    Professor x = (Professor)p[i];
                    Display.Add("Name: " + x.name);
                }
            }
            return Display;

        }


        public List<String> DisplayByName(string name)
        {
            List<String> Display = new List<String>();
            Display.Add("\nName not found");
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].name.ToLower() == name.ToLower())
                {
                    Display.RemoveAt(0); //Removes the name not found default value
                    Display.Add("\n");

                    if (p[i] is Student)
                    {
                        Student s = (Student)p[i];
                        Display.Add("Name: " + s.name);
                        Display.Add("Address: " + s.address);
                        Display.Add("GPA: " + s.gpa);
                    }
                    else if (p[i] is Professor)
                    {
                        Professor x = (Professor)p[i];
                        Display.Add("Name: " + x.name);
                        Display.Add("Address: " + x.address);
                        Display.Add("Salary: " + x.salary);
                    }
                }
            }
            return Display;
        }

        public String RemoveByName(String name)
        {
            String removed = "Name not found";
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].name.ToLower() == name.ToLower())
                {
                    p.RemoveAt(i);
                    removed = "Successfully Removed";
                }
            }
            return removed;
        }

        public String GetObjType(String name)
        {
            String update = "Name not found";
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].name == name.ToLower())
                {
                    if (p[i] is Student)//If it is a student or professor it will return that
                                        //value in string so the decision form can decide what form to open next
                    {
                        update = "Student";
                    }
                    else if (p[i] is Professor)
                    {
                        update = "Professor";
                    }
                }
            }

            return update;
        }

        public Student GetStudentByName(String name)
        {
            
            Student s = new Student();
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].name.ToLower() == name.ToLower())
                {
                    if (p[i] is Student)
                    {
                        s = (Student)p[i];
                    }        
                }
            }
            return s;
        }

        public Professor GetProfessorByName(String name)
        {
            Professor x = new Professor();
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].name.ToLower() == name.ToLower())
                {
                    if (p[i] is Student)
                    {
                        x = (Professor)p[i];
                    }
                }
            }
            return x;
        }

        public void UpdateStudent(Student s, String name)
        {
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].name.ToLower() == name.ToLower())
                {
                    p[i] = s;
                }
            }
        }
        public void UpdateProfessor(Professor x, String name)
        {
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].name.ToLower() == name.ToLower())
                {
                    p[i] = x;
                }
            }
        }
    }
}
