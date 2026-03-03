using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

public sealed class NameInfo : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NIFullName;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIobjectId;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIassemId;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIprimitiveTypeEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_NItype;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIisSealed;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIisArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIisArrayItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_NItransmitTypeOnObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_NItransmitTypeOnMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIisParentTypeOnObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIarrayEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_NIsealedStatusChecked;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NIname_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0;

	public unsafe string NIFullName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIFullName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIFullName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe long NIobjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIobjectId);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIobjectId)) = value;
		}
	}

	public unsafe long NIassemId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIassemId);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIassemId)) = value;
		}
	}

	public unsafe InternalPrimitiveTypeE NIprimitiveTypeEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIprimitiveTypeEnum);
			return *(InternalPrimitiveTypeE*)num;
		}
		set
		{
			*(InternalPrimitiveTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIprimitiveTypeEnum)) = value;
		}
	}

	public unsafe Type NItype
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NItype);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NItype)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool NIisSealed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIisSealed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIisSealed)) = value;
		}
	}

	public unsafe bool NIisArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIisArray);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIisArray)) = value;
		}
	}

	public unsafe bool NIisArrayItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIisArrayItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIisArrayItem)) = value;
		}
	}

	public unsafe bool NItransmitTypeOnObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NItransmitTypeOnObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NItransmitTypeOnObject)) = value;
		}
	}

	public unsafe bool NItransmitTypeOnMember
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NItransmitTypeOnMember);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NItransmitTypeOnMember)) = value;
		}
	}

	public unsafe bool NIisParentTypeOnObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIisParentTypeOnObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIisParentTypeOnObject)) = value;
		}
	}

	public unsafe InternalArrayTypeE NIarrayEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIarrayEnum);
			return *(InternalArrayTypeE*)num;
		}
		set
		{
			*(InternalArrayTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIarrayEnum)) = value;
		}
	}

	public unsafe bool NIsealedStatusChecked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIsealedStatusChecked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NIsealedStatusChecked)) = value;
		}
	}

	public unsafe bool IsSealed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803888, XrefRangeEnd = 803889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string NIname
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 803890, RefRangeEnd = 803894, XrefRangeStart = 803889, XrefRangeEnd = 803890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NIname_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static NameInfo()
	{
		Il2CppClassPointerStore<NameInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "NameInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameInfo>.NativeClassPtr);
		NativeFieldInfoPtr_NIFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIFullName");
		NativeFieldInfoPtr_NIobjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIobjectId");
		NativeFieldInfoPtr_NIassemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIassemId");
		NativeFieldInfoPtr_NIprimitiveTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIprimitiveTypeEnum");
		NativeFieldInfoPtr_NItype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItype");
		NativeFieldInfoPtr_NIisSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisSealed");
		NativeFieldInfoPtr_NIisArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisArray");
		NativeFieldInfoPtr_NIisArrayItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisArrayItem");
		NativeFieldInfoPtr_NItransmitTypeOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItransmitTypeOnObject");
		NativeFieldInfoPtr_NItransmitTypeOnMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItransmitTypeOnMember");
		NativeFieldInfoPtr_NIisParentTypeOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisParentTypeOnObject");
		NativeFieldInfoPtr_NIarrayEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIarrayEnum");
		NativeFieldInfoPtr_NIsealedStatusChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIsealedStatusChecked");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671185);
		NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671186);
		NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671187);
		NativeMethodInfoPtr_get_NIname_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671188);
		NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100671189);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NameInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803886, XrefRangeEnd = 803888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NameInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
