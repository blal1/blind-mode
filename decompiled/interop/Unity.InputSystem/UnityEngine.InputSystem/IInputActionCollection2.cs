using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.InputSystem;

public class IInputActionCollection2 : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_bindings_Public_Abstract_Virtual_New_get_IEnumerable_1_InputBinding_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindAction_Public_Abstract_Virtual_New_InputAction_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindBinding_Public_Abstract_Virtual_New_Int32_InputBinding_byref_InputAction_0;

	public unsafe virtual IEnumerable<InputBinding> bindings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_bindings_Public_Abstract_Virtual_New_get_IEnumerable_1_InputBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<InputBinding>>(intPtr2) : null;
		}
	}

	static IInputActionCollection2()
	{
		Il2CppClassPointerStore<IInputActionCollection2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "IInputActionCollection2");
		NativeMethodInfoPtr_get_bindings_Public_Abstract_Virtual_New_get_IEnumerable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection2>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_FindAction_Public_Abstract_Virtual_New_InputAction_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection2>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_FindBinding_Public_Abstract_Virtual_New_Int32_InputBinding_byref_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection2>.NativeClassPtr, 100663596);
	}

	[CallerCount(0)]
	public unsafe virtual InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionNameOrId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &throwIfNotFound;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FindAction_Public_Abstract_Virtual_New_InputAction_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual int FindBinding(InputBinding mask, out InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mask));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FindBinding_Public_Abstract_Virtual_New_Int32_InputBinding_byref_InputAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		action = ((num3 == 0) ? null : new InputAction(num3));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IInputActionCollection2(IntPtr pointer)
		: base(pointer)
	{
	}
}
