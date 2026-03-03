using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class ComponentUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsUniversalCamera_Public_Static_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUniversalLight_Public_Static_Boolean_Light_0;

	static ComponentUtility()
	{
		Il2CppClassPointerStore<ComponentUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ComponentUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentUtility>.NativeClassPtr);
		NativeMethodInfoPtr_IsUniversalCamera_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentUtility>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_IsUniversalLight_Public_Static_Boolean_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentUtility>.NativeClassPtr, 100663320);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076087, XrefRangeEnd = 1076095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUniversalCamera(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUniversalCamera_Public_Static_Boolean_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076095, XrefRangeEnd = 1076103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUniversalLight(Light light)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUniversalLight_Public_Static_Boolean_Light_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ComponentUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
