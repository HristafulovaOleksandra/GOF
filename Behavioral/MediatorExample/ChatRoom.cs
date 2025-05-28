using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.MediatorExample
{
    public class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} [{user.Name}]: {message}");
        }
    }
}
