using System;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x2001102")]
public class SearchBoxDialog : SelectDialogViewControllerBase<string, string>
{
	[Token(Token = "0x400B3C5")]
	private const string LABEL_SBN_SEARCHBUTTON = "SearchButton";

	[Token(Token = "0x400B3C6")]
	private const string LABEL_TXT_INPUTFIELD = "TextName";

	[Token(Token = "0x400B3C7")]
	private const string LABEL_TXT_PLACEHOLDER = "PlaceHolder";

	[Token(Token = "0x400B3C8")]
	private const string LABEL_EIF_SEARCHFIELD = "SearchField";

	[Token(Token = "0x400B3C9")]
	private const string PREFAB_PATH = "DeckEdit/SearchBoxDialog";

	[Token(Token = "0x17001119")]
	private Text m_InputFieldText
	{
		[Token(Token = "0x6006AE8")]
		[Address(RVA = "0xB2ED80", Offset = "0xB2DF80", VA = "0x180B2ED80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700111A")]
	private SelectionButton m_SearchButton
	{
		[Token(Token = "0x6006AE9")]
		[Address(RVA = "0xB2EE40", Offset = "0xB2E040", VA = "0x180B2EE40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700111B")]
	private ExtendedInputField m_InputField
	{
		[Token(Token = "0x6006AEA")]
		[Address(RVA = "0xB2EDE0", Offset = "0xB2DFE0", VA = "0x180B2EDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006AEB")]
	[Address(RVA = "0xB2EAE0", Offset = "0xB2DCE0", VA = "0x180B2EAE0")]
	public static void Open(string keyword, Action<string> callback)
	{
	}

	[Token(Token = "0x6006AEC")]
	[Address(RVA = "0xB2E970", Offset = "0xB2DB70", VA = "0x180B2E970", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006AED")]
	[Address(RVA = "0xB2EB50", Offset = "0xB2DD50", VA = "0x180B2EB50")]
	private void Start()
	{
	}

	[Token(Token = "0x6006AEE")]
	[Address(RVA = "0xB2ECE0", Offset = "0xB2DEE0", VA = "0x180B2ECE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6006AEF")]
	[Address(RVA = "0xB2ED40", Offset = "0xB2DF40", VA = "0x180B2ED40")]
	public SearchBoxDialog()
	{
	}
}
