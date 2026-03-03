using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CC2")]
public class MDMarkupAssetViewController : BaseBlurOverlayViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x2000CC3")]
	private enum InitFlags
	{
		[Token(Token = "0x4009C16")]
		None = 0,
		[Token(Token = "0x4009C17")]
		LoadMarkupAsset = 1,
		[Token(Token = "0x4009C18")]
		InitializedMarkupFactory = 2,
		[Token(Token = "0x4009C19")]
		CreateViewStart = 4,
		[Token(Token = "0x4009C1A")]
		CreateViewEnd = 8,
		[Token(Token = "0x4009C1B")]
		MarkupTextLoad = 0x10,
		[Token(Token = "0x4009C1C")]
		MarkupPreLoadStart = 0x20,
		[Token(Token = "0x4009C1D")]
		MarkupPreLoadEnd = 0x40,
		[Token(Token = "0x4009C1E")]
		MarkupOutputGraphStart = 0x80,
		[Token(Token = "0x4009C1F")]
		MarkupOutputGraphEnd = 0x100
	}

	[Token(Token = "0x4009BF9")]
	private const string k_PrefPath = "MDMarkupAsset";

	[Token(Token = "0x4009BFA")]
	public const string k_ArgKeyOpenOnHome = "openOnHome";

	[Token(Token = "0x4009BFB")]
	private const string k_ArgKeySourceAsset = "sourceAsset";

	[Token(Token = "0x4009BFC")]
	private const string k_ArgKeySourceJson = "sourceJson";

	[Token(Token = "0x4009BFD")]
	private const string k_ArgKeyOpenArgs = "openArgs";

	[Token(Token = "0x4009BFE")]
	private const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x4009BFF")]
	public const string k_ArgKeyCloseButtonType = "closeButtonType";

	[Token(Token = "0x4009C00")]
	public const string k_ArgKeyTitle = "title";

	[Token(Token = "0x4009C01")]
	public const string k_ArgKeyOptionalText = "optionalText";

	[Token(Token = "0x4009C02")]
	public const string k_ArgKeyBadge = "badge";

	[Token(Token = "0x4009C03")]
	public const string k_ArgKeyBgId = "bgId";

	[Token(Token = "0x4009C04")]
	public const string k_ArgKeyBehaviourController = "behaviourController";

	[Token(Token = "0x4009C05")]
	public const string k_OVGLabel_Default = "Default";

	[Token(Token = "0x4009C06")]
	public const string k_OVGLabel_Dialog = "Dialog";

	[Token(Token = "0x4009C07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ViewLabelBoard;

	[Token(Token = "0x4009C08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ViewLabelPager;

	[Token(Token = "0x4009C09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ViewLabelTabs;

	[Token(Token = "0x4009C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ViewLabelBoardPager;

	[Token(Token = "0x4009C0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelCloseButton;

	[Token(Token = "0x4009C0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelDialogFooterShortcutKey;

	[Token(Token = "0x4009C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private InitFlags m_InitStep;

	[Token(Token = "0x4009C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private bool m_Aborted;

	[Token(Token = "0x4009C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private MDMarkupAsset m_MDMarkupAsset;

	[Token(Token = "0x4009C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Dictionary<string, object> m_MDMarkupArgs;

	[Token(Token = "0x4009C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private MDMarkupGraphFactory m_MDMarkupGraphFactory;

	[Token(Token = "0x4009C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private IMDMarkupContainerWidget m_ContainerWidget;

	[Token(Token = "0x4009C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private IMDMarkupAssetBehaviourController m_BehaviourController;

	[Token(Token = "0x4009C14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private int m_BgId;

	[Token(Token = "0x17000AF7")]
	protected override bool defaultBlurOverlay
	{
		[Token(Token = "0x6004D47")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AF8")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6004D48")]
		[Address(RVA = "0x950950", Offset = "0x94FB50", VA = "0x180950950", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000AF9")]
	public bool IsInstantView
	{
		[Token(Token = "0x6004D49")]
		[Address(RVA = "0x950940", Offset = "0x94FB40", VA = "0x180950940")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004D4A")]
	[Address(RVA = "0x94E050", Offset = "0x94D250", VA = "0x18094E050")]
	protected static bool IsInstantViewLaunch(ViewControllerManager vcm)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D4B")]
	[Address(RVA = "0x9503F0", Offset = "0x94F5F0", VA = "0x1809503F0")]
	public string TryGetSourceName()
	{
		return null;
	}

	[Token(Token = "0x6004D4C")]
	[Address(RVA = "0x94FBF0", Offset = "0x94EDF0", VA = "0x18094FBF0")]
	public static void PushByContainer(ViewControllerManager vcm, IMDMarkupContainer container, [Optional] Action callback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004D4D")]
	[Address(RVA = "0x94F480", Offset = "0x94E680", VA = "0x18094F480")]
	public static void OpenByAsset(string assetPath, [Optional] Action callback, [Optional] Dictionary<string, object> args, [Optional] ViewControllerManager manager)
	{
	}

	[Token(Token = "0x6004D4E")]
	[Address(RVA = "0x950160", Offset = "0x94F360", VA = "0x180950160")]
	public static void SwapOpenByAsset(ViewController target, string assetPath, [Optional] Action callback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004D4F")]
	[Address(RVA = "0x94F620", Offset = "0x94E820", VA = "0x18094F620")]
	public static void OpenByAsset(MDMarkupAsset asset, [Optional] Action callback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004D50")]
	[Address(RVA = "0x950290", Offset = "0x94F490", VA = "0x180950290")]
	public static void SwapOpenByAsset(ViewController target, MDMarkupAsset asset, [Optional] Action callback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004D51")]
	[Address(RVA = "0x94F740", Offset = "0x94E940", VA = "0x18094F740")]
	public static void OpenByJson(string json, [Optional] Action callback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004D52")]
	[Address(RVA = "0x94E020", Offset = "0x94D220", VA = "0x18094E020", Slot = "30")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x6004D53")]
	[Address(RVA = "0x94E0D0", Offset = "0x94D2D0", VA = "0x18094E0D0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004D54")]
	[Address(RVA = "0x94E9E0", Offset = "0x94DBE0", VA = "0x18094E9E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6004D55")]
	[Address(RVA = "0x94E870", Offset = "0x94DA70", VA = "0x18094E870")]
	private void OnCreatedMDMarkupAsset()
	{
	}

	[Token(Token = "0x6004D56")]
	[Address(RVA = "0x94FE30", Offset = "0x94F030", VA = "0x18094FE30")]
	private void SubmitMDMarkupAsset()
	{
	}

	[Token(Token = "0x6004D57")]
	[Address(RVA = "0x94F8A0", Offset = "0x94EAA0", VA = "0x18094F8A0", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x6004D58")]
	[Address(RVA = "0x94FD60", Offset = "0x94EF60", VA = "0x18094FD60")]
	private void Start()
	{
	}

	[Token(Token = "0x6004D59")]
	[Address(RVA = "0x94F200", Offset = "0x94E400", VA = "0x18094F200")]
	private void OnFailedOpen()
	{
	}

	[Token(Token = "0x6004D5A")]
	[Address(RVA = "0x94E790", Offset = "0x94D990", VA = "0x18094E790", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004D5B")]
	[Address(RVA = "0x950800", Offset = "0x94FA00", VA = "0x180950800")]
	public MDMarkupAssetViewController()
	{
	}
}
