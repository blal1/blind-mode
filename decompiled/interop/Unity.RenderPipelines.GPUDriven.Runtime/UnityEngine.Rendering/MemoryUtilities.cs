using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering;

public static class MemoryUtilities : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Malloc_Public_Static_ptr_T_Int32_Allocator_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Malloc_Public_Static_ptr_T_Int32_Allocator_0, Il2CppClassPointerStore<MemoryUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Malloc_Public_Static_ptr_T_Int32_Allocator_0;

	static MemoryUtilities()
	{
		Il2CppClassPointerStore<MemoryUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "MemoryUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_Malloc_Public_Static_ptr_T_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryUtilities>.NativeClassPtr, 100664060);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075479, RefRangeEnd = 1075480, XrefRangeStart = 1075468, XrefRangeEnd = 1075479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T* Malloc<T>(int count, Allocator allocator) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(Allocator**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Malloc_Public_Static_ptr_T_Int32_Allocator_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (T*)result;
	}

	public MemoryUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
