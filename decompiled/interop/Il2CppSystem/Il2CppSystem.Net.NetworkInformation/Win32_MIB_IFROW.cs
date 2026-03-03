using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public sealed class Win32_MIB_IFROW : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_Index;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mtu;

	private static readonly System.IntPtr NativeFieldInfoPtr_Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_PhysAddrLen;

	private static readonly System.IntPtr NativeFieldInfoPtr_PhysAddr;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_OperStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_InOctets;

	private static readonly System.IntPtr NativeFieldInfoPtr_InUcastPkts;

	private static readonly System.IntPtr NativeFieldInfoPtr_InNUcastPkts;

	private static readonly System.IntPtr NativeFieldInfoPtr_InDiscards;

	private static readonly System.IntPtr NativeFieldInfoPtr_InErrors;

	private static readonly System.IntPtr NativeFieldInfoPtr_InUnknownProtos;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutOctets;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutUcastPkts;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutNUcastPkts;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutDiscards;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutErrors;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutQLen;

	private static readonly System.IntPtr NativeFieldInfoPtr_DescrLen;

	private static readonly System.IntPtr NativeFieldInfoPtr_Descr;

	public unsafe Il2CppStructArray<char> Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int Index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index)) = value;
		}
	}

	public unsafe NetworkInterfaceType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(NetworkInterfaceType*)num;
		}
		set
		{
			*(NetworkInterfaceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = value;
		}
	}

	public unsafe int Mtu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mtu);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mtu)) = value;
		}
	}

	public unsafe uint Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed)) = value;
		}
	}

	public unsafe int PhysAddrLen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysAddrLen);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysAddrLen)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> PhysAddr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysAddr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysAddr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint AdminStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdminStatus);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdminStatus)) = value;
		}
	}

	public unsafe uint OperStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OperStatus);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OperStatus)) = value;
		}
	}

	public unsafe uint LastChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastChange);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastChange)) = value;
		}
	}

	public unsafe int InOctets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InOctets);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InOctets)) = value;
		}
	}

	public unsafe int InUcastPkts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InUcastPkts);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InUcastPkts)) = value;
		}
	}

	public unsafe int InNUcastPkts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InNUcastPkts);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InNUcastPkts)) = value;
		}
	}

	public unsafe int InDiscards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InDiscards);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InDiscards)) = value;
		}
	}

	public unsafe int InErrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InErrors);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InErrors)) = value;
		}
	}

	public unsafe int InUnknownProtos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InUnknownProtos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InUnknownProtos)) = value;
		}
	}

	public unsafe int OutOctets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutOctets);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutOctets)) = value;
		}
	}

	public unsafe int OutUcastPkts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutUcastPkts);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutUcastPkts)) = value;
		}
	}

	public unsafe int OutNUcastPkts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutNUcastPkts);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutNUcastPkts)) = value;
		}
	}

	public unsafe int OutDiscards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutDiscards);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutDiscards)) = value;
		}
	}

	public unsafe int OutErrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutErrors);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutErrors)) = value;
		}
	}

	public unsafe int OutQLen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutQLen);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutQLen)) = value;
		}
	}

	public unsafe int DescrLen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescrLen);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescrLen)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> Descr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Descr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Descr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Win32_MIB_IFROW()
	{
		Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_MIB_IFROW");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "Index");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_Mtu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "Mtu");
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "Speed");
		NativeFieldInfoPtr_PhysAddrLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "PhysAddrLen");
		NativeFieldInfoPtr_PhysAddr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "PhysAddr");
		NativeFieldInfoPtr_AdminStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "AdminStatus");
		NativeFieldInfoPtr_OperStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "OperStatus");
		NativeFieldInfoPtr_LastChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "LastChange");
		NativeFieldInfoPtr_InOctets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "InOctets");
		NativeFieldInfoPtr_InUcastPkts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "InUcastPkts");
		NativeFieldInfoPtr_InNUcastPkts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "InNUcastPkts");
		NativeFieldInfoPtr_InDiscards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "InDiscards");
		NativeFieldInfoPtr_InErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "InErrors");
		NativeFieldInfoPtr_InUnknownProtos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "InUnknownProtos");
		NativeFieldInfoPtr_OutOctets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "OutOctets");
		NativeFieldInfoPtr_OutUcastPkts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "OutUcastPkts");
		NativeFieldInfoPtr_OutNUcastPkts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "OutNUcastPkts");
		NativeFieldInfoPtr_OutDiscards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "OutDiscards");
		NativeFieldInfoPtr_OutErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "OutErrors");
		NativeFieldInfoPtr_OutQLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "OutQLen");
		NativeFieldInfoPtr_DescrLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "DescrLen");
		NativeFieldInfoPtr_Descr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, "Descr");
	}

	public Win32_MIB_IFROW(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Win32_MIB_IFROW()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr))
	{
	}
}
