using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering;

public class IProbeVolumeEnabledRenderPipeline : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_supportProbeVolume_Public_Abstract_Virtual_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_maxSHBands_Public_Abstract_Virtual_New_get_ProbeVolumeSHBands_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_probeVolumeSceneData_Public_Abstract_Virtual_New_get_ProbeVolumeSceneData_0;

	public unsafe virtual bool supportProbeVolume
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_supportProbeVolume_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual ProbeVolumeSHBands maxSHBands
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_maxSHBands_Public_Abstract_Virtual_New_get_ProbeVolumeSHBands_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProbeVolumeSHBands*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual ProbeVolumeSceneData probeVolumeSceneData
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_probeVolumeSceneData_Public_Abstract_Virtual_New_get_ProbeVolumeSceneData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr2) : null;
		}
	}

	static IProbeVolumeEnabledRenderPipeline()
	{
		Il2CppClassPointerStore<IProbeVolumeEnabledRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IProbeVolumeEnabledRenderPipeline");
		NativeMethodInfoPtr_get_supportProbeVolume_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProbeVolumeEnabledRenderPipeline>.NativeClassPtr, 100665265);
		NativeMethodInfoPtr_get_maxSHBands_Public_Abstract_Virtual_New_get_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProbeVolumeEnabledRenderPipeline>.NativeClassPtr, 100665266);
		NativeMethodInfoPtr_get_probeVolumeSceneData_Public_Abstract_Virtual_New_get_ProbeVolumeSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProbeVolumeEnabledRenderPipeline>.NativeClassPtr, 100665267);
	}

	public IProbeVolumeEnabledRenderPipeline(IntPtr pointer)
		: base(pointer)
	{
	}
}
