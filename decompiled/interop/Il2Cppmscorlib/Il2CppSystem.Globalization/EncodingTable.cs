using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization;

public static class EncodingTable : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_encodingDataPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_codePageDataPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastEncodingItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_hashByName;

	private static readonly System.IntPtr NativeFieldInfoPtr_hashByCodePage;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0;

	public unsafe static Il2CppReferenceArray<InternalEncodingDataItem> encodingDataPtr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_encodingDataPtr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternalEncodingDataItem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_encodingDataPtr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<InternalCodePageDataItem> codePageDataPtr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_codePageDataPtr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternalCodePageDataItem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_codePageDataPtr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int lastEncodingItem
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastEncodingItem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastEncodingItem, (void*)(&value));
		}
	}

	public unsafe static Dictionary<string, int> hashByName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hashByName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hashByName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, CodePageDataItem> hashByCodePage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hashByCodePage, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CodePageDataItem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hashByCodePage, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static EncodingTable()
	{
		Il2CppClassPointerStore<EncodingTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "EncodingTable");
		NativeFieldInfoPtr_encodingDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "encodingDataPtr");
		NativeFieldInfoPtr_codePageDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "codePageDataPtr");
		NativeFieldInfoPtr_lastEncodingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "lastEncodingItem");
		NativeFieldInfoPtr_hashByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "hashByName");
		NativeFieldInfoPtr_hashByCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, "hashByCodePage");
		NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673199);
		NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673200);
		NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673201);
		NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673203);
		NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673204);
		NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingTable>.NativeClassPtr, 100673205);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820164, XrefRangeEnd = 820168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNumEncodingItems()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumEncodingItems_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820168, XrefRangeEnd = 820169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InternalEncodingDataItem ENC(string name, ushort cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cp;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ENC_Private_Static_InternalEncodingDataItem_String_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InternalEncodingDataItem(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820169, XrefRangeEnd = 820170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&cp);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fcp;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(names);
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapCodePageDataItem_Private_Static_InternalCodePageDataItem_UInt16_UInt16_String_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InternalCodePageDataItem(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820186, RefRangeEnd = 820187, XrefRangeStart = 820170, XrefRangeEnd = 820186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int internalGetCodePageFromName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetCodePageFromName_Private_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820213, RefRangeEnd = 820214, XrefRangeStart = 820187, XrefRangeEnd = 820213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCodePageFromName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCodePageFromName_Internal_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 820247, RefRangeEnd = 820250, XrefRangeStart = 820214, XrefRangeEnd = 820247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CodePageDataItem GetCodePageDataItem(int codepage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codepage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCodePageDataItem_Internal_Static_CodePageDataItem_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePageDataItem>(intPtr2) : null;
	}

	public EncodingTable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
