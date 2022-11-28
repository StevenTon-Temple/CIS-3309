using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace MyClassLibrary
{
    public class StudentList
    {
        private ArrayList students;
        private int currentPosition;

        public StudentList()
        {
            students = new ArrayList();
            currentPosition = -1;
        }

        public int Count
        {
            get { return students.Count; }
        }

        // Returns the index of the newly added Student object
        public int AddStudent(Student s)
        {
            return students.Add(s);
        }

        public bool AddStudent(Student s, int index)
        {
            if (index >= 0 && index <= students.Count)
            {
                students.Insert(index, s);
                return true;
            }

            return false;
        }

        public bool RemoveStudent(Student s)
        {
            int countBeforeRemoval = students.Count;
            students.Remove(s);

            if (countBeforeRemoval > students.Count)
            {
                currentPosition = -1;   // reset the current position in the list
                return true;
            }

            return false;
        }

        public bool RemoveStudent(int index)
        {
            if (index < 0 || index > students.Count - 1)
                return false;

            int countBeforeRemoval = students.Count;
            students.RemoveAt(index);

            if (countBeforeRemoval > students.Count)
            {
                currentPosition = -1;   // reset the current position in the list
                return true;
            }

            return false;
        }

        public Student GetStudent(Student s)
        {
            int index = students.IndexOf(s);

            if (index == -1)
                return null;

            return (Student)students[index];
        }

        public Student GetStudent(int index)
        {
            if (index > students.Count - 1 || index < 0)
                return null;

            return (Student)students[index];
        }

        public Student NextStudent()
        {
            if (students.Count == 0)
                return null;

            if (currentPosition < students.Count - 1)
                currentPosition++;

            return (Student)students[currentPosition];
        }

        public Student PreviousStudent()
        {
            if (students.Count == 0)
                return null;

            if (currentPosition == -1)
                return null;

            if (currentPosition > 0)
                currentPosition--;

            return (Student)students[currentPosition];
        }

        // Method returns a new ArrayList with all the references from the original ArrayList
        // Shallow-Copy of items ArrayList
        public ArrayList GetStudents()
        {
            ArrayList theList = new ArrayList();
            foreach (object item in students)
            {
                theList.Add(item);
            }

            return theList;
        }

        public void ClearStudents()
        {
            students.Clear();
            currentPosition = -1;
        }

        public Student FindStudentByID(string id)
        {
            foreach (Student s in students)
            {
                if (s.StudentID == id)
                    return s;
            }

            return null;
        }

    }
}
