using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings;

public static class BindingsAllocator : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct NativeOwnedMemory
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		[FieldOffset(0)]
		public System.IntPtr data;

		static NativeOwnedMemory()
		{
			Il2CppClassPointerStore<NativeOwnedMemory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr, "NativeOwnedMemory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeOwnedMemory>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOwnedMemory>.NativeClassPtr, "data");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeOwnedMemory>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private delegate System.IntPtr MallocDelegate(int size);

	private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeNativeOwnedMemory_Public_Static_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNativeOwnedDataPointer_Public_Static_ptr_Void_ptr_Void_0;

	private static readonly MallocDelegate MallocDelegateField;

	static BindingsAllocator()
	{
		Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "BindingsAllocator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr);
		NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr, 100667236);
		NativeMethodInfoPtr_FreeNativeOwnedMemory_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr, 100667237);
		NativeMethodInfoPtr_GetNativeOwnedDataPointer_Public_Static_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr, 100667238);
		MallocDelegateField = IL2CPP.ResolveICall<MallocDelegate>("UnityEngine.Bindings.BindingsAllocator::Malloc");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228326, XrefRangeEnd = 1228328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Free(void* ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)ptr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1228330, RefRangeEnd = 1228331, XrefRangeStart = 1228328, XrefRangeEnd = 1228330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreeNativeOwnedMemory(void* ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)ptr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeNativeOwnedMemory_Public_Static_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 962094, RefRangeEnd = 962123, XrefRangeStart = 962094, XrefRangeEnd = 962123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* GetNativeOwnedDataPointer(void* ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)ptr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNativeOwnedDataPointer_Public_Static_ptr_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	public BindingsAllocator(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void* Malloc(int size)
	{
		return (void*)MallocDelegateField(size);
	}
}
