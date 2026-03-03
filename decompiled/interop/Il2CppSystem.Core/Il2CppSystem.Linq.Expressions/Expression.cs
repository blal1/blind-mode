using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Dynamic.Utils;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Linq.Expressions;

public class Expression : Object
{
	public class LambdaExpressionProxy : Object
	{
		static LambdaExpressionProxy()
		{
			Il2CppClassPointerStore<LambdaExpressionProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Expression>.NativeClassPtr, "LambdaExpressionProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LambdaExpressionProxy>.NativeClassPtr);
		}

		public LambdaExpressionProxy(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MemberExpressionProxy : Object
	{
		static MemberExpressionProxy()
		{
			Il2CppClassPointerStore<MemberExpressionProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Expression>.NativeClassPtr, "MemberExpressionProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberExpressionProxy>.NativeClassPtr);
		}

		public MemberExpressionProxy(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class UnaryExpressionProxy : Object
	{
		static UnaryExpressionProxy()
		{
			Il2CppClassPointerStore<UnaryExpressionProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Expression>.NativeClassPtr, "UnaryExpressionProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnaryExpressionProxy>.NativeClassPtr);
		}

		public UnaryExpressionProxy(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ExtensionInfo : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_NodeType;

		public unsafe ExpressionType NodeType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeType);
				return *(ExpressionType*)num;
			}
			set
			{
				*(ExpressionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeType)) = value;
			}
		}

		static ExtensionInfo()
		{
			Il2CppClassPointerStore<ExtensionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Expression>.NativeClassPtr, "ExtensionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionInfo>.NativeClassPtr);
			NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionInfo>.NativeClassPtr, "NodeType");
		}

		public ExtensionInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_lambdaDelegateCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_legacyCtorSupportTable;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_ExpressionType_0;

	public unsafe static CacheDict<Type, MethodInfo> s_lambdaDelegateCache
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_lambdaDelegateCache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CacheDict<Type, MethodInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_lambdaDelegateCache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Runtime.CompilerServices.ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_legacyCtorSupportTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Runtime.CompilerServices.ConditionalWeakTable<Expression, ExtensionInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_legacyCtorSupportTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe virtual ExpressionType NodeType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861650, XrefRangeEnd = 861659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_ExpressionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ExpressionType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Expression()
	{
		Il2CppClassPointerStore<Expression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression>.NativeClassPtr);
		NativeFieldInfoPtr_s_lambdaDelegateCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "s_lambdaDelegateCache");
		NativeFieldInfoPtr_s_legacyCtorSupportTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "s_legacyCtorSupportTable");
		NativeMethodInfoPtr_get_NodeType_Public_Virtual_New_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100663610);
	}

	public Expression(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
public class Expression<TDelegate> : LambdaExpression
{
	static Expression()
	{
		Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Expression`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression<TDelegate>>.NativeClassPtr);
	}

	public Expression(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
