using ChainOfResp_Project.DAL;
using ChainOfResp_Project.Models;

namespace ChainOfResp_Project.ChainOfResponsibility
{
    public class AreaDirector : Employe
    {
        private readonly Context _context;

        public AreaDirector(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 350000)
            {

                CustomerProcess customer = new CustomerProcess();
                customer.Amount = model.Amount;
                customer.Name = model.Name;
                customer.EmployerName = "Bölge Yöneticisi";
                customer.Description = "İstenen Tutar Müşteriye Bölge yöneticisi tarafından Ödendi";
                _context.customerProcesses.Add(customer);
                _context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess(); 
                customerProcess.Amount = model.Amount; 
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Bölge Yöneticisi";
                customerProcess.Description = "Günlük ödeme limiti aştığı için ödeme yapılamadı,müşteriye Bilgi verildi"; 
                _context.customerProcesses.Add(customerProcess); 
                _context.SaveChanges();
            }
        }
    }
}
