using System;
using Il2CppInterop.Runtime;

namespace Unity.Audio;

public struct DSPSampleProviderInternal
{
	private delegate int Internal_ReadUInt8FromSampleProviderDelegate(System.IntPtr provider, int format, System.IntPtr buffer, int length);

	private delegate int Internal_ReadSInt16FromSampleProviderDelegate(System.IntPtr provider, int format, System.IntPtr buffer, int length);

	private delegate int Internal_ReadFloatFromSampleProviderDelegate(System.IntPtr provider, System.IntPtr buffer, int length);

	private delegate ushort Internal_GetChannelCountDelegate(System.IntPtr provider);

	private delegate uint Internal_GetSampleRateDelegate(System.IntPtr provider);

	private delegate int Internal_ReadUInt8FromSampleProviderByIdDelegate(uint providerId, int format, System.IntPtr buffer, int length);

	private delegate int Internal_ReadSInt16FromSampleProviderByIdDelegate(uint providerId, int format, System.IntPtr buffer, int length);

	private delegate int Internal_ReadFloatFromSampleProviderByIdDelegate(uint providerId, System.IntPtr buffer, int length);

	private delegate ushort Internal_GetChannelCountByIdDelegate(uint providerId);

	private delegate uint Internal_GetSampleRateByIdDelegate(uint providerId);

	private static readonly Internal_ReadUInt8FromSampleProviderDelegate Internal_ReadUInt8FromSampleProviderDelegateField = IL2CPP.ResolveICall<Internal_ReadUInt8FromSampleProviderDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadUInt8FromSampleProvider");

	private static readonly Internal_ReadSInt16FromSampleProviderDelegate Internal_ReadSInt16FromSampleProviderDelegateField = IL2CPP.ResolveICall<Internal_ReadSInt16FromSampleProviderDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadSInt16FromSampleProvider");

	private static readonly Internal_ReadFloatFromSampleProviderDelegate Internal_ReadFloatFromSampleProviderDelegateField = IL2CPP.ResolveICall<Internal_ReadFloatFromSampleProviderDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadFloatFromSampleProvider");

	private static readonly Internal_GetChannelCountDelegate Internal_GetChannelCountDelegateField = IL2CPP.ResolveICall<Internal_GetChannelCountDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_GetChannelCount");

	private static readonly Internal_GetSampleRateDelegate Internal_GetSampleRateDelegateField = IL2CPP.ResolveICall<Internal_GetSampleRateDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_GetSampleRate");

	private static readonly Internal_ReadUInt8FromSampleProviderByIdDelegate Internal_ReadUInt8FromSampleProviderByIdDelegateField = IL2CPP.ResolveICall<Internal_ReadUInt8FromSampleProviderByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadUInt8FromSampleProviderById");

	private static readonly Internal_ReadSInt16FromSampleProviderByIdDelegate Internal_ReadSInt16FromSampleProviderByIdDelegateField = IL2CPP.ResolveICall<Internal_ReadSInt16FromSampleProviderByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadSInt16FromSampleProviderById");

	private static readonly Internal_ReadFloatFromSampleProviderByIdDelegate Internal_ReadFloatFromSampleProviderByIdDelegateField = IL2CPP.ResolveICall<Internal_ReadFloatFromSampleProviderByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadFloatFromSampleProviderById");

	private static readonly Internal_GetChannelCountByIdDelegate Internal_GetChannelCountByIdDelegateField = IL2CPP.ResolveICall<Internal_GetChannelCountByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_GetChannelCountById");

	private static readonly Internal_GetSampleRateByIdDelegate Internal_GetSampleRateByIdDelegateField = IL2CPP.ResolveICall<Internal_GetSampleRateByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_GetSampleRateById");

	public unsafe static int Internal_ReadUInt8FromSampleProvider(void* provider, int format, void* buffer, int length)
	{
		return Internal_ReadUInt8FromSampleProviderDelegateField((nint)provider, format, (nint)buffer, length);
	}

	public unsafe static int Internal_ReadSInt16FromSampleProvider(void* provider, int format, void* buffer, int length)
	{
		return Internal_ReadSInt16FromSampleProviderDelegateField((nint)provider, format, (nint)buffer, length);
	}

	public unsafe static int Internal_ReadFloatFromSampleProvider(void* provider, void* buffer, int length)
	{
		return Internal_ReadFloatFromSampleProviderDelegateField((nint)provider, (nint)buffer, length);
	}

	public unsafe static ushort Internal_GetChannelCount(void* provider)
	{
		return Internal_GetChannelCountDelegateField((nint)provider);
	}

	public unsafe static uint Internal_GetSampleRate(void* provider)
	{
		return Internal_GetSampleRateDelegateField((nint)provider);
	}

	public unsafe static int Internal_ReadUInt8FromSampleProviderById(uint providerId, int format, void* buffer, int length)
	{
		return Internal_ReadUInt8FromSampleProviderByIdDelegateField(providerId, format, (nint)buffer, length);
	}

	public unsafe static int Internal_ReadSInt16FromSampleProviderById(uint providerId, int format, void* buffer, int length)
	{
		return Internal_ReadSInt16FromSampleProviderByIdDelegateField(providerId, format, (nint)buffer, length);
	}

	public unsafe static int Internal_ReadFloatFromSampleProviderById(uint providerId, void* buffer, int length)
	{
		return Internal_ReadFloatFromSampleProviderByIdDelegateField(providerId, (nint)buffer, length);
	}

	public static ushort Internal_GetChannelCountById(uint providerId)
	{
		return Internal_GetChannelCountByIdDelegateField(providerId);
	}

	public static uint Internal_GetSampleRateById(uint providerId)
	{
		return Internal_GetSampleRateByIdDelegateField(providerId);
	}
}
