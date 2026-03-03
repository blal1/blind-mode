using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.MemoryProfiler;

public static class MetadataInjector : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultCollector;

	private static readonly System.IntPtr NativeFieldInfoPtr_CollectorCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultCollectorInjected;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerInitMetadata_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMetadataCollection_Private_Static_Void_0;

	public unsafe static DefaultMetadataCollect DefaultCollector
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultCollector, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DefaultMetadataCollect>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultCollector, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static long CollectorCount
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CollectorCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CollectorCount, (void*)(&value));
		}
	}

	public unsafe static byte DefaultCollectorInjected
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultCollectorInjected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultCollectorInjected, (void*)(&value));
		}
	}

	static MetadataInjector()
	{
		Il2CppClassPointerStore<MetadataInjector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.MemoryProfiler.dll", "Unity.MemoryProfiler", "MetadataInjector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetadataInjector>.NativeClassPtr);
		NativeFieldInfoPtr_DefaultCollector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataInjector>.NativeClassPtr, "DefaultCollector");
		NativeFieldInfoPtr_CollectorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataInjector>.NativeClassPtr, "CollectorCount");
		NativeFieldInfoPtr_DefaultCollectorInjected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataInjector>.NativeClassPtr, "DefaultCollectorInjected");
		NativeMethodInfoPtr_PlayerInitMetadata_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataInjector>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_InitializeMetadataCollection_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataInjector>.NativeClassPtr, 100663299);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024195, XrefRangeEnd = 1024253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayerInitMetadata()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerInitMetadata_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024253, XrefRangeEnd = 1024278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeMetadataCollection()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMetadataCollection_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MetadataInjector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
