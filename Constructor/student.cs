using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{

	public class player : student
	{

		public string pname { get { return name; } }

		public int rno
		{
			get { return roll; }
		}

		public int omarks
		{
			get { return obmarks; }
		}

	}


	public class student
	{

		public student()
		{
			name = "salman";
			rollno = 9;
			obmarks = 900;
			tmarks = 1100;
			
		}

		public student(string name,int rollno,int obmarks,int tmarks)
		{
			this.name = name;
			this.rollno = rollno;
			this.obmarks = obmarks;
			this.tmarks = tmarks;
		}

		public student(student oldstudent,int obmarks,int tmarks )
		{
			this.name=oldstudent.name.Replace("Mr","");
			this.roll = oldstudent.rollno;
			this.obmarks=obmarks;
			this.tmarks =tmarks;

		}

		public void show()
		{

			Console.WriteLine(name);
			Console.WriteLine(rollno);
			Console.WriteLine(obtainmarks);
			Console.WriteLine(totalmarks);
			Console.WriteLine(percentage);
			Console.WriteLine("-----* Player Info *-----");
			
	
		}

		private string username;
			private int rollno;
			private int obtainmarks;
			private int tmarks;
			private decimal aggregate;


		public string name
		{
			get { return "Mr " + username; }
			set { username = value; }
		}

		public int obmarks
		{
			get { return obtainmarks;}
			set { obtainmarks=value;}
		}

			public int roll
			{
			get
			{ return rollno; }
				
			set
				{
					if (value < 0)
					{
						Console.WriteLine("Your Roll Number Can't be Less  Then 0. And by Default set to=");
						rollno = 1;
					}
					else
					{
						rollno = value;
					}
				}
			}

			public int totalmarks
			{
				get { return tmarks = 1100; }
				
			}


			public decimal percentage
			{

				get
				{
					return Convert.ToDecimal(obtainmarks) / Convert.ToDecimal(totalmarks) * 100;
				}
				
			}


		}

	}

