using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;

namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct Unmarshal
{
	private sealed class MethodInfoStoreGeneric_UnmarshalUnityObject_Public_Static_T_IntPtr_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UnmarshalUnityObject_Public_Static_T_IntPtr_0, Il2CppClassPointerStore<Unmarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalUnityObject_Public_Static_T_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromIntPtrUnsafe_Public_Static_GCHandle_IntPtr_0;

	static Unmarshal()
	{
		Il2CppClassPointerStore<Unmarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "Unmarshal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unmarshal>.NativeClassPtr);
		NativeMethodInfoPtr_UnmarshalUnityObject_Public_Static_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unmarshal>.NativeClassPtr, 100667232);
		NativeMethodInfoPtr_FromIntPtrUnsafe_Public_Static_GCHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unmarshal>.NativeClassPtr, 100667233);
	}

	[CallerCount(196)]
	[CachedScanResults(RefRangeStart = 1224763, RefRangeEnd = 1224959, XrefRangeStart = 1224755, XrefRangeEnd = 1224763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T UnmarshalUnityObject<T>(System.IntPtr gcHandlePtr) where T : Object
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gcHandlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UnmarshalUnityObject_Public_Static_T_IntPtr_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224959, XrefRangeEnd = 1224960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Runtime.InteropServices.GCHandle FromIntPtrUnsafe(System.IntPtr gcHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gcHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromIntPtrUnsafe_Public_Static_GCHandle_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Il2CppSystem.Runtime.InteropServices.GCHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unmarshal>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
