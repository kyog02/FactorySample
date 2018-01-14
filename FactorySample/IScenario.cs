using System;
namespace FactorySample
{
    public interface IScenario
    {
        void ToInitialize();
        void ToExecute();
        void ToFinalize();
    }

}
