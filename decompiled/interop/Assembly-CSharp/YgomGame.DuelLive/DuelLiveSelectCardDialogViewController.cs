using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F1B")]
public class DuelLiveSelectCardDialogViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, IBokeSupported
{
	[Token(Token = "0x2000F1C")]
	private class CardListArea
	{
		[Token(Token = "0x400A622")]
		private const string LABEL_IMGCARD = "ImageCard";

		[Token(Token = "0x400A623")]
		private const string LABEL_IMGPACK = "PackImage";

		[Token(Token = "0x400A624")]
		private const string LABEL_BTN = "ThumbButton";

		[Token(Token = "0x400A625")]
		private const string LABEL_SELECT_TOGGLE = "SelectedStateToggle";

		[Token(Token = "0x400A627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly DuelLiveSelectCardDialogViewController _vc;

		[Token(Token = "0x400A628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly InfinityScrollView _infinityScroll;

		[Token(Token = "0x400A629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Selector _selector;

		[Token(Token = "0x400A62A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly GridLayoutGroup _gridlayout;

		[Token(Token = "0x400A62B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _selectedCardObj;

		[Token(Token = "0x400A62C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int packIconId;

		[Token(Token = "0x17000E55")]
		internal List<int> cardData
		{
			[Token(Token = "0x6005B89")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B88")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0xA016C0", Offset = "0xA008C0", VA = "0x180A016C0")]
		internal CardListArea(DuelLiveSelectCardDialogViewController vc, InfinityScrollView v)
		{
		}

		[Token(Token = "0x6005B8B")]
		[Address(RVA = "0xA00F00", Offset = "0xA00100", VA = "0x180A00F00")]
		internal void Initialize(List<int> data, int packIconId)
		{
		}

		[Token(Token = "0x6005B8C")]
		[Address(RVA = "0xA00E80", Offset = "0xA00080", VA = "0x180A00E80")]
		internal void Disp(bool on)
		{
		}

		[Token(Token = "0x6005B8D")]
		[Address(RVA = "0xA01630", Offset = "0xA00830", VA = "0x180A01630")]
		internal void Refresh()
		{
		}

		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0xA01120", Offset = "0xA00320", VA = "0x180A01120")]
		private void OnEntityUpdate(GameObject obj, int index)
		{
		}

		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0xA010A0", Offset = "0xA002A0", VA = "0x180A010A0")]
		private void OnEntityDeactivate(GameObject obj)
		{
		}
	}

	[Token(Token = "0x400A60B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string ARG_ONRESULT;

	[Token(Token = "0x400A60C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string ARG_PACKID;

	[Token(Token = "0x400A60D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string ARG_PACKNAMEID;

	[Token(Token = "0x400A60E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string ARG_MRKLIST;

	[Token(Token = "0x400A60F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string ARG_SELECT_INDEX;

	[Token(Token = "0x400A610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Action<int> _onResult;

	[Token(Token = "0x400A611")]
	private const string LABEL_BTNCANCEL = "ButtonCancel";

	[Token(Token = "0x400A612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private CardListArea _cardArea;

	[Token(Token = "0x400A613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private ElementObjectManager _contentView;

	[Token(Token = "0x400A614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ElementObjectManager _cardCollectionView;

	[Token(Token = "0x400A615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ElementObjectManager _cardScrollTop;

	[Token(Token = "0x400A616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public ExtendedTextMeshProUGUI _teamName;

	[Token(Token = "0x400A617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private BindingTextMeshProUGUI _title;

	[Token(Token = "0x400A618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private SelectionButton _cancelBtn;

	[Token(Token = "0x400A619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private SelectionButton _decideBtn;

	[Token(Token = "0x400A61A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject _noCardMessageText;

	[Token(Token = "0x400A61B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject _loadingIcon;

	[Token(Token = "0x400A61C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int _selectedCardIdx;

	[Token(Token = "0x400A61E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
	private bool _backSent;

	[Token(Token = "0x400A61F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private int packId;

	[Token(Token = "0x400A620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public string packNameId;

	[Token(Token = "0x400A621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<int> highlightMrks;

	[Token(Token = "0x17000E54")]
	public bool initialized
	{
		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0xA0B9D0", Offset = "0xA0ABD0", VA = "0x180A0B9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0xA0B9E0", Offset = "0xA0ABE0", VA = "0x180A0B9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6005B7E")]
	[Address(RVA = "0xA0B3E0", Offset = "0xA0A5E0", VA = "0x180A0B3E0")]
	public static void Open(int packId, string packName, List<int> mrks, int selectedId = -1, [Optional] Action<int> onCompleted)
	{
	}

	[Token(Token = "0x6005B7F")]
	[Address(RVA = "0xA0A5B0", Offset = "0xA097B0", VA = "0x180A0A5B0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005B80")]
	[Address(RVA = "0xA0AB60", Offset = "0xA09D60", VA = "0x180A0AB60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005B81")]
	[Address(RVA = "0xA0B5B0", Offset = "0xA0A7B0", VA = "0x180A0B5B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6005B82")]
	[Address(RVA = "0xA0A9A0", Offset = "0xA09BA0", VA = "0x180A0A9A0")]
	private bool OnCardSelected(int cardId, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B83")]
	[Address(RVA = "0xA0B240", Offset = "0xA0A440", VA = "0x180A0B240")]
	private bool OnPackIconSelected(int packIconId, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B84")]
	[Address(RVA = "0xA0A560", Offset = "0xA09760", VA = "0x180A0A560")]
	private void Close()
	{
	}

	[Token(Token = "0x6005B85")]
	[Address(RVA = "0xA0B940", Offset = "0xA0AB40", VA = "0x180A0B940")]
	public DuelLiveSelectCardDialogViewController()
	{
	}
}
