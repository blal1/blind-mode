using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct ProbeVolumeBakingProcessSettings
{
	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "SettingsVersion")]
	public enum SettingsVersion
	{
		Initial = 0,
		ThreadedVirtualOffset = 1,
		Max = 2,
		Current = 1
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly System.IntPtr NativeFieldInfoPtr_dilationSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_virtualOffsetSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Internal_Static_get_ProbeVolumeBakingProcessSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProbeDilationSettings_VirtualOffsetSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaults_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Upgrade_Internal_Void_0;

	[FieldOffset(0)]
	public SettingsVersion m_Version;

	[FieldOffset(4)]
	public ProbeDilationSettings dilationSettings;

	[FieldOffset(24)]
	public VirtualOffsetSettings virtualOffsetSettings;

	public unsafe static ProbeVolumeBakingProcessSettings Default
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043868, XrefRangeEnd = 1043869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Internal_Static_get_ProbeVolumeBakingProcessSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProbeVolumeBakingProcessSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ProbeVolumeBakingProcessSettings()
	{
		Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeBakingProcessSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, "m_Version");
		NativeFieldInfoPtr_dilationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, "dilationSettings");
		NativeFieldInfoPtr_virtualOffsetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, "virtualOffsetSettings");
		NativeMethodInfoPtr_get_Default_Internal_Static_get_ProbeVolumeBakingProcessSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, 100665753);
		NativeMethodInfoPtr__ctor_Internal_Void_ProbeDilationSettings_VirtualOffsetSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, 100665754);
		NativeMethodInfoPtr_SetDefaults_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, 100665755);
		NativeMethodInfoPtr_Upgrade_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, 100665756);
	}

	[CallerCount(0)]
	public unsafe ProbeVolumeBakingProcessSettings(ProbeDilationSettings dilationSettings, VirtualOffsetSettings virtualOffsetSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dilationSettings);
		*(VirtualOffsetSettings**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &virtualOffsetSettings;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ProbeDilationSettings_VirtualOffsetSettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043869, XrefRangeEnd = 1043870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaults()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaults_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043870, XrefRangeEnd = 1043871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Upgrade()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Upgrade_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
