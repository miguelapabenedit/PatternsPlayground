using DesignPatternsPlayground.ChainOfResponsability.Abstract;
using System;

namespace DesignPatternsPlayground.ChainOfResponsability.Concrete
{
    public class Doctor : HealthStaff
    {
        public Doctor(HealthStaff supeior)
        {
            if (supeior.GetType().Name == "Specialist")
            {
                nextHandler = supeior;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public override void HandleDiagnose(PatientLevel patient)
        {
            if (patient == PatientLevel.Medium)
            {
                Console.WriteLine("Patient Diagnosted by Doctor");
            }
            else
            {
                nextHandler.HandleDiagnose(patient);
            }
        }
    }
}
