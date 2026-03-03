using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct LightBakingOutput
{
	private static readonly System.IntPtr NativeFieldInfoPtr_probeOcclusionLightIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionMaskChannel;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapBakeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_mixedLightingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBaked;

	[FieldOffset(0)]
	public int probeOcclusionLightIndex;

	[FieldOffset(4)]
	public int occlusionMaskChannel;

	[FieldOffset(8)]
	public LightmapBakeType lightmapBakeType;

	[FieldOffset(12)]
	public MixedLightingMode mixedLightingMode;

	[FieldOffset(16)]
	[MarshalAs(UnmanagedType.U1)]
	public bool isBaked;

	static LightBakingOutput()
	{
		Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightBakingOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr);
		NativeFieldInfoPtr_probeOcclusionLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "probeOcclusionLightIndex");
		NativeFieldInfoPtr_occlusionMaskChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "occlusionMaskChannel");
		NativeFieldInfoPtr_lightmapBakeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "lightmapBakeType");
		NativeFieldInfoPtr_mixedLightingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "mixedLightingMode");
		NativeFieldInfoPtr_isBaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "isBaked");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
