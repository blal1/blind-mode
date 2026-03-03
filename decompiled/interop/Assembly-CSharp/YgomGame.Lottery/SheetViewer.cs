using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Lottery;

[Token(Token = "0x2001739")]
public class SheetViewer : MonoBehaviour
{
	[Token(Token = "0x400DB1C")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_SheetLabel;

	[Token(Token = "0x400DB1D")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_CardLabel;

	[Token(Token = "0x400DB1E")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_NumLabel;

	[Token(Token = "0x400DB1F")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ShadeLabel;

	[Token(Token = "0x400DB20")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_RoundTextLabel;

	[Token(Token = "0x400DB21")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_GreyOutLabel;

	[Token(Token = "0x400DB23")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private int m_CardNum;

	[Token(Token = "0x400DB24")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private int m_RoundNum;

	[Token(Token = "0x400DB25")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private int m_SheetNum;

	[Token(Token = "0x400DB26")]
	[FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400DB27")]
	[FieldOffset(Offset = "0x68")]
	private PlayableDirector m_Director;

	[Token(Token = "0x400DB28")]
	[FieldOffset(Offset = "0x70")]
	private List<RawImage> m_Images;

	[Token(Token = "0x400DB29")]
	[FieldOffset(Offset = "0x78")]
	private List<List<GameObject>> m_Nums;

	[Token(Token = "0x400DB2A")]
	[FieldOffset(Offset = "0x80")]
	private List<GameObject> m_Sheets;

	[Token(Token = "0x400DB2B")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_Shade;

	[Token(Token = "0x400DB2C")]
	[FieldOffset(Offset = "0x90")]
	private ExtendedTextMeshProUGUI m_RoundText;

	[Token(Token = "0x400DB2D")]
	[FieldOffset(Offset = "0x98")]
	private bool m_IsShow;

	[Token(Token = "0x17001659")]
	public bool isShow
	{
		[Token(Token = "0x60091A8")]
		[Address(RVA = "0xDB8210", Offset = "0xDB7410", VA = "0x180DB8210")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700165A")]
	public int sheetState
	{
		[Token(Token = "0x60091A9")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60091AA")]
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", VA = "0x18049C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60091AB")]
	[Address(RVA = "0xDB6850", Offset = "0xDB5A50", VA = "0x180DB6850")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60091AC")]
	[Address(RVA = "0xDB6F10", Offset = "0xDB6110", VA = "0x180DB6F10")]
	public void SetCards(int[] mrks, bool isButton = false)
	{
	}

	[Token(Token = "0x60091AD")]
	[Address(RVA = "0xDB7330", Offset = "0xDB6530", VA = "0x180DB7330")]
	public void SetCards(int[] mrks, List<int> buttonList, int indexOffset)
	{
	}

	[Token(Token = "0x60091AE")]
	[Address(RVA = "0xDB7850", Offset = "0xDB6A50", VA = "0x180DB7850")]
	public void SetNum(int num)
	{
	}

	[Token(Token = "0x60091AF")]
	[Address(RVA = "0xDB7C80", Offset = "0xDB6E80", VA = "0x180DB7C80")]
	public void SetSheet(int sheet, bool useTimeline = false)
	{
	}

	[Token(Token = "0x60091B0")]
	[Address(RVA = "0xDB7AF0", Offset = "0xDB6CF0", VA = "0x180DB7AF0")]
	public void SetSheetHotfix(int sheet, bool useTimeline = false)
	{
	}

	[Token(Token = "0x60091B1")]
	[Address(RVA = "0xDB7F50", Offset = "0xDB7150", VA = "0x180DB7F50")]
	public void SkipSheetTimeline()
	{
	}

	[Token(Token = "0x60091B2")]
	[Address(RVA = "0xDB7650", Offset = "0xDB6850", VA = "0x180DB7650")]
	public void SetDefaultSheet()
	{
	}

	[Token(Token = "0x60091B3")]
	[Address(RVA = "0xDB7660", Offset = "0xDB6860", VA = "0x180DB7660")]
	public void SetGreyOut(bool isGrey)
	{
	}

	[Token(Token = "0x60091B4")]
	[Address(RVA = "0xDB6520", Offset = "0xDB5720", VA = "0x180DB6520")]
	public List<SelectionButton> GetCardButtons()
	{
		return null;
	}

	[Token(Token = "0x60091B5")]
	[Address(RVA = "0xDB6710", Offset = "0xDB5910", VA = "0x180DB6710")]
	private void HideCards()
	{
	}

	[Token(Token = "0x60091B6")]
	[Address(RVA = "0xDB7E10", Offset = "0xDB7010", VA = "0x180DB7E10")]
	private void ShowCards()
	{
	}

	[Token(Token = "0x60091B7")]
	[Address(RVA = "0xDB8000", Offset = "0xDB7200", VA = "0x180DB8000")]
	public SheetViewer()
	{
	}
}
