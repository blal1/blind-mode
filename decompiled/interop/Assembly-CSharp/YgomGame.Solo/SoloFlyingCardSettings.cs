using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Solo;

[Token(Token = "0x200088B")]
[CreateAssetMenu(menuName = "Scriptable Object/SoloFlyingCardSettings")]
public class SoloFlyingCardSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200088C")]
	public class MrkList
	{
		[Token(Token = "0x200088D")]
		[CompilerGenerated]
		private sealed class _003CGetRandomMrkFromList_003Ed__4 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40086B7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40086B8")]
			[FieldOffset(Offset = "0x14")]
			private int _003C_003E2__current;

			[Token(Token = "0x40086B9")]
			[FieldOffset(Offset = "0x18")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40086BA")]
			[FieldOffset(Offset = "0x20")]
			public MrkList _003C_003E4__this;

			[Token(Token = "0x40086BB")]
			[FieldOffset(Offset = "0x28")]
			private int quantity;

			[Token(Token = "0x40086BC")]
			[FieldOffset(Offset = "0x2C")]
			public int _003C_003E3__quantity;

			[Token(Token = "0x40086BD")]
			[FieldOffset(Offset = "0x30")]
			private List<int> _003CremainMrkList_003E5__2;

			[Token(Token = "0x40086BE")]
			[FieldOffset(Offset = "0x38")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x17000662")]
			private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
			{
				[Token(Token = "0x60033B8")]
				[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000663")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60033BA")]
				[Address(RVA = "0x778F30", Offset = "0x778130", VA = "0x180778F30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60033B5")]
			[Address(RVA = "0x778F60", Offset = "0x778160", VA = "0x180778F60")]
			[DebuggerHidden]
			public _003CGetRandomMrkFromList_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60033B6")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60033B7")]
			[Address(RVA = "0x778D20", Offset = "0x777F20", VA = "0x180778D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60033B9")]
			[Address(RVA = "0x778EF0", Offset = "0x7780F0", VA = "0x180778EF0", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60033BB")]
			[Address(RVA = "0x778E40", Offset = "0x778040", VA = "0x180778E40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60033BC")]
			[Address(RVA = "0x778E40", Offset = "0x778040", VA = "0x180778E40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40086B6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<int> mrkList;

		[Token(Token = "0x60033AF")]
		[Address(RVA = "0x7690B0", Offset = "0x7682B0", VA = "0x1807690B0")]
		private bool Contains(int mrk)
		{
			return default(bool);
		}

		[Token(Token = "0x60033B0")]
		[Address(RVA = "0x768F90", Offset = "0x768190", VA = "0x180768F90")]
		public void Add(int mrk)
		{
		}

		[Token(Token = "0x60033B1")]
		[Address(RVA = "0x769110", Offset = "0x768310", VA = "0x180769110")]
		public List<int> GetListCopy()
		{
			return null;
		}

		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x7692C0", Offset = "0x7684C0", VA = "0x1807692C0")]
		[IteratorStateMachine(typeof(_003CGetRandomMrkFromList_003Ed__4))]
		public IEnumerable<int> GetRandomMrkFromList(int quantity = 10)
		{
			return null;
		}

		[Token(Token = "0x60033B3")]
		[Address(RVA = "0x769060", Offset = "0x768260", VA = "0x180769060")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x60033B4")]
		[Address(RVA = "0x769340", Offset = "0x768540", VA = "0x180769340")]
		public MrkList()
		{
		}
	}

	[Token(Token = "0x200088E")]
	public enum Format
	{
		[Token(Token = "0x40086C0")]
		SOLO_TUTORIAL,
		[Token(Token = "0x40086C1")]
		SOLO_NORMAL
	}

	[Token(Token = "0x40086B4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MrkList soloTutorialMrkList;

	[Token(Token = "0x40086B5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MrkList soloNormalMrkList;

	[Token(Token = "0x60033AD")]
	[Address(RVA = "0x76B290", Offset = "0x76A490", VA = "0x18076B290")]
	public MrkList GetMrkList(Format format)
	{
		return null;
	}

	[Token(Token = "0x60033AE")]
	[Address(RVA = "0x76B2B0", Offset = "0x76A4B0", VA = "0x18076B2B0")]
	public SoloFlyingCardSettings()
	{
	}
}
