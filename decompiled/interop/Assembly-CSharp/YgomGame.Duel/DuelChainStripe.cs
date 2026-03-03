using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A0E")]
public class DuelChainStripe : MonoBehaviour
{
	[Token(Token = "0x2001A11")]
	[CompilerGenerated]
	private sealed class _003CAddChainUnit_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F07D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F07E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F07F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelChainStripe _003C_003E4__this;

		[Token(Token = "0x400F080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int chainid;

		[Token(Token = "0x400F081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform chainunit;

		[Token(Token = "0x400F082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float targetlength;

		[Token(Token = "0x400F083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _003Cunitlength_003E5__2;

		[Token(Token = "0x400F084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _003Ccurrentdist_003E5__3;

		[Token(Token = "0x170019F4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A87C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019F5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A87E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A879")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAddChainUnit_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A87A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A87B")]
		[Address(RVA = "0xF5E8C0", Offset = "0xF5DAC0", VA = "0x180F5E8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A87D")]
		[Address(RVA = "0xF5EC70", Offset = "0xF5DE70", VA = "0x180F5EC70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001A12")]
	[CompilerGenerated]
	private sealed class _003CRemoveChainUnit_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelChainStripe _003C_003E4__this;

		[Token(Token = "0x400F088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int chainid;

		[Token(Token = "0x400F089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Stack<Transform> _003Cchainstack_003E5__2;

		[Token(Token = "0x170019F6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A882")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019F7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A884")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A87F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CRemoveChainUnit_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A880")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A881")]
		[Address(RVA = "0xF5FF20", Offset = "0xF5F120", VA = "0x180F5FF20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A883")]
		[Address(RVA = "0xF60230", Offset = "0xF5F430", VA = "0x180F60230", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400F070")]
	private const float DELTATIME = 0.25f;

	[Token(Token = "0x400F071")]
	private const float MINFLOAT = 0.0001f;

	[Token(Token = "0x400F072")]
	private const float UNITLENGTH = 0.75f;

	[Token(Token = "0x400F073")]
	private const string PATH_PREHAB = "Duel/Effects/Chain/fxp_chn_001/fxp_chn_001";

	[Token(Token = "0x400F074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_ChainUnitPrehab;

	[Token(Token = "0x400F075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform m_ShowPool;

	[Token(Token = "0x400F076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform m_HidePool;

	[Token(Token = "0x400F077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Stack<int> m_ChainIdStack;

	[Token(Token = "0x400F078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Stack<Transform> m_IdolChainUnitStack;

	[Token(Token = "0x400F079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<int, ChainIndo> m_ChainInfoTable;

	[Token(Token = "0x600A86C")]
	[Address(RVA = "0xF498A0", Offset = "0xF48AA0", VA = "0x180F498A0")]
	public static DuelChainStripe Create(DuelChainManager dcmanager)
	{
		return null;
	}

	[Token(Token = "0x600A86D")]
	[Address(RVA = "0xF492C0", Offset = "0xF484C0", VA = "0x180F492C0")]
	public int AddChain(Vector3 srcpos, Vector3 dstpos, [Optional] Action<int> onfinish)
	{
		return default(int);
	}

	[Token(Token = "0x600A86E")]
	[Address(RVA = "0xF49E70", Offset = "0xF49070", VA = "0x180F49E70")]
	public int RemoveChain()
	{
		return default(int);
	}

	[Token(Token = "0x600A86F")]
	[Address(RVA = "0xF49210", Offset = "0xF48410", VA = "0x180F49210")]
	[IteratorStateMachine(typeof(_003CAddChainUnit_003Ed__13))]
	private IEnumerator AddChainUnit(int chainid, Transform chainunit, float targetlength)
	{
		return null;
	}

	[Token(Token = "0x600A870")]
	[Address(RVA = "0xF49DF0", Offset = "0xF48FF0", VA = "0x180F49DF0")]
	[IteratorStateMachine(typeof(_003CRemoveChainUnit_003Ed__14))]
	private IEnumerator RemoveChainUnit(int chainid)
	{
		return null;
	}

	[Token(Token = "0x600A871")]
	[Address(RVA = "0xF49B80", Offset = "0xF48D80", VA = "0x180F49B80")]
	private void HideChainUnit(Transform chainunit)
	{
	}

	[Token(Token = "0x600A872")]
	[Address(RVA = "0xF499A0", Offset = "0xF48BA0", VA = "0x180F499A0")]
	private Transform GetAvailableChainUnit()
	{
		return null;
	}

	[Token(Token = "0x600A873")]
	[Address(RVA = "0xF49BF0", Offset = "0xF48DF0", VA = "0x180F49BF0")]
	private void PlayTransTween(Transform chainhead, float duration, float trans, [Optional] Action onfinished)
	{
	}

	[Token(Token = "0x600A874")]
	[Address(RVA = "0xF4A020", Offset = "0xF49220", VA = "0x180F4A020")]
	public DuelChainStripe()
	{
	}
}
