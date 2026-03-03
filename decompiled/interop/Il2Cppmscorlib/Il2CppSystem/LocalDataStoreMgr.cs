using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem;

public sealed class LocalDataStoreMgr : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_SlotInfoTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstAvailableSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ManagedLocalDataStores;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KeyToSlotMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CookieGenerator;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<bool> m_SlotInfoTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SlotInfoTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SlotInfoTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_FirstAvailableSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstAvailableSlot);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstAvailableSlot)) = value;
		}
	}

	public unsafe List<LocalDataStore> m_ManagedLocalDataStores
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ManagedLocalDataStores);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LocalDataStore>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ManagedLocalDataStores)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KeyToSlotMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, LocalDataStoreSlot>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KeyToSlotMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe long m_CookieGenerator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CookieGenerator);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CookieGenerator)) = value;
		}
	}

	static LocalDataStoreMgr()
	{
		Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreMgr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr);
		NativeFieldInfoPtr_m_SlotInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_SlotInfoTable");
		NativeFieldInfoPtr_m_FirstAvailableSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_FirstAvailableSlot");
		NativeFieldInfoPtr_m_ManagedLocalDataStores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_ManagedLocalDataStores");
		NativeFieldInfoPtr_m_KeyToSlotMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_KeyToSlotMap");
		NativeFieldInfoPtr_m_CookieGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_CookieGenerator");
		NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666597);
		NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666598);
		NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666599);
		NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666600);
		NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666601);
		NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666602);
		NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666603);
		NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666604);
		NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666605);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666606);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753516, RefRangeEnd = 753517, XrefRangeStart = 753492, XrefRangeEnd = 753516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalDataStoreHolder CreateLocalDataStore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 753525, RefRangeEnd = 753527, XrefRangeStart = 753517, XrefRangeEnd = 753525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteLocalDataStore(LocalDataStore store)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)store);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 753544, RefRangeEnd = 753546, XrefRangeStart = 753527, XrefRangeEnd = 753544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalDataStoreSlot AllocateDataSlot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 753555, RefRangeEnd = 753557, XrefRangeStart = 753546, XrefRangeEnd = 753555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalDataStoreSlot AllocateNamedDataSlot(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753568, RefRangeEnd = 753569, XrefRangeStart = 753557, XrefRangeEnd = 753568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalDataStoreSlot GetNamedDataSlot(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753577, RefRangeEnd = 753578, XrefRangeStart = 753569, XrefRangeEnd = 753577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeNamedDataSlot(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753589, RefRangeEnd = 753590, XrefRangeStart = 753578, XrefRangeEnd = 753589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeDataSlot(int slot, long cookie)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&slot);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cookie;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ValidateSlot(LocalDataStoreSlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 54455, RefRangeEnd = 54510, XrefRangeStart = 54455, XrefRangeEnd = 54510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSlotTableLength()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753609, RefRangeEnd = 753610, XrefRangeStart = 753590, XrefRangeEnd = 753609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalDataStoreMgr()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LocalDataStoreMgr(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
