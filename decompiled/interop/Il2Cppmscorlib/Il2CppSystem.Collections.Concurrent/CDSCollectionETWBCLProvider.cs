using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppSystem.Collections.Concurrent;

public sealed class CDSCollectionETWBCLProvider : EventSource
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Log;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0;

	public unsafe static CDSCollectionETWBCLProvider Log
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Log, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CDSCollectionETWBCLProvider>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Log, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CDSCollectionETWBCLProvider()
	{
		Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "CDSCollectionETWBCLProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr);
		NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, "Log");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, 100673757);
		NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, 100673758);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 824699, XrefRangeEnd = 824700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CDSCollectionETWBCLProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 824702, RefRangeEnd = 824704, XrefRangeStart = 824700, XrefRangeEnd = 824702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&numOfBuckets);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CDSCollectionETWBCLProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
