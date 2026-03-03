using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath;

public class XPathParser : Il2CppSystem.Object
{
	public class ParamInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__ftype;

		private static readonly System.IntPtr NativeFieldInfoPtr__minargs;

		private static readonly System.IntPtr NativeFieldInfoPtr__maxargs;

		private static readonly System.IntPtr NativeFieldInfoPtr__argTypes;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0;

		public unsafe Function.FunctionType _ftype
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ftype);
				return *(Function.FunctionType*)num;
			}
			set
			{
				*(Function.FunctionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ftype)) = value;
			}
		}

		public unsafe int _minargs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minargs);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minargs)) = value;
			}
		}

		public unsafe int _maxargs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxargs);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxargs)) = value;
			}
		}

		public unsafe Il2CppStructArray<XPathResultType> _argTypes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__argTypes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__argTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Function.FunctionType FType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Function.FunctionType*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int Minargs
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int Maxargs
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe Il2CppStructArray<XPathResultType> ArgTypes
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
		}

		static ParamInfo()
		{
			Il2CppClassPointerStore<ParamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "ParamInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr);
			NativeFieldInfoPtr__ftype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, "_ftype");
			NativeFieldInfoPtr__minargs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, "_minargs");
			NativeFieldInfoPtr__maxargs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, "_maxargs");
			NativeFieldInfoPtr__argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, "_argTypes");
			NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, 100668726);
			NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, 100668727);
			NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, 100668728);
			NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, 100668729);
			NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, 100668730);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952723, XrefRangeEnd = 952725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, Il2CppStructArray<XPathResultType> argTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&ftype);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minargs;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxargs;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argTypes);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ParamInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__scanner;

	private static readonly System.IntPtr NativeFieldInfoPtr__parseDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray1;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray2;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray3;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray4;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray5;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray6;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray7;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray8;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_temparray9;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_functionTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_AxesTable;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseXPathExpression_Public_Static_AstNode_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseExpression_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextLex_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestOp_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Dictionary_2_String_ParamInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAxesTable_Private_Static_Dictionary_2_String_AxisType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis_Private_AxisType_0;

	public unsafe XPathScanner _scanner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scanner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XPathScanner>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scanner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _parseDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parseDepth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parseDepth)) = value;
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray3
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray3, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray4
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray4, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray5
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray5, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray5, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray6
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray6, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray6, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray7
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray7, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray7, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray8
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray8, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray8, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<XPathResultType> s_temparray9
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_temparray9, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_temparray9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, ParamInfo> s_functionTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_functionTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, ParamInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_functionTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, Axis.AxisType> s_AxesTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_AxesTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Axis.AxisType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_AxesTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static XPathParser()
	{
		Il2CppClassPointerStore<XPathParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "XPathParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathParser>.NativeClassPtr);
		NativeFieldInfoPtr__scanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "_scanner");
		NativeFieldInfoPtr__parseDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "_parseDepth");
		NativeFieldInfoPtr_s_temparray1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray1");
		NativeFieldInfoPtr_s_temparray2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray2");
		NativeFieldInfoPtr_s_temparray3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray3");
		NativeFieldInfoPtr_s_temparray4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray4");
		NativeFieldInfoPtr_s_temparray5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray5");
		NativeFieldInfoPtr_s_temparray6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray6");
		NativeFieldInfoPtr_s_temparray7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray7");
		NativeFieldInfoPtr_s_temparray8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray8");
		NativeFieldInfoPtr_s_temparray9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray9");
		NativeFieldInfoPtr_s_functionTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_functionTable");
		NativeFieldInfoPtr_s_AxesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_AxesTable");
		NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668694);
		NativeMethodInfoPtr_ParseXPathExpression_Public_Static_AstNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668695);
		NativeMethodInfoPtr_ParseExpression_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668696);
		NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668697);
		NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668698);
		NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668699);
		NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668700);
		NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668701);
		NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668702);
		NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668703);
		NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668704);
		NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668705);
		NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668706);
		NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668707);
		NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668708);
		NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668709);
		NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668710);
		NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668711);
		NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668712);
		NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668713);
		NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668714);
		NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668715);
		NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668716);
		NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668717);
		NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668718);
		NativeMethodInfoPtr_NextLex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668719);
		NativeMethodInfoPtr_TestOp_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668720);
		NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668721);
		NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Dictionary_2_String_ParamInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668722);
		NativeMethodInfoPtr_CreateAxesTable_Private_Static_Dictionary_2_String_AxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668723);
		NativeMethodInfoPtr_GetAxis_Private_AxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100668724);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XPathParser(XPathScanner scanner)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathParser>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scanner);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 952741, RefRangeEnd = 952742, XrefRangeStart = 952725, XrefRangeEnd = 952741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AstNode ParseXPathExpression(string xpathExpression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(xpathExpression);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseXPathExpression_Public_Static_AstNode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 952756, RefRangeEnd = 952760, XrefRangeStart = 952742, XrefRangeEnd = 952756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseExpression(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseExpression_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952760, XrefRangeEnd = 952774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseOrExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 952788, RefRangeEnd = 952792, XrefRangeStart = 952774, XrefRangeEnd = 952788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseAndExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 952803, RefRangeEnd = 952805, XrefRangeStart = 952792, XrefRangeEnd = 952803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseEqualityExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 952818, RefRangeEnd = 952820, XrefRangeStart = 952805, XrefRangeEnd = 952818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseRelationalExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 952831, RefRangeEnd = 952833, XrefRangeStart = 952820, XrefRangeEnd = 952831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseAdditiveExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 952851, RefRangeEnd = 952853, XrefRangeStart = 952833, XrefRangeEnd = 952851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseMultiplicativeExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 952869, RefRangeEnd = 952871, XrefRangeStart = 952853, XrefRangeEnd = 952869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseUnaryExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 952881, RefRangeEnd = 952882, XrefRangeStart = 952871, XrefRangeEnd = 952881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseUnionExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 952886, RefRangeEnd = 952889, XrefRangeStart = 952882, XrefRangeEnd = 952886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNodeType(XPathScanner scaner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaner);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 952932, RefRangeEnd = 952934, XrefRangeStart = 952889, XrefRangeEnd = 952932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParsePathExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952934, XrefRangeEnd = 952943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseFilterExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 952946, RefRangeEnd = 952949, XrefRangeStart = 952943, XrefRangeEnd = 952946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParsePredicate(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952949, XrefRangeEnd = 952967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseLocationPath(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 952977, RefRangeEnd = 952980, XrefRangeStart = 952967, XrefRangeEnd = 952977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseRelativeLocationPath(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool IsStep(XPathScanner.LexKind lexKind)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lexKind);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 953007, RefRangeEnd = 953009, XrefRangeStart = 952980, XrefRangeEnd = 953007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseStep(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 953047, RefRangeEnd = 953048, XrefRangeStart = 953009, XrefRangeEnd = 953047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		*(Axis.AxisType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisType;
		*(XPathNodeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodeType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953048, XrefRangeEnd = 953052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPrimaryExpr(XPathScanner scanner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scanner);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 953063, RefRangeEnd = 953065, XrefRangeStart = 953052, XrefRangeEnd = 953063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParsePrimaryExpr(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953065, XrefRangeEnd = 953129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstNode ParseMethod(AstNode qyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qyInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 953129, RefRangeEnd = 953131, XrefRangeStart = 953129, XrefRangeEnd = 953129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckToken(XPathScanner.LexKind t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953131, XrefRangeEnd = 953134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassToken(XPathScanner.LexKind t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953134, XrefRangeEnd = 953136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextLex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextLex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953136, XrefRangeEnd = 953137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TestOp(string op)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(op);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestOp_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void CheckNodeSet(XPathResultType t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953137, XrefRangeEnd = 953391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<string, ParamInfo> CreateFunctionTable()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Dictionary_2_String_ParamInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, ParamInfo>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953391, XrefRangeEnd = 953450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<string, Axis.AxisType> CreateAxesTable()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAxesTable_Private_Static_Dictionary_2_String_AxisType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Axis.AxisType>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953450, XrefRangeEnd = 953457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Axis.AxisType GetAxis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxis_Private_AxisType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Axis.AxisType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public XPathParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
