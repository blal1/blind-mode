using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputForUI;

public class IEventProperties : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_eventSource_Public_Abstract_Virtual_New_get_EventSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_eventModifiers_Public_Abstract_Virtual_New_get_EventModifiers_0;

	public unsafe virtual EventSource eventSource
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_eventSource_Public_Abstract_Virtual_New_get_EventSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual EventModifiers eventModifiers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_eventModifiers_Public_Abstract_Virtual_New_get_EventModifiers_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventModifiers*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static IEventProperties()
	{
		Il2CppClassPointerStore<IEventProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "IEventProperties");
		NativeMethodInfoPtr_get_eventSource_Public_Abstract_Virtual_New_get_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventProperties>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_get_eventModifiers_Public_Abstract_Virtual_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventProperties>.NativeClassPtr, 100663343);
	}

	public IEventProperties(IntPtr pointer)
		: base(pointer)
	{
	}
}
