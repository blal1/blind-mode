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

[Token(Token = "0x200116E")]
public class FilterSelectViewController : SelectDialogViewControllerBase<string, FilterSelectViewController.EntryData[], int>, IBokeSupported
{
	[Token(Token = "0x200116F")]
	public enum ButtonStyle
	{
		[Token(Token = "0x400B72A")]
		Toggle,
		[Token(Token = "0x400B72B")]
		ToggleRegulation
	}

	[Serializable]
	[Token(Token = "0x2001170")]
	public class EntryData
	{
		[Token(Token = "0x400B72C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x400B72D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ButtonStyle buttonStyle;

		[Token(Token = "0x400B72E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool interactable;

		[Token(Token = "0x400B72F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string overrideSeClick;

		[Token(Token = "0x400B730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isOn;

		[Token(Token = "0x400B731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string imagePath;

		[Token(Token = "0x400B732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool badge;

		[Token(Token = "0x6006D65")]
		[Address(RVA = "0xB4D2C0", Offset = "0xB4C4C0", VA = "0x180B4D2C0")]
		public EntryData(string text)
		{
		}

		[Token(Token = "0x6006D66")]
		[Address(RVA = "0xB4D230", Offset = "0xB4C430", VA = "0x180B4D230")]
		public EntryData(string text, ButtonStyle buttonStyle = ButtonStyle.Toggle, bool interactable = true, [Optional] string overrideSeClick, bool isOn = false, [Optional] string imagePath, bool badge = false)
		{
		}
	}

	[Token(Token = "0x2001171")]
	public class EntryButtonsScrollWidget : ElementWidgetBase
	{
		[Token(Token = "0x400B733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InfinityScrollView scrollView;

		[Token(Token = "0x400B734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ScrollRect scrollRect;

		[Token(Token = "0x400B735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly LayoutElement layoutElement;

		[Token(Token = "0x6006D67")]
		[Address(RVA = "0xB4CAE0", Offset = "0xB4BCE0", VA = "0x180B4CAE0")]
		public EntryButtonsScrollWidget(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x2001172")]
	public class EntryButtonWidget : ElementWidgetBase
	{
		[Token(Token = "0x400B736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string k_ELabelText;

		[Token(Token = "0x400B737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string k_ELabelImage;

		[Token(Token = "0x400B738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string k_ELabelBadge;

		[Token(Token = "0x400B739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly string k_ELabelImageOff;

		[Token(Token = "0x400B73A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly string k_ELabelImageOn;

		[Token(Token = "0x400B73B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string k_ELabelOff;

		[Token(Token = "0x400B73C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly string k_ELabelOn;

		[Token(Token = "0x400B73D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly string k_ELabelTextOff;

		[Token(Token = "0x400B73E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public readonly string k_ELabelTextOn;

		[Token(Token = "0x400B73F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string k_SEToggleOn;

		[Token(Token = "0x400B740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly string k_SEToggleOff;

		[Token(Token = "0x400B741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public readonly SelectionButton button;

		[Token(Token = "0x400B742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public readonly TMP_Text text;

		[Token(Token = "0x400B743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public readonly Image image;

		[Token(Token = "0x400B744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public readonly GameObject badge;

		[Token(Token = "0x400B745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public readonly string defaultSoundLabelClick;

		[Token(Token = "0x400B746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Action<EntryButtonWidget> onClickCallback;

		[Token(Token = "0x6006D68")]
		[Address(RVA = "0xB4C7A0", Offset = "0xB4B9A0", VA = "0x180B4C7A0")]
		public EntryButtonWidget(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006D69")]
		[Address(RVA = "0xA46750", Offset = "0xA45950", VA = "0x180A46750")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6006D6A")]
		[Address(RVA = "0xB4C190", Offset = "0xB4B390", VA = "0x180B4C190", Slot = "10")]
		public virtual void OnUpdate(EntryData entryData)
		{
		}
	}

	[Token(Token = "0x2001173")]
	public class EntryButtonWidgetToggle : EntryButtonWidget
	{
		[Token(Token = "0x400B747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public readonly string k_ELabelToggleOff;

		[Token(Token = "0x400B748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public readonly string k_ELabelToggleOn;

		[Token(Token = "0x400B749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly string k_SEToggleOn;

		[Token(Token = "0x400B74A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly string k_SEToggleOff;

		[Token(Token = "0x400B74B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ActionSheetViewController actionSheetView;

		[Token(Token = "0x6006D6B")]
		[Address(RVA = "0xB4C0A0", Offset = "0xB4B2A0", VA = "0x180B4C0A0")]
		public EntryButtonWidgetToggle(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006D6C")]
		[Address(RVA = "0xB4B830", Offset = "0xB4AA30", VA = "0x180B4B830", Slot = "10")]
		public override void OnUpdate(EntryData entryData)
		{
		}
	}

	[Token(Token = "0x400B716")]
	private const string k_PrefPath = "Common/FilterSelect/FilterSelect";

	[Token(Token = "0x400B717")]
	private const string k_ArgKeyMessage = "message";

	[Token(Token = "0x400B718")]
	private const string k_ArgKeyEmbedObject = "embedObject";

	[Token(Token = "0x400B719")]
	public const string k_ArgKeyOnCancel = "onCancelCallback";

	[Token(Token = "0x400B71A")]
	public const string k_ArgKeyOnDecide = "onDecideCallback";

	[Token(Token = "0x400B71B")]
	public const string k_ArgKeyAddFooterOnShortcutButton = "addFooterOnShortcut";

	[Token(Token = "0x400B71C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelTitleText;

	[Token(Token = "0x400B71D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelMessageArea;

	[Token(Token = "0x400B71E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelEmbedObjectArea;

	[Token(Token = "0x400B71F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelEntryButtonsScrollView;

	[Token(Token = "0x400B720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelCancelButton;

	[Token(Token = "0x400B721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelDecideButton;

	[Token(Token = "0x400B722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelShortcutIcon;

	[Token(Token = "0x400B723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400B724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private EntryButtonsScrollWidget m_EntryButtonsScrollWidget;

	[Token(Token = "0x400B725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Dictionary<GameObject, EntryButtonWidget> m_EntryButtonWidgetMap;

	[Token(Token = "0x400B726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<EntryData> m_EntryButtonDatas;

	[Token(Token = "0x400B727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private List<EntryData> m_DisplayEntryButtonDatas;

	[Token(Token = "0x400B728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<int> m_EntryButtonTemplateIdxs;

	[Token(Token = "0x17001146")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6006D55")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001147")]
	protected override EntryData[] arg2
	{
		[Token(Token = "0x6006D56")]
		[Address(RVA = "0xB4FD90", Offset = "0xB4EF90", VA = "0x180B4FD90", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001148")]
	protected override Action<int> arg3
	{
		[Token(Token = "0x6006D57")]
		[Address(RVA = "0xB50010", Offset = "0xB4F210", VA = "0x180B50010", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006D58")]
	[Address(RVA = "0xB4F0D0", Offset = "0xB4E2D0", VA = "0x180B4F0D0")]
	public static void Open(string title, EntryData[] entrys, [Optional] Action<int> callback, [Optional] Action onCancel, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006D59")]
	[Address(RVA = "0xB4EE10", Offset = "0xB4E010", VA = "0x180B4EE10")]
	public static void OpenFilterSelect(string title, EntryData[] entrys, [Optional] Action<bool[]> callback, [Optional] Action onCancel, [Optional] string message, bool isFooterShortCut = true, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006D5A")]
	[Address(RVA = "0x540540", Offset = "0x53F740", VA = "0x180540540", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006D5B")]
	[Address(RVA = "0xB4DE90", Offset = "0xB4D090", VA = "0x180B4DE90", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006D5C")]
	[Address(RVA = "0xB4F2B0", Offset = "0xB4E4B0", VA = "0x180B4F2B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006D5D")]
	[Address(RVA = "0xB4F430", Offset = "0xB4E630", VA = "0x180B4F430")]
	public void UpdateEntries()
	{
	}

	[Token(Token = "0x6006D5E")]
	[Address(RVA = "0xB4DC70", Offset = "0xB4CE70", VA = "0x180B4DC70")]
	private void OnCreateButtonEntity(GameObject buttonEntity)
	{
	}

	[Token(Token = "0x6006D5F")]
	[Address(RVA = "0xB4ED10", Offset = "0xB4DF10", VA = "0x180B4ED10")]
	private void OnUpdateButtonEntity(GameObject buttonEntity, int idx)
	{
	}

	[Token(Token = "0x6006D60")]
	[Address(RVA = "0xB4DB20", Offset = "0xB4CD20", VA = "0x180B4DB20")]
	private void OnClickButtonEntity(EntryButtonWidget buttonWidget)
	{
	}

	[Token(Token = "0x6006D61")]
	[Address(RVA = "0xB4DA50", Offset = "0xB4CC50", VA = "0x180B4DA50")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x6006D62")]
	[Address(RVA = "0xB4EC40", Offset = "0xB4DE40", VA = "0x180B4EC40")]
	private void OnDecide()
	{
	}

	[Token(Token = "0x6006D63")]
	[Address(RVA = "0xB4FAC0", Offset = "0xB4ECC0", VA = "0x180B4FAC0")]
	public FilterSelectViewController()
	{
	}
}
