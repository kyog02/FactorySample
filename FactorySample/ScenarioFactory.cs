using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FactorySample
{
    public class ScenarioFactory
    {
        public ScenarioFactory()
        {
        }

        public IScenario ScenarioCreate(string ScenarioName)
        {
            IScenario Scenario = null;
            switch(ScenarioName)
            {
                case "ScenarioSample":
                    Scenario = new ScenarioSample();
                    break;
                default:
                    break;
            }

            return Scenario;
        }
    }
}
