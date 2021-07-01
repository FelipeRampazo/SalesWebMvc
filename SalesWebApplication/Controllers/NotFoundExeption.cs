﻿using System;
using System.Runtime.Serialization;

namespace SalesWebApplication.Controllers
{
    [Serializable]
    internal class NotFoundExeption : Exception
    {
        public NotFoundExeption()
        {
        }

        public NotFoundExeption(string message) : base(message)
        {
        }

        public NotFoundExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}