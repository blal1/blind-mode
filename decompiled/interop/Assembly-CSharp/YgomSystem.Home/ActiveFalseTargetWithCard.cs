using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Home;

[Token(Token = "0x2000378")]
[RequireComponent(typeof(RawImage))]
public class ActiveFalseTargetWithCard : ActiveFalseTarget<RawImage>
{
	[Token(Token = "0x600157A")]
	[Address(RVA = "0x519D20", Offset = "0x518F20", VA = "0x180519D20", Slot = "4")]
	protected override bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600157B")]
	[Address(RVA = "0x519C10", Offset = "0x518E10", VA = "0x180519C10")]
	private bool IsActBindingCardMaterial(bool defaultValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600157C")]
	[Address(RVA = "0x519DB0", Offset = "0x518FB0", VA = "0x180519DB0")]
	public ActiveFalseTargetWithCard()
	{
	}
}
