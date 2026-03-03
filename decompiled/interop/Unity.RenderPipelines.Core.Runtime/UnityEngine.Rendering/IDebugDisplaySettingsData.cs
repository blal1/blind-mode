using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering;

public class IDebugDisplaySettingsData : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_CreatePanel_Public_Abstract_Virtual_New_IDebugDisplaySettingsPanelDisposable_0;

	static IDebugDisplaySettingsData()
	{
		Il2CppClassPointerStore<IDebugDisplaySettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IDebugDisplaySettingsData");
		NativeMethodInfoPtr_CreatePanel_Public_Abstract_Virtual_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugDisplaySettingsData>.NativeClassPtr, 100665055);
	}

	[CallerCount(0)]
	public unsafe virtual IDebugDisplaySettingsPanelDisposable CreatePanel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreatePanel_Public_Abstract_Virtual_New_IDebugDisplaySettingsPanelDisposable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr2) : null;
	}

	public IDebugDisplaySettingsData(IntPtr pointer)
		: base(pointer)
	{
	}
}
