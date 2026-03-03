using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using YgomSystem.Timeline;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AC4")]
public class ScenarioBehaviour_Text : ScenarioBehaviour, IScenarioLogTextBehavior, IScenarioLogBehavior, IScenarioPreGenerateTextBehaviour
{
	[Token(Token = "0x2000AC5")]
	public enum PlayType
	{
		[Token(Token = "0x400939D")]
		LineByLine,
		[Token(Token = "0x400939E")]
		AllAtOnce
	}

	[Token(Token = "0x400938F")]
	internal const string k_ArgKey_TrysyncTMLabel = "text_trysync_tmlabel";

	[Token(Token = "0x4009390")]
	[FieldOffset(Offset = "0x50")]
	public float waitLineSec;

	[Token(Token = "0x4009391")]
	[FieldOffset(Offset = "0x54")]
	private int m_SubStepInit;

	[Token(Token = "0x4009392")]
	[FieldOffset(Offset = "0x58")]
	private int m_SubStepAction;

	[Token(Token = "0x4009393")]
	[FieldOffset(Offset = "0x5C")]
	private PlayType m_PlayType;

	[Token(Token = "0x4009394")]
	[FieldOffset(Offset = "0x60")]
	private List<TMP_Text> m_LineTextMeshs;

	[Token(Token = "0x4009395")]
	[FieldOffset(Offset = "0x68")]
	private int m_PlayPos;

	[Token(Token = "0x4009396")]
	[FieldOffset(Offset = "0x6C")]
	private float m_RemineWaitLineSec;

	[Token(Token = "0x4009397")]
	[FieldOffset(Offset = "0x70")]
	private string m_Text;

	[Token(Token = "0x4009398")]
	[FieldOffset(Offset = "0x78")]
	private LabeledPlayableController m_BGLabeledPlayer;

	[Token(Token = "0x4009399")]
	[FieldOffset(Offset = "0x80")]
	private List<string> m_TextRangeTMLabels;

	[Token(Token = "0x400939A")]
	[FieldOffset(Offset = "0x88")]
	private bool m_ReachedTailLabelWrap;

	[Token(Token = "0x400939B")]
	[FieldOffset(Offset = "0x8C")]
	public ScenarioTextContainer.GroupType groupType;

	[Token(Token = "0x170008C4")]
	private string tailTextTMLabel
	{
		[Token(Token = "0x600420C")]
		[Address(RVA = "0x89BFF0", Offset = "0x89B1F0", VA = "0x18089BFF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C5")]
	private bool existsTMControll
	{
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x89BF50", Offset = "0x89B150", VA = "0x18089BF50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008C6")]
	public override float arrowMerginSec
	{
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x89BDE0", Offset = "0x89AFE0", VA = "0x18089BDE0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008C7")]
	protected override float autoWaitSec
	{
		[Token(Token = "0x600420F")]
		[Address(RVA = "0x89BE40", Offset = "0x89B040", VA = "0x18089BE40", Slot = "22")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6004210")]
	[Address(RVA = "0x89BD50", Offset = "0x89AF50", VA = "0x18089BD50")]
	public ScenarioBehaviour_Text(object commandData)
	{
	}

	[Token(Token = "0x6004211")]
	[Address(RVA = "0x89A4A0", Offset = "0x8996A0", VA = "0x18089A4A0", Slot = "24")]
	public string GetPreGenerateText()
	{
		return null;
	}

	[Token(Token = "0x6004212")]
	[Address(RVA = "0x89A6D0", Offset = "0x8998D0", VA = "0x18089A6D0")]
	private bool IsTextTMLabel(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6004213")]
	[Address(RVA = "0x89B850", Offset = "0x89AA50", VA = "0x18089B850")]
	private bool SetupTMLabels()
	{
		return default(bool);
	}

	[Token(Token = "0x6004214")]
	[Address(RVA = "0x89A660", Offset = "0x899860", VA = "0x18089A660")]
	private bool IsProgressHeadTMClip()
	{
		return default(bool);
	}

	[Token(Token = "0x6004215")]
	[Address(RVA = "0x89A5E0", Offset = "0x8997E0", VA = "0x18089A5E0")]
	private bool IsCompleteTailTMClip()
	{
		return default(bool);
	}

	[Token(Token = "0x6004216")]
	[Address(RVA = "0x89A880", Offset = "0x899A80", VA = "0x18089A880")]
	private void OnReachedLabelWrapEdge(string leachedLabel, LabeledPlayableController labeledPlayableController)
	{
	}

	[Token(Token = "0x6004217")]
	[Address(RVA = "0x89AFD0", Offset = "0x89A1D0", VA = "0x18089AFD0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004218")]
	[Address(RVA = "0x89A480", Offset = "0x899680", VA = "0x18089A480", Slot = "9")]
	protected override bool AllowProgressNextChild(ScenarioBehaviour child)
	{
		return default(bool);
	}

	[Token(Token = "0x6004219")]
	[Address(RVA = "0x89A990", Offset = "0x899B90", VA = "0x18089A990", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x600421A")]
	[Address(RVA = "0x89AC00", Offset = "0x899E00", VA = "0x18089AC00", Slot = "16")]
	protected override void ProgressFinish()
	{
	}

	[Token(Token = "0x600421B")]
	[Address(RVA = "0x89B620", Offset = "0x89A820", VA = "0x18089B620", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600421C")]
	[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820", Slot = "23")]
	public string GetLogText()
	{
		return null;
	}
}
