using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioListener : AudioBehaviour
{
	private delegate float get_volumeDelegate();

	private delegate void set_volumeDelegate(float value);

	private delegate bool get_pauseDelegate();

	private delegate void set_pauseDelegate(bool value);

	private delegate void GetOutputDataHelper_InjectedDelegate([Out] IntPtr samples, int channel);

	private delegate AudioVelocityUpdateMode get_velocityUpdateMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_velocityUpdateMode_InjectedDelegate(IntPtr _unity_self, AudioVelocityUpdateMode value);

	private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumDataHelper_Injected_Private_Static_Void_byref_BlittableArrayWrapper_Int32_FFTWindow_0;

	private static readonly get_volumeDelegate get_volumeDelegateField;

	private static readonly set_volumeDelegate set_volumeDelegateField;

	private static readonly get_pauseDelegate get_pauseDelegateField;

	private static readonly set_pauseDelegate set_pauseDelegateField;

	private static readonly GetOutputDataHelper_InjectedDelegate GetOutputDataHelper_InjectedDelegateField;

	private static readonly get_velocityUpdateMode_InjectedDelegate get_velocityUpdateMode_InjectedDelegateField;

	private static readonly set_velocityUpdateMode_InjectedDelegate set_velocityUpdateMode_InjectedDelegateField;

	public static float volume
	{
		get
		{
			return get_volumeDelegateField();
		}
		set
		{
			set_volumeDelegateField(value);
		}
	}

	public static bool pause
	{
		get
		{
			return get_pauseDelegateField();
		}
		set
		{
			set_pauseDelegateField(value);
		}
	}

	public AudioVelocityUpdateMode velocityUpdateMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_velocityUpdateMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_velocityUpdateMode_Injected(intPtr, value);
		}
	}

	static AudioListener()
	{
		Il2CppClassPointerStore<AudioListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioListener");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioListener>.NativeClassPtr);
		NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_GetSpectrumData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_GetSpectrumDataHelper_Injected_Private_Static_Void_byref_BlittableArrayWrapper_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663330);
		get_volumeDelegateField = IL2CPP.ResolveICall<get_volumeDelegate>("UnityEngine.AudioListener::get_volume");
		set_volumeDelegateField = IL2CPP.ResolveICall<set_volumeDelegate>("UnityEngine.AudioListener::set_volume");
		get_pauseDelegateField = IL2CPP.ResolveICall<get_pauseDelegate>("UnityEngine.AudioListener::get_pause");
		set_pauseDelegateField = IL2CPP.ResolveICall<set_pauseDelegate>("UnityEngine.AudioListener::set_pause");
		GetOutputDataHelper_InjectedDelegateField = IL2CPP.ResolveICall<GetOutputDataHelper_InjectedDelegate>("UnityEngine.AudioListener::GetOutputDataHelper_Injected");
		get_velocityUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<get_velocityUpdateMode_InjectedDelegate>("UnityEngine.AudioListener::get_velocityUpdateMode_Injected");
		set_velocityUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<set_velocityUpdateMode_InjectedDelegate>("UnityEngine.AudioListener::set_velocityUpdateMode_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162897, RefRangeEnd = 1162898, XrefRangeStart = 1162889, XrefRangeEnd = 1162897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSpectrumDataHelper([Out] Il2CppStructArray<float> samples, int channel, FFTWindow window)
	{
		//IL_0053: Expected native int or pointer, but got O
		IntPtr* ptr = stackalloc IntPtr[3];
		nint num = 0;
		*ptr = (nint)(&num);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &channel;
		*(FFTWindow**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &window;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		Unsafe.Write((void*)(nint)samples, (num2 == 0) ? null : new Il2CppStructArray<float>((IntPtr)num2));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162899, RefRangeEnd = 1162900, XrefRangeStart = 1162898, XrefRangeEnd = 1162899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSpectrumData(Il2CppStructArray<float> samples, int channel, FFTWindow window)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)samples);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &channel;
		*(FFTWindow**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &window;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpectrumData_Public_Static_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioListener()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioListener>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162900, XrefRangeEnd = 1162902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSpectrumDataHelper_Injected(out BlittableArrayWrapper samples, int channel, FFTWindow window)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref samples);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &channel;
		*(FFTWindow**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &window;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpectrumDataHelper_Injected_Private_Static_Void_byref_BlittableArrayWrapper_Int32_FFTWindow_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AudioListener(IntPtr pointer)
		: base(pointer)
	{
	}

	public static void GetOutputDataHelper([Out] Il2CppStructArray<float> samples, int channel)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<float> GetOutputData(int numSamples, int channel)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static void GetOutputData(Il2CppStructArray<float> samples, int channel)
	{
		GetOutputDataHelper(samples, channel);
	}

	public static Il2CppStructArray<float> GetSpectrumData(int numSamples, int channel, FFTWindow window)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public unsafe static void GetOutputDataHelper_Injected(out BlittableArrayWrapper samples, int channel)
	{
		GetOutputDataHelper_InjectedDelegateField((nint)Unsafe.AsPointer(ref samples), channel);
	}

	public static AudioVelocityUpdateMode get_velocityUpdateMode_Injected(IntPtr _unity_self)
	{
		return get_velocityUpdateMode_InjectedDelegateField(_unity_self);
	}

	public static void set_velocityUpdateMode_Injected(IntPtr _unity_self, AudioVelocityUpdateMode value)
	{
		set_velocityUpdateMode_InjectedDelegateField(_unity_self, value);
	}
}
