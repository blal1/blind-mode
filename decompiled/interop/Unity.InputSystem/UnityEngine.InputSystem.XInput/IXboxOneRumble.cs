using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.XInput;

public class IXboxOneRumble : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetMotorSpeeds_Public_Abstract_Virtual_New_Void_Single_Single_Single_Single_0;

	static IXboxOneRumble()
	{
		Il2CppClassPointerStore<IXboxOneRumble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XInput", "IXboxOneRumble");
		NativeMethodInfoPtr_SetMotorSpeeds_Public_Abstract_Virtual_New_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXboxOneRumble>.NativeClassPtr, 100666554);
	}

	[CallerCount(0)]
	public unsafe virtual void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&lowFrequency);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &highFrequency;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &leftTrigger;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &rightTrigger;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetMotorSpeeds_Public_Abstract_Virtual_New_Void_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IXboxOneRumble(IntPtr pointer)
		: base(pointer)
	{
	}
}
