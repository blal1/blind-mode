using System;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x20003E0")]
public static class KeyCommandUtil
{
	[Token(Token = "0x400137A")]
	[FieldOffset(Offset = "0x0")]
	private static KeyCommandSetting setting;

	[Token(Token = "0x400137B")]
	private const string settingPath = "ScriptableObjects/KeyCommand/KeyCommandSetting";

	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x5CE400", Offset = "0x5CD600", VA = "0x1805CE400")]
	public static void Initialize(Action<KeyCommandSetting> onFinished)
	{
	}

	[Token(Token = "0x60018F9")]
	[Address(RVA = "0x5CE350", Offset = "0x5CD550", VA = "0x1805CE350")]
	public static KeyCommandSetting.KeyCommandInfo GetInfo(string label)
	{
		return null;
	}

	[Token(Token = "0x60018FA")]
	[Address(RVA = "0x5CE220", Offset = "0x5CD420", VA = "0x1805CE220")]
	public static KeyCommand Begin(string settingLabel, Action<KeyCommand.OnKeyResult> onSetKeyCallback)
	{
		return null;
	}

	[Token(Token = "0x60018FB")]
	[Address(RVA = "0x5CE550", Offset = "0x5CD750", VA = "0x1805CE550")]
	public static void SetupKeyCommandReceiver(KeyCommand keyCommand, SelectionItem target)
	{
	}

	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x5CE600", Offset = "0x5CD800", VA = "0x1805CE600")]
	private static void SetupKeyCommandShortcut(KeyCommand keyCommand, SelectionItem target, SelectorManager.KeyType keyType)
	{
	}
}
