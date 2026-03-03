using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E7C")]
public class DuelPreviewTask_SpawnPref : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E7D")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A363")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A364")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A365")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_SpawnPref _003C_003E4__this;

		[Token(Token = "0x17000D5B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005783")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D5C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005785")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005780")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005781")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005782")]
		[Address(RVA = "0x9C3AA0", Offset = "0x9C2CA0", VA = "0x1809C3AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005784")]
		[Address(RVA = "0x9C3BC0", Offset = "0x9C2DC0", VA = "0x1809C3BC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E7E")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A366")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A367")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A368")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_SpawnPref _003C_003E4__this;

		[Token(Token = "0x17000D5D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005789")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D5E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600578B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005786")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005787")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005788")]
		[Address(RVA = "0x9CC1E0", Offset = "0x9CB3E0", VA = "0x1809CC1E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600578A")]
		[Address(RVA = "0x9CC360", Offset = "0x9CB560", VA = "0x1809CC360", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A362")]
	[FieldOffset(Offset = "0x20")]
	private string m_PrefPath;

	[Token(Token = "0x17000D57")]
	private string prefLabel
	{
		[Token(Token = "0x6005779")]
		[Address(RVA = "0x9B7EE0", Offset = "0x9B70E0", VA = "0x1809B7EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D58")]
	private Vector3 pos
	{
		[Token(Token = "0x600577A")]
		[Address(RVA = "0x9B8B70", Offset = "0x9B7D70", VA = "0x1809B8B70")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000D59")]
	private Vector3 rotate
	{
		[Token(Token = "0x600577B")]
		[Address(RVA = "0x9B8BB0", Offset = "0x9B7DB0", VA = "0x1809B8BB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000D5A")]
	private Vector3 scale
	{
		[Token(Token = "0x600577C")]
		[Address(RVA = "0x9B8BF0", Offset = "0x9B7DF0", VA = "0x1809B8BF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x600577D")]
	[Address(RVA = "0x9B8E90", Offset = "0x9B8090", VA = "0x1809B8E90", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__9))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x600577E")]
	[Address(RVA = "0x9B8E20", Offset = "0x9B8020", VA = "0x1809B8E20", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__10))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x600577F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_SpawnPref()
	{
	}
}
