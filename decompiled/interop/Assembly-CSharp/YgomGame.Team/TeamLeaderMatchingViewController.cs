using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x2001658")]
public class TeamLeaderMatchingViewController : BaseMenuViewController
{
	[Token(Token = "0x2001659")]
	protected enum Step
	{
		[Token(Token = "0x400D5F7")]
		WAIT_INIT,
		[Token(Token = "0x400D5F8")]
		WAIT_PRE_MATCHING,
		[Token(Token = "0x400D5F9")]
		CALL_MATCHING,
		[Token(Token = "0x400D5FA")]
		WAIT_MATCHING,
		[Token(Token = "0x400D5FB")]
		WAIT_END
	}

	[Token(Token = "0x400D5EF")]
	public const string PREFAB_PATH = "Team/TeamLeaderMatching";

	[Token(Token = "0x400D5F0")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string E_ButtonCancel;

	[Token(Token = "0x400D5F1")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string E_TextSearching;

	[Token(Token = "0x400D5F2")]
	[FieldOffset(Offset = "0xE0")]
	protected Step m_Step;

	[Token(Token = "0x400D5F3")]
	[FieldOffset(Offset = "0xE4")]
	private bool isRequestCancel;

	[Token(Token = "0x400D5F4")]
	[FieldOffset(Offset = "0xE8")]
	private SelectionButton backBtn;

	[Token(Token = "0x400D5F5")]
	[FieldOffset(Offset = "0xF0")]
	private int callCount;

	[Token(Token = "0x17001537")]
	protected Step step
	{
		[Token(Token = "0x6008AFF")]
		[Address(RVA = "0x746560", Offset = "0x745760", VA = "0x180746560")]
		get
		{
			return default(Step);
		}
		[Token(Token = "0x6008B00")]
		[Address(RVA = "0xA2A4F0", Offset = "0xA296F0", VA = "0x180A2A4F0")]
		set
		{
		}
	}

	[Token(Token = "0x6008B01")]
	[Address(RVA = "0xD65AC0", Offset = "0xD64CC0", VA = "0x180D65AC0")]
	public static void Open(ViewControllerManager manager)
	{
	}

	[Token(Token = "0x6008B02")]
	[Address(RVA = "0xD65A70", Offset = "0xD64C70", VA = "0x180D65A70", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008B03")]
	[Address(RVA = "0xD65AA0", Offset = "0xD64CA0", VA = "0x180D65AA0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008B04")]
	[Address(RVA = "0xD65780", Offset = "0xD64980", VA = "0x180D65780")]
	private void Init()
	{
	}

	[Token(Token = "0x6008B05")]
	[Address(RVA = "0xD656B0", Offset = "0xD648B0", VA = "0x180D656B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6008B06")]
	[Address(RVA = "0xD656B0", Offset = "0xD648B0", VA = "0x180D656B0")]
	private void EvalEachSteps()
	{
	}

	[Token(Token = "0x6008B07")]
	[Address(RVA = "0xD65610", Offset = "0xD64810", VA = "0x180D65610")]
	private void CallAPIMatching()
	{
	}

	[Token(Token = "0x6008B08")]
	[Address(RVA = "0xD659D0", Offset = "0xD64BD0", VA = "0x180D659D0")]
	private void NotFindMember()
	{
	}

	[Token(Token = "0x6008B09")]
	[Address(RVA = "0xD65D90", Offset = "0xD64F90", VA = "0x180D65D90")]
	public TeamLeaderMatchingViewController()
	{
	}
}
