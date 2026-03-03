using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001419")]
[RequireComponent(typeof(RawImage))]
public class BindingCardMaterial : BindingAsyncBase
{
	[Token(Token = "0x200141A")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x400C513")]
		[FieldOffset(Offset = "0x10")]
		public BindingCardMaterial _003C_003E4__this;

		[Token(Token = "0x400C514")]
		[FieldOffset(Offset = "0x18")]
		public int loadingCnt;

		[Token(Token = "0x6007D04")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x6007D05")]
		[Address(RVA = "0xC674E0", Offset = "0xC666E0", VA = "0x180C674E0")]
		internal void _003CyBindingRoutine_003Eb__0()
		{
		}

		[Token(Token = "0x6007D06")]
		[Address(RVA = "0xC67590", Offset = "0xC66790", VA = "0x180C67590")]
		internal void _003CyBindingRoutine_003Eb__1()
		{
		}

		[Token(Token = "0x6007D07")]
		[Address(RVA = "0xC675E0", Offset = "0xC667E0", VA = "0x180C675E0")]
		internal void _003CyBindingRoutine_003Eb__2()
		{
		}
	}

	[Token(Token = "0x200141B")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C515")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C516")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C517")]
		[FieldOffset(Offset = "0x20")]
		public BindingCardMaterial _003C_003E4__this;

		[Token(Token = "0x400C518")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

		[Token(Token = "0x17001323")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007D0B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001324")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007D0D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007D08")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007D09")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007D0A")]
		[Address(RVA = "0xC685C0", Offset = "0xC677C0", VA = "0x180C685C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007D0C")]
		[Address(RVA = "0xC68900", Offset = "0xC67B00", VA = "0x180C68900", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C50F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_CardId;

	[Token(Token = "0x400C510")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int m_RareId;

	[Token(Token = "0x400C511")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsMonochrome;

	[Token(Token = "0x400C512")]
	[FieldOffset(Offset = "0x40")]
	private RawImage m_TargetCache;

	[Token(Token = "0x1700131F")]
	public int cardId
	{
		[Token(Token = "0x6007CF7")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007CF8")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001320")]
	public int pRareType
	{
		[Token(Token = "0x6007CF9")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007CFA")]
		[Address(RVA = "0x9941B0", Offset = "0x9933B0", VA = "0x1809941B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001321")]
	public bool isMonochrome
	{
		[Token(Token = "0x6007CFB")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007CFC")]
		[Address(RVA = "0xC565D0", Offset = "0xC557D0", VA = "0x180C565D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001322")]
	private RawImage target
	{
		[Token(Token = "0x6007CFD")]
		[Address(RVA = "0xC56540", Offset = "0xC55740", VA = "0x180C56540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007CFE")]
	[Address(RVA = "0xC56290", Offset = "0xC55490", VA = "0x180C56290")]
	private bool IsReleasedResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CFF")]
	[Address(RVA = "0xC56130", Offset = "0xC55330", VA = "0x180C56130")]
	public static BindingCardMaterial Binding(RawImage target, int cardId, int pRareType = 1)
	{
		return null;
	}

	[Token(Token = "0x6007D00")]
	[Address(RVA = "0xC56610", Offset = "0xC55810", VA = "0x180C56610", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__17))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007D01")]
	[Address(RVA = "0xC564B0", Offset = "0xC556B0", VA = "0x180C564B0")]
	private void SetMatMonochrome(bool isMonochrome)
	{
	}

	[Token(Token = "0x6007D02")]
	[Address(RVA = "0xC56310", Offset = "0xC55510", VA = "0x180C56310", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007D03")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BindingCardMaterial()
	{
	}
}
