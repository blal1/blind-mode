using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Certification;

[Token(Token = "0x20014D6")]
public class CertificationWritingReslutViewController : BaseMenuViewController
{
	[Token(Token = "0x20014D9")]
	[CompilerGenerated]
	private sealed class _003CShowTween_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C8C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C8C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C8C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CertificationWritingReslutViewController _003C_003E4__this;

		[Token(Token = "0x170013C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600812C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600812E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008129")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShowTween_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600812A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600812B")]
		[Address(RVA = "0xC99800", Offset = "0xC98A00", VA = "0x180C99800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600812D")]
		[Address(RVA = "0xC99B90", Offset = "0xC98D90", VA = "0x180C99B90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C8A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string BUTTON_EXIT_LABEL;

	[Token(Token = "0x400C8A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string BUTTON_REPLAY_LABEL;

	[Token(Token = "0x400C8A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string BUTTON_EXPLANATION_LABEL;

	[Token(Token = "0x400C8A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string FOOTER_AREA_LABEL;

	[Token(Token = "0x400C8A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string L_ResultSuccess;

	[Token(Token = "0x400C8A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string L_ResultFailed;

	[Token(Token = "0x400C8A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string L_ResultText;

	[Token(Token = "0x400C8A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string L_Success;

	[Token(Token = "0x400C8A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string L_Failed;

	[Token(Token = "0x400C8AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject resultSuccess;

	[Token(Token = "0x400C8AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject resultFailed;

	[Token(Token = "0x400C8AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ExtendedTextMeshProUGUI resultText;

	[Token(Token = "0x400C8AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool isSuccess;

	[Token(Token = "0x400C8AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private CertificationMateViewer mateViewer;

	[Token(Token = "0x400C8AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ElementObjectManager mainEOM;

	[Token(Token = "0x400C8B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ElementObjectManager footerEOM;

	[Token(Token = "0x400C8B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private ElementObjectManager btnReplay;

	[Token(Token = "0x400C8B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private int correctAnswerNum;

	[Token(Token = "0x400C8B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private int gradeIndex;

	[Token(Token = "0x400C8B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private bool progressUpdate;

	[Token(Token = "0x400C8B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private int totalQuestionNum;

	[Token(Token = "0x400C8B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private int requireNum;

	[Token(Token = "0x400C8B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private List<object> answerIdxList;

	[Token(Token = "0x400C8B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private List<int> answerIdxIntList;

	[Token(Token = "0x400C8B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Coroutine coroutine;

	[Token(Token = "0x170013C6")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600810B")]
		[Address(RVA = "0xC95FB0", Offset = "0xC951B0", VA = "0x180C95FB0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013C7")]
	private bool isReadyMate
	{
		[Token(Token = "0x600810C")]
		[Address(RVA = "0xC95F20", Offset = "0xC95120", VA = "0x180C95F20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170013C8")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600810D")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600810E")]
	[Address(RVA = "0xC943E0", Offset = "0xC935E0", VA = "0x180C943E0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600810F")]
	[Address(RVA = "0xC94AC0", Offset = "0xC93CC0", VA = "0x180C94AC0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008110")]
	[Address(RVA = "0xC94F40", Offset = "0xC94140", VA = "0x180C94F40", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6008111")]
	[Address(RVA = "0xC94210", Offset = "0xC93410", VA = "0x180C94210")]
	private void InitData()
	{
	}

	[Token(Token = "0x6008112")]
	[Address(RVA = "0xC94E70", Offset = "0xC94070", VA = "0x180C94E70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008113")]
	[Address(RVA = "0xC957F0", Offset = "0xC949F0", VA = "0x180C957F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6008114")]
	[Address(RVA = "0xC950A0", Offset = "0xC942A0", VA = "0x180C950A0")]
	private void SetElements()
	{
	}

	[Token(Token = "0x6008115")]
	[Address(RVA = "0xC95A50", Offset = "0xC94C50", VA = "0x180C95A50")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6008116")]
	[Address(RVA = "0xC95780", Offset = "0xC94980", VA = "0x180C95780")]
	[IteratorStateMachine(typeof(_003CShowTween_003Ed__39))]
	private IEnumerator ShowTween()
	{
		return null;
	}

	[Token(Token = "0x6008117")]
	[Address(RVA = "0xC95420", Offset = "0xC94620", VA = "0x180C95420")]
	private void SetMate()
	{
	}

	[Token(Token = "0x6008118")]
	[Address(RVA = "0xC94B70", Offset = "0xC93D70", VA = "0x180C94B70")]
	private void OnClickExit()
	{
	}

	[Token(Token = "0x6008119")]
	[Address(RVA = "0xC94D00", Offset = "0xC93F00", VA = "0x180C94D00")]
	private void OnClickReplay()
	{
	}

	[Token(Token = "0x600811A")]
	[Address(RVA = "0xC94C20", Offset = "0xC93E20", VA = "0x180C94C20")]
	private void OnClickExplanation()
	{
	}

	[Token(Token = "0x600811B")]
	[Address(RVA = "0xC940F0", Offset = "0xC932F0", VA = "0x180C940F0")]
	private void CallApi([Optional] Action onComplited)
	{
	}

	[Token(Token = "0x600811C")]
	[Address(RVA = "0xC95CB0", Offset = "0xC94EB0", VA = "0x180C95CB0")]
	public CertificationWritingReslutViewController()
	{
	}
}
