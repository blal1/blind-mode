using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Numerics;

public static class BigIntegerCalculator : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ReducerThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_SquareThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllocationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_MultiplyThreshold;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subtract_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

	public unsafe static int ReducerThreshold
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReducerThreshold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReducerThreshold, (void*)(&value));
		}
	}

	public unsafe static int SquareThreshold
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SquareThreshold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SquareThreshold, (void*)(&value));
		}
	}

	public unsafe static int AllocationThreshold
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AllocationThreshold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AllocationThreshold, (void*)(&value));
		}
	}

	public unsafe static int MultiplyThreshold
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MultiplyThreshold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MultiplyThreshold, (void*)(&value));
		}
	}

	static BigIntegerCalculator()
	{
		Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Numerics", "BigIntegerCalculator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr);
		NativeFieldInfoPtr_ReducerThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, "ReducerThreshold");
		NativeFieldInfoPtr_SquareThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, "SquareThreshold");
		NativeFieldInfoPtr_AllocationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, "AllocationThreshold");
		NativeFieldInfoPtr_MultiplyThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, "MultiplyThreshold");
		NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_Add_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_Subtract_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663332);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 900909, RefRangeEnd = 900912, XrefRangeStart = 900905, XrefRangeEnd = 900909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<uint> Add(Il2CppStructArray<uint> left, uint right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 900920, RefRangeEnd = 900924, XrefRangeStart = 900912, XrefRangeEnd = 900920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<uint> Add(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)left;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftLength;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = right;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rightLength;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = bits;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitsLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 900928, RefRangeEnd = 900930, XrefRangeStart = 900924, XrefRangeEnd = 900928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<uint> Subtract(Il2CppStructArray<uint> left, uint right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 900939, RefRangeEnd = 900941, XrefRangeStart = 900930, XrefRangeEnd = 900939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<uint> Subtract(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)left;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftLength;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = right;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rightLength;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = bits;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitsLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subtract_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int Compare(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public BigIntegerCalculator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
