using ChainOfResp_Project.DAL;
using ChainOfResp_Project.Models;

namespace ChainOfResp_Project.ChainOfResponsibility
{
    public class ManagerAsistant : Employe
    {
        private readonly Context _context;

        public ManagerAsistant(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess(); 
                customerProcess.Amount = model.Amount; 
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Şube Müdür yrd";
                customerProcess.Description = "İstenen tutar müşteriye Şube müdür yardımcısı tarafından ödendi"; 
                _context.customerProcesses.Add(customerProcess);  
                _context.SaveChanges();
            } 
            else if(NextApprover !=null) 
            { 
               CustomerProcess customerProcess=new CustomerProcess(); 
                customerProcess.Amount=model.Amount; 
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Şube Müdürü yrd";
                customerProcess.Description = "Ödeme Şube müdürü Yardımcısı tarafından ödenmedi ve işlem şube müdürüne gönderildi";
                _context.customerProcesses.Add(customerProcess); 
                _context.SaveChanges(); 
                NextApprover.ProcessRequest(model);
            } 
        }
    }
}
