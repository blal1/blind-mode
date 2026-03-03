using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x200098E")]
public class HighlightWidget : ElementWidgetBase
{
	[Token(Token = "0x200098F")]
	public interface IThumbWidget
	{
		[Token(Token = "0x170007B3")]
		ShopDef.HighlightType highlightType
		{
			[Token(Token = "0x6003A90")]
			get;
		}

		[Token(Token = "0x170007B4")]
		int page
		{
			[Token(Token = "0x6003A91")]
			get;
		}

		[Token(Token = "0x170007B5")]
		int idx
		{
			[Token(Token = "0x6003A92")]
			get;
		}

		[Token(Token = "0x170007B6")]
		bool isHead
		{
			[Token(Token = "0x6003A93")]
			get;
		}

		[Token(Token = "0x170007B7")]
		int widthAmount
		{
			[Token(Token = "0x6003A94")]
			get;
		}

		[Token(Token = "0x170007B8")]
		SelectionButton button
		{
			[Token(Token = "0x6003A95")]
			get;
		}

		[Token(Token = "0x170007B9")]
		GameObject playRoot
		{
			[Token(Token = "0x6003A96")]
			get;
		}

		[Token(Token = "0x170007BA")]
		SelectionButton playButton
		{
			[Token(Token = "0x6003A97")]
			get;
		}

		[Token(Token = "0x1400003D")]
		event Action<IThumbWidget> onClickEvent;

		[Token(Token = "0x1400003E")]
		event Action<IThumbWidget> onClickPlayEvent;

		[Token(Token = "0x6003A9C")]
		void ReleaseResources();
	}

	[Token(Token = "0x2000990")]
	public class PageWidget : ElementWidgetBase
	{
		[Token(Token = "0x2000991")]
		public abstract class ThumbBase : ElementWidgetBase, IThumbWidget
		{
			[Token(Token = "0x4008CB9")]
			[FieldOffset(Offset = "0x20")]
			private readonly string k_ELabel_ThumbButton;

			[Token(Token = "0x4008CBA")]
			[FieldOffset(Offset = "0x28")]
			private readonly string k_ELabel_PlayRoot;

			[Token(Token = "0x4008CBB")]
			[FieldOffset(Offset = "0x30")]
			private readonly string k_ELabel_PlayButton;

			[Token(Token = "0x4008CBC")]
			[FieldOffset(Offset = "0x38")]
			private readonly string k_ELabel_DXIcon;

			[Token(Token = "0x4008CC1")]
			[FieldOffset(Offset = "0x60")]
			public readonly int page;

			[Token(Token = "0x4008CC2")]
			[FieldOffset(Offset = "0x64")]
			public readonly int idx;

			[Token(Token = "0x4008CC3")]
			[FieldOffset(Offset = "0x68")]
			public BindingShopProductThumb bindingShopThumb;

			[Token(Token = "0x170007BB")]
			public SelectionButton button
			{
				[Token(Token = "0x6003AA1")]
				[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850", Slot = "15")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003AA2")]
				[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170007BC")]
			public GameObject playRoot
			{
				[Token(Token = "0x6003AA3")]
				[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "16")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003AA4")]
				[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170007BD")]
			public SelectionButton playButton
			{
				[Token(Token = "0x6003AA5")]
				[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "17")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003AA6")]
				[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170007BE")]
			public GameObject dxIcon
			{
				[Token(Token = "0x6003AA7")]
				[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003AA8")]
				[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170007BF")]
			public abstract int widthAmount
			{
				[Token(Token = "0x6003AA9")]
				get;
			}

			[Token(Token = "0x170007C0")]
			public abstract ShopDef.HighlightType highlightType
			{
				[Token(Token = "0x6003AAA")]
				get;
			}

			[Token(Token = "0x170007C1")]
			public bool isHead
			{
				[Token(Token = "0x6003AAB")]
				[Address(RVA = "0x81BBF0", Offset = "0x81ADF0", VA = "0x18081BBF0", Slot = "13")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170007C2")]
			public bool interactable
			{
				[Token(Token = "0x6003AAC")]
				[Address(RVA = "0x81BBC0", Offset = "0x81ADC0", VA = "0x18081BBC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003AAD")]
				[Address(RVA = "0x81BD70", Offset = "0x81AF70", VA = "0x18081BD70")]
				set
				{
				}
			}

			[Token(Token = "0x170007C3")]
			private int YgomGame_002EShop_002EHighlightWidget_002EIThumbWidget_002Epage
			{
				[Token(Token = "0x6003AAE")]
				[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880", Slot = "11")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170007C4")]
			private int YgomGame_002EShop_002EHighlightWidget_002EIThumbWidget_002Eidx
			{
				[Token(Token = "0x6003AAF")]
				[Address(RVA = "0x80A510", Offset = "0x809710", VA = "0x18080A510", Slot = "12")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1400003F")]
			public event Action<IThumbWidget> onClickEvent
			{
				[Token(Token = "0x6003AB0")]
				[Address(RVA = "0x81BA60", Offset = "0x81AC60", VA = "0x18081BA60", Slot = "18")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6003AB1")]
				[Address(RVA = "0x81BC00", Offset = "0x81AE00", VA = "0x18081BC00", Slot = "19")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Token(Token = "0x14000040")]
			public event Action<IThumbWidget> onClickPlayEvent
			{
				[Token(Token = "0x6003AB2")]
				[Address(RVA = "0x81BB10", Offset = "0x81AD10", VA = "0x18081BB10", Slot = "20")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6003AB3")]
				[Address(RVA = "0x81BCB0", Offset = "0x81AEB0", VA = "0x18081BCB0", Slot = "21")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Token(Token = "0x6003AB4")]
			[Address(RVA = "0x81B660", Offset = "0x81A860", VA = "0x18081B660")]
			public ThumbBase(ElementObjectManager eom, int page, int idx, HighlightContext context)
			{
			}

			[Token(Token = "0x6003AB5")]
			[Address(RVA = "0x81B640", Offset = "0x81A840", VA = "0x18081B640")]
			private void OnClick()
			{
			}

			[Token(Token = "0x6003AB6")]
			[Address(RVA = "0x81B620", Offset = "0x81A820", VA = "0x18081B620")]
			private void OnClickPlay()
			{
			}

			[Token(Token = "0x6003AB7")]
			public abstract void ReleaseResources();
		}

		[Token(Token = "0x2000993")]
		public class CardThumbWidget : ThumbBase, IThumbWidget
		{
			[Token(Token = "0x4008CC8")]
			[FieldOffset(Offset = "0x80")]
			private readonly string k_ELabelCardImage;

			[Token(Token = "0x4008CC9")]
			[FieldOffset(Offset = "0x88")]
			private readonly string k_ELabelRarityIcon;

			[Token(Token = "0x4008CCA")]
			[FieldOffset(Offset = "0x90")]
			public readonly int mrk;

			[Token(Token = "0x170007C5")]
			public override int widthAmount
			{
				[Token(Token = "0x6003ABB")]
				[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "23")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170007C6")]
			public override ShopDef.HighlightType highlightType
			{
				[Token(Token = "0x6003ABC")]
				[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "24")]
				get
				{
					return default(ShopDef.HighlightType);
				}
			}

			[Token(Token = "0x6003ABD")]
			[Address(RVA = "0x80FF00", Offset = "0x80F100", VA = "0x18080FF00")]
			public CardThumbWidget(ElementObjectManager eom, int page, int idx, HighlightContext context)
			{
			}

			[Token(Token = "0x6003ABE")]
			[Address(RVA = "0x80FE50", Offset = "0x80F050", VA = "0x18080FE50", Slot = "25")]
			public override void ReleaseResources()
			{
			}
		}

		[Token(Token = "0x2000994")]
		public class WideThumbWidget : ThumbBase, IThumbWidget
		{
			[Token(Token = "0x4008CCB")]
			[FieldOffset(Offset = "0x80")]
			private readonly string k_ELabelThumbImage;

			[Token(Token = "0x4008CCC")]
			[FieldOffset(Offset = "0x88")]
			public readonly string thumbPath;

			[Token(Token = "0x170007C7")]
			public override int widthAmount
			{
				[Token(Token = "0x6003ABF")]
				[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "23")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170007C8")]
			public override ShopDef.HighlightType highlightType
			{
				[Token(Token = "0x6003AC0")]
				[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "24")]
				get
				{
					return default(ShopDef.HighlightType);
				}
			}

			[Token(Token = "0x6003AC1")]
			[Address(RVA = "0x821330", Offset = "0x820530", VA = "0x180821330")]
			public WideThumbWidget(ElementObjectManager eom, int page, int idx, HighlightContext context)
			{
			}

			[Token(Token = "0x6003AC2")]
			[Address(RVA = "0x821310", Offset = "0x820510", VA = "0x180821310", Slot = "25")]
			public override void ReleaseResources()
			{
			}
		}

		[Token(Token = "0x4008CB5")]
		[FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelCardThumbTemplate;

		[Token(Token = "0x4008CB6")]
		[FieldOffset(Offset = "0x28")]
		private readonly string k_ELabelWideThumbTemplate;

		[Token(Token = "0x4008CB7")]
		[FieldOffset(Offset = "0x30")]
		private readonly ElementObjectManager m_CardThumbTemplate;

		[Token(Token = "0x4008CB8")]
		[FieldOffset(Offset = "0x38")]
		private readonly ElementObjectManager m_WideThumbTemplate;

		[Token(Token = "0x6003A9D")]
		[Address(RVA = "0x818E70", Offset = "0x818070", VA = "0x180818E70")]
		public PageWidget(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6003A9E")]
		[Address(RVA = "0x818C90", Offset = "0x817E90", VA = "0x180818C90")]
		public IThumbWidget CreateThumb(HighlightContext context, int page, int idx, int shopId, ShopSettings shopSettings)
		{
			return null;
		}

		[Token(Token = "0x6003A9F")]
		[Address(RVA = "0x8189D0", Offset = "0x817BD0", VA = "0x1808189D0")]
		private IThumbWidget CreateCardThumb(HighlightContext context, int page, int idx)
		{
			return null;
		}

		[Token(Token = "0x6003AA0")]
		[Address(RVA = "0x818D40", Offset = "0x817F40", VA = "0x180818D40")]
		private IThumbWidget CreateWideThumb(HighlightContext context, int page, int idx)
		{
			return null;
		}
	}

	[Token(Token = "0x2000996")]
	[CompilerGenerated]
	private sealed class _003CyMovePage_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008CD0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008CD1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008CD2")]
		[FieldOffset(Offset = "0x20")]
		public HighlightWidget _003C_003E4__this;

		[Token(Token = "0x4008CD3")]
		[FieldOffset(Offset = "0x28")]
		public int dstPage;

		[Token(Token = "0x4008CD4")]
		[FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x170007C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003AC8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003ACA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003AC5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMovePage_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003AC6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003AC7")]
		[Address(RVA = "0x81FFA0", Offset = "0x81F1A0", VA = "0x18081FFA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x820060", Offset = "0x81F260", VA = "0x180820060", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008CA5")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelPageTemplate;

	[Token(Token = "0x4008CA6")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_IndicatorChildTemplate;

	[Token(Token = "0x4008CA7")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_PrevButton;

	[Token(Token = "0x4008CA8")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_NextButton;

	[Token(Token = "0x4008CA9")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_PrevShortcutIcon;

	[Token(Token = "0x4008CAA")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_NextShortcutIcon;

	[Token(Token = "0x4008CAB")]
	[FieldOffset(Offset = "0x50")]
	private readonly int k_PageChildAmountMax;

	[Token(Token = "0x4008CAC")]
	[FieldOffset(Offset = "0x58")]
	private readonly ScrollRectPageSnap m_PageSnap;

	[Token(Token = "0x4008CAD")]
	[FieldOffset(Offset = "0x60")]
	private readonly SelectionButton m_PrevButton;

	[Token(Token = "0x4008CAE")]
	[FieldOffset(Offset = "0x68")]
	private readonly SelectionButton m_NextButton;

	[Token(Token = "0x4008CAF")]
	[FieldOffset(Offset = "0x70")]
	public readonly Selector selector;

	[Token(Token = "0x4008CB0")]
	[FieldOffset(Offset = "0x78")]
	public IReadOnlyList<HighlightContext> contexts;

	[Token(Token = "0x4008CB1")]
	[FieldOffset(Offset = "0x80")]
	public List<IThumbWidget> m_ThumbWidgets;

	[Token(Token = "0x4008CB2")]
	[FieldOffset(Offset = "0x88")]
	public Action onUpInputCallback;

	[Token(Token = "0x170007AF")]
	public SelectionButton prevButton
	{
		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007B0")]
	public SelectionButton nextButton
	{
		[Token(Token = "0x6003A77")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007B1")]
	public bool existPage
	{
		[Token(Token = "0x6003A78")]
		[Address(RVA = "0x813430", Offset = "0x812630", VA = "0x180813430")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170007B2")]
	public bool shortcutIconVisible
	{
		[Token(Token = "0x6003A79")]
		[Address(RVA = "0x813490", Offset = "0x812690", VA = "0x180813490")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003A7A")]
		[Address(RVA = "0x813680", Offset = "0x812880", VA = "0x180813680")]
		set
		{
		}
	}

	[Token(Token = "0x1400003B")]
	public event Action<IThumbWidget> onClickThumbEvent
	{
		[Token(Token = "0x6003A7B")]
		[Address(RVA = "0x813370", Offset = "0x812570", VA = "0x180813370")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x8135C0", Offset = "0x8127C0", VA = "0x1808135C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400003C")]
	public event Action<IThumbWidget> onClickPlayEvent
	{
		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x8132B0", Offset = "0x8124B0", VA = "0x1808132B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003A7E")]
		[Address(RVA = "0x813500", Offset = "0x812700", VA = "0x180813500")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003A7F")]
	[Address(RVA = "0x812F00", Offset = "0x812100", VA = "0x180812F00")]
	public HighlightWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003A80")]
	[Address(RVA = "0x811F90", Offset = "0x811190", VA = "0x180811F90")]
	public void SetContexts(IReadOnlyList<HighlightContext> contexts, ProductContext productCtx, ShopSettings shopSettings, Func<HighlightContext, ProductContext, bool> showPlayFunc)
	{
	}

	[Token(Token = "0x6003A81")]
	[Address(RVA = "0x812CB0", Offset = "0x811EB0", VA = "0x180812CB0")]
	private void UpdateButtons()
	{
	}

	[Token(Token = "0x6003A82")]
	[Address(RVA = "0x811770", Offset = "0x810970", VA = "0x180811770")]
	private void PlayIndicatorsTween()
	{
	}

	[Token(Token = "0x6003A83")]
	[Address(RVA = "0x8112B0", Offset = "0x8104B0", VA = "0x1808112B0")]
	private PageWidget CreatePageWidget(ElementObjectManager template)
	{
		return null;
	}

	[Token(Token = "0x6003A84")]
	[Address(RVA = "0x811200", Offset = "0x810400", VA = "0x180811200")]
	private GameObject CreateIndicatorChild(GameObject template)
	{
		return null;
	}

	[Token(Token = "0x6003A85")]
	[Address(RVA = "0x8114A0", Offset = "0x8106A0", VA = "0x1808114A0")]
	public bool FocusItem(int idx, bool select = false, bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A86")]
	[Address(RVA = "0x811CE0", Offset = "0x810EE0", VA = "0x180811CE0")]
	public bool SelectEdgeRightItem(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A87")]
	[Address(RVA = "0x8115E0", Offset = "0x8107E0", VA = "0x1808115E0")]
	private void MovePage(int dstPage)
	{
	}

	[Token(Token = "0x6003A88")]
	[Address(RVA = "0x813730", Offset = "0x812930", VA = "0x180813730")]
	[IteratorStateMachine(typeof(_003CyMovePage_003Ed__40))]
	private IEnumerator yMovePage(int dstPage, Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6003A89")]
	[Address(RVA = "0x811B30", Offset = "0x810D30", VA = "0x180811B30")]
	public void ReleaseResources()
	{
	}
}
