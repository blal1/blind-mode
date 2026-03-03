using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering;

public class IDefaultVolumeProfileAsset : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_defaultVolumeProfile_Public_Abstract_Virtual_New_get_VolumeProfile_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_defaultVolumeProfile_Public_Abstract_Virtual_New_set_Void_VolumeProfile_0;

	public unsafe virtual VolumeProfile defaultVolumeProfile
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_defaultVolumeProfile_Public_Abstract_Virtual_New_get_VolumeProfile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_defaultVolumeProfile_Public_Abstract_Virtual_New_set_Void_VolumeProfile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static IDefaultVolumeProfileAsset()
	{
		Il2CppClassPointerStore<IDefaultVolumeProfileAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IDefaultVolumeProfileAsset");
		NativeMethodInfoPtr_get_defaultVolumeProfile_Public_Abstract_Virtual_New_get_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDefaultVolumeProfileAsset>.NativeClassPtr, 100666029);
		NativeMethodInfoPtr_set_defaultVolumeProfile_Public_Abstract_Virtual_New_set_Void_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDefaultVolumeProfileAsset>.NativeClassPtr, 100666030);
	}

	public IDefaultVolumeProfileAsset(IntPtr pointer)
		: base(pointer)
	{
	}
}
