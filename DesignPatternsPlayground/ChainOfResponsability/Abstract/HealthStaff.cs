using DesignPatternsPlayground.ChainOfResponsability.Interfaces;

namespace DesignPatternsPlayground.ChainOfResponsability.Abstract
{
    public abstract class HealthStaff : IPatientHandler
    {
        protected IPatientHandler nextHandler;

        public abstract void HandleDiagnose(PatientLevel patient);
    }
}
