using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema;

public sealed class RangePositionInfo : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_curpos;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangeCounters;

	public unsafe BitSet curpos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curpos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitSet>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curpos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Decimal> rangeCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeCounters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeCounters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RangePositionInfo()
	{
		Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RangePositionInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr);
		NativeFieldInfoPtr_curpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr, "curpos");
		NativeFieldInfoPtr_rangeCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr, "rangeCounters");
	}

	public RangePositionInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RangePositionInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr))
	{
	}
}
