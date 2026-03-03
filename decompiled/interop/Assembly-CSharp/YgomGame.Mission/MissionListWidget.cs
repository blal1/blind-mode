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
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Mission;

[Token(Token = "0x2000C11")]
public class MissionListWidget : ElementWidgetBase
{
	[Token(Token = "0x2000C12")]
	[CompilerGenerated]
	private sealed class _003CyPlayFade_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40099EA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40099EB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40099EC")]
		[FieldOffset(Offset = "0x20")]
		public MissionListWidget _003C_003E4__this;

		[Token(Token = "0x40099ED")]
		[FieldOffset(Offset = "0x28")]
		public string tweenFadeKey;

		[Token(Token = "0x170009EE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004990")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004992")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600498D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayFade_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600498E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600498F")]
		[Address(RVA = "0x92B0B0", Offset = "0x92A2B0", VA = "0x18092B0B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004991")]
		[Address(RVA = "0x92B210", Offset = "0x92A410", VA = "0x18092B210", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000C13")]
	[CompilerGenerated]
	private sealed class _003CyPlayFocusPanel_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40099EE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40099EF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40099F0")]
		[FieldOffset(Offset = "0x20")]
		public MissionListWidget _003C_003E4__this;

		[Token(Token = "0x40099F1")]
		[FieldOffset(Offset = "0x28")]
		public int idx;

		[Token(Token = "0x40099F2")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CvirtualDstPos_003E5__2;

		[Token(Token = "0x40099F3")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform _003CtargetTran_003E5__3;

		[Token(Token = "0x170009F0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004996")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004998")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004993")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayFocusPanel_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004994")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004995")]
		[Address(RVA = "0x92B250", Offset = "0x92A450", VA = "0x18092B250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004997")]
		[Address(RVA = "0x92B730", Offset = "0x92A930", VA = "0x18092B730", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40099DE")]
	[FieldOffset(Offset = "0x20")]
	public readonly int k_NormalTemplateIdx;

	[Token(Token = "0x40099DF")]
	[FieldOffset(Offset = "0x24")]
	public readonly int k_HeaderTemplateIdx;

	[Token(Token = "0x40099E0")]
	[FieldOffset(Offset = "0x28")]
	public readonly string k_TweenFadeIn;

	[Token(Token = "0x40099E1")]
	[FieldOffset(Offset = "0x30")]
	public readonly string k_TweenFadeOut;

	[Token(Token = "0x40099E2")]
	[FieldOffset(Offset = "0x38")]
	public readonly string k_TweenOnRecieveFocusScroll;

	[Token(Token = "0x40099E3")]
	[FieldOffset(Offset = "0x40")]
	public readonly InfinityScrollView scrollView;

	[Token(Token = "0x40099E4")]
	[FieldOffset(Offset = "0x48")]
	public readonly ScrollRect scrollRect;

	[Token(Token = "0x40099E5")]
	[FieldOffset(Offset = "0x50")]
	public readonly TMP_Text tabNameText;

	[Token(Token = "0x40099E6")]
	[FieldOffset(Offset = "0x58")]
	private TweenPosition m_TweenOnRecieveFocusScrollPosition;

	[Token(Token = "0x40099E7")]
	[FieldOffset(Offset = "0x60")]
	private RectOffset m_OriginalPadding;

	[Token(Token = "0x40099E8")]
	[FieldOffset(Offset = "0x68")]
	private float m_OriginalSpacing;

	[Token(Token = "0x40099E9")]
	[FieldOffset(Offset = "0x6C")]
	private float m_EntityHeight;

	[Token(Token = "0x170009ED")]
	public GameObject fadeTargetGo
	{
		[Token(Token = "0x6004985")]
		[Address(RVA = "0x920600", Offset = "0x91F800", VA = "0x180920600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004986")]
	[Address(RVA = "0x9204A0", Offset = "0x91F6A0", VA = "0x1809204A0")]
	public MissionListWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004987")]
	[Address(RVA = "0x920180", Offset = "0x91F380", VA = "0x180920180")]
	public void OnInitializedScrollView(Dictionary<GameObject, MissionPanelWidget> panelWidgetsMap)
	{
	}

	[Token(Token = "0x6004988")]
	[Address(RVA = "0x920630", Offset = "0x91F830", VA = "0x180920630")]
	public IEnumerator yPlayFadeIn()
	{
		return null;
	}

	[Token(Token = "0x6004989")]
	[Address(RVA = "0x920640", Offset = "0x91F840", VA = "0x180920640")]
	public IEnumerator yPlayFadeOut()
	{
		return null;
	}

	[Token(Token = "0x600498A")]
	[Address(RVA = "0x920650", Offset = "0x91F850", VA = "0x180920650")]
	[IteratorStateMachine(typeof(_003CyPlayFade_003Ed__18))]
	public IEnumerator yPlayFade(string tweenFadeKey)
	{
		return null;
	}

	[Token(Token = "0x600498B")]
	[Address(RVA = "0x920440", Offset = "0x91F640", VA = "0x180920440")]
	public void SetPlayFocusPanelSpeed(float speed)
	{
	}

	[Token(Token = "0x600498C")]
	[Address(RVA = "0x9206E0", Offset = "0x91F8E0", VA = "0x1809206E0")]
	[IteratorStateMachine(typeof(_003CyPlayFocusPanel_003Ed__20))]
	public IEnumerator yPlayFocusPanel(int idx)
	{
		return null;
	}
}
