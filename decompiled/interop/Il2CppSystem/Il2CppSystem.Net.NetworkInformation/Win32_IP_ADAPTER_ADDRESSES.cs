using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
public sealed class Win32_IP_ADAPTER_ADDRESSES : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Alignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_Next;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdapterName;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstUnicastAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstAnycastAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstMulticastAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstDnsServerAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_DnsSuffix;

	private static readonly System.IntPtr NativeFieldInfoPtr_Description;

	private static readonly System.IntPtr NativeFieldInfoPtr_FriendlyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalAddressLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mtu;

	private static readonly System.IntPtr NativeFieldInfoPtr_IfType;

	private static readonly System.IntPtr NativeFieldInfoPtr_OperStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ipv6IfIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZoneIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_TransmitLinkSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReceiveLinkSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstWinsServerAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstGatewayAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ipv4Metric;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ipv6Metric;

	private static readonly System.IntPtr NativeFieldInfoPtr_Luid;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dhcpv4Server;

	private static readonly System.IntPtr NativeFieldInfoPtr_CompartmentId;

	private static readonly System.IntPtr NativeFieldInfoPtr_NetworkGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_TunnelType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dhcpv6Server;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dhcpv6ClientDuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dhcpv6ClientDuidLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dhcpv6Iaid;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstDnsSuffix;

	public unsafe AlignmentUnion Alignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Alignment);
			return *(AlignmentUnion*)num;
		}
		set
		{
			*(AlignmentUnion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Alignment)) = value;
		}
	}

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

	public unsafe string AdapterName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdapterName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdapterName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe System.IntPtr FirstUnicastAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstUnicastAddress);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstUnicastAddress)) = value;
		}
	}

	public unsafe System.IntPtr FirstAnycastAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstAnycastAddress);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstAnycastAddress)) = value;
		}
	}

	public unsafe System.IntPtr FirstMulticastAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstMulticastAddress);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstMulticastAddress)) = value;
		}
	}

	public unsafe System.IntPtr FirstDnsServerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstDnsServerAddress);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstDnsServerAddress)) = value;
		}
	}

	public unsafe string DnsSuffix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DnsSuffix);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DnsSuffix)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string Description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string FriendlyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FriendlyName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FriendlyName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppStructArray<byte> PhysicalAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysicalAddress);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysicalAddress)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint PhysicalAddressLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysicalAddressLength);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysicalAddressLength)) = value;
		}
	}

	public unsafe uint Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flags);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flags)) = value;
		}
	}

	public unsafe uint Mtu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mtu);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mtu)) = value;
		}
	}

	public unsafe NetworkInterfaceType IfType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IfType);
			return *(NetworkInterfaceType*)num;
		}
		set
		{
			*(NetworkInterfaceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IfType)) = value;
		}
	}

	public unsafe OperationalStatus OperStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OperStatus);
			return *(OperationalStatus*)num;
		}
		set
		{
			*(OperationalStatus*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OperStatus)) = value;
		}
	}

	public unsafe int Ipv6IfIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ipv6IfIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ipv6IfIndex)) = value;
		}
	}

	public unsafe Il2CppStructArray<uint> ZoneIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ZoneIndices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ZoneIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe System.IntPtr FirstPrefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstPrefix);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstPrefix)) = value;
		}
	}

	public unsafe ulong TransmitLinkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransmitLinkSpeed);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransmitLinkSpeed)) = value;
		}
	}

	public unsafe ulong ReceiveLinkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReceiveLinkSpeed);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReceiveLinkSpeed)) = value;
		}
	}

	public unsafe System.IntPtr FirstWinsServerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstWinsServerAddress);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstWinsServerAddress)) = value;
		}
	}

	public unsafe System.IntPtr FirstGatewayAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstGatewayAddress);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstGatewayAddress)) = value;
		}
	}

	public unsafe uint Ipv4Metric
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ipv4Metric);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ipv4Metric)) = value;
		}
	}

	public unsafe uint Ipv6Metric
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ipv6Metric);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ipv6Metric)) = value;
		}
	}

	public unsafe ulong Luid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Luid);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Luid)) = value;
		}
	}

	public unsafe Win32_SOCKET_ADDRESS Dhcpv4Server
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv4Server);
			return *(Win32_SOCKET_ADDRESS*)num;
		}
		set
		{
			*(Win32_SOCKET_ADDRESS*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv4Server)) = value;
		}
	}

	public unsafe uint CompartmentId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompartmentId);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompartmentId)) = value;
		}
	}

	public unsafe ulong NetworkGuid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NetworkGuid);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NetworkGuid)) = value;
		}
	}

	public unsafe int ConnectionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionType)) = value;
		}
	}

	public unsafe int TunnelType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TunnelType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TunnelType)) = value;
		}
	}

	public unsafe Win32_SOCKET_ADDRESS Dhcpv6Server
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv6Server);
			return *(Win32_SOCKET_ADDRESS*)num;
		}
		set
		{
			*(Win32_SOCKET_ADDRESS*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv6Server)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> Dhcpv6ClientDuid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv6ClientDuid);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv6ClientDuid)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ulong Dhcpv6ClientDuidLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv6ClientDuidLength);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv6ClientDuidLength)) = value;
		}
	}

	public unsafe ulong Dhcpv6Iaid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv6Iaid);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dhcpv6Iaid)) = value;
		}
	}

	public unsafe System.IntPtr FirstDnsSuffix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstDnsSuffix);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstDnsSuffix)) = value;
		}
	}

	static Win32_IP_ADAPTER_ADDRESSES()
	{
		Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_IP_ADAPTER_ADDRESSES");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr);
		NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Alignment");
		NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Next");
		NativeFieldInfoPtr_AdapterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "AdapterName");
		NativeFieldInfoPtr_FirstUnicastAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FirstUnicastAddress");
		NativeFieldInfoPtr_FirstAnycastAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FirstAnycastAddress");
		NativeFieldInfoPtr_FirstMulticastAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FirstMulticastAddress");
		NativeFieldInfoPtr_FirstDnsServerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FirstDnsServerAddress");
		NativeFieldInfoPtr_DnsSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "DnsSuffix");
		NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Description");
		NativeFieldInfoPtr_FriendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FriendlyName");
		NativeFieldInfoPtr_PhysicalAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "PhysicalAddress");
		NativeFieldInfoPtr_PhysicalAddressLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "PhysicalAddressLength");
		NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Flags");
		NativeFieldInfoPtr_Mtu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Mtu");
		NativeFieldInfoPtr_IfType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "IfType");
		NativeFieldInfoPtr_OperStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "OperStatus");
		NativeFieldInfoPtr_Ipv6IfIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Ipv6IfIndex");
		NativeFieldInfoPtr_ZoneIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "ZoneIndices");
		NativeFieldInfoPtr_FirstPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FirstPrefix");
		NativeFieldInfoPtr_TransmitLinkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "TransmitLinkSpeed");
		NativeFieldInfoPtr_ReceiveLinkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "ReceiveLinkSpeed");
		NativeFieldInfoPtr_FirstWinsServerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FirstWinsServerAddress");
		NativeFieldInfoPtr_FirstGatewayAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FirstGatewayAddress");
		NativeFieldInfoPtr_Ipv4Metric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Ipv4Metric");
		NativeFieldInfoPtr_Ipv6Metric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Ipv6Metric");
		NativeFieldInfoPtr_Luid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Luid");
		NativeFieldInfoPtr_Dhcpv4Server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Dhcpv4Server");
		NativeFieldInfoPtr_CompartmentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "CompartmentId");
		NativeFieldInfoPtr_NetworkGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "NetworkGuid");
		NativeFieldInfoPtr_ConnectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "ConnectionType");
		NativeFieldInfoPtr_TunnelType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "TunnelType");
		NativeFieldInfoPtr_Dhcpv6Server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Dhcpv6Server");
		NativeFieldInfoPtr_Dhcpv6ClientDuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Dhcpv6ClientDuid");
		NativeFieldInfoPtr_Dhcpv6ClientDuidLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Dhcpv6ClientDuidLength");
		NativeFieldInfoPtr_Dhcpv6Iaid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "Dhcpv6Iaid");
		NativeFieldInfoPtr_FirstDnsSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr, "FirstDnsSuffix");
	}

	public Win32_IP_ADAPTER_ADDRESSES(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Win32_IP_ADAPTER_ADDRESSES()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_IP_ADAPTER_ADDRESSES>.NativeClassPtr))
	{
	}
}
