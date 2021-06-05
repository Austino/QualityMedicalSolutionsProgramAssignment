using QualityMedicalSolutionsProgramAssignment.Functionality;

namespace QualityMedicalSolutionsProgramAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase = new TestCaseBasicFunctionality();
            testCase.Run(100);
        }
    }
}
