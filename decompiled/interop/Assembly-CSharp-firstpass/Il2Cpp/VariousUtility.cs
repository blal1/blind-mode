using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public static class VariousUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_UNIX_EPOCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_convertHankakuKanaTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_convertHankakuKanaDakuonTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_convertHankakuKanaHanDakuonTable;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTimeFromUnixTime_Public_Static_DateTime_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnixTimeFromDateTime_Public_Static_UInt64_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertHankakuToZenkaku_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LOSHORT_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HISHORT_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LOBYTE_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HIBYTE_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumOfBits_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToRgba_Public_Static_Int32_Color_0;

	public unsafe static Il2CppSystem.DateTime UNIX_EPOCH
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.DateTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UNIX_EPOCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UNIX_EPOCH, (void*)(&value));
		}
	}

	public unsafe static Dictionary<char, string> convertHankakuKanaTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_convertHankakuKanaTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<char, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_convertHankakuKanaTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<char, string> convertHankakuKanaDakuonTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_convertHankakuKanaDakuonTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<char, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_convertHankakuKanaDakuonTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<char, string> convertHankakuKanaHanDakuonTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_convertHankakuKanaHanDakuonTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<char, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_convertHankakuKanaHanDakuonTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static VariousUtility()
	{
		Il2CppClassPointerStore<VariousUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VariousUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr);
		NativeFieldInfoPtr_UNIX_EPOCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, "UNIX_EPOCH");
		NativeFieldInfoPtr_convertHankakuKanaTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, "convertHankakuKanaTable");
		NativeFieldInfoPtr_convertHankakuKanaDakuonTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, "convertHankakuKanaDakuonTable");
		NativeFieldInfoPtr_convertHankakuKanaHanDakuonTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, "convertHankakuKanaHanDakuonTable");
		NativeMethodInfoPtr_GetLocalTimeFromUnixTime_Public_Static_DateTime_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_GetUnixTimeFromDateTime_Public_Static_UInt64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_ConvertHankakuToZenkaku_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_LOSHORT_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_HISHORT_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_LOBYTE_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_HIBYTE_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_NumOfBits_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_ToRgba_Public_Static_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousUtility>.NativeClassPtr, 100663492);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24365, XrefRangeEnd = 24372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime GetLocalTimeFromUnixTime(ulong unixTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unixTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalTimeFromUnixTime_Public_Static_DateTime_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24372, XrefRangeEnd = 24385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong GetUnixTimeFromDateTime(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnixTimeFromDateTime_Public_Static_UInt64_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24385, XrefRangeEnd = 24408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ConvertHankakuToZenkaku(string input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertHankakuToZenkaku_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LOSHORT(this int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LOSHORT_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 24423, RefRangeEnd = 24426, XrefRangeStart = 24423, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int HISHORT(this int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HISHORT_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LOBYTE(this int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LOBYTE_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 24437, RefRangeEnd = 24447, XrefRangeStart = 24437, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int HIBYTE(this int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HIBYTE_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int NumOfBits(int bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumOfBits_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24447, RefRangeEnd = 24448, XrefRangeStart = 24447, XrefRangeEnd = 24447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToRgba(this Color col)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&col);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToRgba_Public_Static_Int32_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public VariousUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
