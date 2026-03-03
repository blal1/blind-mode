using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.NetworkInformation;

public sealed class Win32_FIXED_INFO : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HostName;

	private static readonly System.IntPtr NativeFieldInfoPtr_DomainName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentDnsServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_DnsServerList;

	private static readonly System.IntPtr NativeFieldInfoPtr_NodeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScopeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableRouting;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableProxy;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableDns;

	public unsafe string HostName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HostName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HostName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string DomainName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DomainName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DomainName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe System.IntPtr CurrentDnsServer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentDnsServer);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentDnsServer)) = value;
		}
	}

	public unsafe Win32_IP_ADDR_STRING DnsServerList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DnsServerList);
			return new Win32_IP_ADDR_STRING(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DnsServerList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NetBiosNodeType NodeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeType);
			return *(NetBiosNodeType*)num;
		}
		set
		{
			*(NetBiosNodeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeType)) = value;
		}
	}

	public unsafe string ScopeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScopeId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScopeId)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe uint EnableRouting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableRouting);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableRouting)) = value;
		}
	}

	public unsafe uint EnableProxy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableProxy);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableProxy)) = value;
		}
	}

	public unsafe uint EnableDns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableDns);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableDns)) = value;
		}
	}

	static Win32_FIXED_INFO()
	{
		Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_FIXED_INFO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr);
		NativeFieldInfoPtr_HostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "HostName");
		NativeFieldInfoPtr_DomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "DomainName");
		NativeFieldInfoPtr_CurrentDnsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "CurrentDnsServer");
		NativeFieldInfoPtr_DnsServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "DnsServerList");
		NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "NodeType");
		NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "ScopeId");
		NativeFieldInfoPtr_EnableRouting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableRouting");
		NativeFieldInfoPtr_EnableProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableProxy");
		NativeFieldInfoPtr_EnableDns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableDns");
	}

	public Win32_FIXED_INFO(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Win32_FIXED_INFO()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr))
	{
	}
}
