using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class WebCamTexture : Texture
{
	private delegate void Pause_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Stop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isPlaying_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_deviceName_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_deviceName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate float get_requestedFPS_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_requestedFPS_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_requestedWidth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_requestedWidth_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_requestedHeight_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_requestedHeight_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_videoRotationAngle_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_videoVerticallyMirrored_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_didUpdateThisFrame_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetPixel_InjectedDelegate(System.IntPtr _unity_self, int x, int y, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetPixels_InjectedDelegate(System.IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight);

	private delegate System.IntPtr GetPixels32_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr colors);

	private delegate void get_internalAutoFocusPoint_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_internalAutoFocusPoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate bool get_isDepth_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateWebCamTexture_Private_Static_Void_WebCamTexture_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateWebCamTexture_Injected_Private_Static_Void_WebCamTexture_byref_ManagedSpanWrapper_Int32_Int32_Int32_0;

	private static readonly Pause_InjectedDelegate Pause_InjectedDelegateField;

	private static readonly Stop_InjectedDelegate Stop_InjectedDelegateField;

	private static readonly get_isPlaying_InjectedDelegate get_isPlaying_InjectedDelegateField;

	private static readonly get_deviceName_InjectedDelegate get_deviceName_InjectedDelegateField;

	private static readonly set_deviceName_InjectedDelegate set_deviceName_InjectedDelegateField;

	private static readonly get_requestedFPS_InjectedDelegate get_requestedFPS_InjectedDelegateField;

	private static readonly set_requestedFPS_InjectedDelegate set_requestedFPS_InjectedDelegateField;

	private static readonly get_requestedWidth_InjectedDelegate get_requestedWidth_InjectedDelegateField;

	private static readonly set_requestedWidth_InjectedDelegate set_requestedWidth_InjectedDelegateField;

	private static readonly get_requestedHeight_InjectedDelegate get_requestedHeight_InjectedDelegateField;

	private static readonly set_requestedHeight_InjectedDelegate set_requestedHeight_InjectedDelegateField;

	private static readonly get_videoRotationAngle_InjectedDelegate get_videoRotationAngle_InjectedDelegateField;

	private static readonly get_videoVerticallyMirrored_InjectedDelegate get_videoVerticallyMirrored_InjectedDelegateField;

	private static readonly get_didUpdateThisFrame_InjectedDelegate get_didUpdateThisFrame_InjectedDelegateField;

	private static readonly GetPixel_InjectedDelegate GetPixel_InjectedDelegateField;

	private static readonly GetPixels_InjectedDelegate GetPixels_InjectedDelegateField;

	private static readonly GetPixels32_InjectedDelegate GetPixels32_InjectedDelegateField;

	private static readonly get_internalAutoFocusPoint_InjectedDelegate get_internalAutoFocusPoint_InjectedDelegateField;

	private static readonly set_internalAutoFocusPoint_InjectedDelegate set_internalAutoFocusPoint_InjectedDelegateField;

	private static readonly get_isDepth_InjectedDelegate get_isDepth_InjectedDelegateField;

	public bool isPlaying
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isPlaying_Injected(intPtr);
		}
	}

	public unsafe string deviceName
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_deviceName_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0028: Expected O, but got Ref
			//IL_0034: Expected O, but got Ref
			//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
					fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_deviceName_Injected(intPtr, ref managedSpanWrapper);
						return;
					}
				}
				set_deviceName_Injected(intPtr, ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public float requestedFPS
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_requestedFPS_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_requestedFPS_Injected(intPtr, value);
		}
	}

	public int requestedWidth
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_requestedWidth_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_requestedWidth_Injected(intPtr, value);
		}
	}

	public int requestedHeight
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_requestedHeight_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_requestedHeight_Injected(intPtr, value);
		}
	}

	public int videoRotationAngle
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_videoRotationAngle_Injected(intPtr);
		}
	}

	public bool videoVerticallyMirrored
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_videoVerticallyMirrored_Injected(intPtr);
		}
	}

	public bool didUpdateThisFrame
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_didUpdateThisFrame_Injected(intPtr);
		}
	}

	public unsafe Il2CppSystem.Nullable<Vector2> autoFocusPoint
	{
		get
		{
			return (internalAutoFocusPoint.x < 0f) ? null : new Il2CppSystem.Nullable<Vector2>(internalAutoFocusPoint);
		}
		set
		{
			//IL_0009: Expected O, but got Ref
			//IL_0012: Expected O, but got Ref
			internalAutoFocusPoint = ((!((Il2CppSystem.Nullable<Vector2>)(&value)).HasValue) ? new Vector2(-1f, -1f) : ((Il2CppSystem.Nullable<Vector2>)(&value)).Value);
		}
	}

	public Vector2 internalAutoFocusPoint
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_internalAutoFocusPoint_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_internalAutoFocusPoint_Injected(intPtr, ref value);
		}
	}

	public bool isDepth
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isDepth_Injected(intPtr);
		}
	}

	static WebCamTexture()
	{
		Il2CppClassPointerStore<WebCamTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "WebCamTexture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCamTexture>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCamTexture>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCamTexture>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_Internal_CreateWebCamTexture_Private_Static_Void_WebCamTexture_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCamTexture>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCamTexture>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_Internal_CreateWebCamTexture_Injected_Private_Static_Void_WebCamTexture_byref_ManagedSpanWrapper_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCamTexture>.NativeClassPtr, 100663405);
		Pause_InjectedDelegateField = IL2CPP.ResolveICall<Pause_InjectedDelegate>("UnityEngine.WebCamTexture::Pause_Injected");
		Stop_InjectedDelegateField = IL2CPP.ResolveICall<Stop_InjectedDelegate>("UnityEngine.WebCamTexture::Stop_Injected");
		get_isPlaying_InjectedDelegateField = IL2CPP.ResolveICall<get_isPlaying_InjectedDelegate>("UnityEngine.WebCamTexture::get_isPlaying_Injected");
		get_deviceName_InjectedDelegateField = IL2CPP.ResolveICall<get_deviceName_InjectedDelegate>("UnityEngine.WebCamTexture::get_deviceName_Injected");
		set_deviceName_InjectedDelegateField = IL2CPP.ResolveICall<set_deviceName_InjectedDelegate>("UnityEngine.WebCamTexture::set_deviceName_Injected");
		get_requestedFPS_InjectedDelegateField = IL2CPP.ResolveICall<get_requestedFPS_InjectedDelegate>("UnityEngine.WebCamTexture::get_requestedFPS_Injected");
		set_requestedFPS_InjectedDelegateField = IL2CPP.ResolveICall<set_requestedFPS_InjectedDelegate>("UnityEngine.WebCamTexture::set_requestedFPS_Injected");
		get_requestedWidth_InjectedDelegateField = IL2CPP.ResolveICall<get_requestedWidth_InjectedDelegate>("UnityEngine.WebCamTexture::get_requestedWidth_Injected");
		set_requestedWidth_InjectedDelegateField = IL2CPP.ResolveICall<set_requestedWidth_InjectedDelegate>("UnityEngine.WebCamTexture::set_requestedWidth_Injected");
		get_requestedHeight_InjectedDelegateField = IL2CPP.ResolveICall<get_requestedHeight_InjectedDelegate>("UnityEngine.WebCamTexture::get_requestedHeight_Injected");
		set_requestedHeight_InjectedDelegateField = IL2CPP.ResolveICall<set_requestedHeight_InjectedDelegate>("UnityEngine.WebCamTexture::set_requestedHeight_Injected");
		get_videoRotationAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_videoRotationAngle_InjectedDelegate>("UnityEngine.WebCamTexture::get_videoRotationAngle_Injected");
		get_videoVerticallyMirrored_InjectedDelegateField = IL2CPP.ResolveICall<get_videoVerticallyMirrored_InjectedDelegate>("UnityEngine.WebCamTexture::get_videoVerticallyMirrored_Injected");
		get_didUpdateThisFrame_InjectedDelegateField = IL2CPP.ResolveICall<get_didUpdateThisFrame_InjectedDelegate>("UnityEngine.WebCamTexture::get_didUpdateThisFrame_Injected");
		GetPixel_InjectedDelegateField = IL2CPP.ResolveICall<GetPixel_InjectedDelegate>("UnityEngine.WebCamTexture::GetPixel_Injected");
		GetPixels_InjectedDelegateField = IL2CPP.ResolveICall<GetPixels_InjectedDelegate>("UnityEngine.WebCamTexture::GetPixels_Injected");
		GetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<GetPixels32_InjectedDelegate>("UnityEngine.WebCamTexture::GetPixels32_Injected");
		get_internalAutoFocusPoint_InjectedDelegateField = IL2CPP.ResolveICall<get_internalAutoFocusPoint_InjectedDelegate>("UnityEngine.WebCamTexture::get_internalAutoFocusPoint_Injected");
		set_internalAutoFocusPoint_InjectedDelegateField = IL2CPP.ResolveICall<set_internalAutoFocusPoint_InjectedDelegate>("UnityEngine.WebCamTexture::set_internalAutoFocusPoint_Injected");
		get_isDepth_InjectedDelegateField = IL2CPP.ResolveICall<get_isDepth_InjectedDelegate>("UnityEngine.WebCamTexture::get_isDepth_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163271, RefRangeEnd = 1163272, XrefRangeStart = 1163264, XrefRangeEnd = 1163271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WebCamTexture()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCamTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163277, RefRangeEnd = 1163278, XrefRangeStart = 1163272, XrefRangeEnd = 1163277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163292, RefRangeEnd = 1163293, XrefRangeStart = 1163278, XrefRangeEnd = 1163292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CreateWebCamTexture(WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(scriptingDevice);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestedWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestedHeight;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxFramerate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateWebCamTexture_Private_Static_Void_WebCamTexture_String_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163293, XrefRangeEnd = 1163295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Play_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163295, XrefRangeEnd = 1163297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CreateWebCamTexture_Injected(WebCamTexture self, ref ManagedSpanWrapper scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scriptingDevice);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestedWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestedHeight;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxFramerate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateWebCamTexture_Injected_Private_Static_Void_WebCamTexture_byref_ManagedSpanWrapper_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public WebCamTexture(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Pause()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Pause_Injected(intPtr);
	}

	public void Stop()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Stop_Injected(intPtr);
	}

	public Color GetPixel(int x, int y)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPixel_Injected(intPtr, x, y, out var ret);
		return ret;
	}

	public Il2CppStructArray<Color> GetPixels()
	{
		return GetPixels(0, 0, width, height);
	}

	public Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPixels_Injected(intPtr, x, y, blockWidth, blockHeight);
	}

	public Il2CppStructArray<Color32> GetPixels32()
	{
		return GetPixels32(null);
	}

	public Il2CppStructArray<Color32> GetPixels32(Il2CppStructArray<Color32> colors)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPixels32_Injected(intPtr, colors);
	}

	public static void Pause_Injected(System.IntPtr _unity_self)
	{
		Pause_InjectedDelegateField(_unity_self);
	}

	public static void Stop_Injected(System.IntPtr _unity_self)
	{
		Stop_InjectedDelegateField(_unity_self);
	}

	public static bool get_isPlaying_Injected(System.IntPtr _unity_self)
	{
		return get_isPlaying_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_deviceName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_deviceName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_deviceName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_deviceName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_requestedFPS_Injected(System.IntPtr _unity_self)
	{
		return get_requestedFPS_InjectedDelegateField(_unity_self);
	}

	public static void set_requestedFPS_Injected(System.IntPtr _unity_self, float value)
	{
		set_requestedFPS_InjectedDelegateField(_unity_self, value);
	}

	public static int get_requestedWidth_Injected(System.IntPtr _unity_self)
	{
		return get_requestedWidth_InjectedDelegateField(_unity_self);
	}

	public static void set_requestedWidth_Injected(System.IntPtr _unity_self, int value)
	{
		set_requestedWidth_InjectedDelegateField(_unity_self, value);
	}

	public static int get_requestedHeight_Injected(System.IntPtr _unity_self)
	{
		return get_requestedHeight_InjectedDelegateField(_unity_self);
	}

	public static void set_requestedHeight_Injected(System.IntPtr _unity_self, int value)
	{
		set_requestedHeight_InjectedDelegateField(_unity_self, value);
	}

	public static int get_videoRotationAngle_Injected(System.IntPtr _unity_self)
	{
		return get_videoRotationAngle_InjectedDelegateField(_unity_self);
	}

	public static bool get_videoVerticallyMirrored_Injected(System.IntPtr _unity_self)
	{
		return get_videoVerticallyMirrored_InjectedDelegateField(_unity_self);
	}

	public static bool get_didUpdateThisFrame_Injected(System.IntPtr _unity_self)
	{
		return get_didUpdateThisFrame_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetPixel_Injected(System.IntPtr _unity_self, int x, int y, out Color ret)
	{
		GetPixel_InjectedDelegateField(_unity_self, x, y, (nint)Unsafe.AsPointer(ref ret));
	}

	public static Il2CppStructArray<Color> GetPixels_Injected(System.IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight)
	{
		System.IntPtr intPtr = GetPixels_InjectedDelegateField(_unity_self, x, y, blockWidth, blockHeight);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
	}

	public static Il2CppStructArray<Color32> GetPixels32_Injected(System.IntPtr _unity_self, Il2CppStructArray<Color32> colors)
	{
		System.IntPtr intPtr = GetPixels32_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr) : null;
	}

	public unsafe static void get_internalAutoFocusPoint_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_internalAutoFocusPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_internalAutoFocusPoint_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_internalAutoFocusPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_isDepth_Injected(System.IntPtr _unity_self)
	{
		return get_isDepth_InjectedDelegateField(_unity_self);
	}
}
