using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.Common.ReedSolomon;

public sealed class GenericGFPoly : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_field;

	private static readonly System.IntPtr NativeFieldInfoPtr_coefficients;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GenericGF_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Coefficients_Internal_get_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Degree_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isZero_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCoefficient_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_evaluateAt_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addOrSubtract_Internal_GenericGFPoly_GenericGFPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_multiply_Internal_GenericGFPoly_GenericGFPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_multiply_Internal_GenericGFPoly_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_multiplyByMonomial_Internal_GenericGFPoly_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_divide_Internal_Il2CppReferenceArray_1_GenericGFPoly_GenericGFPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe GenericGF field
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGF>(intPtr) : null;
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

	public unsafe Il2CppStructArray<int> Coefficients
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Coefficients_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
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

	static GenericGFPoly()
	{
		Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Common.ReedSolomon", "GenericGFPoly");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr);
		NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, "field");
		NativeFieldInfoPtr_coefficients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, "coefficients");
		NativeMethodInfoPtr__ctor_Internal_Void_GenericGF_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664804);
		NativeMethodInfoPtr_get_Coefficients_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664805);
		NativeMethodInfoPtr_get_Degree_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664806);
		NativeMethodInfoPtr_get_isZero_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664807);
		NativeMethodInfoPtr_getCoefficient_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664808);
		NativeMethodInfoPtr_evaluateAt_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664809);
		NativeMethodInfoPtr_addOrSubtract_Internal_GenericGFPoly_GenericGFPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664810);
		NativeMethodInfoPtr_multiply_Internal_GenericGFPoly_GenericGFPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664811);
		NativeMethodInfoPtr_multiply_Internal_GenericGFPoly_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664812);
		NativeMethodInfoPtr_multiplyByMonomial_Internal_GenericGFPoly_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664813);
		NativeMethodInfoPtr_divide_Internal_Il2CppReferenceArray_1_GenericGFPoly_GenericGFPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664814);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr, 100664815);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1429543, RefRangeEnd = 1429552, XrefRangeStart = 1429533, XrefRangeEnd = 1429543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GenericGFPoly(GenericGF field, Il2CppStructArray<int> coefficients)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericGFPoly>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)coefficients);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_GenericGF_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1429556, RefRangeEnd = 1429560, XrefRangeStart = 1429552, XrefRangeEnd = 1429556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1429572, RefRangeEnd = 1429577, XrefRangeStart = 1429560, XrefRangeEnd = 1429572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GenericGFPoly addOrSubtract(GenericGFPoly other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addOrSubtract_Internal_GenericGFPoly_GenericGFPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGFPoly>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1429588, RefRangeEnd = 1429590, XrefRangeStart = 1429577, XrefRangeEnd = 1429588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GenericGFPoly multiply(GenericGFPoly other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_multiply_Internal_GenericGFPoly_GenericGFPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGFPoly>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1429598, RefRangeEnd = 1429600, XrefRangeStart = 1429590, XrefRangeEnd = 1429598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GenericGFPoly multiply(int scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scalar);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_multiply_Internal_GenericGFPoly_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGFPoly>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1429608, RefRangeEnd = 1429611, XrefRangeStart = 1429600, XrefRangeEnd = 1429608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GenericGFPoly multiplyByMonomial(int degree, int coefficient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&degree);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coefficient;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_multiplyByMonomial_Internal_GenericGFPoly_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGFPoly>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1429622, RefRangeEnd = 1429623, XrefRangeStart = 1429611, XrefRangeEnd = 1429622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<GenericGFPoly> divide(GenericGFPoly other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_divide_Internal_Il2CppReferenceArray_1_GenericGFPoly_GenericGFPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GenericGFPoly>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429623, XrefRangeEnd = 1429650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public GenericGFPoly(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
