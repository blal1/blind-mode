using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu;

[Token(Token = "0x2001383")]
public class StructureDeckObtainViewController : InformDialogViewControllerBase<int, Action>
{
	[Token(Token = "0x2001384")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C241")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C242")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C243")]
		[FieldOffset(Offset = "0x20")]
		public StructureDeckObtainViewController _003C_003E4__this;

		[Token(Token = "0x170012B6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600792D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012B7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600792F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600792A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600792B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600792C")]
		[Address(RVA = "0xC28390", Offset = "0xC27590", VA = "0x180C28390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600792E")]
		[Address(RVA = "0xC28600", Offset = "0xC27800", VA = "0x180C28600", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C23D")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private float m_AlphaMessageWaitSec;

	[Token(Token = "0x400C23E")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelDeckBox;

	[Token(Token = "0x400C23F")]
	[FieldOffset(Offset = "0xF0")]
	private StructureBoxWidget m_DeckWidget;

	[Token(Token = "0x400C240")]
	private const string ANDROID_BACK_KEY_LABEL = "AndroidBackKey";

	[Token(Token = "0x170012B3")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007921")]
		[Address(RVA = "0xC24920", Offset = "0xC23B20", VA = "0x180C24920", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012B4")]
	protected override int arg1
	{
		[Token(Token = "0x6007922")]
		[Address(RVA = "0xC247F0", Offset = "0xC239F0", VA = "0x180C247F0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170012B5")]
	protected override Action arg2
	{
		[Token(Token = "0x6007923")]
		[Address(RVA = "0xC24860", Offset = "0xC23A60", VA = "0x180C24860", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007924")]
	[Address(RVA = "0xC245B0", Offset = "0xC237B0", VA = "0x180C245B0")]
	public static void Open(int structureDeckId, Action callback)
	{
	}

	[Token(Token = "0x6007925")]
	[Address(RVA = "0xC244B0", Offset = "0xC236B0", VA = "0x180C244B0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007926")]
	[Address(RVA = "0xC24620", Offset = "0xC23820", VA = "0x180C24620")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__12))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6007927")]
	[Address(RVA = "0xC24780", Offset = "0xC23980", VA = "0x180C24780")]
	public StructureDeckObtainViewController()
	{
	}
}
