using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class InstanceCullingBatcherDesc : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_onCompleteCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewDefault_Public_Static_InstanceCullingBatcherDesc_0;

	public unsafe OnCullingCompleteCallback onCompleteCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnCullingCompleteCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InstanceCullingBatcherDesc()
	{
		Il2CppClassPointerStore<InstanceCullingBatcherDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceCullingBatcherDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceCullingBatcherDesc>.NativeClassPtr);
		NativeFieldInfoPtr_onCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcherDesc>.NativeClassPtr, "onCompleteCallback");
		NativeMethodInfoPtr_NewDefault_Public_Static_InstanceCullingBatcherDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherDesc>.NativeClassPtr, 100663603);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070123, RefRangeEnd = 1070124, XrefRangeStart = 1070122, XrefRangeEnd = 1070123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InstanceCullingBatcherDesc NewDefault()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewDefault_Public_Static_InstanceCullingBatcherDesc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InstanceCullingBatcherDesc(pointer);
	}

	public InstanceCullingBatcherDesc(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InstanceCullingBatcherDesc()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceCullingBatcherDesc>.NativeClassPtr))
	{
	}
}
