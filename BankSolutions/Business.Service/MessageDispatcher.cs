using System;
using System.Collections.Generic;

namespace Business.Service
{
    public class MessageDispatcher
    {
        private Dictionary<Type, Action<object>> commandHandlers =
            new Dictionary<Type, Action<object>>(); 

        public void SendCommand<TCommand>(TCommand c)
        {
            Action<object> cmdHandler;
            var cmdType = typeof (TCommand);

            if (commandHandlers.TryGetValue(cmdType, out cmdHandler))
                cmdHandler(c);
            else
                throw new CommandHandlerNotRegisteredException(cmdType.Name);
        }
    }
}
