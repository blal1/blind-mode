using System;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EF3")]
public class DuelLiveImportSettingData
{
	[Token(Token = "0x400A57B")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x400A57C")]
	[FieldOffset(Offset = "0x18")]
	public KeyValueString[] stringArray;

	[Token(Token = "0x400A57D")]
	[FieldOffset(Offset = "0x20")]
	public KeyValueList[] listArray;

	[Token(Token = "0x6005AA6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveImportSettingData()
	{
	}
}
