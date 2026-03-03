using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppZXing.PDF417;

public sealed class PDF417MacroMetadata : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__SegmentIndex_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__FileId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__SegmentCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Sender_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Addressee_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__FileSize_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Checksum_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Timestamp_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SegmentIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FileId_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SegmentCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Sender_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Addressee_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FileName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FileSize_Public_get_Nullable_1_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Checksum_Public_get_Nullable_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Timestamp_Public_get_Nullable_1_Int64_0;

	public unsafe int _SegmentIndex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SegmentIndex_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SegmentIndex_k__BackingField)) = value;
		}
	}

	public unsafe string _FileId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FileId_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FileId_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int _SegmentCount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SegmentCount_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SegmentCount_k__BackingField)) = value;
		}
	}

	public unsafe string _Sender_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Sender_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Sender_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _Addressee_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Addressee_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Addressee_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
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

	public unsafe Il2CppSystem.Nullable<long> _FileSize_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FileSize_k__BackingField);
			return new Il2CppSystem.Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<long>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FileSize_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<long>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Nullable<int> _Checksum_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Checksum_k__BackingField);
			return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Checksum_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Nullable<long> _Timestamp_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Timestamp_k__BackingField);
			return new Il2CppSystem.Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<long>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Timestamp_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<long>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int SegmentIndex
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SegmentIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string FileId
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FileId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe int SegmentCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SegmentCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string Sender
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Sender_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string Addressee
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Addressee_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string FileName
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FileName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Nullable<long> FileSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FileSize_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<long>(pointer);
		}
	}

	public unsafe Il2CppSystem.Nullable<int> Checksum
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Checksum_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<int>(pointer);
		}
	}

	public unsafe Il2CppSystem.Nullable<long> Timestamp
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Timestamp_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<long>(pointer);
		}
	}

	static PDF417MacroMetadata()
	{
		Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417", "PDF417MacroMetadata");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr);
		NativeFieldInfoPtr__SegmentIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<SegmentIndex>k__BackingField");
		NativeFieldInfoPtr__FileId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<FileId>k__BackingField");
		NativeFieldInfoPtr__SegmentCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<SegmentCount>k__BackingField");
		NativeFieldInfoPtr__Sender_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<Sender>k__BackingField");
		NativeFieldInfoPtr__Addressee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<Addressee>k__BackingField");
		NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<FileName>k__BackingField");
		NativeFieldInfoPtr__FileSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<FileSize>k__BackingField");
		NativeFieldInfoPtr__Checksum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<Checksum>k__BackingField");
		NativeFieldInfoPtr__Timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, "<Timestamp>k__BackingField");
		NativeMethodInfoPtr_get_SegmentIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663775);
		NativeMethodInfoPtr_get_FileId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663776);
		NativeMethodInfoPtr_get_SegmentCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663777);
		NativeMethodInfoPtr_get_Sender_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663778);
		NativeMethodInfoPtr_get_Addressee_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663779);
		NativeMethodInfoPtr_get_FileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663780);
		NativeMethodInfoPtr_get_FileSize_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663781);
		NativeMethodInfoPtr_get_Checksum_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr_get_Timestamp_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417MacroMetadata>.NativeClassPtr, 100663783);
	}

	public PDF417MacroMetadata(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
