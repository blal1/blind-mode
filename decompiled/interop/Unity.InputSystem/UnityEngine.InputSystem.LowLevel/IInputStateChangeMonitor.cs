using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.LowLevel;

public class IInputStateChangeMonitor : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_NotifyControlStateChanged_Public_Abstract_Virtual_New_Void_InputControl_Double_InputEventPtr_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_NotifyTimerExpired_Public_Abstract_Virtual_New_Void_InputControl_Double_Int64_Int32_0;

	static IInputStateChangeMonitor()
	{
		Il2CppClassPointerStore<IInputStateChangeMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "IInputStateChangeMonitor");
		NativeMethodInfoPtr_NotifyControlStateChanged_Public_Abstract_Virtual_New_Void_InputControl_Double_InputEventPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputStateChangeMonitor>.NativeClassPtr, 100667799);
		NativeMethodInfoPtr_NotifyTimerExpired_Public_Abstract_Virtual_New_Void_InputControl_Double_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputStateChangeMonitor>.NativeClassPtr, 100667800);
	}

	[CallerCount(0)]
	public unsafe virtual void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &time;
		*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &eventPtr;
		*(long**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &monitorIndex;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NotifyControlStateChanged_Public_Abstract_Virtual_New_Void_InputControl_Double_InputEventPtr_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &time;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &monitorIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &timerIndex;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NotifyTimerExpired_Public_Abstract_Virtual_New_Void_InputControl_Double_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IInputStateChangeMonitor(IntPtr pointer)
		: base(pointer)
	{
	}
}
