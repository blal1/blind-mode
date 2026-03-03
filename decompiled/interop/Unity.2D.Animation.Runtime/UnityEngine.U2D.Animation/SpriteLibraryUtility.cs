using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D.Animation;

public static class SpriteLibraryUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GetStringHash;

	private static readonly System.IntPtr NativeMethodInfoPtr_Convert32BitTo30BitHash_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bit30Hash_GetStringHash_Private_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreserveFirst30Bits_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHash_Internal_Static_Int64_0;

	public unsafe static Il2CppSystem.Func<string, int> GetStringHash
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GetStringHash, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GetStringHash, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SpriteLibraryUtility()
	{
		Il2CppClassPointerStore<SpriteLibraryUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "SpriteLibraryUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteLibraryUtility>.NativeClassPtr);
		NativeFieldInfoPtr_GetStringHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteLibraryUtility>.NativeClassPtr, "GetStringHash");
		NativeMethodInfoPtr_Convert32BitTo30BitHash_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibraryUtility>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_Bit30Hash_GetStringHash_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibraryUtility>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_PreserveFirst30Bits_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibraryUtility>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_GenerateHash_Internal_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibraryUtility>.NativeClassPtr, 100663616);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 956864, RefRangeEnd = 956866, XrefRangeStart = 956861, XrefRangeEnd = 956864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Convert32BitTo30BitHash(int input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Convert32BitTo30BitHash_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956866, XrefRangeEnd = 956870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Bit30Hash_GetStringHash(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bit30Hash_GetStringHash_Private_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int PreserveFirst30Bits(int input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreserveFirst30Bits_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956870, XrefRangeEnd = 956875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GenerateHash()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateHash_Internal_Static_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SpriteLibraryUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
