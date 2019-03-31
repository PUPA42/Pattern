using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Mediator
{
    class ChatRoom
    {
        public static void ShowMessage(User user,string message)
        {
            Console.WriteLine(System.DateTime.Now.ToString()+"["+
                user.GetName()+"]:"+message);
        }

    }
}
