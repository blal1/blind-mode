using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

public sealed class ParseRecord : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_parseRecordIdCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRparseTypeEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRobjectTypeEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRarrayTypeEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRmemberTypeEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRmemberValueEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRobjectPositionEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRname;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRvalue;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRvarValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRkeyDt;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRdtType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRdtTypeCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRisEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRobjectId;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRidRef;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRarrayElementTypeString;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRarrayElementType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRisArrayVariant;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRarrayElementTypeCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRrank;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRlengthA;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRpositionA;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRlowerBoundA;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRupperBoundA;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRindexMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRmemberIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRlinearlength;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRrectangularMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRisLowerBound;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRtopId;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRheaderId;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRobjectInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRisValueTypeFixup;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRnewObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRobjectA;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRprimitiveArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRisRegistered;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRmemberData;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRsi;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRnullCount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

	public unsafe static int parseRecordIdCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_parseRecordIdCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_parseRecordIdCount, (void*)(&value));
		}
	}

	public unsafe InternalParseTypeE PRparseTypeEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRparseTypeEnum);
			return *(InternalParseTypeE*)num;
		}
		set
		{
			*(InternalParseTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRparseTypeEnum)) = value;
		}
	}

	public unsafe InternalObjectTypeE PRobjectTypeEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectTypeEnum);
			return *(InternalObjectTypeE*)num;
		}
		set
		{
			*(InternalObjectTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectTypeEnum)) = value;
		}
	}

	public unsafe InternalArrayTypeE PRarrayTypeEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRarrayTypeEnum);
			return *(InternalArrayTypeE*)num;
		}
		set
		{
			*(InternalArrayTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRarrayTypeEnum)) = value;
		}
	}

	public unsafe InternalMemberTypeE PRmemberTypeEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRmemberTypeEnum);
			return *(InternalMemberTypeE*)num;
		}
		set
		{
			*(InternalMemberTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRmemberTypeEnum)) = value;
		}
	}

	public unsafe InternalMemberValueE PRmemberValueEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRmemberValueEnum);
			return *(InternalMemberValueE*)num;
		}
		set
		{
			*(InternalMemberValueE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRmemberValueEnum)) = value;
		}
	}

	public unsafe InternalObjectPositionE PRobjectPositionEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectPositionEnum);
			return *(InternalObjectPositionE*)num;
		}
		set
		{
			*(InternalObjectPositionE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectPositionEnum)) = value;
		}
	}

	public unsafe string PRname
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRname);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRname)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string PRvalue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRvalue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRvalue)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Object PRvarValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRvarValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRvarValue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string PRkeyDt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRkeyDt);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRkeyDt)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Type PRdtType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRdtType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRdtType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InternalPrimitiveTypeE PRdtTypeCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRdtTypeCode);
			return *(InternalPrimitiveTypeE*)num;
		}
		set
		{
			*(InternalPrimitiveTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRdtTypeCode)) = value;
		}
	}

	public unsafe bool PRisEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisEnum);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisEnum)) = value;
		}
	}

	public unsafe long PRobjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectId);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectId)) = value;
		}
	}

	public unsafe long PRidRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRidRef);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRidRef)) = value;
		}
	}

	public unsafe string PRarrayElementTypeString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRarrayElementTypeString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRarrayElementTypeString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Type PRarrayElementType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRarrayElementType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRarrayElementType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool PRisArrayVariant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisArrayVariant);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisArrayVariant)) = value;
		}
	}

	public unsafe InternalPrimitiveTypeE PRarrayElementTypeCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRarrayElementTypeCode);
			return *(InternalPrimitiveTypeE*)num;
		}
		set
		{
			*(InternalPrimitiveTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRarrayElementTypeCode)) = value;
		}
	}

	public unsafe int PRrank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRrank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRrank)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> PRlengthA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRlengthA);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRlengthA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> PRpositionA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRpositionA);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRpositionA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> PRlowerBoundA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRlowerBoundA);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRlowerBoundA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> PRupperBoundA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRupperBoundA);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRupperBoundA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> PRindexMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRindexMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRindexMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int PRmemberIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRmemberIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRmemberIndex)) = value;
		}
	}

	public unsafe int PRlinearlength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRlinearlength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRlinearlength)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> PRrectangularMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRrectangularMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRrectangularMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool PRisLowerBound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisLowerBound);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisLowerBound)) = value;
		}
	}

	public unsafe long PRtopId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRtopId);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRtopId)) = value;
		}
	}

	public unsafe long PRheaderId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRheaderId);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRheaderId)) = value;
		}
	}

	public unsafe ReadObjectInfo PRobjectInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool PRisValueTypeFixup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisValueTypeFixup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisValueTypeFixup)) = value;
		}
	}

	public unsafe Object PRnewObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRnewObj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRnewObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Object> PRobjectA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectA);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRobjectA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PrimitiveArray PRprimitiveArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRprimitiveArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PrimitiveArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRprimitiveArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool PRisRegistered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisRegistered);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRisRegistered)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<Object> PRmemberData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRmemberData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRmemberData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SerializationInfo PRsi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRsi);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRsi)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int PRnullCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRnullCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PRnullCount)) = value;
		}
	}

	static ParseRecord()
	{
		Il2CppClassPointerStore<ParseRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ParseRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr);
		NativeFieldInfoPtr_parseRecordIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "parseRecordIdCount");
		NativeFieldInfoPtr_PRparseTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRparseTypeEnum");
		NativeFieldInfoPtr_PRobjectTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectTypeEnum");
		NativeFieldInfoPtr_PRarrayTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayTypeEnum");
		NativeFieldInfoPtr_PRmemberTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberTypeEnum");
		NativeFieldInfoPtr_PRmemberValueEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberValueEnum");
		NativeFieldInfoPtr_PRobjectPositionEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectPositionEnum");
		NativeFieldInfoPtr_PRname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRname");
		NativeFieldInfoPtr_PRvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRvalue");
		NativeFieldInfoPtr_PRvarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRvarValue");
		NativeFieldInfoPtr_PRkeyDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRkeyDt");
		NativeFieldInfoPtr_PRdtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRdtType");
		NativeFieldInfoPtr_PRdtTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRdtTypeCode");
		NativeFieldInfoPtr_PRisEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisEnum");
		NativeFieldInfoPtr_PRobjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectId");
		NativeFieldInfoPtr_PRidRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRidRef");
		NativeFieldInfoPtr_PRarrayElementTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementTypeString");
		NativeFieldInfoPtr_PRarrayElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementType");
		NativeFieldInfoPtr_PRisArrayVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisArrayVariant");
		NativeFieldInfoPtr_PRarrayElementTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementTypeCode");
		NativeFieldInfoPtr_PRrank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRrank");
		NativeFieldInfoPtr_PRlengthA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlengthA");
		NativeFieldInfoPtr_PRpositionA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRpositionA");
		NativeFieldInfoPtr_PRlowerBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlowerBoundA");
		NativeFieldInfoPtr_PRupperBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRupperBoundA");
		NativeFieldInfoPtr_PRindexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRindexMap");
		NativeFieldInfoPtr_PRmemberIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberIndex");
		NativeFieldInfoPtr_PRlinearlength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlinearlength");
		NativeFieldInfoPtr_PRrectangularMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRrectangularMap");
		NativeFieldInfoPtr_PRisLowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisLowerBound");
		NativeFieldInfoPtr_PRtopId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRtopId");
		NativeFieldInfoPtr_PRheaderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRheaderId");
		NativeFieldInfoPtr_PRobjectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectInfo");
		NativeFieldInfoPtr_PRisValueTypeFixup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisValueTypeFixup");
		NativeFieldInfoPtr_PRnewObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRnewObj");
		NativeFieldInfoPtr_PRobjectA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectA");
		NativeFieldInfoPtr_PRprimitiveArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRprimitiveArray");
		NativeFieldInfoPtr_PRisRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisRegistered");
		NativeFieldInfoPtr_PRmemberData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberData");
		NativeFieldInfoPtr_PRsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRsi");
		NativeFieldInfoPtr_PRnullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRnullCount");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, 100671154);
		NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, 100671155);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParseRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 803642, RefRangeEnd = 803649, XrefRangeStart = 803624, XrefRangeEnd = 803642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ParseRecord(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
