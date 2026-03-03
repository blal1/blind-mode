using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct VirtualOffsetSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_useVirtualOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_validityThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_outOfGeoOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_rayOriginBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_collisionMask;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaults_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool useVirtualOffset;

	[FieldOffset(4)]
	public float validityThreshold;

	[FieldOffset(8)]
	public float outOfGeoOffset;

	[FieldOffset(12)]
	public float searchMultiplier;

	[FieldOffset(16)]
	public float rayOriginBias;

	[FieldOffset(20)]
	public LayerMask collisionMask;

	static VirtualOffsetSettings()
	{
		Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VirtualOffsetSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr);
		NativeFieldInfoPtr_useVirtualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "useVirtualOffset");
		NativeFieldInfoPtr_validityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "validityThreshold");
		NativeFieldInfoPtr_outOfGeoOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "outOfGeoOffset");
		NativeFieldInfoPtr_searchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "searchMultiplier");
		NativeFieldInfoPtr_rayOriginBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "rayOriginBias");
		NativeFieldInfoPtr_collisionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "collisionMask");
		NativeMethodInfoPtr_SetDefaults_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, 100665751);
		NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, 100665752);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043866, XrefRangeEnd = 1043867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaults()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaults_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043867, XrefRangeEnd = 1043868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
