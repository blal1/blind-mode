using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe;

public sealed class AsyncReadManagerRequestMetric : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__AssetName_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OffsetBytes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__SizeBytes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AssetTypeId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CurrentBytesRead_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BatchReadCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsBatchRead_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ReadType_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PriorityLevel_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Subsystem_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField;

	public unsafe string _AssetName_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AssetName_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AssetName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _FileName_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FileName_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FileName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ulong _OffsetBytes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OffsetBytes_k__BackingField);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OffsetBytes_k__BackingField)) = value;
		}
	}

	public unsafe ulong _SizeBytes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SizeBytes_k__BackingField);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SizeBytes_k__BackingField)) = value;
		}
	}

	public unsafe ulong _AssetTypeId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AssetTypeId_k__BackingField);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AssetTypeId_k__BackingField)) = value;
		}
	}

	public unsafe ulong _CurrentBytesRead_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentBytesRead_k__BackingField);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentBytesRead_k__BackingField)) = value;
		}
	}

	public unsafe uint _BatchReadCount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BatchReadCount_k__BackingField);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BatchReadCount_k__BackingField)) = value;
		}
	}

	public unsafe bool _IsBatchRead_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsBatchRead_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsBatchRead_k__BackingField)) = value;
		}
	}

	public unsafe ProcessingState _State_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__State_k__BackingField);
			return *(ProcessingState*)num;
		}
		set
		{
			*(ProcessingState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__State_k__BackingField)) = value;
		}
	}

	public unsafe FileReadType _ReadType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReadType_k__BackingField);
			return *(FileReadType*)num;
		}
		set
		{
			*(FileReadType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReadType_k__BackingField)) = value;
		}
	}

	public unsafe Priority _PriorityLevel_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PriorityLevel_k__BackingField);
			return *(Priority*)num;
		}
		set
		{
			*(Priority*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PriorityLevel_k__BackingField)) = value;
		}
	}

	public unsafe AssetLoadingSubsystem _Subsystem_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Subsystem_k__BackingField);
			return *(AssetLoadingSubsystem*)num;
		}
		set
		{
			*(AssetLoadingSubsystem*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Subsystem_k__BackingField)) = value;
		}
	}

	public unsafe double _RequestTimeMicroseconds_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField)) = value;
		}
	}

	public unsafe double _TimeInQueueMicroseconds_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField)) = value;
		}
	}

	public unsafe double _TotalTimeMicroseconds_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField)) = value;
		}
	}

	public string AssetName => _AssetName_k__BackingField;

	public string FileName => _FileName_k__BackingField;

	public ulong OffsetBytes => _OffsetBytes_k__BackingField;

	public ulong SizeBytes => _SizeBytes_k__BackingField;

	public ulong AssetTypeId => _AssetTypeId_k__BackingField;

	public ulong CurrentBytesRead => _CurrentBytesRead_k__BackingField;

	public uint BatchReadCount => _BatchReadCount_k__BackingField;

	public bool IsBatchRead => _IsBatchRead_k__BackingField;

	public ProcessingState State => _State_k__BackingField;

	public FileReadType ReadType => _ReadType_k__BackingField;

	public Priority PriorityLevel => _PriorityLevel_k__BackingField;

	public AssetLoadingSubsystem Subsystem => _Subsystem_k__BackingField;

	public double RequestTimeMicroseconds => _RequestTimeMicroseconds_k__BackingField;

	public double TimeInQueueMicroseconds => _TimeInQueueMicroseconds_k__BackingField;

	public double TotalTimeMicroseconds => _TotalTimeMicroseconds_k__BackingField;

	static AsyncReadManagerRequestMetric()
	{
		Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerRequestMetric");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr);
		NativeFieldInfoPtr__AssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetName>k__BackingField");
		NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<FileName>k__BackingField");
		NativeFieldInfoPtr__OffsetBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<OffsetBytes>k__BackingField");
		NativeFieldInfoPtr__SizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<SizeBytes>k__BackingField");
		NativeFieldInfoPtr__AssetTypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetTypeId>k__BackingField");
		NativeFieldInfoPtr__CurrentBytesRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<CurrentBytesRead>k__BackingField");
		NativeFieldInfoPtr__BatchReadCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<BatchReadCount>k__BackingField");
		NativeFieldInfoPtr__IsBatchRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<IsBatchRead>k__BackingField");
		NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<State>k__BackingField");
		NativeFieldInfoPtr__ReadType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<ReadType>k__BackingField");
		NativeFieldInfoPtr__PriorityLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<PriorityLevel>k__BackingField");
		NativeFieldInfoPtr__Subsystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<Subsystem>k__BackingField");
		NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<RequestTimeMicroseconds>k__BackingField");
		NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TimeInQueueMicroseconds>k__BackingField");
		NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TotalTimeMicroseconds>k__BackingField");
	}

	public AsyncReadManagerRequestMetric(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AsyncReadManagerRequestMetric()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr))
	{
	}
}
