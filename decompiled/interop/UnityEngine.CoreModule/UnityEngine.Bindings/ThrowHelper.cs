using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Bindings;

public static class ThrowHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentNullException_Public_Static_Void_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowNullReferenceException_Public_Static_Void_Object_0;

	static ThrowHelper()
	{
		Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "ThrowHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
		NativeMethodInfoPtr_ThrowArgumentNullException_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100667234);
		NativeMethodInfoPtr_ThrowNullReferenceException_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100667235);
	}

	[CallerCount(761)]
	[CachedScanResults(RefRangeStart = 1224966, RefRangeEnd = 1225727, XrefRangeStart = 1224960, XrefRangeEnd = 1224966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentNullException(Il2CppSystem.Object obj, string parameterName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parameterName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentNullException_Public_Static_Void_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2593)]
	[CachedScanResults(RefRangeStart = 1225733, RefRangeEnd = 1228326, XrefRangeStart = 1225727, XrefRangeEnd = 1225733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowNullReferenceException(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowNullReferenceException_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ThrowHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
