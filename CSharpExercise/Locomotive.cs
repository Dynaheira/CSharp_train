using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	public class Locomotive {
		private Person driver;
		private Engine engine;

		internal Person Driver { get => driver; set => driver = value; }
		internal Engine Engine { get => engine; set => engine = value; }

		public Locomotive()
        {
            
        }
		public Locomotive(Person driver, Engine engine) {
			this.Driver = driver;
			this.Engine = engine;
		}

		public override string ToString() {
			return $"{Engine}\nStrojvedoucí: {Driver} ";
		}

		public static void Mainx() {
			Engine e1 = new Engine("Diesel");
			Person p1 = new Person("Karel", "Novák");

			Locomotive l1 = new Locomotive(p1 , e1);

;			Console.WriteLine(l1.ToString());
		}
	}

}
