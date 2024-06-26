using ChainOfResp_Project.Models;

namespace ChainOfResp_Project.ChainOfResponsibility
{
    public abstract class Employe
    {
        protected Employe NextApprover;
        public void SetNextApprover(Employe superVisior)
        {
            this.NextApprover = superVisior;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel model);
    }
}
