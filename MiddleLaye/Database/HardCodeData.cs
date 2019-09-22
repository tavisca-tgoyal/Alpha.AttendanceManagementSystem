using System;
using System.Collections.Generic;
using System.Text;
using AMS.MiddleLayer.Database;

namespace AMS.MiddleLayer.Database
{
    public class HardCodeData
    {
        public HardCodeData()
        {
            AddTeachers();
            AddStudents();
            var SubjectList = new[]{"Data Structures", "Computer Networks" ,"Engineering Drawing","DBMS","Operating System","Engineering Mathematics","Chemistry","Value Ethics","Economics","Algorithms"};
            for(int i = 0; i < 10; i++)
            {
                string subjectId = (100 + i).ToString();
                AddSubjects(subjectId,SubjectList[i]);
            }
        }
        public void AddSubjects(string subjectId, string subjectName,int i=0)
        {
            Databases.Subjects.Add(
                new Subject { Id = subjectId,
                    Name = subjectName,
                    Teacher = Databases.Teachers[0],
                    TotalClassesTaken = 5,
                    StudentAttendance = new Dictionary<int, int> { { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) },
                                                                   { Databases.Students[i++].Id, new Random().Next(5) }
                    }
                }
                );
        }

        public void AddTeachers()
        {
            Databases.Teachers.Add(
                new Personna.Teacher(500, "teacher1", "teacher1@gmail.com", "teacher1Pass")
                );

            Databases.Teachers.Add(
                new Personna.Teacher(501, "teacher2", "teacher2@gmail.com", "teacher2Pass")
                );

            Databases.Teachers.Add(
                new Personna.Teacher(502, "teacher3", "teacher3@gmail.com", "teacher3Pass")
                );

            Databases.Teachers.Add(
                new Personna.Teacher(503, "teacher4", "teacher4@gmail.com", "teacher4Pass")
                );

            Databases.Teachers.Add(
                new Personna.Teacher(504, "teacher5", "teacher5@gmail.com", "teacher5Pass")
                );
        }

        public void AddStudents()
        {
            Databases.Students.Add(
                new Personna.Student(1001, "tushar", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1002, "student2", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1003, "student3", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1004, "student4", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1005, "student5", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1006, "student6", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1007, "student7", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1008, "student8", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1009, "student9", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1010, "student10", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1011, "student11", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1012, "student12", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1013, "student13", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1014, "student14", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1015, "student15", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1016, "student16", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1017, "student17", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1018, "student18", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1019, "student19", "willingtushar@gmail.com", "thisismypassword")
                );
            Databases.Students.Add(
                new Personna.Student(1020, "student20", "willingtushar@gmail.com", "thisismypassword")
                );
        }
    }
}
