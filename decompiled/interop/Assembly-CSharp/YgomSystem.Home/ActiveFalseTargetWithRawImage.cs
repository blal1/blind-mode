using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Home;

[Token(Token = "0x200037B")]
[RequireComponent(typeof(RawImage))]
public class ActiveFalseTargetWithRawImage : ActiveFalseTarget<RawImage>
{
	[Token(Token = "0x6001581")]
	[Address(RVA = "0x519F40", Offset = "0x519140", VA = "0x180519F40", Slot = "4")]
	protected override bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6001582")]
	[Address(RVA = "0x51A000", Offset = "0x519200", VA = "0x18051A000")]
	public ActiveFalseTargetWithRawImage()
	{
	}
}
