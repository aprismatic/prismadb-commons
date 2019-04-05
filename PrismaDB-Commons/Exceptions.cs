using System;

namespace PrismaDB.Commons
{
    public class PrismaException : Exception
    {
        public PrismaException() { }
        public PrismaException(string message) : base(message) { }
        public PrismaException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class PrismaParserException : PrismaException
    {
        public PrismaParserException() { }
        public PrismaParserException(string message) : base(message) { }
        public PrismaParserException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class PrismaDriverException : PrismaException
    {
        public PrismaDriverException() { }
        public PrismaDriverException(string message) : base(message) { }
        public PrismaDriverException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class PrismaCoreException : PrismaException
    {
        public PrismaCoreException() { }
        public PrismaCoreException(string message) : base(message) { }
        public PrismaCoreException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class PrismaDeployUdfException : PrismaDriverException
    {
        public PrismaDeployUdfException() { }
        public PrismaDeployUdfException(string message) : base(message) { }
        public PrismaDeployUdfException(string message, Exception innerException) : base(message, innerException) { }
    }
}
