﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise {
	internal class Chair {

		private bool nearWindow;
		private int number;
		private bool reserved;

		public bool NearWindow { get => nearWindow; set => nearWindow = value; }
		public int Number { get => number; set => number = value; }
		public bool Reserved { get => reserved; set => reserved = value; }

		public Chair(bool nearWindow, int number) {
			this.NearWindow = nearWindow;
			this.Number = number;
		}


	}
}
