using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem;

public static class GC : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EPHEMERON_TOMBSTONE;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxGeneration_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCollect_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMemoryInfo_Internal_Static_Void_byref_UInt32_byref_UInt64_byref_UInt32_byref_UIntPtr_byref_UIntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Collect_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxGeneration_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0;

	public unsafe static Object EPHEMERON_TOMBSTONE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EPHEMERON_TOMBSTONE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EPHEMERON_TOMBSTONE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int MaxGeneration
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756802, XrefRangeEnd = 756806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxGeneration_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static GC()
	{
		Il2CppClassPointerStore<GC>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "GC");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GC>.NativeClassPtr);
		NativeFieldInfoPtr_EPHEMERON_TOMBSTONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GC>.NativeClassPtr, "EPHEMERON_TOMBSTONE");
		NativeMethodInfoPtr_GetMaxGeneration_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666780);
		NativeMethodInfoPtr_InternalCollect_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666781);
		NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666782);
		NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666783);
		NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666784);
		NativeMethodInfoPtr_GetMemoryInfo_Internal_Static_Void_byref_UInt32_byref_UInt64_byref_UInt32_byref_UIntPtr_byref_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666785);
		NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666786);
		NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666787);
		NativeMethodInfoPtr_Collect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666788);
		NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666789);
		NativeMethodInfoPtr_get_MaxGeneration_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666790);
		NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666791);
		NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666792);
		NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666793);
		NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666794);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756733, XrefRangeEnd = 756734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxGeneration()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxGeneration_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756734, XrefRangeEnd = 756735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalCollect(int generation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&generation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCollect_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756735, XrefRangeEnd = 756736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecordPressure(long bytesAllocated)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bytesAllocated);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 756737, RefRangeEnd = 756738, XrefRangeStart = 756736, XrefRangeEnd = 756737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void register_ephemeron_array(Il2CppReferenceArray<Ephemeron> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756738, XrefRangeEnd = 756739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object get_ephemeron_tombstone()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 756739, RefRangeEnd = 756742, XrefRangeStart = 756739, XrefRangeEnd = 756739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out System.UIntPtr lastRecordedHeapSize, out System.UIntPtr lastRecordedFragmentation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref highMemLoadThreshold);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref totalPhysicalMem);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref lastRecordedMemLoad);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref lastRecordedHeapSize);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref lastRecordedFragmentation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMemoryInfo_Internal_Static_Void_byref_UInt32_byref_UInt64_byref_UInt32_byref_UIntPtr_byref_UIntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 756763, RefRangeEnd = 756765, XrefRangeStart = 756742, XrefRangeEnd = 756763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddMemoryPressure(long bytesAllocated)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bytesAllocated);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 756786, RefRangeEnd = 756787, XrefRangeStart = 756765, XrefRangeEnd = 756786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveMemoryPressure(long bytesAllocated)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bytesAllocated);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 756795, RefRangeEnd = 756802, XrefRangeStart = 756787, XrefRangeEnd = 756795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Collect()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Collect_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void KeepAlive(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756806, XrefRangeEnd = 756812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _SuppressFinalize(Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(148)]
	[CachedScanResults(RefRangeStart = 756822, RefRangeEnd = 756970, XrefRangeStart = 756812, XrefRangeEnd = 756822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SuppressFinalize(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756970, XrefRangeEnd = 756971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _ReRegisterForFinalize(Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 756981, RefRangeEnd = 756984, XrefRangeStart = 756971, XrefRangeEnd = 756981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReRegisterForFinalize(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GC(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
