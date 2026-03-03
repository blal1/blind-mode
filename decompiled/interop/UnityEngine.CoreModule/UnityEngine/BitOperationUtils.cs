using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public static class BitOperationUtils
{
	public static int CountBits(int mask)
	{
		return CountBits((uint)mask);
	}

	public static int CountBits(uint mask)
	{
		uint num = 0u;
		while (mask != 0)
		{
			num += mask & 1;
			mask >>= 1;
		}
		return (int)num;
	}

	public static bool IsValueWithinMaskedBitsRange(uint value, uint mask, int bitCount)
	{
		return AnyBitMatch(mask, value) && IsValueSmallerOrEqualThanIndex(value, BitCountToIndex(bitCount));
	}

	public static uint ModifyMaskByValuesArrayAndBitCount(uint mask, IEnumerable<int> values, [Optional] int bitCount)
	{
		AssertBitCount(bitCount);
		uint num = 0u;
		IEnumerator<int> enumerator = values.GetEnumerator();
		try
		{
			while (((IEnumerator)(object)enumerator).MoveNext())
			{
				int current = enumerator.Current;
				uint num2 = (uint)current;
				if (IsValueWithinMaskedBitsRange(num2, mask, bitCount))
				{
					num += num2;
				}
			}
		}
		finally
		{
			((IDisposable)(object)enumerator)?.Dispose();
		}
		return num;
	}

	public static bool AreAllBitsSetForValues(uint mask, IEnumerable<int> values, [Optional] int bitCount)
	{
		AssertBitCount(bitCount);
		IEnumerator<int> enumerator = values.GetEnumerator();
		try
		{
			while (((IEnumerator)(object)enumerator).MoveNext())
			{
				int current = enumerator.Current;
				uint value = (uint)current;
				if (!AnyBitMatch(mask, value) || IsValueBiggerOrEqualThanIndex(value, BitCountToIndex(bitCount)))
				{
					return false;
				}
			}
		}
		finally
		{
			((IDisposable)(object)enumerator)?.Dispose();
		}
		return true;
	}

	public static uint IndexToValue(int index)
	{
		AssertIndex(index);
		return (uint)(1 << index);
	}

	public static bool IsValueSmallerThanIndex(uint value, int index)
	{
		AssertIndex(index);
		return value < IndexToValue(index);
	}

	public static bool IsValueBiggerThanIndex(uint value, int index)
	{
		AssertIndex(index);
		return value > IndexToValue(index);
	}

	public static bool IsValueSmallerOrEqualThanIndex(uint value, int index)
	{
		AssertIndex(index);
		return value <= IndexToValue(index);
	}

	public static bool IsValueBiggerOrEqualThanIndex(uint value, int index)
	{
		AssertIndex(index);
		return value >= IndexToValue(index);
	}

	public static bool AnyBitMatch(uint mask, uint value)
	{
		return (mask & value) != 0;
	}

	public static int BitCountToIndex(int bitCount)
	{
		AssertBitCount(bitCount);
		return bitCount - 1;
	}

	public static void AssertBitCount(int bitCount)
	{
		Debug.Assert(bitCount >= 1 && bitCount <= 32, "Bit count must be between 1 and 32.");
	}

	public static void AssertIndex(int index)
	{
		Debug.Assert(index >= 0 && index <= 31, "Index must be between 0 and 31.");
	}
}
