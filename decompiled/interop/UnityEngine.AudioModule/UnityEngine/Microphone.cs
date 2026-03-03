using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Microphone
{
	private delegate void EndRecordDelegate(int deviceID);

	private delegate bool IsRecordingDelegate(int deviceID);

	private delegate int GetRecordPositionDelegate(int deviceID);

	private delegate void GetDeviceCapsDelegate(int deviceID, [Out] System.IntPtr minFreq, [Out] System.IntPtr maxFreq);

	private delegate System.IntPtr get_devicesDelegate();

	private delegate bool get_isAnyDeviceRecordingDelegate();

	private delegate int GetMicrophoneDeviceIDFromName_InjectedDelegate(System.IntPtr name);

	private delegate System.IntPtr StartRecord_InjectedDelegate(int deviceID, bool loop, float lengthSec, int frequency);

	private static readonly EndRecordDelegate EndRecordDelegateField = IL2CPP.ResolveICall<EndRecordDelegate>("UnityEngine.Microphone::EndRecord");

	private static readonly IsRecordingDelegate IsRecordingDelegateField = IL2CPP.ResolveICall<IsRecordingDelegate>("UnityEngine.Microphone::IsRecording");

	private static readonly GetRecordPositionDelegate GetRecordPositionDelegateField = IL2CPP.ResolveICall<GetRecordPositionDelegate>("UnityEngine.Microphone::GetRecordPosition");

	private static readonly GetDeviceCapsDelegate GetDeviceCapsDelegateField = IL2CPP.ResolveICall<GetDeviceCapsDelegate>("UnityEngine.Microphone::GetDeviceCaps");

	private static readonly get_devicesDelegate get_devicesDelegateField = IL2CPP.ResolveICall<get_devicesDelegate>("UnityEngine.Microphone::get_devices");

	private static readonly get_isAnyDeviceRecordingDelegate get_isAnyDeviceRecordingDelegateField = IL2CPP.ResolveICall<get_isAnyDeviceRecordingDelegate>("UnityEngine.Microphone::get_isAnyDeviceRecording");

	private static readonly GetMicrophoneDeviceIDFromName_InjectedDelegate GetMicrophoneDeviceIDFromName_InjectedDelegateField = IL2CPP.ResolveICall<GetMicrophoneDeviceIDFromName_InjectedDelegate>("UnityEngine.Microphone::GetMicrophoneDeviceIDFromName_Injected");

	private static readonly StartRecord_InjectedDelegate StartRecord_InjectedDelegateField = IL2CPP.ResolveICall<StartRecord_InjectedDelegate>("UnityEngine.Microphone::StartRecord_Injected");

	public static Il2CppStringArray devices
	{
		get
		{
			System.IntPtr intPtr = get_devicesDelegateField();
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
	}

	public static bool isAnyDeviceRecording => get_isAnyDeviceRecordingDelegateField();

	public unsafe static int GetMicrophoneDeviceIDFromName(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetMicrophoneDeviceIDFromName_Injected(ref managedSpanWrapper);
				}
			}
			return GetMicrophoneDeviceIDFromName_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static AudioClip StartRecord(int deviceID, bool loop, float lengthSec, int frequency)
	{
		return Unmarshal.UnmarshalUnityObject<AudioClip>(StartRecord_Injected(deviceID, loop, lengthSec, frequency));
	}

	public static void EndRecord(int deviceID)
	{
		EndRecordDelegateField(deviceID);
	}

	public static bool IsRecording(int deviceID)
	{
		return IsRecordingDelegateField(deviceID);
	}

	public static int GetRecordPosition(int deviceID)
	{
		return GetRecordPositionDelegateField(deviceID);
	}

	public unsafe static void GetDeviceCaps(int deviceID, out int minFreq, out int maxFreq)
	{
		GetDeviceCapsDelegateField(deviceID, (nint)Unsafe.AsPointer(ref minFreq), (nint)Unsafe.AsPointer(ref maxFreq));
	}

	public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency)
	{
		int microphoneDeviceIDFromName = GetMicrophoneDeviceIDFromName(deviceName);
		if (microphoneDeviceIDFromName == -1)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Couldn't acquire device ID for device name ", deviceName));
		}
		if (lengthSec <= 0)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Length of recording must be greater than zero seconds (was: ", lengthSec.ToString(), " seconds)"));
		}
		if (lengthSec > 3600)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Length of recording must be less than one hour (was: ", lengthSec.ToString(), " seconds)"));
		}
		if (frequency <= 0)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Frequency of recording must be greater than zero (was: ", frequency.ToString(), " Hz)"));
		}
		return StartRecord(microphoneDeviceIDFromName, loop, lengthSec, frequency);
	}

	public static void End(string deviceName)
	{
		int microphoneDeviceIDFromName = GetMicrophoneDeviceIDFromName(deviceName);
		if (microphoneDeviceIDFromName != -1)
		{
			EndRecord(microphoneDeviceIDFromName);
		}
	}

	public static bool IsRecording(string deviceName)
	{
		int microphoneDeviceIDFromName = GetMicrophoneDeviceIDFromName(deviceName);
		if (microphoneDeviceIDFromName == -1)
		{
			return false;
		}
		return IsRecording(microphoneDeviceIDFromName);
	}

	public static int GetPosition(string deviceName)
	{
		int microphoneDeviceIDFromName = GetMicrophoneDeviceIDFromName(deviceName);
		if (microphoneDeviceIDFromName == -1)
		{
			return 0;
		}
		return GetRecordPosition(microphoneDeviceIDFromName);
	}

	public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq)
	{
		minFreq = 0;
		maxFreq = 0;
		int microphoneDeviceIDFromName = GetMicrophoneDeviceIDFromName(deviceName);
		if (microphoneDeviceIDFromName != -1)
		{
			GetDeviceCaps(microphoneDeviceIDFromName, out minFreq, out maxFreq);
		}
	}

	public unsafe static int GetMicrophoneDeviceIDFromName_Injected(ref ManagedSpanWrapper name)
	{
		return GetMicrophoneDeviceIDFromName_InjectedDelegateField((nint)Unsafe.AsPointer(ref name));
	}

	public static System.IntPtr StartRecord_Injected(int deviceID, bool loop, float lengthSec, int frequency)
	{
		return StartRecord_InjectedDelegateField(deviceID, loop, lengthSec, frequency);
	}
}
