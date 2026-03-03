using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DDA")]
public class FriendListWidget : ElementWidgetBehaviourBase<FriendListWidget>
{
	[Token(Token = "0x400A0D2")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelEmptyText;

	[Token(Token = "0x400A0D3")]
	[FieldOffset(Offset = "0x30")]
	private readonly int k_TemplateIdxPlayer;

	[Token(Token = "0x400A0D4")]
	[FieldOffset(Offset = "0x34")]
	private readonly int k_TemplateIdxPinLine;

	[Token(Token = "0x400A0D5")]
	[FieldOffset(Offset = "0x38")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x400A0D6")]
	[FieldOffset(Offset = "0x40")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x400A0D7")]
	[FieldOffset(Offset = "0x48")]
	private Selector m_Selector;

	[Token(Token = "0x400A0D8")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<GameObject, FriendWidget> m_EntityWidgetMap;

	[Token(Token = "0x400A0D9")]
	[FieldOffset(Offset = "0x58")]
	public string nameFilter;

	[Token(Token = "0x400A0DA")]
	[FieldOffset(Offset = "0x60")]
	public bool followStateVisible;

	[Token(Token = "0x400A0DB")]
	[FieldOffset(Offset = "0x61")]
	public bool isUsePinLine;

	[Token(Token = "0x400A0DC")]
	[FieldOffset(Offset = "0x68")]
	public string emptyMessage;

	[Token(Token = "0x400A0DD")]
	[FieldOffset(Offset = "0x70")]
	private IReadOnlyList<IPlayerContext> m_FriendContexts;

	[Token(Token = "0x400A0DE")]
	[FieldOffset(Offset = "0x78")]
	private List<IPlayerContext> m_DisplayFriendContexts;

	[Token(Token = "0x400A0DF")]
	[FieldOffset(Offset = "0x80")]
	private List<int> m_TemplateIdxs;

	[Token(Token = "0x400A0E6")]
	[FieldOffset(Offset = "0xB8")]
	private List<IPlayerContext> m_SearchPlayerList;

	[Token(Token = "0x400A0E7")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_IsContainPin;

	[Token(Token = "0x400A0E8")]
	[FieldOffset(Offset = "0xC1")]
	public bool dumpPos;

	[Token(Token = "0x17000C31")]
	public Selector selector
	{
		[Token(Token = "0x600534E")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C32")]
	public IReadOnlyList<IPlayerContext> friendContexts
	{
		[Token(Token = "0x600534F")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C33")]
	public IReadOnlyList<IPlayerContext> displayFriendContexts
	{
		[Token(Token = "0x6005350")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C34")]
	public InfinityScrollView scrollView
	{
		[Token(Token = "0x6005351")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C35")]
	public ScrollRect scrollRect
	{
		[Token(Token = "0x6005352")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C36")]
	public int defaultIdx
	{
		[Token(Token = "0x600535F")]
		[Address(RVA = "0x9A7410", Offset = "0x9A6610", VA = "0x1809A7410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005360")]
		[Address(RVA = "0x9A78A0", Offset = "0x9A6AA0", VA = "0x1809A78A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C37")]
	public bool scrollEnabled
	{
		[Token(Token = "0x6005361")]
		[Address(RVA = "0x9A7430", Offset = "0x9A6630", VA = "0x1809A7430")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005362")]
		[Address(RVA = "0x9A78C0", Offset = "0x9A6AC0", VA = "0x1809A78C0")]
		set
		{
		}
	}

	[Token(Token = "0x14000078")]
	public event Action<IPlayerContext> onClickEntityEvent
	{
		[Token(Token = "0x6005353")]
		[Address(RVA = "0x9A6FC0", Offset = "0x9A61C0", VA = "0x1809A6FC0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005354")]
		[Address(RVA = "0x9A7450", Offset = "0x9A6650", VA = "0x1809A7450")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000079")]
	public event Action<int, IPlayerContext> onSelectedEntityEvent
	{
		[Token(Token = "0x6005355")]
		[Address(RVA = "0x9A72A0", Offset = "0x9A64A0", VA = "0x1809A72A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005356")]
		[Address(RVA = "0x9A7730", Offset = "0x9A6930", VA = "0x1809A7730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400007A")]
	public event Action<bool> onOpenCloseEvent
	{
		[Token(Token = "0x6005357")]
		[Address(RVA = "0x9A7080", Offset = "0x9A6280", VA = "0x1809A7080")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005358")]
		[Address(RVA = "0x9A7510", Offset = "0x9A6710", VA = "0x1809A7510")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400007B")]
	public event Action onUpdateDataCountEvent
	{
		[Token(Token = "0x6005359")]
		[Address(RVA = "0x9A7360", Offset = "0x9A6560", VA = "0x1809A7360")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600535A")]
		[Address(RVA = "0x9A77F0", Offset = "0x9A69F0", VA = "0x1809A77F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400007C")]
	public event Action onReachScrollHeadEvent
	{
		[Token(Token = "0x600535B")]
		[Address(RVA = "0x9A7140", Offset = "0x9A6340", VA = "0x1809A7140")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600535C")]
		[Address(RVA = "0x9A75D0", Offset = "0x9A67D0", VA = "0x1809A75D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400007D")]
	public event Action onReachScrollTailEvent
	{
		[Token(Token = "0x600535D")]
		[Address(RVA = "0x9A71F0", Offset = "0x9A63F0", VA = "0x1809A71F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600535E")]
		[Address(RVA = "0x9A7680", Offset = "0x9A6880", VA = "0x1809A7680")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005363")]
	[Address(RVA = "0x9A4B00", Offset = "0x9A3D00", VA = "0x1809A4B00")]
	public static FriendListWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005364")]
	[Address(RVA = "0x9A4870", Offset = "0x9A3A70", VA = "0x1809A4870", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005365")]
	[Address(RVA = "0x9A52A0", Offset = "0x9A44A0", VA = "0x1809A52A0")]
	public void Initialize(IReadOnlyList<IPlayerContext> friendContexts, Action callback)
	{
	}

	[Token(Token = "0x6005366")]
	[Address(RVA = "0x9A60A0", Offset = "0x9A52A0", VA = "0x1809A60A0")]
	public IReadOnlyList<IPlayerContext> SearchInnerViewportPlayers()
	{
		return null;
	}

	[Token(Token = "0x6005367")]
	[Address(RVA = "0x9A6590", Offset = "0x9A5790", VA = "0x1809A6590")]
	public void UpdateDataCount()
	{
	}

	[Token(Token = "0x6005368")]
	[Address(RVA = "0x9A6E20", Offset = "0x9A6020", VA = "0x1809A6E20")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6005369")]
	[Address(RVA = "0x9A5150", Offset = "0x9A4350", VA = "0x1809A5150")]
	public long GetSelectedPcode()
	{
		return default(long);
	}

	[Token(Token = "0x600536A")]
	[Address(RVA = "0x9A6330", Offset = "0x9A5530", VA = "0x1809A6330")]
	public bool TrySelectInViewportPcode(long pcode, bool focus = false, bool isIniitialSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600536B")]
	[Address(RVA = "0x9A5040", Offset = "0x9A4240", VA = "0x1809A5040")]
	public bool FocusPlayer(long pcode, bool isIniitialSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600536C")]
	[Address(RVA = "0x9A5280", Offset = "0x9A4480", VA = "0x1809A5280")]
	public void ImmediateApplyMovement()
	{
	}

	[Token(Token = "0x600536D")]
	[Address(RVA = "0x9A4B40", Offset = "0x9A3D40", VA = "0x1809A4B40")]
	public void FixEntitiesSelectedTween()
	{
	}

	[Token(Token = "0x600536E")]
	[Address(RVA = "0x9A5FD0", Offset = "0x9A51D0", VA = "0x1809A5FD0")]
	public void OpenOrClose(bool isOn)
	{
	}

	[Token(Token = "0x600536F")]
	[Address(RVA = "0x9A6050", Offset = "0x9A5250", VA = "0x1809A6050")]
	public void Open()
	{
	}

	[Token(Token = "0x6005370")]
	[Address(RVA = "0x9A4820", Offset = "0x9A3A20", VA = "0x1809A4820")]
	public void Close()
	{
	}

	[Token(Token = "0x6005371")]
	[Address(RVA = "0x9A52F0", Offset = "0x9A44F0", VA = "0x1809A52F0")]
	protected bool IsSelectableDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6005372")]
	[Address(RVA = "0x9A5410", Offset = "0x9A4610", VA = "0x1809A5410")]
	protected void OnCreatedEntity(GameObject gob)
	{
	}

	[Token(Token = "0x6005373")]
	[Address(RVA = "0x9A5990", Offset = "0x9A4B90", VA = "0x1809A5990")]
	protected void OnUpdateEntity(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6005374")]
	[Address(RVA = "0x9A56E0", Offset = "0x9A48E0", VA = "0x1809A56E0")]
	private void OnScrollValueChanged(Vector2 normalizedPos)
	{
	}

	[Token(Token = "0x6005375")]
	[Address(RVA = "0x9A5350", Offset = "0x9A4550", VA = "0x1809A5350")]
	private void OnClickedEntityWidget(FriendWidget clickedWidget)
	{
	}

	[Token(Token = "0x6005376")]
	[Address(RVA = "0x9A5810", Offset = "0x9A4A10", VA = "0x1809A5810")]
	private void OnSelectedEntityWidget(FriendWidget selectedWidget)
	{
	}

	[Token(Token = "0x6005377")]
	[Address(RVA = "0x9A6E40", Offset = "0x9A6040", VA = "0x1809A6E40")]
	public FriendListWidget()
	{
	}
}
