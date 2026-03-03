using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct LightShadowCasterCullingInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_splitRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitExclusionMask;

	[FieldOffset(0)]
	public RangeInt splitRange;

	[FieldOffset(8)]
	public BatchCullingProjectionType projectionType;

	[FieldOffset(12)]
	public ushort splitExclusionMask;

	static LightShadowCasterCullingInfo()
	{
		Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LightShadowCasterCullingInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr);
		NativeFieldInfoPtr_splitRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr, "splitRange");
		NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr, "projectionType");
		NativeFieldInfoPtr_splitExclusionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr, "splitExclusionMask");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
