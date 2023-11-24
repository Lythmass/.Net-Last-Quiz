using quiz_last;
using quiz_last.Models;
using System;
using System.Linq;
using System.Reflection.Metadata;

using var db = new SchoolContext();

Console.WriteLine($"Database path: {db.DbPath}.");

var student1 = new Student() { Name="Gigi", EnrollmentDate=DateTime.Now };
var student2 = new Student() { Name = "Ushangi", EnrollmentDate = DateTime.Now };

Console.WriteLine("Creating a new Lecture");
db.Add(new Lecture { Title=".Net", Capacity=4, Date=DateTime.Now});
db.SaveChanges();


Console.WriteLine("Adding Students to Lectures");
var lecture = db.Lectures.First();
lecture.Students.Add(student1);
lecture.Students.Add(student2);
db.SaveChanges();


Console.WriteLine($"Lecture: {lecture.Title}");
foreach (var student in lecture.Students)
{
    Console.WriteLine("Student Name: " + student.Name + ", ");
}


Console.WriteLine("Delete the lecture");
db.Remove(lecture);
db.SaveChanges();