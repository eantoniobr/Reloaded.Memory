﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace Reloaded.Memory.Exceptions
{
    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public class MemoryException : Exception
    {
        /// <inheritdoc />
        public MemoryException()
        { }

        /// <inheritdoc />
        public MemoryException(string message) : base(message)
        { }

        /// <inheritdoc />
        public MemoryException(string message, Exception innerException) : base(message, innerException)
        { }

        /// <inheritdoc />
        protected MemoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
