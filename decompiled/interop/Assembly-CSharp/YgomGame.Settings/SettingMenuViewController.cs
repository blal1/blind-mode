using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomGame.TextIDs;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Settings;

[Token(Token = "0x20009F3")]
public class SettingMenuViewController : BaseMenuViewController
{
	[Token(Token = "0x20009F4")]
	private class ButtonData
	{
		[Token(Token = "0x4008EBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string currentText;

		[Token(Token = "0x4008EC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] textArray;

		[Token(Token = "0x6003D20")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ButtonData()
		{
		}
	}

	[Token(Token = "0x20009F5")]
	private enum Mode
	{
		[Token(Token = "0x4008EC2")]
		Home,
		[Token(Token = "0x4008EC3")]
		DuelPlayer,
		[Token(Token = "0x4008EC4")]
		DuelAudience,
		[Token(Token = "0x4008EC5")]
		Title
	}

	[Token(Token = "0x20009F6")]
	public enum Page
	{
		[Token(Token = "0x4008EC7")]
		General,
		[Token(Token = "0x4008EC8")]
		Duel,
		[Token(Token = "0x4008EC9")]
		Audience,
		[Token(Token = "0x4008ECA")]
		CrossPlay,
		[Token(Token = "0x4008ECB")]
		Privacy,
		[Token(Token = "0x4008ECC")]
		Num
	}

	[Token(Token = "0x20009F7")]
	private class PageInfo
	{
		[Token(Token = "0x4008ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Page page;

		[Token(Token = "0x4008ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ElementObjectManager root;

		[Token(Token = "0x4008ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ElementObject buttonEO;

		[Token(Token = "0x4008ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SelectionButton button;

		[Token(Token = "0x4008ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject on;

		[Token(Token = "0x4008ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject off;

		[Token(Token = "0x4008ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject menuGroup;

		[Token(Token = "0x4008ED4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ExtendedScrollRect scroll;

		[Token(Token = "0x4008ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LayoutGroup layout;

		[Token(Token = "0x4008ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Dictionary<Menu, ElementObjectManager> menu;

		[Token(Token = "0x4008ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Menu currentMenu;

		[Token(Token = "0x4008ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SelectionItem preSelectedMenuItem;

		[Token(Token = "0x4008ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action onShowPage;

		[Token(Token = "0x6003D21")]
		[Address(RVA = "0x846BC0", Offset = "0x845DC0", VA = "0x180846BC0")]
		public ElementObjectManager AddMenu(Menu menuType, bool leftBack, ElementObjectManager template, Transform parent, IDS_PREFERENCE titleText, bool showArrow)
		{
			return null;
		}

		[Token(Token = "0x6003D22")]
		[Address(RVA = "0x847140", Offset = "0x846340", VA = "0x180847140")]
		public ElementObjectManager AddMenu(Menu menuType, bool leftBack, ElementObjectManager template, Transform parent, string titleText, bool showArrow)
		{
			return null;
		}

		[Token(Token = "0x6003D23")]
		[Address(RVA = "0x846D10", Offset = "0x845F10", VA = "0x180846D10")]
		private ElementObjectManager AddMenu(Menu menuType, ElementObjectManager ui, bool leftBack, string titleText, bool showArrow, RectTransform subMenuParentMenu, RectTransform subMenuParentContent)
		{
			return null;
		}

		[Token(Token = "0x6003D24")]
		[Address(RVA = "0x847230", Offset = "0x846430", VA = "0x180847230")]
		public ElementObjectManager AddSubmenu(Menu menuType, Menu groupMenuType, string titleText, bool showArrow)
		{
			return null;
		}

		[Token(Token = "0x6003D25")]
		[Address(RVA = "0x847400", Offset = "0x846600", VA = "0x180847400")]
		public ElementObjectManager AddSubmenu(Menu menuType, Menu groupMenuType, IDS_PREFERENCE titleText, bool showArrow)
		{
			return null;
		}

		[Token(Token = "0x6003D26")]
		[Address(RVA = "0x8479A0", Offset = "0x846BA0", VA = "0x1808479A0")]
		public void OpenSubMenu(Menu groupMenuType, bool immediate)
		{
		}

		[Token(Token = "0x6003D27")]
		[Address(RVA = "0x847620", Offset = "0x846820", VA = "0x180847620")]
		public void CloseSubMenu(Menu groupMenuType, bool immediate)
		{
		}

		[Token(Token = "0x6003D28")]
		[Address(RVA = "0x847B90", Offset = "0x846D90", VA = "0x180847B90")]
		public void SelectTopOrPreSelectedMenu()
		{
		}

		[Token(Token = "0x6003D29")]
		[Address(RVA = "0x847FD0", Offset = "0x8471D0", VA = "0x180847FD0")]
		public void ShowPage()
		{
		}

		[Token(Token = "0x6003D2A")]
		[Address(RVA = "0x847820", Offset = "0x846A20", VA = "0x180847820")]
		public void HidePage()
		{
		}

		[Token(Token = "0x6003D2B")]
		[Address(RVA = "0x847EE0", Offset = "0x8470E0", VA = "0x180847EE0")]
		public void ShowMenu(bool show)
		{
		}

		[Token(Token = "0x6003D2C")]
		[Address(RVA = "0x848150", Offset = "0x847350", VA = "0x180848150")]
		public PageInfo()
		{
		}
	}

	[Token(Token = "0x20009FA")]
	public enum Menu
	{
		[Token(Token = "0x4008EE3")]
		BGM,
		[Token(Token = "0x4008EE4")]
		SE,
		[Token(Token = "0x4008EE5")]
		Voice,
		[Token(Token = "0x4008EE6")]
		Movie,
		[Token(Token = "0x4008EE7")]
		Quality,
		[Token(Token = "0x4008EE8")]
		CustomAntiAliasing,
		[Token(Token = "0x4008EE9")]
		CustomCardQuality,
		[Token(Token = "0x4008EEA")]
		CustomResolution,
		[Token(Token = "0x4008EEB")]
		Power,
		[Token(Token = "0x4008EEC")]
		Resolution,
		[Token(Token = "0x4008EED")]
		DisplayMode,
		[Token(Token = "0x4008EEE")]
		Language,
		[Token(Token = "0x4008EEF")]
		CardTextSize,
		[Token(Token = "0x4008EF0")]
		Vibration,
		[Token(Token = "0x4008EF1")]
		ShowOfficialIcon,
		[Token(Token = "0x4008EF2")]
		SelfChain,
		[Token(Token = "0x4008EF3")]
		ActivateConfirm,
		[Token(Token = "0x4008EF4")]
		CustomActivateConfirmUseSwitch,
		[Token(Token = "0x4008EF5")]
		CustomActivateConfirmDuelStart,
		[Token(Token = "0x4008EF6")]
		CustomActivateConfirmDefault,
		[Token(Token = "0x4008EF7")]
		CustomActivateConfirmHold0,
		[Token(Token = "0x4008EF8")]
		CustomActivateConfirmHold1,
		[Token(Token = "0x4008EF9")]
		SwitchOnTurnEnd,
		[Token(Token = "0x4008EFA")]
		AutoLocation,
		[Token(Token = "0x4008EFB")]
		AutoActivateOrder,
		[Token(Token = "0x4008EFC")]
		AutoCardInfo,
		[Token(Token = "0x4008EFD")]
		ShowSetCard,
		[Token(Token = "0x4008EFE")]
		ShowAudience,
		[Token(Token = "0x4008EFF")]
		ShowBattleStep,
		[Token(Token = "0x4008F00")]
		CommandType,
		[Token(Token = "0x4008F01")]
		SkipSummonEffect,
		[Token(Token = "0x4008F02")]
		SkipMonsterCutin,
		[Token(Token = "0x4008F03")]
		SkipCardRunEffect,
		[Token(Token = "0x4008F04")]
		UseConsoleLayout,
		[Token(Token = "0x4008F05")]
		CameraType,
		[Token(Token = "0x4008F06")]
		ShowRivalName,
		[Token(Token = "0x4008F07")]
		ShowCardReport,
		[Token(Token = "0x4008F08")]
		ShowHappenedEffect,
		[Token(Token = "0x4008F09")]
		CardSelectionListLayout,
		[Token(Token = "0x4008F0A")]
		GenericCardListLayout,
		[Token(Token = "0x4008F0B")]
		BgmMode,
		[Token(Token = "0x4008F0C")]
		AudienceAutoCardInfo,
		[Token(Token = "0x4008F0D")]
		AudienceShowSetCard,
		[Token(Token = "0x4008F0E")]
		AudienceShowAudience,
		[Token(Token = "0x4008F0F")]
		AudienceShowBattleStep,
		[Token(Token = "0x4008F10")]
		AudienceSkipSummonEffect,
		[Token(Token = "0x4008F11")]
		AudienceSkipMonsterCutin,
		[Token(Token = "0x4008F12")]
		AudienceSkipCardRunEffect,
		[Token(Token = "0x4008F13")]
		AudienceUseConsoleLayout,
		[Token(Token = "0x4008F14")]
		AudienceCameraType,
		[Token(Token = "0x4008F15")]
		AudienceShowRivalName,
		[Token(Token = "0x4008F16")]
		AudienceShowCardReport,
		[Token(Token = "0x4008F17")]
		AudienceShowHappenedEffect,
		[Token(Token = "0x4008F18")]
		AudienceGenericCardListLayout,
		[Token(Token = "0x4008F19")]
		CrossPlay,
		[Token(Token = "0x4008F1A")]
		PrivacyWatchPermission,
		[Token(Token = "0x4008F1B")]
		PrivacyAnonymous,
		[Token(Token = "0x4008F1C")]
		None
	}

	[Token(Token = "0x2000A02")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		[Token(Token = "0x4008F60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool dialogClosed;

		[Token(Token = "0x6003DA8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass68_0()
		{
		}

		[Token(Token = "0x6003DA9")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CShowLangChangedDialog_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000A03")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass76_0
	{
		[Token(Token = "0x4008F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action onComplete;

		[Token(Token = "0x6003DAA")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass76_0()
		{
		}

		[Token(Token = "0x6003DAB")]
		[Address(RVA = "0x438A10", Offset = "0x437C10", VA = "0x180438A10")]
		internal void _003CyLoadSounds_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000A04")]
	[CompilerGenerated]
	private sealed class _003CShowLangChangedDialog_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string changeAlartText;

		[Token(Token = "0x4008F65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string okText;

		[Token(Token = "0x4008F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass68_0 _003C_003E8__1;

		[Token(Token = "0x4008F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SettingMenuViewController _003C_003E4__this;

		[Token(Token = "0x17000811")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003DAF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000812")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003DB1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003DAC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShowLangChangedDialog_003Ed__68(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003DAD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003DAE")]
		[Address(RVA = "0x85C2B0", Offset = "0x85B4B0", VA = "0x18085C2B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003DB0")]
		[Address(RVA = "0x85C4D0", Offset = "0x85B6D0", VA = "0x18085C4D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000A05")]
	[CompilerGenerated]
	private sealed class _003CyLoadSounds_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onComplete;

		[Token(Token = "0x4008F6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass76_0 _003C_003E8__1;

		[Token(Token = "0x17000813")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003DB5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000814")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003DB7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003DB2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyLoadSounds_003Ed__76(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003DB3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003DB4")]
		[Address(RVA = "0x863B50", Offset = "0x862D50", VA = "0x180863B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003DB6")]
		[Address(RVA = "0x863D10", Offset = "0x862F10", VA = "0x180863D10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008E8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Dictionary<Page, PageInfo> pageInfo;

	[Token(Token = "0x4008E8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Page currentPage;

	[Token(Token = "0x4008E8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private bool isDirty;

	[Token(Token = "0x4008E8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int originBgmMode;

	[Token(Token = "0x4008E8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private bool switchBgmMode;

	[Token(Token = "0x4008E8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private SettingsUtil.DuelParam duelParam;

	[Token(Token = "0x4008E90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private SettingsUtil.BasicParam basicParam;

	[Token(Token = "0x4008E91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private SettingsUtil.SoundParam soundParam;

	[Token(Token = "0x4008E92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private SettingsUtil.SystemParam systemParam;

	[Token(Token = "0x4008E93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private SettingsUtil.AudienceParam audienceParam;

	[Token(Token = "0x4008E94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private SettingsUtil.PrivacyParam privacyParam;

	[Token(Token = "0x4008E95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Mode mode;

	[Token(Token = "0x4008E96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private int selectorGroupPriority;

	[Token(Token = "0x4008E97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Action onSurrendered;

	[Token(Token = "0x4008E98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Action<SettingsUtil.DuelParam.MANUAL_TYPE, bool> onChangeConfirm;

	[Token(Token = "0x4008E99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Action<bool> onChangeShowAudience;

	[Token(Token = "0x4008E9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Action<bool> onChangeShowBattleStep;

	[Token(Token = "0x4008E9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private Action<bool> onChangeShowSetCard;

	[Token(Token = "0x4008E9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Action onClosed;

	[Token(Token = "0x4008E9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private bool voiceAvailable;

	[Token(Token = "0x4008E9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
	private bool showSurrenderButton;

	[Token(Token = "0x4008E9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private string surrenderButtonText;

	[Token(Token = "0x4008EA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private string surrenderDialogText;

	[Token(Token = "0x4008EA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private bool isDuelTutorial;

	[Token(Token = "0x4008EA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x209")]
	private bool showHelpButton;

	[Token(Token = "0x4008EA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private Action onHelp;

	[Token(Token = "0x4008EA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private bool showRetryButton;

	[Token(Token = "0x4008EA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private Action onRetry;

	[Token(Token = "0x4008EA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private bool showConfirmButton;

	[Token(Token = "0x4008EA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private Action onConfirm;

	[Token(Token = "0x4008EA8")]
	public const string keyMode = "Mode";

	[Token(Token = "0x4008EA9")]
	public const string keySelectorGroupPriority = "SelectorGroupPriority";

	[Token(Token = "0x4008EAA")]
	public const string keyOnSurrenderedCallback = "OnSurrenderedCallback";

	[Token(Token = "0x4008EAB")]
	public const string keyOnChangeConfirmCallback = "OnChangeConfirmCallback";

	[Token(Token = "0x4008EAC")]
	public const string keyOnChangeShowAudienceCallback = "OnChangeShowAudienceCallback";

	[Token(Token = "0x4008EAD")]
	public const string keyOnChangeShowBattleStepCallback = "OnChangeShowBattleStepCallback";

	[Token(Token = "0x4008EAE")]
	public const string keyOnChangeShowSetCardCallback = "OnChangeShowSetCardCallback";

	[Token(Token = "0x4008EAF")]
	public const string keyOnClosedCallback = "OnClosedCallback";

	[Token(Token = "0x4008EB0")]
	public const string keyShowSurrenderButton = "ShowSurrenderButton";

	[Token(Token = "0x4008EB1")]
	public const string keySurrenderButtonText = "SurrenderButtonText";

	[Token(Token = "0x4008EB2")]
	public const string keySurrenderDialogText = "SurrenderDialogText";

	[Token(Token = "0x4008EB3")]
	public const string keyIsDuelTutorial = "IsDuelTutorial";

	[Token(Token = "0x4008EB4")]
	public const string keyShowHelpButton = "ShowHelpButton";

	[Token(Token = "0x4008EB5")]
	public const string keyOnHelpCallback = "OnHelpCallback";

	[Token(Token = "0x4008EB6")]
	public const string keyShowRetryButton = "ShowRetryButton";

	[Token(Token = "0x4008EB7")]
	public const string keyOnRetryCallback = "OnRetryCallback";

	[Token(Token = "0x4008EB8")]
	public const string keyViewStyleOVerride = "viewStyleOverride";

	[Token(Token = "0x4008EB9")]
	public const string keyOnShowConfirmButton = "ShowConfirmButton";

	[Token(Token = "0x4008EBA")]
	public const string keyOnConfirmCallback = "OnDeckConfirm";

	[Token(Token = "0x4008EBB")]
	private const string k_Sound_PreviewVoiceLabel = "V_TITLE_001";

	[Token(Token = "0x4008EBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private KeyCode[] surrenderCommand;

	[Token(Token = "0x4008EBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private int keyCommandIndex;

	[Token(Token = "0x4008EBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly SettingsUtil.PrivacyParam.WatchPermissionType[] s_watchPermissionMenuOrder;

	[Token(Token = "0x17000810")]
	private int currentBgmMode
	{
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x839490", Offset = "0x838690", VA = "0x180839490")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003CBD")]
	[Address(RVA = "0x8269C0", Offset = "0x825BC0", VA = "0x1808269C0")]
	public static Dictionary<string, object> GetHomeArgs(int selectorGroupPriority)
	{
		return null;
	}

	[Token(Token = "0x6003CBE")]
	[Address(RVA = "0x826D10", Offset = "0x825F10", VA = "0x180826D10")]
	public static Dictionary<string, object> GetTitleArgs()
	{
		return null;
	}

	[Token(Token = "0x6003CBF")]
	[Address(RVA = "0x826590", Offset = "0x825790", VA = "0x180826590")]
	public static Dictionary<string, object> GetDuelPlayerArgs(int selectorGroupPriority, Action onClosed, Action onSurrenderedCallback, Action<SettingsUtil.DuelParam.MANUAL_TYPE, bool> onChangeConfirm, Action<bool> onChangeShowAudience, Action<bool> onChangeShowSetCard, Action<bool> onChangeShowBattleStep, string surrenderButtonText, string surrenderDialogText, bool isDuelTutorial, bool showHelpButton, Action onHelp, bool showRetryButton = false, [Optional] Action onRetry, bool showConfirmButton = false, [Optional] Action onConfirm)
	{
		return null;
	}

	[Token(Token = "0x6003CC0")]
	[Address(RVA = "0x8262B0", Offset = "0x8254B0", VA = "0x1808262B0")]
	public static Dictionary<string, object> GetDuelAudienceArgs(int selectorGroupPriority, Action onClosed, Action onSurrenderedCallback, Action<bool> onChangeShowAudience, Action<bool> onChangeShowSetCard, Action<bool> onChangeShowBattleStep, string surrenderButtonText, string surrenderDialogText, bool showConfirmButton = false, [Optional] Action onConfirm)
	{
		return null;
	}

	[Token(Token = "0x6003CC1")]
	[Address(RVA = "0x825780", Offset = "0x824980", VA = "0x180825780")]
	private void GetArgs()
	{
	}

	[Token(Token = "0x6003CC2")]
	[Address(RVA = "0x827010", Offset = "0x826210", VA = "0x180827010", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003CC3")]
	[Address(RVA = "0x827740", Offset = "0x826940", VA = "0x180827740", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003CC4")]
	[Address(RVA = "0x8394B0", Offset = "0x8386B0", VA = "0x1808394B0")]
	private void setMenuTexts(Page page, Menu menu, string modeText, string noteText)
	{
	}

	[Token(Token = "0x6003CC5")]
	[Address(RVA = "0x8323D0", Offset = "0x8315D0", VA = "0x1808323D0")]
	private void SetupUI()
	{
	}

	[Token(Token = "0x6003CC6")]
	[Address(RVA = "0x838690", Offset = "0x837890", VA = "0x180838690")]
	[IteratorStateMachine(typeof(_003CShowLangChangedDialog_003Ed__68))]
	private IEnumerator ShowLangChangedDialog(string changeAlartText, string okText)
	{
		return null;
	}

	[Token(Token = "0x6003CC7")]
	[Address(RVA = "0x8311D0", Offset = "0x8303D0", VA = "0x1808311D0")]
	private void SetupMode(Mode mode)
	{
	}

	[Token(Token = "0x6003CC8")]
	[Address(RVA = "0x826B30", Offset = "0x825D30", VA = "0x180826B30")]
	private ElementObjectManager GetMenu(Menu menu)
	{
		return null;
	}

	[Token(Token = "0x6003CC9")]
	[Address(RVA = "0x82D8B0", Offset = "0x82CAB0", VA = "0x18082D8B0")]
	private void SetMenuConfigurable(Menu menu, bool on)
	{
	}

	[Token(Token = "0x6003CCA")]
	[Address(RVA = "0x8273A0", Offset = "0x8265A0", VA = "0x1808273A0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6003CCB")]
	[Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
	private void LoadIDS()
	{
	}

	[Token(Token = "0x6003CCC")]
	[Address(RVA = "0x838E40", Offset = "0x838040", VA = "0x180838E40")]
	private void UnloadIDS()
	{
	}

	[Token(Token = "0x6003CCD")]
	[Address(RVA = "0x826F30", Offset = "0x826130", VA = "0x180826F30")]
	private void LoadSounds()
	{
	}

	[Token(Token = "0x6003CCE")]
	[Address(RVA = "0x839600", Offset = "0x838800", VA = "0x180839600")]
	[IteratorStateMachine(typeof(_003CyLoadSounds_003Ed__76))]
	private IEnumerator yLoadSounds(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6003CCF")]
	[Address(RVA = "0x838ED0", Offset = "0x8380D0", VA = "0x180838ED0")]
	private void UnloadSounds()
	{
	}

	[Token(Token = "0x6003CD0")]
	[Address(RVA = "0x838740", Offset = "0x837940", VA = "0x180838740")]
	private void ShowPageMenu(Page page)
	{
	}

	[Token(Token = "0x6003CD1")]
	[Address(RVA = "0x827640", Offset = "0x826840", VA = "0x180827640")]
	private void OnCancel(bool pageBack)
	{
	}

	[Token(Token = "0x6003CD2")]
	[Address(RVA = "0x8256C0", Offset = "0x8248C0", VA = "0x1808256C0")]
	private void Close(bool playSE = true)
	{
	}

	[Token(Token = "0x6003CD3")]
	[Address(RVA = "0x827940", Offset = "0x826B40", VA = "0x180827940")]
	private void OnSurrender()
	{
	}

	[Token(Token = "0x6003CD4")]
	[Address(RVA = "0x827800", Offset = "0x826A00", VA = "0x180827800")]
	private void OnHelp()
	{
	}

	[Token(Token = "0x6003CD5")]
	[Address(RVA = "0x827780", Offset = "0x826980", VA = "0x180827780")]
	private void OnDeckConfirm()
	{
	}

	[Token(Token = "0x6003CD6")]
	[Address(RVA = "0x827830", Offset = "0x826A30", VA = "0x180827830")]
	private void OnRetry()
	{
	}

	[Token(Token = "0x6003CD7")]
	[Address(RVA = "0x82A250", Offset = "0x829450", VA = "0x18082A250")]
	private void SetBGM(float volume)
	{
	}

	[Token(Token = "0x6003CD8")]
	[Address(RVA = "0x82E4F0", Offset = "0x82D6F0", VA = "0x18082E4F0")]
	private void SetSE(float volume)
	{
	}

	[Token(Token = "0x6003CD9")]
	[Address(RVA = "0x830BF0", Offset = "0x82FDF0", VA = "0x180830BF0")]
	private void SetVoice(float volume)
	{
	}

	[Token(Token = "0x6003CDA")]
	[Address(RVA = "0x82DA20", Offset = "0x82CC20", VA = "0x18082DA20")]
	private void SetMovie(float volume)
	{
	}

	[Token(Token = "0x6003CDB")]
	[Address(RVA = "0x82DCB0", Offset = "0x82CEB0", VA = "0x18082DCB0")]
	private void SetQuality(SettingsUtil.BasicParam.QUALITY quality, bool onInitialize)
	{
	}

	[Token(Token = "0x6003CDC")]
	[Address(RVA = "0x82B490", Offset = "0x82A690", VA = "0x18082B490")]
	private void SetCustomAntiAliasing(SettingsUtil.BasicParam.ANTI_ALIASING antiAliasing)
	{
	}

	[Token(Token = "0x6003CDD")]
	[Address(RVA = "0x82B750", Offset = "0x82A950", VA = "0x18082B750")]
	private void SetCustomCardQuality(SettingsUtil.BasicParam.CARD_QUALITY cardQuality)
	{
	}

	[Token(Token = "0x6003CDE")]
	[Address(RVA = "0x82DB50", Offset = "0x82CD50", VA = "0x18082DB50")]
	private void SetPower(float volume)
	{
	}

	[Token(Token = "0x6003CDF")]
	[Address(RVA = "0x82E0F0", Offset = "0x82D2F0", VA = "0x18082E0F0")]
	private void SetResolution(int index)
	{
	}

	[Token(Token = "0x6003CE0")]
	[Address(RVA = "0x82BA10", Offset = "0x82AC10", VA = "0x18082BA10")]
	private void SetCustomResolution(int height)
	{
	}

	[Token(Token = "0x6003CE1")]
	[Address(RVA = "0x82BFF0", Offset = "0x82B1F0", VA = "0x18082BFF0")]
	private void SetDisplayMode(bool isFullScreen)
	{
	}

	[Token(Token = "0x6003CE2")]
	[Address(RVA = "0x82AAE0", Offset = "0x829CE0", VA = "0x18082AAE0")]
	private void SetCardTextSize(SettingsUtil.BasicParam.CARD_TEXT_SIZE type)
	{
	}

	[Token(Token = "0x6003CE3")]
	[Address(RVA = "0x830950", Offset = "0x82FB50", VA = "0x180830950")]
	private void SetVibration(bool active)
	{
	}

	[Token(Token = "0x6003CE4")]
	[Address(RVA = "0x82F520", Offset = "0x82E720", VA = "0x18082F520")]
	private void SetShowOfficialIcon()
	{
	}

	[Token(Token = "0x6003CE5")]
	[Address(RVA = "0x82B000", Offset = "0x82A200", VA = "0x18082B000")]
	private void SetCrossPlay()
	{
	}

	[Token(Token = "0x6003CE6")]
	[Address(RVA = "0x82E620", Offset = "0x82D820", VA = "0x18082E620")]
	private void SetSelfChain(SettingsUtil.DuelParam.CHAIN_TYPE type)
	{
	}

	[Token(Token = "0x6003CE7")]
	[Address(RVA = "0x82CEE0", Offset = "0x82C0E0", VA = "0x18082CEE0")]
	private void SetManualConfirm(SettingsUtil.DuelParam.MANUAL_TYPE type, bool onInitialize)
	{
	}

	[Token(Token = "0x6003CE8")]
	[Address(RVA = "0x830D20", Offset = "0x82FF20", VA = "0x180830D20")]
	private void SetupActiveConfirmSubmenu()
	{
	}

	[Token(Token = "0x6003CE9")]
	[Address(RVA = "0x82CBD0", Offset = "0x82BDD0", VA = "0x18082CBD0")]
	private void SetManualConfirmCustomUseSwitch(bool use)
	{
	}

	[Token(Token = "0x6003CEA")]
	[Address(RVA = "0x82C7D0", Offset = "0x82B9D0", VA = "0x18082C7D0")]
	private void SetManualConfirmCustomDuelStart(SettingsUtil.DuelParam.CONFIRM_MODE mode)
	{
	}

	[Token(Token = "0x6003CEB")]
	[Address(RVA = "0x82C780", Offset = "0x82B980", VA = "0x18082C780")]
	private void SetManualConfirmCustomDefault(SettingsUtil.DuelParam.CONFIRM_MODE mode)
	{
	}

	[Token(Token = "0x6003CEC")]
	[Address(RVA = "0x82C820", Offset = "0x82BA20", VA = "0x18082C820")]
	private void SetManualConfirmCustomHold0(SettingsUtil.DuelParam.CONFIRM_MODE mode)
	{
	}

	[Token(Token = "0x6003CED")]
	[Address(RVA = "0x82C870", Offset = "0x82BA70", VA = "0x18082C870")]
	private void SetManualConfirmCustomHold1(SettingsUtil.DuelParam.CONFIRM_MODE mode)
	{
	}

	[Token(Token = "0x6003CEE")]
	[Address(RVA = "0x82C8C0", Offset = "0x82BAC0", VA = "0x18082C8C0")]
	private void SetManualConfirmCustomText(Page page, Menu menu, SettingsUtil.DuelParam.CONFIRM_MODE mode)
	{
	}

	[Token(Token = "0x6003CEF")]
	[Address(RVA = "0x8303B0", Offset = "0x82F5B0", VA = "0x1808303B0")]
	private void SetSwitchOnTurnEnd(SettingsUtil.DuelParam.CONFIRM_SWITCH_MODE mode)
	{
	}

	[Token(Token = "0x6003CF0")]
	[Address(RVA = "0x82C520", Offset = "0x82B720", VA = "0x18082C520")]
	private void SetLocateType(SettingsUtil.DuelParam.LOCATE_TYPE type)
	{
	}

	[Token(Token = "0x6003CF1")]
	[Address(RVA = "0x82BDC0", Offset = "0x82AFC0", VA = "0x18082BDC0")]
	private void SetDecideActivateOrder(bool active)
	{
	}

	[Token(Token = "0x6003CF2")]
	[Address(RVA = "0x82ED40", Offset = "0x82DF40", VA = "0x18082ED40")]
	private void SetShowCardInfoType(int type)
	{
	}

	[Token(Token = "0x6003CF3")]
	[Address(RVA = "0x82F9F0", Offset = "0x82EBF0", VA = "0x18082F9F0")]
	private void SetShowSetCard(bool active)
	{
	}

	[Token(Token = "0x6003CF4")]
	[Address(RVA = "0x82E880", Offset = "0x82DA80", VA = "0x18082E880")]
	private void SetShowAudienceInfo(bool active)
	{
	}

	[Token(Token = "0x6003CF5")]
	[Address(RVA = "0x82EAE0", Offset = "0x82DCE0", VA = "0x18082EAE0")]
	private void SetShowBattleStep(bool active)
	{
	}

	[Token(Token = "0x6003CF6")]
	[Address(RVA = "0x82ADA0", Offset = "0x829FA0", VA = "0x18082ADA0")]
	private void SetCommandType(SettingsUtil.DuelParam.COMMAND_TYPE type)
	{
	}

	[Token(Token = "0x6003CF7")]
	[Address(RVA = "0x8300F0", Offset = "0x82F2F0", VA = "0x1808300F0")]
	private void SetSkipSummonEffectType(SettingsUtil.DuelParam.SKIP_TYPE type)
	{
	}

	[Token(Token = "0x6003CF8")]
	[Address(RVA = "0x82FEA0", Offset = "0x82F0A0", VA = "0x18082FEA0")]
	private void SetSkipMonsterCutinType(SettingsUtil.DuelParam.SKIP_TYPE type)
	{
	}

	[Token(Token = "0x6003CF9")]
	[Address(RVA = "0x82FC50", Offset = "0x82EE50", VA = "0x18082FC50")]
	private void SetSkipCardRunEffectType(SettingsUtil.DuelParam.SKIP_TYPE type)
	{
	}

	[Token(Token = "0x6003CFA")]
	[Address(RVA = "0x8306D0", Offset = "0x82F8D0", VA = "0x1808306D0")]
	private void SetUseConsoleLayout(bool active)
	{
	}

	[Token(Token = "0x6003CFB")]
	[Address(RVA = "0x82A5D0", Offset = "0x8297D0", VA = "0x18082A5D0")]
	private void SetCameraType(SettingsUtil.DuelParam.CAMERA_TYPE type)
	{
	}

	[Token(Token = "0x6003CFC")]
	[Address(RVA = "0x82F790", Offset = "0x82E990", VA = "0x18082F790")]
	private void SetShowRivalName(int type)
	{
	}

	[Token(Token = "0x6003CFD")]
	[Address(RVA = "0x82F000", Offset = "0x82E200", VA = "0x18082F000")]
	private void SetShowCardReport(int type)
	{
	}

	[Token(Token = "0x6003CFE")]
	[Address(RVA = "0x82A820", Offset = "0x829A20", VA = "0x18082A820")]
	private void SetCardSelectionListLayout(int cardListLayoutType)
	{
	}

	[Token(Token = "0x6003CFF")]
	[Address(RVA = "0x82C260", Offset = "0x82B460", VA = "0x18082C260")]
	private void SetGenericCardListLayout(int cardListLayoutType)
	{
	}

	[Token(Token = "0x6003D00")]
	[Address(RVA = "0x82F260", Offset = "0x82E460", VA = "0x18082F260")]
	private void SetShowHappenedEffectType(int type)
	{
	}

	[Token(Token = "0x6003D01")]
	[Address(RVA = "0x82A380", Offset = "0x829580", VA = "0x18082A380")]
	private void SetBgmMode(SettingsUtil.BGM_MODE mode)
	{
	}

	[Token(Token = "0x6003D02")]
	[Address(RVA = "0x828C10", Offset = "0x827E10", VA = "0x180828C10")]
	private void SetAudienceShowCardInfoType(int type)
	{
	}

	[Token(Token = "0x6003D03")]
	[Address(RVA = "0x829650", Offset = "0x828850", VA = "0x180829650")]
	private void SetAudienceShowSetCard(bool active)
	{
	}

	[Token(Token = "0x6003D04")]
	[Address(RVA = "0x828750", Offset = "0x827950", VA = "0x180828750")]
	private void SetAudienceShowAudienceInfo(bool active)
	{
	}

	[Token(Token = "0x6003D05")]
	[Address(RVA = "0x8289B0", Offset = "0x827BB0", VA = "0x1808289B0")]
	private void SetAudienceShowBattleStep(bool active)
	{
	}

	[Token(Token = "0x6003D06")]
	[Address(RVA = "0x829D50", Offset = "0x828F50", VA = "0x180829D50")]
	private void SetAudienceSkipSummonEffectType(SettingsUtil.AudienceParam.SKIP_TYPE type)
	{
	}

	[Token(Token = "0x6003D07")]
	[Address(RVA = "0x829B00", Offset = "0x828D00", VA = "0x180829B00")]
	private void SetAudienceSkipMonsterCutinType(SettingsUtil.AudienceParam.SKIP_TYPE type)
	{
	}

	[Token(Token = "0x6003D08")]
	[Address(RVA = "0x8298B0", Offset = "0x828AB0", VA = "0x1808298B0")]
	private void SetAudienceSkipCardRunEffectType(SettingsUtil.AudienceParam.SKIP_TYPE type)
	{
	}

	[Token(Token = "0x6003D09")]
	[Address(RVA = "0x82A010", Offset = "0x829210", VA = "0x18082A010")]
	private void SetAudienceUseConsoleLayout(bool active)
	{
	}

	[Token(Token = "0x6003D0A")]
	[Address(RVA = "0x828240", Offset = "0x827440", VA = "0x180828240")]
	private void SetAudienceCameraType(SettingsUtil.AudienceParam.CAMERA_TYPE type)
	{
	}

	[Token(Token = "0x6003D0B")]
	[Address(RVA = "0x8293F0", Offset = "0x8285F0", VA = "0x1808293F0")]
	private void SetAudienceShowRivalName(int type)
	{
	}

	[Token(Token = "0x6003D0C")]
	[Address(RVA = "0x828ED0", Offset = "0x8280D0", VA = "0x180828ED0")]
	private void SetAudienceShowCardReport(int type)
	{
	}

	[Token(Token = "0x6003D0D")]
	[Address(RVA = "0x828490", Offset = "0x827690", VA = "0x180828490")]
	private void SetAudienceGenericCardListLayout(int cardListLayoutType)
	{
	}

	[Token(Token = "0x6003D0E")]
	[Address(RVA = "0x827B60", Offset = "0x826D60", VA = "0x180827B60")]
	private void Save()
	{
	}

	[Token(Token = "0x6003D0F")]
	[Address(RVA = "0x827EB0", Offset = "0x8270B0", VA = "0x180827EB0")]
	private static void ScrollToSelectingItem(RectTransform itemRect, RectTransform buttonRect, ScrollRect scroll, LayoutGroup layout, RectTransform parentMenuRect, RectTransform parentContentRect)
	{
	}

	[Token(Token = "0x6003D10")]
	[Address(RVA = "0x829130", Offset = "0x828330", VA = "0x180829130")]
	private void SetAudienceShowHappenedEffectType(int type)
	{
	}

	[Token(Token = "0x6003D11")]
	[Address(RVA = "0x826E40", Offset = "0x826040", VA = "0x180826E40")]
	private bool IsMovieAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003D12")]
	[Address(RVA = "0x827A40", Offset = "0x826C40", VA = "0x180827A40")]
	private void PlayPreviewVoice()
	{
	}

	[Token(Token = "0x6003D13")]
	[Address(RVA = "0x8393D0", Offset = "0x8385D0", VA = "0x1808393D0")]
	private string getWatchPermissionTypeText(SettingsUtil.PrivacyParam.WatchPermissionType permissionType)
	{
		return null;
	}

	[Token(Token = "0x6003D14")]
	[Address(RVA = "0x839310", Offset = "0x838510", VA = "0x180839310")]
	private string getWatchPermissionNoteText(SettingsUtil.PrivacyParam.WatchPermissionType permissionType)
	{
		return null;
	}

	[Token(Token = "0x6003D15")]
	[Address(RVA = "0x838960", Offset = "0x837B60", VA = "0x180838960")]
	private void ShowWatchPermission(SettingsUtil.PrivacyParam.WatchPermissionType permissionType)
	{
	}

	[Token(Token = "0x6003D16")]
	[Address(RVA = "0x838880", Offset = "0x837A80", VA = "0x180838880")]
	private void ShowWatchAnonymous(bool anonymous)
	{
	}

	[Token(Token = "0x6003D17")]
	[Address(RVA = "0x827AB0", Offset = "0x826CB0", VA = "0x180827AB0")]
	private void SavePrivacySettings()
	{
	}

	[Token(Token = "0x6003D18")]
	[Address(RVA = "0x839120", Offset = "0x838320", VA = "0x180839120")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D19")]
	[Address(RVA = "0x838F40", Offset = "0x838140", VA = "0x180838F40")]
	private void UpdateSurrenderCommand()
	{
	}

	[Token(Token = "0x6003D1A")]
	[Address(RVA = "0x839220", Offset = "0x838420", VA = "0x180839220")]
	public SettingMenuViewController()
	{
	}
}
