using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x2001372")]
public class PublicDeckSearchFilterController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x400C1C1")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelCategoryScrollView;

	[Token(Token = "0x400C1C2")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelAddCategoryButton;

	[Token(Token = "0x400C1C3")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelTagScrollView;

	[Token(Token = "0x400C1C4")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelAddTagButton;

	[Token(Token = "0x400C1C5")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelCancelButton;

	[Token(Token = "0x400C1C6")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelSearchButton;

	[Token(Token = "0x400C1C7")]
	[FieldOffset(Offset = "0x100")]
	private InfinityScrollView m_CategoryScrollView;

	[Token(Token = "0x400C1C8")]
	[FieldOffset(Offset = "0x108")]
	private SelectionButton m_AddCategoryButton;

	[Token(Token = "0x400C1C9")]
	[FieldOffset(Offset = "0x110")]
	private InfinityScrollView m_TagScrollView;

	[Token(Token = "0x400C1CA")]
	[FieldOffset(Offset = "0x118")]
	private SelectionButton m_AddTagButton;

	[Token(Token = "0x400C1CB")]
	[FieldOffset(Offset = "0x120")]
	private SelectionButton m_CancelButton;

	[Token(Token = "0x400C1CC")]
	[FieldOffset(Offset = "0x128")]
	private SelectionButton m_SearchButton;

	[Token(Token = "0x400C1CD")]
	[FieldOffset(Offset = "0x130")]
	private List<CategoryReference> m_SelectedCategories;

	[Token(Token = "0x400C1CE")]
	[FieldOffset(Offset = "0x138")]
	private List<CategoryReference> m_SelectedTags;

	[Token(Token = "0x170012AC")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60078B9")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60078BA")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60078BB")]
	[Address(RVA = "0xC1E8A0", Offset = "0xC1DAA0", VA = "0x180C1E8A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60078BC")]
	[Address(RVA = "0xC1D920", Offset = "0xC1CB20", VA = "0x180C1D920", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60078BD")]
	[Address(RVA = "0xC1D170", Offset = "0xC1C370", VA = "0x180C1D170", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x60078BE")]
	[Address(RVA = "0xC1E680", Offset = "0xC1D880", VA = "0x180C1E680")]
	private void OpenCategorySelectUI()
	{
	}

	[Token(Token = "0x60078BF")]
	[Address(RVA = "0xC1E790", Offset = "0xC1D990", VA = "0x180C1E790")]
	private void OpenTagSelectUI()
	{
	}

	[Token(Token = "0x60078C0")]
	[Address(RVA = "0xC1CF40", Offset = "0xC1C140", VA = "0x180C1CF40")]
	private void InitializeInfinityScrollView()
	{
	}

	[Token(Token = "0x60078C1")]
	[Address(RVA = "0xA779B0", Offset = "0xA76BB0", VA = "0x180A779B0")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x60078C2")]
	[Address(RVA = "0xC1DF70", Offset = "0xC1D170", VA = "0x180C1DF70")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x60078C3")]
	[Address(RVA = "0xC1E1C0", Offset = "0xC1D3C0", VA = "0x180C1E1C0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x60078C4")]
	[Address(RVA = "0xC1D660", Offset = "0xC1C860", VA = "0x180C1D660")]
	private void OnClickCategoryButton(int dataindex, CategoryReference categoryRef, SelectionButton button)
	{
	}

	[Token(Token = "0x60078C5")]
	[Address(RVA = "0xA779B0", Offset = "0xA76BB0", VA = "0x180A779B0")]
	public void OnItemInitialize2(GameObject gob)
	{
	}

	[Token(Token = "0x60078C6")]
	[Address(RVA = "0xC1DF10", Offset = "0xC1D110", VA = "0x180C1DF10")]
	public void OnGsvStanby2()
	{
	}

	[Token(Token = "0x60078C7")]
	[Address(RVA = "0xC1DFD0", Offset = "0xC1D1D0", VA = "0x180C1DFD0")]
	public void OnItemSetData2(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x60078C8")]
	[Address(RVA = "0xC1D7C0", Offset = "0xC1C9C0", VA = "0x180C1D7C0")]
	private void OnClickTagButton(int dataindex, CategoryReference tagRef, SelectionButton button)
	{
	}

	[Token(Token = "0x60078C9")]
	[Address(RVA = "0xC1E3B0", Offset = "0xC1D5B0", VA = "0x180C1E3B0", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60078CA")]
	[Address(RVA = "0xC1D400", Offset = "0xC1C600", VA = "0x180C1D400")]
	private void OnClickButtonOK()
	{
	}

	[Token(Token = "0x60078CB")]
	[Address(RVA = "0xC1E8C0", Offset = "0xC1DAC0", VA = "0x180C1E8C0")]
	public PublicDeckSearchFilterController()
	{
	}
}
