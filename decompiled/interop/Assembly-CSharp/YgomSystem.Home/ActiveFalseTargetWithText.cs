using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.YGomTMPro;

namespace YgomSystem.Home;

[Token(Token = "0x200037C")]
[RequireComponent(typeof(ExtendedTextMeshProUGUI))]
public class ActiveFalseTargetWithText : ActiveFalseTarget<ExtendedTextMeshProUGUI>
{
	[Token(Token = "0x6001583")]
	[Address(RVA = "0x51A040", Offset = "0x519240", VA = "0x18051A040", Slot = "4")]
	protected override bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6001584")]
	[Address(RVA = "0x51A080", Offset = "0x519280", VA = "0x18051A080")]
	public ActiveFalseTargetWithText()
	{
	}
}
