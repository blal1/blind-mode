using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Billing;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.GemShop;

[Token(Token = "0x2000DB1")]
public class GemShopViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x2000DB8")]
	[CompilerGenerated]
	private sealed class _003CyPlayPopIcon_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A00B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A00C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A00D")]
		[FieldOffset(Offset = "0x20")]
		public GemShopViewController _003C_003E4__this;

		[Token(Token = "0x400A00E")]
		[FieldOffset(Offset = "0x28")]
		public bool isIn;

		[Token(Token = "0x17000BE4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600524E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005250")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600524B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPopIcon_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600524C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600524D")]
		[Address(RVA = "0x99B180", Offset = "0x99A380", VA = "0x18099B180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600524F")]
		[Address(RVA = "0x99B3D0", Offset = "0x99A5D0", VA = "0x18099B3D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009FDD")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelProductList;

	[Token(Token = "0x4009FDE")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelDoubleNotationPriceRate;

	[Token(Token = "0x4009FDF")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelServiceInfoButton;

	[Token(Token = "0x4009FE0")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelGemGetHistoryButton;

	[Token(Token = "0x4009FE1")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelCautionButton;

	[Token(Token = "0x4009FE2")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelProductEmptyText;

	[Token(Token = "0x4009FE3")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelServiceInfoText;

	[Token(Token = "0x4009FE4")]
	[FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelLocatorPromoButton;

	[Token(Token = "0x4009FE5")]
	[FieldOffset(Offset = "0x110")]
	private readonly string k_ALabelConfirmRegDialogTextWidget;

	[Token(Token = "0x4009FE6")]
	[FieldOffset(Offset = "0x118")]
	private readonly string k_PLabelDoubleNotationLabel;

	[Token(Token = "0x4009FE7")]
	[FieldOffset(Offset = "0x120")]
	private readonly string k_PLabelDoubleNotationConfirmFormat;

	[Token(Token = "0x4009FE8")]
	[FieldOffset(Offset = "0x128")]
	private string m_DoubleNotationRateLabel;

	[Token(Token = "0x4009FE9")]
	[FieldOffset(Offset = "0x130")]
	private string m_DoubleNotationRateFormatLabel;

	[Token(Token = "0x4009FEA")]
	[FieldOffset(Offset = "0x138")]
	private Dictionary<GameObject, ProductWidget> m_EntityWidgetMap;

	[Token(Token = "0x4009FEB")]
	[FieldOffset(Offset = "0x140")]
	private List<ProductContext> m_ProductContexts;

	[Token(Token = "0x4009FEC")]
	[FieldOffset(Offset = "0x148")]
	private JsonGemShopAnalyzer m_JsonGemShopAnalyzer;

	[Token(Token = "0x4009FED")]
	[FieldOffset(Offset = "0x150")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x4009FEE")]
	[FieldOffset(Offset = "0x158")]
	private TMP_Text m_ServiceInfo;

	[Token(Token = "0x4009FEF")]
	[FieldOffset(Offset = "0x160")]
	private string m_CautionHelpPath;

	[Token(Token = "0x4009FF0")]
	[FieldOffset(Offset = "0x168")]
	private Coroutine m_PopIconRoutine;

	[Token(Token = "0x4009FF1")]
	[FieldOffset(Offset = "0x170")]
	private TransitionType m_TransitionType;

	[Token(Token = "0x4009FF2")]
	private const string k_GemShopViewControllerPath = "GemShop/GemShop";

	[Token(Token = "0x17000BE3")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600521A")]
		[Address(RVA = "0x98E990", Offset = "0x98DB90", VA = "0x18098E990", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600521B")]
	[Address(RVA = "0x98B130", Offset = "0x98A330", VA = "0x18098B130", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x600521C")]
	[Address(RVA = "0x98D040", Offset = "0x98C240", VA = "0x18098D040")]
	public static void Open()
	{
	}

	[Token(Token = "0x600521D")]
	[Address(RVA = "0x98CEA0", Offset = "0x98C0A0", VA = "0x18098CEA0")]
	public static void OpenOnHome()
	{
	}

	[Token(Token = "0x600521E")]
	[Address(RVA = "0x98B140", Offset = "0x98A340", VA = "0x18098B140", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600521F")]
	[Address(RVA = "0x98B5E0", Offset = "0x98A7E0", VA = "0x18098B5E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005220")]
	[Address(RVA = "0x98D540", Offset = "0x98C740", VA = "0x18098D540")]
	private void Start()
	{
	}

	[Token(Token = "0x6005221")]
	[Address(RVA = "0x98BB20", Offset = "0x98AD20", VA = "0x18098BB20", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6005222")]
	[Address(RVA = "0x98BAA0", Offset = "0x98ACA0", VA = "0x18098BAA0", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6005223")]
	[Address(RVA = "0x98BA90", Offset = "0x98AC90", VA = "0x18098BA90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005224")]
	[Address(RVA = "0x98B4B0", Offset = "0x98A6B0", VA = "0x18098B4B0")]
	private void OnCreatedEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6005225")]
	[Address(RVA = "0x98BB90", Offset = "0x98AD90", VA = "0x18098BB90")]
	private void OnUpdateEntity(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x6005226")]
	[Address(RVA = "0x98A540", Offset = "0x989740", VA = "0x18098A540")]
	private void ImportProducts()
	{
	}

	[Token(Token = "0x6005227")]
	[Address(RVA = "0x98D300", Offset = "0x98C500", VA = "0x18098D300")]
	private void RefreshView(bool import = true)
	{
	}

	[Token(Token = "0x6005228")]
	[Address(RVA = "0x98D810", Offset = "0x98CA10", VA = "0x18098D810")]
	private void TryPlayPopIcon(bool isIn)
	{
	}

	[Token(Token = "0x6005229")]
	[Address(RVA = "0x98EC60", Offset = "0x98DE60", VA = "0x18098EC60")]
	[IteratorStateMachine(typeof(_003CyPlayPopIcon_003Ed__38))]
	private IEnumerator yPlayPopIcon(bool isIn)
	{
		return null;
	}

	[Token(Token = "0x600522A")]
	[Address(RVA = "0x98AE70", Offset = "0x98A070", VA = "0x18098AE70")]
	private void InitPromoButton()
	{
	}

	[Token(Token = "0x600522B")]
	[Address(RVA = "0x98B440", Offset = "0x98A640", VA = "0x18098B440")]
	private void OnClickServiceInfo()
	{
	}

	[Token(Token = "0x600522C")]
	[Address(RVA = "0x98B250", Offset = "0x98A450", VA = "0x18098B250")]
	private void OnClickGemHistory()
	{
	}

	[Token(Token = "0x600522D")]
	[Address(RVA = "0x98B220", Offset = "0x98A420", VA = "0x18098B220")]
	private void OnClickCaution()
	{
	}

	[Token(Token = "0x600522E")]
	[Address(RVA = "0x98B2A0", Offset = "0x98A4A0", VA = "0x18098B2A0")]
	private void OnClickProductWidget(ProductWidget productWidget)
	{
	}

	[Token(Token = "0x600522F")]
	[Address(RVA = "0x98C920", Offset = "0x98BB20", VA = "0x18098C920")]
	private void OpenConfirmRegDialog(int shopPaidId, ProductContext productContext, IReadOnlyDictionary<string, object> productData, List<object> confirmRegDatas)
	{
	}

	[Token(Token = "0x6005230")]
	[Address(RVA = "0x98B1F0", Offset = "0x98A3F0", VA = "0x18098B1F0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6005231")]
	[Address(RVA = "0x98D240", Offset = "0x98C440", VA = "0x18098D240")]
	private void ProcessBuyItem(int shopPaidId, IReadOnlyDictionary<string, object> productData)
	{
	}

	[Token(Token = "0x6005232")]
	[Address(RVA = "0x98A200", Offset = "0x989400", VA = "0x18098A200")]
	private void BuyResultSequence(int step, ResultCode resultCode, string resultTitle, string resultMessage)
	{
	}

	[Token(Token = "0x6005233")]
	[Address(RVA = "0x98E640", Offset = "0x98D840", VA = "0x18098E640")]
	public GemShopViewController()
	{
	}
}
