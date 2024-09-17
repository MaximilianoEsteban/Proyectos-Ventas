using MimeKit.Text;
using MimeKit;

namespace Carrefour.BackEnd.Models
{
    public class MailModel
    {
        public string email{ get; set; }          
        public string subject { get; set; }
        public string message { get; set; }
    }
}
