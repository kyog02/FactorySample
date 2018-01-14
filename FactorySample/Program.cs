using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FactorySample
{
    class Program
    {
        public static void Main(string[] args)
        {
            ScenarioFactory ScenarioFactory = new ScenarioFactory();
            //TextReader command = Console.In;
            IScenario Scenario = ScenarioFactory.ScenarioCreate("ScenarioSample");
            if (Scenario != null)
            {
                Executor Executor = new Executor(Scenario);
                Executor.Exe();
            }

        }
    }
}
