using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000264")]
internal static class GroupBoxUtility
{
	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers;

	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache;

	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Type k_GenericGroupBoxType;

	[Token(Token = "0x60010D5")]
	public static void RegisterGroupBoxOption<T>(this T option) where T : VisualElement, IGroupBoxOption
	{
	}

	[Token(Token = "0x60010D6")]
	public static void UnregisterGroupBoxOption<T>(this T option) where T : VisualElement, IGroupBoxOption
	{
	}

	[Token(Token = "0x60010D7")]
	public static void OnOptionSelected<T>(this T selectedOption) where T : VisualElement, IGroupBoxOption
	{
	}

	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x2B2DCB0", Offset = "0x2B2CEB0", VA = "0x182B2DCB0")]
	private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox)
	{
		return null;
	}

	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x2B2E1F0", Offset = "0x2B2D3F0", VA = "0x182B2E1F0")]
	private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x2B2E2B0", Offset = "0x2B2D4B0", VA = "0x182B2E2B0")]
	private static void OnPanelDestroyed(BaseVisualElementPanel panel)
	{
	}
}
