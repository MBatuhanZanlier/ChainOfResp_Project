using ChainOfResp_Project.DAL;
using ChainOfResp_Project.Models;

namespace ChainOfResp_Project.ChainOfResponsibility
{
    public class Treasurey : Employe
    {
        private readonly Context _context;

        public Treasurey(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 80000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Veznedar";
                customerProcess.Description = "İstenen Tutar Müşteriye Veznadar tarafından ödendi";
                _context.customerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Veznedar";
                customerProcess.Description = "Ödeme veznedar Tarafından yapılmadı ve işlem Şube Müdr Yrd. Gönderildi";
                _context.customerProcesses.Add(customerProcess); 
                _context.SaveChanges(); 
                NextApprover.ProcessRequest(model);
            }
        }
    }
}
