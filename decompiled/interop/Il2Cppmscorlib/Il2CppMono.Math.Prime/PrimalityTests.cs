using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime;

public sealed class PrimalityTests : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;

	static PrimalityTests()
	{
		Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math.Prime", "PrimalityTests");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr);
		NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663780);
		NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663781);
		NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663783);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 700536, RefRangeEnd = 700538, XrefRangeStart = 700525, XrefRangeEnd = 700536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bi);
		*(ConfidenceFactor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &confidence;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700538, XrefRangeEnd = 700542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Test(BigInteger n, ConfidenceFactor confidence)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)n);
		*(ConfidenceFactor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &confidence;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 700593, RefRangeEnd = 700595, XrefRangeStart = 700542, XrefRangeEnd = 700593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)n);
		*(ConfidenceFactor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &confidence;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 700621, RefRangeEnd = 700622, XrefRangeStart = 700595, XrefRangeEnd = 700621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bi);
		*(ConfidenceFactor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &confidence;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public PrimalityTests(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
