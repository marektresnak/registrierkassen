﻿using Mews.Registrierkassen.Dto.Identifiers;

namespace Mews.Registrierkassen.Dto
{
    public class SignedQrData
    {
        public SignedQrData(QrData data, JwsSignature signature)
        {
            Data = data;
            Signature = signature;
            Value = ComputeValue();
        }

        public QrData Data { get; }

        public JwsSignature Signature { get; }

        public string Value { get; }

        public override string ToString()
        {
            return Value;
        }

        private string ComputeValue()
        {
            return $"{Data}_{Signature.Base64String}";
        }
    }
}

