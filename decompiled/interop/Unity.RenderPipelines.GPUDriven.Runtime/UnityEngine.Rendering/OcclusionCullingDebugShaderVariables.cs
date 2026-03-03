using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct OcclusionCullingDebugShaderVariables
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.OcclusionCullingDebugShaderVariables+<_OccluderMipBounds>e__FixedBuffer")]
	public struct __OccluderMipBounds_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public uint FixedElementField;

		static __OccluderMipBounds_e__FixedBuffer()
		{
			Il2CppClassPointerStore<__OccluderMipBounds_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr, "<_OccluderMipBounds>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__OccluderMipBounds_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__OccluderMipBounds_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__OccluderMipBounds_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__DepthSizeInOccluderPixels;

	private static readonly System.IntPtr NativeFieldInfoPtr__OccluderMipBounds;

	private static readonly System.IntPtr NativeFieldInfoPtr__OccluderMipLayoutSizeX;

	private static readonly System.IntPtr NativeFieldInfoPtr__OccluderMipLayoutSizeY;

	private static readonly System.IntPtr NativeFieldInfoPtr__OcclusionCullingDebugPad0;

	private static readonly System.IntPtr NativeFieldInfoPtr__OcclusionCullingDebugPad1;

	[FieldOffset(0)]
	public Vector4 _DepthSizeInOccluderPixels;

	[FieldOffset(16)]
	public __OccluderMipBounds_e__FixedBuffer _OccluderMipBounds;

	[FieldOffset(144)]
	public uint _OccluderMipLayoutSizeX;

	[FieldOffset(148)]
	public uint _OccluderMipLayoutSizeY;

	[FieldOffset(152)]
	public uint _OcclusionCullingDebugPad0;

	[FieldOffset(156)]
	public uint _OcclusionCullingDebugPad1;

	static OcclusionCullingDebugShaderVariables()
	{
		Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OcclusionCullingDebugShaderVariables");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr);
		NativeFieldInfoPtr__DepthSizeInOccluderPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr, "_DepthSizeInOccluderPixels");
		NativeFieldInfoPtr__OccluderMipBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr, "_OccluderMipBounds");
		NativeFieldInfoPtr__OccluderMipLayoutSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr, "_OccluderMipLayoutSizeX");
		NativeFieldInfoPtr__OccluderMipLayoutSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr, "_OccluderMipLayoutSizeY");
		NativeFieldInfoPtr__OcclusionCullingDebugPad0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr, "_OcclusionCullingDebugPad0");
		NativeFieldInfoPtr__OcclusionCullingDebugPad1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr, "_OcclusionCullingDebugPad1");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OcclusionCullingDebugShaderVariables>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
