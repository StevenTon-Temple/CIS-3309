using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Tests
{
    [TestClass()]
    public class StudentListTests
    {
        [TestMethod()]
        public void StudentListTest()
        {

            StudentList student = null;
            Assert.IsNull(student);
            Assert.AreEqual(null, student);

            student = new StudentList();

            Assert.IsNotNull(student);
            Assert.AreNotEqual(null, student);

        }
        /// <summary>
        /// (student)
        /// </summary>
        [TestMethod()]
        public void AddStudentTest()
        {
            StudentList studList = new StudentList();
            Assert.AreEqual(studList.Count, 0);
            Student student = new Student("Steven");
            studList.AddStudent(student);
            Assert.AreNotEqual(studList.Count, 0);
            Assert.AreEqual(studList.Count, 1);
            string[] names = { "Jak", "Tom", "Carl", "Demi" };
            int count = studList.Count;
            foreach (string value in names)
            {
                Student test = new Student(value);
                studList.AddStudent(test);
                count++;
            }
            Assert.AreEqual(student, studList.GetStudent(student));
            Assert.AreEqual(studList.Count, count);

        }

        /// <summary>
        /// (student s, index)
        /// </summary>
        [TestMethod()]
        public void AddStudentTest1()
        {
            StudentList studList = new StudentList();
            Assert.AreEqual(studList.Count, 0);
            Student student = new Student("Steven");
            studList.AddStudent(student,0);
            Assert.AreNotEqual(studList.Count, 0);
            Assert.AreEqual(studList.Count, 1);
            string[] names = { "Jak", "Tom", "Carl", "Demi" };
            int count = studList.Count;
            foreach (string value in names)
            {
                Student test = new Student(value);
                studList.AddStudent(test, count);
                count++;
            }
            Assert.AreEqual(student, studList.GetStudent(student));

            Assert.AreEqual(studList.Count, count);

        }
        /// <summary>
        /// (student s)
        /// </summary>
        [TestMethod()]
        public void RemoveStudentTest()
        {

            StudentList studList = new StudentList();
            Assert.AreEqual(studList.Count, 0);
            Student student = new Student("Steven");
            studList.AddStudent(student);
            Assert.AreNotEqual(studList.Count, 0);
            Assert.AreEqual(studList.Count, 1);
            Student student2 = new Student("Ton");
            studList.AddStudent(student2);
            Assert.AreNotEqual(studList.Count, 1);
            Assert.AreEqual(studList.Count, 2);

            string[] names = { "Jak", "Tom", "Carl", "Demi" };
            int count = studList.Count;
            foreach (string value in names)
            {
                Student test = new Student(value);
                studList.AddStudent(test, count);
                count++;
            }

            studList.RemoveStudent(student);
            studList.RemoveStudent(student2);
            count--;
            count--;

            Assert.AreNotEqual(student, studList.GetStudent(student));
            Assert.AreNotEqual(student2, studList.GetStudent(student2));

            Assert.AreEqual(studList.Count, count);
        }
        /// <summary>
        /// (index)
        /// </summary>
        [TestMethod()]
        public void RemoveStudentTest1()
        {

            StudentList studList = new StudentList();
            
            Assert.AreEqual(studList.Count, 0);
            Student student = new Student("Steven");
            studList.AddStudent(student);
            Assert.AreNotEqual(studList.Count, 0);
            Assert.AreEqual(studList.Count, 1);
            string[] names = { "Jak", "Tom", "Carl", "Demi" };
            int count = studList.Count;
            foreach (string value in names)
            {
                Student test = new Student(value);
                studList.AddStudent(test, count);
                count++;
            }

            studList.RemoveStudent(1);
            studList.RemoveStudent(2);
            count--;
            count--;
           
            Assert.AreEqual(student, studList.GetStudent(student));
            Assert.AreEqual(studList.Count, count);

        }



        [TestMethod()]
        public void GetStudentTest()
        {
            StudentList studList = new StudentList();
            Student student0 = new Student("Steven");
            studList.AddStudent(student0, 0);
            Assert.AreNotEqual(studList.Count, 0);
            Student student1 = new Student("jak");
            studList.AddStudent(student1, 1);
            Assert.AreEqual(studList.Count, 2);
            Student student2 = new Student("Tom");
            studList.AddStudent(student2, 2);
            Assert.AreEqual(studList.Count, 3);
            Student student3 = new Student("Carl");
            studList.AddStudent(student3, 3);
            Assert.AreNotEqual(studList.Count, 3);



            Assert.AreEqual(student0, studList.GetStudent(student0));
            Assert.AreEqual(student1, studList.GetStudent(student1));
            Assert.AreEqual(student3, studList.GetStudent(student3));
            Assert.AreEqual(student2, studList.GetStudent(student2));
            Assert.AreNotEqual(student1, studList.GetStudent(student0));
            Assert.AreNotEqual(student2, studList.GetStudent(student1));
            Assert.AreNotEqual(student1, studList.GetStudent(student3));
            Assert.AreNotEqual(student3, studList.GetStudent(student2));
            Assert.AreNotEqual(student3, studList.GetStudent(student0));
        }

        [TestMethod()]
        public void GetStudentTest1()
        {
            StudentList studList = new StudentList();
            Student student0 = new Student("Steven");
            studList.AddStudent(student0, 0);
            Assert.AreNotEqual(studList.Count, 0);
            Student student1 = new Student("jak");
            studList.AddStudent(student1, 1);
            Assert.AreEqual(studList.Count, 2);
            Student student2 = new Student("Tom");
            studList.AddStudent(student2, 2);
            Assert.AreEqual(studList.Count, 3);
            Student student3 = new Student("Carl");
            studList.AddStudent(student3, 3);
            Assert.AreNotEqual(studList.Count, 3);

            Assert.AreEqual(student1, studList.GetStudent(1));
            Assert.AreNotEqual(student1, studList.GetStudent(2));
            Assert.AreEqual(student2, studList.GetStudent(2));
            Assert.AreEqual(student3, studList.GetStudent(3));
          
            Assert.AreNotEqual(student0, studList.GetStudent(2));
            Assert.AreNotEqual(student2, studList.GetStudent(3));

            Assert.AreEqual(student0, studList.GetStudent(0));
            Assert.AreNotEqual(student2, studList.GetStudent(3));
            Assert.AreNotEqual(student3, studList.GetStudent(1));

        }

        [TestMethod()]
        public void NextStudentTest()
        {
            StudentList studList = new StudentList();
            Student student0 = new Student("Steven");
            studList.AddStudent(student0, 0);
            Assert.AreNotEqual(studList.Count, 0);
            Student student1 = new Student("jak");
            studList.AddStudent(student1, 1);
            Assert.AreEqual(studList.Count, 2);
            Student student2 = new Student("Tom");
            studList.AddStudent(student2, 2);
            Assert.AreEqual(studList.Count, 3);
            Student student3 = new Student("Carl");
            studList.AddStudent(student3, 3);
            Assert.AreNotEqual(studList.Count, 3);


            Assert.AreEqual(student0, studList.NextStudent());
            Assert.AreEqual(student1, studList.NextStudent());
            Assert.AreNotEqual(student3, studList.NextStudent());
        }

        [TestMethod()]
        public void PreviousStudentTest()
        {
            StudentList studList = new StudentList();
            Student student0 = new Student("Steven");
            studList.AddStudent(student0, 0);
            Assert.AreNotEqual(studList.Count, 0);
            Student student1 = new Student("jak");
            studList.AddStudent(student1, 1);
            Assert.AreEqual(studList.Count, 2);
            Student student2 = new Student("Tom");
            studList.AddStudent(student2, 2);
            Assert.AreEqual(studList.Count, 3);
            Student student3 = new Student("Carl");
            studList.AddStudent(student3, 3);
            Assert.AreNotEqual(studList.Count, 3);


            Assert.AreEqual(null, studList.PreviousStudent());
            studList.NextStudent();
            studList.NextStudent();
            Assert.AreEqual(student0, studList.PreviousStudent());
            Assert.AreNotEqual(student1, studList.PreviousStudent());
        }

        [TestMethod()]
        public void GetStudentsTest()
        {
            StudentList studList = new StudentList();
            Student student0 = new Student("Steven");
            studList.AddStudent(student0, 0);
            Assert.AreNotEqual(studList.Count, 0);
            Student student1 = new Student("jak");
            studList.AddStudent(student1, 1);
            Assert.AreEqual(studList.Count, 2);
            Student student2 = new Student("Tom");
            studList.AddStudent(student2, 2);
            Assert.AreEqual(studList.Count, 3);
            Student student3 = new Student("Carl");
            studList.AddStudent(student3, 3);
            Assert.AreNotEqual(studList.Count, 3);

            ArrayList arraystudlist = studList.GetStudents();


            Assert.AreEqual(studList.GetStudent(0), arraystudlist[0]);
            Assert.AreEqual(studList.GetStudent(1), arraystudlist[1]);
            Assert.AreEqual(studList.GetStudent(2), arraystudlist[2]);
            Assert.AreEqual(studList.GetStudent(3), arraystudlist[3]);

            Assert.AreNotEqual(studList.GetStudent(3), arraystudlist[1]);
            Assert.AreNotEqual(studList.GetStudent(3), arraystudlist[2]);
            Assert.AreNotEqual(studList.GetStudent(2), arraystudlist[1]);
            

        }

        [TestMethod()]
        public void ClearStudentsTest()
        {
            StudentList studList = new StudentList();
            Student student0 = new Student("Steven");
            studList.AddStudent(student0, 0);
            Assert.AreNotEqual(studList.Count, 0);
            Student student1 = new Student("jak");
            studList.AddStudent(student1, 1);
            Assert.AreEqual(studList.Count, 2);
            Student student2 = new Student("Tom");
            studList.AddStudent(student2, 2);
            Assert.AreEqual(studList.Count, 3);
            Student student3 = new Student("Carl");
            studList.AddStudent(student3, 3);
            Assert.AreNotEqual(studList.Count, 3);

            studList.ClearStudents();

            Assert.AreNotEqual(5, studList.Count);
            Assert.AreNotEqual(4, studList.Count);
            Assert.AreNotEqual(3, studList.Count);
            Assert.AreNotEqual(2, studList.Count);
            Assert.AreNotEqual(1, studList.Count);
            Assert.AreEqual(0, studList.Count);
            
         

        }

        [TestMethod()]
        public void FindStudentByIDTest()
        {
            StudentList studList = new StudentList();
            Student student0 = new Student("Steven", "1552");
            studList.AddStudent(student0, 0);
            Assert.AreNotEqual(studList.Count, 0);
            Student student1 = new Student("jak", "2220");
            studList.AddStudent(student1, 1);
            Assert.AreEqual(studList.Count, 2);
            Student student2 = new Student("Tom", "9912");
            studList.AddStudent(student2, 2);
            Assert.AreEqual(studList.Count, 3);
            Student student3 = new Student("Carl", "2113");
            studList.AddStudent(student3, 3);
            Assert.AreNotEqual(studList.Count, 3);


            Assert.AreEqual(student3, studList.FindStudentByID("2113"));
            Assert.AreEqual(student2, studList.FindStudentByID("9912"));
            Assert.AreNotEqual(student1, studList.FindStudentByID("9912"));
            Assert.AreNotEqual(student1, studList.FindStudentByID("2113"));
            Assert.AreEqual(null, studList.FindStudentByID("2222"));
            Assert.IsNull(studList.FindStudentByID("9999"));

            Assert.AreNotEqual(student0, studList.FindStudentByID("2220"));
            Assert.AreEqual(student0, studList.FindStudentByID("1552"));
            Assert.AreNotEqual(student2, studList.FindStudentByID("9911"));
            Assert.AreEqual(null, studList.FindStudentByID("12"));
            Assert.IsNull(studList.FindStudentByID("1734"));

        }


        //[TestMethod()]
        //public void count()
        //{
        //I did this in tested count in addstudent and subtractstudent and all my other test as well;
        //    Assert.Fail();
        //}
    }
}

        