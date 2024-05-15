using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	internal class NightWagon : PersonalWagon, IConnect {

		private int numberOfBeds;
		public Bed[] Beds { get; set; }
		public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }

		public NightWagon(int numberOfChairs, int numberOfBeds) : base(numberOfChairs) {
			this.NumberOfBeds = numberOfBeds;
		}

		public override string ToString() {
			return $"Vagon typu Night s počtem sedadel {NumberOfChairs} a {NumberOfBeds} postelemi";
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
