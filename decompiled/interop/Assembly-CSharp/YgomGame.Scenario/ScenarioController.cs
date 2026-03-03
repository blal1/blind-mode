using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AC8")]
public class ScenarioController
{
	[Token(Token = "0x40093A2")]
	[FieldOffset(Offset = "0x10")]
	private readonly ScenarioWork m_Work;

	[Token(Token = "0x40093A3")]
	[FieldOffset(Offset = "0x18")]
	private readonly StringBuilder m_PreGenerateTextBuilder;

	[Token(Token = "0x40093A4")]
	[FieldOffset(Offset = "0x20")]
	private ScenarioBehaviour m_HeadBehaviour;

	[Token(Token = "0x40093A5")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<ScenarioBehaviour> m_AllBehaviours;

	[Token(Token = "0x40093A6")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<IScenarioLogBehavior> m_LogBehaviors;

	[Token(Token = "0x40093A7")]
	[FieldOffset(Offset = "0x38")]
	private readonly Queue<ScenarioBehaviour> m_PlayQueueBehaviours;

	[Token(Token = "0x40093A8")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<ScenarioBehaviour> m_PlayBehaviours;

	[Token(Token = "0x40093A9")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<ScenarioBehaviour> m_RemoveBehavioursReserver;

	[Token(Token = "0x40093AA")]
	[FieldOffset(Offset = "0x50")]
	private IScenarioFadeInTransitionBehaviour m_HeadFadeInTransitionBehaviour;

	[Token(Token = "0x170008CC")]
	public ScenarioWork work
	{
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008CD")]
	public bool isFadeInTransitionCompleted
	{
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x8A0C90", Offset = "0x89FE90", VA = "0x1808A0C90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008CE")]
	public bool isFailed
	{
		[Token(Token = "0x600422E")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600422F")]
		[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170008CF")]
	public bool isFinish
	{
		[Token(Token = "0x6004230")]
		[Address(RVA = "0x8A0CE0", Offset = "0x89FEE0", VA = "0x1808A0CE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008D0")]
	public bool isComplete
	{
		[Token(Token = "0x6004231")]
		[Address(RVA = "0x8A0C20", Offset = "0x89FE20", VA = "0x1808A0C20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008D1")]
	public List<ScenarioBehaviour> allBehaviours
	{
		[Token(Token = "0x6004232")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D2")]
	public List<IScenarioLogBehavior> logBehaviors
	{
		[Token(Token = "0x6004233")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D3")]
	public StringBuilder preGenerateTextBuilder
	{
		[Token(Token = "0x6004234")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004235")]
	[Address(RVA = "0x8A0A60", Offset = "0x89FC60", VA = "0x1808A0A60")]
	public ScenarioController(ScenarioWork work)
	{
	}

	[Token(Token = "0x6004236")]
	[Address(RVA = "0x8A09E0", Offset = "0x89FBE0", VA = "0x1808A09E0")]
	public void Update()
	{
	}

	[Token(Token = "0x6004237")]
	[Address(RVA = "0x89EE70", Offset = "0x89E070", VA = "0x18089EE70")]
	private bool ProgressPlayBehaviours()
	{
		return default(bool);
	}

	[Token(Token = "0x6004238")]
	[Address(RVA = "0x89EAE0", Offset = "0x89DCE0", VA = "0x18089EAE0")]
	private void ProgressFetchBehaviours()
	{
	}

	[Token(Token = "0x6004239")]
	[Address(RVA = "0x89ED40", Offset = "0x89DF40", VA = "0x18089ED40")]
	private void ProgressFirstBehaviour(ScenarioBehaviour behaviour, int destIdx = -1)
	{
	}

	[Token(Token = "0x600423A")]
	[Address(RVA = "0x89F170", Offset = "0x89E370", VA = "0x18089F170")]
	public int ReadScenarioData(string scenarioName, List<object> commandList, bool loadCommand = false)
	{
		return default(int);
	}

	[Token(Token = "0x600423B")]
	[Address(RVA = "0x89E260", Offset = "0x89D460", VA = "0x18089E260")]
	private void AddBehavior(ScenarioBehaviour b)
	{
	}

	[Token(Token = "0x600423C")]
	[Address(RVA = "0x89E6E0", Offset = "0x89D8E0", VA = "0x18089E6E0")]
	private void PreSetupBehaviour(ScenarioBehaviour b)
	{
	}

	[Token(Token = "0x600423D")]
	[Address(RVA = "0x89FF40", Offset = "0x89F140", VA = "0x18089FF40")]
	private void SetupBehaviour(ScenarioBehaviour behaviour)
	{
	}

	[Token(Token = "0x600423E")]
	[Address(RVA = "0x89E990", Offset = "0x89DB90", VA = "0x18089E990")]
	private void PreloadSectionRange(IScenarioPreloadSectionBehaviour beginSection)
	{
	}

	[Token(Token = "0x600423F")]
	[Address(RVA = "0x8A07C0", Offset = "0x89F9C0", VA = "0x1808A07C0")]
	private bool TryPreloadInSection(IScenarioPreloadSectionBehaviour beginSection, ScenarioBehaviour behaviour)
	{
		return default(bool);
	}

	[Token(Token = "0x6004240")]
	[Address(RVA = "0x89E3E0", Offset = "0x89D5E0", VA = "0x18089E3E0")]
	public static bool IsChildAsyncCommand(string command)
	{
		return default(bool);
	}

	[Token(Token = "0x6004241")]
	[Address(RVA = "0x89E450", Offset = "0x89D650", VA = "0x18089E450")]
	public static bool IsSupportedAsyncCommand(string command)
	{
		return default(bool);
	}

	[Token(Token = "0x6004242")]
	[Address(RVA = "0x89E310", Offset = "0x89D510", VA = "0x18089E310")]
	public ScenarioBehaviour GetActiveScenarioBehavior()
	{
		return null;
	}

	[Token(Token = "0x6004243")]
	[Address(RVA = "0x8A0630", Offset = "0x89F830", VA = "0x1808A0630")]
	public ScenarioBehaviour TryGetWaitInputBehaviour()
	{
		return null;
	}

	[Token(Token = "0x6004244")]
	[Address(RVA = "0x89E150", Offset = "0x89D350", VA = "0x18089E150")]
	private void AbortByError(ScenarioBehaviour errorBehaviour)
	{
	}
}
