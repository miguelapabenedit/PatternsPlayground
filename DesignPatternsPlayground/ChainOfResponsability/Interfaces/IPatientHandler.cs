using DesignPatternsPlayground.ChainOfResponsability.Abstract;

namespace DesignPatternsPlayground.ChainOfResponsability.Interfaces
{
    public interface IPatientHandler
    {
        void HandleDiagnose(PatientLevel patient);
    }
}
