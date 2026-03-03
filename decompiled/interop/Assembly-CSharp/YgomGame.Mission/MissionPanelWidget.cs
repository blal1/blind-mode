using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission;

[Token(Token = "0x2000C14")]
public class MissionPanelWidget : ElementWidgetBase
{
	[Token(Token = "0x40099F4")]
	private const string k_ELabelFocusEffect = "FocusEffect";

	[Token(Token = "0x40099F5")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelTitleText;

	[Token(Token = "0x40099F6")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelInfoGroup;

	[Token(Token = "0x40099F7")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelLimitDateGroup;

	[Token(Token = "0x40099F8")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelLimitDateText;

	[Token(Token = "0x40099F9")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelHintGroup;

	[Token(Token = "0x40099FA")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelHintButton;

	[Token(Token = "0x40099FB")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelHintShortcutIconGroup;

	[Token(Token = "0x40099FC")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelGoalsPager;

	[Token(Token = "0x40099FD")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelLockedFilter;

	[Token(Token = "0x40099FE")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelLockedIcon;

	[Token(Token = "0x40099FF")]
	[FieldOffset(Offset = "0x70")]
	private readonly string k_ELabelBadge;

	[Token(Token = "0x4009A00")]
	[FieldOffset(Offset = "0x78")]
	private readonly string k_ELabelSecretIcon;

	[Token(Token = "0x4009A01")]
	private const string k_TLabelIn = "in";

	[Token(Token = "0x4009A02")]
	private const string k_TLabelOut = "out";

	[Token(Token = "0x4009A03")]
	[FieldOffset(Offset = "0x80")]
	public int missionId;

	[Token(Token = "0x4009A04")]
	[FieldOffset(Offset = "0x88")]
	public readonly LabeledPlayableController m_LabeledPlayableControlelr;

	[Token(Token = "0x4009A05")]
	[FieldOffset(Offset = "0x90")]
	public readonly PlayableDirector playableDirector;

	[Token(Token = "0x4009A06")]
	[FieldOffset(Offset = "0x98")]
	public readonly MissionGoalsPagerWidget goalsPager;

	[Token(Token = "0x4009A07")]
	[FieldOffset(Offset = "0xA0")]
	public readonly SelectionItem selectionItem;

	[Token(Token = "0x4009A08")]
	[FieldOffset(Offset = "0xA8")]
	public readonly GameObject titleBase;

	[Token(Token = "0x4009A09")]
	[FieldOffset(Offset = "0xB0")]
	public readonly TMP_Text titleText;

	[Token(Token = "0x4009A0A")]
	[FieldOffset(Offset = "0xB8")]
	public readonly GameObject InfoGroup;

	[Token(Token = "0x4009A0B")]
	[FieldOffset(Offset = "0xC0")]
	public readonly GameObject limitDateGroup;

	[Token(Token = "0x4009A0C")]
	[FieldOffset(Offset = "0xC8")]
	public readonly TMP_Text limitDateText;

	[Token(Token = "0x4009A0D")]
	[FieldOffset(Offset = "0xD0")]
	public readonly SelectionButton hintButton;

	[Token(Token = "0x4009A0E")]
	[FieldOffset(Offset = "0xD8")]
	public readonly GameObject lockedFilter;

	[Token(Token = "0x4009A0F")]
	[FieldOffset(Offset = "0xE0")]
	public readonly GameObject lockedIcon;

	[Token(Token = "0x4009A10")]
	[FieldOffset(Offset = "0xE8")]
	public readonly GameObject badge;

	[Token(Token = "0x4009A11")]
	[FieldOffset(Offset = "0xF0")]
	public readonly GameObject secretIcon;

	[Token(Token = "0x4009A12")]
	[FieldOffset(Offset = "0xF8")]
	public PlayableAsset tmCompleteMission;

	[Token(Token = "0x4009A13")]
	[FieldOffset(Offset = "0x100")]
	public PlayableAsset tmHideMission;

	[Token(Token = "0x4009A14")]
	[FieldOffset(Offset = "0x108")]
	public PlayableAsset tmNewMission;

	[Token(Token = "0x4009A15")]
	[FieldOffset(Offset = "0x110")]
	public PlayableAsset tmFocusMission;

	[Token(Token = "0x170009F2")]
	private GameObject focusEffect
	{
		[Token(Token = "0x6004999")]
		[Address(RVA = "0x9410C0", Offset = "0x9402C0", VA = "0x1809410C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F3")]
	public GameObject hintGroup
	{
		[Token(Token = "0x600499A")]
		[Address(RVA = "0x941110", Offset = "0x940310", VA = "0x180941110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F4")]
	public ShortcutIcon hintShortcutIconGroup
	{
		[Token(Token = "0x600499B")]
		[Address(RVA = "0x941140", Offset = "0x940340", VA = "0x180941140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600499C")]
	[Address(RVA = "0x940C30", Offset = "0x93FE30", VA = "0x180940C30")]
	public MissionPanelWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600499D")]
	[Address(RVA = "0x940BA0", Offset = "0x93FDA0", VA = "0x180940BA0")]
	public bool ValidSetSpeed()
	{
		return default(bool);
	}

	[Token(Token = "0x600499E")]
	[Address(RVA = "0x940B90", Offset = "0x93FD90", VA = "0x180940B90")]
	public void SetPlayableSpeed(double speed)
	{
	}

	[Token(Token = "0x600499F")]
	[Address(RVA = "0x9405A0", Offset = "0x93F7A0", VA = "0x1809405A0")]
	public void PlayFocusEffect()
	{
	}

	[Token(Token = "0x60049A0")]
	[Address(RVA = "0x940350", Offset = "0x93F550", VA = "0x180940350")]
	public bool IsPlayingFocusEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60049A1")]
	[Address(RVA = "0x940A50", Offset = "0x93FC50", VA = "0x180940A50")]
	public void SetFocusEffect()
	{
	}

	[Token(Token = "0x60049A2")]
	[Address(RVA = "0x93FE70", Offset = "0x93F070", VA = "0x18093FE70")]
	public void ClearFocusEffect()
	{
	}

	[Token(Token = "0x60049A3")]
	[Address(RVA = "0x940460", Offset = "0x93F660", VA = "0x180940460")]
	public void PlayCompleteEffectIn(bool isSkip)
	{
	}

	[Token(Token = "0x60049A4")]
	[Address(RVA = "0x940260", Offset = "0x93F460", VA = "0x180940260")]
	public bool IsPlayingCompleteEffectIn()
	{
		return default(bool);
	}

	[Token(Token = "0x60049A5")]
	[Address(RVA = "0x9404C0", Offset = "0x93F6C0", VA = "0x1809404C0")]
	public void PlayCompleteEffectOut(bool isSkip)
	{
	}

	[Token(Token = "0x60049A6")]
	[Address(RVA = "0x9409B0", Offset = "0x93FBB0", VA = "0x1809409B0")]
	public void SetCompleteEffect()
	{
	}

	[Token(Token = "0x60049A7")]
	[Address(RVA = "0x93FE20", Offset = "0x93F020", VA = "0x18093FE20")]
	public void ClearCompleteEffect()
	{
	}

	[Token(Token = "0x60049A8")]
	[Address(RVA = "0x9402B0", Offset = "0x93F4B0", VA = "0x1809402B0")]
	public bool IsPlayingCompleteEffectOut()
	{
		return default(bool);
	}

	[Token(Token = "0x60049A9")]
	[Address(RVA = "0x940140", Offset = "0x93F340", VA = "0x180940140")]
	public void ForceEndCompleteEffectOut()
	{
	}

	[Token(Token = "0x60049AA")]
	[Address(RVA = "0x940520", Offset = "0x93F720", VA = "0x180940520")]
	public void PlayEntryEffect()
	{
	}

	[Token(Token = "0x60049AB")]
	[Address(RVA = "0x940300", Offset = "0x93F500", VA = "0x180940300")]
	public bool IsPlayingEntryEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60049AC")]
	[Address(RVA = "0x9401D0", Offset = "0x93F3D0", VA = "0x1809401D0")]
	public void ForceEndEntryEffect()
	{
	}

	[Token(Token = "0x60049AD")]
	[Address(RVA = "0x940A00", Offset = "0x93FC00", VA = "0x180940A00")]
	public void SetEntryEffect()
	{
	}

	[Token(Token = "0x60049AE")]
	[Address(RVA = "0x940960", Offset = "0x93FB60", VA = "0x180940960")]
	private void PlayTM(PlayableAsset playableAsset, string label = "in")
	{
	}

	[Token(Token = "0x60049AF")]
	[Address(RVA = "0x940680", Offset = "0x93F880", VA = "0x180940680")]
	private void PlayTMWithSkipSwitch(PlayableAsset playableAsset, string label, bool skipOn)
	{
	}

	[Token(Token = "0x60049B0")]
	[Address(RVA = "0x9403A0", Offset = "0x93F5A0", VA = "0x1809403A0")]
	private bool IsPlayingTM(PlayableAsset playableAsset, string label = "in")
	{
		return default(bool);
	}

	[Token(Token = "0x60049B1")]
	[Address(RVA = "0x93FF00", Offset = "0x93F100", VA = "0x18093FF00")]
	private void EvaluateHeadTM(PlayableAsset playableAsset, string label = "in")
	{
	}

	[Token(Token = "0x60049B2")]
	[Address(RVA = "0x93FFD0", Offset = "0x93F1D0", VA = "0x18093FFD0")]
	private void EvaluateTailTM(PlayableAsset playableAsset, string label = "in")
	{
	}
}
