using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Prize.TurnOverPrize;

[Token(Token = "0x2000BAE")]
public class ActorRoot : ElementWidgetBase
{
	[Token(Token = "0x40097A7")]
	private const string k_ELabelRoot3D = "Root3D";

	[Token(Token = "0x40097A8")]
	private const string k_ELabelRootUI = "RootUI";

	[Token(Token = "0x40097A9")]
	private const string k_ELabel3D_PackGroup = "PackGroup";

	[Token(Token = "0x40097AA")]
	internal const string k_TLabel_Shuffle = "shuffle";

	[Token(Token = "0x40097AB")]
	internal const string k_TLabel_SelectBegin = "select_begin";

	[Token(Token = "0x40097AC")]
	internal const string k_TLabel_SelectEnd = "select_end";

	[Token(Token = "0x40097AD")]
	internal const string k_TLabel_Result = "result";

	[Token(Token = "0x40097AE")]
	[FieldOffset(Offset = "0x20")]
	private readonly PlayableDirector m_Director;

	[Token(Token = "0x40097AF")]
	[FieldOffset(Offset = "0x28")]
	private readonly LabeledPlayableController m_PlayableController;

	[Token(Token = "0x40097B0")]
	[FieldOffset(Offset = "0x30")]
	private readonly PackGroupActor m_PackGroup;

	[Token(Token = "0x17000999")]
	public LabeledPlayableController playableController
	{
		[Token(Token = "0x6004722")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700099A")]
	public PackGroupActor packGroup
	{
		[Token(Token = "0x6004723")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004724")]
	[Address(RVA = "0x8FCE10", Offset = "0x8FC010", VA = "0x1808FCE10")]
	public ActorRoot(GameObject root3D, GameObject rootUI, ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004725")]
	[Address(RVA = "0x8FC780", Offset = "0x8FB980", VA = "0x1808FC780")]
	public void DeactivateAllOverrideTrack()
	{
	}

	[Token(Token = "0x6004726")]
	[Address(RVA = "0x8FCAA0", Offset = "0x8FBCA0", VA = "0x1808FCAA0")]
	public void SetDecidedPackOverrideTrackEnableAt(int idx, bool enable)
	{
	}

	[Token(Token = "0x6004727")]
	[Address(RVA = "0x8FCD90", Offset = "0x8FBF90", VA = "0x1808FCD90")]
	public void SwitchPackGroupOverrideTrack(int packTotal)
	{
	}

	[Token(Token = "0x6004728")]
	[Address(RVA = "0x8FC860", Offset = "0x8FBA60", VA = "0x1808FC860")]
	private bool SetAllOverrideTrackEnabled(string baseTrackName, bool enabled)
	{
		return default(bool);
	}

	[Token(Token = "0x6004729")]
	[Address(RVA = "0x8FCB20", Offset = "0x8FBD20", VA = "0x1808FCB20")]
	private bool SwitchOverrideTrackEnabled(string baseTrackName, string activateOverrideTrackName)
	{
		return default(bool);
	}

	[Token(Token = "0x600472A")]
	[Address(RVA = "0x8E08D0", Offset = "0x8DFAD0", VA = "0x1808E08D0")]
	public void TMRebuildGraph()
	{
	}
}
