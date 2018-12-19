using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter01
{
    public class Worker
    {
        private readonly IScreen screen;
        private IMessage message;

        public Worker(IScreen screen, IMessage message)
        {
            this.screen = screen;
            this.message = message;
        }

        public void ReverseTextValue()
        {
            char[] arr = screen.TextValue.ToCharArray();
            Array.Reverse(arr);
            message.MyMessage = new string(arr);
        }

        public void SetTextValue()
        {
            message.MyMessage = screen.Answer;
        }
    }
}
