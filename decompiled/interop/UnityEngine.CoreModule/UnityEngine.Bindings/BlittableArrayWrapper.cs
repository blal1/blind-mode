using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct BlittableArrayWrapper
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "UpdateFlags")]
	public enum UpdateFlags
	{
		NoUpdateNeeded,
		SizeChanged,
		DataIsNativePointer,
		DataIsNativeOwnedMemory,
		DataIsEmpty,
		DataIsNull
	}

	private sealed class MethodInfoStoreGeneric_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateFlags;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0;

	[FieldOffset(0)]
	public System.IntPtr data;

	[FieldOffset(8)]
	public int size;

	[FieldOffset(12)]
	public UpdateFlags updateFlags;

	static BlittableArrayWrapper()
	{
		Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "BlittableArrayWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, "data");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, "size");
		NativeFieldInfoPtr_updateFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, "updateFlags");
		NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, 100667239);
		NativeMethodInfoPtr_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, 100667240);
	}

	[CallerCount(0)]
	public unsafe BlittableArrayWrapper(void* data, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)data;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228331, XrefRangeEnd = 1228344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unmarshal<T>(ref Il2CppArrayBase<T> array) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
