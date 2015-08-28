using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string studentName;
        private int StudentID;
        private int yearOfBirth;
        private bool isActive;

        public Student()
        {
            studentName = "John Doe";
            StudentID = 0;
            yearOfBirth = 1995;
            isActive = false;
        }
        public Student(string name,int id)
        {
            studentName = name;
            this.StudentID = id;
            this.yearOfBirth = 1995;
            isActive = true;
        }
        public Student(String name, int id,int year)
        {
            studentName = name;
            this.StudentID = id;
            this.yearOfBirth = year;
            isActive = true;
        }
        public void Student1(string studentName, int StudentID, int yearOfBirth, bool isActive)
        {
            this.studentName = studentName;
            this.StudentID = StudentID;
            this.isActive = Active;
            this.yearOfBirth = yearOfBirth;
        }
        public string name
        {
            get {
                return studentName;
            }
            set {
                studentName = value ;
            }         
        }
        public int id
        {
            get
            {
                return StudentID;
            }
            set
            {
                StudentID = value;
            }
        }
        public int yearOfBirth1
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                if (value< 1950 || value> 2000)
                {
                   Console.WriteLine(StudentID + ": error try setting invalid year-of-birth value!");
                }
                else {
                    yearOfBirth = value;
                }
                
            }
        }

        public bool Active
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
            }
        }
        public int getAge()
        {
            return 2015 - yearOfBirth;
        }

        public override string ToString()
       {
           string a = "";
       
            if (isActive == true)
            {
                a = " active";
           }
           else
            {
                a = " not active";
           }
            string s = "[Student: " + name + "(" + id + "), age=" + getAge() + ", is" + a + " student]";
            return s;
        }
    }
 }

