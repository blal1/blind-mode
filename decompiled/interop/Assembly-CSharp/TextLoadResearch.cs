using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

[Token(Token = "0x200000D")]
public class TextLoadResearch : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class _003CExec_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x20")]
		public TextLoadResearch _003C_003E4__this;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000001")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CExec_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3E7EB0", Offset = "0x3E70B0", VA = "0x1803E7EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3E94A0", Offset = "0x3E86A0", VA = "0x1803E94A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		public TextLoadResearch _003C_003E4__this;

		[Token(Token = "0x17000003")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3EA540", Offset = "0x3E9740", VA = "0x1803EA540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3EA710", Offset = "0x3E9910", VA = "0x1803EA710", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager _eom;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x28")]
	private Text _msg;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder _buffer;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3E64F0", Offset = "0x3E56F0", VA = "0x1803E64F0")]
	private void AddLine(string text)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3E6700", Offset = "0x3E5900", VA = "0x1803E6700")]
	private void TextClear()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3E6580", Offset = "0x3E5780", VA = "0x1803E6580")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3E6690", Offset = "0x3E5890", VA = "0x1803E6690")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__6))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	private void Measure<T>()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3E6620", Offset = "0x3E5820", VA = "0x1803E6620")]
	[IteratorStateMachine(typeof(_003CExec_003Ed__8))]
	private IEnumerator Exec()
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x3E6770", Offset = "0x3E5970", VA = "0x1803E6770")]
	public TextLoadResearch()
	{
	}
}
