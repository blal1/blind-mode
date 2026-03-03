using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppZXing.Aztec;

public sealed class AztecResultMetadata : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Compact_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Datablocks_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Layers_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Compact_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Datablocks_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Layers_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0;

	public unsafe bool _Compact_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Compact_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Compact_k__BackingField)) = value;
		}
	}

	public unsafe int _Datablocks_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Datablocks_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Datablocks_k__BackingField)) = value;
		}
	}

	public unsafe int _Layers_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Layers_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Layers_k__BackingField)) = value;
		}
	}

	public unsafe bool Compact
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86557, RefRangeEnd = 86558, XrefRangeStart = 86557, XrefRangeEnd = 86558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Compact_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int Datablocks
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164133, RefRangeEnd = 164138, XrefRangeStart = 164133, XrefRangeEnd = 164138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Datablocks_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int Layers
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Layers_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static AztecResultMetadata()
	{
		Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Aztec", "AztecResultMetadata");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr);
		NativeFieldInfoPtr__Compact_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr, "<Compact>k__BackingField");
		NativeFieldInfoPtr__Datablocks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr, "<Datablocks>k__BackingField");
		NativeFieldInfoPtr__Layers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr, "<Layers>k__BackingField");
		NativeMethodInfoPtr_set_Compact_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr, 100664839);
		NativeMethodInfoPtr_set_Datablocks_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr, 100664840);
		NativeMethodInfoPtr_set_Layers_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr, 100664841);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr, 100664842);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429976, XrefRangeEnd = 1429977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AztecResultMetadata(bool compact, int datablocks, int layers)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AztecResultMetadata>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&compact);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &datablocks;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layers;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AztecResultMetadata(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
