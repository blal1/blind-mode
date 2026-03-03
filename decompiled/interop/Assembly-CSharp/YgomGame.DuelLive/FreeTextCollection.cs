using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F4E")]
public class FreeTextCollection
{
	[Token(Token = "0x2000F4F")]
	public class Entry
	{
		[Token(Token = "0x400A76E")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x400A76F")]
		[FieldOffset(Offset = "0x18")]
		public int templateIndex;

		[Token(Token = "0x400A770")]
		[FieldOffset(Offset = "0x20")]
		public ElementObjectManager eom;

		[Token(Token = "0x6005D11")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Entry()
		{
		}
	}

	[Token(Token = "0x2000F50")]
	[CompilerGenerated]
	private sealed class _003CCreateTemplates_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A771")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A772")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A773")]
		[FieldOffset(Offset = "0x20")]
		public FreeTextCollection _003C_003E4__this;

		[Token(Token = "0x400A774")]
		[FieldOffset(Offset = "0x28")]
		public int indexOffset;

		[Token(Token = "0x400A775")]
		[FieldOffset(Offset = "0x30")]
		public GameObject original;

		[Token(Token = "0x400A776")]
		[FieldOffset(Offset = "0x38")]
		public GameObject parent;

		[Token(Token = "0x17000EA7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005D15")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EA8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005D17")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D12")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCreateTemplates_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005D13")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005D14")]
		[Address(RVA = "0xA2B830", Offset = "0xA2AA30", VA = "0x180A2B830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005D16")]
		[Address(RVA = "0xA2BE20", Offset = "0xA2B020", VA = "0x180A2BE20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000F51")]
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__8 : IEnumerator<Entry>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A777")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A778")]
		[FieldOffset(Offset = "0x18")]
		private Entry _003C_003E2__current;

		[Token(Token = "0x400A779")]
		[FieldOffset(Offset = "0x20")]
		public FreeTextCollection _003C_003E4__this;

		[Token(Token = "0x400A77A")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Entry>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000EA9")]
		private Entry System_002ECollections_002EGeneric_002EIEnumerator_003CYgomGame_002EDuelLive_002EFreeTextCollection_002EEntry_003E_002ECurrent
		{
			[Token(Token = "0x6005D1C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EAA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005D1E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D18")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005D19")]
		[Address(RVA = "0xA2C080", Offset = "0xA2B280", VA = "0x180A2C080", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005D1A")]
		[Address(RVA = "0xA2BE60", Offset = "0xA2B060", VA = "0x180A2BE60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005D1B")]
		[Address(RVA = "0xA2C110", Offset = "0xA2B310", VA = "0x180A2C110")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6005D1D")]
		[Address(RVA = "0xA2C040", Offset = "0xA2B240", VA = "0x180A2C040", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A76D")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Entry> m_textEntries;

	[Token(Token = "0x17000EA6")]
	public int dataCount
	{
		[Token(Token = "0x6005D0B")]
		[Address(RVA = "0xA1E110", Offset = "0xA1D310", VA = "0x180A1E110")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005D0A")]
	[Address(RVA = "0xA1DDF0", Offset = "0xA1CFF0", VA = "0x180A1DDF0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005D0C")]
	[Address(RVA = "0xA1DF70", Offset = "0xA1D170", VA = "0x180A1DF70")]
	public int GetTextTemplateIndex(string text)
	{
		return default(int);
	}

	[Token(Token = "0x6005D0D")]
	[Address(RVA = "0xA1E010", Offset = "0xA1D210", VA = "0x180A1E010")]
	public void RegisterText(string text)
	{
	}

	[Token(Token = "0x6005D0E")]
	[Address(RVA = "0xA1DE40", Offset = "0xA1D040", VA = "0x180A1DE40")]
	[IteratorStateMachine(typeof(_003CCreateTemplates_003Ed__7))]
	public IEnumerator CreateTemplates(GameObject original, GameObject parent, int indexOffset)
	{
		return null;
	}

	[Token(Token = "0x6005D0F")]
	[Address(RVA = "0xA1DF00", Offset = "0xA1D100", VA = "0x180A1DF00")]
	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__8))]
	public IEnumerator<Entry> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6005D10")]
	[Address(RVA = "0xA1E090", Offset = "0xA1D290", VA = "0x180A1E090")]
	public FreeTextCollection()
	{
	}
}
