namespace Business.Service
{
    public class CommandHandlerNotRegisteredException : System.Exception
    {
        public CommandHandlerNotRegisteredException(string name) : base(name)
        {
        }
    }
}
