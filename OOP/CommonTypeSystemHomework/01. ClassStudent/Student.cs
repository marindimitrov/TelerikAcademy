using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassStudent
{
    // 1. Define a class Student, which contains data about a student – first, middle 
    // and last name, SSN, permanent address, mobile phone e-mail, course, specialty, 
    // university, faculty. Use an enumeration for the specialties, universities and 
    // faculties. Override the standard methods, inherited by  System.Object: Equals(), 
    // ToString(), GetHashCode() and operators == and !=.

    public enum Specialities
    {
        Physics,
        Mathematics,
        Chemistry,
        Biology
    }

    public enum Universities
    {
        SofiaUniversity,
        TechnicalUniversity,
        ArchitectureUniversity
    }

    public enum Faculties
    {
        AppliedMathematics,
        EngineeringPhysics,
        IndustrialChemistry,
        MicroBiology
    }

    public class Student : Object, ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        public string PermanentAddress { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Specialities Speciality { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }

        public Student()
        {

        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("First Name: " + FirstName + "\n");
            info.Append("Middle Name: " + MiddleName + "\n");
            info.Append("Last Name: " + LastName + "\n");
            info.Append("SSN: " + Ssn + "\n");
            info.Append("Permanent address: " + PermanentAddress + "\n");
            info.Append("Mobile phone: " + MobilePhone + "\n");
            info.Append("E-mail: " + Email + "\n");
            info.Append("Course: " + Course + "\n");
            info.Append("Speciality : " + Speciality + "\n");
            info.Append("University: " + University + "\n");
            info.Append("Faculty: " + Faculty + "\n");

            return info.ToString();
        }

        public override bool Equals(object obj)
        {
            Student compared = obj as Student;
            if (this.Ssn == compared.Ssn)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Ssn;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Ssn == secondStudent.Ssn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Ssn == secondStudent.Ssn)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // 2. Add implementations of the ICloneable interface. The Clone() method should  
        // deeply copy all object's fields into a new object of type Student.

        public Student Clone()
        {
            Student cloningStudent = new Student();
            cloningStudent.FirstName = this.FirstName;
            cloningStudent.MiddleName = this.MiddleName;
            cloningStudent.LastName = this.LastName;
            cloningStudent.Ssn = this.Ssn;
            cloningStudent.PermanentAddress = this.PermanentAddress;
            cloningStudent.MobilePhone = this.MobilePhone;
            cloningStudent.Email = this.Email;
            cloningStudent.Course = this.Course;
            cloningStudent.University = this.University;
            cloningStudent.Speciality = this.Speciality;
            cloningStudent.Faculty = this.Faculty;
            return cloningStudent;
        }

        public void Compare(List<Student> students)
        {
            students = new List<Student>();

            var comparedStudents =
                from student in students
                orderby student.Ssn
                orderby student.LastName
                orderby student.MiddleName
                orderby student.FirstName
                select student;

            foreach (var student in comparedStudents)
            {
                Console.Write(student.ToString() + "\n");
            }
        }
    }
}