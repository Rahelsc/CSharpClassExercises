using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5_ClassExercise
{
    class Car
    {
		private int currentSpeed;

		public int CurrentSpeed
		{
			get { return currentSpeed; }
			set { currentSpeed = value; }
		}

		public void Accelerate(int num) // to mimick slow acceleration
		{
			while (num > 0)
			{ // validation check
				currentSpeed++;
				num--;
			}
		}

		public void Decelerate(int num) // to mimick slow deceleration
		{
			while (num > 0)
			{ // validation check
				currentSpeed--;
				num--;
			}
		}

		public void Stop()
		{
			currentSpeed = 0;
		}

		public string GetDescription()
		{
			return $" car speed: {currentSpeed}";
		}

	}
}
