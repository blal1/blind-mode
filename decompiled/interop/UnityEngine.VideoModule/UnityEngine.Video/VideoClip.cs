using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine.Video;

public sealed class VideoClip : Object
{
	private delegate void get_originalPath_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate ulong get_frameCount_InjectedDelegate(IntPtr _unity_self);

	private delegate double get_frameRate_InjectedDelegate(IntPtr _unity_self);

	private delegate double get_length_InjectedDelegate(IntPtr _unity_self);

	private delegate uint get_width_InjectedDelegate(IntPtr _unity_self);

	private delegate uint get_height_InjectedDelegate(IntPtr _unity_self);

	private delegate uint get_pixelAspectRatioNumerator_InjectedDelegate(IntPtr _unity_self);

	private delegate uint get_pixelAspectRatioDenominator_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_sRGB_InjectedDelegate(IntPtr _unity_self);

	private delegate ushort get_audioTrackCount_InjectedDelegate(IntPtr _unity_self);

	private delegate ushort GetAudioChannelCount_InjectedDelegate(IntPtr _unity_self, ushort audioTrackIdx);

	private delegate uint GetAudioSampleRate_InjectedDelegate(IntPtr _unity_self, ushort audioTrackIdx);

	private delegate void GetAudioLanguage_InjectedDelegate(IntPtr _unity_self, ushort audioTrackIdx, [Out] IntPtr ret);

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly get_originalPath_InjectedDelegate get_originalPath_InjectedDelegateField;

	private static readonly get_frameCount_InjectedDelegate get_frameCount_InjectedDelegateField;

	private static readonly get_frameRate_InjectedDelegate get_frameRate_InjectedDelegateField;

	private static readonly get_length_InjectedDelegate get_length_InjectedDelegateField;

	private static readonly get_width_InjectedDelegate get_width_InjectedDelegateField;

	private static readonly get_height_InjectedDelegate get_height_InjectedDelegateField;

	private static readonly get_pixelAspectRatioNumerator_InjectedDelegate get_pixelAspectRatioNumerator_InjectedDelegateField;

	private static readonly get_pixelAspectRatioDenominator_InjectedDelegate get_pixelAspectRatioDenominator_InjectedDelegateField;

	private static readonly get_sRGB_InjectedDelegate get_sRGB_InjectedDelegateField;

	private static readonly get_audioTrackCount_InjectedDelegate get_audioTrackCount_InjectedDelegateField;

	private static readonly GetAudioChannelCount_InjectedDelegate GetAudioChannelCount_InjectedDelegateField;

	private static readonly GetAudioSampleRate_InjectedDelegate GetAudioSampleRate_InjectedDelegateField;

	private static readonly GetAudioLanguage_InjectedDelegate GetAudioLanguage_InjectedDelegateField;

	public string originalPath
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				get_originalPath_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public ulong frameCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_frameCount_Injected(intPtr);
		}
	}

	public double frameRate
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_frameRate_Injected(intPtr);
		}
	}

	public double length
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_length_Injected(intPtr);
		}
	}

	public uint width
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_width_Injected(intPtr);
		}
	}

	public uint height
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_height_Injected(intPtr);
		}
	}

	public uint pixelAspectRatioNumerator
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pixelAspectRatioNumerator_Injected(intPtr);
		}
	}

	public uint pixelAspectRatioDenominator
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pixelAspectRatioDenominator_Injected(intPtr);
		}
	}

	public bool sRGB
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sRGB_Injected(intPtr);
		}
	}

	public ushort audioTrackCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_audioTrackCount_Injected(intPtr);
		}
	}

	static VideoClip()
	{
		Il2CppClassPointerStore<VideoClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VideoModule.dll", "UnityEngine.Video", "VideoClip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoClip>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoClip>.NativeClassPtr, 100663299);
		get_originalPath_InjectedDelegateField = IL2CPP.ResolveICall<get_originalPath_InjectedDelegate>("UnityEngine.Video.VideoClip::get_originalPath_Injected");
		get_frameCount_InjectedDelegateField = IL2CPP.ResolveICall<get_frameCount_InjectedDelegate>("UnityEngine.Video.VideoClip::get_frameCount_Injected");
		get_frameRate_InjectedDelegateField = IL2CPP.ResolveICall<get_frameRate_InjectedDelegate>("UnityEngine.Video.VideoClip::get_frameRate_Injected");
		get_length_InjectedDelegateField = IL2CPP.ResolveICall<get_length_InjectedDelegate>("UnityEngine.Video.VideoClip::get_length_Injected");
		get_width_InjectedDelegateField = IL2CPP.ResolveICall<get_width_InjectedDelegate>("UnityEngine.Video.VideoClip::get_width_Injected");
		get_height_InjectedDelegateField = IL2CPP.ResolveICall<get_height_InjectedDelegate>("UnityEngine.Video.VideoClip::get_height_Injected");
		get_pixelAspectRatioNumerator_InjectedDelegateField = IL2CPP.ResolveICall<get_pixelAspectRatioNumerator_InjectedDelegate>("UnityEngine.Video.VideoClip::get_pixelAspectRatioNumerator_Injected");
		get_pixelAspectRatioDenominator_InjectedDelegateField = IL2CPP.ResolveICall<get_pixelAspectRatioDenominator_InjectedDelegate>("UnityEngine.Video.VideoClip::get_pixelAspectRatioDenominator_Injected");
		get_sRGB_InjectedDelegateField = IL2CPP.ResolveICall<get_sRGB_InjectedDelegate>("UnityEngine.Video.VideoClip::get_sRGB_Injected");
		get_audioTrackCount_InjectedDelegateField = IL2CPP.ResolveICall<get_audioTrackCount_InjectedDelegate>("UnityEngine.Video.VideoClip::get_audioTrackCount_Injected");
		GetAudioChannelCount_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioChannelCount_InjectedDelegate>("UnityEngine.Video.VideoClip::GetAudioChannelCount_Injected");
		GetAudioSampleRate_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioSampleRate_InjectedDelegate>("UnityEngine.Video.VideoClip::GetAudioSampleRate_Injected");
		GetAudioLanguage_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioLanguage_InjectedDelegate>("UnityEngine.Video.VideoClip::GetAudioLanguage_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410722, XrefRangeEnd = 1410726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VideoClip()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoClip>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VideoClip(IntPtr pointer)
		: base(pointer)
	{
	}

	public ushort GetAudioChannelCount(ushort audioTrackIdx)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAudioChannelCount_Injected(intPtr, audioTrackIdx);
	}

	public uint GetAudioSampleRate(ushort audioTrackIdx)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAudioSampleRate_Injected(intPtr, audioTrackIdx);
	}

	public string GetAudioLanguage(ushort audioTrackIdx)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			GetAudioLanguage_Injected(intPtr, audioTrackIdx, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void get_originalPath_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_originalPath_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static ulong get_frameCount_Injected(IntPtr _unity_self)
	{
		return get_frameCount_InjectedDelegateField(_unity_self);
	}

	public static double get_frameRate_Injected(IntPtr _unity_self)
	{
		return get_frameRate_InjectedDelegateField(_unity_self);
	}

	public static double get_length_Injected(IntPtr _unity_self)
	{
		return get_length_InjectedDelegateField(_unity_self);
	}

	public static uint get_width_Injected(IntPtr _unity_self)
	{
		return get_width_InjectedDelegateField(_unity_self);
	}

	public static uint get_height_Injected(IntPtr _unity_self)
	{
		return get_height_InjectedDelegateField(_unity_self);
	}

	public static uint get_pixelAspectRatioNumerator_Injected(IntPtr _unity_self)
	{
		return get_pixelAspectRatioNumerator_InjectedDelegateField(_unity_self);
	}

	public static uint get_pixelAspectRatioDenominator_Injected(IntPtr _unity_self)
	{
		return get_pixelAspectRatioDenominator_InjectedDelegateField(_unity_self);
	}

	public static bool get_sRGB_Injected(IntPtr _unity_self)
	{
		return get_sRGB_InjectedDelegateField(_unity_self);
	}

	public static ushort get_audioTrackCount_Injected(IntPtr _unity_self)
	{
		return get_audioTrackCount_InjectedDelegateField(_unity_self);
	}

	public static ushort GetAudioChannelCount_Injected(IntPtr _unity_self, ushort audioTrackIdx)
	{
		return GetAudioChannelCount_InjectedDelegateField(_unity_self, audioTrackIdx);
	}

	public static uint GetAudioSampleRate_Injected(IntPtr _unity_self, ushort audioTrackIdx)
	{
		return GetAudioSampleRate_InjectedDelegateField(_unity_self, audioTrackIdx);
	}

	public unsafe static void GetAudioLanguage_Injected(IntPtr _unity_self, ushort audioTrackIdx, out ManagedSpanWrapper ret)
	{
		GetAudioLanguage_InjectedDelegateField(_unity_self, audioTrackIdx, (nint)Unsafe.AsPointer(ref ret));
	}
}
