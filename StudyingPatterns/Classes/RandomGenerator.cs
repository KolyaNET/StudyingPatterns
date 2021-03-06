﻿using System;
using System.Security.Cryptography;

namespace Classes
{
	/// <summary>
	/// https://stackoverflow.com/questions/42426420/how-to-generate-a-cryptographically-secure-random-integer-within-a-range
	/// TODO: Не потокобезопасно.
	/// </summary>
	public sealed class RandomGenerator
    {
	    private readonly RNGCryptoServiceProvider _csp;

	    public RandomGenerator()
	    {
		    _csp = new RNGCryptoServiceProvider();
	    }

	    public int Next(int minValue, int maxExclusiveValue)
	    {
		    if (minValue >= maxExclusiveValue)
			    throw new ArgumentOutOfRangeException(nameof(minValue), "MinValue must be lower than maxExclusiveValue");

		    var diff = (long)maxExclusiveValue - minValue;
		    var upperBound = uint.MaxValue / diff * diff;

		    uint ui;
		    do
		    {
			    ui = GetRandomUInt();
		    } while (ui >= upperBound);
		    return (int)(minValue + (ui % diff));
	    }

	    private uint GetRandomUInt()
	    {
		    var randomBytes = GenerateRandomBytes(sizeof(uint));
		    return BitConverter.ToUInt32(randomBytes, 0);
	    }

	    private byte[] GenerateRandomBytes(int bytesNumber)
	    {
		    var buffer = new byte[bytesNumber];
		    _csp.GetBytes(buffer);
		    return buffer;
	    }
	}
}
