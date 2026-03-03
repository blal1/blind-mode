using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x20001DE")]
public class StepSequencer
{
	[Token(Token = "0x20001DF")]
	private enum Status
	{
		[Token(Token = "0x4000A49")]
		Idle,
		[Token(Token = "0x4000A4A")]
		Running,
		[Token(Token = "0x4000A4B")]
		End
	}

	[Token(Token = "0x20001E0")]
	private enum ProcessType
	{
		[Token(Token = "0x4000A4D")]
		None,
		[Token(Token = "0x4000A4E")]
		Method,
		[Token(Token = "0x4000A4F")]
		Coroutine
	}

	[Token(Token = "0x20001E1")]
	private class StepEntry
	{
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x10")]
		public int step;

		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x14")]
		public ProcessType type;

		[Token(Token = "0x4000A52")]
		[FieldOffset(Offset = "0x18")]
		public object proccess;

		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x20")]
		public IEnumerator enumerator;

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public StepEntry()
		{
		}
	}

	[Token(Token = "0x20001E2")]
	[CompilerGenerated]
	private sealed class _003CstepCoroutineProcess_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x20")]
		public StepEntry entry;

		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x28")]
		public StepSequencer _003C_003E4__this;

		[Token(Token = "0x17000131")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepCoroutineProcess_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0xC18A30", Offset = "0xC17C30", VA = "0x180C18A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0xC18B20", Offset = "0xC17D20", VA = "0x180C18B20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, StepEntry> m_steps;

	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x18")]
	private int m_currentStep;

	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x1C")]
	private int m_prevStep;

	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x20")]
	private bool m_stepChanged;

	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x28")]
	private IEnumerator m_stepCoroutine;

	[Token(Token = "0x4000A45")]
	private const int INVALID_STEP = -1;

	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x30")]
	private Status m_status;

	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x34")]
	private int m_result;

	[Token(Token = "0x1700012D")]
	public bool isRunning
	{
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0xC16490", Offset = "0xC15690", VA = "0x180C16490")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700012E")]
	public bool isStepChanged
	{
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700012F")]
	public int currentStep
	{
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000130")]
	public int result
	{
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000B25")]
	[Address(RVA = "0xC164A0", Offset = "0xC156A0", VA = "0x180C164A0")]
	private StepEntry registerStep(int step, ProcessType type, object proccess)
	{
		return null;
	}

	[Token(Token = "0x6000B26")]
	[Address(RVA = "0xC15F10", Offset = "0xC15110", VA = "0x180C15F10")]
	private void clear()
	{
	}

	[Token(Token = "0x6000B27")]
	[Address(RVA = "0xC16690", Offset = "0xC15890", VA = "0x180C16690")]
	[IteratorStateMachine(typeof(_003CstepCoroutineProcess_003Ed__13))]
	private IEnumerator stepCoroutineProcess(StepEntry entry)
	{
		return null;
	}

	[Token(Token = "0x6000B28")]
	[Address(RVA = "0xC165B0", Offset = "0xC157B0", VA = "0x180C165B0")]
	private void runStepCoroutine(StepEntry entry)
	{
	}

	[Token(Token = "0x6000B29")]
	[Address(RVA = "0xC16720", Offset = "0xC15920", VA = "0x180C16720")]
	private void stopStepCoroutine()
	{
	}

	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0xC163F0", Offset = "0xC155F0", VA = "0x180C163F0")]
	public StepSequencer()
	{
	}

	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0xC15F10", Offset = "0xC15110", VA = "0x180C15F10")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0xC15F80", Offset = "0xC15180", VA = "0x180C15F80")]
	public void RegisterStep(int stepValue, Action<StepSequencer> stepMethod)
	{
	}

	[Token(Token = "0x6000B2D")]
	public void RegisterStep<T>(T stepValue, Action<StepSequencer> stepMethod) where T : Enum
	{
	}

	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0xC15FA0", Offset = "0xC151A0", VA = "0x180C15FA0")]
	public void RegisterStep(int stepValue, Func<StepSequencer, IEnumerator> stepGenerator)
	{
	}

	[Token(Token = "0x6000B2F")]
	public void RegisterStep<T>(T stepValue, Func<StepSequencer, IEnumerator> stepGenerator) where T : Enum
	{
	}

	[Token(Token = "0x6000B30")]
	public bool IsStepRegistered<T>(T step) where T : Enum
	{
		return default(bool);
	}

	[Token(Token = "0x6000B31")]
	[Address(RVA = "0xC161A0", Offset = "0xC153A0", VA = "0x180C161A0")]
	public void StartSequence(int startStep)
	{
	}

	[Token(Token = "0x6000B32")]
	public void StartSequence<T>(T startStep) where T : Enum
	{
	}

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0xC15FC0", Offset = "0xC151C0", VA = "0x180C15FC0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0xC16230", Offset = "0xC15430", VA = "0x180C16230")]
	public bool UpdateSequence()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B35")]
	[Address(RVA = "0xC16140", Offset = "0xC15340", VA = "0x180C16140")]
	public void SetStep(int step)
	{
	}

	[Token(Token = "0x6000B36")]
	public void SetStep<T>(T stepValue) where T : Enum
	{
	}

	[Token(Token = "0x6000B37")]
	[Address(RVA = "0xC16130", Offset = "0xC15330", VA = "0x180C16130")]
	public void SetEnd(int result = 0)
	{
	}
}
