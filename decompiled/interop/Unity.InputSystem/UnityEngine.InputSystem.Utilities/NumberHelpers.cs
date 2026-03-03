using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Utilities;

public static class NumberHelpers : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_Int64_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToNormalizedFloat_Public_Static_Single_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizedFloatToInt_Public_Static_Int32_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIntToNormalizedFloat_Public_Static_Single_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizedFloatToUInt_Public_Static_UInt32_Single_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemapUIntBitsToNormalizeFloatToUIntBits_Public_Static_UInt32_UInt32_UInt32_UInt32_0;

	static NumberHelpers()
	{
		Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "NumberHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668865);
		NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668866);
		NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668867);
		NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668868);
		NativeMethodInfoPtr_IntToNormalizedFloat_Public_Static_Single_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668869);
		NativeMethodInfoPtr_NormalizedFloatToInt_Public_Static_Int32_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668870);
		NativeMethodInfoPtr_UIntToNormalizedFloat_Public_Static_Single_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668871);
		NativeMethodInfoPtr_NormalizedFloatToUInt_Public_Static_UInt32_Single_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668872);
		NativeMethodInfoPtr_RemapUIntBitsToNormalizeFloatToUIntBits_Public_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberHelpers>.NativeClassPtr, 100668873);
	}

	[CallerCount(0)]
	public unsafe static int AlignToMultipleOf(this int number, int alignment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&number);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignment;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static long AlignToMultipleOf(this long number, long alignment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&number);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignment;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_Int64_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint AlignToMultipleOf(this uint number, uint alignment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&number);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignment;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignToMultipleOf_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020316, XrefRangeEnd = 1020321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Approximately(double a, double b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float IntToNormalizedFloat(int value, int minValue, int maxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToNormalizedFloat_Public_Static_Single_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020321, RefRangeEnd = 1020322, XrefRangeStart = 1020321, XrefRangeEnd = 1020321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &intMinValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &intMaxValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizedFloatToInt_Public_Static_Int32_Single_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIntToNormalizedFloat_Public_Static_Single_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1020322, RefRangeEnd = 1020326, XrefRangeStart = 1020322, XrefRangeEnd = 1020322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uintMinValue;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uintMaxValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizedFloatToUInt_Public_Static_UInt32_Single_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1020326, RefRangeEnd = 1020334, XrefRangeStart = 1020326, XrefRangeEnd = 1020326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inBitSize;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outBitSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemapUIntBitsToNormalizeFloatToUIntBits_Public_Static_UInt32_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public NumberHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
