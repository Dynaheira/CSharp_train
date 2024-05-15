using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	internal class Bed {
		private int number;
		private bool reserved;

		public int Number { get => number; set => number = value; }
		public bool Reserved { get => reserved; set => reserved = value; }

		public Bed()
        {
            
        }

	}
}
