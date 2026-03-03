using System;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomGame.WCS.Portal;
using YgomSystem.UI;

namespace WCSFinal;

[Token(Token = "0x2000105")]
public class WCSFinal_ColosseumViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400067D")]
	private const string LABEL_BTN_FINALIST = "ButtonFinalist";

	[Token(Token = "0x400067E")]
	private const string LABEL_BTN_ADMIN = "ButtonAdmin";

	[Token(Token = "0x400067F")]
	private const string LABEL_BTN_REHEARSAL = "ButtonRoom";

	[Token(Token = "0x17000080")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x9E88F0", Offset = "0x9E7AF0", VA = "0x1809E88F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0x9E7CD0", Offset = "0x9E6ED0", VA = "0x1809E7CD0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0x9E7F70", Offset = "0x9E7170", VA = "0x1809E7F70", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x9E7D80", Offset = "0x9E6F80", VA = "0x1809E7D80", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x9E8010", Offset = "0x9E7210", VA = "0x1809E8010")]
	private void OpenAdminPage(WCSBattleInfoBaseViewController.ViewType viewType)
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x9E7B40", Offset = "0x9E6D40", VA = "0x1809E7B40")]
	private void CheckRehearsalRoom()
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x9E8560", Offset = "0x9E7760", VA = "0x1809E8560")]
	private void OpenRehearsalRoom()
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public WCSFinal_ColosseumViewController()
	{
	}
}
