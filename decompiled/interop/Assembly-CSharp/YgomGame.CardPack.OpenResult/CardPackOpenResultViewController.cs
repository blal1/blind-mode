using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Menu;
using YgomGame.Shop;
using YgomSystem.UI;

namespace YgomGame.CardPack.OpenResult;

[Token(Token = "0x2001538")]
public class CardPackOpenResultViewController : BaseMenuViewController
{
	[Token(Token = "0x200153B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x400CBC0")]
		[FieldOffset(Offset = "0x10")]
		public bool playingObtainView;

		[Token(Token = "0x6008339")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x600833A")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CCheckOpenNotices_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200153C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_1
	{
		[Token(Token = "0x400CBC1")]
		[FieldOffset(Offset = "0x10")]
		public bool playingNextFinalizeDialog;

		[Token(Token = "0x600833B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_1()
		{
		}

		[Token(Token = "0x600833C")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CCheckOpenNotices_003Eb__1()
		{
		}
	}

	[Token(Token = "0x200153D")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_2
	{
		[Token(Token = "0x400CBC2")]
		[FieldOffset(Offset = "0x10")]
		public bool reservedMatchRewardResult;

		[Token(Token = "0x400CBC3")]
		[FieldOffset(Offset = "0x11")]
		public bool waitingToastComplete;

		[Token(Token = "0x400CBC4")]
		[FieldOffset(Offset = "0x12")]
		public bool playingObtainItems;

		[Token(Token = "0x600833D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_2()
		{
		}

		[Token(Token = "0x600833E")]
		[Address(RVA = "0xCCC5D0", Offset = "0xCCB7D0", VA = "0x180CCC5D0")]
		internal void _003CCheckOpenNotices_003Eb__3()
		{
		}

		[Token(Token = "0x600833F")]
		[Address(RVA = "0xCCC5E0", Offset = "0xCCB7E0", VA = "0x180CCC5E0")]
		internal void _003CCheckOpenNotices_003Eb__4()
		{
		}

		[Token(Token = "0x6008340")]
		[Address(RVA = "0xCCC5C0", Offset = "0xCCB7C0", VA = "0x180CCC5C0")]
		internal void _003CCheckOpenNotices_003Eb__2()
		{
		}
	}

	[Token(Token = "0x200153E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_3
	{
		[Token(Token = "0x400CBC5")]
		[FieldOffset(Offset = "0x10")]
		public bool playingMatchProductReward;

		[Token(Token = "0x6008341")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_3()
		{
		}

		[Token(Token = "0x6008342")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CCheckOpenNotices_003Eb__5()
		{
		}
	}

	[Token(Token = "0x2001540")]
	[CompilerGenerated]
	private sealed class _003CCheckOpenNotices_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CBC8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CBC9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CBCA")]
		[FieldOffset(Offset = "0x20")]
		public CardPackOpenResultViewController _003C_003E4__this;

		[Token(Token = "0x400CBCB")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		[Token(Token = "0x400CBCC")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass37_1 _003C_003E8__2;

		[Token(Token = "0x400CBCD")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass37_2 _003C_003E8__3;

		[Token(Token = "0x400CBCE")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass37_3 _003C_003E8__4;

		[Token(Token = "0x400CBCF")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, object> _003CshopPurchaseResult_003E5__2;

		[Token(Token = "0x17001403")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008348")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001404")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600834A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008345")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckOpenNotices_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008346")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008347")]
		[Address(RVA = "0xCCB3E0", Offset = "0xCCA5E0", VA = "0x180CCB3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008349")]
		[Address(RVA = "0xCCBFC0", Offset = "0xCCB1C0", VA = "0x180CCBFC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001541")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CBD0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CBD1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CBD2")]
		[FieldOffset(Offset = "0x20")]
		public CardPackOpenResultViewController _003C_003E4__this;

		[Token(Token = "0x17001405")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600834E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001406")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008350")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600834B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600834C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600834D")]
		[Address(RVA = "0xCCC000", Offset = "0xCCB200", VA = "0x180CCC000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600834F")]
		[Address(RVA = "0xCCC100", Offset = "0xCCB300", VA = "0x180CCC100", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CBA5")]
	internal const string k_ArgKey_OpenFoundedSecretWithOnHome = "OpenFoundedSecretWithOnHome";

	[Token(Token = "0x400CBA6")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x400CBA7")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelObtainedCardsRoot;

	[Token(Token = "0x400CBA8")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelFoundedSecretPacksRoot;

	[Token(Token = "0x400CBA9")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelShowOwnedNumToggle;

	[Token(Token = "0x400CBAA")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelFootBar;

	[Token(Token = "0x400CBAB")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelOKButton;

	[Token(Token = "0x400CBAC")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelCardFileButton;

	[Token(Token = "0x400CBAD")]
	[FieldOffset(Offset = "0x108")]
	private bool m_ReadyWork;

	[Token(Token = "0x400CBAE")]
	[FieldOffset(Offset = "0x109")]
	private bool m_ReadyBinding;

	[Token(Token = "0x400CBAF")]
	[FieldOffset(Offset = "0x110")]
	private Dictionary<string, object> m_GachaResultWork;

	[Token(Token = "0x400CBB0")]
	[FieldOffset(Offset = "0x118")]
	private List<object> m_DrawDatas;

	[Token(Token = "0x400CBB1")]
	[FieldOffset(Offset = "0x120")]
	private List<object> m_ExtraPackGroups;

	[Token(Token = "0x400CBB2")]
	[FieldOffset(Offset = "0x128")]
	private List<int> m_SecretPackIds;

	[Token(Token = "0x400CBB3")]
	[FieldOffset(Offset = "0x130")]
	private readonly List<ProductContext> m_SecretPackContexts;

	[Token(Token = "0x400CBB4")]
	[FieldOffset(Offset = "0x138")]
	private Selector m_FootBarSelector;

	[Token(Token = "0x400CBB5")]
	[FieldOffset(Offset = "0x140")]
	private ObtainedCardsWidget m_ObtainedCardsWidget;

	[Token(Token = "0x400CBB6")]
	[FieldOffset(Offset = "0x148")]
	private FoundedSecretPacksWidget m_FoundedSecretPacksWidget;

	[Token(Token = "0x400CBB7")]
	[FieldOffset(Offset = "0x150")]
	private bool m_OpenFoundedSecretTrigger;

	[Token(Token = "0x400CBB8")]
	[FieldOffset(Offset = "0x151")]
	private bool m_OpenNextFinalizedURTrigger;

	[Token(Token = "0x400CBB9")]
	[FieldOffset(Offset = "0x158")]
	private (EntryItemListData itemListData, bool isSendPresent, bool isDone) m_PlayObtainItems;

	[Token(Token = "0x400CBBA")]
	[FieldOffset(Offset = "0x168")]
	private TransitionType m_TransitionType;

	[Token(Token = "0x170013FF")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600831F")]
		[Address(RVA = "0xCB6B00", Offset = "0xCB5D00", VA = "0x180CB6B00", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001400")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6008320")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001401")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x6008321")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001402")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6008322")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008323")]
	[Address(RVA = "0xCB59F0", Offset = "0xCB4BF0", VA = "0x180CB59F0")]
	public static void SwapOpen(ViewController fromVc, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6008324")]
	[Address(RVA = "0xCB4490", Offset = "0xCB3690", VA = "0x180CB4490", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008325")]
	[Address(RVA = "0xCB4AE0", Offset = "0xCB3CE0", VA = "0x180CB4AE0")]
	private void SetupWork(bool tryRecover)
	{
	}

	[Token(Token = "0x6008326")]
	[Address(RVA = "0xCB4800", Offset = "0xCB3A00", VA = "0x180CB4800", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008327")]
	[Address(RVA = "0xCB5A50", Offset = "0xCB4C50", VA = "0x180CB5A50")]
	private void TryBindingView()
	{
	}

	[Token(Token = "0x6008328")]
	[Address(RVA = "0xCB4AB0", Offset = "0xCB3CB0", VA = "0x180CB4AB0", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6008329")]
	[Address(RVA = "0xCB5980", Offset = "0xCB4B80", VA = "0x180CB5980")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__36))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600832A")]
	[Address(RVA = "0xCB4420", Offset = "0xCB3620", VA = "0x180CB4420")]
	[IteratorStateMachine(typeof(_003CCheckOpenNotices_003Ed__37))]
	private IEnumerator CheckOpenNotices()
	{
		return null;
	}

	[Token(Token = "0x600832B")]
	[Address(RVA = "0xCB49D0", Offset = "0xCB3BD0", VA = "0x180CB49D0")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x600832C")]
	[Address(RVA = "0xCB4650", Offset = "0xCB3850", VA = "0x180CB4650")]
	private void OnClickPack(ProductContext packProductContext)
	{
	}

	[Token(Token = "0x600832D")]
	[Address(RVA = "0xCB4810", Offset = "0xCB3A10", VA = "0x180CB4810")]
	private void OnDecidedOpenSecretPacks(int shopId)
	{
	}

	[Token(Token = "0x600832E")]
	[Address(RVA = "0xCB44C0", Offset = "0xCB36C0", VA = "0x180CB44C0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600832F")]
	[Address(RVA = "0xCB4580", Offset = "0xCB3780", VA = "0x180CB4580", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6008330")]
	[Address(RVA = "0xCB6930", Offset = "0xCB5B30", VA = "0x180CB6930")]
	public CardPackOpenResultViewController()
	{
	}
}
