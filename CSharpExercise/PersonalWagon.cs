using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	abstract class PersonalWagon : IConnect {
		public List<Door> Doors { get; set; }
		public List<Chair> Sits { get; set; }
		public int NumberOfChairs { get; set; }

		// Konstruktor třídy, který přijímá počet židlí jako parametr
		public PersonalWagon(int numberOfChairs) {
			NumberOfChairs = numberOfChairs;
			Doors = new List<Door>(); // inicializace prázdného seznamu dveří
			Sits = new List<Chair>(); // inicializace prázdného seznamu židlí

			for (int i = 0; i < this.NumberOfChairs; i++) {
				Sits.Add(new Chair(nearWindow: true, number: i + 1)); // Přidání nové židle
			}
		}

		// Konstruktor třídy, který přijímá seznam dveří a seznam židlí jako parametry
		public PersonalWagon(List<Door> doors, List<Chair> sits) {
			Doors = doors;
			Sits = sits;
			NumberOfChairs = sits.Count;


		}

        public PersonalWagon()
        {
            
        }

		public void ConnectWagon(Train train) {
			train.ConnectWagon(this);

		}

		public void DisconnectWagon(Train train) {
			train.DisconnectWagon(this);
		}
	}
}
