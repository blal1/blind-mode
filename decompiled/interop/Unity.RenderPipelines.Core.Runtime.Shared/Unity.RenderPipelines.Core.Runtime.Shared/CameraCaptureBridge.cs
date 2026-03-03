using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Unity.RenderPipelines.Core.Runtime.Shared;

public static class CameraCaptureBridge : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCachedCaptureActionsEnumerator_Public_Static_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_Camera_0;

	static CameraCaptureBridge()
	{
		Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.Shared.dll", "Unity.RenderPipelines.Core.Runtime.Shared", "CameraCaptureBridge");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr);
		NativeMethodInfoPtr_GetCachedCaptureActionsEnumerator_Public_Static_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr, 100663297);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1066459, RefRangeEnd = 1066460, XrefRangeStart = 1066455, XrefRangeEnd = 1066459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator<Il2CppSystem.Action<RenderTargetIdentifier, CommandBuffer>> GetCachedCaptureActionsEnumerator(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCachedCaptureActionsEnumerator_Public_Static_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppSystem.Action<RenderTargetIdentifier, CommandBuffer>>>(intPtr2) : null;
	}

	public CameraCaptureBridge(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
