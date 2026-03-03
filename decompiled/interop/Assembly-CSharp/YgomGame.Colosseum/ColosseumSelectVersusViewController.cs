using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CDA")]
public class ColosseumSelectVersusViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x40100F9")]
	public const string PREF_PATH = "Colosseum/ColosseumSelectVersus";

	[Token(Token = "0x40100FA")]
	private const string E_RootButton = "RootButton";

	[Token(Token = "0x40100FB")]
	private const string E_Button = "Button";

	[Token(Token = "0x40100FC")]
	private const string E_Image = "Image";

	[Token(Token = "0x40100FD")]
	private const string E_ImageParticipate = "ImageParticipate";

	[Token(Token = "0x40100FE")]
	private const string E_Text = "Text";

	[Token(Token = "0x40100FF")]
	private const string E_TextHeadline = "TextHeadline";

	[Token(Token = "0x4010100")]
	private const string E_TextParticipate = "TextParticipate";

	[Token(Token = "0x4010101")]
	private const string E_TextBottom = "TextBottom";

	[Token(Token = "0x4010102")]
	private const string E_ImageBg = "ImageBg";

	[Token(Token = "0x4010103")]
	private const string E_ImageIcon = "ImageIcon";

	[Token(Token = "0x4010104")]
	private const string E_ImageMonster = "ImageMonster";

	[Token(Token = "0x4010105")]
	private const string ARGKEY_VERSUSID = "ArgKeyVersusId";

	[Token(Token = "0x4010106")]
	private const string ARGKEY_ONCLICKBUTTON = "ArgKeyOnClickButton";

	[Token(Token = "0x4010107")]
	[FieldOffset(Offset = "0xD0")]
	private int m_GroupNum;

	[Token(Token = "0x4010108")]
	[FieldOffset(Offset = "0xD4")]
	private int versus_id;

	[Token(Token = "0x4010109")]
	[FieldOffset(Offset = "0xD8")]
	private Action<int, ViewController> onDecide;

	[Token(Token = "0x17001BF0")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600BA7A")]
		[Address(RVA = "0x553140", Offset = "0x552340", VA = "0x180553140", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BA7B")]
	[Address(RVA = "0x551B50", Offset = "0x550D50", VA = "0x180551B50")]
	public static Dictionary<string, object> GetArgs(int versus_id, Action<int, ViewController> onDecide)
	{
		return null;
	}

	[Token(Token = "0x600BA7C")]
	[Address(RVA = "0x5522E0", Offset = "0x5514E0", VA = "0x1805522E0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600BA7D")]
	[Address(RVA = "0x552530", Offset = "0x551730", VA = "0x180552530", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600BA7E")]
	[Address(RVA = "0x551C40", Offset = "0x550E40", VA = "0x180551C40")]
	private void InitView()
	{
	}

	[Token(Token = "0x600BA7F")]
	[Address(RVA = "0x552560", Offset = "0x551760", VA = "0x180552560")]
	private void SetButton(ElementObjectManager eom, int logoId, int groupId)
	{
	}

	[Token(Token = "0x600BA80")]
	[Address(RVA = "0x552D90", Offset = "0x551F90", VA = "0x180552D90")]
	private void StartPerformance()
	{
	}

	[Token(Token = "0x600BA81")]
	[Address(RVA = "0x553120", Offset = "0x552320", VA = "0x180553120")]
	public ColosseumSelectVersusViewController()
	{
	}
}
