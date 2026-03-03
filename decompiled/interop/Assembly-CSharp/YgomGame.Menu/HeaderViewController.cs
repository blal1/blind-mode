using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x20012BD")]
public class HeaderViewController : ViewController
{
	[Token(Token = "0x20012BE")]
	[Flags]
	public enum IsDispHeader
	{
		[Token(Token = "0x400BD22")]
		BACK = 1,
		[Token(Token = "0x400BD23")]
		GEM_QUANTITY = 2,
		[Token(Token = "0x400BD24")]
		FRIEND = 4,
		[Token(Token = "0x400BD25")]
		CONFIG = 8,
		[Token(Token = "0x400BD26")]
		PRESENT = 0x10,
		[Token(Token = "0x400BD27")]
		NOTICE = 0x20,
		[Token(Token = "0x400BD28")]
		GEM_QUANTITY_TEXT = 0x40,
		[Token(Token = "0x400BD29")]
		BORDER = 0x80,
		[Token(Token = "0x400BD2A")]
		DUELLIVE = 0x100,
		[Token(Token = "0x400BD2B")]
		DUELPASS = 0x200
	}

	[Token(Token = "0x20012BF")]
	public enum Part
	{
		[Token(Token = "0x400BD2D")]
		ALL,
		[Token(Token = "0x400BD2E")]
		TOP
	}

	[Token(Token = "0x20012C0")]
	private class FrontGroup
	{
		[Token(Token = "0x400BD2F")]
		[FieldOffset(Offset = "0x10")]
		private readonly Part part;

		[Token(Token = "0x400BD30")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<IsDispHeader, GameObject> fronts;

		[Token(Token = "0x6007483")]
		[Address(RVA = "0xB9F240", Offset = "0xB9E440", VA = "0x180B9F240")]
		public FrontGroup(Part part)
		{
		}

		[Token(Token = "0x6007484")]
		[Address(RVA = "0xB9F1B0", Offset = "0xB9E3B0", VA = "0x180B9F1B0")]
		public void SetFront(IsDispHeader isDispHeader, GameObject gameObject)
		{
		}

		[Token(Token = "0x6007485")]
		[Address(RVA = "0xB9EF90", Offset = "0xB9E190", VA = "0x180B9EF90")]
		public GameObject GetFront(IsDispHeader isDispHeader)
		{
			return null;
		}

		[Token(Token = "0x6007486")]
		[Address(RVA = "0xB9F020", Offset = "0xB9E220", VA = "0x180B9F020")]
		public void InitTween()
		{
		}
	}

	[Token(Token = "0x400BCFB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400BCFC")]
	[FieldOffset(Offset = "0x50")]
	private ElementObjectManager ui;

	[Token(Token = "0x400BCFD")]
	[FieldOffset(Offset = "0x58")]
	private readonly string ROOT_LABEL;

	[Token(Token = "0x400BCFE")]
	[FieldOffset(Offset = "0x60")]
	private readonly string ROOT_TOP_LABEL;

	[Token(Token = "0x400BCFF")]
	[FieldOffset(Offset = "0x68")]
	private readonly string BTN_BACK_LABEL;

	[Token(Token = "0x400BD00")]
	[FieldOffset(Offset = "0x70")]
	private readonly string BTN_CONFIG_LABEL;

	[Token(Token = "0x400BD01")]
	[FieldOffset(Offset = "0x78")]
	private readonly string BTN_FRIEND_LABEL;

	[Token(Token = "0x400BD02")]
	[FieldOffset(Offset = "0x80")]
	private readonly string BTN_NOTICE_LABEL;

	[Token(Token = "0x400BD03")]
	[FieldOffset(Offset = "0x88")]
	private readonly string BTN_PRESENT_LABEL;

	[Token(Token = "0x400BD04")]
	[FieldOffset(Offset = "0x90")]
	private readonly string BTN_GEM_LABEL;

	[Token(Token = "0x400BD05")]
	[FieldOffset(Offset = "0x98")]
	private readonly string BTN_DUELLIVE;

	[Token(Token = "0x400BD06")]
	[FieldOffset(Offset = "0xA0")]
	private readonly string BTN_DUELPASS;

	[Token(Token = "0x400BD07")]
	[FieldOffset(Offset = "0xA8")]
	private readonly string TXT_GEM_LABEL;

	[Token(Token = "0x400BD08")]
	[FieldOffset(Offset = "0xB0")]
	private readonly string TXT_LABEL;

	[Token(Token = "0x400BD09")]
	[FieldOffset(Offset = "0xB8")]
	private readonly string IMG_BORDER_LABEL;

	[Token(Token = "0x400BD0A")]
	[FieldOffset(Offset = "0xC0")]
	private readonly string ROOT_TWEEN_LABEL;

	[Token(Token = "0x400BD0B")]
	[FieldOffset(Offset = "0xC8")]
	private readonly string STATE_NOTICE_PATH;

	[Token(Token = "0x400BD0C")]
	[FieldOffset(Offset = "0xD0")]
	private ElementObjectManager topEOM;

	[Token(Token = "0x400BD0D")]
	[FieldOffset(Offset = "0xD8")]
	private Selector topSelector;

	[Token(Token = "0x400BD0E")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject root;

	[Token(Token = "0x400BD0F")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject topRoot;

	[Token(Token = "0x400BD10")]
	[FieldOffset(Offset = "0xF0")]
	private FrontGroup topFronts;

	[Token(Token = "0x400BD11")]
	[FieldOffset(Offset = "0xF8")]
	private bool isDispTop;

	[Token(Token = "0x400BD12")]
	[FieldOffset(Offset = "0x100")]
	private ExtendedTextMeshProUGUI gemButtonText;

	[Token(Token = "0x400BD13")]
	[FieldOffset(Offset = "0x108")]
	private ExtendedTextMeshProUGUI gemText;

	[Token(Token = "0x400BD14")]
	[FieldOffset(Offset = "0x110")]
	private ViewControllerManager content;

	[Token(Token = "0x400BD15")]
	[FieldOffset(Offset = "0x118")]
	private ViewController crntViewController;

	[Token(Token = "0x400BD16")]
	[FieldOffset(Offset = "0x120")]
	private bool isDirty;

	[Token(Token = "0x400BD17")]
	[FieldOffset(Offset = "0x121")]
	private bool shouldResetShortCutBack;

	[Token(Token = "0x400BD18")]
	[FieldOffset(Offset = "0x124")]
	private IsDispHeader isDisp;

	[Token(Token = "0x400BD19")]
	[FieldOffset(Offset = "0x128")]
	private SelectionButton btnBack;

	[Token(Token = "0x400BD1A")]
	[FieldOffset(Offset = "0x130")]
	private SelectionButton btnConfig;

	[Token(Token = "0x400BD1B")]
	[FieldOffset(Offset = "0x138")]
	private SelectionButton btnGem;

	[Token(Token = "0x400BD1C")]
	[FieldOffset(Offset = "0x140")]
	private SelectionButton btnFriend;

	[Token(Token = "0x400BD1D")]
	[FieldOffset(Offset = "0x148")]
	private SelectionButton btnPresent;

	[Token(Token = "0x400BD1E")]
	[FieldOffset(Offset = "0x150")]
	private SelectionButton btnNotice;

	[Token(Token = "0x400BD1F")]
	[FieldOffset(Offset = "0x158")]
	private SelectionButton btnDuellive;

	[Token(Token = "0x400BD20")]
	[FieldOffset(Offset = "0x160")]
	private SelectionButton btnDuelPass;

	[Token(Token = "0x17001251")]
	public static HeaderViewController instance
	{
		[Token(Token = "0x600744A")]
		[Address(RVA = "0xBA5190", Offset = "0xBA4390", VA = "0x180BA5190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600744B")]
		[Address(RVA = "0xBA51D0", Offset = "0xBA43D0", VA = "0x180BA51D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001252")]
	public SelectionButton BtnBack
	{
		[Token(Token = "0x600744C")]
		[Address(RVA = "0xBA4C00", Offset = "0xBA3E00", VA = "0x180BA4C00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001253")]
	public SelectionButton BtnConfig
	{
		[Token(Token = "0x600744D")]
		[Address(RVA = "0xBA4CB0", Offset = "0xBA3EB0", VA = "0x180BA4CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001254")]
	public SelectionButton BtnGem
	{
		[Token(Token = "0x600744E")]
		[Address(RVA = "0xBA4F70", Offset = "0xBA4170", VA = "0x180BA4F70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001255")]
	public SelectionButton BtnFriend
	{
		[Token(Token = "0x600744F")]
		[Address(RVA = "0xBA4EC0", Offset = "0xBA40C0", VA = "0x180BA4EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001256")]
	public SelectionButton BtnPresent
	{
		[Token(Token = "0x6007450")]
		[Address(RVA = "0xBA50D0", Offset = "0xBA42D0", VA = "0x180BA50D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001257")]
	public SelectionButton BtnNotice
	{
		[Token(Token = "0x6007451")]
		[Address(RVA = "0xBA5020", Offset = "0xBA4220", VA = "0x180BA5020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001258")]
	public SelectionButton BtnDuellive
	{
		[Token(Token = "0x6007452")]
		[Address(RVA = "0xBA4E10", Offset = "0xBA4010", VA = "0x180BA4E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001259")]
	public SelectionButton BtnDuelPass
	{
		[Token(Token = "0x6007453")]
		[Address(RVA = "0xBA4D60", Offset = "0xBA3F60", VA = "0x180BA4D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700125A")]
	public static IsDispHeader defaultDisp
	{
		[Token(Token = "0x6007454")]
		[Address(RVA = "0xBA5180", Offset = "0xBA4380", VA = "0x180BA5180")]
		get
		{
			return default(IsDispHeader);
		}
	}

	[Token(Token = "0x6007455")]
	[Address(RVA = "0xBA0B30", Offset = "0xB9FD30", VA = "0x180BA0B30")]
	public static void InitHeader()
	{
	}

	[Token(Token = "0x6007456")]
	[Address(RVA = "0xB9FEF0", Offset = "0xB9F0F0", VA = "0x180B9FEF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007457")]
	[Address(RVA = "0xBA1D80", Offset = "0xBA0F80", VA = "0x180BA1D80")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007458")]
	[Address(RVA = "0xBA17A0", Offset = "0xBA09A0", VA = "0x180BA17A0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6007459")]
	[Address(RVA = "0xBA1420", Offset = "0xBA0620", VA = "0x180BA1420", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600745A")]
	[Address(RVA = "0xBA1540", Offset = "0xBA0740", VA = "0x180BA1540", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600745B")]
	[Address(RVA = "0xBA2610", Offset = "0xBA1810", VA = "0x180BA2610")]
	private void Start()
	{
	}

	[Token(Token = "0x600745C")]
	[Address(RVA = "0xBA2050", Offset = "0xBA1250", VA = "0x180BA2050")]
	private void SetAnimBtnHideCallback(string label)
	{
	}

	[Token(Token = "0x600745D")]
	[Address(RVA = "0xBA44D0", Offset = "0xBA36D0", VA = "0x180BA44D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600745E")]
	[Address(RVA = "0xBA1A10", Offset = "0xBA0C10", VA = "0x180BA1A10")]
	public void OnBackButton()
	{
	}

	[Token(Token = "0x600745F")]
	[Address(RVA = "0xBA1D40", Offset = "0xBA0F40", VA = "0x180BA1D40")]
	private void OnCommonButton(IsDispHeader isDispHeader, Action onClick)
	{
	}

	[Token(Token = "0x6007460")]
	[Address(RVA = "0xBA1010", Offset = "0xBA0210", VA = "0x180BA1010")]
	private bool IsReadyClickAction(IsDispHeader isDispHeader)
	{
		return default(bool);
	}

	[Token(Token = "0x6007461")]
	[Address(RVA = "0xBA2170", Offset = "0xBA1370", VA = "0x180BA2170")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6007462")]
	[Address(RVA = "0xBA0B10", Offset = "0xB9FD10", VA = "0x180BA0B10")]
	public void HideButton()
	{
	}

	[Token(Token = "0x6007463")]
	[Address(RVA = "0xBA2600", Offset = "0xBA1800", VA = "0x180BA2600")]
	public void ShowButtonTemp()
	{
	}

	[Token(Token = "0x6007464")]
	[Address(RVA = "0xBA0B00", Offset = "0xB9FD00", VA = "0x180BA0B00")]
	public void HideButtonTemp()
	{
	}

	[Token(Token = "0x6007465")]
	[Address(RVA = "0xBA2400", Offset = "0xBA1600", VA = "0x180BA2400")]
	public void SetInteractableAllContents(bool interactable)
	{
	}

	[Token(Token = "0x6007466")]
	[Address(RVA = "0xBA2510", Offset = "0xBA1710", VA = "0x180BA2510")]
	public void SetShortCutBackButton(bool isSet)
	{
	}

	[Token(Token = "0x6007467")]
	[Address(RVA = "0xBA34F0", Offset = "0xBA26F0", VA = "0x180BA34F0")]
	public void SwapBeforeParent(ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6007468")]
	[Address(RVA = "0xBA0AD0", Offset = "0xB9FCD0", VA = "0x180BA0AD0")]
	public GameObject GetTopFrontGameObject(IsDispHeader isDispHeader)
	{
		return null;
	}

	[Token(Token = "0x6007469")]
	[Address(RVA = "0xBA1FD0", Offset = "0xBA11D0", VA = "0x180BA1FD0")]
	private void ResetOption()
	{
	}

	[Token(Token = "0x600746A")]
	[Address(RVA = "0xBA2A20", Offset = "0xBA1C20", VA = "0x180BA2A20")]
	private void StateChange(ViewController vc, bool forceHide = false)
	{
	}

	[Token(Token = "0x600746B")]
	[Address(RVA = "0xBA4A70", Offset = "0xBA3C70", VA = "0x180BA4A70")]
	private void doHome()
	{
	}

	[Token(Token = "0x600746C")]
	[Address(RVA = "0xBA1140", Offset = "0xBA0340", VA = "0x180BA1140")]
	private bool IsSupportedView(ViewController vc)
	{
		return default(bool);
	}

	[Token(Token = "0x600746D")]
	[Address(RVA = "0xBA24C0", Offset = "0xBA16C0", VA = "0x180BA24C0")]
	private void SetIsDisp(IsDispHeader disp, bool flag)
	{
	}

	[Token(Token = "0x600746E")]
	[Address(RVA = "0xBA3FF0", Offset = "0xBA31F0", VA = "0x180BA3FF0")]
	private void UpdateDispPart(Part part)
	{
	}

	[Token(Token = "0x600746F")]
	[Address(RVA = "0xBA0F30", Offset = "0xBA0130", VA = "0x180BA0F30")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x6007470")]
	[Address(RVA = "0xBA2180", Offset = "0xBA1380", VA = "0x180BA2180")]
	private void SetDispAllContents(bool flag)
	{
	}

	[Token(Token = "0x6007471")]
	[Address(RVA = "0xBA0D10", Offset = "0xB9FF10", VA = "0x180BA0D10")]
	private bool IsDispAnyContent(Part part = Part.ALL)
	{
		return default(bool);
	}

	[Token(Token = "0x6007472")]
	[Address(RVA = "0xBA3420", Offset = "0xBA2620", VA = "0x180BA3420")]
	private void StateNotificator(object mes)
	{
	}

	[Token(Token = "0x6007473")]
	[Address(RVA = "0xBA18F0", Offset = "0xBA0AF0", VA = "0x180BA18F0")]
	private void NotifyTransition(TransitionType tt, ViewController vc, ViewController preVc)
	{
	}

	[Token(Token = "0x6007474")]
	[Address(RVA = "0xBA1B50", Offset = "0xBA0D50", VA = "0x180BA1B50")]
	private void OnBackEvent(ViewControllerManager vcm)
	{
	}

	[Token(Token = "0x6007475")]
	[Address(RVA = "0xBA0CA0", Offset = "0xB9FEA0", VA = "0x180BA0CA0")]
	private void InitializeSelector()
	{
	}

	[Token(Token = "0x6007476")]
	[Address(RVA = "0xBA09D0", Offset = "0xB9FBD0", VA = "0x180BA09D0")]
	private void FinalizeSelector()
	{
	}

	[Token(Token = "0x6007477")]
	[Address(RVA = "0xBA24E0", Offset = "0xBA16E0", VA = "0x180BA24E0")]
	private void SetSelectorEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6007478")]
	[Address(RVA = "0xBA0A20", Offset = "0xB9FC20", VA = "0x180BA0A20")]
	private ViewControllerManager GetContentManager()
	{
		return null;
	}

	[Token(Token = "0x6007479")]
	[Address(RVA = "0xBA4790", Offset = "0xBA3990", VA = "0x180BA4790")]
	public HeaderViewController()
	{
	}
}
