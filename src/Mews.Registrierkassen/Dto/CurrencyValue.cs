﻿using System;

namespace Mews.Registrierkassen.Dto
{
    public sealed class CurrencyValue
    {
        public CurrencyValue(decimal value)
        {
            var decimalPlaces = BitConverter.GetBytes(Decimal.GetBits(value)[3])[2];
            if (decimalPlaces > 2)
            {
                throw new ArgumentException("API requires the currency values to have at most 2 decimal places.");
            }

            var sanitizedValue = EnsureMinimalPrecision(value, decimalPlaces);

            Value = sanitizedValue;
            CurrencyIsoCode = "EUR";
        }

        public string CurrencyIsoCode { get; }

        public decimal Value { get; }

        private decimal EnsureMinimalPrecision(decimal value, int placesCount)
        {
            switch (placesCount)
            {
                case 0:
                    return value * 1.00m;
                case 1:
                    return value * 1.0m;
                default:
                    return value;
            }
        }
    }
}
