using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine;

public static class ImageConversion : Il2CppSystem.Object
{
	private delegate bool GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate();

	private delegate void SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate(bool enable);

	private delegate System.IntPtr UnsafeEncodeNativeArrayToTGADelegate(System.IntPtr array, System.IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes);

	private delegate System.IntPtr UnsafeEncodeNativeArrayToPNGDelegate(System.IntPtr array, System.IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes);

	private delegate System.IntPtr UnsafeEncodeNativeArrayToJPGDelegate(System.IntPtr array, System.IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes, int quality);

	private delegate System.IntPtr UnsafeEncodeNativeArrayToEXRDelegate(System.IntPtr array, System.IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes, Texture2D.EXRFlags flags);

	private delegate System.IntPtr UnsafeEncodeNativeArrayToR2DDelegate(System.IntPtr array, System.IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes);

	private delegate void EncodeToTGA_InjectedDelegate(System.IntPtr tex, [Out] System.IntPtr ret);

	private delegate void EncodeToPNG_InjectedDelegate(System.IntPtr tex, [Out] System.IntPtr ret);

	private delegate void EncodeToEXR_InjectedDelegate(System.IntPtr tex, Texture2D.EXRFlags flags, [Out] System.IntPtr ret);

	private delegate void EncodeToR2DInternal_InjectedDelegate(System.IntPtr tex, [Out] System.IntPtr ret);

	private delegate void EncodeArrayToTGA_InjectedDelegate(System.IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes, [Out] System.IntPtr ret);

	private delegate void EncodeArrayToPNG_InjectedDelegate(System.IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes, [Out] System.IntPtr ret);

	private delegate void EncodeArrayToJPG_InjectedDelegate(System.IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes, int quality, [Out] System.IntPtr ret);

	private delegate void EncodeArrayToEXR_InjectedDelegate(System.IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes, Texture2D.EXRFlags flags, [Out] System.IntPtr ret);

	private delegate void EncodeArrayToR2DInternal_InjectedDelegate(System.IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeToJPG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeToJPG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_ReadOnlySpan_1_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeToJPG_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadImage_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_Boolean_0;

	private static readonly GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField;

	private static readonly SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField;

	private static readonly UnsafeEncodeNativeArrayToTGADelegate UnsafeEncodeNativeArrayToTGADelegateField;

	private static readonly UnsafeEncodeNativeArrayToPNGDelegate UnsafeEncodeNativeArrayToPNGDelegateField;

	private static readonly UnsafeEncodeNativeArrayToJPGDelegate UnsafeEncodeNativeArrayToJPGDelegateField;

	private static readonly UnsafeEncodeNativeArrayToEXRDelegate UnsafeEncodeNativeArrayToEXRDelegateField;

	private static readonly UnsafeEncodeNativeArrayToR2DDelegate UnsafeEncodeNativeArrayToR2DDelegateField;

	private static readonly EncodeToTGA_InjectedDelegate EncodeToTGA_InjectedDelegateField;

	private static readonly EncodeToPNG_InjectedDelegate EncodeToPNG_InjectedDelegateField;

	private static readonly EncodeToEXR_InjectedDelegate EncodeToEXR_InjectedDelegateField;

	private static readonly EncodeToR2DInternal_InjectedDelegate EncodeToR2DInternal_InjectedDelegateField;

	private static readonly EncodeArrayToTGA_InjectedDelegate EncodeArrayToTGA_InjectedDelegateField;

	private static readonly EncodeArrayToPNG_InjectedDelegate EncodeArrayToPNG_InjectedDelegateField;

	private static readonly EncodeArrayToJPG_InjectedDelegate EncodeArrayToJPG_InjectedDelegateField;

	private static readonly EncodeArrayToEXR_InjectedDelegate EncodeArrayToEXR_InjectedDelegateField;

	private static readonly EncodeArrayToR2DInternal_InjectedDelegate EncodeArrayToR2DInternal_InjectedDelegateField;

	public static bool EnableLegacyPngGammaRuntimeLoadBehavior
	{
		get
		{
			return GetEnableLegacyPngGammaRuntimeLoadBehavior();
		}
		set
		{
			SetEnableLegacyPngGammaRuntimeLoadBehavior(value);
		}
	}

	static ImageConversion()
	{
		Il2CppClassPointerStore<ImageConversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ImageConversionModule.dll", "UnityEngine", "ImageConversion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr);
		NativeMethodInfoPtr_EncodeToJPG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_EncodeToJPG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_ReadOnlySpan_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_EncodeToJPG_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_LoadImage_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageConversion>.NativeClassPtr, 100663302);
		GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField = IL2CPP.ResolveICall<GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate>("UnityEngine.ImageConversion::GetEnableLegacyPngGammaRuntimeLoadBehavior");
		SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField = IL2CPP.ResolveICall<SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate>("UnityEngine.ImageConversion::SetEnableLegacyPngGammaRuntimeLoadBehavior");
		UnsafeEncodeNativeArrayToTGADelegateField = IL2CPP.ResolveICall<UnsafeEncodeNativeArrayToTGADelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToTGA");
		UnsafeEncodeNativeArrayToPNGDelegateField = IL2CPP.ResolveICall<UnsafeEncodeNativeArrayToPNGDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToPNG");
		UnsafeEncodeNativeArrayToJPGDelegateField = IL2CPP.ResolveICall<UnsafeEncodeNativeArrayToJPGDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToJPG");
		UnsafeEncodeNativeArrayToEXRDelegateField = IL2CPP.ResolveICall<UnsafeEncodeNativeArrayToEXRDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToEXR");
		UnsafeEncodeNativeArrayToR2DDelegateField = IL2CPP.ResolveICall<UnsafeEncodeNativeArrayToR2DDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToR2D");
		EncodeToTGA_InjectedDelegateField = IL2CPP.ResolveICall<EncodeToTGA_InjectedDelegate>("UnityEngine.ImageConversion::EncodeToTGA_Injected");
		EncodeToPNG_InjectedDelegateField = IL2CPP.ResolveICall<EncodeToPNG_InjectedDelegate>("UnityEngine.ImageConversion::EncodeToPNG_Injected");
		EncodeToEXR_InjectedDelegateField = IL2CPP.ResolveICall<EncodeToEXR_InjectedDelegate>("UnityEngine.ImageConversion::EncodeToEXR_Injected");
		EncodeToR2DInternal_InjectedDelegateField = IL2CPP.ResolveICall<EncodeToR2DInternal_InjectedDelegate>("UnityEngine.ImageConversion::EncodeToR2DInternal_Injected");
		EncodeArrayToTGA_InjectedDelegateField = IL2CPP.ResolveICall<EncodeArrayToTGA_InjectedDelegate>("UnityEngine.ImageConversion::EncodeArrayToTGA_Injected");
		EncodeArrayToPNG_InjectedDelegateField = IL2CPP.ResolveICall<EncodeArrayToPNG_InjectedDelegate>("UnityEngine.ImageConversion::EncodeArrayToPNG_Injected");
		EncodeArrayToJPG_InjectedDelegateField = IL2CPP.ResolveICall<EncodeArrayToJPG_InjectedDelegate>("UnityEngine.ImageConversion::EncodeArrayToJPG_Injected");
		EncodeArrayToEXR_InjectedDelegateField = IL2CPP.ResolveICall<EncodeArrayToEXR_InjectedDelegate>("UnityEngine.ImageConversion::EncodeArrayToEXR_Injected");
		EncodeArrayToR2DInternal_InjectedDelegateField = IL2CPP.ResolveICall<EncodeArrayToR2DInternal_InjectedDelegate>("UnityEngine.ImageConversion::EncodeArrayToR2DInternal_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243961, RefRangeEnd = 1243962, XrefRangeStart = 1243952, XrefRangeEnd = 1243961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> EncodeToJPG(this Texture2D tex, int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeToJPG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243963, RefRangeEnd = 1243965, XrefRangeStart = 1243962, XrefRangeEnd = 1243963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> EncodeToJPG(this Texture2D tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeToJPG_Public_Static_Il2CppStructArray_1_Byte_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243965, XrefRangeEnd = 1243976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadImage(this Texture2D tex, Il2CppSystem.ReadOnlySpan<byte> data, bool markNonReadable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &markNonReadable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_ReadOnlySpan_1_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243989, RefRangeEnd = 1243990, XrefRangeStart = 1243976, XrefRangeEnd = 1243989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadImage(this Texture2D tex, Il2CppStructArray<byte> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadImage_Public_Static_Boolean_Texture2D_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243990, XrefRangeEnd = 1243992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EncodeToJPG_Injected(System.IntPtr tex, int quality, out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeToJPG_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243992, XrefRangeEnd = 1243994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadImage_Injected(System.IntPtr tex, ref ManagedSpanWrapper data, bool markNonReadable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref data);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &markNonReadable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadImage_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ImageConversion(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool GetEnableLegacyPngGammaRuntimeLoadBehavior()
	{
		return GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField();
	}

	public static void SetEnableLegacyPngGammaRuntimeLoadBehavior(bool enable)
	{
		SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField(enable);
	}

	public unsafe static Il2CppStructArray<byte> EncodeToTGA(Texture2D tex)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeToTGA_Injected(Object.MarshalledUnityObject.Marshal(tex), out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<byte> EncodeToPNG(Texture2D tex)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeToPNG_Injected(Object.MarshalledUnityObject.Marshal(tex), out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<byte> EncodeToEXR(Texture2D tex, Texture2D.EXRFlags flags)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeToEXR_Injected(Object.MarshalledUnityObject.Marshal(tex), flags, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array));
			result = array;
		}
		return result;
	}

	public static Il2CppStructArray<byte> EncodeToEXR(Texture2D tex)
	{
		return EncodeToEXR(tex, Texture2D.EXRFlags.None);
	}

	public unsafe static Il2CppStructArray<byte> EncodeToR2DInternal(Texture2D tex)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeToR2DInternal_Injected(Object.MarshalledUnityObject.Marshal(tex), out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array));
			result = array;
		}
		return result;
	}

	public static bool LoadImage(Texture2D tex, Il2CppSystem.ReadOnlySpan<byte> data)
	{
		return tex.LoadImage(data, markNonReadable: false);
	}

	public static bool LoadImage(Texture2D tex, Il2CppStructArray<byte> data, bool markNonReadable)
	{
		return tex.LoadImage(new Il2CppSystem.ReadOnlySpan<byte>((Il2CppArrayBase<byte>)(object)data), markNonReadable);
	}

	public unsafe static Il2CppStructArray<byte> EncodeArrayToTGA(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeArrayToTGA_Injected(array, format, width, height, rowBytes, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array2);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array2));
			result = array2;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<byte> EncodeArrayToPNG(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeArrayToPNG_Injected(array, format, width, height, rowBytes, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array2);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array2));
			result = array2;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<byte> EncodeArrayToJPG(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeArrayToJPG_Injected(array, format, width, height, rowBytes, quality, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array2);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array2));
			result = array2;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<byte> EncodeArrayToEXR(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeArrayToEXR_Injected(array, format, width, height, rowBytes, flags, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array2);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array2));
			result = array2;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<byte> EncodeArrayToR2DInternal(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<byte> result;
		try
		{
			EncodeArrayToR2DInternal_Injected(array, format, width, height, rowBytes, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<byte> array2);
			ret.Unmarshal(ref *(Il2CppArrayBase<byte>*)(&array2));
			result = array2;
		}
		return result;
	}

	public unsafe static NativeArray<byte> EncodeNativeArrayToTGA<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes) where T : struct
	{
		//IL_0009: Expected O, but got Ref
		int sizeInBytes = ((NativeArray<T>)(&input)).Length * UnsafeUtility.SizeOf<T>();
		void* dataPointer = UnsafeEncodeNativeArrayToTGA(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(input), ref sizeInBytes, format, width, height, rowBytes);
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(dataPointer, sizeInBytes, Allocator.Persistent);
	}

	public unsafe static NativeArray<byte> EncodeNativeArrayToPNG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes) where T : struct
	{
		//IL_0009: Expected O, but got Ref
		int sizeInBytes = ((NativeArray<T>)(&input)).Length * UnsafeUtility.SizeOf<T>();
		void* dataPointer = UnsafeEncodeNativeArrayToPNG(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(input), ref sizeInBytes, format, width, height, rowBytes);
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(dataPointer, sizeInBytes, Allocator.Persistent);
	}

	public unsafe static NativeArray<byte> EncodeNativeArrayToJPG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality) where T : struct
	{
		//IL_0009: Expected O, but got Ref
		int sizeInBytes = ((NativeArray<T>)(&input)).Length * UnsafeUtility.SizeOf<T>();
		void* dataPointer = UnsafeEncodeNativeArrayToJPG(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(input), ref sizeInBytes, format, width, height, rowBytes, quality);
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(dataPointer, sizeInBytes, Allocator.Persistent);
	}

	public unsafe static NativeArray<byte> EncodeNativeArrayToEXR<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags) where T : struct
	{
		//IL_0009: Expected O, but got Ref
		int sizeInBytes = ((NativeArray<T>)(&input)).Length * UnsafeUtility.SizeOf<T>();
		void* dataPointer = UnsafeEncodeNativeArrayToEXR(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(input), ref sizeInBytes, format, width, height, rowBytes, flags);
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(dataPointer, sizeInBytes, Allocator.Persistent);
	}

	public unsafe static NativeArray<byte> EncodeNativeArrayToR2DInternal<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes) where T : struct
	{
		//IL_0009: Expected O, but got Ref
		int sizeInBytes = ((NativeArray<T>)(&input)).Length * UnsafeUtility.SizeOf<T>();
		void* dataPointer = UnsafeEncodeNativeArrayToR2D(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(input), ref sizeInBytes, format, width, height, rowBytes);
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(dataPointer, sizeInBytes, Allocator.Persistent);
	}

	public unsafe static void* UnsafeEncodeNativeArrayToTGA(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
	{
		return (void*)UnsafeEncodeNativeArrayToTGADelegateField((nint)array, (nint)Unsafe.AsPointer(ref sizeInBytes), format, width, height, rowBytes);
	}

	public unsafe static void* UnsafeEncodeNativeArrayToPNG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
	{
		return (void*)UnsafeEncodeNativeArrayToPNGDelegateField((nint)array, (nint)Unsafe.AsPointer(ref sizeInBytes), format, width, height, rowBytes);
	}

	public unsafe static void* UnsafeEncodeNativeArrayToJPG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality)
	{
		return (void*)UnsafeEncodeNativeArrayToJPGDelegateField((nint)array, (nint)Unsafe.AsPointer(ref sizeInBytes), format, width, height, rowBytes, quality);
	}

	public unsafe static void* UnsafeEncodeNativeArrayToEXR(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags)
	{
		return (void*)UnsafeEncodeNativeArrayToEXRDelegateField((nint)array, (nint)Unsafe.AsPointer(ref sizeInBytes), format, width, height, rowBytes, flags);
	}

	public unsafe static void* UnsafeEncodeNativeArrayToR2D(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
	{
		return (void*)UnsafeEncodeNativeArrayToR2DDelegateField((nint)array, (nint)Unsafe.AsPointer(ref sizeInBytes), format, width, height, rowBytes);
	}

	public unsafe static void EncodeToTGA_Injected(System.IntPtr tex, out BlittableArrayWrapper ret)
	{
		EncodeToTGA_InjectedDelegateField(tex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void EncodeToPNG_Injected(System.IntPtr tex, out BlittableArrayWrapper ret)
	{
		EncodeToPNG_InjectedDelegateField(tex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void EncodeToEXR_Injected(System.IntPtr tex, Texture2D.EXRFlags flags, out BlittableArrayWrapper ret)
	{
		EncodeToEXR_InjectedDelegateField(tex, flags, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void EncodeToR2DInternal_Injected(System.IntPtr tex, out BlittableArrayWrapper ret)
	{
		EncodeToR2DInternal_InjectedDelegateField(tex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void EncodeArrayToTGA_Injected(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, uint rowBytes, out BlittableArrayWrapper ret)
	{
		EncodeArrayToTGA_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array), format, width, height, rowBytes, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void EncodeArrayToPNG_Injected(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, uint rowBytes, out BlittableArrayWrapper ret)
	{
		EncodeArrayToPNG_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array), format, width, height, rowBytes, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void EncodeArrayToJPG_Injected(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, uint rowBytes, int quality, out BlittableArrayWrapper ret)
	{
		EncodeArrayToJPG_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array), format, width, height, rowBytes, quality, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void EncodeArrayToEXR_Injected(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, uint rowBytes, Texture2D.EXRFlags flags, out BlittableArrayWrapper ret)
	{
		EncodeArrayToEXR_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array), format, width, height, rowBytes, flags, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void EncodeArrayToR2DInternal_Injected(Il2CppSystem.Array array, GraphicsFormat format, uint width, uint height, uint rowBytes, out BlittableArrayWrapper ret)
	{
		EncodeArrayToR2DInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array), format, width, height, rowBytes, (nint)Unsafe.AsPointer(ref ret));
	}
}
