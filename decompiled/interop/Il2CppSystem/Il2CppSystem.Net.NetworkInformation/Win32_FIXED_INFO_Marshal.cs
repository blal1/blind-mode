using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.NetworkInformation;

public sealed class Win32_FIXED_INFO_Marshal : ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("System.Net.NetworkInformation.Win32_FIXED_INFO_Marshal+<HostName>e__FixedBuffer")]
	public struct _HostName_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _HostName_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_HostName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "<HostName>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_HostName_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_HostName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_HostName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("System.Net.NetworkInformation.Win32_FIXED_INFO_Marshal+<DomainName>e__FixedBuffer")]
	public struct _DomainName_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _DomainName_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_DomainName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "<DomainName>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_DomainName_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_DomainName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_DomainName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("System.Net.NetworkInformation.Win32_FIXED_INFO_Marshal+<ScopeId>e__FixedBuffer")]
	public struct _ScopeId_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _ScopeId_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_ScopeId_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "<ScopeId>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ScopeId_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ScopeId_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_ScopeId_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_HostName;

	private static readonly System.IntPtr NativeFieldInfoPtr_DomainName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentDnsServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_DnsServerList;

	private static readonly System.IntPtr NativeFieldInfoPtr_NodeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScopeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableRouting;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableProxy;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableDns;

	public unsafe _HostName_e__FixedBuffer HostName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HostName);
			return *(_HostName_e__FixedBuffer*)num;
		}
		set
		{
			*(_HostName_e__FixedBuffer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HostName)) = value;
		}
	}

	public unsafe _DomainName_e__FixedBuffer DomainName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DomainName);
			return *(_DomainName_e__FixedBuffer*)num;
		}
		set
		{
			*(_DomainName_e__FixedBuffer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DomainName)) = value;
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

	public unsafe _ScopeId_e__FixedBuffer ScopeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScopeId);
			return *(_ScopeId_e__FixedBuffer*)num;
		}
		set
		{
			*(_ScopeId_e__FixedBuffer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScopeId)) = value;
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

	static Win32_FIXED_INFO_Marshal()
	{
		Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_FIXED_INFO_Marshal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr);
		NativeFieldInfoPtr_HostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "HostName");
		NativeFieldInfoPtr_DomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "DomainName");
		NativeFieldInfoPtr_CurrentDnsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "CurrentDnsServer");
		NativeFieldInfoPtr_DnsServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "DnsServerList");
		NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "NodeType");
		NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "ScopeId");
		NativeFieldInfoPtr_EnableRouting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "EnableRouting");
		NativeFieldInfoPtr_EnableProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "EnableProxy");
		NativeFieldInfoPtr_EnableDns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "EnableDns");
	}

	public Win32_FIXED_INFO_Marshal(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Win32_FIXED_INFO_Marshal()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr))
	{
	}
}
