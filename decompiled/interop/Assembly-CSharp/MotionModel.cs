using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200004F")]
[RequireComponent(typeof(Animator))]
public class MotionModel : MonoBehaviour
{
	[Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class _003CDelaySetFalse_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionModel _003C_003E4__this;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action action;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimatorStateInfo _003Cstate_003E5__2;

		[Token(Token = "0x1700001B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelaySetFalse_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x3FBB40", Offset = "0x3FAD40", VA = "0x1803FBB40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x3FBC90", Offset = "0x3FAE90", VA = "0x1803FBC90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator animator;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AnimatorStateInfo defaultState;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int syncLayerIdx;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool disableStateControlWeightChange;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool playing;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool enableSE;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string modelSeLabel;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int seId;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float sePan;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int loadModelId;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool isMotionSELoaded;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string preAnimationEventSeLabel;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<string> triggerList;

	[Token(Token = "0x4000193")]
	private const string syncLayerName = "Sync Layer";

	[Token(Token = "0x1700001A")]
	public bool DisableStateControlWeightChange
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x3E1DE0", Offset = "0x3E0FE0", VA = "0x1803E1DE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x3E1DF0", Offset = "0x3E0FF0", VA = "0x1803E1DF0")]
		set
		{
		}
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x3E1280", Offset = "0x3E0480", VA = "0x1803E1280")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void Init(Animator animator)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x3E1AC0", Offset = "0x3E0CC0", VA = "0x1803E1AC0")]
	public void Play(string label)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x3E1870", Offset = "0x3E0A70", VA = "0x1803E1870")]
	private void PlayBool(string label)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x3E1650", Offset = "0x3E0850", VA = "0x1803E1650")]
	public bool IsTransitionCompleteLoopState()
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x3E1A10", Offset = "0x3E0C10", VA = "0x1803E1A10")]
	private void PlayTrigger(string label, [Optional] string seLabel)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x3E1C80", Offset = "0x3E0E80", VA = "0x1803E1C80")]
	public void SetSELabel(string label, int modelId)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x3E1C70", Offset = "0x3E0E70", VA = "0x1803E1C70")]
	public void SetEnableSE(bool flg)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x3E15D0", Offset = "0x3E07D0", VA = "0x1803E15D0")]
	public bool GetEnableSE()
	{
		return default(bool);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x3E1540", Offset = "0x3E0740", VA = "0x1803E1540")]
	[IteratorStateMachine(typeof(_003CDelaySetFalse_003Ed__26))]
	private IEnumerator DelaySetFalse(Action action)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x3E16E0", Offset = "0x3E08E0", VA = "0x1803E16E0")]
	public void PlayAnimationEventSe(string seLabel)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x3E1CB0", Offset = "0x3E0EB0", VA = "0x1803E1CB0")]
	public void SetSePan(float pan)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x3E15E0", Offset = "0x3E07E0", VA = "0x1803E15E0")]
	public float GetSePan()
	{
		return default(float);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x3E1CC0", Offset = "0x3E0EC0", VA = "0x1803E1CC0")]
	public void StopSe(float fade = -1f)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x3E14B0", Offset = "0x3E06B0", VA = "0x1803E14B0")]
	public bool CheckDefaultState()
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x3E15F0", Offset = "0x3E07F0", VA = "0x1803E15F0")]
	public bool HasMotion(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x3E1470", Offset = "0x3E0670", VA = "0x1803E1470")]
	public void ChangeSyncLayerWeight(float val)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x3E1C60", Offset = "0x3E0E60", VA = "0x1803E1C60")]
	public void ResetPlaying()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x3E1D40", Offset = "0x3E0F40", VA = "0x1803E1D40")]
	public MotionModel()
	{
	}
}
