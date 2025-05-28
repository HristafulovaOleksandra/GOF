using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.MediatorExample
{
    public class User
    {
        private string name;
        private IChatRoomMediator chatMediator;

        public User(string name, IChatRoomMediator mediator)
        {
            this.name = name;
            this.chatMediator = mediator;
        }

        public string Name => name;

        public void Send(string message)
        {
            chatMediator.ShowMessage(this, message);
        }
    }
}
