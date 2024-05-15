using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	public class Person {

		private string firstName;
		private string lastName;

		public string FirstName { get => firstName; set => firstName = value; }
		public string LastName { get => lastName; set => lastName = value; }

		public Person(string firstName, string lastName) {
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public override string ToString() {
			return $"{FirstName} {LastName}";
		}

   //     public static void Mainx()
   //     {
			//Person p1 = new Person("Karel", "Novák");
   //         Console.WriteLine(p1.ToString());
   //     }

    }
}
