using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

[StructLayout(LayoutKind.Explicit)]
public struct RuntimeGPtrArrayHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0;

	[FieldOffset(0)]
	public System.IntPtr value;

	public unsafe int Length
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 696548, RefRangeEnd = 696555, XrefRangeStart = 696548, XrefRangeEnd = 696548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe System.IntPtr this[int i]
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 696556, RefRangeEnd = 696563, XrefRangeStart = 696555, XrefRangeEnd = 696556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&i);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RuntimeGPtrArrayHandle()
	{
		Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeGPtrArrayHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr);
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, "value");
		NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663397);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 696563, RefRangeEnd = 696565, XrefRangeStart = 696563, XrefRangeEnd = 696563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr Lookup(int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696565, XrefRangeEnd = 696566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GPtrArrayFree(RuntimeStructs.GPtrArray* value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 696567, RefRangeEnd = 696581, XrefRangeStart = 696566, XrefRangeEnd = 696567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyAndFree(ref RuntimeGPtrArrayHandle h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
