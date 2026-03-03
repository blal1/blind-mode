using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.Haptics;

public class IDualMotorRumble : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetMotorSpeeds_Public_Abstract_Virtual_New_Void_Single_Single_0;

	static IDualMotorRumble()
	{
		Il2CppClassPointerStore<IDualMotorRumble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Haptics", "IDualMotorRumble");
		NativeMethodInfoPtr_SetMotorSpeeds_Public_Abstract_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDualMotorRumble>.NativeClassPtr, 100667296);
	}

	[CallerCount(0)]
	public unsafe virtual void SetMotorSpeeds(float lowFrequency, float highFrequency)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&lowFrequency);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &highFrequency;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetMotorSpeeds_Public_Abstract_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IDualMotorRumble(IntPtr pointer)
		: base(pointer)
	{
	}
}
