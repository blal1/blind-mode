using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline;

public class ITimelineClipAsset : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Abstract_Virtual_New_get_ClipCaps_0;

	public unsafe virtual ClipCaps clipCaps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_clipCaps_Public_Abstract_Virtual_New_get_ClipCaps_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ClipCaps*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ITimelineClipAsset()
	{
		Il2CppClassPointerStore<ITimelineClipAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ITimelineClipAsset");
		NativeMethodInfoPtr_get_clipCaps_Public_Abstract_Virtual_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimelineClipAsset>.NativeClassPtr, 100664093);
	}

	public ITimelineClipAsset(IntPtr pointer)
		: base(pointer)
	{
	}
}
