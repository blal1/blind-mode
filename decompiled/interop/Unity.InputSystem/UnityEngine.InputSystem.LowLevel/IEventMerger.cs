using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.LowLevel;

public class IEventMerger : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_MergeForward_Public_Abstract_Virtual_New_Boolean_InputEventPtr_InputEventPtr_0;

	static IEventMerger()
	{
		Il2CppClassPointerStore<IEventMerger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "IEventMerger");
		NativeMethodInfoPtr_MergeForward_Public_Abstract_Virtual_New_Boolean_InputEventPtr_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventMerger>.NativeClassPtr, 100667383);
	}

	[CallerCount(0)]
	public unsafe virtual bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&currentEventPtr);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nextEventPtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MergeForward_Public_Abstract_Virtual_New_Boolean_InputEventPtr_InputEventPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IEventMerger(IntPtr pointer)
		: base(pointer)
	{
	}
}
