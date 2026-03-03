using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions;

public sealed class UnaryExpression : Expression
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Operand_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Operand_Public_get_Expression_0;

	public unsafe Expression _Operand_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Operand_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Expression>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Operand_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Expression Operand
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Operand_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
		}
	}

	static UnaryExpression()
	{
		Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "UnaryExpression");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr);
		NativeFieldInfoPtr__Operand_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, "<Operand>k__BackingField");
		NativeMethodInfoPtr_get_Operand_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryExpression>.NativeClassPtr, 100663617);
	}

	public UnaryExpression(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
