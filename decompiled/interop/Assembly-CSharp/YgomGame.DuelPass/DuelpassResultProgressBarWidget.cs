using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000EDE")]
public class DuelpassResultProgressBarWidget
{
	[Token(Token = "0x2000EDF")]
	[CompilerGenerated]
	private sealed class _003CProgressAnimationCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A525")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A526")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A527")]
		[FieldOffset(Offset = "0x20")]
		public DuelpassResultProgressBarWidget _003C_003E4__this;

		[Token(Token = "0x400A528")]
		[FieldOffset(Offset = "0x28")]
		private float _003CelapsedTime_003E5__2;

		[Token(Token = "0x400A529")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CstartProgress_003E5__3;

		[Token(Token = "0x400A52A")]
		[FieldOffset(Offset = "0x30")]
		private float _003CcurrentProgress_003E5__4;

		[Token(Token = "0x17000DE8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005A21")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DE9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005A23")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A1E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CProgressAnimationCoroutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005A1F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005A20")]
		[Address(RVA = "0x9FDB10", Offset = "0x9FCD10", VA = "0x1809FDB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005A22")]
		[Address(RVA = "0x9FDE80", Offset = "0x9FD080", VA = "0x1809FDE80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A51A")]
	[FieldOffset(Offset = "0x10")]
	private TMP_Text currentGradeText;

	[Token(Token = "0x400A51B")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Text nextGradeText;

	[Token(Token = "0x400A51C")]
	[FieldOffset(Offset = "0x20")]
	private Image progressBar;

	[Token(Token = "0x400A51D")]
	[FieldOffset(Offset = "0x28")]
	private Image normalpassWallpaper;

	[Token(Token = "0x400A51E")]
	[FieldOffset(Offset = "0x30")]
	private Image goldpassWallpaper;

	[Token(Token = "0x400A51F")]
	[FieldOffset(Offset = "0x38")]
	private DuelpassResultProgressBarContext context;

	[Token(Token = "0x400A520")]
	[FieldOffset(Offset = "0x40")]
	private float time100;

	[Token(Token = "0x400A521")]
	[FieldOffset(Offset = "0x44")]
	private float dulationTime;

	[Token(Token = "0x400A522")]
	[FieldOffset(Offset = "0x48")]
	public Action onStartAnimation;

	[Token(Token = "0x400A523")]
	[FieldOffset(Offset = "0x50")]
	public Action onEndAnimation;

	[Token(Token = "0x400A524")]
	[FieldOffset(Offset = "0x58")]
	public Action<int> onGradeUpInAnimation;

	[Token(Token = "0x6005A1B")]
	[Address(RVA = "0x9F20F0", Offset = "0x9F12F0", VA = "0x1809F20F0")]
	public DuelpassResultProgressBarWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005A1C")]
	[Address(RVA = "0x9F2050", Offset = "0x9F1250", VA = "0x1809F2050")]
	public void StartGradeProgressAnimation(MonoBehaviour coroutineStarter)
	{
	}

	[Token(Token = "0x6005A1D")]
	[Address(RVA = "0x9F1FE0", Offset = "0x9F11E0", VA = "0x1809F1FE0")]
	[IteratorStateMachine(typeof(_003CProgressAnimationCoroutine_003Ed__13))]
	private IEnumerator ProgressAnimationCoroutine()
	{
		return null;
	}
}
