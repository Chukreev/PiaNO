﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PiaNO
{
    [Serializable]
    public class PiaException : ApplicationException
    {
        protected PiaException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        public PiaException()
        { }

        public PiaException(string message)
            : base(message) { }

        public PiaException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
