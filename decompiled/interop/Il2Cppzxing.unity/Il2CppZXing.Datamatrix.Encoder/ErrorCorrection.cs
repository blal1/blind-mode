using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.Datamatrix.Encoder;

public static class ErrorCorrection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FACTOR_SETS;

	private static readonly System.IntPtr NativeFieldInfoPtr_FACTORS;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_ALOG;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodeECC200_Public_Static_String_String_SymbolInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createECCBlock_Private_Static_String_String_Int32_0;

	public unsafe static Il2CppStructArray<int> FACTOR_SETS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FACTOR_SETS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FACTOR_SETS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> FACTORS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FACTORS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FACTORS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> LOG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOG, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOG, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> ALOG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALOG, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALOG, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ErrorCorrection()
	{
		Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Datamatrix.Encoder", "ErrorCorrection");
		NativeFieldInfoPtr_FACTOR_SETS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, "FACTOR_SETS");
		NativeFieldInfoPtr_FACTORS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, "FACTORS");
		NativeFieldInfoPtr_LOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, "LOG");
		NativeFieldInfoPtr_ALOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, "ALOG");
		NativeMethodInfoPtr_encodeECC200_Public_Static_String_String_SymbolInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_createECCBlock_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, 100664535);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1426759, RefRangeEnd = 1426760, XrefRangeStart = 1426720, XrefRangeEnd = 1426759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string encodeECC200(string codewords, SymbolInfo symbolInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(codewords);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)symbolInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeECC200_Public_Static_String_String_SymbolInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1426785, RefRangeEnd = 1426787, XrefRangeStart = 1426760, XrefRangeEnd = 1426785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string createECCBlock(string codewords, int numECWords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(codewords);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numECWords;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createECCBlock_Private_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public ErrorCorrection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
