using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSteamworks;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct CSteamID
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Nil;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutofDateGS;

	private static readonly System.IntPtr NativeFieldInfoPtr_LanModeGS;

	private static readonly System.IntPtr NativeFieldInfoPtr_NotInitYetGS;

	private static readonly System.IntPtr NativeFieldInfoPtr_NonSteamGS;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SteamID;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0;

	[FieldOffset(0)]
	public ulong m_SteamID;

	public unsafe static CSteamID Nil
	{
		get
		{
			Unsafe.SkipInit(out CSteamID result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Nil, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Nil, (void*)(&value));
		}
	}

	public unsafe static CSteamID OutofDateGS
	{
		get
		{
			Unsafe.SkipInit(out CSteamID result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OutofDateGS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OutofDateGS, (void*)(&value));
		}
	}

	public unsafe static CSteamID LanModeGS
	{
		get
		{
			Unsafe.SkipInit(out CSteamID result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LanModeGS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LanModeGS, (void*)(&value));
		}
	}

	public unsafe static CSteamID NotInitYetGS
	{
		get
		{
			Unsafe.SkipInit(out CSteamID result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NotInitYetGS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NotInitYetGS, (void*)(&value));
		}
	}

	public unsafe static CSteamID NonSteamGS
	{
		get
		{
			Unsafe.SkipInit(out CSteamID result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NonSteamGS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NonSteamGS, (void*)(&value));
		}
	}

	static CSteamID()
	{
		Il2CppClassPointerStore<CSteamID>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "CSteamID");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSteamID>.NativeClassPtr);
		NativeFieldInfoPtr_Nil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "Nil");
		NativeFieldInfoPtr_OutofDateGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "OutofDateGS");
		NativeFieldInfoPtr_LanModeGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "LanModeGS");
		NativeFieldInfoPtr_NotInitYetGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "NotInitYetGS");
		NativeFieldInfoPtr_NonSteamGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "NonSteamGS");
		NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "m_SteamID");
		NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100663463);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687873, XrefRangeEnd = 687877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&unAccountID);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unAccountInstance;
		*(EUniverse**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eUniverse;
		*(EAccountType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &eAccountType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CSteamID(ulong ulSteamID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ulSteamID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687883, RefRangeEnd = 687884, XrefRangeStart = 687880, XrefRangeEnd = 687883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&unAccountID);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unInstance;
		*(EUniverse**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eUniverse;
		*(EAccountType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &eAccountType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetAccountID(AccountID_t other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetAccountInstance(uint other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetEAccountType(EAccountType other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetEUniverse(EUniverse other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 687916, RefRangeEnd = 687918, XrefRangeStart = 687884, XrefRangeEnd = 687916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687918, XrefRangeEnd = 687923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687923, XrefRangeEnd = 687924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1225)]
	[CachedScanResults(RefRangeStart = 682879, RefRangeEnd = 684104, XrefRangeStart = 682879, XrefRangeEnd = 684104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(CSteamID x, CSteamID y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(CSteamID**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator CSteamID(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CSteamID*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 687924, RefRangeEnd = 687930, XrefRangeStart = 687924, XrefRangeEnd = 687924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(CSteamID other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687930, XrefRangeEnd = 687931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(CSteamID other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
