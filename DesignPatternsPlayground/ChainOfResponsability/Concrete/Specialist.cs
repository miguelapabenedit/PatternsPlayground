using DesignPatternsPlayground.ChainOfResponsability.Abstract;
using System;

namespace DesignPatternsPlayground.ChainOfResponsability.Concrete
{
    public class Specialist : HealthStaff
    {
        public override void HandleDiagnose(PatientLevel patient)
        {
            if (patient == PatientLevel.High)
            {
                Console.WriteLine("Patient Diagnosted by Specialist");
            }
            else
            {
                throw new ExecutionEngineException();
            }
        }
    }
}
