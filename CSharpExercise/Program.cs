using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	internal class Program {
		static void Main() {

			// Business - nyní stewardkou v ceně
			Person steward = new Person("Lenka", "Kozáková");
			BusinessWagon businessWagon = new BusinessWagon(30, steward);

			// Vytvoření spacího vagonu
			NightWagon sleeperWagon = new NightWagon(20, 10);

			// Vytvoření Hopperu
			Hopper hopperWagon = new Hopper(50);

			Console.WriteLine("První vlak.\n");

			// Kája a jeho lokomotiva
			Engine dieselEngine = new Engine("diesel");
			Person driver1 = new Person("Karel", "Novák");
			Locomotive dieselLocomotive = new Locomotive(driver1, dieselEngine);

			// Kája nabral vagóny (a Lenku k tomu)
			Train train1 = new Train(dieselLocomotive);
			train1.ConnectWagon(businessWagon);
			train1.ConnectWagon(hopperWagon);
			train1.ConnectWagon(sleeperWagon);	

			// Babiš potřebuje vyvést řepku
			Hopper additionalHopper = new Hopper(40);
			additionalHopper.ConnectWagon(train1);

            Console.WriteLine("\nKonec zadávání prvního vlaku.\n");

			Console.WriteLine("Druhý vlak.\n");

			// Parní na 5 vagónu, hlídá se tady IFem, jinak nadáváme
			Engine steamEngine = new Engine("parní");
			Locomotive steamLocomotive = new Locomotive(driver1, steamEngine);
			Train train2 = new Train(steamLocomotive);

			for (int i = 0; i < 5; i++) {
				if (train2.Wagons.Count < 5) {
					EconomyWagon wagon = new EconomyWagon(50);
					wagon.ConnectWagon(train2);
				}
				else {
					Console.WriteLine("Nelze připojit další vagon k parní lokomotivě, maximální počet je 5.");
					break;
				}
			}


			// Zkouška vytvoření a připojení dalšího vagonu k parní lokomotivě
			EconomyWagon extraWagon = new EconomyWagon(40);
			extraWagon.ConnectWagon(train2);

			Console.WriteLine("\nKonec zadávání druhého vlaku.\n");

			Console.WriteLine("Rezervační část.");


			// Rezervačka
			train1.ReserveChair(2, 3);

			// Pokud chceme jet s Babišovou řepkou
			train1.ReserveChair(3, 2);

			// Pokud chceme jet s Babišovou řepkou
			train1.ReserveChair(1, 8);

			// Tlačíme se na již rezervované sedadlo
			train1.ReserveChair(2, 3);

			// Výpis rezervaček
			Console.WriteLine("\nRezervovaná sedadla:");
			train1.ListReservedChairs();

			Console.WriteLine("\nInformační část.");

			// Im'm train Choo Choo
			Console.WriteLine("\nInformace o prvním vlaku:");
			Console.WriteLine(train1.ToString());
			Console.WriteLine("\nInformace o druhém vlaku:");
			Console.WriteLine(train2.ToString());



		}
	}
}
