using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

public class IInputEventTypeInfo : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Abstract_Virtual_New_get_FourCC_0;

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_typeStatic_Public_Abstract_Virtual_New_get_FourCC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static IInputEventTypeInfo()
	{
		Il2CppClassPointerStore<IInputEventTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "IInputEventTypeInfo");
		NativeMethodInfoPtr_get_typeStatic_Public_Abstract_Virtual_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputEventTypeInfo>.NativeClassPtr, 100667475);
	}

	public IInputEventTypeInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
