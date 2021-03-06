﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to University Management System");
            Console.WriteLine("");
            Console.WriteLine("");
            Course c = new Course("C#", 001, 3, 5.0);
            Course c1 = new Course("C++", 002, 3, 5.0, 1);
            Section s1 = new Section("A", "C#", 003, 3, 5.0);
            Section s2 = new Section("B", "C#", 004, 3, 3.0);
            Section s3 = new Section("C", "C#", 005, 3, 3.0);
            Section s4 = new Section("D", "C#", 006, 3, 3.0);
            Section s5 = new Section("E", "C++", 007, 3, 3.0);
            Section s6 = new Section("F", "Java", 008, 3, 3.0);
            Section s7 = new Section("G", "OOP1", 009, 3, 3.0);
            Section s8 = new Section("H", "Compiler", 010, 3, 3.0);
            Section s9 = new Section("I", "Grapics design", 011, 3, 3.0);
            Section s10 = new Section("J", "OOP1", 012, 3, 3.0);
            s1.SearchSection(003);
            Console.WriteLine("Seacrhing For Section");
            Console.WriteLine("");
            c.SearchSection(001);
            Console.WriteLine("");
            c.ShowInfo();
            Console.WriteLine("");
            s1.ShowInfo();
            Console.WriteLine("");
            Department d = new Department("FST");
            Department d1 = new Department("Accounting");
            Department d2 = new Department("FBA");
            Department d3 = new Department("Mechanical");
            d.AddCourse(c, c1);
            d.ShowAllCourses();
            Console.WriteLine("");
            Console.WriteLine("Adding Courses In Department");
            Console.WriteLine("");
            d.AddCourse(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            d.ShowAllCourses();
            Console.WriteLine("");
            Console.WriteLine("Faculty Taking Courses");
            Console.WriteLine("");
            Faculty f1 = new Faculty("Anisul korim", "20-001");
            Faculty f2 = new Faculty("Aurpita Akter", "21-002");
            Faculty f3 = new Faculty("Avijit sorkar", "22-003");
            Faculty f4 = new Faculty("Rafeed kamal", "19-004");
            Faculty f5 = new Faculty("Sudipto sorkar", "18-005");
            Teaching_Hour t = new Teaching_Hour("C", 3, d);
            Teaching_Hour t1 = new Teaching_Hour("C++ ", 3, d);
            Teaching_Hour t2 = new Teaching_Hour("Java ", 3, d);
            Teaching_Hour t3 = new Teaching_Hour("Python", 3, d);
            Teaching_Hour t4 = new Teaching_Hour("Accounting", 3, d);
            Teaching_Hour t5 = new Teaching_Hour("OOAD", 3, d);
            Teaching_Hour t6 = new Teaching_Hour("Physics", 3, d2);
            Teaching_Hour t7 = new Teaching_Hour("COA", 3, d);
            Teaching_Hour t8 = new Teaching_Hour("DC", 3, d1);
            Teaching_Hour t9 = new Teaching_Hour("DLD", 3, d1);
            Teaching_Hour t10 = new Teaching_Hour("Math", 3, d1);
            Teaching_Hour t11 = new Teaching_Hour("DEC", 3, d1);
            Teaching_Hour t12 = new Teaching_Hour("ECO", 3, d2);
            Console.WriteLine("");
            Console.WriteLine("Faculty Information");
            Console.WriteLine("");
            f1.ShowInfo();
            f1.AddCredit(t, t1, t2, t3, t4, t5, t8);
            f1.ShowAllCredits();
            Console.WriteLine("");
            Console.WriteLine("Faculty Information");
            Console.WriteLine("");
            f3.ShowInfo();
            f3.AddCredit(t, t1, t2, t3, t4, t5, t8, t12);
            f3.ShowAllCredits();

            Console.WriteLine("Developer At Kuratoli Software Solutions");

        }
    }
}