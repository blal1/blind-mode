using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class OcclusionCullingDebugOutput : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_occluderDepthPyramid;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionDebugOverlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_cb;

	public unsafe RTHandle occluderDepthPyramid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderDepthPyramid);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderDepthPyramid)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer occlusionDebugOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionDebugOverlay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionDebugOverlay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe OcclusionCullingDebugShaderVariables cb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cb);
			return *(OcclusionCullingDebugShaderVariables*)num;
		}
		set
		{
			*(OcclusionCullingDebugShaderVariables*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cb)) = value;
		}
	}

	static OcclusionCullingDebugOutput()
	{
		Il2CppClassPointerStore<OcclusionCullingDebugOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OcclusionCullingDebugOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionCullingDebugOutput>.NativeClassPtr);
		NativeFieldInfoPtr_occluderDepthPyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugOutput>.NativeClassPtr, "occluderDepthPyramid");
		NativeFieldInfoPtr_occlusionDebugOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugOutput>.NativeClassPtr, "occlusionDebugOverlay");
		NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugOutput>.NativeClassPtr, "cb");
	}

	public OcclusionCullingDebugOutput(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public OcclusionCullingDebugOutput()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionCullingDebugOutput>.NativeClassPtr))
	{
	}
}
