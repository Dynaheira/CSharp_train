using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	public class Engine {

		private string type;

		public string Type { get => type; set => type = value; }

		public Engine(string type) {
			this.Type = type;
		}

		public override string ToString() {
			return $"Typ lokmotivy: {Type}";
		}

		//public static void Mainx() {
		//	Engine e1 = new Engine("Diesel");
		//	Console.WriteLine(e1.ToString());
		//}

	}
}
