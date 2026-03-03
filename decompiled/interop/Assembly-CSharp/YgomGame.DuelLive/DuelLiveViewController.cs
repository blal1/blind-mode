using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F23")]
public class DuelLiveViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000F26")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x400A662")]
		[FieldOffset(Offset = "0x10")]
		public bool doneWebApi;

		[Token(Token = "0x400A663")]
		[FieldOffset(Offset = "0x11")]
		public bool webApiError;

		[Token(Token = "0x400A664")]
		[FieldOffset(Offset = "0x18")]
		public DuelLiveViewController _003C_003E4__this;

		[Token(Token = "0x400A665")]
		[FieldOffset(Offset = "0x20")]
		public bool doneInitProduct;

		[Token(Token = "0x400A666")]
		[FieldOffset(Offset = "0x21")]
		public bool doneApplyList;

		[Token(Token = "0x6005BD2")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6005BD3")]
		[Address(RVA = "0xA15F00", Offset = "0xA15100", VA = "0x180A15F00")]
		internal void _003CyInitialize_003Eb__3(Handle h)
		{
		}

		[Token(Token = "0x6005BD4")]
		[Address(RVA = "0xA15D00", Offset = "0xA14F00", VA = "0x180A15D00")]
		internal void _003CyInitialize_003Eb__0()
		{
		}

		[Token(Token = "0x6005BD5")]
		[Address(RVA = "0x69EDD0", Offset = "0x69DFD0", VA = "0x18069EDD0")]
		internal void _003CyInitialize_003Eb__1()
		{
		}

		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x69EDE0", Offset = "0x69DFE0", VA = "0x18069EDE0")]
		internal void _003CyInitialize_003Eb__2()
		{
		}

		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0xA15D20", Offset = "0xA14F20", VA = "0x180A15D20")]
		internal void _003CyInitialize_003Eb__13(int preIdx, int preSecIdx, int idx, int secIdx)
		{
		}

		[Token(Token = "0x6005BD8")]
		[Address(RVA = "0xA15E50", Offset = "0xA15050", VA = "0x180A15E50")]
		internal void _003CyInitialize_003Eb__14(int idx, int secIdx)
		{
		}

		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0xA15E80", Offset = "0xA15080", VA = "0x180A15E80")]
		internal bool _003CyInitialize_003Eb__16()
		{
			return default(bool);
		}

		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0xA15F50", Offset = "0xA15150", VA = "0x180A15F50")]
		internal void _003CyInitialize_003Eb__5(Vector2 value)
		{
		}

		[Token(Token = "0x6005BDB")]
		[Address(RVA = "0xA15F70", Offset = "0xA15170", VA = "0x180A15F70")]
		internal void _003CyInitialize_003Eb__6(ProductWidget productWidget)
		{
		}

		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0xA160B0", Offset = "0xA152B0", VA = "0x180A160B0")]
		internal void _003CyInitialize_003Eb__7(ProductWidget productWidget)
		{
		}

		[Token(Token = "0x6005BDD")]
		[Address(RVA = "0xA160E0", Offset = "0xA152E0", VA = "0x180A160E0")]
		internal void _003CyInitialize_003Eb__8(int menu_id)
		{
		}
	}

	[Token(Token = "0x2000F2A")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A66F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A670")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A671")]
		[FieldOffset(Offset = "0x20")]
		public DuelLiveViewController _003C_003E4__this;

		[Token(Token = "0x400A672")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		[Token(Token = "0x17000E5A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005BE9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E5B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005BEB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0xA17190", Offset = "0xA16390", VA = "0x180A17190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0xA186B0", Offset = "0xA178B0", VA = "0x180A186B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A640")]
	private const string k_PrefPath = "DuelLive/DuelLive";

	[Token(Token = "0x400A641")]
	private const string k_ELabelHelpButton = "ButtonHelp";

	[Token(Token = "0x400A642")]
	private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

	[Token(Token = "0x400A643")]
	private const string k_ELabelShortcutButtonBack = "ShortcutButtonBack";

	[Token(Token = "0x400A644")]
	private const string k_ELabelShortcutButtonCancel = "ShortcutButtonCancel";

	[Token(Token = "0x400A645")]
	private const string k_ELabelWCSFilterSettingButton = "ButtonFilter";

	[Token(Token = "0x400A646")]
	private const string k_ELabelWCSFilterResetButton = "ButtonTrash";

	[Token(Token = "0x400A647")]
	private const string PLAYER_NAME_A = "DUELIST A ";

	[Token(Token = "0x400A648")]
	private const string PLAYER_NAME_B = "DUELIST B ";

	[Token(Token = "0x400A649")]
	public const string k_ArgsLaunchMainID = "mainId";

	[Token(Token = "0x400A64A")]
	public const string k_ArgsLaunchMenuID = "menuId";

	[Token(Token = "0x400A64B")]
	public const string k_ArgsLaunchSectionID = "sectionId";

	[Token(Token = "0x400A64C")]
	public const string k_ArgsLaunchOptionID = "optionId";

	[Token(Token = "0x400A64D")]
	public const string k_ArgsLaunchSkipApi = "alreadyDoneApi";

	[Token(Token = "0x400A64E")]
	[FieldOffset(Offset = "0xD0")]
	private DuelLiveSettings m_DuelLiveSettings;

	[Token(Token = "0x400A64F")]
	[FieldOffset(Offset = "0xD8")]
	private DuelLiveRootWidget m_RootWidget;

	[Token(Token = "0x400A650")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_IsStarted;

	[Token(Token = "0x400A651")]
	[FieldOffset(Offset = "0xE1")]
	private bool m_IsHighEnd;

	[Token(Token = "0x400A652")]
	[FieldOffset(Offset = "0xE2")]
	private bool alreadyDoneApi;

	[Token(Token = "0x400A653")]
	[FieldOffset(Offset = "0xE8")]
	private Coroutine initCoroutine;

	[Token(Token = "0x400A654")]
	[FieldOffset(Offset = "0xF0")]
	private int loadingCount;

	[Token(Token = "0x400A655")]
	[FieldOffset(Offset = "0xF8")]
	private List<object> loadIdsList;

	[Token(Token = "0x400A656")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[TextArea]
	private string dj;

	[Token(Token = "0x400A657")]
	[FieldOffset(Offset = "0x108")]
	private bool m_OnChangedSubTabIdxFocusBlocker;

	[Token(Token = "0x400A658")]
	[FieldOffset(Offset = "0x110")]
	private Dictionary<(int, int), bool> badgeMap;

	[Token(Token = "0x400A659")]
	[FieldOffset(Offset = "0x118")]
	private bool m_ProductListScrollCheckBlocker;

	[Token(Token = "0x17000E57")]
	protected override bool setProgressOnInitialize
	{
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E58")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E59")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0xA0FB30", Offset = "0xA0ED30", VA = "0x180A0FB30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005BA8")]
	[Address(RVA = "0xA0D120", Offset = "0xA0C320", VA = "0x180A0D120")]
	private void LoadTextFile()
	{
	}

	[Token(Token = "0x6005BA9")]
	[Address(RVA = "0xA0F760", Offset = "0xA0E960", VA = "0x180A0F760")]
	private void UnloadTextFile()
	{
	}

	[Token(Token = "0x6005BAA")]
	[Address(RVA = "0xA0F430", Offset = "0xA0E630", VA = "0x180A0F430")]
	public static void Open(bool onHome = false, int mainId = 0, int menuId = 0, int sectionId = 0, int optionId = 0, bool skipApi = false)
	{
	}

	[Token(Token = "0x6005BAB")]
	[Address(RVA = "0xA0F200", Offset = "0xA0E400", VA = "0x180A0F200")]
	public static void OpenWithShopId(bool onHome, int shopId)
	{
	}

	[Token(Token = "0x6005BAC")]
	[Address(RVA = "0xA0CB30", Offset = "0xA0BD30", VA = "0x180A0CB30")]
	public static bool ExistsVc()
	{
		return default(bool);
	}

	[Token(Token = "0x6005BAD")]
	[Address(RVA = "0xA0D2E0", Offset = "0xA0C4E0", VA = "0x180A0D2E0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005BAE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "26")]
	protected override void OnTransitionSetBg(TransitionType type)
	{
	}

	[Token(Token = "0x6005BAF")]
	[Address(RVA = "0xA0D950", Offset = "0xA0CB50", VA = "0x180A0D950", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6005BB0")]
	[Address(RVA = "0xA0FD30", Offset = "0xA0EF30", VA = "0x180A0FD30")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__37))]
	private IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005BB1")]
	[Address(RVA = "0xA0E5D0", Offset = "0xA0D7D0", VA = "0x180A0E5D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005BB2")]
	[Address(RVA = "0xA0D070", Offset = "0xA0C270", VA = "0x180A0D070")]
	private void InitializeRootContext()
	{
	}

	[Token(Token = "0x6005BB3")]
	[Address(RVA = "0xA0CBD0", Offset = "0xA0BDD0", VA = "0x180A0CBD0")]
	private void InitializeData()
	{
	}

	[Token(Token = "0x6005BB4")]
	[Address(RVA = "0xA0F8C0", Offset = "0xA0EAC0", VA = "0x180A0F8C0")]
	private void UpdateBg()
	{
	}

	[Token(Token = "0x6005BB5")]
	[Address(RVA = "0xA0EDC0", Offset = "0xA0DFC0", VA = "0x180A0EDC0", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6005BB6")]
	[Address(RVA = "0xA0EC60", Offset = "0xA0DE60", VA = "0x180A0EC60", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6005BB7")]
	[Address(RVA = "0xA0E8D0", Offset = "0xA0DAD0", VA = "0x180A0E8D0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x6005BB8")]
	[Address(RVA = "0xA0D3D0", Offset = "0xA0C5D0", VA = "0x180A0D3D0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6005BB9")]
	[Address(RVA = "0xA0E960", Offset = "0xA0DB60", VA = "0x180A0E960")]
	private void OnHelpButton()
	{
	}

	[Token(Token = "0x6005BBA")]
	[Address(RVA = "0xA0EF00", Offset = "0xA0E100", VA = "0x180A0EF00")]
	private void OnWCSFilterSettingButton()
	{
	}

	[Token(Token = "0x6005BBB")]
	[Address(RVA = "0xA0EE30", Offset = "0xA0E030", VA = "0x180A0EE30")]
	private void OnWCSFilterResetButton()
	{
	}

	[Token(Token = "0x6005BBC")]
	[Address(RVA = "0xA0FA40", Offset = "0xA0EC40", VA = "0x180A0FA40")]
	private void applyWCSFilter()
	{
	}

	[Token(Token = "0x6005BBD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x6005BBE")]
	[Address(RVA = "0xA0DB50", Offset = "0xA0CD50", VA = "0x180A0DB50")]
	private void OnChangedTab(int preIndex, int preSubIndex, int index, int subIndex)
	{
	}

	[Token(Token = "0x6005BBF")]
	[Address(RVA = "0xA0DFA0", Offset = "0xA0D1A0", VA = "0x180A0DFA0")]
	private void OnClickCustomAction(int index, int subIndex, bool initializeSelection = false)
	{
	}

	[Token(Token = "0x6005BC0")]
	[Address(RVA = "0xA0F650", Offset = "0xA0E850", VA = "0x180A0F650")]
	private bool TrySelectProductList(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BC1")]
	[Address(RVA = "0xA0E9B0", Offset = "0xA0DBB0", VA = "0x180A0E9B0")]
	private void OnProductListScrolled(Vector2 value)
	{
	}

	[Token(Token = "0x6005BC2")]
	[Address(RVA = "0xA0E4A0", Offset = "0xA0D6A0", VA = "0x180A0E4A0")]
	private void OnClickProduct(ProductWidget productWidget)
	{
	}

	[Token(Token = "0x6005BC3")]
	[Address(RVA = "0xA0F0F0", Offset = "0xA0E2F0", VA = "0x180A0F0F0")]
	private void OpenSelectDialog(ProductWidget productWidget)
	{
	}

	[Token(Token = "0x6005BC4")]
	[Address(RVA = "0xA0E0D0", Offset = "0xA0D2D0", VA = "0x180A0E0D0")]
	private void OnClickPlayButton(ProductWidget productWidget, bool isReverse = false)
	{
	}

	[Token(Token = "0x6005BC5")]
	[Address(RVA = "0xA0DC50", Offset = "0xA0CE50", VA = "0x180A0DC50")]
	private void OnClickCategoryPlayButton(int menuID, bool isReverse = false)
	{
	}

	[Token(Token = "0x6005BC6")]
	[Address(RVA = "0xA0F950", Offset = "0xA0EB50", VA = "0x180A0F950")]
	public DuelLiveViewController()
	{
	}
}
