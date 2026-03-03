using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema;

public sealed class ValidationState : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsNill;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_NeedValidateChildren;

	private static readonly System.IntPtr NativeFieldInfoPtr_CheckRequiredAttribute;

	private static readonly System.IntPtr NativeFieldInfoPtr_ValidationSkipped;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProcessContents;

	private static readonly System.IntPtr NativeFieldInfoPtr_Validity;

	private static readonly System.IntPtr NativeFieldInfoPtr_ElementDecl;

	private static readonly System.IntPtr NativeFieldInfoPtr_ElementDeclBeforeXsi;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Namespace;

	private static readonly System.IntPtr NativeFieldInfoPtr_Constr;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentState;

	private static readonly System.IntPtr NativeFieldInfoPtr_HasMatched;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllElementsSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_RunningPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_TooComplex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool IsNill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNill)) = value;
		}
	}

	public unsafe bool IsDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDefault);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDefault)) = value;
		}
	}

	public unsafe bool NeedValidateChildren
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeedValidateChildren);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeedValidateChildren)) = value;
		}
	}

	public unsafe bool CheckRequiredAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CheckRequiredAttribute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CheckRequiredAttribute)) = value;
		}
	}

	public unsafe bool ValidationSkipped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidationSkipped);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidationSkipped)) = value;
		}
	}

	public unsafe XmlSchemaContentProcessing ProcessContents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProcessContents);
			return *(XmlSchemaContentProcessing*)num;
		}
		set
		{
			*(XmlSchemaContentProcessing*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProcessContents)) = value;
		}
	}

	public unsafe XmlSchemaValidity Validity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Validity);
			return *(XmlSchemaValidity*)num;
		}
		set
		{
			*(XmlSchemaValidity*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Validity)) = value;
		}
	}

	public unsafe SchemaElementDecl ElementDecl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ElementDecl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ElementDecl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SchemaElementDecl ElementDeclBeforeXsi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ElementDeclBeforeXsi);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ElementDeclBeforeXsi)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string LocalName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string Namespace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Namespace);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Namespace)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppReferenceArray<ConstraintStruct> Constr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Constr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstraintStruct>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Constr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StateUnion CurrentState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentState);
			return *(StateUnion*)num;
		}
		set
		{
			*(StateUnion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentState)) = value;
		}
	}

	public unsafe bool HasMatched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasMatched);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasMatched)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<BitSet> CurPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BitSet AllElementsSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllElementsSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitSet>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllElementsSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<RangePositionInfo> RunningPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RunningPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RangePositionInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RunningPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool TooComplex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TooComplex);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TooComplex)) = value;
		}
	}

	static ValidationState()
	{
		Il2CppClassPointerStore<ValidationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ValidationState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationState>.NativeClassPtr);
		NativeFieldInfoPtr_IsNill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "IsNill");
		NativeFieldInfoPtr_IsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "IsDefault");
		NativeFieldInfoPtr_NeedValidateChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "NeedValidateChildren");
		NativeFieldInfoPtr_CheckRequiredAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CheckRequiredAttribute");
		NativeFieldInfoPtr_ValidationSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ValidationSkipped");
		NativeFieldInfoPtr_ProcessContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ProcessContents");
		NativeFieldInfoPtr_Validity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Validity");
		NativeFieldInfoPtr_ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ElementDecl");
		NativeFieldInfoPtr_ElementDeclBeforeXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ElementDeclBeforeXsi");
		NativeFieldInfoPtr_LocalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "LocalName");
		NativeFieldInfoPtr_Namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Namespace");
		NativeFieldInfoPtr_Constr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Constr");
		NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CurrentState");
		NativeFieldInfoPtr_HasMatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "HasMatched");
		NativeFieldInfoPtr_CurPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CurPos");
		NativeFieldInfoPtr_AllElementsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "AllElementsSet");
		NativeFieldInfoPtr_RunningPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "RunningPositions");
		NativeFieldInfoPtr_TooComplex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "TooComplex");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, 100667126);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 935945, RefRangeEnd = 935948, XrefRangeStart = 935940, XrefRangeEnd = 935945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ValidationState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ValidationState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
