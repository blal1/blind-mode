using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E57")]
public class DuelPreviewTask_PlaySimpleEffect : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E58")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A31E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A31F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A320")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_PlaySimpleEffect _003C_003E4__this;

		[Token(Token = "0x400A321")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CplayRoutine_003E5__2;

		[Token(Token = "0x17000D23")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60056C5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D24")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60056C7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056C2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60056C3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60056C4")]
		[Address(RVA = "0x9C3C00", Offset = "0x9C2E00", VA = "0x1809C3C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60056C6")]
		[Address(RVA = "0x9C4150", Offset = "0x9C3350", VA = "0x1809C4150", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E59")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A322")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A323")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A324")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_PlaySimpleEffect _003C_003E4__this;

		[Token(Token = "0x400A325")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003Croutine_003E5__2;

		[Token(Token = "0x17000D25")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60056CB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D26")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60056CD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056C8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60056C9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60056CA")]
		[Address(RVA = "0x9CBBA0", Offset = "0x9CADA0", VA = "0x1809CBBA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60056CC")]
		[Address(RVA = "0x9CBD10", Offset = "0x9CAF10", VA = "0x1809CBD10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x17000D1C")]
	private string selfLabel
	{
		[Token(Token = "0x60056B8")]
		[Address(RVA = "0x9B8320", Offset = "0x9B7520", VA = "0x1809B8320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D1D")]
	private string targetLabel
	{
		[Token(Token = "0x60056B9")]
		[Address(RVA = "0x9B8390", Offset = "0x9B7590", VA = "0x1809B8390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D1E")]
	private string effectPath
	{
		[Token(Token = "0x60056BA")]
		[Address(RVA = "0x9B8000", Offset = "0x9B7200", VA = "0x1809B8000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D1F")]
	private Vector3 pos
	{
		[Token(Token = "0x60056BB")]
		[Address(RVA = "0x9B8080", Offset = "0x9B7280", VA = "0x1809B8080")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000D20")]
	private Vector3 rotation
	{
		[Token(Token = "0x60056BC")]
		[Address(RVA = "0x9B8160", Offset = "0x9B7360", VA = "0x1809B8160")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000D21")]
	private Vector3 scale
	{
		[Token(Token = "0x60056BD")]
		[Address(RVA = "0x9B8240", Offset = "0x9B7440", VA = "0x1809B8240")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000D22")]
	private bool withSpawnTarget
	{
		[Token(Token = "0x60056BE")]
		[Address(RVA = "0x9B8410", Offset = "0x9B7610", VA = "0x1809B8410")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60056BF")]
	[Address(RVA = "0x9B8470", Offset = "0x9B7670", VA = "0x1809B8470", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__14))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x60056C0")]
	[Address(RVA = "0x9B7F90", Offset = "0x9B7190", VA = "0x1809B7F90", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__15))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x60056C1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_PlaySimpleEffect()
	{
	}
}
