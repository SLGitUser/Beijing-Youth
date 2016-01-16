using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeijingYouth.Pub.Models;
using BeijingYouth.Pub.Models.JSJL;

namespace BeijingYouth.Pub.Service.JSJL
{
    public class MessagesService
    {
        public static BeijingYouthContext db = new BeijingYouthContext();
        public static bool CreateMessage(Message message)
        {
            var at = DateTime.Now;
            message.SendDate = at;
            db.Messages.Add(message);
            db.SaveChanges();
            return true;
        }
    }
}
