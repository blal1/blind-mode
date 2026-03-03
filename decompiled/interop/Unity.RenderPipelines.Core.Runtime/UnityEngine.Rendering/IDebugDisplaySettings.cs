using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class IDebugDisplaySettings : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForEach_Public_Abstract_Virtual_New_Void_Action_1_IDebugDisplaySettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_IDebugDisplaySettingsData_IDebugDisplaySettingsData_0;

	static IDebugDisplaySettings()
	{
		Il2CppClassPointerStore<IDebugDisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IDebugDisplaySettings");
		NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettings>.NativeClassPtr, 100665052);
		NativeMethodInfoPtr_ForEach_Public_Abstract_Virtual_New_Void_Action_1_IDebugDisplaySettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettings>.NativeClassPtr, 100665053);
		NativeMethodInfoPtr_Add_Public_Virtual_New_IDebugDisplaySettingsData_IDebugDisplaySettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettings>.NativeClassPtr, 100665054);
	}

	[CallerCount(0)]
	public unsafe virtual void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void ForEach(Il2CppSystem.Action<IDebugDisplaySettingsData> onExecute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onExecute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ForEach_Public_Abstract_Virtual_New_Void_Action_1_IDebugDisplaySettingsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IDebugDisplaySettingsData Add(IDebugDisplaySettingsData newData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Add_Public_Virtual_New_IDebugDisplaySettingsData_IDebugDisplaySettingsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsData>(intPtr2) : null;
	}

	public IDebugDisplaySettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
