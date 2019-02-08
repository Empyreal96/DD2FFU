﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.WindowsPhone.ImageUpdate.Tools.Common.IUException
// Assembly: ToolsCommon, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b3f029d4c9c2ec30
// MVID: 8A4E8FCA-4522-42C3-A670-4E93952F2307
// Assembly location: C:\Users\gus33000\source\repos\DD2FFU\DD2FFU\libraries\ToolsCommon.dll

using System;
using System.Runtime.Serialization;
using System.Text;

namespace Decomp.Microsoft.WindowsPhone.ImageUpdate.Tools.Common
{
    public class IUException : Exception
    {
        public IUException()
        {
        }

        public IUException(string message)
            : base(message)
        {
        }

        public IUException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public IUException(string message, params object[] args)
            : this(string.Format(message, args))
        {
        }

        protected IUException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public IUException(Exception innerException, string message)
            : base(message, innerException)
        {
        }

        public IUException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Format(message, args))
        {
        }

        public string MessageTrace
        {
            get
            {
                var stringBuilder = new StringBuilder();
                for (Exception exception = this; exception != null; exception = exception.InnerException)
                    if (!string.IsNullOrEmpty(exception.Message))
                        stringBuilder.AppendLine(exception.Message);
                return stringBuilder.ToString();
            }
        }
    }
}