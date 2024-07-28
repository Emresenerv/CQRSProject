using CQRSProject.CQRS.Commands;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class RemoveProductCommandHanler
    {
        private readonly Context _context;

        public RemoveProductCommandHanler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveProductCommand command) 
        {
            var values = _context.Products.Find(command.ProductId);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
