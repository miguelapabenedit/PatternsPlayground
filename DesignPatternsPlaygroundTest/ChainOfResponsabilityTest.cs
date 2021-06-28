using DesignPatternsPlayground.ChainOfResponsability.Abstract;
using DesignPatternsPlayground.ChainOfResponsability.Concrete;
using NUnit.Framework;

namespace DesignPatternsPlaygroundTest
{
    public class ChainOfResponsabilityTest
    {
        [Test ]
        public void ChainOfResponsability_PassLowPatient_ProcessPatientResident()
        {
            Specialist specialist = new();
            Doctor doctor = new(specialist);
            Resident resident = new(doctor);

            resident.HandleDiagnose(PatientLevel.Low);
            resident.HandleDiagnose(PatientLevel.High);
            doctor.HandleDiagnose(PatientLevel.High);
            specialist.HandleDiagnose(PatientLevel.High);
            doctor.HandleDiagnose(PatientLevel.Low);
        }
    }
}
