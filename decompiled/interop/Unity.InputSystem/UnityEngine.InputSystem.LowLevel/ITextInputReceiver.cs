using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.LowLevel;

public class ITextInputReceiver : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnTextInput_Public_Abstract_Virtual_New_Void_Char_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnIMECompositionChanged_Public_Abstract_Virtual_New_Void_IMECompositionString_0;

	static ITextInputReceiver()
	{
		Il2CppClassPointerStore<ITextInputReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "ITextInputReceiver");
		NativeMethodInfoPtr_OnTextInput_Public_Abstract_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextInputReceiver>.NativeClassPtr, 100667386);
		NativeMethodInfoPtr_OnIMECompositionChanged_Public_Abstract_Virtual_New_Void_IMECompositionString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextInputReceiver>.NativeClassPtr, 100667387);
	}

	[CallerCount(0)]
	public unsafe virtual void OnTextInput(char character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&character);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnTextInput_Public_Abstract_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void OnIMECompositionChanged(IMECompositionString compositionString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&compositionString);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnIMECompositionChanged_Public_Abstract_Virtual_New_Void_IMECompositionString_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ITextInputReceiver(IntPtr pointer)
		: base(pointer)
	{
	}
}
