using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;

namespace YgomSystem.Home;

[Token(Token = "0x2000379")]
[RequireComponent(typeof(BindingCardFile))]
public class ActiveFalseTargetWithCardFile : ActiveFalseTarget<BindingCardFile>
{
	[Token(Token = "0x600157D")]
	[Address(RVA = "0x519BB0", Offset = "0x518DB0", VA = "0x180519BB0", Slot = "4")]
	protected override bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600157E")]
	[Address(RVA = "0x519BD0", Offset = "0x518DD0", VA = "0x180519BD0")]
	public ActiveFalseTargetWithCardFile()
	{
	}
}
