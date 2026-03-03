using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Numerics;

public static class NumericsHelpers : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_DangerousMakeTwosComplement_Public_Static_Void_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeUlong_Public_Static_UInt64_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineHash_Public_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineHash_Public_Static_Int32_Int32_Int32_0;

	static NumericsHelpers()
	{
		Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Numerics", "NumericsHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_DangerousMakeTwosComplement_Public_Static_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_MakeUlong_Public_Static_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_Abs_Public_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_CombineHash_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_CombineHash_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663342);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 901084, RefRangeEnd = 901085, XrefRangeStart = 901082, XrefRangeEnd = 901084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DangerousMakeTwosComplement(Il2CppStructArray<uint> d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DangerousMakeTwosComplement_Public_Static_Void_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static ulong MakeUlong(uint uHi, uint uLo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uHi);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uLo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeUlong_Public_Static_UInt64_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint Abs(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint CombineHash(uint u1, uint u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineHash_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int CombineHash(int n1, int n2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&n1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineHash_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public NumericsHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
