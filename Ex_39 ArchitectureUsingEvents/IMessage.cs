using System;

namespace ModelViewPresenter01
{
    public interface IMessage
    {
        event EventHandler<CustomArgs> MessageSetEvent;
        string MyMessage { get; set; }
    }
}
