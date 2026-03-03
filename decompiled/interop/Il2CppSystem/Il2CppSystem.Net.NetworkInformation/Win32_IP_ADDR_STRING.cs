using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.NetworkInformation;

public sealed class Win32_IP_ADDR_STRING : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Next;

	private static readonly System.IntPtr NativeFieldInfoPtr_IpAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_IpMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_Context;

	public unsafe System.IntPtr Next
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next)) = value;
		}
	}

	public unsafe string IpAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IpAddress);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IpAddress)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string IpMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IpMask);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IpMask)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe uint Context
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Context);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Context)) = value;
		}
	}

	static Win32_IP_ADDR_STRING()
	{
		Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_IP_ADDR_STRING");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr);
		NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "Next");
		NativeFieldInfoPtr_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "IpAddress");
		NativeFieldInfoPtr_IpMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "IpMask");
		NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "Context");
	}

	public Win32_IP_ADDR_STRING(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Win32_IP_ADDR_STRING()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr))
	{
	}
}
