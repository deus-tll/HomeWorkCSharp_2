using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortByColumns
{
	public partial class Form1 : Form
	{
		List<Student> students = new List<Student>
		{
			new Student()
			{
				FirstName = "Olga",
				LastName = "Petrova",
				BirthDay = new DateTime(2000, 10, 15),
				StudentCard = new StudentCard()
				{
					Series = "AB",
					Number = 123456
				}
			},
			new Student()
			{
				FirstName = "Valery",
				LastName = "Matveev",
				BirthDay = new DateTime(2001, 11, 5),
				StudentCard = new StudentCard()
				{
					Series = "AB",
					Number = 123400
				}
			},
			new Student()
			{
				FirstName = "Petro",
				LastName = "Alekseev",
				BirthDay = new DateTime(2000, 10, 14),
				StudentCard = new StudentCard()
				{
					Series = "AC",
					Number = 123489
				}
			},
			new Student()
			{
				FirstName = "Irina",
				LastName = "Fadeeva",
				BirthDay = new DateTime(1999, 2, 24),
				StudentCard = new StudentCard()
				{
					Series = "AC",
					Number = 123455
				}
			}
		};

		private bool _ascDesc = false;
		private int _lastColumnClick;

		public Form1()
		{
			InitializeComponent();

			listView1.Columns.Add("FirstName");
			listView1.Columns.Add("LastName");
			listView1.Columns.Add("Date");
			listView1.Columns.Add("Series");
			listView1.Columns.Add("Number");

			FillListView();

			listView1.View = View.Details;
		}

		private void FillListView()
		{
			listView1.Items.Clear();

			for (int i = 0; i < students.Count; i++)
			{
				listView1.Items.Add(students[i].FirstName);
				listView1.Items[i].SubItems.Add(students[i].LastName);
				listView1.Items[i].SubItems.Add(students[i].BirthDay.ToShortDateString());
				listView1.Items[i].SubItems.Add(students[i].StudentCard.Series);
				listView1.Items[i].SubItems.Add(students[i].StudentCard.Number.ToString());
			}
		}

		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			_ascDesc = !_ascDesc;

			switch (e.Column)
			{
				case 0:
					students.Sort((s1, s2) => _ascDesc ? Student.CompareByFirstName(s1, s2) : Student.CompareByFirstName(s2, s1));
					break;
				case 1:
					students.Sort((s1, s2) => _ascDesc ? Student.CompareByLastName(s1, s2) : Student.CompareByLastName(s2, s1));
					break;
				case 2:
					students.Sort((s1, s2) => _ascDesc ? Student.CompareByBirthday(s1, s2) : Student.CompareByBirthday(s2, s1));
					break;
				case 3:
					students.Sort((s1, s2) => _ascDesc ? Student.CompareBySeries(s1, s2) : Student.CompareBySeries(s2, s1));
					break;
				case 4:
					students.Sort((s1, s2) => _ascDesc ? Student.CompareByNumber(s1, s2) : Student.CompareByNumber(s2, s1));
					break;
				default:
					break;
			}

			listView1.Columns[_lastColumnClick].Text = listView1.Columns[_lastColumnClick].Text.Remove(listView1.Columns[_lastColumnClick].Text.Length - 1);

			if (_ascDesc)
				listView1.Columns[e.Column].Text += "↑";
			else
				listView1.Columns[e.Column].Text += "↓";

			_lastColumnClick = e.Column;

			FillListView();
		}
	}

	[Serializable]
	public class StudentCard : IComparable, ICloneable
	{

		public string Series { get; set; }
		public int Number { get; set; }

		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public int CompareTo(object obj)
		{
			StudentCard st1 = obj as StudentCard;
			if (Series == st1.Series)
			{
				return Number.CompareTo(st1.Number);
			}
			else
			{
				return Series.CompareTo(st1.Series);
			}
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{Series} #{Number}";
		}
	}

	class GroupName
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}

	public class Student : IComparable<Student>, ICloneable
	{
		int id = 100;
		public int GroupName { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDay { get; set; }
		public StudentCard StudentCard { get; set; }


		public override int GetHashCode()
		{
			return $"{StudentCard.Series} #{StudentCard.Number}".GetHashCode();
		}

		public int CompareTo(Student obj) => LastName.CompareTo(obj.LastName);


		public override string ToString()
		{
			return $"{FirstName.PadRight(10)} {LastName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
		}

		public object Clone()
		{
			Student student = (Student)this.MemberwiseClone();
			student.StudentCard = (StudentCard)this.StudentCard.Clone();
			return student;
		}

		public void Exam(DateTime date)
		{
			Console.WriteLine($"Екзамен для {FirstName} {LastName} назначений на {date.ToShortDateString()}");
		}

		static public int CompareByFirstName(Student s1, Student s2) => s1.FirstName.CompareTo(s2.FirstName);
		static public int CompareByLastName(Student s1, Student s2) => s1.LastName.CompareTo(s2.LastName);
		static public int CompareByBirthday(Student s1, Student s2) => s1.BirthDay.CompareTo(s2.BirthDay);
		static public int CompareBySeries(Student s1, Student s2) => s1.StudentCard.Series.CompareTo(s2.StudentCard.Series);
		static public int CompareByNumber(Student s1, Student s2) => s1.StudentCard.Number.CompareTo(s2.StudentCard.Number);
	}

	class ExamEventArgs : EventArgs
	{
		public DateTime Date { get; set; }
	}
}
