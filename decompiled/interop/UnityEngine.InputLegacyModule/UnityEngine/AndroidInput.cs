using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine;

public class AndroidInput
{
	private delegate int GetTouchCount_BindingsDelegate();

	private delegate bool IsInputDeviceEnabled_BindingsDelegate();

	private delegate int GetTouchpadWidthDelegate();

	private delegate int GetTouchpadHeightDelegate();

	private delegate void GetTouch_Bindings_InjectedDelegate(int index, [Out] IntPtr ret);

	private static readonly GetTouchCount_BindingsDelegate GetTouchCount_BindingsDelegateField = IL2CPP.ResolveICall<GetTouchCount_BindingsDelegate>("UnityEngine.AndroidInput::GetTouchCount_Bindings");

	private static readonly IsInputDeviceEnabled_BindingsDelegate IsInputDeviceEnabled_BindingsDelegateField = IL2CPP.ResolveICall<IsInputDeviceEnabled_BindingsDelegate>("UnityEngine.AndroidInput::IsInputDeviceEnabled_Bindings");

	private static readonly GetTouchpadWidthDelegate GetTouchpadWidthDelegateField = IL2CPP.ResolveICall<GetTouchpadWidthDelegate>("UnityEngine.AndroidInput::GetTouchpadWidth");

	private static readonly GetTouchpadHeightDelegate GetTouchpadHeightDelegateField = IL2CPP.ResolveICall<GetTouchpadHeightDelegate>("UnityEngine.AndroidInput::GetTouchpadHeight");

	private static readonly GetTouch_Bindings_InjectedDelegate GetTouch_Bindings_InjectedDelegateField = IL2CPP.ResolveICall<GetTouch_Bindings_InjectedDelegate>("UnityEngine.AndroidInput::GetTouch_Bindings_Injected");

	public static int touchCountSecondary => GetTouchCount_Bindings();

	public static bool secondaryTouchEnabled => IsInputDeviceEnabled_Bindings();

	public static int secondaryTouchWidth => GetTouchpadWidth();

	public static int secondaryTouchHeight => GetTouchpadHeight();

	public static Touch GetSecondaryTouch(int index)
	{
		return GetTouch_Bindings(index);
	}

	public static Touch GetTouch_Bindings(int index)
	{
		GetTouch_Bindings_Injected(index, out var ret);
		return ret;
	}

	public static int GetTouchCount_Bindings()
	{
		return GetTouchCount_BindingsDelegateField();
	}

	public static bool IsInputDeviceEnabled_Bindings()
	{
		return IsInputDeviceEnabled_BindingsDelegateField();
	}

	public static int GetTouchpadWidth()
	{
		return GetTouchpadWidthDelegateField();
	}

	public static int GetTouchpadHeight()
	{
		return GetTouchpadHeightDelegateField();
	}

	public unsafe static void GetTouch_Bindings_Injected(int index, out Touch ret)
	{
		GetTouch_Bindings_InjectedDelegateField(index, (nint)Unsafe.AsPointer(ref ret));
	}
}
