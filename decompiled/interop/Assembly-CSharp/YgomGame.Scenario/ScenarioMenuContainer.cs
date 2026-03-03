using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.HeaderFooter;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A74")]
public class ScenarioMenuContainer : ElementWidgetBehaviourBase<ScenarioMenuContainer>
{
	[Token(Token = "0x2000A75")]
	public enum ButtonType
	{
		[Token(Token = "0x4009224")]
		Skip,
		[Token(Token = "0x4009225")]
		Subtitle,
		[Token(Token = "0x4009226")]
		MovieSubtitle,
		[Token(Token = "0x4009227")]
		Auto,
		[Token(Token = "0x4009228")]
		Log,
		[Token(Token = "0x4009229")]
		View
	}

	[Token(Token = "0x2000A76")]
	public enum ButtonSet
	{
		[Token(Token = "0x400922B")]
		Default,
		[Token(Token = "0x400922C")]
		Movie,
		[Token(Token = "0x400922D")]
		MovieWithSubtitle,
		[Token(Token = "0x400922E")]
		Voice
	}

	[Token(Token = "0x40091FF")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelMenuAccordion;

	[Token(Token = "0x4009200")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelMenuAccordion_RootButton;

	[Token(Token = "0x4009201")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelMenuAccordion_ChildGroup;

	[Token(Token = "0x4009202")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelMenuAccordion_ChildSlotTemplate_Default;

	[Token(Token = "0x4009203")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelMenuAccordion_ChildSlotTemplate_Toggle;

	[Token(Token = "0x4009204")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelMenuAccordion_ChildSlot_Button;

	[Token(Token = "0x4009205")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelMenuAccordion_ChildSlot_Text;

	[Token(Token = "0x4009206")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelMenuAccordion_ChildSlot_ImageIcon;

	[Token(Token = "0x4009207")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelVolumeButton;

	[Token(Token = "0x4009208")]
	[FieldOffset(Offset = "0x70")]
	private readonly string k_ELabelVolumeMuteIcon;

	[Token(Token = "0x4009209")]
	[FieldOffset(Offset = "0x78")]
	private readonly string k_ELabelVolumeUnmuteIcon;

	[Token(Token = "0x400920A")]
	[FieldOffset(Offset = "0x80")]
	private readonly string k_ELabelExpandedIcon;

	[Token(Token = "0x400920B")]
	[FieldOffset(Offset = "0x88")]
	private readonly string k_ELabelShlinkedIcon;

	[Token(Token = "0x400920C")]
	[FieldOffset(Offset = "0x90")]
	private readonly string k_ELabelAutoIcon;

	[Token(Token = "0x400920D")]
	[FieldOffset(Offset = "0x98")]
	private readonly string k_ELabelFooter;

	[Token(Token = "0x400920E")]
	[FieldOffset(Offset = "0xA0")]
	private readonly string k_TweenShow;

	[Token(Token = "0x400920F")]
	[FieldOffset(Offset = "0xA8")]
	private readonly string k_TweenHide;

	[Token(Token = "0x4009210")]
	[FieldOffset(Offset = "0xB0")]
	private readonly string k_TweenExpand;

	[Token(Token = "0x4009211")]
	[FieldOffset(Offset = "0xB8")]
	private readonly string k_TweenShrink;

	[Token(Token = "0x4009212")]
	[FieldOffset(Offset = "0xC0")]
	private readonly string k_TweenOnStartActivate;

	[Token(Token = "0x4009213")]
	[FieldOffset(Offset = "0xC8")]
	private readonly string k_TweenOnEndActivate;

	[Token(Token = "0x4009214")]
	[FieldOffset(Offset = "0xD0")]
	private ElementObjectManager m_AccordionEom;

	[Token(Token = "0x4009215")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject m_ChildGroup;

	[Token(Token = "0x4009216")]
	[FieldOffset(Offset = "0xE0")]
	private Selector m_Selector;

	[Token(Token = "0x4009217")]
	[FieldOffset(Offset = "0xE8")]
	private LayoutGroup m_ChildGroupLayoutGroup;

	[Token(Token = "0x4009218")]
	[FieldOffset(Offset = "0xF0")]
	private SelectionButton m_RootButton;

	[Token(Token = "0x4009219")]
	[FieldOffset(Offset = "0xF8")]
	private SelectionButton m_VolumeButton;

	[Token(Token = "0x400921A")]
	[FieldOffset(Offset = "0x100")]
	private OutGameFooter m_Footer;

	[Token(Token = "0x400921B")]
	[FieldOffset(Offset = "0x108")]
	private Dictionary<ButtonType, ElementObjectManager> m_ButtonSlotMap;

	[Token(Token = "0x400921C")]
	[FieldOffset(Offset = "0x110")]
	private ScenarioWork m_Work;

	[Token(Token = "0x400921D")]
	[FieldOffset(Offset = "0x118")]
	private bool m_IsVisible;

	[Token(Token = "0x400921E")]
	[FieldOffset(Offset = "0x119")]
	private bool m_IsExpanded;

	[Token(Token = "0x400921F")]
	[FieldOffset(Offset = "0x11A")]
	private bool m_IsPlayingExpandOrShrink;

	[Token(Token = "0x17000891")]
	public Selector selector
	{
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000892")]
	public SelectionButton autoButton
	{
		[Token(Token = "0x600403F")]
		[Address(RVA = "0x8894A0", Offset = "0x8886A0", VA = "0x1808894A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000893")]
	public SelectionButton subtitleButton
	{
		[Token(Token = "0x6004040")]
		[Address(RVA = "0x8895A0", Offset = "0x8887A0", VA = "0x1808895A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000894")]
	public SelectionButton movieSubtitleButton
	{
		[Token(Token = "0x6004041")]
		[Address(RVA = "0x889540", Offset = "0x888740", VA = "0x180889540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000895")]
	public SelectionButton logButton
	{
		[Token(Token = "0x6004042")]
		[Address(RVA = "0x889530", Offset = "0x888730", VA = "0x180889530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000896")]
	public SelectionButton skipButton
	{
		[Token(Token = "0x6004043")]
		[Address(RVA = "0x889590", Offset = "0x888790", VA = "0x180889590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000897")]
	public SelectionButton viewButton
	{
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x8895B0", Offset = "0x8887B0", VA = "0x1808895B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000898")]
	public bool visible
	{
		[Token(Token = "0x6004045")]
		[Address(RVA = "0x8895C0", Offset = "0x8887C0", VA = "0x1808895C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004046")]
		[Address(RVA = "0x889960", Offset = "0x888B60", VA = "0x180889960")]
		set
		{
		}
	}

	[Token(Token = "0x17000899")]
	public bool expandIconVisible
	{
		[Token(Token = "0x6004047")]
		[Address(RVA = "0x8894F0", Offset = "0x8886F0", VA = "0x1808894F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004048")]
		[Address(RVA = "0x8898C0", Offset = "0x888AC0", VA = "0x1808898C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700089A")]
	public bool shrinkIconVisible
	{
		[Token(Token = "0x6004049")]
		[Address(RVA = "0x889550", Offset = "0x888750", VA = "0x180889550")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600404A")]
		[Address(RVA = "0x889910", Offset = "0x888B10", VA = "0x180889910")]
		set
		{
		}
	}

	[Token(Token = "0x1700089B")]
	public bool autoIconVisible
	{
		[Token(Token = "0x600404B")]
		[Address(RVA = "0x8894B0", Offset = "0x8886B0", VA = "0x1808894B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600404C")]
		[Address(RVA = "0x889870", Offset = "0x888A70", VA = "0x180889870")]
		set
		{
		}
	}

	[Token(Token = "0x1700089C")]
	public bool volumeMuteVisible
	{
		[Token(Token = "0x600404D")]
		[Address(RVA = "0x8895D0", Offset = "0x8887D0", VA = "0x1808895D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x889980", Offset = "0x888B80", VA = "0x180889980")]
		set
		{
		}
	}

	[Token(Token = "0x14000050")]
	public event Action<ButtonType> onClickButtonEvent
	{
		[Token(Token = "0x600404F")]
		[Address(RVA = "0x889320", Offset = "0x888520", VA = "0x180889320")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004050")]
		[Address(RVA = "0x8896F0", Offset = "0x8888F0", VA = "0x1808896F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000051")]
	public event Action<ScenarioSettingsWrapper.SoundSettingType[]> onClickVolumeButtonEvent
	{
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x8893E0", Offset = "0x8885E0", VA = "0x1808893E0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004052")]
		[Address(RVA = "0x8897B0", Offset = "0x8889B0", VA = "0x1808897B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000052")]
	public event Action onClickAnyButtonEvent
	{
		[Token(Token = "0x6004053")]
		[Address(RVA = "0x889270", Offset = "0x888470", VA = "0x180889270")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004054")]
		[Address(RVA = "0x889640", Offset = "0x888840", VA = "0x180889640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6004055")]
	[Address(RVA = "0x8869F0", Offset = "0x885BF0", VA = "0x1808869F0")]
	public static ScenarioMenuContainer Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6004056")]
	[Address(RVA = "0x886710", Offset = "0x885910", VA = "0x180886710", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6004057")]
	[Address(RVA = "0x886D60", Offset = "0x885F60", VA = "0x180886D60")]
	public void Initialize(ScenarioWork work, ButtonSet buttonSet)
	{
	}

	[Token(Token = "0x6004058")]
	[Address(RVA = "0x888080", Offset = "0x887280", VA = "0x180888080")]
	private void SetupButtonSet(ButtonSet buttonSet)
	{
	}

	[Token(Token = "0x6004059")]
	[Address(RVA = "0x888280", Offset = "0x887480", VA = "0x180888280")]
	private void SetupVolumeButton(params ScenarioSettingsWrapper.SoundSettingType[] soundSettingTypes)
	{
	}

	[Token(Token = "0x600405A")]
	[Address(RVA = "0x8878D0", Offset = "0x886AD0", VA = "0x1808878D0")]
	private void SetupAccordionButtons(params ButtonType[] buttonTypes)
	{
	}

	[Token(Token = "0x600405B")]
	[Address(RVA = "0x886F00", Offset = "0x886100", VA = "0x180886F00")]
	private bool IsToggleButton(ButtonType buttonType)
	{
		return default(bool);
	}

	[Token(Token = "0x600405C")]
	[Address(RVA = "0x886CF0", Offset = "0x885EF0", VA = "0x180886CF0")]
	private bool GetToggleValue(ButtonType buttonType)
	{
		return default(bool);
	}

	[Token(Token = "0x600405D")]
	[Address(RVA = "0x886C70", Offset = "0x885E70", VA = "0x180886C70")]
	private ElementObjectManager GetSlotTemplate(ButtonType buttonType)
	{
		return null;
	}

	[Token(Token = "0x600405E")]
	[Address(RVA = "0x8884A0", Offset = "0x8876A0", VA = "0x1808884A0")]
	private bool SkipButtonDecideSE(ButtonType buttonType)
	{
		return default(bool);
	}

	[Token(Token = "0x600405F")]
	[Address(RVA = "0x886B10", Offset = "0x885D10", VA = "0x180886B10")]
	private string GetButtonLabel(ButtonType buttonType)
	{
		return null;
	}

	[Token(Token = "0x6004060")]
	[Address(RVA = "0x886A30", Offset = "0x885C30", VA = "0x180886A30")]
	private string GetButtonIconSpriteLabel(ButtonType buttonType)
	{
		return null;
	}

	[Token(Token = "0x6004061")]
	[Address(RVA = "0x888D80", Offset = "0x887F80", VA = "0x180888D80")]
	private SelectionButton TryGetChildButton(ButtonType buttonType)
	{
		return null;
	}

	[Token(Token = "0x6004062")]
	[Address(RVA = "0x8884B0", Offset = "0x8876B0", VA = "0x1808884B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6004063")]
	[Address(RVA = "0x886F10", Offset = "0x886110", VA = "0x180886F10")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6004064")]
	[Address(RVA = "0x888640", Offset = "0x887840", VA = "0x180888640")]
	private void ToExpand(bool immediate = false)
	{
	}

	[Token(Token = "0x6004065")]
	[Address(RVA = "0x8889B0", Offset = "0x887BB0", VA = "0x1808889B0")]
	private void ToShrink(bool immediate = false)
	{
	}

	[Token(Token = "0x6004066")]
	[Address(RVA = "0x887330", Offset = "0x886530", VA = "0x180887330")]
	public void PlayHide(bool immediate = false)
	{
	}

	[Token(Token = "0x6004067")]
	[Address(RVA = "0x887450", Offset = "0x886650", VA = "0x180887450")]
	public void PlayShow(bool immediate = false)
	{
	}

	[Token(Token = "0x6004068")]
	[Address(RVA = "0x887680", Offset = "0x886880", VA = "0x180887680")]
	private void ResetButtonsTween()
	{
	}

	[Token(Token = "0x6004069")]
	[Address(RVA = "0x887570", Offset = "0x886770", VA = "0x180887570")]
	private void PlayToggleTween(GameObject target, string activateLabel, string deactivateLabel, bool isActivate, bool immediate = false)
	{
	}

	[Token(Token = "0x600406A")]
	[Address(RVA = "0x888E20", Offset = "0x888020", VA = "0x180888E20")]
	public bool TryShrink(bool immediate = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600406B")]
	[Address(RVA = "0x8872E0", Offset = "0x8864E0", VA = "0x1808872E0")]
	private void OnClickRootButton()
	{
	}

	[Token(Token = "0x600406C")]
	[Address(RVA = "0x886FE0", Offset = "0x8861E0", VA = "0x180886FE0")]
	private void OnChangeAutoEvent(bool value)
	{
	}

	[Token(Token = "0x600406D")]
	[Address(RVA = "0x887040", Offset = "0x886240", VA = "0x180887040")]
	private void OnChangeHideSubtitleEvent(bool value)
	{
	}

	[Token(Token = "0x600406E")]
	[Address(RVA = "0x887070", Offset = "0x886270", VA = "0x180887070")]
	private void OnChangeInVolumeEditEvent(bool value)
	{
	}

	[Token(Token = "0x600406F")]
	[Address(RVA = "0x887120", Offset = "0x886320", VA = "0x180887120")]
	private void OnChangeToggleButton(ButtonType buttonType)
	{
	}

	[Token(Token = "0x6004070")]
	[Address(RVA = "0x886FB0", Offset = "0x8861B0", VA = "0x180886FB0")]
	public bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6004071")]
	[Address(RVA = "0x888E60", Offset = "0x888060", VA = "0x180888E60")]
	public ScenarioMenuContainer()
	{
	}
}
