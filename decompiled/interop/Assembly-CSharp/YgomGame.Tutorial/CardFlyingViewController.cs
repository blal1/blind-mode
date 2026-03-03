using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using YgomGame.Menu;
using YgomGame.Solo;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.YGomTMPro;

namespace YgomGame.Tutorial;

[Token(Token = "0x200079B")]
public class CardFlyingViewController : BaseMenuViewController
{
	[Token(Token = "0x200079F")]
	[CompilerGenerated]
	private sealed class _003CShowTelopRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002619")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400261A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400261B")]
		[FieldOffset(Offset = "0x20")]
		public IList<string> messages;

		[Token(Token = "0x400261C")]
		[FieldOffset(Offset = "0x28")]
		public CardFlyingViewController _003C_003E4__this;

		[Token(Token = "0x400261D")]
		[FieldOffset(Offset = "0x30")]
		private GameObject _003Ctarget_003E5__2;

		[Token(Token = "0x400261E")]
		[FieldOffset(Offset = "0x38")]
		private ExtendedTextMeshProUGUI _003Ctext_003E5__3;

		[Token(Token = "0x400261F")]
		[FieldOffset(Offset = "0x40")]
		private ElementObject _003CmsgObj_003E5__4;

		[Token(Token = "0x4002620")]
		[FieldOffset(Offset = "0x48")]
		private int _003Ci_003E5__5;

		[Token(Token = "0x1700062B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60031CC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60031CE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60031C9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShowTelopRoutine_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60031CB")]
		[Address(RVA = "0x75A760", Offset = "0x759960", VA = "0x18075A760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60031CD")]
		[Address(RVA = "0x75ACF0", Offset = "0x759EF0", VA = "0x18075ACF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002607")]
	private const string PATH = "Tutorial/CardFlying";

	[Token(Token = "0x4002608")]
	private const string TWEEN_LABEL_SHOW = "Show";

	[Token(Token = "0x4002609")]
	private const string TWEEN_LABEL_HIDE = "Hide";

	[Token(Token = "0x400260A")]
	private const string ELEOBJ_LABEL_MSG = "Message";

	[Token(Token = "0x400260B")]
	private const string ARGS_KEY_TEXTLIST = "TextList";

	[Token(Token = "0x400260C")]
	private const string ARGS_KEY_FINISHCALLBACK = "onFinish";

	[Token(Token = "0x400260D")]
	private const string ARGS_KEY_AUTOMODE = "AutoMode";

	[Token(Token = "0x400260E")]
	private const string ANDROID_BACK_KEY_LABEL = "AndroidBackKey";

	[Token(Token = "0x400260F")]
	[FieldOffset(Offset = "0xD0")]
	private ElementObjectManager _ui;

	[Token(Token = "0x4002610")]
	[FieldOffset(Offset = "0xD8")]
	private SoloFlyingCardSettings _flyingCardSetting;

	[Token(Token = "0x4002611")]
	[FieldOffset(Offset = "0xE0")]
	private LabeledPlayableController _labelCtrl;

	[Token(Token = "0x4002612")]
	[FieldOffset(Offset = "0x0")]
	private static PlayableDirector _director;

	[Token(Token = "0x1700062A")]
	public static PlayableDirector bgDirector
	{
		[Token(Token = "0x60031BB")]
		[Address(RVA = "0x74E110", Offset = "0x74D310", VA = "0x18074E110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60031BC")]
	[Address(RVA = "0x74DFF0", Offset = "0x74D1F0", VA = "0x18074DFF0")]
	public static void Start(IList<string> msgList, UnityAction onFinish)
	{
	}

	[Token(Token = "0x60031BD")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60031BE")]
	[Address(RVA = "0x74D580", Offset = "0x74C780", VA = "0x18074D580")]
	public void OnBlackoutEnd()
	{
	}

	[Token(Token = "0x60031BF")]
	[Address(RVA = "0x74D680", Offset = "0x74C880", VA = "0x18074D680", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60031C0")]
	[Address(RVA = "0x74D990", Offset = "0x74CB90", VA = "0x18074D990")]
	private void StartTimeline()
	{
	}

	[Token(Token = "0x60031C1")]
	[Address(RVA = "0x74D900", Offset = "0x74CB00", VA = "0x18074D900")]
	[IteratorStateMachine(typeof(_003CShowTelopRoutine_003Ed__19))]
	private IEnumerator ShowTelopRoutine(IList<string> messages)
	{
		return null;
	}

	[Token(Token = "0x60031C2")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public CardFlyingViewController()
	{
	}
}
