using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame;

[Token(Token = "0x20006DF")]
public class PopUpTextForSelectionList : MonoBehaviour
{
	[Token(Token = "0x20006E0")]
	private enum Status
	{
		[Token(Token = "0x40022AD")]
		Opening,
		[Token(Token = "0x40022AE")]
		Showing,
		[Token(Token = "0x40022AF")]
		Closing,
		[Token(Token = "0x40022B0")]
		Free
	}

	[Token(Token = "0x20006E2")]
	[CompilerGenerated]
	private sealed class _003CShow_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0x20")]
		public PopUpTextForSelectionList _003C_003E4__this;

		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0x28")]
		public string text;

		[Token(Token = "0x170005AE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DED")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DEF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002DEA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShow_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DEB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DEC")]
		[Address(RVA = "0x7253B0", Offset = "0x7245B0", VA = "0x1807253B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DEE")]
		[Address(RVA = "0x7255A0", Offset = "0x7247A0", VA = "0x1807255A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400229F")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<SelectionButton, string> m_PupUpBtnTabel;

	[Token(Token = "0x40022A0")]
	[FieldOffset(Offset = "0x28")]
	private float m_MaxWidth;

	[Token(Token = "0x40022A1")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_CurrentCoroutine;

	[Token(Token = "0x40022A2")]
	[FieldOffset(Offset = "0x38")]
	private SelectionButton m_TargetSbtn;

	[Token(Token = "0x40022A3")]
	[FieldOffset(Offset = "0x40")]
	private Image m_Arrow;

	[Token(Token = "0x40022A4")]
	[FieldOffset(Offset = "0x48")]
	private TweenAlpha m_TweenAlphaTo;

	[Token(Token = "0x40022A5")]
	[FieldOffset(Offset = "0x50")]
	private TweenScaleTo m_TweenScaleRootTo;

	[Token(Token = "0x40022A6")]
	[FieldOffset(Offset = "0x58")]
	private TweenScaleTo m_TweenScaleArrowTo;

	[Token(Token = "0x40022A7")]
	[FieldOffset(Offset = "0x60")]
	private Status m_Status;

	[Token(Token = "0x40022A8")]
	[FieldOffset(Offset = "0x68")]
	private ElementObjectManager m_EOManager;

	[Token(Token = "0x40022A9")]
	[FieldOffset(Offset = "0x70")]
	private ExtendedTextMeshProUGUI m_PopUpText;

	[Token(Token = "0x40022AA")]
	[FieldOffset(Offset = "0x78")]
	private RectTransform m_Rt;

	[Token(Token = "0x40022AB")]
	[FieldOffset(Offset = "0x80")]
	private AdaptiveTextContainer adaptiveTextContainer;

	[Token(Token = "0x6002DDE")]
	[Address(RVA = "0x71DE50", Offset = "0x71D050", VA = "0x18071DE50")]
	public void RegistPopUpCallback(SelectionButton sbtn, string text)
	{
	}

	[Token(Token = "0x6002DDF")]
	[Address(RVA = "0x71DE10", Offset = "0x71D010", VA = "0x18071DE10")]
	public void OnDisappear()
	{
	}

	[Token(Token = "0x6002DE0")]
	[Address(RVA = "0x71DB70", Offset = "0x71CD70", VA = "0x18071DB70")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6002DE1")]
	[Address(RVA = "0x71DE50", Offset = "0x71D050", VA = "0x18071DE50")]
	private void RegistPopUpCallbackImpl(SelectionButton sbtn, string text)
	{
	}

	[Token(Token = "0x6002DE2")]
	[Address(RVA = "0x71E010", Offset = "0x71D210", VA = "0x18071E010")]
	public void SetMaxWidth(int maxWidth)
	{
	}

	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x71E030", Offset = "0x71D230", VA = "0x18071E030")]
	[IteratorStateMachine(typeof(_003CShow_003Ed__19))]
	private IEnumerator Show(string text)
	{
		return null;
	}

	[Token(Token = "0x6002DE4")]
	[Address(RVA = "0x71E110", Offset = "0x71D310", VA = "0x18071E110")]
	private void Update()
	{
	}

	[Token(Token = "0x6002DE5")]
	[Address(RVA = "0x71E0C0", Offset = "0x71D2C0", VA = "0x18071E0C0")]
	private void StopAllTween()
	{
	}

	[Token(Token = "0x6002DE6")]
	[Address(RVA = "0x71E2F0", Offset = "0x71D4F0", VA = "0x18071E2F0")]
	public PopUpTextForSelectionList()
	{
	}
}
