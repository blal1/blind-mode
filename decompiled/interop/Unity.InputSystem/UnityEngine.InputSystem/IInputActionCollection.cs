using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class IInputActionCollection : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingMask_Public_Abstract_Virtual_New_get_Nullable_1_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bindingMask_Public_Abstract_Virtual_New_set_Void_Nullable_1_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_devices_Public_Abstract_Virtual_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_devices_Public_Abstract_Virtual_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlSchemes_Public_Abstract_Virtual_New_get_ReadOnlyArray_1_InputControlScheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Abstract_Virtual_New_Void_0;

	public unsafe virtual Il2CppSystem.Nullable<InputBinding> bindingMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_bindingMask_Public_Abstract_Virtual_New_get_Nullable_1_InputBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<InputBinding>(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_bindingMask_Public_Abstract_Virtual_New_set_Void_Nullable_1_InputBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual Il2CppSystem.Nullable<ReadOnlyArray<InputDevice>> devices
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_devices_Public_Abstract_Virtual_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<ReadOnlyArray<InputDevice>>(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_devices_Public_Abstract_Virtual_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_controlSchemes_Public_Abstract_Virtual_New_get_ReadOnlyArray_1_InputControlScheme_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputControlScheme>(pointer);
		}
	}

	static IInputActionCollection()
	{
		Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "IInputActionCollection");
		NativeMethodInfoPtr_get_bindingMask_Public_Abstract_Virtual_New_get_Nullable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_set_bindingMask_Public_Abstract_Virtual_New_set_Void_Nullable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_get_devices_Public_Abstract_Virtual_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_set_devices_Public_Abstract_Virtual_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_get_controlSchemes_Public_Abstract_Virtual_New_get_ReadOnlyArray_1_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_Enable_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_Disable_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionCollection>.NativeClassPtr, 100663593);
	}

	[CallerCount(0)]
	public unsafe virtual bool Contains(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_InputAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void Enable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Enable_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Disable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Disable_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IInputActionCollection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
