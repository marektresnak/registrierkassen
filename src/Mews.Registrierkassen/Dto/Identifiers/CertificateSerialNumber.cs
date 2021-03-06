﻿using System.Text.RegularExpressions;
using Mews.Registrierkassen.Dto.Identifiers;

namespace Mews.Registrierkassen.Dto.Identifiers
{
    public sealed class CertificateSerialNumber : StringIdentifier
    {
        public static readonly Regex Pattern = new Regex(".+");

        public CertificateSerialNumber(string value)
            : base(value, Pattern)
        {
        }
    }
}
