using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class LightExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetUniversalAdditionalLightData_Public_Static_UniversalAdditionalLightData_Light_0;

	static LightExtensions()
	{
		Il2CppClassPointerStore<LightExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetUniversalAdditionalLightData_Public_Static_UniversalAdditionalLightData_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExtensions>.NativeClassPtr, 100665723);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1101843, RefRangeEnd = 1101850, XrefRangeStart = 1101836, XrefRangeEnd = 1101843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniversalAdditionalLightData GetUniversalAdditionalLightData(this Light light)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUniversalAdditionalLightData_Public_Static_UniversalAdditionalLightData_Light_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalAdditionalLightData>(intPtr2) : null;
	}

	public LightExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
