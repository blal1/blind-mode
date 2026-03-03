using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Rendering;
using UnityEngine;

namespace Il2CppZXing;

public class BarcodeWriter : BarcodeWriter<Il2CppStructArray<Color32>>
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static BarcodeWriter()
	{
		Il2CppClassPointerStore<BarcodeWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "BarcodeWriter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarcodeWriter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeWriter>.NativeClassPtr, 100663401);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1412521, RefRangeEnd = 1412523, XrefRangeStart = 1412510, XrefRangeEnd = 1412521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarcodeWriter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarcodeWriter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BarcodeWriter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
public class BarcodeWriter<TOutput> : BarcodeWriterGeneric
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Renderer_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Renderer_Public_get_IBarcodeRenderer_1_TOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Renderer_Public_set_Void_IBarcodeRenderer_1_TOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_TOutput_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IBarcodeRenderer<TOutput> _Renderer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Renderer_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBarcodeRenderer<TOutput>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Renderer_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IBarcodeRenderer<TOutput> Renderer
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Renderer_Public_get_IBarcodeRenderer_1_TOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBarcodeRenderer<TOutput>>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Renderer_Public_set_Void_IBarcodeRenderer_1_TOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static BarcodeWriter()
	{
		Il2CppClassPointerStore<BarcodeWriter<TOutput>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "BarcodeWriter`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarcodeWriter<TOutput>>.NativeClassPtr);
		NativeFieldInfoPtr__Renderer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeWriter<TOutput>>.NativeClassPtr, "<Renderer>k__BackingField");
		NativeMethodInfoPtr_get_Renderer_Public_get_IBarcodeRenderer_1_TOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeWriter<TOutput>>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_set_Renderer_Public_set_Void_IBarcodeRenderer_1_TOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeWriter<TOutput>>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_Write_Public_Virtual_Final_New_TOutput_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeWriter<TOutput>>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeWriter<TOutput>>.NativeClassPtr, 100663405);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1412527, RefRangeEnd = 1412529, XrefRangeStart = 1412523, XrefRangeEnd = 1412527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual TOutput Write(string contents)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Public_Virtual_Final_New_TOutput_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TOutput>(intPtr2, false, true);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarcodeWriter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarcodeWriter<TOutput>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BarcodeWriter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
