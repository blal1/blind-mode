using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Profiling.Memory;

namespace Unity.MemoryProfiler;

public class DefaultMetadataCollect : MetadataCollect
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CollectMetadata_Public_Virtual_Void_MemorySnapshotMetadata_0;

	private static readonly IntPtr NativeMethodInfoPtr_FormatSecondsToTime_Private_String_Double_0;

	static DefaultMetadataCollect()
	{
		Il2CppClassPointerStore<DefaultMetadataCollect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.MemoryProfiler.dll", "Unity.MemoryProfiler", "DefaultMetadataCollect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultMetadataCollect>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMetadataCollect>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_CollectMetadata_Public_Virtual_Void_MemorySnapshotMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMetadataCollect>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_FormatSecondsToTime_Private_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMetadataCollect>.NativeClassPtr, 100663305);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024307, XrefRangeEnd = 1024324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DefaultMetadataCollect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultMetadataCollect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024324, XrefRangeEnd = 1024366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CollectMetadata(MemorySnapshotMetadata data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CollectMetadata_Public_Virtual_Void_MemorySnapshotMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1024388, RefRangeEnd = 1024389, XrefRangeStart = 1024366, XrefRangeEnd = 1024388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatSecondsToTime(double timeInSeconds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&timeInSeconds);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSecondsToTime_Private_String_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public DefaultMetadataCollect(IntPtr pointer)
		: base(pointer)
	{
	}
}
