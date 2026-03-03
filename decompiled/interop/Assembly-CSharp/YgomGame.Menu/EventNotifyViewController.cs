using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu;

[Token(Token = "0x200116C")]
public class EventNotifyViewController : InformDialogViewControllerBase<string[], Action>
{
	[Token(Token = "0x200116D")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B70F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventNotifyViewController _003C_003E4__this;

		[Token(Token = "0x400B712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003CpastSec_003E5__2;

		[Token(Token = "0x400B713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _003ClastShowSec_003E5__3;

		[Token(Token = "0x400B714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _003ClastHideSec_003E5__4;

		[Token(Token = "0x400B715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Queue<(float, GameObject)> _003CshowQueue_003E5__5;

		[Token(Token = "0x17001144")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006D52")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001145")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006D54")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006D4F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006D50")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006D51")]
		[Address(RVA = "0xB57000", Offset = "0xB56200", VA = "0x180B57000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006D53")]
		[Address(RVA = "0xB57530", Offset = "0xB56730", VA = "0x180B57530", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B701")]
	private const string k_PrefPath = "Common/EventNotify/EventNotify";

	[Token(Token = "0x400B702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelRootShow;

	[Token(Token = "0x400B703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelRootHide;

	[Token(Token = "0x400B704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelTemplate;

	[Token(Token = "0x400B705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400B706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelShorcutSkip;

	[Token(Token = "0x400B707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[Tooltip("汎用通知の生存時間（各汎用通知がTweenの\"Show\"を呼んでから\"Hide\"を呼ぶまでの時間）")]
	[SerializeField]
	private float m_LifeSecond;

	[Token(Token = "0x400B708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	[Tooltip("汎用通知が連続して表示される時、この秒数だけ次の表示を待つ")]
	[SerializeField]
	private float m_IntervalShowSecond;

	[Token(Token = "0x400B709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[Tooltip("汎用通知が消えた後、この秒数だけ次の表示を待つ")]
	[SerializeField]
	private float m_IntervalHideSecond;

	[Token(Token = "0x400B70A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	[Tooltip("画面に映る汎用通知の最大数")]
	[SerializeField]
	private int m_MaxDisp;

	[Token(Token = "0x400B70B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject m_RootShow;

	[Token(Token = "0x400B70C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject m_RootHide;

	[Token(Token = "0x400B70D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Queue<GameObject> m_HideQueue;

	[Token(Token = "0x400B70E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool m_IsSkip;

	[Token(Token = "0x6006D49")]
	[Address(RVA = "0xB4D810", Offset = "0xB4CA10", VA = "0x180B4D810")]
	public static void Open(string[] messages, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6006D4A")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006D4B")]
	[Address(RVA = "0xB4D4F0", Offset = "0xB4C6F0", VA = "0x180B4D4F0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006D4C")]
	[Address(RVA = "0xB4D880", Offset = "0xB4CA80", VA = "0x180B4D880")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__17))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6006D4D")]
	[Address(RVA = "0xB4D900", Offset = "0xB4CB00", VA = "0x180B4D900")]
	public EventNotifyViewController()
	{
	}
}
