using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI;

public class IGraphicEnabledDisabled : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0;

	static IGraphicEnabledDisabled()
	{
		Il2CppClassPointerStore<IGraphicEnabledDisabled>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IGraphicEnabledDisabled");
		NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGraphicEnabledDisabled>.NativeClassPtr, 100663613);
	}

	[CallerCount(0)]
	public unsafe virtual void OnSiblingGraphicEnabledDisabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IGraphicEnabledDisabled(IntPtr pointer)
		: base(pointer)
	{
	}
}
