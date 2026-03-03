using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AC6")]
public class ScenarioBehaviour_Voice : ScenarioBehaviour, IScenarioBehaviour_SoundPlay
{
	[Token(Token = "0x400939F")]
	[FieldOffset(Offset = "0x50")]
	private readonly ScenarioBehaviour_Text m_TextBehaviour;

	[Token(Token = "0x40093A0")]
	[FieldOffset(Offset = "0x58")]
	private readonly ScenarioBehaviour_SoundPlay m_SoundPlayBehaviour;

	[Token(Token = "0x170008C8")]
	public bool readyTMClip
	{
		[Token(Token = "0x600421D")]
		[Address(RVA = "0x89D5F0", Offset = "0x89C7F0", VA = "0x18089D5F0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008C9")]
	public bool useTMClip
	{
		[Token(Token = "0x600421E")]
		[Address(RVA = "0x89D610", Offset = "0x89C810", VA = "0x18089D610", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600421F")]
	[Address(RVA = "0x89D3F0", Offset = "0x89C5F0", VA = "0x18089D3F0")]
	public ScenarioBehaviour_Voice(object commandData)
	{
	}

	[Token(Token = "0x6004220")]
	[Address(RVA = "0x89D3B0", Offset = "0x89C5B0", VA = "0x18089D3B0", Slot = "7")]
	public override void SetScenarioWork(ScenarioWork work)
	{
	}

	[Token(Token = "0x6004221")]
	[Address(RVA = "0x89D320", Offset = "0x89C520", VA = "0x18089D320", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004222")]
	[Address(RVA = "0x89D270", Offset = "0x89C470", VA = "0x18089D270", Slot = "8")]
	protected override bool AllowProgressChild(ScenarioBehaviour child)
	{
		return default(bool);
	}

	[Token(Token = "0x6004223")]
	[Address(RVA = "0x89D280", Offset = "0x89C480", VA = "0x18089D280", Slot = "9")]
	protected override bool AllowProgressNextChild(ScenarioBehaviour child)
	{
		return default(bool);
	}

	[Token(Token = "0x6004224")]
	[Address(RVA = "0x89D380", Offset = "0x89C580", VA = "0x18089D380", Slot = "15")]
	protected override void ProgressWaitInput()
	{
	}

	[Token(Token = "0x6004225")]
	[Address(RVA = "0x89D330", Offset = "0x89C530", VA = "0x18089D330", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}
}
