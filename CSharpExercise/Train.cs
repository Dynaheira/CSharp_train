using CSharpExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {

	public class Train {
		private Locomotive locomotive;
		private List<IConnect> wagons;

		public Locomotive Locomotive { get => locomotive; set => locomotive = value; }
		public List<IConnect> Wagons { get => wagons; set => wagons = value; }

		public Train() {
			wagons = new List<IConnect>(); // inicializace seznamu vagonů
		}

		public Train(Locomotive locomotive) {
			this.Locomotive = locomotive;
			wagons = new List<IConnect>(); // inicializace seznamu vagonů
		}

		public Train(Locomotive locomotive, List<IConnect> wagons) {
			this.Locomotive = locomotive;
			this.Wagons = wagons;
		}

		public void ConnectWagon(IConnect wagon) {
			if (locomotive != null && wagons.Count < 5) {
				wagons.Add(wagon);
				Console.WriteLine("Vagón byl připojen k vlaku.");
			}
			else {
				Console.WriteLine("Vagón nelze připojit k vlaku.");
			}
		}

		public void DisconnectWagon(IConnect wagon) {
			if (wagons.Contains(wagon)) {
				wagons.Remove(wagon);
				Console.WriteLine("Vagón byl odpojen od vlaku.");
			}
			else {
				Console.WriteLine("Vagón není připojen k tomuto vlaku.");
			}
		}

		// IFovací Mordor
		public void ReserveChair(int wagonIndex, int chairNumber) {
			if (wagonIndex >= 0 && wagonIndex < wagons.Count && wagons[wagonIndex] is PersonalWagon) {
				PersonalWagon wagon = (PersonalWagon)wagons[wagonIndex];
				if (chairNumber > 0 && chairNumber <= wagon.NumberOfChairs) {
					if (!wagon.Sits[chairNumber - 1].Reserved) {
						wagon.Sits[chairNumber - 1].Reserved = true;
						Console.WriteLine($"\nSedadlo {chairNumber} ve vagónu {wagonIndex+1} bylo úspěšně zarezervováno.");
					}
					else {
						Console.WriteLine($"\nSedadlo {chairNumber} ve vagónu {wagonIndex+1} je již rezervované.");
					}
				}
				else {
					Console.WriteLine($"\nSedadlo {chairNumber} ve vagónu {wagonIndex+1} neexistuje.");
				}
			}
			else {
				Console.WriteLine($"\nTady je Babišovo! Najdi si misto jinde! (Vagón {wagonIndex+1} neexistuje nebo není osobní vagon.)");
			}
		}

		public void ListReservedChairs() {
			for (int i = 0; i < wagons.Count; i++) {
				if (wagons[i] is PersonalWagon) {
					PersonalWagon wagon = (PersonalWagon)wagons[i];
					Console.WriteLine($"\nVagón {i+1}:");
					for (int j = 0; j < wagon.Sits.Count; j++) {
						if (wagon.Sits[j].Reserved) {
							Console.WriteLine($"Sedadlo {j + 1}");
						}
					}
				}
				else if (wagons[i] is Hopper) {
					Console.WriteLine("\nŘepka!");
				}
			}
		}

		// Emčův String Builsder
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{locomotive}");
			sb.AppendLine("Vagony:");
			foreach (var wagon in wagons) {
				sb.AppendLine(wagon.ToString());
			}
			return sb.ToString();
		}
	}
}

