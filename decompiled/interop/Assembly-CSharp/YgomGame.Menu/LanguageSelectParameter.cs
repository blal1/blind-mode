using System;
using Il2CppDummyDll;
using YgomGame.TextIDs;

namespace YgomGame.Menu;

[Token(Token = "0x20012F3")]
public class LanguageSelectParameter
{
	[Token(Token = "0x400BE6F")]
	[FieldOffset(Offset = "0x10")]
	public IDS_SYS decisionButtonTextID;

	[Token(Token = "0x400BE70")]
	[FieldOffset(Offset = "0x14")]
	public bool disableBackButton;

	[Token(Token = "0x400BE71")]
	[FieldOffset(Offset = "0x18")]
	public int selectorPriority;

	[Token(Token = "0x400BE72")]
	[FieldOffset(Offset = "0x20")]
	public Action<string> resultCallback;

	[Token(Token = "0x60075BD")]
	[Address(RVA = "0xBC1890", Offset = "0xBC0A90", VA = "0x180BC1890")]
	public LanguageSelectParameter()
	{
	}
}
