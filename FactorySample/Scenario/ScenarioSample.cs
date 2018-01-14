using System;
namespace FactorySample
{
    /// <summary>
    /// サンプル用シナリオ
    /// </summary>
    public class ScenarioSample : IScenario
    {
        public ScenarioSample()
        {
        }

        public void ToInitialize()
        {
            Console.WriteLine("sample ToInitialize");
        }

        public void ToExecute()
        {
            Console.WriteLine("sample ToExecute");
        }

        public void ToFinalize()
        {
            Console.WriteLine("sample ToFinalize");
        }
    }
}
