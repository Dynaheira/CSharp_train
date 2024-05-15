using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	public interface IConnect {

		// Metoda pro připojení vagónu k vlaku
		void ConnectWagon(Train train);

		// Metoda pro odpojení vagónu od vlaku
		void DisconnectWagon(Train train);
	}
}
