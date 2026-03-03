using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct TouchScreenKeyboard_InternalConstructorHelperArguments
{
	private static readonly System.IntPtr NativeFieldInfoPtr_keyboardType;

	private static readonly System.IntPtr NativeFieldInfoPtr_autocorrection;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiline;

	private static readonly System.IntPtr NativeFieldInfoPtr_secure;

	private static readonly System.IntPtr NativeFieldInfoPtr_alert;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterLimit;

	[FieldOffset(0)]
	public uint keyboardType;

	[FieldOffset(4)]
	public uint autocorrection;

	[FieldOffset(8)]
	public uint multiline;

	[FieldOffset(12)]
	public uint secure;

	[FieldOffset(16)]
	public uint alert;

	[FieldOffset(20)]
	public int characterLimit;

	static TouchScreenKeyboard_InternalConstructorHelperArguments()
	{
		Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard_InternalConstructorHelperArguments");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr);
		NativeFieldInfoPtr_keyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "keyboardType");
		NativeFieldInfoPtr_autocorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "autocorrection");
		NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "multiline");
		NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "secure");
		NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "alert");
		NativeFieldInfoPtr_characterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "characterLimit");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
