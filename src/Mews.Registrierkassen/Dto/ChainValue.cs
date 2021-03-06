﻿using System;

namespace Mews.Registrierkassen.Dto
{
    public sealed class ChainValue : ByteValue
    {
        public ChainValue(byte[] value)
            : base(value)
        {
            if (Value.Length != 8)
            {
                throw new ArgumentException("Unexpected number of bytes.");
            }
        }
    }
}
