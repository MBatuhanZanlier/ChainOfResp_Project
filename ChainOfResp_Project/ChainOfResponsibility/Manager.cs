using ChainOfResp_Project.DAL;
using ChainOfResp_Project.Models;

namespace ChainOfResp_Project.ChainOfResponsibility
{
    public class Manager : Employe
    {
        private readonly Context _context;

        public Manager(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Şube Müdürü";
                customerProcess.Description = "İstenen Tutar Müşteriye Şube Müdürü Tarafından Ödendi";
                _context.customerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Şube Müdürü";
                customerProcess.Description = "Ödeme Şube Müdürü tarafından yapılamadı ve işlem bölge müdürüne gönderildi";
                _context.customerProcesses.Add(customerProcess); 
                _context.SaveChanges(); 
                NextApprover.ProcessRequest(model);
            }
        }
    }
}
