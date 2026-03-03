using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.LowLevel;

public class IEventPreProcessor : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_PreProcessEvent_Public_Abstract_Virtual_New_Boolean_InputEventPtr_0;

	static IEventPreProcessor()
	{
		Il2CppClassPointerStore<IEventPreProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "IEventPreProcessor");
		NativeMethodInfoPtr_PreProcessEvent_Public_Abstract_Virtual_New_Boolean_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventPreProcessor>.NativeClassPtr, 100667384);
	}

	[CallerCount(0)]
	public unsafe virtual bool PreProcessEvent(InputEventPtr currentEventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&currentEventPtr);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PreProcessEvent_Public_Abstract_Virtual_New_Boolean_InputEventPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IEventPreProcessor(IntPtr pointer)
		: base(pointer)
	{
	}
}
