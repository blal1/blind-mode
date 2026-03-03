using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x2001375")]
public class PublicDeckSearchFilterTagSelectController : BaseMenuViewController
{
	[Token(Token = "0x2001376")]
	private enum CType
	{
		[Token(Token = "0x400C1F2")]
		Category,
		[Token(Token = "0x400C1F3")]
		Tag
	}

	[Token(Token = "0x400C1D7")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelTitleText;

	[Token(Token = "0x400C1D8")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelInputField;

	[Token(Token = "0x400C1D9")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelPlaceholder;

	[Token(Token = "0x400C1DA")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelScrollView;

	[Token(Token = "0x400C1DB")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelEmptyMessage;

	[Token(Token = "0x400C1DC")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelEmptyMessageText;

	[Token(Token = "0x400C1DD")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelInputButton;

	[Token(Token = "0x400C1DE")]
	[FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelButtonOK;

	[Token(Token = "0x400C1DF")]
	[FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelButtonCancel;

	[Token(Token = "0x400C1E0")]
	[FieldOffset(Offset = "0x118")]
	private TextMeshProUGUI m_TitleText;

	[Token(Token = "0x400C1E1")]
	[FieldOffset(Offset = "0x120")]
	private ElementObjectManager m_InputFieldEom;

	[Token(Token = "0x400C1E2")]
	[FieldOffset(Offset = "0x128")]
	private InputFieldWidget m_InputFieldWidget;

	[Token(Token = "0x400C1E3")]
	[FieldOffset(Offset = "0x130")]
	private ElementObjectManager m_ScrollViewEom;

	[Token(Token = "0x400C1E4")]
	[FieldOffset(Offset = "0x138")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x400C1E5")]
	[FieldOffset(Offset = "0x140")]
	private Transform m_EmptyMessage;

	[Token(Token = "0x400C1E6")]
	[FieldOffset(Offset = "0x148")]
	private TextMeshProUGUI m_EmptyMessageText;

	[Token(Token = "0x400C1E7")]
	[FieldOffset(Offset = "0x150")]
	private Transform m_TitleArea;

	[Token(Token = "0x400C1E8")]
	[FieldOffset(Offset = "0x158")]
	private Transform m_TextFieldArea;

	[Token(Token = "0x400C1E9")]
	[FieldOffset(Offset = "0x160")]
	private SelectionButton m_InputButton;

	[Token(Token = "0x400C1EA")]
	[FieldOffset(Offset = "0x168")]
	private SelectionButton m_ButtonOK;

	[Token(Token = "0x400C1EB")]
	[FieldOffset(Offset = "0x170")]
	private SelectionButton m_ButtonCancel;

	[Token(Token = "0x400C1EC")]
	[FieldOffset(Offset = "0x178")]
	private CType type;

	[Token(Token = "0x400C1ED")]
	[FieldOffset(Offset = "0x180")]
	private string m_Language;

	[Token(Token = "0x400C1EE")]
	[FieldOffset(Offset = "0x188")]
	private List<CategoryReference> m_Categories;

	[Token(Token = "0x400C1EF")]
	[FieldOffset(Offset = "0x190")]
	private List<CategoryReference> m_SelectedCategories;

	[Token(Token = "0x400C1F0")]
	[FieldOffset(Offset = "0x198")]
	private List<CategoryReference> m_tmpSelected;

	[Token(Token = "0x170012AD")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60078D4")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170012AE")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60078D5")]
		[Address(RVA = "0xC20F30", Offset = "0xC20130", VA = "0x180C20F30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078D6")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60078D7")]
	[Address(RVA = "0xC20A60", Offset = "0xC1FC60", VA = "0x180C20A60")]
	private void Start()
	{
	}

	[Token(Token = "0x60078D8")]
	[Address(RVA = "0xC1F730", Offset = "0xC1E930", VA = "0x180C1F730", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60078D9")]
	[Address(RVA = "0xC1EC20", Offset = "0xC1DE20", VA = "0x180C1EC20")]
	private void InitializeCategoryList()
	{
	}

	[Token(Token = "0x60078DA")]
	[Address(RVA = "0xC20850", Offset = "0xC1FA50", VA = "0x180C20850")]
	private void SortCategory()
	{
	}

	[Token(Token = "0x60078DB")]
	[Address(RVA = "0xC1F080", Offset = "0xC1E280", VA = "0x180C1F080")]
	private void InitializeInfinityScrollView()
	{
	}

	[Token(Token = "0x60078DC")]
	[Address(RVA = "0xC20300", Offset = "0xC1F500", VA = "0x180C20300")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x60078DD")]
	[Address(RVA = "0xC202A0", Offset = "0xC1F4A0", VA = "0x180C202A0")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x60078DE")]
	[Address(RVA = "0xC20360", Offset = "0xC1F560", VA = "0x180C20360")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x60078DF")]
	[Address(RVA = "0xC1F570", Offset = "0xC1E770", VA = "0x180C1F570")]
	private void OnClickButtonOK()
	{
	}

	[Token(Token = "0x60078E0")]
	[Address(RVA = "0xC1F480", Offset = "0xC1E680", VA = "0x180C1F480")]
	private void OnClickButtonCancel()
	{
	}

	[Token(Token = "0x60078E1")]
	[Address(RVA = "0xC20520", Offset = "0xC1F720", VA = "0x180C20520")]
	private void SetKeyWord(string keyword)
	{
	}

	[Token(Token = "0x60078E2")]
	[Address(RVA = "0xC20BB0", Offset = "0xC1FDB0", VA = "0x180C20BB0")]
	private string StrConvHiraToKata(string str)
	{
		return null;
	}

	[Token(Token = "0x60078E3")]
	[Address(RVA = "0xC1EA80", Offset = "0xC1DC80", VA = "0x180C1EA80")]
	private void CheckNOListMessage(string keyword)
	{
	}

	[Token(Token = "0x60078E4")]
	[Address(RVA = "0xC1F1D0", Offset = "0xC1E3D0", VA = "0x180C1F1D0")]
	public string LangKey(string lang)
	{
		return null;
	}

	[Token(Token = "0x60078E5")]
	[Address(RVA = "0xC20CB0", Offset = "0xC1FEB0", VA = "0x180C20CB0")]
	public PublicDeckSearchFilterTagSelectController()
	{
	}
}
