using System;
using System.Collections.Generic;
using Strategy.Algorithms;
using Strategy.GreetingAlgorithms;

namespace Strategy
{
	public class Client
	{
        private readonly IGreetingAlgorithm _greetingAlgorithm;

        public Client (IGreetingAlgorithm greetingAlgorithm)
        {
            _greetingAlgorithm = greetingAlgorithm;
        }

		public IEnumerable<string> ProcessNames(IEnumerable<string> names) 
		{
			return _greetingAlgorithm.Execute (names);
		}
	}
}
	