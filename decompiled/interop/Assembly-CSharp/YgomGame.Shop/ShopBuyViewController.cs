using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.DuelPreview;
using YgomGame.Menu;
using YgomGame.Shop.ProductViewer;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Shop;

[Token(Token = "0x2000975")]
public class ShopBuyViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported, IShopProductContainVC
{
	[Token(Token = "0x2000976")]
	public enum OpenMode
	{
		[Token(Token = "0x4008C15")]
		Push,
		[Token(Token = "0x4008C16")]
		PushOnHome,
		[Token(Token = "0x4008C17")]
		ReplaceOpen
	}

	[Token(Token = "0x2000977")]
	private enum CheckPurchaseFlags
	{
		[Token(Token = "0x4008C19")]
		None = 0,
		[Token(Token = "0x4008C1A")]
		DoneSubPricesSheet = 2,
		[Token(Token = "0x4008C1B")]
		DoneLimitConfirm = 4,
		[Token(Token = "0x4008C1C")]
		DoneConfirmDialog = 8
	}

	[Token(Token = "0x2000983")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShopBuyViewController _003C_003E4__this;

		[Token(Token = "0x17000795")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003A2E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000796")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003A30")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003A2B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__117(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003A2C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003A2D")]
		[Address(RVA = "0x81BDD0", Offset = "0x81AFD0", VA = "0x18081BDD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003A2F")]
		[Address(RVA = "0x81C960", Offset = "0x81BB60", VA = "0x18081C960", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000984")]
	[CompilerGenerated]
	private sealed class _003CyPlayPaging_003Ed__136 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int direction;

		[Token(Token = "0x4008C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShopBuyViewController _003C_003E4__this;

		[Token(Token = "0x4008C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _003CoutKey_003E5__2;

		[Token(Token = "0x4008C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _003CinKey_003E5__3;

		[Token(Token = "0x17000797")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003A34")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000798")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003A36")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003A31")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPaging_003Ed__136(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003A32")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003A33")]
		[Address(RVA = "0x820AD0", Offset = "0x81FCD0", VA = "0x180820AD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003A35")]
		[Address(RVA = "0x820E70", Offset = "0x820070", VA = "0x180820E70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008BBA")]
	private const string k_PrefPath = "Shop/ShopBuy";

	[Token(Token = "0x4008BBB")]
	internal const string k_PurchaseArgs_Slot = "slot";

	[Token(Token = "0x4008BBC")]
	internal const string k_RouteKey_PurchaseHandler = "purchaseHandler";

	[Token(Token = "0x4008BBD")]
	internal const string k_RouteKey_BuyRouteSchemeOpenSelectSE = "callSE";

	[Token(Token = "0x4008BBE")]
	private const string K_ArgKeyShopId = "productId";

	[Token(Token = "0x4008BBF")]
	private const string K_ArgKeyPageIdx = "pageIdx";

	[Token(Token = "0x4008BC0")]
	private const string K_ArgKeySendChangedShopIdOnLaunch = "sendChangedShopId";

	[Token(Token = "0x4008BC1")]
	private const string K_ArgKeyPageProductCollection = "pageProductCollection";

	[Token(Token = "0x4008BC2")]
	private const string K_ArgKeyConfirmSkipped = "confirmSkipped";

	[Token(Token = "0x4008BC3")]
	internal const string K_ArgKeyBlockPurchase = "blockPurchase";

	[Token(Token = "0x4008BC4")]
	internal const string K_ArgKeyBlockOtherProduct = "blockOtherProduct";

	[Token(Token = "0x4008BC5")]
	internal const string K_ResultKey_ChangedShopId = "ShopBuy_ChangedShopId";

	[Token(Token = "0x4008BC6")]
	internal const string K_ResultKey_RequestedWebApi = "ShopBuy_RequestedWebApi";

	[Token(Token = "0x4008BC7")]
	internal const string K_ResultKey_RequestDialogTitle = "ShopBuy_RequestDialogTitle";

	[Token(Token = "0x4008BC8")]
	internal const string K_ResultKey_RequestDialogMessage = "ShopBuy_RequestDialogMessage";

	[Token(Token = "0x4008BC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelHeaderTicket;

	[Token(Token = "0x4008BCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x4008BCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelAnalogScrollItem;

	[Token(Token = "0x4008BCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelShortcutButtonL1;

	[Token(Token = "0x4008BCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelShortcutButtonR1;

	[Token(Token = "0x4008BCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelShortcutIconL1;

	[Token(Token = "0x4008BCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelShortcutIconR1;

	[Token(Token = "0x4008BD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelPrevButton;

	[Token(Token = "0x4008BD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelNextButton;

	[Token(Token = "0x4008BD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelBadge;

	[Token(Token = "0x4008BD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string k_ELabelCategoryNameText;

	[Token(Token = "0x4008BD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string k_ELabelCategoryNameBorder;

	[Token(Token = "0x4008BD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string k_ELabelProductNameText;

	[Token(Token = "0x4008BD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string k_ELabelDescText;

	[Token(Token = "0x4008BD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string k_ELabelDescScrollRect;

	[Token(Token = "0x4008BD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string k_ELabelProductViewer;

	[Token(Token = "0x4008BD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string k_ELabelHighlightList;

	[Token(Token = "0x4008BDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string k_ELabelNewGroup;

	[Token(Token = "0x4008BDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string k_ELabelNewText;

	[Token(Token = "0x4008BDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string k_ELabelSpCpGroup;

	[Token(Token = "0x4008BDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string k_ELabelSpCpIconImage;

	[Token(Token = "0x4008BDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string k_ELabelInformButtonGroup;

	[Token(Token = "0x4008BDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string k_ELabelBuyButtonGroup;

	[Token(Token = "0x4008BE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string k_ELabelShortcutKeyFooterRoot;

	[Token(Token = "0x4008BE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly string k_ALabelConfirmRegDialogProductWidget;

	[Token(Token = "0x4008BE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly string k_ALabelConfirmRegDialogTextWidget;

	[Token(Token = "0x4008BE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private readonly string k_ALabelBuyActionSheetPositive;

	[Token(Token = "0x4008BE4")]
	private const string k_TLabelStyleNormal = "Style_Normal";

	[Token(Token = "0x4008BE5")]
	private const string k_TLabelStyleHighlight = "Style_Highlight";

	[Token(Token = "0x4008BE6")]
	private const string k_TLabelLimitAlert_OFF = "LimitAlert_OFF";

	[Token(Token = "0x4008BE7")]
	private const string k_TLabelLimitAlert_ON = "LimitAlert_ON";

	[Token(Token = "0x4008BE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private readonly string k_TLabelPagingNextOut;

	[Token(Token = "0x4008BE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private readonly string k_TLabelPagingBackOut;

	[Token(Token = "0x4008BEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private readonly string k_TLabelPagingNextIn;

	[Token(Token = "0x4008BEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private readonly string k_TLabelPagingBackIn;

	[Token(Token = "0x4008BEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private string[] m_CacheResourcePaths_Body;

	[Token(Token = "0x4008BED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	private string[] m_CacheResourcePaths_InformButtons;

	[Token(Token = "0x4008BEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private ResourceCacheHolderContainer.Holder m_ResourceCacheHolder;

	[Token(Token = "0x4008BEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private ShopSettings m_ShopSettings;

	[Token(Token = "0x4008BF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private ShopHeaderTicketWidget m_HeaderTicket;

	[Token(Token = "0x4008BF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private YgomGame.DuelPreview.DuelPreviewPlayer m_PreviewPlayer;

	[Token(Token = "0x4008BF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private ShopShortcutKeyFooter m_ShortcutKeyFooter;

	[Token(Token = "0x4008BF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private SelectionButton m_PrevButton;

	[Token(Token = "0x4008BF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private SelectionButton m_NextButton;

	[Token(Token = "0x4008BF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private ProductContext m_ProductContext;

	[Token(Token = "0x4008BF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private int m_PageIdx;

	[Token(Token = "0x4008BF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private IReadOnlyList<ProductContext> m_PageProducts;

	[Token(Token = "0x4008BF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private ExtendedScrollRect m_DescScrollRect;

	[Token(Token = "0x4008BF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private SelectionButton m_DescScrollRectButton;

	[Token(Token = "0x4008BFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private ProductViewerWidget m_ProductViewerWidget;

	[Token(Token = "0x4008BFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private InformButtonGroupWidget m_InformButtonGroupWidget;

	[Token(Token = "0x4008BFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private HighlightWidget m_HighlightWidget;

	[Token(Token = "0x4008BFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private BuyButtonGroupWidget m_BuyButtonGroupWidget;

	[Token(Token = "0x4008BFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private bool m_RefreshTrigger;

	[Token(Token = "0x4008BFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	private int m_PreviewMateItemId;

	[Token(Token = "0x4008C00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private int m_PreviewMateHighlightIdx;

	[Token(Token = "0x4008C01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	private bool m_ReserveHelp_DuelPreview;

	[Token(Token = "0x4008C02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x265")]
	private bool m_ReserveHelp_Market;

	[Token(Token = "0x4008C03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x266")]
	private bool m_ReserveCardFile;

	[Token(Token = "0x4008C04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private List<HighlightContext> m_HighlightContexts;

	[Token(Token = "0x4008C05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private List<IThumbPlayer> m_ViewerPlayers;

	[Token(Token = "0x4008C06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private List<int> m_CardBrowseMrks;

	[Token(Token = "0x4008C07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private List<int> m_CardBrowseRareList;

	[Token(Token = "0x4008C08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private List<HighlightContext> m_CardBrowseContexts;

	[Token(Token = "0x4008C09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private List<Tween> m_SpecialTimeTweens;

	[Token(Token = "0x4008C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private GameObject m_ActionSheetTemplate;

	[Token(Token = "0x4008C0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private bool m_ReleaseResourcesReq;

	[Token(Token = "0x4008C0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A1")]
	private bool m_ProductClosed;

	[Token(Token = "0x4008C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A2")]
	private bool m_ProductDirty;

	[Token(Token = "0x4008C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A3")]
	private bool m_AbortedBySectionMainter;

	[Token(Token = "0x4008C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private Dictionary<string, object> m_SendResultDicCache;

	[Token(Token = "0x4008C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private bool m_HasProductStructure;

	[Token(Token = "0x4008C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B1")]
	private bool m_OnLaunchCheckTutorialReserve;

	[Token(Token = "0x4008C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B2")]
	private bool m_StartedTransition;

	[Token(Token = "0x4008C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B3")]
	private bool m_BlockOnResultRequestedWebApi;

	[Token(Token = "0x17000790")]
	private Dictionary<string, object> sendResultDic
	{
		[Token(Token = "0x60039A8")]
		[Address(RVA = "0x7FF840", Offset = "0x7FEA40", VA = "0x1807FF840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000791")]
	private bool IsReady
	{
		[Token(Token = "0x60039A9")]
		[Address(RVA = "0x7FF7C0", Offset = "0x7FE9C0", VA = "0x1807FF7C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000792")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x60039AA")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000793")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60039AB")]
		[Address(RVA = "0x7FF8D0", Offset = "0x7FEAD0", VA = "0x1807FF8D0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000794")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60039AC")]
		[Address(RVA = "0x7FF800", Offset = "0x7FEA00", VA = "0x1807FF800", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60039AD")]
	[Address(RVA = "0x7F6110", Offset = "0x7F5310", VA = "0x1807F6110", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x60039AE")]
	[Address(RVA = "0x7F5F00", Offset = "0x7F5100", VA = "0x1807F5F00")]
	private string GetTLabelPagingOut(int direction)
	{
		return null;
	}

	[Token(Token = "0x60039AF")]
	[Address(RVA = "0x7F5EE0", Offset = "0x7F50E0", VA = "0x1807F5EE0")]
	private string GetTLabelPagingIn(int direction)
	{
		return null;
	}

	[Token(Token = "0x60039B0")]
	[Address(RVA = "0x7FDAA0", Offset = "0x7FCCA0", VA = "0x1807FDAA0")]
	public int TryGetCurrentShopId()
	{
		return default(int);
	}

	[Token(Token = "0x60039B1")]
	[Address(RVA = "0x49BC90", Offset = "0x49AE90", VA = "0x18049BC90")]
	public bool TryGetProductClosed()
	{
		return default(bool);
	}

	[Token(Token = "0x60039B2")]
	[Address(RVA = "0x7F5A00", Offset = "0x7F4C00", VA = "0x1807F5A00", Slot = "29")]
	public bool ContainsProduct(int shopId, bool chkBuyAble = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60039B3")]
	[Address(RVA = "0x7FA2C0", Offset = "0x7F94C0", VA = "0x1807FA2C0")]
	public static void OpenOnHome(int shopId, [Optional] int[] pageShopIds, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60039B4")]
	[Address(RVA = "0x7FA6D0", Offset = "0x7F98D0", VA = "0x1807FA6D0")]
	public static void OpenPush(bool onHome, int shopId, [Optional] int[] pageShopIds, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60039B5")]
	[Address(RVA = "0x7FA710", Offset = "0x7F9910", VA = "0x1807FA710")]
	public static void Open(int shopId, bool skipRequest = false, [Optional] int[] pageShopIds, OpenMode openMode = OpenMode.Push, [Optional] Dictionary<string, object> args, [Optional] Action onSuccess, [Optional] Action onFailed)
	{
	}

	[Token(Token = "0x60039B6")]
	[Address(RVA = "0x7FA4D0", Offset = "0x7F96D0", VA = "0x1807FA4D0")]
	public static void OpenProducts(int idx, ProductContextCollection pageProductCollection, OpenMode openMode = OpenMode.Push, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60039B7")]
	[Address(RVA = "0x7FA3C0", Offset = "0x7F95C0", VA = "0x1807FA3C0")]
	public static void OpenProducts(int idx, IReadOnlyList<ProductContext> pageProducts, OpenMode openMode = OpenMode.Push, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60039B8")]
	[Address(RVA = "0x7FA2F0", Offset = "0x7F94F0", VA = "0x1807FA2F0")]
	public static void OpenProduct(int shopId, OpenMode openMode = OpenMode.Push, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60039B9")]
	[Address(RVA = "0x7F9050", Offset = "0x7F8250", VA = "0x1807F9050")]
	public static void OpenByTicket(bool tIsPeriod, int tItemCategory, int tItemId, OpenMode openMode = OpenMode.Push, [Optional] Dictionary<string, object> args, [Optional] Action onSuccess, [Optional] Action onFailed)
	{
	}

	[Token(Token = "0x60039BA")]
	[Address(RVA = "0x7F5F20", Offset = "0x7F5120", VA = "0x1807F5F20")]
	private static void InnerOpen(OpenMode openMode = OpenMode.Push, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60039BB")]
	[Address(RVA = "0x7F4640", Offset = "0x7F3840", VA = "0x1807F4640")]
	public static void CheckLaunch(int shopId, bool skipRequest, Action onSuccess, [Optional] Action onFailed)
	{
	}

	[Token(Token = "0x60039BC")]
	[Address(RVA = "0x7F63A0", Offset = "0x7F55A0", VA = "0x1807F63A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60039BD")]
	[Address(RVA = "0x7F7960", Offset = "0x7F6B60", VA = "0x1807F7960", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60039BE")]
	[Address(RVA = "0x7F8560", Offset = "0x7F7760", VA = "0x1807F8560")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60039BF")]
	[Address(RVA = "0x7FD9B0", Offset = "0x7FCBB0", VA = "0x1807FD9B0")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__117))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60039C0")]
	[Address(RVA = "0x7F5CE0", Offset = "0x7F4EE0", VA = "0x1807F5CE0")]
	private Vector2 GetAnalogScrollInput()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60039C1")]
	[Address(RVA = "0x7FDA20", Offset = "0x7FCC20", VA = "0x1807FDA20", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60039C2")]
	[Address(RVA = "0x7FDA30", Offset = "0x7FCC30", VA = "0x1807FDA30", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60039C3")]
	[Address(RVA = "0x7F8FB0", Offset = "0x7F81B0", VA = "0x1807F8FB0", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x60039C4")]
	[Address(RVA = "0x7F8530", Offset = "0x7F7730", VA = "0x1807F8530")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60039C5")]
	[Address(RVA = "0x7F85A0", Offset = "0x7F77A0", VA = "0x1807F85A0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x60039C6")]
	[Address(RVA = "0x7FDBD0", Offset = "0x7FCDD0", VA = "0x1807FDBD0")]
	private void TryResumeThumbRoll()
	{
	}

	[Token(Token = "0x60039C7")]
	[Address(RVA = "0x7F8DA0", Offset = "0x7F7FA0", VA = "0x1807F8DA0", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60039C8")]
	[Address(RVA = "0x7FD4E0", Offset = "0x7FC6E0", VA = "0x1807FD4E0")]
	private void ReleaseResources()
	{
	}

	[Token(Token = "0x60039C9")]
	[Address(RVA = "0x7FA840", Offset = "0x7F9A40", VA = "0x1807FA840")]
	private void PopAllBuyVc()
	{
	}

	[Token(Token = "0x60039CA")]
	[Address(RVA = "0x7F6B10", Offset = "0x7F5D10", VA = "0x1807F6B10", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60039CB")]
	[Address(RVA = "0x7F69B0", Offset = "0x7F5BB0", VA = "0x1807F69B0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60039CC")]
	[Address(RVA = "0x7F7340", Offset = "0x7F6540", VA = "0x1807F7340")]
	private void ToNextPage()
	{
	}

	[Token(Token = "0x60039CD")]
	[Address(RVA = "0x7F76F0", Offset = "0x7F68F0", VA = "0x1807F76F0")]
	private void ToPrevPage()
	{
	}

	[Token(Token = "0x60039CE")]
	[Address(RVA = "0x7F4410", Offset = "0x7F3610", VA = "0x1807F4410")]
	private void ChangePage(int dstIdx, int direction = 0)
	{
	}

	[Token(Token = "0x60039CF")]
	[Address(RVA = "0x7FFC10", Offset = "0x7FEE10", VA = "0x1807FFC10")]
	[IteratorStateMachine(typeof(_003CyPlayPaging_003Ed__136))]
	private IEnumerator yPlayPaging(int direction = 0)
	{
		return null;
	}

	[Token(Token = "0x60039D0")]
	[Address(RVA = "0x7F58A0", Offset = "0x7F4AA0", VA = "0x1807F58A0")]
	private void CheckTutorialOpen()
	{
	}

	[Token(Token = "0x60039D1")]
	[Address(RVA = "0x7FAEB0", Offset = "0x7FA0B0", VA = "0x1807FAEB0")]
	private void RefreshPageButtons()
	{
	}

	[Token(Token = "0x60039D2")]
	[Address(RVA = "0x7FAE00", Offset = "0x7FA000", VA = "0x1807FAE00")]
	private void RefreshDuelLiveButton()
	{
	}

	[Token(Token = "0x60039D3")]
	[Address(RVA = "0x7FBAF0", Offset = "0x7FACF0", VA = "0x1807FBAF0")]
	private void RefreshProduct()
	{
	}

	[Token(Token = "0x60039D4")]
	[Address(RVA = "0x7FB060", Offset = "0x7FA260", VA = "0x1807FB060")]
	private void RefreshProductStatus()
	{
	}

	[Token(Token = "0x60039D5")]
	[Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
	private void RefreshTicketGroup()
	{
	}

	[Token(Token = "0x60039D6")]
	[Address(RVA = "0x7FD8D0", Offset = "0x7FCAD0", VA = "0x1807FD8D0")]
	private void SetLimitAlertStyle(bool isAlertOn)
	{
	}

	[Token(Token = "0x60039D7")]
	[Address(RVA = "0x7F7340", Offset = "0x7F6540", VA = "0x1807F7340")]
	private void OnClickNextButton()
	{
	}

	[Token(Token = "0x60039D8")]
	[Address(RVA = "0x7F76F0", Offset = "0x7F68F0", VA = "0x1807F76F0")]
	private void OnClickPrevButton()
	{
	}

	[Token(Token = "0x60039D9")]
	[Address(RVA = "0x7F89E0", Offset = "0x7F7BE0", VA = "0x1807F89E0")]
	private void OnInputDescScrollAnalogDirection(Vector2 vec)
	{
	}

	[Token(Token = "0x60039DA")]
	[Address(RVA = "0x7F8740", Offset = "0x7F7940", VA = "0x1807F8740")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x60039DB")]
	[Address(RVA = "0x7F8810", Offset = "0x7F7A10", VA = "0x1807F8810")]
	private bool OnInputAnalogScroll(Vector2 mainVec)
	{
		return default(bool);
	}

	[Token(Token = "0x60039DC")]
	[Address(RVA = "0x7F7890", Offset = "0x7F6A90", VA = "0x1807F7890")]
	private void OnClickShortcutL1()
	{
	}

	[Token(Token = "0x60039DD")]
	[Address(RVA = "0x7F78E0", Offset = "0x7F6AE0", VA = "0x1807F78E0")]
	private void OnClickShortcutR1()
	{
	}

	[Token(Token = "0x60039DE")]
	[Address(RVA = "0x7F7930", Offset = "0x7F6B30", VA = "0x1807F7930")]
	private void OnClickTicketHeader()
	{
	}

	[Token(Token = "0x60039DF")]
	[Address(RVA = "0x7F72C0", Offset = "0x7F64C0", VA = "0x1807F72C0")]
	private void OnClickMate()
	{
	}

	[Token(Token = "0x60039E0")]
	[Address(RVA = "0x7F7360", Offset = "0x7F6560", VA = "0x1807F7360")]
	private void OnClickPlayShortcut()
	{
	}

	[Token(Token = "0x60039E1")]
	[Address(RVA = "0x7F6D70", Offset = "0x7F5F70", VA = "0x1807F6D70")]
	private void OnClickDuelLive()
	{
	}

	[Token(Token = "0x60039E2")]
	[Address(RVA = "0x7FEBA0", Offset = "0x7FDDA0", VA = "0x1807FEBA0")]
	private void UpdateHighlightWidgetGamePad()
	{
	}

	[Token(Token = "0x60039E3")]
	[Address(RVA = "0x7FEF20", Offset = "0x7FE120", VA = "0x1807FEF20")]
	private void UpdateShortcutIcon()
	{
	}

	[Token(Token = "0x60039E4")]
	[Address(RVA = "0x7FE740", Offset = "0x7FD940", VA = "0x1807FE740")]
	private void UpdateFooter()
	{
	}

	[Token(Token = "0x60039E5")]
	[Address(RVA = "0x7F9020", Offset = "0x7F8220", VA = "0x1807F9020")]
	private void OnUpInputHilightThumb()
	{
	}

	[Token(Token = "0x60039E6")]
	[Address(RVA = "0x7F6F20", Offset = "0x7F6120", VA = "0x1807F6F20")]
	private void OnClickHilightThumb(HighlightWidget.IThumbWidget thumbWidget)
	{
	}

	[Token(Token = "0x60039E7")]
	[Address(RVA = "0x7F6E10", Offset = "0x7F6010", VA = "0x1807F6E10")]
	private void OnClickHilightPlay(HighlightWidget.IThumbWidget thumbWidget)
	{
	}

	[Token(Token = "0x60039E8")]
	[Address(RVA = "0x7F8350", Offset = "0x7F7550", VA = "0x1807F8350")]
	private void OnDeviceChange(SelectorManager.InputDevice inputDevice)
	{
	}

	[Token(Token = "0x60039E9")]
	[Address(RVA = "0x7F6D10", Offset = "0x7F5F10", VA = "0x1807F6D10")]
	private void OnChangedSelectionItem(SelectionItem prevItem, SelectionItem currentItem)
	{
	}

	[Token(Token = "0x60039EA")]
	[Address(RVA = "0x7F7710", Offset = "0x7F6910", VA = "0x1807F7710")]
	private void OnClickProductBuy(PriceContext priceContext, CheckPurchaseFlags checkPurchaseFlags = CheckPurchaseFlags.None)
	{
	}

	[Token(Token = "0x60039EB")]
	[Address(RVA = "0x7F52C0", Offset = "0x7F44C0", VA = "0x1807F52C0")]
	private bool CheckPurchaseSubPricesSelect(PriceContext priceContext, CheckPurchaseFlags checkPurchaseFlags)
	{
		return default(bool);
	}

	[Token(Token = "0x60039EC")]
	[Address(RVA = "0x7FDAC0", Offset = "0x7FCCC0", VA = "0x1807FDAC0")]
	private bool TryOpenActionScheme(PriceContext priceContext)
	{
		return default(bool);
	}

	[Token(Token = "0x60039ED")]
	[Address(RVA = "0x7F4AD0", Offset = "0x7F3CD0", VA = "0x1807F4AD0")]
	private bool CheckPurchaseLimitConfirm(PriceContext priceContext, CheckPurchaseFlags checkPurchaseFlags)
	{
		return default(bool);
	}

	[Token(Token = "0x60039EE")]
	[Address(RVA = "0x7F4EB0", Offset = "0x7F40B0", VA = "0x1807F4EB0")]
	private bool CheckPurchasePayItemHave(PriceContext priceContext)
	{
		return default(bool);
	}

	[Token(Token = "0x60039EF")]
	[Address(RVA = "0x7F4910", Offset = "0x7F3B10", VA = "0x1807F4910")]
	private bool CheckPurchaseConfirmDialog(PriceContext priceContext, CheckPurchaseFlags checkPurchaseFlags)
	{
		return default(bool);
	}

	[Token(Token = "0x60039F0")]
	[Address(RVA = "0x7F9180", Offset = "0x7F8380", VA = "0x1807F9180")]
	private void OpenConfirmPurchase(PriceContext priceContext)
	{
	}

	[Token(Token = "0x60039F1")]
	[Address(RVA = "0x7F6180", Offset = "0x7F5380", VA = "0x1807F6180")]
	private string MakeConfirmPurchaseText(PriceContext priceContext, bool isGemPrice, string priceItemName)
	{
		return null;
	}

	[Token(Token = "0x60039F2")]
	[Address(RVA = "0x7FD5A0", Offset = "0x7FC7A0", VA = "0x1807FD5A0")]
	private void RequestBuyProduct(ShopPurchase.RequestPurchaseDelegate requestPurchaseDelegate, PriceContext priceContext, [Optional] Dictionary<string, object> purchaseArgs, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60039F3")]
	[Address(RVA = "0x7F8AE0", Offset = "0x7F7CE0", VA = "0x1807F8AE0")]
	private void OnModifyProductRequestComplete()
	{
	}

	[Token(Token = "0x60039F4")]
	[Address(RVA = "0x7F40C0", Offset = "0x7F32C0", VA = "0x1807F40C0")]
	private void BuyAfterRefresh(bool isSuccess, bool tryFocus = false, bool doneChkRequireGetList = false)
	{
	}

	[Token(Token = "0x60039F5")]
	[Address(RVA = "0x7F5A80", Offset = "0x7F4C80", VA = "0x1807F5A80")]
	private bool ExistsAllProducts()
	{
		return default(bool);
	}

	[Token(Token = "0x60039F6")]
	[Address(RVA = "0x7FD210", Offset = "0x7FC410", VA = "0x1807FD210")]
	private void ReimportExistsProducts()
	{
	}

	[Token(Token = "0x60039F7")]
	[Address(RVA = "0x7FA8E0", Offset = "0x7F9AE0", VA = "0x1807FA8E0")]
	private void PostProcessBuySuccessResult(bool skipResult = false)
	{
	}

	[Token(Token = "0x60039F8")]
	[Address(RVA = "0x7FF070", Offset = "0x7FE270", VA = "0x1807FF070")]
	public ShopBuyViewController()
	{
	}
}
