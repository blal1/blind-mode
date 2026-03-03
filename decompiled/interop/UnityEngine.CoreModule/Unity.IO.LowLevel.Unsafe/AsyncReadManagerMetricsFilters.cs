using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe;

public class AsyncReadManagerMetricsFilters : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TypeIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_States;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReadTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_PriorityLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_Subsystems;

	public unsafe Il2CppStructArray<ulong> TypeIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TypeIDs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TypeIDs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<ProcessingState> States
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_States);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ProcessingState>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_States)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<FileReadType> ReadTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReadTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<FileReadType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReadTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Priority> PriorityLevels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PriorityLevels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Priority>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PriorityLevels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<AssetLoadingSubsystem> Subsystems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Subsystems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<AssetLoadingSubsystem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Subsystems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AsyncReadManagerMetricsFilters()
	{
		Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerMetricsFilters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr);
		NativeFieldInfoPtr_TypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "TypeIDs");
		NativeFieldInfoPtr_States = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "States");
		NativeFieldInfoPtr_ReadTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "ReadTypes");
		NativeFieldInfoPtr_PriorityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "PriorityLevels");
		NativeFieldInfoPtr_Subsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "Subsystems");
	}

	public AsyncReadManagerMetricsFilters(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetTypeIDFilter(Il2CppStructArray<ulong> _typeIDs)
	{
		TypeIDs = _typeIDs;
	}

	public void SetStateFilter(Il2CppStructArray<ProcessingState> _states)
	{
		States = _states;
	}

	public void SetReadTypeFilter(Il2CppStructArray<FileReadType> _readTypes)
	{
		ReadTypes = _readTypes;
	}

	public void SetPriorityFilter(Il2CppStructArray<Priority> _priorityLevels)
	{
		PriorityLevels = _priorityLevels;
	}

	public void SetSubsystemFilter(Il2CppStructArray<AssetLoadingSubsystem> _subsystems)
	{
		Subsystems = _subsystems;
	}

	public void SetTypeIDFilter(ulong _typeID)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetStateFilter(ProcessingState _state)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetReadTypeFilter(FileReadType _readType)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetPriorityFilter(Priority _priorityLevel)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetSubsystemFilter(AssetLoadingSubsystem _subsystem)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void RemoveTypeIDFilter()
	{
		TypeIDs = null;
	}

	public void RemoveStateFilter()
	{
		States = null;
	}

	public void RemoveReadTypeFilter()
	{
		ReadTypes = null;
	}

	public void RemovePriorityFilter()
	{
		PriorityLevels = null;
	}

	public void RemoveSubsystemFilter()
	{
		Subsystems = null;
	}

	public void ClearFilters()
	{
		RemoveTypeIDFilter();
		RemoveStateFilter();
		RemoveReadTypeFilter();
		RemovePriorityFilter();
		RemoveSubsystemFilter();
	}
}
