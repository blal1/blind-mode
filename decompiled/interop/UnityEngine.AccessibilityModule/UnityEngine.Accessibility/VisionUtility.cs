using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Accessibility;

public static class VisionUtility
{
	[Serializable]
	public sealed class _003C_003Ec
	{
	}

	public sealed class _003C_003Ec__DisplayClass6_0
	{
	}

	public static float ComputePerceivedLuminance(Color color)
	{
		color = color.linear;
		return Mathf.LinearToGammaSpace(0.2126f * color.r + 0.7152f * color.g + 0.0722f * color.b);
	}

	public static void GetLuminanceValuesForPalette(Il2CppStructArray<Color> palette, ref Il2CppStructArray<float> outLuminanceValues)
	{
		Debug.Assert(palette != null && outLuminanceValues != null, "Passed in arrays can't be null.");
		Debug.Assert(((Il2CppArrayBase)palette).Length == ((Il2CppArrayBase)outLuminanceValues).Length, "Passed in arrays need to be of the same length.");
		for (int i = 0; i < ((Il2CppArrayBase)palette).Length; i++)
		{
			((Il2CppArrayBase<float>)(object)outLuminanceValues)[i] = ComputePerceivedLuminance(((Il2CppArrayBase<Color>)(object)palette)[i]);
		}
	}

	public static int GetColorBlindSafePalette(Il2CppStructArray<Color> palette, float minimumLuminance, float maximumLuminance)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static int GetColorBlindSafePalette(Il2CppStructArray<Color32> palette, float minimumLuminance, float maximumLuminance)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public unsafe static int GetColorBlindSafePaletteInternal(void* palette, int paletteLength, float minimumLuminance, float maximumLuminance, bool useColor32)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
