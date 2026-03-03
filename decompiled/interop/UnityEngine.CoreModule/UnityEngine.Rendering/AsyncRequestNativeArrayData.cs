using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AsyncRequestNativeArrayData
{
	private sealed class MethodInfoStoreGeneric_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0, Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeArrayBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_lengthInBytes;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0;

	[FieldOffset(0)]
	public System.IntPtr nativeArrayBuffer;

	[FieldOffset(8)]
	public long lengthInBytes;

	static AsyncRequestNativeArrayData()
	{
		Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncRequestNativeArrayData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr);
		NativeFieldInfoPtr_nativeArrayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, "nativeArrayBuffer");
		NativeFieldInfoPtr_lengthInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, "lengthInBytes");
		NativeMethodInfoPtr_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, 100667655);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231785, XrefRangeEnd = 1231786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncRequestNativeArrayData CreateAndCheckAccess<T>(NativeArray<T> array) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AsyncRequestNativeArrayData*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public unsafe static AsyncRequestNativeArrayData CreateAndCheckAccess<T>(NativeSlice<T> array) where T : struct
	{
		//IL_001f: Expected O, but got Ref
		AsyncRequestNativeArrayData result = default(AsyncRequestNativeArrayData);
		result.nativeArrayBuffer = (nint)array.GetUnsafePtr();
		result.lengthInBytes = (long)((NativeSlice<T>)(&array)).Length * (long)UnsafeUtility.SizeOf<T>();
		return result;
	}
}
