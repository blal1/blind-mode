using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema;

public class RestrictionFacets : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Length;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_Patterns;

	private static readonly System.IntPtr NativeFieldInfoPtr_Enumeration;

	private static readonly System.IntPtr NativeFieldInfoPtr_WhiteSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxInclusive;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxExclusive;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinInclusive;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinExclusive;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalDigits;

	private static readonly System.IntPtr NativeFieldInfoPtr_FractionDigits;

	private static readonly System.IntPtr NativeFieldInfoPtr_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_FixedFlags;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int Length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length)) = value;
		}
	}

	public unsafe int MinLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinLength)) = value;
		}
	}

	public unsafe int MaxLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxLength)) = value;
		}
	}

	public unsafe ArrayList Patterns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Patterns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Patterns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ArrayList Enumeration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enumeration);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enumeration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaWhiteSpace WhiteSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhiteSpace);
			return *(XmlSchemaWhiteSpace*)num;
		}
		set
		{
			*(XmlSchemaWhiteSpace*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhiteSpace)) = value;
		}
	}

	public unsafe Object MaxInclusive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxInclusive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxInclusive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object MaxExclusive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxExclusive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxExclusive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object MinInclusive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinInclusive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinInclusive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object MinExclusive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinExclusive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinExclusive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int TotalDigits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalDigits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalDigits)) = value;
		}
	}

	public unsafe int FractionDigits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FractionDigits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FractionDigits)) = value;
		}
	}

	public unsafe RestrictionFlags Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flags);
			return *(RestrictionFlags*)num;
		}
		set
		{
			*(RestrictionFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flags)) = value;
		}
	}

	public unsafe RestrictionFlags FixedFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedFlags);
			return *(RestrictionFlags*)num;
		}
		set
		{
			*(RestrictionFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedFlags)) = value;
		}
	}

	static RestrictionFacets()
	{
		Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RestrictionFacets");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr);
		NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Length");
		NativeFieldInfoPtr_MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinLength");
		NativeFieldInfoPtr_MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxLength");
		NativeFieldInfoPtr_Patterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Patterns");
		NativeFieldInfoPtr_Enumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Enumeration");
		NativeFieldInfoPtr_WhiteSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "WhiteSpace");
		NativeFieldInfoPtr_MaxInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxInclusive");
		NativeFieldInfoPtr_MaxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxExclusive");
		NativeFieldInfoPtr_MinInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinInclusive");
		NativeFieldInfoPtr_MinExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinExclusive");
		NativeFieldInfoPtr_TotalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "TotalDigits");
		NativeFieldInfoPtr_FractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "FractionDigits");
		NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Flags");
		NativeFieldInfoPtr_FixedFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "FixedFlags");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, 100666149);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RestrictionFacets()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RestrictionFacets(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
