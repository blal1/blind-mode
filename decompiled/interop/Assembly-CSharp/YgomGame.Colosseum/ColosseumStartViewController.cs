using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CDD")]
public class ColosseumStartViewController : BaseMenuViewController
{
	[Token(Token = "0x2001CDE")]
	public enum PrefabType
	{
		[Token(Token = "0x401011C")]
		STANDARD,
		[Token(Token = "0x401011D")]
		TOURNAMENT,
		[Token(Token = "0x401011E")]
		WCS,
		[Token(Token = "0x401011F")]
		TOURNAMENT_NOMESSAGE
	}

	[Token(Token = "0x401010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string BTN_CLOSE_LABEL;

	[Token(Token = "0x4010110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string IMG_TOURNAMENT_LABEL;

	[Token(Token = "0x4010111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string TXT_NAME_LABEL;

	[Token(Token = "0x4010112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string E_TextDescription;

	[Token(Token = "0x4010113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string E_Logo;

	[Token(Token = "0x4010114")]
	private const string KEY_NAME = "TournamentName";

	[Token(Token = "0x4010115")]
	private const string KEY_LOGO = "LogoId";

	[Token(Token = "0x4010116")]
	private const string KEY_TYPE = "PrefabType";

	[Token(Token = "0x4010117")]
	private const string KEY_IDENTIFIER = "Identifier";

	[Token(Token = "0x4010118")]
	public const string KEY_ENDACTION_QUEUE = "EndActionQueue";

	[Token(Token = "0x4010119")]
	public const string KEY_ENDACTION = "EndAction";

	[Token(Token = "0x401011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private PrefabType prefabType;

	[Token(Token = "0x17001BF1")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600BA86")]
		[Address(RVA = "0x554620", Offset = "0x553820", VA = "0x180554620", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BA87")]
	[Address(RVA = "0x553C20", Offset = "0x552E20", VA = "0x180553C20")]
	public static void Open(PrefabType prefabType, string tournamentName = "", int logoId = 0, int identifier = 0, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x600BA88")]
	[Address(RVA = "0x553300", Offset = "0x552500", VA = "0x180553300", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600BA89")]
	[Address(RVA = "0x5537A0", Offset = "0x5529A0", VA = "0x1805537A0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600BA8A")]
	[Address(RVA = "0x5535B0", Offset = "0x5527B0", VA = "0x1805535B0")]
	private void OnClickBackButton()
	{
	}

	[Token(Token = "0x600BA8B")]
	[Address(RVA = "0x553E00", Offset = "0x553000", VA = "0x180553E00")]
	private void UpdateStandardView()
	{
	}

	[Token(Token = "0x600BA8C")]
	[Address(RVA = "0x554170", Offset = "0x553370", VA = "0x180554170")]
	private void UpdateTouramentView()
	{
	}

	[Token(Token = "0x600BA8D")]
	[Address(RVA = "0x5543C0", Offset = "0x5535C0", VA = "0x1805543C0")]
	private void UpdateWCSView()
	{
	}

	[Token(Token = "0x600BA8E")]
	[Address(RVA = "0x553F70", Offset = "0x553170", VA = "0x180553F70")]
	private void UpdateTouramentNoMessageView()
	{
	}

	[Token(Token = "0x600BA8F")]
	[Address(RVA = "0x553210", Offset = "0x552410", VA = "0x180553210")]
	private string GetStandardPath()
	{
		return null;
	}

	[Token(Token = "0x600BA90")]
	[Address(RVA = "0x554510", Offset = "0x553710", VA = "0x180554510")]
	public ColosseumStartViewController()
	{
	}
}
