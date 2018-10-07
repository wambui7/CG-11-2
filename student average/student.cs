using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_average
{
	internal class student
	{
		public string Name { get; set; }

		public decimal Grades { get; set; }

		public decimal AverageGrade { get; set; }



		public student(string name, decimal grades, decimal averageGrade)

		{
			Name = name;

			Grades = grades;

			AverageGrade = averageGrade;
		}
	}
}
