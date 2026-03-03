using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000ABF")]
public class ScenarioBehaviour_Title : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour, IScenarioPreGenerateTextBehaviour
{
	[Token(Token = "0x2000AC0")]
	public enum InnerStep
	{
		[Token(Token = "0x4009385")]
		Step0_BeginLoad,
		[Token(Token = "0x4009386")]
		Step1_CheckRenderSetup,
		[Token(Token = "0x4009387")]
		Step2_CheckRootScreenFadin,
		[Token(Token = "0x4009388")]
		Step3_WaitRootScreenFadein,
		[Token(Token = "0x4009389")]
		Step4_CheckRootScreenFadeout,
		[Token(Token = "0x400938A")]
		Step5_WaitRootScreenFadeout
	}

	[Token(Token = "0x4009380")]
	[FieldOffset(Offset = "0x50")]
	private string m_TitleText;

	[Token(Token = "0x4009381")]
	[FieldOffset(Offset = "0x58")]
	private ScenarioBGActor m_BGActor;

	[Token(Token = "0x4009382")]
	[FieldOffset(Offset = "0x60")]
	private float m_CurrentSec;

	[Token(Token = "0x4009383")]
	[FieldOffset(Offset = "0x64")]
	private InnerStep m_InnerStep;

	[Token(Token = "0x170008C1")]
	public InnerStep innerStep
	{
		[Token(Token = "0x60041F7")]
		[Address(RVA = "0x80A510", Offset = "0x809710", VA = "0x18080A510")]
		get
		{
			return default(InnerStep);
		}
	}

	[Token(Token = "0x170008C2")]
	public override bool isReady
	{
		[Token(Token = "0x60041F8")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60041F9")]
	[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60", Slot = "23")]
	public bool IsFadeInTransitionCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60041FA")]
	[Address(RVA = "0x89A480", Offset = "0x899680", VA = "0x18089A480", Slot = "8")]
	protected override bool AllowProgressChild(ScenarioBehaviour child)
	{
		return default(bool);
	}

	[Token(Token = "0x60041FB")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_Title(object commandData)
	{
	}

	[Token(Token = "0x60041FC")]
	[Address(RVA = "0x89C240", Offset = "0x89B440", VA = "0x18089C240", Slot = "24")]
	public string GetPreGenerateText()
	{
		return null;
	}

	[Token(Token = "0x60041FD")]
	[Address(RVA = "0x89C7C0", Offset = "0x89B9C0", VA = "0x18089C7C0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x60041FE")]
	[Address(RVA = "0x89C380", Offset = "0x89B580", VA = "0x18089C380", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x60041FF")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}
}
