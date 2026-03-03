using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.PDF417.Internal.EC;

public sealed class ModulusPoly : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_field;

	private static readonly System.IntPtr NativeFieldInfoPtr_coefficients;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModulusGF_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Degree_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isZero_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCoefficient_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_evaluateAt_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_Internal_ModulusPoly_ModulusPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_subtract_Internal_ModulusPoly_ModulusPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_multiply_Internal_ModulusPoly_ModulusPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNegative_Internal_ModulusPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_multiply_Internal_ModulusPoly_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_multiplyByMonomial_Internal_ModulusPoly_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe ModulusGF field
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModulusGF>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> coefficients
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coefficients);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coefficients)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int Degree
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Degree_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isZero
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isZero_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ModulusPoly()
	{
		Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal.EC", "ModulusPoly");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr);
		NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, "field");
		NativeFieldInfoPtr_coefficients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, "coefficients");
		NativeMethodInfoPtr__ctor_Public_Void_ModulusGF_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr_get_Degree_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_get_isZero_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_getCoefficient_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_evaluateAt_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_add_Internal_ModulusPoly_ModulusPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_subtract_Internal_ModulusPoly_ModulusPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr_multiply_Internal_ModulusPoly_ModulusPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr_getNegative_Internal_ModulusPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664037);
		NativeMethodInfoPtr_multiply_Internal_ModulusPoly_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_multiplyByMonomial_Internal_ModulusPoly_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664039);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr, 100664040);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1420205, RefRangeEnd = 1420216, XrefRangeStart = 1420195, XrefRangeEnd = 1420205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModulusPoly(ModulusGF field, Il2CppStructArray<int> coefficients)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModulusPoly>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)coefficients);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ModulusGF_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int getCoefficient(int degree)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&degree);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCoefficient_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1420217, RefRangeEnd = 1420222, XrefRangeStart = 1420216, XrefRangeEnd = 1420217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int evaluateAt(int a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_evaluateAt_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420231, RefRangeEnd = 1420233, XrefRangeStart = 1420222, XrefRangeEnd = 1420231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModulusPoly add(ModulusPoly other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_Internal_ModulusPoly_ModulusPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModulusPoly>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420235, RefRangeEnd = 1420237, XrefRangeStart = 1420233, XrefRangeEnd = 1420235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModulusPoly subtract(ModulusPoly other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_subtract_Internal_ModulusPoly_ModulusPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModulusPoly>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420245, RefRangeEnd = 1420247, XrefRangeStart = 1420237, XrefRangeEnd = 1420245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModulusPoly multiply(ModulusPoly other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_multiply_Internal_ModulusPoly_ModulusPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModulusPoly>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420254, RefRangeEnd = 1420256, XrefRangeStart = 1420247, XrefRangeEnd = 1420254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModulusPoly getNegative()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNegative_Internal_ModulusPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModulusPoly>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420264, RefRangeEnd = 1420266, XrefRangeStart = 1420256, XrefRangeEnd = 1420264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModulusPoly multiply(int scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scalar);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_multiply_Internal_ModulusPoly_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModulusPoly>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420274, RefRangeEnd = 1420275, XrefRangeStart = 1420266, XrefRangeEnd = 1420274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModulusPoly multiplyByMonomial(int degree, int coefficient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&degree);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coefficient;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_multiplyByMonomial_Internal_ModulusPoly_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModulusPoly>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420275, XrefRangeEnd = 1420296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public ModulusPoly(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
