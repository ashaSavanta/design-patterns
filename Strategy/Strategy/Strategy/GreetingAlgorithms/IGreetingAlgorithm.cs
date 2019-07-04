using System.Collections.Generic;

namespace Strategy.Algorithms
{
    public interface IGreetingAlgorithm
    {
        IEnumerable<string> Execute(IEnumerable<string> inputList);
    }
}