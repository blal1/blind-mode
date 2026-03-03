using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.XInput;

public class XInputControllerWindows : XInputController
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XInputControllerWindows()
	{
		Il2CppClassPointerStore<XInputControllerWindows>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XInput", "XInputControllerWindows");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XInputControllerWindows>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputControllerWindows>.NativeClassPtr, 100666564);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 963305, RefRangeEnd = 963314, XrefRangeStart = 963305, XrefRangeEnd = 963314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XInputControllerWindows()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XInputControllerWindows>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XInputControllerWindows(IntPtr pointer)
		: base(pointer)
	{
	}
}
