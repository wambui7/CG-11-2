using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_average
{
	class classlist
	{
		public void Run()

		{

			CreateStudent();

			Console.ReadLine();

		}



		public void CreateStudent()

		{

			List<Student> students = new List<Student>();

			string line;

			StreamReader file = new StreamReader(@"C:\Users\agatha\Source\Repos\student
\StudentList.txt");

			while ((line = file.ReadLine()) != null)

			{

				decimal totalGrades = 0;

				decimal averageGrade = 0;

				string[] lines = line.Split(' ');

				string studentName = lines[0];



				foreach (string grade in lines.Skip(1))

				{

					int grades = int.Parse(grade);

					totalGrades = totalGrades + grades;

				}

				averageGrade = totalGrades / (lines.Length - 1);



				Student newStudent = new Student(studentName, totalGrades, averageGrade);

				students.Add(newStudent);

			}

			foreach (Student student in students)

			{

				Console.WriteLine($"{student.Name} has an average grade of {student.AverageGrade:}");

			}

		}


		class Student
		{
			internal object AverageGrade;

			public Student(string studentName, decimal totalGrades, decimal averageGrade)
			{
			}

			public object Name { get; internal set; }
		}
	}
}
	

