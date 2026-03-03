using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine;

public class ICanvasRaycastFilter : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Abstract_Virtual_New_Boolean_Vector2_Camera_0;

	static ICanvasRaycastFilter()
	{
		Il2CppClassPointerStore<ICanvasRaycastFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "ICanvasRaycastFilter");
		NativeMethodInfoPtr_IsRaycastLocationValid_Public_Abstract_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanvasRaycastFilter>.NativeClassPtr, 100663297);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&sp);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventCamera);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsRaycastLocationValid_Public_Abstract_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ICanvasRaycastFilter(IntPtr pointer)
		: base(pointer)
	{
	}
}
