using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	internal class EconomyWagon : PersonalWagon, IConnect{

		public EconomyWagon(int numberOfChairs) : base(numberOfChairs) {
		}

		public override string ToString() {
			return $"Vagon typu Economy s počtem sedadel {NumberOfChairs}";
		}
		public void ConnectWagon(Train train) {
			// Implementace připojení vagónu k vlaku
			train.ConnectWagon(this);

		}
		public void DisconnectWagon(Train train) {
			// Implementace odpojení vagónu k vlaku
			train.DisconnectWagon(this);
		}
	}
}
