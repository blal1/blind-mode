using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Hierarchy;

[System.Serializable]
public sealed class HierarchySearchFilter : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_WhiteSpaces;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Invalid;

	private static readonly System.IntPtr NativeFieldInfoPtr__Name_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Value_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NumValue_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Op_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Invalid_Public_Static_get_byref_HierarchySearchFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NumValue_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Op_Public_get_HierarchySearchFilterOperator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_HierarchySearchFilterOperator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuoteStringIfNeeded_Internal_Static_String_String_0;

	public unsafe static Il2CppStructArray<char> s_WhiteSpaces
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_WhiteSpaces, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_WhiteSpaces, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static HierarchySearchFilter s_Invalid
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Invalid, (void*)intPtr);
			return new HierarchySearchFilter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Invalid, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe string _Name_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _Value_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Value_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Value_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe float _NumValue_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NumValue_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NumValue_k__BackingField)) = value;
		}
	}

	public unsafe HierarchySearchFilterOperator _Op_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Op_k__BackingField);
			return *(HierarchySearchFilterOperator*)num;
		}
		set
		{
			*(HierarchySearchFilterOperator*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Op_k__BackingField)) = value;
		}
	}

	public unsafe static ref HierarchySearchFilter Invalid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243417, XrefRangeEnd = 1243421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Invalid_Public_Static_get_byref_HierarchySearchFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(HierarchySearchFilter*)intPtr2;
		}
	}

	public unsafe bool IsValid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243421, XrefRangeEnd = 1243425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string Name
	{
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			_Name_k__BackingField = value;
		}
	}

	public unsafe string Value
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			_Value_k__BackingField = value;
		}
	}

	public unsafe float NumValue
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NumValue_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_NumValue_k__BackingField = value;
		}
	}

	public unsafe HierarchySearchFilterOperator Op
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Op_Public_get_HierarchySearchFilterOperator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HierarchySearchFilterOperator*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_Op_k__BackingField = value;
		}
	}

	static HierarchySearchFilter()
	{
		Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchySearchFilter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr);
		NativeFieldInfoPtr_s_WhiteSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, "s_WhiteSpaces");
		NativeFieldInfoPtr_s_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, "s_Invalid");
		NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, "<Name>k__BackingField");
		NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, "<Value>k__BackingField");
		NativeFieldInfoPtr__NumValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, "<NumValue>k__BackingField");
		NativeFieldInfoPtr__Op_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, "<Op>k__BackingField");
		NativeMethodInfoPtr_get_Invalid_Public_Static_get_byref_HierarchySearchFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_get_NumValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_get_Op_Public_get_HierarchySearchFilterOperator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_ToString_Public_Static_String_HierarchySearchFilterOperator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_QuoteStringIfNeeded_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr, 100663508);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243425, XrefRangeEnd = 1243434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(HierarchySearchFilterOperator op)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&op);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_HierarchySearchFilterOperator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243470, RefRangeEnd = 1243472, XrefRangeStart = 1243434, XrefRangeEnd = 1243470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243481, RefRangeEnd = 1243482, XrefRangeStart = 1243472, XrefRangeEnd = 1243481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string QuoteStringIfNeeded(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuoteStringIfNeeded_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public HierarchySearchFilter(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HierarchySearchFilter()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchySearchFilter>.NativeClassPtr))
	{
	}

	public static HierarchySearchFilterOperator ToOp(string op)
	{
		switch (_PrivateImplementationDetails_.ComputeStringHash(op))
		{
		case 957132539u:
			if (!(op == "<"))
			{
				break;
			}
			return HierarchySearchFilterOperator.Lesser;
		case 2499223986u:
			if (!(op == "<="))
			{
				break;
			}
			return HierarchySearchFilterOperator.LesserOrEqual;
		case 990687777u:
			if (!(op == ">"))
			{
				break;
			}
			return HierarchySearchFilterOperator.Greater;
		case 284975636u:
			if (!(op == ">="))
			{
				break;
			}
			return HierarchySearchFilterOperator.GreaterOrEqual;
		case 940354920u:
			if (!(op == "="))
			{
				break;
			}
			return HierarchySearchFilterOperator.Equal;
		case 1057798253u:
			if (!(op == ":"))
			{
				break;
			}
			return HierarchySearchFilterOperator.Contains;
		case 2428715011u:
			if (!(op == "!="))
			{
				break;
			}
			return HierarchySearchFilterOperator.NotEqual;
		case 671913016u:
			if (!(op == "-"))
			{
				break;
			}
			return HierarchySearchFilterOperator.Not;
		}
		throw new Il2CppSystem.NotImplementedException(Il2CppSystem.String.Concat("Cannot convert ", op, " to SearchFilterOperator"));
	}

	public static HierarchySearchFilter CreateFilter(string name, string op, string value)
	{
		return CreateFilter(name, ToOp(op), value);
	}

	public static HierarchySearchFilter CreateFilter(string name, HierarchySearchFilterOperator op, string str)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
