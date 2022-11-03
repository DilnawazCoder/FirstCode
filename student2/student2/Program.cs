using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace student2
{
    internal class Student
    {


        //private  int studentid;
        //private string studentName;
        //private int marks;
        //private char grade;
        int studentid;
        string studentName;
        int marks;
        //char grade;

        public Student()
        {
        }
        public Student(int studentid, string studentName, int marks)
        {
            this.studentid = studentid;
            this.studentName = studentName;
            this.marks = marks;
         
        }
        public void DisplayDetails()

        {

            
        // Console.WriteLine("name: " + studentName + " " + "studentid: " + studentid + " " + "marks: " + marks + " " + "grade is: " + calculateGrade());
         // return "name" + studentName + " " + "studentid" + studentid + " " + "marks" + marks + " " + "grade is" + calculateGrade();
            
            Console.WriteLine(" studentid=" + studentid);
            Console.WriteLine("  studentName=" + studentName);
            Console.WriteLine("  marks=" + marks);
            Console.WriteLine("grade is=" + calculateGrade());
             

        }
        public char calculateGrade()

        {
           
            if (marks > 90)
            {

               return 'A'; 
               
               
            }
            else if (marks > 81 && marks < 90)
            {
                return 'B';
            }
            else if (marks > 71 && marks < 80)
            {
                return 'C';
            }
            else if (marks > 61 && marks < 70)
            {
                return'D';
            }
            else
            {
                return 'C';
            }
            
           

        }

            public static void Main()
            {
                Student st = new Student(9029, "dil", 39);
                st.DisplayDetails();
                Console.ReadLine(); 

            
            }

        }
    
    
    }




