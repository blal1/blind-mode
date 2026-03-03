using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public static class GPUDrivenCallbacks : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeGPUDrivenLODGroupDataNativeCallback_Public_Static_Void_GPUDrivenLODGroupDataNativeCallback_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeGPUDrivenRendererDataNativeCallback_Public_Static_Void_GPUDrivenRendererDataNativeCallback_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0;

	static GPUDrivenCallbacks()
	{
		Il2CppClassPointerStore<GPUDrivenCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GPUDrivenCallbacks");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenCallbacks>.NativeClassPtr);
		NativeMethodInfoPtr_InvokeGPUDrivenLODGroupDataNativeCallback_Public_Static_Void_GPUDrivenLODGroupDataNativeCallback_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenCallbacks>.NativeClassPtr, 100668360);
		NativeMethodInfoPtr_InvokeGPUDrivenRendererDataNativeCallback_Public_Static_Void_GPUDrivenRendererDataNativeCallback_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenCallbacks>.NativeClassPtr, 100668361);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237502, XrefRangeEnd = 1237503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeGPUDrivenLODGroupDataNativeCallback(GPUDrivenLODGroupDataNativeCallback callback, [In] ref GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lodGroupDataNative);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeGPUDrivenLODGroupDataNativeCallback_Public_Static_Void_GPUDrivenLODGroupDataNativeCallback_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237503, XrefRangeEnd = 1237504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeGPUDrivenRendererDataNativeCallback(GPUDrivenRendererDataNativeCallback callback, [In] ref GPUDrivenRendererGroupDataNative rendererDataNative, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rendererDataNative);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeGPUDrivenRendererDataNativeCallback_Public_Static_Void_GPUDrivenRendererDataNativeCallback_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUDrivenCallbacks(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
