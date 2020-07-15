using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace StudentDataAccess
{
    public static class StudentIO
    {
        static string filePath = @"C:\test.txt";
        static List<Student> students = new List<Student>();

        public static List<Student> LoadStudents()
        {
            students.Clear();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                if (line.Trim().Length > 0)
                    students.Add(new Student(line));
            }

            return students;
        }

        public static void SaveStudent(Student student)
        {
            File.AppendAllText(filePath, $"{student.ToJson()}\n");
        }

        public static void RemoveStudent(int index)
        {
            LoadStudents();
            students.RemoveAt(index);
            File.WriteAllText(filePath, string.Empty);
            foreach (Student student in students)
            {
                SaveStudent(student);
            }
        }

        public static bool ExportStudents(string path)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Id, Name, Class, Section, Contact, Address");

            LoadStudents();
            if(students.Count == 0)
            {
                return false;
            }
            foreach (Student student in students)
            {
                builder.AppendLine(student.ToString());
            }
            try
            {
                File.WriteAllText(path, builder.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int NextId()
        {
            LoadStudents();
            Trace.WriteLine($"Number of students: {students.Count}");
            if(students.Count == 0)
            {
                return 0;
            }
            return students[^1].Id + 1;
        }

        public static void UpdateStudent(int selectedIndex, Student in_student)
        {
            LoadStudents();
            students[selectedIndex] = in_student;
            File.WriteAllText(filePath, string.Empty);
            foreach (Student student in students)
            {
                SaveStudent(student);
            }
        }
    }
}
