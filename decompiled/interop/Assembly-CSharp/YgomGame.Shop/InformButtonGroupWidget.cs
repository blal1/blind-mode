using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000997")]
public class InformButtonGroupWidget : ElementWidgetBase
{
	[Token(Token = "0x2000998")]
	private class EntryContext
	{
		[Token(Token = "0x4008CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string buttonLabel;

		[Token(Token = "0x4008CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShopInformButtonData buttonData;

		[Token(Token = "0x4008CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> args;

		[Token(Token = "0x4008CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<EntryContext> children;

		[Token(Token = "0x170007CC")]
		public bool isSingle
		{
			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0x5C4390", Offset = "0x5C3590", VA = "0x1805C4390")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007CD")]
		public bool isMulti
		{
			[Token(Token = "0x6003AEB")]
			[Address(RVA = "0x8111A0", Offset = "0x8103A0", VA = "0x1808111A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003AEC")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public EntryContext()
		{
		}
	}

	[Token(Token = "0x4008CD5")]
	private const int k_TemplateIdx_Normal = 0;

	[Token(Token = "0x4008CD6")]
	private const int k_TemplateIdx_Highlight_1 = 1;

	[Token(Token = "0x4008CD7")]
	private const int k_TemplateIdx_Highlight_2 = 2;

	[Token(Token = "0x4008CD8")]
	private const int k_TemplateIdx_Normal_Half = 3;

	[Token(Token = "0x4008CD9")]
	private const int k_TemplateIdx_Highlight_1_Half = 4;

	[Token(Token = "0x4008CDA")]
	private const int k_TemplateIdx_Highlight_2_Half = 5;

	[Token(Token = "0x4008CDB")]
	private const int k_TemplateIdx_HalfBox = 10;

	[Token(Token = "0x4008CDC")]
	private const int k_RawLength = 2;

	[Token(Token = "0x4008CDD")]
	internal const string k_BehaviourArgKey_NormalCardPoolId = "normalCardPoolId";

	[Token(Token = "0x4008CDE")]
	internal const string k_BehaviourArgKey_PickupCardPoolId = "pickupCardPoolId";

	[Token(Token = "0x4008CDF")]
	internal const string k_BehaviourArgKey_CardBrowserTitle = "cardBrowserTitle";

	[Token(Token = "0x4008CE0")]
	internal const string k_BehaviourArgKey_PrizeId = "prizeId";

	[Token(Token = "0x4008CE1")]
	internal const string k_BehaviourArgKey_PrizeResultTitle = "prizeResultTitle";

	[Token(Token = "0x4008CE2")]
	internal const string k_BehaviourArgKey_PrizeResultDesc = "prizeResultDesc";

	[Token(Token = "0x4008CE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelHalfButtonGroup;

	[Token(Token = "0x4008CE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelText;

	[Token(Token = "0x4008CE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly List<(string label, Action callback)> m_DataList;

	[Token(Token = "0x4008CE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<int> m_TemplateIdList;

	[Token(Token = "0x4008CE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ProductContext m_ProductContext;

	[Token(Token = "0x4008CE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool blockPurchase;

	[Token(Token = "0x4008CE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool setDefaultButton;

	[Token(Token = "0x4008CEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform m_PoolRoot;

	[Token(Token = "0x4008CEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<SelectionButton> m_Buttons;

	[Token(Token = "0x4008CEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Dictionary<SelectionButton, (int xPos, int yPos)> m_ButtonPositionMap;

	[Token(Token = "0x4008CED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Dictionary<int, Stack<GameObject>> m_Rents;

	[Token(Token = "0x4008CEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<int, Stack<GameObject>> m_Reusables;

	[Token(Token = "0x4008CF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Action onTransitionEdgeLeft;

	[Token(Token = "0x4008CF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action onTransitionEdgeDown;

	[Token(Token = "0x4008CF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<ShopInformButtonData> m_ValidInfoButtonSearcher;

	[Token(Token = "0x4008CF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<EntryContext> m_CardPoolEntryContexts;

	[Token(Token = "0x170007CB")]
	private GameObject halfButtonGroup
	{
		[Token(Token = "0x6003ACB")]
		[Address(RVA = "0x818900", Offset = "0x817B00", VA = "0x180818900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000041")]
	public event Action onClickInformButtonEvent
	{
		[Token(Token = "0x6003ACC")]
		[Address(RVA = "0x818860", Offset = "0x817A60", VA = "0x180818860")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003ACD")]
		[Address(RVA = "0x818930", Offset = "0x817B30", VA = "0x180818930")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003ACE")]
	[Address(RVA = "0x815360", Offset = "0x814560", VA = "0x180815360")]
	private int GetTemplateSize(bool isHalf)
	{
		return default(int);
	}

	[Token(Token = "0x6003ACF")]
	[Address(RVA = "0x815210", Offset = "0x814410", VA = "0x180815210")]
	private int GetTemplateIdxByStyle(ShopInformButtonData.ButtonStyle buttonStyle, bool isHalf)
	{
		return default(int);
	}

	[Token(Token = "0x6003AD0")]
	[Address(RVA = "0x814E50", Offset = "0x814050", VA = "0x180814E50")]
	private string GetButtonLabel(ShopInformButtonData buttonData)
	{
		return null;
	}

	[Token(Token = "0x6003AD1")]
	[Address(RVA = "0x813EE0", Offset = "0x8130E0", VA = "0x180813EE0")]
	private Action GetBehaviourCallback(ShopInformButtonData buttonData, [Optional] Dictionary<string, object> behaviourArgs)
	{
		return null;
	}

	[Token(Token = "0x6003AD2")]
	[Address(RVA = "0x813CA0", Offset = "0x812EA0", VA = "0x180813CA0")]
	private Action CreateBehaviourCallbackByEntry(EntryContext entryContext)
	{
		return null;
	}

	[Token(Token = "0x6003AD3")]
	[Address(RVA = "0x8180C0", Offset = "0x8172C0", VA = "0x1808180C0")]
	public InformButtonGroupWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003AD4")]
	[Address(RVA = "0x815370", Offset = "0x814570", VA = "0x180815370")]
	private void InitEntityTemplate(int templateId)
	{
	}

	[Token(Token = "0x6003AD5")]
	[Address(RVA = "0x8137D0", Offset = "0x8129D0", VA = "0x1808137D0")]
	private void ApplyData()
	{
	}

	[Token(Token = "0x6003AD6")]
	[Address(RVA = "0x815BE0", Offset = "0x814DE0", VA = "0x180815BE0")]
	private void ReturnEntityAll()
	{
	}

	[Token(Token = "0x6003AD7")]
	[Address(RVA = "0x815DB0", Offset = "0x814FB0", VA = "0x180815DB0")]
	private void ReturnEntity(int templateId, GameObject entity, bool reusable = true)
	{
	}

	[Token(Token = "0x6003AD8")]
	[Address(RVA = "0x815940", Offset = "0x814B40", VA = "0x180815940")]
	private GameObject RentEntity(int templateId)
	{
		return null;
	}

	[Token(Token = "0x6003AD9")]
	[Address(RVA = "0x813E00", Offset = "0x813000", VA = "0x180813E00")]
	private GameObject CreateEntity(int templateId)
	{
		return null;
	}

	[Token(Token = "0x6003ADA")]
	[Address(RVA = "0x8168E0", Offset = "0x815AE0", VA = "0x1808168E0")]
	private void SetupEntity(int templateIdx, GameObject entity)
	{
	}

	[Token(Token = "0x6003ADB")]
	[Address(RVA = "0x815250", Offset = "0x814450", VA = "0x180815250")]
	private string GetTemplateLabel(int templateIdx)
	{
		return null;
	}

	[Token(Token = "0x6003ADC")]
	[Address(RVA = "0x815400", Offset = "0x814600", VA = "0x180815400")]
	private bool IsHalfTemplate(int templateIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003ADD")]
	[Address(RVA = "0x8153F0", Offset = "0x8145F0", VA = "0x1808153F0")]
	private bool IsBoxTemplate(int templateIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003ADE")]
	[Address(RVA = "0x815500", Offset = "0x814700", VA = "0x180815500")]
	private void OnButtonInputDirection(SelectionButton button, int xAmount, int yAmount)
	{
	}

	[Token(Token = "0x6003ADF")]
	[Address(RVA = "0x817DD0", Offset = "0x816FD0", VA = "0x180817DD0")]
	private SelectionButton TryGetSideButton(SelectionButton button, int xAmount, int yAmount)
	{
		return null;
	}

	[Token(Token = "0x6003AE0")]
	[Address(RVA = "0x818070", Offset = "0x817270", VA = "0x180818070")]
	private int TryGetSideIdx(int idx, PadInputDirection direction, bool isHalf)
	{
		return default(int);
	}

	[Token(Token = "0x6003AE1")]
	[Address(RVA = "0x8155C0", Offset = "0x8147C0", VA = "0x1808155C0")]
	private void OnClickEntity(SelectionButton button)
	{
	}

	[Token(Token = "0x6003AE2")]
	[Address(RVA = "0x816260", Offset = "0x815460", VA = "0x180816260")]
	public void SetContext(ShopSettings shopSettings, ProductContext productContext)
	{
	}

	[Token(Token = "0x6003AE3")]
	[Address(RVA = "0x815410", Offset = "0x814610", VA = "0x180815410")]
	private bool ModifyCheckIsHalfButtonEdge(ShopInformButtonData buttonData, ShopInformButtonData nextButtonData, ref int halfSizeTotal)
	{
		return default(bool);
	}

	[Token(Token = "0x6003AE4")]
	[Address(RVA = "0x816140", Offset = "0x815340", VA = "0x180816140")]
	public void SelectHeadButton()
	{
	}

	[Token(Token = "0x6003AE5")]
	[Address(RVA = "0x816090", Offset = "0x815290", VA = "0x180816090")]
	public void SelectBottomButton(bool initializeSelection = false)
	{
	}

	[Token(Token = "0x6003AE6")]
	[Address(RVA = "0x816BC0", Offset = "0x815DC0", VA = "0x180816BC0")]
	private Dictionary<string, object> TryCreateOpenItemPreview(ProductContext productContext)
	{
		return null;
	}

	[Token(Token = "0x6003AE7")]
	[Address(RVA = "0x817230", Offset = "0x816430", VA = "0x180817230")]
	private EntryContext TryGetCardPoolListEntry(ShopInformButtonData sourceButtonData, int idx)
	{
		return null;
	}

	[Token(Token = "0x6003AE8")]
	[Address(RVA = "0x815680", Offset = "0x814880", VA = "0x180815680")]
	private void OpenCardFile(int itemId = 0)
	{
	}

	[Token(Token = "0x6003AE9")]
	[Address(RVA = "0x815690", Offset = "0x814890", VA = "0x180815690")]
	private void OpenItemPreview(ItemUtil.Category category, int id, object itemDic)
	{
	}
}
