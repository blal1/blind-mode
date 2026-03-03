using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables;

public class INotification : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0;

	public unsafe virtual PropertyName id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PropertyName*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static INotification()
	{
		Il2CppClassPointerStore<INotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "INotification");
		NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotification>.NativeClassPtr, 100667389);
	}

	public INotification(IntPtr pointer)
		: base(pointer)
	{
	}
}
