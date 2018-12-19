using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter01
{
    public class Message : IMessage
    {
        public event EventHandler<CustomArgs> MessageSetEvent;
        private string myMessage;

        public string MyMessage {
            get { return this.myMessage; }
            set {
				//should change myMessage and raise the MessageSetEvent
				//To do that we need an CustomArgs instance holding the
				//old (before) and new (after) value of myMessage 
            }
        }

        public Message()
        {
            this.myMessage = "No message";
        }
    }
}
