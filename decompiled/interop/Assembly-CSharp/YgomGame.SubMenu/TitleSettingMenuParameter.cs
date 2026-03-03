using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.SubMenu;

[Token(Token = "0x200104B")]
public class TitleSettingMenuParameter
{
	[Token(Token = "0x400ADCF")]
	[FieldOffset(Offset = "0x10")]
	public IReadOnlyCollection<TitleSettingMenuID> menuOrder;

	[Token(Token = "0x400ADD0")]
	[FieldOffset(Offset = "0x18")]
	public Action onPreCacheClear;

	[Token(Token = "0x400ADD1")]
	[FieldOffset(Offset = "0x20")]
	public Action onPostCacheClear;

	[Token(Token = "0x60062B4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TitleSettingMenuParameter()
	{
	}
}
