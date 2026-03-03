using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Prize.TurnOverPrizeItem;

[Token(Token = "0x2000B96")]
public class ActorRoot : ElementWidgetBase
{
	[Token(Token = "0x400973E")]
	private const string k_ELabelRoot3D = "Root3D";

	[Token(Token = "0x400973F")]
	private const string k_ELabelRootUI = "RootUI";

	[Token(Token = "0x4009740")]
	private const string k_ELabel3D_PackGroup = "PackGroup";

	[Token(Token = "0x4009741")]
	internal const string k_TLabel_Shuffle = "shuffle";

	[Token(Token = "0x4009742")]
	internal const string k_TLabel_SelectBegin = "select_begin";

	[Token(Token = "0x4009743")]
	internal const string k_TLabel_SelectEnd = "select_end";

	[Token(Token = "0x4009744")]
	internal const string k_TLabel_Result = "result";

	[Token(Token = "0x4009745")]
	[FieldOffset(Offset = "0x20")]
	private readonly PlayableDirector m_Director;

	[Token(Token = "0x4009746")]
	[FieldOffset(Offset = "0x28")]
	private readonly LabeledPlayableController m_PlayableController;

	[Token(Token = "0x4009747")]
	[FieldOffset(Offset = "0x30")]
	private readonly BoxGroupActor m_PackGroup;

	[Token(Token = "0x1700097E")]
	public LabeledPlayableController playableController
	{
		[Token(Token = "0x6004696")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700097F")]
	public BoxGroupActor packGroup
	{
		[Token(Token = "0x6004697")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004698")]
	[Address(RVA = "0x8E08F0", Offset = "0x8DFAF0", VA = "0x1808E08F0")]
	public ActorRoot(GameObject root3D, GameObject rootUI, ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004699")]
	[Address(RVA = "0x8E0240", Offset = "0x8DF440", VA = "0x1808E0240")]
	public void DeactivateAllOverrideTrack()
	{
	}

	[Token(Token = "0x600469A")]
	[Address(RVA = "0x8E0560", Offset = "0x8DF760", VA = "0x1808E0560")]
	public void SetDecidedPackOverrideTrackEnableAt(int idx, bool enable)
	{
	}

	[Token(Token = "0x600469B")]
	[Address(RVA = "0x8E0850", Offset = "0x8DFA50", VA = "0x1808E0850")]
	public void SwitchPackGroupOverrideTrack(int packTotal)
	{
	}

	[Token(Token = "0x600469C")]
	[Address(RVA = "0x8E0320", Offset = "0x8DF520", VA = "0x1808E0320")]
	private bool SetAllOverrideTrackEnabled(string baseTrackName, bool enabled)
	{
		return default(bool);
	}

	[Token(Token = "0x600469D")]
	[Address(RVA = "0x8E05E0", Offset = "0x8DF7E0", VA = "0x1808E05E0")]
	private bool SwitchOverrideTrackEnabled(string baseTrackName, string activateOverrideTrackName)
	{
		return default(bool);
	}

	[Token(Token = "0x600469E")]
	[Address(RVA = "0x8E08D0", Offset = "0x8DFAD0", VA = "0x1808E08D0")]
	public void TMRebuildGraph()
	{
	}
}
