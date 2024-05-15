using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	internal class BusinessWagon : PersonalWagon {
		private Person steward;

		internal Person Steward { get => steward; set => steward = value; }


		public BusinessWagon(int numberOfChairs, Person steward) : base(numberOfChairs) {
			this.Steward = steward;
		}

		public override string ToString() {
		return $"Vagon typu Business s {NumberOfChairs} sedadly a stewardkou: {Steward}";
	}

		public void ConnectWagon(Train train) {
			train.ConnectWagon(this);

		}

		public void DisconnectWagon(Train train) {
			train.DisconnectWagon(this);
		}
	}
}
