using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Numerics.Hashing;

public static class HashHelpers : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_RandomSeed;

	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;

	public unsafe static int RandomSeed
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RandomSeed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RandomSeed, (void*)(&value));
		}
	}

	static HashHelpers()
	{
		Il2CppClassPointerStore<HashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Numerics.Hashing", "HashHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr);
		NativeFieldInfoPtr_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "RandomSeed");
		NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100672595);
	}

	[CallerCount(113)]
	[CachedScanResults(RefRangeStart = 815135, RefRangeEnd = 815248, XrefRangeStart = 815135, XrefRangeEnd = 815135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Combine(int h1, int h2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HashHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
