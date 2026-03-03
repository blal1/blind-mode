using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath;

public class Function : AstNode
{
	[OriginalName("System.Xml.dll", "", "FunctionType")]
	public enum FunctionType
	{
		FuncLast,
		FuncPosition,
		FuncCount,
		FuncID,
		FuncLocalName,
		FuncNameSpaceUri,
		FuncName,
		FuncString,
		FuncBoolean,
		FuncNumber,
		FuncTrue,
		FuncFalse,
		FuncNot,
		FuncConcat,
		FuncStartsWith,
		FuncContains,
		FuncSubstringBefore,
		FuncSubstringAfter,
		FuncSubstring,
		FuncStringLength,
		FuncNormalize,
		FuncTranslate,
		FuncLang,
		FuncSum,
		FuncFloor,
		FuncCeiling,
		FuncRound,
		FuncUserDefined
	}

	private static readonly IntPtr NativeFieldInfoPtr__functionType;

	private static readonly IntPtr NativeFieldInfoPtr__argumentList;

	private static readonly IntPtr NativeFieldInfoPtr__name;

	private static readonly IntPtr NativeFieldInfoPtr__prefix;

	private static readonly IntPtr NativeFieldInfoPtr_ReturnTypes;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FunctionType_List_1_AstNode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_AstNode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;

	public unsafe FunctionType _functionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__functionType);
			return *(FunctionType*)num;
		}
		set
		{
			*(FunctionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__functionType)) = value;
		}
	}

	public unsafe List<AstNode> _argumentList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__argumentList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AstNode>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__argumentList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _prefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prefix);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prefix)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> ReturnTypes
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReturnTypes, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReturnTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override AstType Type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AstType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override XPathResultType ReturnType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952713, XrefRangeEnd = 952717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XPathResultType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Function()
	{
		Il2CppClassPointerStore<Function>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Function");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Function>.NativeClassPtr);
		NativeFieldInfoPtr__functionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_functionType");
		NativeFieldInfoPtr__argumentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_argumentList");
		NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_name");
		NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_prefix");
		NativeFieldInfoPtr_ReturnTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "ReturnTypes");
		NativeMethodInfoPtr__ctor_Public_Void_FunctionType_List_1_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100668671);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100668672);
		NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100668673);
		NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100668674);
		NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100668675);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952679, XrefRangeEnd = 952687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Function(FunctionType ftype, List<AstNode> argumentList)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&ftype);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argumentList);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FunctionType_List_1_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952687, XrefRangeEnd = 952697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Function(string prefix, string name, List<AstNode> argumentList)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argumentList);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 952711, RefRangeEnd = 952713, XrefRangeStart = 952697, XrefRangeEnd = 952711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Function(FunctionType ftype, AstNode arg)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&ftype);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Function(IntPtr pointer)
		: base(pointer)
	{
	}
}
