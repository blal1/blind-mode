using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath;

public class Operator : AstNode
{
	[OriginalName("System.Xml.dll", "", "Op")]
	public enum Op
	{
		INVALID,
		OR,
		AND,
		EQ,
		NE,
		LT,
		LE,
		GT,
		GE,
		PLUS,
		MINUS,
		MUL,
		DIV,
		MOD,
		UNION
	}

	private static readonly IntPtr NativeFieldInfoPtr_s_invertOp;

	private static readonly IntPtr NativeFieldInfoPtr__opType;

	private static readonly IntPtr NativeFieldInfoPtr__opnd1;

	private static readonly IntPtr NativeFieldInfoPtr__opnd2;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;

	public unsafe static Il2CppStructArray<Op> s_invertOp
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_invertOp, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Op>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_invertOp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Op _opType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opType);
			return *(Op*)num;
		}
		set
		{
			*(Op*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opType)) = value;
		}
	}

	public unsafe AstNode _opnd1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opnd1);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opnd1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AstNode _opnd2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opnd2);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AstNode>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opnd2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override AstType Type
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 63528, RefRangeEnd = 63535, XrefRangeStart = 63528, XrefRangeEnd = 63535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static Operator()
	{
		Il2CppClassPointerStore<Operator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Operator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Operator>.NativeClassPtr);
		NativeFieldInfoPtr_s_invertOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "s_invertOp");
		NativeFieldInfoPtr__opType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "_opType");
		NativeFieldInfoPtr__opnd1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "_opnd1");
		NativeFieldInfoPtr__opnd2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "_opnd2");
		NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100668684);
		NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100668685);
		NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100668686);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 871747, RefRangeEnd = 871752, XrefRangeStart = 871747, XrefRangeEnd = 871752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Operator(Op op, AstNode opnd1, AstNode opnd2)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Operator>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&op);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)opnd1);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)opnd2);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Operator(IntPtr pointer)
		: base(pointer)
	{
	}
}
