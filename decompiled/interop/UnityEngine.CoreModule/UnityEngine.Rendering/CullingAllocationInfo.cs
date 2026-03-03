using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CullingAllocationInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_visibleLightsPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffscreenVertexLightsPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleReflectionProbesPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleLightCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffscreenVertexLightCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleReflectionProbeCount;

	[FieldOffset(0)]
	public System.IntPtr visibleLightsPtr;

	[FieldOffset(8)]
	public System.IntPtr visibleOffscreenVertexLightsPtr;

	[FieldOffset(16)]
	public System.IntPtr visibleReflectionProbesPtr;

	[FieldOffset(24)]
	public int visibleLightCount;

	[FieldOffset(28)]
	public int visibleOffscreenVertexLightCount;

	[FieldOffset(32)]
	public int visibleReflectionProbeCount;

	static CullingAllocationInfo()
	{
		Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingAllocationInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr);
		NativeFieldInfoPtr_visibleLightsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleLightsPtr");
		NativeFieldInfoPtr_visibleOffscreenVertexLightsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleOffscreenVertexLightsPtr");
		NativeFieldInfoPtr_visibleReflectionProbesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleReflectionProbesPtr");
		NativeFieldInfoPtr_visibleLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleLightCount");
		NativeFieldInfoPtr_visibleOffscreenVertexLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleOffscreenVertexLightCount");
		NativeFieldInfoPtr_visibleReflectionProbeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleReflectionProbeCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
