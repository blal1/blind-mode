using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AB7")]
public class ScenarioBehaviour_SoundPlay : ScenarioBehaviour, IScenarioBehaviour_SoundPlay, IScenarioPreloadSoundBehaviour, IScenarioPreloadBehaviour
{
	[Token(Token = "0x2000AB8")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x4009372")]
		[FieldOffset(Offset = "0x10")]
		public bool readyVoice;

		[Token(Token = "0x60041DA")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyProgressInit_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000AB9")]
	[CompilerGenerated]
	private sealed class _003CyProgressActionAsClip_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009373")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009374")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009375")]
		[FieldOffset(Offset = "0x20")]
		public ScenarioBehaviour_SoundPlay _003C_003E4__this;

		[Token(Token = "0x170008BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60041DF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60041E1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyProgressActionAsClip_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x8AAE30", Offset = "0x8AA030", VA = "0x1808AAE30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60041E0")]
		[Address(RVA = "0x8AAFD0", Offset = "0x8AA1D0", VA = "0x1808AAFD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000ABA")]
	[CompilerGenerated]
	private sealed class _003CyProgressActionAsSequence_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009376")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009377")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009378")]
		[FieldOffset(Offset = "0x20")]
		public ScenarioBehaviour_SoundPlay _003C_003E4__this;

		[Token(Token = "0x4009379")]
		[FieldOffset(Offset = "0x28")]
		private float _003CdelaySec_003E5__2;

		[Token(Token = "0x400937A")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CendMarginSec_003E5__3;

		[Token(Token = "0x170008BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60041E5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60041E7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60041E2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyProgressActionAsSequence_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60041E3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60041E4")]
		[Address(RVA = "0x8AB010", Offset = "0x8AA210", VA = "0x1808AB010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60041E6")]
		[Address(RVA = "0x8AB2E0", Offset = "0x8AA4E0", VA = "0x1808AB2E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000ABB")]
	[CompilerGenerated]
	private sealed class _003CyProgressInit_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400937B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400937C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400937D")]
		[FieldOffset(Offset = "0x20")]
		public ScenarioBehaviour_SoundPlay _003C_003E4__this;

		[Token(Token = "0x400937E")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x170008BF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60041EB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60041ED")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60041E8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyProgressInit_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60041EA")]
		[Address(RVA = "0x8AB320", Offset = "0x8AA520", VA = "0x1808AB320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60041EC")]
		[Address(RVA = "0x8AB6A0", Offset = "0x8AA8A0", VA = "0x1808AB6A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009368")]
	internal const string k_ArgKey_WaitCompleteSound = "sound_wait_complete";

	[Token(Token = "0x4009369")]
	[FieldOffset(Offset = "0x50")]
	private string m_Label;

	[Token(Token = "0x400936A")]
	[FieldOffset(Offset = "0x58")]
	private bool m_Played;

	[Token(Token = "0x400936B")]
	[FieldOffset(Offset = "0x60")]
	private string m_ScenarioSoundClip;

	[Token(Token = "0x400936C")]
	[FieldOffset(Offset = "0x68")]
	private ScenarioSoundTrackBinder m_SoundTrackBinder;

	[Token(Token = "0x400936D")]
	[FieldOffset(Offset = "0x70")]
	private bool m_AsTMClip;

	[Token(Token = "0x400936E")]
	[FieldOffset(Offset = "0x74")]
	public float defaultDelaySec;

	[Token(Token = "0x400936F")]
	[FieldOffset(Offset = "0x78")]
	public float defaultMarginSec;

	[Token(Token = "0x4009370")]
	[FieldOffset(Offset = "0x80")]
	private IEnumerator m_InitRoutine;

	[Token(Token = "0x4009371")]
	[FieldOffset(Offset = "0x88")]
	private IEnumerator m_ActionRoutine;

	[Token(Token = "0x170008B7")]
	public override float arrowMerginSec
	{
		[Token(Token = "0x60041CA")]
		[Address(RVA = "0x89A030", Offset = "0x899230", VA = "0x18089A030", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008B8")]
	public bool played
	{
		[Token(Token = "0x60041CB")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008B9")]
	public bool readyTMClip
	{
		[Token(Token = "0x60041CC")]
		[Address(RVA = "0x89A090", Offset = "0x899290", VA = "0x18089A090", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008BA")]
	public bool useTMClip
	{
		[Token(Token = "0x60041CD")]
		[Address(RVA = "0x89A130", Offset = "0x899330", VA = "0x18089A130", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60041C9")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_SoundPlay(object commandData)
	{
	}

	[Token(Token = "0x60041CE")]
	[Address(RVA = "0x899740", Offset = "0x898940", VA = "0x180899740", Slot = "25")]
	public void AssignPreloadSoundLabels(List<string> soundLabels)
	{
	}

	[Token(Token = "0x60041CF")]
	[Address(RVA = "0x899F50", Offset = "0x899150", VA = "0x180899F50", Slot = "7")]
	public override void SetScenarioWork(ScenarioWork work)
	{
	}

	[Token(Token = "0x60041D0")]
	[Address(RVA = "0x899680", Offset = "0x898880", VA = "0x180899680", Slot = "9")]
	protected override bool AllowProgressNextChild(ScenarioBehaviour child)
	{
		return default(bool);
	}

	[Token(Token = "0x60041D1")]
	[Address(RVA = "0x899E40", Offset = "0x899040", VA = "0x180899E40", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x60041D2")]
	[Address(RVA = "0x89A290", Offset = "0x899490", VA = "0x18089A290")]
	[IteratorStateMachine(typeof(_003CyProgressInit_003Ed__22))]
	private IEnumerator yProgressInit()
	{
		return null;
	}

	[Token(Token = "0x60041D3")]
	[Address(RVA = "0x899C00", Offset = "0x898E00", VA = "0x180899C00", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x60041D4")]
	[Address(RVA = "0x89A1B0", Offset = "0x8993B0", VA = "0x18089A1B0")]
	[IteratorStateMachine(typeof(_003CyProgressActionAsClip_003Ed__25))]
	private IEnumerator yProgressActionAsClip()
	{
		return null;
	}

	[Token(Token = "0x60041D5")]
	[Address(RVA = "0x89A220", Offset = "0x899420", VA = "0x18089A220")]
	[IteratorStateMachine(typeof(_003CyProgressActionAsSequence_003Ed__26))]
	private IEnumerator yProgressActionAsSequence()
	{
		return null;
	}

	[Token(Token = "0x60041D6")]
	[Address(RVA = "0x899830", Offset = "0x898A30", VA = "0x180899830")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x60041D7")]
	[Address(RVA = "0x899F10", Offset = "0x899110", VA = "0x180899F10", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}

	[Token(Token = "0x60041D8")]
	[Address(RVA = "0x899D00", Offset = "0x898F00", VA = "0x180899D00", Slot = "16")]
	protected override void ProgressFinish()
	{
	}

	[Token(Token = "0x60041D9")]
	[Address(RVA = "0x8997F0", Offset = "0x8989F0", VA = "0x1808997F0")]
	private void OnProcessTMSoundTrack()
	{
	}
}
