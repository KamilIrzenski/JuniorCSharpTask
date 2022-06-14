using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.CSharp.Task
{
	public class ThirdTask
	{
		public int Divide(int divident, int divisior)
		{
			int sing = 1;
			if (divident * divisior < 0)
			{
				sing = -1;
			}

			int quotient = 0;

			divident = Math.Abs(divident);
			divisior = Math.Abs(divisior);

			if (divisior == 0)
			{
				throw new Exception("Divisior can not be zero");
			}

			if (divident < int.MinValue || divident > int.MaxValue)
			{
				throw new Exception("Divided is not in the range of values");
			}

			if (divisior < int.MinValue || divisior > int.MaxValue)
			{
				throw new Exception("Divided is not in the range of values");
			}

			while (divident >= divisior)
			{
				divident = divident - divisior;
				quotient++;
			}

			if (quotient > int.MaxValue)
			{
				return int.MaxValue;
			}

			else if (quotient < int.MinValue)
			{
				return int.MinValue;
			}

			return sing * quotient;
		}
	}
}
