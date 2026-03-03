using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission;

[Token(Token = "0x2000C0D")]
public class MissionGoalWidget : ElementWidgetBase
{
	[Token(Token = "0x2000C0E")]
	public enum GoalType
	{
		[Token(Token = "0x40099D4")]
		None,
		[Token(Token = "0x40099D5")]
		InProgress,
		[Token(Token = "0x40099D6")]
		Recievable,
		[Token(Token = "0x40099D7")]
		Complete
	}

	[Token(Token = "0x2000C0F")]
	[CompilerGenerated]
	private sealed class _003CyPlayRecieveBetweenWait_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40099D8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40099D9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40099DA")]
		[FieldOffset(Offset = "0x20")]
		public MissionGoalWidget _003C_003E4__this;

		[Token(Token = "0x170009E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600497C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600497E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004979")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayRecieveBetweenWait_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600497A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600497B")]
		[Address(RVA = "0x92B770", Offset = "0x92A970", VA = "0x18092B770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600497D")]
		[Address(RVA = "0x92B9D0", Offset = "0x92ABD0", VA = "0x18092B9D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000C10")]
	[CompilerGenerated]
	private sealed class _003CyPlayRecieved_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40099DB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40099DC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40099DD")]
		[FieldOffset(Offset = "0x20")]
		public MissionGoalWidget _003C_003E4__this;

		[Token(Token = "0x170009EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004982")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004984")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600497F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayRecieved_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004980")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004981")]
		[Address(RVA = "0x92C640", Offset = "0x92B840", VA = "0x18092C640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004983")]
		[Address(RVA = "0x92C7D0", Offset = "0x92B9D0", VA = "0x18092C7D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40099CC")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelCountText;

	[Token(Token = "0x40099CD")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelRewardThumbHolder;

	[Token(Token = "0x40099CE")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelRewardNumText;

	[Token(Token = "0x40099CF")]
	private const string k_ELabelRecievedIcon = "RecievedIcon";

	[Token(Token = "0x40099D0")]
	private const string k_TLabelOnRecieveBetweenWait = "OnRecieveBetweenWait";

	[Token(Token = "0x40099D1")]
	private const string k_TLabelOnRecieved = "OnRecieved";

	[Token(Token = "0x40099D2")]
	[FieldOffset(Offset = "0x38")]
	public readonly GoalType goalType;

	[Token(Token = "0x170009E4")]
	private bool existsRecievedIcon
	{
		[Token(Token = "0x600496A")]
		[Address(RVA = "0x91F5E0", Offset = "0x91E7E0", VA = "0x18091F5E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009E5")]
	private GameObject recievedIcon
	{
		[Token(Token = "0x600496B")]
		[Address(RVA = "0x91F650", Offset = "0x91E850", VA = "0x18091F650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E6")]
	public TMP_Text countText
	{
		[Token(Token = "0x600496C")]
		[Address(RVA = "0x91F590", Offset = "0x91E790", VA = "0x18091F590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E7")]
	public GameObject rewardThumbHolder
	{
		[Token(Token = "0x600496D")]
		[Address(RVA = "0x88DAB0", Offset = "0x88CCB0", VA = "0x18088DAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E8")]
	public TMP_Text rewardNumText
	{
		[Token(Token = "0x600496E")]
		[Address(RVA = "0x91F6A0", Offset = "0x91E8A0", VA = "0x18091F6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600496F")]
	[Address(RVA = "0x91F3F0", Offset = "0x91E5F0", VA = "0x18091F3F0")]
	public MissionGoalWidget(ElementObjectManager eom, GoalType goalType)
	{
	}

	[Token(Token = "0x6004970")]
	[Address(RVA = "0x91F150", Offset = "0x91E350", VA = "0x18091F150")]
	public void SetRecieveBetweenWaitSpeed(float speed)
	{
	}

	[Token(Token = "0x6004971")]
	[Address(RVA = "0x91EDD0", Offset = "0x91DFD0", VA = "0x18091EDD0")]
	public bool IsPlayingRecieveBetweenWait()
	{
		return default(bool);
	}

	[Token(Token = "0x6004972")]
	[Address(RVA = "0x91F6F0", Offset = "0x91E8F0", VA = "0x18091F6F0")]
	[IteratorStateMachine(typeof(_003CyPlayRecieveBetweenWait_003Ed__21))]
	public IEnumerator yPlayRecieveBetweenWait()
	{
		return null;
	}

	[Token(Token = "0x6004973")]
	[Address(RVA = "0x91F1E0", Offset = "0x91E3E0", VA = "0x18091F1E0")]
	public void SetRecievedSpeed(float speed)
	{
	}

	[Token(Token = "0x6004974")]
	[Address(RVA = "0x91EF90", Offset = "0x91E190", VA = "0x18091EF90")]
	public void PlayRecieved()
	{
	}

	[Token(Token = "0x6004975")]
	[Address(RVA = "0x91F760", Offset = "0x91E960", VA = "0x18091F760")]
	[IteratorStateMachine(typeof(_003CyPlayRecieved_003Ed__24))]
	private IEnumerator yPlayRecieved()
	{
		return null;
	}

	[Token(Token = "0x6004976")]
	[Address(RVA = "0x91EE80", Offset = "0x91E080", VA = "0x18091EE80")]
	public bool IsPlayingRecieved()
	{
		return default(bool);
	}

	[Token(Token = "0x6004977")]
	[Address(RVA = "0x91F270", Offset = "0x91E470", VA = "0x18091F270")]
	public void SetRecieved()
	{
	}

	[Token(Token = "0x6004978")]
	[Address(RVA = "0x91ECE0", Offset = "0x91DEE0", VA = "0x18091ECE0")]
	public void ClearRecieved()
	{
	}
}
