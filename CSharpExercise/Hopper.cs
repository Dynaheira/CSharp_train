using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	internal class Hopper : IConnect {
		private double loadingCapacity;

		public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }

		public Hopper(double tonnnage) {
			this.LoadingCapacity = tonnnage;
		}	

		public override string ToString() {
			return $"Hopper, který uvaze {LoadingCapacity} tun nákladu.";
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
