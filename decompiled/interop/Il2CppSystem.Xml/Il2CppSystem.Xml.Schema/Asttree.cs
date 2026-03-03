using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMS.Internal.Xml.XPath;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema;

public class Asttree : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__fAxisArray;

	private static readonly System.IntPtr NativeFieldInfoPtr__xpathexpr;

	private static readonly System.IntPtr NativeFieldInfoPtr__isField;

	private static readonly System.IntPtr NativeFieldInfoPtr__nsmgr;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0;

	public unsafe ArrayList _fAxisArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fAxisArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fAxisArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _xpathexpr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xpathexpr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xpathexpr)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool _isField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isField)) = value;
		}
	}

	public unsafe XmlNamespaceManager _nsmgr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nsmgr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nsmgr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ArrayList SubtreeArray
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
		}
	}

	static Asttree()
	{
		Il2CppClassPointerStore<Asttree>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Asttree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Asttree>.NativeClassPtr);
		NativeFieldInfoPtr__fAxisArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "_fAxisArray");
		NativeFieldInfoPtr__xpathexpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "_xpathexpr");
		NativeFieldInfoPtr__isField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "_isField");
		NativeFieldInfoPtr__nsmgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "_nsmgr");
		NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100665881);
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100665882);
		NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100665883);
		NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100665884);
		NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100665885);
		NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100665886);
		NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100665887);
		NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100665888);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 920081, RefRangeEnd = 920082, XrefRangeStart = 920077, XrefRangeEnd = 920081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Asttree>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(xPath);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isField;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsmgr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsNameTest(Axis ast)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ast);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsAttribute(Axis ast)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ast);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsDescendantOrSelf(Axis ast)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ast);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsSelf(Axis ast)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ast);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 920125, RefRangeEnd = 920127, XrefRangeStart = 920082, XrefRangeEnd = 920125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(xPath);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isField;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsmgr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 920130, RefRangeEnd = 920132, XrefRangeStart = 920127, XrefRangeEnd = 920130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetURN(Axis axis, XmlNamespaceManager nsmgr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)axis);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsmgr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Asttree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
