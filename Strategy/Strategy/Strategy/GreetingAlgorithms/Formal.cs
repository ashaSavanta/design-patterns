using System.Collections.Generic;
using System.Linq;
using Strategy.Algorithms;

namespace Strategy.GreetingAlgorithms
{
	public class Formal : IGreetingAlgorithm
	{
		public IEnumerable<string> Execute(IEnumerable<string> inputList)
		{
			return inputList.Select (item => string.Format("Dear {0},", item));
		}
	}
}

