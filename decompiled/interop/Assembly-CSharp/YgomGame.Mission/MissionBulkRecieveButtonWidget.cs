using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission;

[Token(Token = "0x2000C05")]
public class MissionBulkRecieveButtonWidget : ElementWidgetBase
{
	[Token(Token = "0x4009989")]
	[FieldOffset(Offset = "0x20")]
	public readonly SelectionButton button;

	[Token(Token = "0x400998A")]
	[FieldOffset(Offset = "0x28")]
	public readonly GameObject numBadge;

	[Token(Token = "0x400998B")]
	[FieldOffset(Offset = "0x30")]
	public readonly TMP_Text numBadgeText;

	[Token(Token = "0x6004937")]
	[Address(RVA = "0x91AC20", Offset = "0x919E20", VA = "0x18091AC20")]
	public MissionBulkRecieveButtonWidget(ElementObjectManager eom)
	{
	}
}
