namespace HardwareStore.Core.Infrastructure.Exceptions
{
    using static Common.ExceptionMessages;

    public class InvalidGuidFormatException : Exception
    {
        public InvalidGuidFormatException()
            : base(InvalidGuidFormat) { }

        public InvalidGuidFormatException(string message) 
            : base(message) { }
    }
}
