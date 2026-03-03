using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001797")]
public class DuelEntryTagEntity
{
	[Token(Token = "0x2001799")]
	[CompilerGenerated]
	private sealed class _003CCreateContent2_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DD6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DD6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DD6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelEntryTagEntity _003C_003E4__this;

		[Token(Token = "0x170016A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009491")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009493")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600948E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCreateContent2_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600948F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009490")]
		[Address(RVA = "0xDEE810", Offset = "0xDEDA10", VA = "0x180DEE810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009492")]
		[Address(RVA = "0xDEE8B0", Offset = "0xDEDAB0", VA = "0x180DEE8B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200179A")]
	[CompilerGenerated]
	private sealed class _003CCreateTag_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DD6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DD6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DD6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelEntryTagEntity _003C_003E4__this;

		[Token(Token = "0x400DD70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170016AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009497")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009499")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009494")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCreateTag_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009495")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009496")]
		[Address(RVA = "0xDEE8F0", Offset = "0xDEDAF0", VA = "0x180DEE8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009498")]
		[Address(RVA = "0xDEEAD0", Offset = "0xDEDCD0", VA = "0x180DEEAD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DD5D")]
	private const int m_PreLoadNum = 20;

	[Token(Token = "0x400DD5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int m_TaginContent;

	[Token(Token = "0x400DD5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int m_ListIndex;

	[Token(Token = "0x400DD60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_TemplateIndex;

	[Token(Token = "0x400DD61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int m_TemplateMax;

	[Token(Token = "0x400DD62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_FadeValue;

	[Token(Token = "0x400DD63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<object> m_List;

	[Token(Token = "0x400DD64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400DD65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_Content;

	[Token(Token = "0x400DD66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private DuelEntryTagContainer m_Owner;

	[Token(Token = "0x400DD67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Action onCreateContent;

	[Token(Token = "0x6009481")]
	[Address(RVA = "0xDE3A30", Offset = "0xDE2C30", VA = "0x180DE3A30")]
	public DuelEntryTagEntity(ElementObjectManager eom, List<object> list, int tagNum, float fadeValue = 0.75f, [Optional] DuelEntryTagContainer owner)
	{
	}

	[Token(Token = "0x6009482")]
	[Address(RVA = "0xDE3510", Offset = "0xDE2710", VA = "0x180DE3510")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6009483")]
	[Address(RVA = "0xDE2D20", Offset = "0xDE1F20", VA = "0x180DE2D20")]
	public void CreateContent()
	{
	}

	[Token(Token = "0x6009484")]
	[Address(RVA = "0xDE2CB0", Offset = "0xDE1EB0", VA = "0x180DE2CB0")]
	[IteratorStateMachine(typeof(_003CCreateContent2_003Ed__14))]
	private IEnumerator CreateContent2()
	{
		return null;
	}

	[Token(Token = "0x6009485")]
	[Address(RVA = "0xDE2DB0", Offset = "0xDE1FB0", VA = "0x180DE2DB0")]
	[IteratorStateMachine(typeof(_003CCreateTag_003Ed__15))]
	private IEnumerator CreateTag()
	{
		return null;
	}

	[Token(Token = "0x6009486")]
	[Address(RVA = "0xDE31F0", Offset = "0xDE23F0", VA = "0x180DE31F0")]
	private void DelayCreateTag()
	{
	}

	[Token(Token = "0x6009487")]
	[Address(RVA = "0xDE2FC0", Offset = "0xDE21C0", VA = "0x180DE2FC0")]
	private void DelayCreateNullTag(int index)
	{
	}

	[Token(Token = "0x6009488")]
	[Address(RVA = "0xDE2E20", Offset = "0xDE2020", VA = "0x180DE2E20")]
	private void CreateTag(GameObject obj, string text, bool isFirst = false)
	{
	}
}
