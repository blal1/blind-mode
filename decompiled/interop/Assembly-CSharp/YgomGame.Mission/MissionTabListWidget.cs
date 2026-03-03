using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Mission;

[Token(Token = "0x2000C15")]
public class MissionTabListWidget : ElementWidgetBase
{
	[Token(Token = "0x4009A16")]
	[FieldOffset(Offset = "0x20")]
	public readonly InfinityScrollView scrollView;

	[Token(Token = "0x4009A17")]
	[FieldOffset(Offset = "0x28")]
	public readonly ScrollRect scrollRect;

	[Token(Token = "0x170009F5")]
	public bool isSelected
	{
		[Token(Token = "0x60049B3")]
		[Address(RVA = "0x941230", Offset = "0x940430", VA = "0x180941230")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60049B4")]
	[Address(RVA = "0x941190", Offset = "0x940390", VA = "0x180941190")]
	public MissionTabListWidget(ElementObjectManager eom)
	{
	}
}
