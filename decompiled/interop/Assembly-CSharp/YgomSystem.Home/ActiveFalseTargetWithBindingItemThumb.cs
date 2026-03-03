using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;

namespace YgomSystem.Home;

[Token(Token = "0x2000376")]
[RequireComponent(typeof(BindingItemThumb))]
public class ActiveFalseTargetWithBindingItemThumb : ActiveFalseTarget<BindingItemThumb>
{
	[Token(Token = "0x6001576")]
	[Address(RVA = "0x5199B0", Offset = "0x518BB0", VA = "0x1805199B0", Slot = "4")]
	protected override bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6001577")]
	[Address(RVA = "0x5199E0", Offset = "0x518BE0", VA = "0x1805199E0")]
	public ActiveFalseTargetWithBindingItemThumb()
	{
	}
}
