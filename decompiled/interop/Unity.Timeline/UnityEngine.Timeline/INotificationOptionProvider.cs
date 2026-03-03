using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline;

public class INotificationOptionProvider : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_flags_Public_Abstract_Virtual_New_get_NotificationFlags_0;

	public unsafe virtual NotificationFlags flags
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_flags_Public_Abstract_Virtual_New_get_NotificationFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(NotificationFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static INotificationOptionProvider()
	{
		Il2CppClassPointerStore<INotificationOptionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "INotificationOptionProvider");
		NativeMethodInfoPtr_get_flags_Public_Abstract_Virtual_New_get_NotificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationOptionProvider>.NativeClassPtr, 100663930);
	}

	public INotificationOptionProvider(IntPtr pointer)
		: base(pointer)
	{
	}
}
