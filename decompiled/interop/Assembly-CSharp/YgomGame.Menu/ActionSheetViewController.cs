using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x2001160")]
public class ActionSheetViewController : SelectDialogViewControllerBase<string, ActionSheetViewController.EntryData[], int>, IBokeSupported
{
	[Token(Token = "0x2001161")]
	public enum ButtonStyle
	{
		[Token(Token = "0x400B6B8")]
		Positive,
		[Token(Token = "0x400B6B9")]
		Destructive,
		[Token(Token = "0x400B6BA")]
		Disable,
		[Token(Token = "0x400B6BB")]
		Toggle,
		[Token(Token = "0x400B6BC")]
		Regulation,
		[Token(Token = "0x400B6BD")]
		ToggleRegulation
	}

	[Serializable]
	[Token(Token = "0x2001162")]
	public class EntryData
	{
		[Token(Token = "0x400B6BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x400B6BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string explainText;

		[Token(Token = "0x400B6C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ButtonStyle buttonStyle;

		[Token(Token = "0x400B6C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool clickableDisable;

		[Token(Token = "0x400B6C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool interactable;

		[Token(Token = "0x400B6C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string overrideSeClick;

		[Token(Token = "0x400B6C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool active;

		[Token(Token = "0x400B6C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string label;

		[Token(Token = "0x400B6C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string imagePath;

		[Token(Token = "0x400B6C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool badge;

		[Token(Token = "0x400B6C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int badgeNum;

		[Token(Token = "0x6006D11")]
		[Address(RVA = "0xB4D300", Offset = "0xB4C500", VA = "0x180B4D300")]
		public EntryData()
		{
		}

		[Token(Token = "0x6006D12")]
		[Address(RVA = "0xB4D440", Offset = "0xB4C640", VA = "0x180B4D440")]
		public EntryData(string text)
		{
		}

		[Token(Token = "0x6006D13")]
		[Address(RVA = "0xB4D1E0", Offset = "0xB4C3E0", VA = "0x180B4D1E0")]
		public EntryData(string text, ButtonStyle buttonStyle)
		{
		}

		[Token(Token = "0x6006D14")]
		[Address(RVA = "0xB4D480", Offset = "0xB4C680", VA = "0x180B4D480")]
		public EntryData(string text, string imagePath, ButtonStyle buttonStyle)
		{
		}

		[Token(Token = "0x6006D15")]
		[Address(RVA = "0xB4D170", Offset = "0xB4C370", VA = "0x180B4D170")]
		public EntryData(string text, ButtonStyle buttonStyle, string overrideSeClick)
		{
		}

		[Token(Token = "0x6006D16")]
		[Address(RVA = "0xB4D3E0", Offset = "0xB4C5E0", VA = "0x180B4D3E0")]
		public EntryData(string text, bool interactable, ButtonStyle buttonStyle)
		{
		}

		[Token(Token = "0x6006D17")]
		[Address(RVA = "0xB4D310", Offset = "0xB4C510", VA = "0x180B4D310")]
		public EntryData(string text, bool interactable = true, ButtonStyle buttonStyle = ButtonStyle.Positive, [Optional] string overrideSeClick, bool active = true, [Optional] string label, [Optional] string imagePath, bool badge = false, int badgeNum = 0, [Optional] string explainText, bool clickableDisable = false)
		{
		}

		[Token(Token = "0x6006D18")]
		[Address(RVA = "0xB4CCC0", Offset = "0xB4BEC0", VA = "0x180B4CCC0")]
		public static EntryData[] CreateEntrys(IReadOnlyList<string> entrys, int destructiveLength = 0)
		{
			return null;
		}

		[Token(Token = "0x6006D19")]
		[Address(RVA = "0xB4CEC0", Offset = "0xB4C0C0", VA = "0x180B4CEC0")]
		public static EntryData[] CreateToggle(IReadOnlyList<(string text, string path)> entrys)
		{
			return null;
		}
	}

	[Token(Token = "0x2001163")]
	public class EntryButtonsScrollWidget : ElementWidgetBase
	{
		[Token(Token = "0x400B6C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InfinityScrollView scrollView;

		[Token(Token = "0x400B6CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ScrollRect scrollRect;

		[Token(Token = "0x400B6CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly LayoutElement layoutElement;

		[Token(Token = "0x400B6CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly LayoutGroup contentLayoutGroup;

		[Token(Token = "0x6006D1A")]
		[Address(RVA = "0xB4CBB0", Offset = "0xB4BDB0", VA = "0x180B4CBB0")]
		public EntryButtonsScrollWidget(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x2001164")]
	public class EntryButtonWidget : ElementWidgetBase
	{
		[Token(Token = "0x400B6CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string k_ELabelText;

		[Token(Token = "0x400B6CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string k_ELabelExplainText;

		[Token(Token = "0x400B6CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string k_ELabelToggle;

		[Token(Token = "0x400B6D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly string k_ELabelImage;

		[Token(Token = "0x400B6D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly string k_ELabelBadge;

		[Token(Token = "0x400B6D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string k_ELabelButton;

		[Token(Token = "0x400B6D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly SelectionButton button;

		[Token(Token = "0x400B6D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly TMP_Text text;

		[Token(Token = "0x400B6D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public readonly TMP_Text explainText;

		[Token(Token = "0x400B6D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public readonly Image image;

		[Token(Token = "0x400B6D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public readonly ElementObjectManager badge;

		[Token(Token = "0x400B6D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public readonly string defaultSoundLabelClick;

		[Token(Token = "0x400B6D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Action<EntryButtonWidget> onClickCallback;

		[Token(Token = "0x6006D1B")]
		[Address(RVA = "0xB4C4B0", Offset = "0xB4B6B0", VA = "0x180B4C4B0")]
		public EntryButtonWidget(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006D1C")]
		[Address(RVA = "0x8E4E00", Offset = "0x8E4000", VA = "0x1808E4E00")]
		private void OnClick()
		{
		}
	}

	[Token(Token = "0x2001165")]
	public class EntryButtonWidgetToggle : EntryButtonWidget
	{
		[Token(Token = "0x400B6DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public readonly string k_ELabelImageOff;

		[Token(Token = "0x400B6DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public readonly string k_ELabelImageOn;

		[Token(Token = "0x400B6DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public readonly string k_ELabelOff;

		[Token(Token = "0x400B6DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public readonly string k_ELabelOn;

		[Token(Token = "0x400B6DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public readonly string k_ELabelTextOff;

		[Token(Token = "0x400B6DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public readonly string k_ELabelTextOn;

		[Token(Token = "0x400B6E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public readonly string k_ELabelToggleOff;

		[Token(Token = "0x400B6E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public readonly string k_ELabelToggleOn;

		[Token(Token = "0x400B6E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly string k_SEToggleOn;

		[Token(Token = "0x400B6E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly string k_SEToggleOff;

		[Token(Token = "0x400B6E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ActionSheetViewController actionSheetView;

		[Token(Token = "0x6006D1D")]
		[Address(RVA = "0xB4BEA0", Offset = "0xB4B0A0", VA = "0x180B4BEA0")]
		public EntryButtonWidgetToggle(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006D1E")]
		[Address(RVA = "0xB4BB60", Offset = "0xB4AD60", VA = "0x180B4BB60")]
		public void OnUpdate(EntryData entryData, bool isOnButton)
		{
		}
	}

	[Token(Token = "0x400B68F")]
	private const string k_PrefPath = "Common/ActionSheet/ActionSheet";

	[Token(Token = "0x400B690")]
	private const string k_ArgKeyMessage = "message";

	[Token(Token = "0x400B691")]
	private const string k_ArgKeyEmbedObject = "embedObject";

	[Token(Token = "0x400B692")]
	private const string k_ArgKeyEmbedObjectOnClick = "embedObjectOnClick";

	[Token(Token = "0x400B693")]
	private const string k_ArgKeyIdx = "checkIndex";

	[Token(Token = "0x400B694")]
	public const string k_ArgKeyOnCancel = "onCancelCallback";

	[Token(Token = "0x400B695")]
	private const string k_ArgKeyViewCreaterLabel = "ViewCreaterLabel";

	[Token(Token = "0x400B696")]
	private const string k_ArgKeyViewCreaterTypeLabel = "ViewCreaterTypeLabel";

	[Token(Token = "0x400B697")]
	private const string k_VCLabel_Deck = "View_Deck";

	[Token(Token = "0x400B698")]
	private const string k_VCLabel_Promo = "View_Promo";

	[Token(Token = "0x400B699")]
	private const string k_ArgKeyBannerPath = "BannerPath";

	[Token(Token = "0x400B69A")]
	private const string k_ArgKeyIconPath = "IconPath";

	[Token(Token = "0x400B69B")]
	private const string k_ArgKeySkipAdditionalButton = "SkipAdditionalButton";

	[Token(Token = "0x400B69C")]
	private const string k_ArgKeyCustomButtonMap = "customButtonMap";

	[Token(Token = "0x400B69D")]
	private const string k_ArgKeyCustomOnCreateButtonCallback = "customOnCreateButtonCallback";

	[Token(Token = "0x400B69E")]
	private const string k_ArgKeyCustomOnUpdateButtonCallback = "customOnUpdateButtonCallback";

	[Token(Token = "0x400B69F")]
	private const string k_ArgKeyAdditionalFooterOnClick = "additionalFooterOnClick";

	[Token(Token = "0x400B6A0")]
	private const string k_ArgKeyAdditionalFooterText = "additionalFooterText";

	[Token(Token = "0x400B6A1")]
	private const string k_ArgKeyOffCloseButton = "offCloseButton";

	[Token(Token = "0x400B6A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelCloseButton;

	[Token(Token = "0x400B6A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelTitleText;

	[Token(Token = "0x400B6A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelMessageArea;

	[Token(Token = "0x400B6A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelBanner;

	[Token(Token = "0x400B6A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelIcon;

	[Token(Token = "0x400B6A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelEmbedObjectArea;

	[Token(Token = "0x400B6A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelEntryButtonsScrollView;

	[Token(Token = "0x400B6A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelCancelButton;

	[Token(Token = "0x400B6AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public readonly string k_ELabelOff;

	[Token(Token = "0x400B6AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public readonly string k_ELabelOn;

	[Token(Token = "0x400B6AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400B6AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string k_ELabelShortcutIcon;

	[Token(Token = "0x400B6AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string k_SEFooterDecide;

	[Token(Token = "0x400B6AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private EntryButtonsScrollWidget m_EntryButtonsScrollWidget;

	[Token(Token = "0x400B6B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Dictionary<GameObject, EntryButtonWidget> m_EntryButtonWidgetMap;

	[Token(Token = "0x400B6B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private List<EntryData> m_EntryButtonDatas;

	[Token(Token = "0x400B6B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private List<EntryData> m_DisplayEntryButtonDatas;

	[Token(Token = "0x400B6B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<int> m_EntryButtonTemplateIdxs;

	[Token(Token = "0x400B6B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private int m_buttonIdx;

	[Token(Token = "0x400B6B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Action<ButtonStyle, EntryButtonWidget> m_CustomOnCreateCallback;

	[Token(Token = "0x400B6B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Action<ButtonStyle, EntryButtonWidget, EntryData, int> m_CustomOnUpdateButtonCallback;

	[Token(Token = "0x1700113F")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6006CE9")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001140")]
	protected override EntryData[] arg2
	{
		[Token(Token = "0x6006CEA")]
		[Address(RVA = "0xB42E90", Offset = "0xB42090", VA = "0x180B42E90", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001141")]
	protected override Action<int> arg3
	{
		[Token(Token = "0x6006CEB")]
		[Address(RVA = "0xB43110", Offset = "0xB42310", VA = "0x180B43110", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001142")]
	public GameObject embedObject
	{
		[Token(Token = "0x6006CEC")]
		[Address(RVA = "0xB431F0", Offset = "0xB423F0", VA = "0x180B431F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006CED")]
	[Address(RVA = "0xB41CF0", Offset = "0xB40EF0", VA = "0x180B41CF0")]
	public static void Open(string title, IReadOnlyList<string> entrys)
	{
	}

	[Token(Token = "0x6006CEE")]
	[Address(RVA = "0xB418A0", Offset = "0xB40AA0", VA = "0x180B418A0")]
	public static void Open(string title, IReadOnlyList<string> entrys, Action<int> callback)
	{
	}

	[Token(Token = "0x6006CEF")]
	[Address(RVA = "0xB420A0", Offset = "0xB412A0", VA = "0x180B420A0")]
	public static void Open(string title, IReadOnlyList<string> entrys, Action<int> callback, Action onCancel)
	{
	}

	[Token(Token = "0x6006CF0")]
	[Address(RVA = "0xB41850", Offset = "0xB40A50", VA = "0x180B41850")]
	public static void Open(string title, IReadOnlyList<string> entrys, int destructiveLength = 0, [Optional] Action<int> callback, [Optional] Action onCancel)
	{
	}

	[Token(Token = "0x6006CF1")]
	[Address(RVA = "0xB41F40", Offset = "0xB41140", VA = "0x180B41F40")]
	public static void Open(int idx, string title, IReadOnlyList<string> entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CF2")]
	[Address(RVA = "0xB41AD0", Offset = "0xB40CD0", VA = "0x180B41AD0")]
	public static void Open(int idx, string title, IReadOnlyList<(string buttonText, string imagePath)> entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CF3")]
	[Address(RVA = "0xB41D30", Offset = "0xB40F30", VA = "0x180B41D30")]
	public static void Open(int idx, string title, EntryData[] entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CF4")]
	[Address(RVA = "0xB418F0", Offset = "0xB40AF0", VA = "0x180B418F0")]
	public static void Open(string title, EntryData[] entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CF5")]
	[Address(RVA = "0xB407F0", Offset = "0xB3F9F0", VA = "0x180B407F0")]
	public static void OpenCustomSheet(string title, EntryData[] entrys, Dictionary<ButtonStyle, GameObject> customButtonMap, Action<ButtonStyle, EntryButtonWidget> customOnCreateCallback, Action<ButtonStyle, EntryButtonWidget, EntryData, int> customOnUpdateButtonCallback, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] string message, [Optional] GameObject embedObject, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CF6")]
	[Address(RVA = "0xB40B40", Offset = "0xB3FD40", VA = "0x180B40B40")]
	public static void OpenCustomToggleGroup(string title, EntryData[] entrys, string additionalFooterText, [Optional] Action<bool[]> callback, [Optional] Action onCancel, [Optional] string message, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CF7")]
	[Address(RVA = "0xB40CE0", Offset = "0xB3FEE0", VA = "0x180B40CE0")]
	public static void OpenMessage(string title, string message, IReadOnlyList<string> entrys, [Optional] Action<int> callback, [Optional] Action onCancel)
	{
	}

	[Token(Token = "0x6006CF8")]
	[Address(RVA = "0xB40FA0", Offset = "0xB401A0", VA = "0x180B40FA0")]
	public static void OpenMessage(string title, string message, IReadOnlyList<string> entrys, int destructiveLength = 0, [Optional] Action<int> callback, [Optional] Action onCancel)
	{
	}

	[Token(Token = "0x6006CF9")]
	[Address(RVA = "0xB40D40", Offset = "0xB3FF40", VA = "0x180B40D40")]
	public static void OpenMessage(string title, string message, EntryData[] entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CFA")]
	[Address(RVA = "0xB413A0", Offset = "0xB405A0", VA = "0x180B413A0")]
	public static void OpenWithEmbedObject(string title, GameObject embedObject, IReadOnlyList<string> entrys, int destructiveLength = 0, [Optional] Action<int> callback, [Optional] Action onCancel)
	{
	}

	[Token(Token = "0x6006CFB")]
	[Address(RVA = "0xB41400", Offset = "0xB40600", VA = "0x180B41400")]
	public static void OpenWithEmbedObject(string title, GameObject embedObject, EntryData[] entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CFC")]
	[Address(RVA = "0xB41000", Offset = "0xB40200", VA = "0x180B41000")]
	public static void OpenWithEmbedObject_Deck(string title, GameObject embedObject, EntryData[] entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args, bool enableEmbedClose = true)
	{
	}

	[Token(Token = "0x6006CFD")]
	[Address(RVA = "0xB41660", Offset = "0xB40860", VA = "0x180B41660")]
	public static void Open_Promo(string title, string message, string bannerPath, string iconPath, bool skipAdditionalButton, EntryData[] entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006CFE")]
	[Address(RVA = "0xB42180", Offset = "0xB41380", VA = "0x180B42180")]
	public static bool TryGetLaunchedInstance(out ActionSheetViewController instance)
	{
		return default(bool);
	}

	[Token(Token = "0x6006CFF")]
	[Address(RVA = "0xB3E110", Offset = "0xB3D310", VA = "0x180B3E110", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006D00")]
	[Address(RVA = "0xB3EC70", Offset = "0xB3DE70", VA = "0x180B3EC70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006D01")]
	[Address(RVA = "0xB42100", Offset = "0xB41300", VA = "0x180B42100")]
	private void Start()
	{
	}

	[Token(Token = "0x6006D02")]
	[Address(RVA = "0xB3E0A0", Offset = "0xB3D2A0", VA = "0x180B3E0A0")]
	private bool IsPromo()
	{
		return default(bool);
	}

	[Token(Token = "0x6006D03")]
	[Address(RVA = "0xB3DED0", Offset = "0xB3D0D0", VA = "0x180B3DED0")]
	private void EntrySetting()
	{
	}

	[Token(Token = "0x6006D04")]
	[Address(RVA = "0xB3DF50", Offset = "0xB3D150", VA = "0x180B3DF50")]
	public EntryData GetEntry(string label)
	{
		return null;
	}

	[Token(Token = "0x6006D05")]
	[Address(RVA = "0xB423C0", Offset = "0xB415C0", VA = "0x180B423C0")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6006D06")]
	[Address(RVA = "0xB423F0", Offset = "0xB415F0", VA = "0x180B423F0")]
	public void UpdateEntries()
	{
	}

	[Token(Token = "0x6006D07")]
	[Address(RVA = "0xB3E6F0", Offset = "0xB3D8F0", VA = "0x180B3E6F0")]
	private void OnCreateButtonEntity(GameObject buttonEntity)
	{
	}

	[Token(Token = "0x6006D08")]
	[Address(RVA = "0xB404D0", Offset = "0xB3F6D0", VA = "0x180B404D0")]
	private void OnUpdateButtonEntity(GameObject buttonEntity, int idx)
	{
	}

	[Token(Token = "0x6006D09")]
	[Address(RVA = "0xB3DE50", Offset = "0xB3D050", VA = "0x180B3DE50")]
	private bool CustomButtonEntityInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D0A")]
	[Address(RVA = "0xB3E380", Offset = "0xB3D580", VA = "0x180B3E380")]
	private void OnClickButtonEntity(EntryButtonWidget buttonWidget)
	{
	}

	[Token(Token = "0x6006D0B")]
	[Address(RVA = "0xB3E2B0", Offset = "0xB3D4B0", VA = "0x180B3E2B0")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x6006D0C")]
	[Address(RVA = "0xB42AD0", Offset = "0xB41CD0", VA = "0x180B42AD0")]
	public ActionSheetViewController()
	{
	}
}
