using AMS.MiddleLayer.Personna;
using AMS.MiddleLayer.Database;
using System;
using System.Collections.Generic;
using System.Text;


namespace AMS.MiddleLayer
{
    public class Admin : Person
    {
        public Admin(int id, string name, string email, string pass)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = pass;
        }

        public void AddNewTeacher(Teacher teacher)
        {
            Databases.Teachers.Add(teacher);
        }

        public void AddNewStudent(Student student)
        {
            Databases.Students.Add(student);
        }

        public void AddNewSubject(Subject subject)
        {
            Databases.Subjects.Add(subject);
        }

        public void ModifyTeacher(Teacher teacher)
        {
            for (var i=0;i<Databases.Teachers.Count;i++)
            {
                if(Databases.Teachers[i].Id==teacher.Id)
                {
                    Databases.Teachers.RemoveAt(i);
                    Databases.Teachers.Add(teacher);
                }
            }
        }

        public void ModifySubject(Subject subject)
        {
            for (var i = 0; i < Databases.Subjects.Count; i++)
            {
                if (Databases.Subjects[i].Id == subject.Id)
                {
                    Databases.Subjects.RemoveAt(i);
                    Databases.Subjects.Add(subject);
                }
            }
        }

        public void RemoveSubject(Subject subject)
        {
            Databases.Subjects.Remove(subject);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            Databases.Teachers.Remove(teacher);
        }

        public void RemoveStudent(Student student)
        {
            Databases.Students.Remove(student);
        }
    }
}
