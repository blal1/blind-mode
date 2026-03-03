using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct BlittableListWrapper
{
	private sealed class MethodInfoStoreGeneric_Unmarshal_Internal_Void_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Unmarshal_Internal_Void_List_1_T_0, Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_arrayWrapper;

	private static readonly System.IntPtr NativeFieldInfoPtr_listSize;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlittableArrayWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unmarshal_Internal_Void_List_1_T_0;

	[FieldOffset(0)]
	public BlittableArrayWrapper arrayWrapper;

	[FieldOffset(16)]
	public int listSize;

	static BlittableListWrapper()
	{
		Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "BlittableListWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_arrayWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, "arrayWrapper");
		NativeFieldInfoPtr_listSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, "listSize");
		NativeMethodInfoPtr__ctor_Public_Void_BlittableArrayWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, 100667241);
		NativeMethodInfoPtr_Unmarshal_Internal_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, 100667242);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1228344, RefRangeEnd = 1228345, XrefRangeStart = 1228344, XrefRangeEnd = 1228344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlittableListWrapper(BlittableArrayWrapper arrayWrapper, int listSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&arrayWrapper);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &listSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BlittableArrayWrapper_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228345, XrefRangeEnd = 1228348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unmarshal<T>(List<T> list) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Unmarshal_Internal_Void_List_1_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
