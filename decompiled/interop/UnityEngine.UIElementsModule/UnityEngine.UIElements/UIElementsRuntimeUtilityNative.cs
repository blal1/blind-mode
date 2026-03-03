using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000283")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "Unity.UIElements" })]
[UnityEngine.Bindings.NativeHeader("Modules/UIElements/Core/Native/UIElementsRuntimeUtilityNative.h")]
internal static class UIElementsRuntimeUtilityNative
{
	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x0")]
	internal static Action UpdatePanelsCallback;

	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x8")]
	internal static Action<bool> RepaintPanelsCallback;

	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x10")]
	internal static Action RenderOffscreenPanelsCallback;

	[Token(Token = "0x6001150")]
	[Address(RVA = "0x2B40B20", Offset = "0x2B3FD20", VA = "0x182B40B20")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public static void UpdatePanels()
	{
	}

	[Token(Token = "0x6001151")]
	[Address(RVA = "0x2B40A90", Offset = "0x2B3FC90", VA = "0x182B40A90")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public static void RepaintPanels(bool onlyOffscreen)
	{
	}

	[Token(Token = "0x6001152")]
	[Address(RVA = "0x2B40A40", Offset = "0x2B3FC40", VA = "0x182B40A40")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public static void RenderOffscreenPanels()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x2B40A10", Offset = "0x2B3FC10", VA = "0x182B40A10")]
	public static extern void RegisterPlayerloopCallback();

	[MethodImpl(4096)]
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x2B40AF0", Offset = "0x2B3FCF0", VA = "0x182B40AF0")]
	public static extern void UnregisterPlayerloopCallback();

	[MethodImpl(4096)]
	[Token(Token = "0x6001155")]
	[Address(RVA = "0x2B40B70", Offset = "0x2B3FD70", VA = "0x182B40B70")]
	public static extern void VisualElementCreation();
}
