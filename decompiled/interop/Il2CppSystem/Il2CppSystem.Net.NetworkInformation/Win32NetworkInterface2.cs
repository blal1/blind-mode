using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public sealed class Win32NetworkInterface2 : NetworkInterface
{
	private static readonly System.IntPtr NativeFieldInfoPtr_addr;

	private static readonly System.IntPtr NativeFieldInfoPtr_mib4;

	private static readonly System.IntPtr NativeFieldInfoPtr_mib6;

	private static readonly System.IntPtr NativeFieldInfoPtr_ip4stats;

	private static readonly System.IntPtr NativeFieldInfoPtr_ip_if_props;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIfEntry_Private_Static_Int32_byref_Win32_MIB_IFROW_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Win32_IP_ADAPTER_ADDRESSES_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPhysicalAddress_Public_Virtual_PhysicalAddress_0;

	public unsafe Win32_IP_ADAPTER_ADDRESSES addr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addr);
			return new Win32_IP_ADAPTER_ADDRESSES(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addr), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Win32_MIB_IFROW mib4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mib4);
			return new Win32_MIB_IFROW(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mib4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Win32_MIB_IFROW mib6
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mib6);
			return new Win32_MIB_IFROW(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mib6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Win32IPv4InterfaceStatistics ip4stats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ip4stats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Win32IPv4InterfaceStatistics>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ip4stats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IPInterfaceProperties ip_if_props
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ip_if_props);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPInterfaceProperties>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ip_if_props)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Win32NetworkInterface2()
	{
		Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32NetworkInterface2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr);
		NativeFieldInfoPtr_addr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr, "addr");
		NativeFieldInfoPtr_mib4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr, "mib4");
		NativeFieldInfoPtr_mib6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr, "mib6");
		NativeFieldInfoPtr_ip4stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr, "ip4stats");
		NativeFieldInfoPtr_ip_if_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr, "ip_if_props");
		NativeMethodInfoPtr_GetIfEntry_Private_Static_Int32_byref_Win32_MIB_IFROW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr, 100667136);
		NativeMethodInfoPtr__ctor_Internal_Void_Win32_IP_ADAPTER_ADDRESSES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr, 100667137);
		NativeMethodInfoPtr_GetPhysicalAddress_Public_Virtual_PhysicalAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr, 100667138);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 897283, RefRangeEnd = 897285, XrefRangeStart = 897276, XrefRangeEnd = 897283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetIfEntry(ref Win32_MIB_IFROW row)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIfEntry_Private_Static_Int32_byref_Win32_MIB_IFROW_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 897303, RefRangeEnd = 897304, XrefRangeStart = 897285, XrefRangeEnd = 897303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Win32NetworkInterface2(Win32_IP_ADAPTER_ADDRESSES addr)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32NetworkInterface2>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)addr));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Win32_IP_ADAPTER_ADDRESSES_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897304, XrefRangeEnd = 897313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override PhysicalAddress GetPhysicalAddress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPhysicalAddress_Public_Virtual_PhysicalAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhysicalAddress>(intPtr2) : null;
	}

	public Win32NetworkInterface2(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
