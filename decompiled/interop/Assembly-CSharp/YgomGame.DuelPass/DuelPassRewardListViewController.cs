using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DuelPass;

[Token(Token = "0x2000EBE")]
public class DuelPassRewardListViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000EBF")]
	private class ItemContext
	{
		[Token(Token = "0x400A49D")]
		[FieldOffset(Offset = "0x10")]
		public int grade;

		[Token(Token = "0x400A49E")]
		[FieldOffset(Offset = "0x14")]
		public bool isPeriod;

		[Token(Token = "0x400A49F")]
		[FieldOffset(Offset = "0x18")]
		public int itemCategory;

		[Token(Token = "0x400A4A0")]
		[FieldOffset(Offset = "0x1C")]
		public int itemId;

		[Token(Token = "0x400A4A1")]
		[FieldOffset(Offset = "0x20")]
		public int itemCount;

		[Token(Token = "0x400A4A2")]
		[FieldOffset(Offset = "0x24")]
		public bool isRecommend;

		[Token(Token = "0x600594F")]
		[Address(RVA = "0x9F7710", Offset = "0x9F6910", VA = "0x1809F7710")]
		public ItemContext(int grade, bool isPeriod, int itemCategory, int itemId, int itemCount, bool isRecommend)
		{
		}

		[Token(Token = "0x6005950")]
		[Address(RVA = "0x9F76D0", Offset = "0x9F68D0", VA = "0x1809F76D0")]
		public bool IsSameItem(ItemContext itemContext)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400A478")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelScrollView;

	[Token(Token = "0x400A479")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelThumbHolder;

	[Token(Token = "0x400A47A")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelGradeText;

	[Token(Token = "0x400A47B")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelNumText;

	[Token(Token = "0x400A47C")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelItemRow;

	[Token(Token = "0x400A47D")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelTotalItemRow;

	[Token(Token = "0x400A47E")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400A47F")]
	[FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelItemTemplate;

	[Token(Token = "0x400A480")]
	[FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelTotalItemTemplate;

	[Token(Token = "0x400A481")]
	[FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x400A482")]
	[FieldOffset(Offset = "0x120")]
	private readonly List<string> m_cloneTotalItemNameList;

	[Token(Token = "0x400A483")]
	[FieldOffset(Offset = "0x128")]
	private readonly List<string> m_cloneItemNameList;

	[Token(Token = "0x400A484")]
	[FieldOffset(Offset = "0x130")]
	private readonly string k_grade;

	[Token(Token = "0x400A485")]
	[FieldOffset(Offset = "0x138")]
	private readonly string k_isPeriod;

	[Token(Token = "0x400A486")]
	[FieldOffset(Offset = "0x140")]
	private readonly string k_itemCategory;

	[Token(Token = "0x400A487")]
	[FieldOffset(Offset = "0x148")]
	private readonly string k_itemId;

	[Token(Token = "0x400A488")]
	[FieldOffset(Offset = "0x150")]
	private readonly string k_itemCount;

	[Token(Token = "0x400A489")]
	[FieldOffset(Offset = "0x158")]
	private readonly string k_isRecommend;

	[Token(Token = "0x400A48A")]
	private const int k_TextTNo = 0;

	[Token(Token = "0x400A48B")]
	private const int k_TotalItemRowTNo = 1;

	[Token(Token = "0x400A48C")]
	private const int k_ItemRowTNo = 2;

	[Token(Token = "0x400A48D")]
	[FieldOffset(Offset = "0x0")]
	private static string k_ArgDuelPassDic;

	[Token(Token = "0x400A48E")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private readonly int MAX_COL_CONSOLE;

	[Token(Token = "0x400A48F")]
	[FieldOffset(Offset = "0x164")]
	[SerializeField]
	private readonly int MAX_COL_MOBILE;

	[Token(Token = "0x400A490")]
	[FieldOffset(Offset = "0x168")]
	private int m_maxCol;

	[Token(Token = "0x400A491")]
	[FieldOffset(Offset = "0x16C")]
	private int m_maxTotalItemRow;

	[Token(Token = "0x400A492")]
	[FieldOffset(Offset = "0x170")]
	private int m_maxItemRow;

	[Token(Token = "0x400A493")]
	[FieldOffset(Offset = "0x174")]
	private readonly int GRADE_TOTALITEM;

	[Token(Token = "0x400A494")]
	[FieldOffset(Offset = "0x178")]
	private int m_itemRowStartNum;

	[Token(Token = "0x400A495")]
	[FieldOffset(Offset = "0x17C")]
	private int m_totalItemRowStartNum;

	[Token(Token = "0x400A496")]
	[FieldOffset(Offset = "0x180")]
	private List<ItemContext> m_totalItemContexts;

	[Token(Token = "0x400A497")]
	[FieldOffset(Offset = "0x188")]
	private List<int> m_templates;

	[Token(Token = "0x400A498")]
	[FieldOffset(Offset = "0x190")]
	private List<List<ItemContext>> m_totalItemContextGrid;

	[Token(Token = "0x400A499")]
	[FieldOffset(Offset = "0x198")]
	private List<List<ItemContext>> m_itemContextGrid;

	[Token(Token = "0x400A49A")]
	[FieldOffset(Offset = "0x1A0")]
	private GameObject m_itemTemplateGO;

	[Token(Token = "0x400A49B")]
	[FieldOffset(Offset = "0x1A8")]
	private GameObject m_totalItemTemplateGO;

	[Token(Token = "0x400A49C")]
	[FieldOffset(Offset = "0x1B0")]
	private InfinityScrollView m_scrollView;

	[Token(Token = "0x17000DC3")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600593F")]
		[Address(RVA = "0x9EBF50", Offset = "0x9EB150", VA = "0x1809EBF50", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005940")]
	[Address(RVA = "0x9EB520", Offset = "0x9EA720", VA = "0x1809EB520")]
	public static void Open(Dictionary<string, object> shopDuelPassDic)
	{
	}

	[Token(Token = "0x6005941")]
	[Address(RVA = "0x9E9D80", Offset = "0x9E8F80", VA = "0x1809E9D80", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005942")]
	[Address(RVA = "0x9E9E40", Offset = "0x9E9040", VA = "0x1809E9E40", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005943")]
	[Address(RVA = "0x9EB8D0", Offset = "0x9EAAD0", VA = "0x1809EB8D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6005944")]
	[Address(RVA = "0x9E9710", Offset = "0x9E8910", VA = "0x1809E9710")]
	private void AddTotalItemContext(ItemContext itemContext)
	{
	}

	[Token(Token = "0x6005945")]
	[Address(RVA = "0x9E9950", Offset = "0x9E8B50", VA = "0x1809E9950")]
	private void CreateTotalItemContextGrid()
	{
	}

	[Token(Token = "0x6005946")]
	[Address(RVA = "0x9EAE10", Offset = "0x9EA010", VA = "0x1809EAE10")]
	private IReadOnlyList<(SelectionItem, int, int)> OnItemCollectSelectionItems(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6005947")]
	[Address(RVA = "0x9EB0F0", Offset = "0x9EA2F0", VA = "0x1809EB0F0")]
	public void OnUpdateEntity(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6005948")]
	[Address(RVA = "0x9EB620", Offset = "0x9EA820", VA = "0x1809EB620")]
	private void SetItemWidget(ElementObjectManager itemWidget, ItemContext itemContext)
	{
	}

	[Token(Token = "0x6005949")]
	[Address(RVA = "0x9E9CF0", Offset = "0x9E8EF0", VA = "0x1809E9CF0")]
	private bool IsSelectableDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600594A")]
	[Address(RVA = "0x9E9E00", Offset = "0x9E9000", VA = "0x1809E9E00")]
	private void OnClickItem(ItemContext itemContext)
	{
	}

	[Token(Token = "0x600594B")]
	[Address(RVA = "0x9EAB10", Offset = "0x9E9D10", VA = "0x1809EAB10")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x600594C")]
	[Address(RVA = "0x9EBA80", Offset = "0x9EAC80", VA = "0x1809EBA80")]
	public DuelPassRewardListViewController()
	{
	}
}
