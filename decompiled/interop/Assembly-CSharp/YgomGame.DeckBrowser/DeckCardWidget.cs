using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomSystem.ElementSystem;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2001026")]
public class DeckCardWidget : DeckCard
{
	[Token(Token = "0x400AD03")]
	[FieldOffset(Offset = "0x148")]
	private ElementObjectManager m_EomCache;

	[Token(Token = "0x400AD04")]
	[FieldOffset(Offset = "0x150")]
	private bool m_Ready;

	[Token(Token = "0x400AD05")]
	[FieldOffset(Offset = "0x151")]
	private bool m_IsMonochrome;

	[Token(Token = "0x400AD06")]
	[FieldOffset(Offset = "0x152")]
	private bool m_RagulationVisible;

	[Token(Token = "0x400AD07")]
	[FieldOffset(Offset = "0x153")]
	private bool m_RarityVisible;

	[Token(Token = "0x400AD08")]
	private const string k_ELabelGroupCardNum = "GroupCardNum";

	[Token(Token = "0x400AD09")]
	private const string k_ELabelTextCardNum = "TextCardNum";

	[Token(Token = "0x400AD0A")]
	[FieldOffset(Offset = "0x158")]
	private Image m_CardNumBase;

	[Token(Token = "0x400AD0B")]
	[FieldOffset(Offset = "0x160")]
	private TextMeshProUGUI m_CardNumText;

	[Token(Token = "0x17000F4F")]
	public ElementObjectManager eom
	{
		[Token(Token = "0x60061D6")]
		[Address(RVA = "0xA76D60", Offset = "0xA75F60", VA = "0x180A76D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F50")]
	public bool isMonochrome
	{
		[Token(Token = "0x60061D7")]
		[Address(RVA = "0xA76E00", Offset = "0xA76000", VA = "0x180A76E00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061D8")]
		[Address(RVA = "0xA76E30", Offset = "0xA76030", VA = "0x180A76E30")]
		set
		{
		}
	}

	[Token(Token = "0x17000F51")]
	public bool regulationVisible
	{
		[Token(Token = "0x60061D9")]
		[Address(RVA = "0xA76E20", Offset = "0xA76020", VA = "0x180A76E20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061DA")]
		[Address(RVA = "0xA76EC0", Offset = "0xA760C0", VA = "0x180A76EC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F52")]
	public bool rarityVisible
	{
		[Token(Token = "0x60061DB")]
		[Address(RVA = "0xA76E10", Offset = "0xA76010", VA = "0x180A76E10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061DC")]
		[Address(RVA = "0xA76E50", Offset = "0xA76050", VA = "0x180A76E50")]
		set
		{
		}
	}

	[Token(Token = "0x60061DD")]
	[Address(RVA = "0xA76720", Offset = "0xA75920", VA = "0x180A76720")]
	public static DeckCardWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x60061DE")]
	[Address(RVA = "0xA76AE0", Offset = "0xA75CE0", VA = "0x180A76AE0")]
	public void SetData(CardBaseData baseData)
	{
	}

	[Token(Token = "0x60061DF")]
	[Address(RVA = "0xA76890", Offset = "0xA75A90", VA = "0x180A76890")]
	public void DispCardNum(bool b)
	{
	}

	[Token(Token = "0x60061E0")]
	[Address(RVA = "0xA768F0", Offset = "0xA75AF0", VA = "0x180A768F0")]
	public void SetCardNum(int num)
	{
	}

	[Token(Token = "0x60061E1")]
	[Address(RVA = "0xA768D0", Offset = "0xA75AD0", VA = "0x180A768D0")]
	private void OnFinishSetCardPicture()
	{
	}

	[Token(Token = "0x60061E2")]
	[Address(RVA = "0xA76D40", Offset = "0xA75F40", VA = "0x180A76D40")]
	public DeckCardWidget()
	{
	}
}
