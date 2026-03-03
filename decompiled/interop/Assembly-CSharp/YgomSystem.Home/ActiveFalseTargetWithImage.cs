using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Home;

[Token(Token = "0x200037A")]
[RequireComponent(typeof(Image))]
public class ActiveFalseTargetWithImage : ActiveFalseTarget<Image>
{
	[Token(Token = "0x600157F")]
	[Address(RVA = "0x519DF0", Offset = "0x518FF0", VA = "0x180519DF0", Slot = "4")]
	protected override bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6001580")]
	[Address(RVA = "0x519F00", Offset = "0x519100", VA = "0x180519F00")]
	public ActiveFalseTargetWithImage()
	{
	}
}
