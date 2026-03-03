using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime.Generator;

public class PrimeGeneratorBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe virtual ConfidenceFactor Confidence
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 63708, RefRangeEnd = 63730, XrefRangeStart = 63708, XrefRangeEnd = 63730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ConfidenceFactor*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual PrimalityTest PrimalityTest
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695906, XrefRangeEnd = 695920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PrimalityTest>(intPtr2) : null;
		}
	}

	public unsafe virtual int TrialDivisionBounds
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PrimeGeneratorBase()
	{
		Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math.Prime.Generator", "PrimeGeneratorBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr);
		NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663847);
	}

	[CallerCount(0)]
	public unsafe virtual BigInteger GenerateNewPrime(int bits)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PrimeGeneratorBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PrimeGeneratorBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
