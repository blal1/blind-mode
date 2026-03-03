using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;
using UnityEngine;

namespace Il2CppZXing;

public class Color32Renderer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Foreground_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Background_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Foreground_Public_get_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Foreground_Public_set_Void_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Background_Public_get_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Background_Public_set_Void_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Final_New_Il2CppStructArray_1_Color32_BitMatrix_BarcodeFormat_String_EncodingOptions_0;

	public unsafe Color32 _Foreground_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Foreground_k__BackingField);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Foreground_k__BackingField)) = value;
		}
	}

	public unsafe Color32 _Background_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Background_k__BackingField);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Background_k__BackingField)) = value;
		}
	}

	public unsafe Color32 Foreground
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Foreground_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Foreground_Public_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Color32 Background
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Background_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164133, RefRangeEnd = 164138, XrefRangeStart = 164133, XrefRangeEnd = 164138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Background_Public_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Color32Renderer()
	{
		Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "Color32Renderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr);
		NativeFieldInfoPtr__Foreground_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr, "<Foreground>k__BackingField");
		NativeFieldInfoPtr__Background_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr, "<Background>k__BackingField");
		NativeMethodInfoPtr_get_Foreground_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_set_Foreground_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_get_Background_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_set_Background_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_Render_Public_Virtual_Final_New_Il2CppStructArray_1_Color32_BitMatrix_BarcodeFormat_String_EncodingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr, 100663546);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413171, XrefRangeEnd = 1413174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color32Renderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Color32Renderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413174, XrefRangeEnd = 1413181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppStructArray<Color32> Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		*(BarcodeFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Public_Virtual_Final_New_Il2CppStructArray_1_Color32_BitMatrix_BarcodeFormat_String_EncodingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
	}

	public Color32Renderer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
