using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200141C")]
public class BindingCoin : BindingAsyncBase, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x200141D")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C51E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C51F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C520")]
		[FieldOffset(Offset = "0x20")]
		public BindingCoin _003C_003E4__this;

		[Token(Token = "0x17001329")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007D1E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700132A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007D20")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007D1B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007D1C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007D1D")]
		[Address(RVA = "0xC68940", Offset = "0xC67B40", VA = "0x180C68940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007D1F")]
		[Address(RVA = "0xC68B30", Offset = "0xC67D30", VA = "0x180C68B30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C519")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_ItemId;

	[Token(Token = "0x400C51A")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private CoinBinder.CoinMode m_CoinMode;

	[Token(Token = "0x400C51B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CoinBinder.CoinScale m_CoinScale;

	[Token(Token = "0x400C51C")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsHead;

	[Token(Token = "0x400C51D")]
	[FieldOffset(Offset = "0x40")]
	private IBinding m_Binding;

	[Token(Token = "0x17001325")]
	public CoinBinder.CoinMode coinMode
	{
		[Token(Token = "0x6007D0E")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(CoinBinder.CoinMode);
		}
		[Token(Token = "0x6007D0F")]
		[Address(RVA = "0xC569F0", Offset = "0xC55BF0", VA = "0x180C569F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001326")]
	public int itemId
	{
		[Token(Token = "0x6007D10")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D11")]
		[Address(RVA = "0xC56B40", Offset = "0xC55D40", VA = "0x180C56B40")]
		set
		{
		}
	}

	[Token(Token = "0x17001327")]
	public CoinBinder.CoinScale coinScale
	{
		[Token(Token = "0x6007D12")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(CoinBinder.CoinScale);
		}
		[Token(Token = "0x6007D13")]
		[Address(RVA = "0xC56A60", Offset = "0xC55C60", VA = "0x180C56A60")]
		set
		{
		}
	}

	[Token(Token = "0x17001328")]
	public bool isHead
	{
		[Token(Token = "0x6007D14")]
		[Address(RVA = "0x994170", Offset = "0x993370", VA = "0x180994170")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007D15")]
		[Address(RVA = "0xC56AD0", Offset = "0xC55CD0", VA = "0x180C56AD0")]
		set
		{
		}
	}

	[Token(Token = "0x6007D16")]
	[Address(RVA = "0xC56680", Offset = "0xC55880", VA = "0x180C56680")]
	public static BindingCoin Binding(Image target, int itemId, CoinBinder.CoinScale coinScale = CoinBinder.CoinScale.Large, CoinBinder.CoinMode coinMode = CoinBinder.CoinMode.None, bool isHead = true)
	{
		return null;
	}

	[Token(Token = "0x6007D17")]
	[Address(RVA = "0xC56810", Offset = "0xC55A10", VA = "0x180C56810")]
	public static BindingCoin Binding(GameObject target, int itemId, CoinBinder.CoinScale coinScale = CoinBinder.CoinScale.Large, CoinBinder.CoinMode coinMode = CoinBinder.CoinMode.None, bool isHead = true)
	{
		return null;
	}

	[Token(Token = "0x6007D18")]
	[Address(RVA = "0xC56BB0", Offset = "0xC55DB0", VA = "0x180C56BB0", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__19))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007D19")]
	[Address(RVA = "0xC56990", Offset = "0xC55B90", VA = "0x180C56990", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007D1A")]
	[Address(RVA = "0xC569E0", Offset = "0xC55BE0", VA = "0x180C569E0")]
	public BindingCoin()
	{
	}
}
