using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.NetworkInformation;

public class Win32IPInterfaceProperties2 : IPInterfaceProperties
{
	private static readonly System.IntPtr NativeFieldInfoPtr_addr;

	private static readonly System.IntPtr NativeFieldInfoPtr_mib4;

	private static readonly System.IntPtr NativeFieldInfoPtr_mib6;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Win32_IP_ADAPTER_ADDRESSES_Win32_MIB_IFROW_Win32_MIB_IFROW_0;

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

	static Win32IPInterfaceProperties2()
	{
		Il2CppClassPointerStore<Win32IPInterfaceProperties2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32IPInterfaceProperties2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32IPInterfaceProperties2>.NativeClassPtr);
		NativeFieldInfoPtr_addr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32IPInterfaceProperties2>.NativeClassPtr, "addr");
		NativeFieldInfoPtr_mib4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32IPInterfaceProperties2>.NativeClassPtr, "mib4");
		NativeFieldInfoPtr_mib6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32IPInterfaceProperties2>.NativeClassPtr, "mib6");
		NativeMethodInfoPtr__ctor_Public_Void_Win32_IP_ADAPTER_ADDRESSES_Win32_MIB_IFROW_Win32_MIB_IFROW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPInterfaceProperties2>.NativeClassPtr, 100667130);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897217, XrefRangeEnd = 897221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Win32IPInterfaceProperties2(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32IPInterfaceProperties2>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)addr));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mib4));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mib6));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Win32_IP_ADAPTER_ADDRESSES_Win32_MIB_IFROW_Win32_MIB_IFROW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Win32IPInterfaceProperties2(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
