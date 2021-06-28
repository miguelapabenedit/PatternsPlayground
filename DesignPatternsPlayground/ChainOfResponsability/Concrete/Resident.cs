using DesignPatternsPlayground.ChainOfResponsability.Abstract;
using System;

namespace DesignPatternsPlayground.ChainOfResponsability.Concrete
{
    public class Resident : HealthStaff
    {
        public Resident(HealthStaff supeior)
        {
            if(supeior.GetType().Name == "Doctor" || supeior.GetType().Name == "Specialist")
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
            if(patient == PatientLevel.Low)
            {
                Console.WriteLine("Patient Diagnosted by Resident");
            }
            else
            {
                nextHandler.HandleDiagnose(patient);
            }
        }
    }
}
