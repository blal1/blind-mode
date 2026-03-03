using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001495")]
public class RarityIconBinder : ResourceBinderBase
{
	[Token(Token = "0x2001496")]
	public enum Type
	{
		[Token(Token = "0x400C6FB")]
		Common,
		[Token(Token = "0x400C6FC")]
		Deck
	}

	[Token(Token = "0x400C6F8")]
	[FieldOffset(Offset = "0x10")]
	public readonly string[] rarityLabelCommonFormat;

	[Token(Token = "0x400C6F9")]
	[FieldOffset(Offset = "0x18")]
	public readonly string[] rarityLabelDeckFormat;

	[Token(Token = "0x6007FCD")]
	[Address(RVA = "0xC79EA0", Offset = "0xC790A0", VA = "0x180C79EA0")]
	public string GetRarityIconLabel(int id, Type type)
	{
		return null;
	}

	[Token(Token = "0x6007FCE")]
	[Address(RVA = "0xC79C00", Offset = "0xC78E00", VA = "0x180C79C00")]
	public BindingSpriteContainer BindRarityIcon(GameObject target, int id, bool async = true, Type type = Type.Common)
	{
		return null;
	}

	[Token(Token = "0x6007FCF")]
	[Address(RVA = "0xC79D60", Offset = "0xC78F60", VA = "0x180C79D60")]
	public BindingSpriteContainer BindRarityIcon(Image target, int id, bool async = true, Type type = Type.Common)
	{
		return null;
	}

	[Token(Token = "0x6007FD0")]
	[Address(RVA = "0xC79F20", Offset = "0xC79120", VA = "0x180C79F20")]
	public void GetRaritySprite(int id, Type type, Action<Sprite> onFinished)
	{
	}

	[Token(Token = "0x6007FD1")]
	[Address(RVA = "0xC7A030", Offset = "0xC79230", VA = "0x180C7A030")]
	public RarityIconBinder()
	{
	}
}
