using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct ProbeDilationSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enableDilation;

	private static readonly System.IntPtr NativeFieldInfoPtr_dilationDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_dilationValidityThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_dilationIterations;

	private static readonly System.IntPtr NativeFieldInfoPtr_squaredDistWeighting;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaults_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool enableDilation;

	[FieldOffset(4)]
	public float dilationDistance;

	[FieldOffset(8)]
	public float dilationValidityThreshold;

	[FieldOffset(12)]
	public int dilationIterations;

	[FieldOffset(16)]
	[MarshalAs(UnmanagedType.U1)]
	public bool squaredDistWeighting;

	static ProbeDilationSettings()
	{
		Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeDilationSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr);
		NativeFieldInfoPtr_enableDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "enableDilation");
		NativeFieldInfoPtr_dilationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "dilationDistance");
		NativeFieldInfoPtr_dilationValidityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "dilationValidityThreshold");
		NativeFieldInfoPtr_dilationIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "dilationIterations");
		NativeFieldInfoPtr_squaredDistWeighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "squaredDistWeighting");
		NativeMethodInfoPtr_SetDefaults_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, 100665749);
		NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, 100665750);
	}

	[CallerCount(0)]
	public unsafe void SetDefaults()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaults_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&from);
		*(ProbeVolumeBakingProcessSettings.SettingsVersion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
