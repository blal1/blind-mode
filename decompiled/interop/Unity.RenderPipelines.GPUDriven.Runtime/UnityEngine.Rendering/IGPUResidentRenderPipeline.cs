using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

public class IGPUResidentRenderPipeline : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_gpuResidentDrawerSettings_Public_Abstract_Virtual_New_get_GPUResidentDrawerSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReinitializeGPUResidentDrawer_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Public_Virtual_New_Boolean_byref_String_byref_LogType_0;

	public unsafe virtual GPUResidentDrawerSettings gpuResidentDrawerSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_gpuResidentDrawerSettings_Public_Abstract_Virtual_New_get_GPUResidentDrawerSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new GPUResidentDrawerSettings(pointer);
		}
	}

	static IGPUResidentRenderPipeline()
	{
		Il2CppClassPointerStore<IGPUResidentRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "IGPUResidentRenderPipeline");
		NativeMethodInfoPtr_get_gpuResidentDrawerSettings_Public_Abstract_Virtual_New_get_GPUResidentDrawerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGPUResidentRenderPipeline>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_ReinitializeGPUResidentDrawer_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGPUResidentRenderPipeline>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Public_Virtual_New_Boolean_byref_String_byref_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGPUResidentRenderPipeline>.NativeClassPtr, 100663540);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1068347, RefRangeEnd = 1068349, XrefRangeStart = 1068347, XrefRangeEnd = 1068349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReinitializeGPUResidentDrawer()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitializeGPUResidentDrawer_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069261, XrefRangeEnd = 1069263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		nint num = 0;
		*ptr = (nint)(&num);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref severity);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Public_Virtual_New_Boolean_byref_String_byref_LogType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		message = IL2CPP.Il2CppStringToManaged((IntPtr)num);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IGPUResidentRenderPipeline(IntPtr pointer)
		: base(pointer)
	{
	}
}
