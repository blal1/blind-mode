using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x2000772")]
public class WCSLeagueInfoView : WCSBattleInfoBaseViewController.View
{
	[Token(Token = "0x400254C")]
	private const string LABEL_OVERRIDER_DEFAULT = "Default";

	[Token(Token = "0x400254D")]
	private const string LABEL_OVERRIDER_WCS = "WCS";

	[Token(Token = "0x400254E")]
	[FieldOffset(Offset = "0x38")]
	private readonly int _teamMaxInTable;

	[Token(Token = "0x400254F")]
	[FieldOffset(Offset = "0x40")]
	private readonly WCSLeagueGroupPanel[] _tableList;

	[Token(Token = "0x4002550")]
	[FieldOffset(Offset = "0x48")]
	private readonly ElementObjectManager _topEom;

	[Token(Token = "0x4002551")]
	[FieldOffset(Offset = "0x50")]
	private readonly SelectionButton _ruleButton;

	[Token(Token = "0x60030D8")]
	[Address(RVA = "0x73D2E0", Offset = "0x73C4E0", VA = "0x18073D2E0")]
	public WCSLeagueInfoView(ElementObjectManager topEom, ElementObjectManager scrollEom, ViewControllerManager manager, Def.LeagueLayoutType layout, bool helpBtnInvisible, bool isAdmin)
	{
	}

	[Token(Token = "0x60030D9")]
	[Address(RVA = "0x73D230", Offset = "0x73C430", VA = "0x18073D230", Slot = "4")]
	public override void Terminate()
	{
	}

	[Token(Token = "0x60030DA")]
	[Address(RVA = "0x73C830", Offset = "0x73BA30", VA = "0x18073C830", Slot = "5")]
	protected override void ApplyFromCW(object baseData)
	{
	}

	[Token(Token = "0x60030DB")]
	[Address(RVA = "0x73D1C0", Offset = "0x73C3C0", VA = "0x18073D1C0")]
	private void OpenExplanationPage()
	{
	}

	[Token(Token = "0x60030DC")]
	[Address(RVA = "0x738520", Offset = "0x737720", VA = "0x180738520")]
	private void OpenDuelRoom(int roomId)
	{
	}
}
