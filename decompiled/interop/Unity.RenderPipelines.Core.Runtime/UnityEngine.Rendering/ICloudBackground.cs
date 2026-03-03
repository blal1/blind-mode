using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

public class ICloudBackground : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_IsCloudBackgroundUsable_Public_Abstract_Virtual_New_Boolean_0;

	static ICloudBackground()
	{
		Il2CppClassPointerStore<ICloudBackground>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ICloudBackground");
		NativeMethodInfoPtr_IsCloudBackgroundUsable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICloudBackground>.NativeClassPtr, 100666013);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsCloudBackgroundUsable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsCloudBackgroundUsable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ICloudBackground(IntPtr pointer)
		: base(pointer)
	{
	}
}
