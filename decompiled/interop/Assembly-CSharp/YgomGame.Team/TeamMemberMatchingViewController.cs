using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x2001664")]
public class TeamMemberMatchingViewController : BaseMenuViewController
{
	[Token(Token = "0x2001665")]
	protected enum Step
	{
		[Token(Token = "0x400D63C")]
		WAIT_INIT,
		[Token(Token = "0x400D63D")]
		WAIT_PRE_MATCHING,
		[Token(Token = "0x400D63E")]
		CALL_MATCHING,
		[Token(Token = "0x400D63F")]
		WAIT_MATCHING,
		[Token(Token = "0x400D640")]
		WAIT_END
	}

	[Token(Token = "0x400D630")]
	public const string PREFAB_PATH = "Team/TeamMemberMatching";

	[Token(Token = "0x400D631")]
	public const string KEY_PARENT_VIEW = "parent_view";

	[Token(Token = "0x400D632")]
	public const string KEY_DECK_ID = "deck_id";

	[Token(Token = "0x400D633")]
	public const string KEY_REGULATION_ID = "regulation_id";

	[Token(Token = "0x400D634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string E_ButtonCancel;

	[Token(Token = "0x400D635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string E_TextSearching;

	[Token(Token = "0x400D636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected Step m_Step;

	[Token(Token = "0x400D637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ViewController parentView;

	[Token(Token = "0x400D638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool isRequestCancel;

	[Token(Token = "0x400D639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private SelectionButton backBtn;

	[Token(Token = "0x400D63A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int callCount;

	[Token(Token = "0x17001543")]
	protected Step step
	{
		[Token(Token = "0x6008B4A")]
		[Address(RVA = "0x746560", Offset = "0x745760", VA = "0x180746560")]
		get
		{
			return default(Step);
		}
		[Token(Token = "0x6008B4B")]
		[Address(RVA = "0xA2A4F0", Offset = "0xA296F0", VA = "0x180A2A4F0")]
		set
		{
		}
	}

	[Token(Token = "0x6008B4C")]
	[Address(RVA = "0xD68B10", Offset = "0xD67D10", VA = "0x180D68B10")]
	public static void Open(ViewControllerManager manager, ViewController parentView, int deck_id = 0, int regulation_id = 0)
	{
	}

	[Token(Token = "0x6008B4D")]
	[Address(RVA = "0xD65A70", Offset = "0xD64C70", VA = "0x180D65A70", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008B4E")]
	[Address(RVA = "0xD68AF0", Offset = "0xD67CF0", VA = "0x180D68AF0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008B4F")]
	[Address(RVA = "0xD68660", Offset = "0xD67860", VA = "0x180D68660")]
	private void Init()
	{
	}

	[Token(Token = "0x6008B50")]
	[Address(RVA = "0xD68590", Offset = "0xD67790", VA = "0x180D68590")]
	private void Update()
	{
	}

	[Token(Token = "0x6008B51")]
	[Address(RVA = "0xD68590", Offset = "0xD67790", VA = "0x180D68590")]
	private void EvalEachSteps()
	{
	}

	[Token(Token = "0x6008B52")]
	[Address(RVA = "0xB0D230", Offset = "0xB0C430", VA = "0x180B0D230")]
	private void CallAPIDeckSet(int deckId, int regulationId, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x6008B53")]
	[Address(RVA = "0xD684E0", Offset = "0xD676E0", VA = "0x180D684E0")]
	private void CallAPIMatching()
	{
	}

	[Token(Token = "0x6008B54")]
	[Address(RVA = "0xD68C70", Offset = "0xD67E70", VA = "0x180D68C70")]
	private void ReCallMatching()
	{
	}

	[Token(Token = "0x6008B55")]
	[Address(RVA = "0xD68A70", Offset = "0xD67C70", VA = "0x180D68A70")]
	private void NotFindTeam()
	{
	}

	[Token(Token = "0x6008B56")]
	[Address(RVA = "0xD691F0", Offset = "0xD683F0", VA = "0x180D691F0")]
	public TeamMemberMatchingViewController()
	{
	}
}
