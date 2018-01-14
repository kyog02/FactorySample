using System;
namespace FactorySample
{
    public class Executor
    {
        private IScenario scenario;
        public Executor(IScenario Scenario)
        {
            this.scenario = Scenario;
        }

        public void Exe()
        {
            this.scenario.ToInitialize();
            this.scenario.ToExecute();
            this.scenario.ToFinalize();
        }
    }
}
