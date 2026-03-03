using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AAF")]
public abstract class ScenarioBehaviour : IScenarioBehaviour
{
	[Token(Token = "0x2000AB0")]
	public enum Step
	{
		[Token(Token = "0x400934F")]
		None,
		[Token(Token = "0x4009350")]
		ControllerCheck,
		[Token(Token = "0x4009351")]
		Init,
		[Token(Token = "0x4009352")]
		Action,
		[Token(Token = "0x4009353")]
		Wait,
		[Token(Token = "0x4009354")]
		WaitInput,
		[Token(Token = "0x4009355")]
		Finish,
		[Token(Token = "0x4009356")]
		Error
	}

	[Token(Token = "0x4009345")]
	[FieldOffset(Offset = "0x10")]
	public readonly string commandKey;

	[Token(Token = "0x4009346")]
	[FieldOffset(Offset = "0x18")]
	public readonly ScenarioDef.BehaviourAsyncMode asyncMode;

	[Token(Token = "0x4009347")]
	[FieldOffset(Offset = "0x20")]
	protected readonly Dictionary<string, object> m_Args;

	[Token(Token = "0x4009348")]
	[FieldOffset(Offset = "0x28")]
	protected Step m_Step;

	[Token(Token = "0x4009349")]
	[FieldOffset(Offset = "0x30")]
	private List<ScenarioBehaviour> m_Children;

	[Token(Token = "0x400934A")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsEnd;

	[Token(Token = "0x400934B")]
	[FieldOffset(Offset = "0x3C")]
	private float m_AutoFinishSec;

	[Token(Token = "0x400934C")]
	[FieldOffset(Offset = "0x40")]
	private float m_AutoWaitPast;

	[Token(Token = "0x400934D")]
	[FieldOffset(Offset = "0x48")]
	protected ScenarioWork work;

	[Token(Token = "0x170008AB")]
	public bool hasChildren
	{
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x89D9F0", Offset = "0x89CBF0", VA = "0x18089D9F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008AC")]
	public IReadOnlyList<ScenarioBehaviour> children
	{
		[Token(Token = "0x6004189")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008AD")]
	public Step step
	{
		[Token(Token = "0x600418A")]
		[Address(RVA = "0x89DA80", Offset = "0x89CC80", VA = "0x18089DA80")]
		get
		{
			return default(Step);
		}
		[Token(Token = "0x600418B")]
		[Address(RVA = "0x89DCA0", Offset = "0x89CEA0", VA = "0x18089DCA0")]
		protected set
		{
		}
	}

	[Token(Token = "0x170008AE")]
	public Step childMinStep
	{
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x89D850", Offset = "0x89CA50", VA = "0x18089D850")]
		get
		{
			return default(Step);
		}
	}

	[Token(Token = "0x170008AF")]
	public virtual bool isReady
	{
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x89DA60", Offset = "0x89CC60", VA = "0x18089DA60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008B0")]
	public virtual float arrowMerginSec
	{
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x6496C0", Offset = "0x6488C0", VA = "0x1806496C0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008B1")]
	public bool isFinish
	{
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x89DA40", Offset = "0x89CC40", VA = "0x18089DA40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008B2")]
	protected virtual float autoWaitSec
	{
		[Token(Token = "0x60041AC")]
		[Address(RVA = "0x6496C0", Offset = "0x6488C0", VA = "0x1806496C0", Slot = "22")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6004190")]
	[Address(RVA = "0x89D7D0", Offset = "0x89C9D0", VA = "0x18089D7D0")]
	public ScenarioBehaviour(object commandData)
	{
	}

	[Token(Token = "0x6004191")]
	[Address(RVA = "0x899220", Offset = "0x898420", VA = "0x180899220", Slot = "7")]
	public virtual void SetScenarioWork(ScenarioWork work)
	{
	}

	[Token(Token = "0x6004192")]
	[Address(RVA = "0x899370", Offset = "0x898570", VA = "0x180899370")]
	public void SetStep(Step s)
	{
	}

	[Token(Token = "0x6004193")]
	[Address(RVA = "0x8977B0", Offset = "0x8969B0", VA = "0x1808977B0")]
	private bool IsTerminateStep(Step s)
	{
		return default(bool);
	}

	[Token(Token = "0x6004194")]
	[Address(RVA = "0x8970A0", Offset = "0x8962A0", VA = "0x1808970A0")]
	public void AssignChild(ScenarioBehaviour child)
	{
	}

	[Token(Token = "0x6004195")]
	[Address(RVA = "0x897070", Offset = "0x896270", VA = "0x180897070", Slot = "8")]
	protected virtual bool AllowProgressChild(ScenarioBehaviour child)
	{
		return default(bool);
	}

	[Token(Token = "0x6004196")]
	[Address(RVA = "0x897080", Offset = "0x896280", VA = "0x180897080", Slot = "9")]
	protected virtual bool AllowProgressNextChild(ScenarioBehaviour child)
	{
		return default(bool);
	}

	[Token(Token = "0x6004197")]
	protected List<T> FindChildBehaviours<T>() where T : ScenarioBehaviour
	{
		return null;
	}

	[Token(Token = "0x6004198")]
	protected void FindChildBehaviours<T>(List<T> res) where T : ScenarioBehaviour
	{
	}

	[Token(Token = "0x6004199")]
	[Address(RVA = "0x89D040", Offset = "0x89C240", VA = "0x18089D040")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600419A")]
	[Address(RVA = "0x89CA80", Offset = "0x89BC80", VA = "0x18089CA80")]
	public bool Update(Step maxStep)
	{
		return default(bool);
	}

	[Token(Token = "0x600419B")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
	public virtual bool OnResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600419C")]
	[Address(RVA = "0x89DC80", Offset = "0x89CE80", VA = "0x18089DC80")]
	public bool isError()
	{
		return default(bool);
	}

	[Token(Token = "0x600419D")]
	[Address(RVA = "0x896F00", Offset = "0x896100", VA = "0x180896F00", Slot = "4")]
	public void Abort()
	{
	}

	[Token(Token = "0x600419E")]
	[Address(RVA = "0x897480", Offset = "0x896680", VA = "0x180897480")]
	protected void ControllerCheck()
	{
	}

	[Token(Token = "0x600419F")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "11")]
	protected virtual bool ProgressControllerCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60041A0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	protected virtual void ProgressInit()
	{
	}

	[Token(Token = "0x60041A1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	protected virtual void ProgressAction()
	{
	}

	[Token(Token = "0x60041A2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected virtual void ProgressWait()
	{
	}

	[Token(Token = "0x60041A3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
	protected virtual void ProgressWaitInput()
	{
	}

	[Token(Token = "0x60041A4")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "16")]
	protected virtual void ProgressFinish()
	{
	}

	[Token(Token = "0x60041A5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "17")]
	protected virtual void ProgressError()
	{
	}

	[Token(Token = "0x60041A6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	protected virtual void OnAbort()
	{
	}

	[Token(Token = "0x60041A7")]
	[Address(RVA = "0x897750", Offset = "0x896950", VA = "0x180897750", Slot = "19")]
	public virtual bool IsOverrideBehaviour(ScenarioBehaviour target)
	{
		return default(bool);
	}

	[Token(Token = "0x60041A8")]
	[Address(RVA = "0x897EC0", Offset = "0x8970C0", VA = "0x180897EC0")]
	public bool OnPointerClick()
	{
		return default(bool);
	}

	[Token(Token = "0x60041A9")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "20")]
	protected virtual bool ProgressPointerClick()
	{
		return default(bool);
	}

	[Token(Token = "0x60041AA")]
	[Address(RVA = "0x897EB0", Offset = "0x8970B0", VA = "0x180897EB0")]
	private void OnChangeSuspend(bool isSuspend)
	{
	}

	[Token(Token = "0x60041AB")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "21")]
	protected virtual bool ReadyAutoProgress()
	{
		return default(bool);
	}

	[Token(Token = "0x60041AD")]
	[Address(RVA = "0x897EA0", Offset = "0x8970A0", VA = "0x180897EA0")]
	private void OnChangeAuto(bool isAuto)
	{
	}

	[Token(Token = "0x60041AE")]
	[Address(RVA = "0x898CC0", Offset = "0x897EC0", VA = "0x180898CC0")]
	private void ResetAutoPast()
	{
	}
}
