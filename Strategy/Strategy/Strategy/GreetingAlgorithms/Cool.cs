using System.Collections.Generic;
using System.Linq;
using Strategy.Algorithms;

namespace Strategy.GreetingAlgorithms
{
    public class Cool : IGreetingAlgorithm
    {
        public IEnumerable<string> Execute(IEnumerable<string> inputList)
        {
            return inputList.Select(item => string.Format("Hey yo {0},", item));
        }
    }
}

