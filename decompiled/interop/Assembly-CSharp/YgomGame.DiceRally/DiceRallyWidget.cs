using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Colosseum;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000FA1")]
public class DiceRallyWidget : MonoBehaviour
{
	[Token(Token = "0x2000FA6")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass192_0
	{
		[Token(Token = "0x400AA10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x400AA11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isDice;

		[Token(Token = "0x6005F0A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass192_0()
		{
		}

		[Token(Token = "0x6005F0B")]
		[Address(RVA = "0xA6C6F0", Offset = "0xA6B8F0", VA = "0x180A6C6F0")]
		internal void _003CyMoveEffect_003Eb__0()
		{
		}

		[Token(Token = "0x6005F0C")]
		[Address(RVA = "0xA6C810", Offset = "0xA6BA10", VA = "0x180A6C810")]
		internal void _003CyMoveEffect_003Eb__1()
		{
		}

		[Token(Token = "0x6005F0D")]
		[Address(RVA = "0xA6C810", Offset = "0xA6BA10", VA = "0x180A6C810")]
		internal void _003CyMoveEffect_003Eb__2()
		{
		}

		[Token(Token = "0x6005F0E")]
		[Address(RVA = "0xA6C830", Offset = "0xA6BA30", VA = "0x180A6C830")]
		internal void _003CyMoveEffect_003Eb__3()
		{
		}

		[Token(Token = "0x6005F0F")]
		[Address(RVA = "0xA6C850", Offset = "0xA6BA50", VA = "0x180A6C850")]
		internal void _003CyMoveEffect_003Eb__4()
		{
		}

		[Token(Token = "0x6005F10")]
		[Address(RVA = "0xA6C870", Offset = "0xA6BA70", VA = "0x180A6C870")]
		internal void _003CyMoveEffect_003Eb__5()
		{
		}

		[Token(Token = "0x6005F11")]
		[Address(RVA = "0xA6C870", Offset = "0xA6BA70", VA = "0x180A6C870")]
		internal void _003CyMoveEffect_003Eb__6()
		{
		}
	}

	[Token(Token = "0x2000FA7")]
	[CompilerGenerated]
	private sealed class _003CyFocusSpace_003Ed__193 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x400AA15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DiceRallySpace space;

		[Token(Token = "0x400AA16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isDice;

		[Token(Token = "0x400AA17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool isFocus;

		[Token(Token = "0x400AA18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool isFirst;

		[Token(Token = "0x400AA19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _003CtargetX_003E5__2;

		[Token(Token = "0x400AA1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _003CtargetY_003E5__3;

		[Token(Token = "0x400AA1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TweenPosition _003CtargetTween_003E5__4;

		[Token(Token = "0x400AA1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TweenPosition _003CtargetTweenMini_003E5__5;

		[Token(Token = "0x17000EEB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F15")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EEC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F17")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F12")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyFocusSpace_003Ed__193(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F13")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F14")]
		[Address(RVA = "0xA6CB10", Offset = "0xA6BD10", VA = "0x180A6CB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F16")]
		[Address(RVA = "0xA6D190", Offset = "0xA6C390", VA = "0x180A6D190", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000FA8")]
	[CompilerGenerated]
	private sealed class _003CyGoalEffect_003Ed__194 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x17000EED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F1B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EEE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F1D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F18")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyGoalEffect_003Ed__194(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F19")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F1A")]
		[Address(RVA = "0xA6D1D0", Offset = "0xA6C3D0", VA = "0x180A6D1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F1C")]
		[Address(RVA = "0xA6D590", Offset = "0xA6C790", VA = "0x180A6D590", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000FA9")]
	[CompilerGenerated]
	private sealed class _003CyInstantiateSpace_003Ed__189 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x400AA23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int order;

		[Token(Token = "0x400AA24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform boardTf;

		[Token(Token = "0x400AA25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int depth;

		[Token(Token = "0x17000EEF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F21")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F23")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F1E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInstantiateSpace_003Ed__189(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F1F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F20")]
		[Address(RVA = "0xA6D5D0", Offset = "0xA6C7D0", VA = "0x180A6D5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F22")]
		[Address(RVA = "0xA6DE10", Offset = "0xA6D010", VA = "0x180A6DE10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000FAA")]
	[CompilerGenerated]
	private sealed class _003CyMoveEffect_003Ed__192 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x400AA29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isDice;

		[Token(Token = "0x400AA2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass192_0 _003C_003E8__1;

		[Token(Token = "0x400AA2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int number;

		[Token(Token = "0x400AA2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x400AA2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TweenPosition _003CmoveTween_003E5__3;

		[Token(Token = "0x17000EF1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F27")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F29")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F24")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMoveEffect_003Ed__192(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F25")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F26")]
		[Address(RVA = "0xA6DE50", Offset = "0xA6D050", VA = "0x180A6DE50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F28")]
		[Address(RVA = "0xA6EA70", Offset = "0xA6DC70", VA = "0x180A6EA70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000FAB")]
	[CompilerGenerated]
	private sealed class _003CyNextReward_003Ed__190 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x17000EF3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F2D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F2F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F2A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyNextReward_003Ed__190(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F2B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F2C")]
		[Address(RVA = "0xA6EC60", Offset = "0xA6DE60", VA = "0x180A6EC60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0xA6F160", Offset = "0xA6E360", VA = "0x180A6F160", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000FAC")]
	[CompilerGenerated]
	private sealed class _003CyNextRewardFinish_003Ed__191 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x17000EF5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F33")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F35")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F30")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyNextRewardFinish_003Ed__191(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F31")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F32")]
		[Address(RVA = "0xA6EAB0", Offset = "0xA6DCB0", VA = "0x180A6EAB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F34")]
		[Address(RVA = "0xA6EC20", Offset = "0xA6DE20", VA = "0x180A6EC20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000FAD")]
	[CompilerGenerated]
	private sealed class _003CyOpenDuelDialog_003Ed__197 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenPosition tween;

		[Token(Token = "0x17000EF7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F39")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F3B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F36")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOpenDuelDialog_003Ed__197(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F37")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F38")]
		[Address(RVA = "0xA6F1A0", Offset = "0xA6E3A0", VA = "0x180A6F1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0xA6F280", Offset = "0xA6E480", VA = "0x180A6F280", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000FAE")]
	[CompilerGenerated]
	private sealed class _003CyUpdateBoard_003Ed__195 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x400AA3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TweenPosition _003Ctween_003E5__2;

		[Token(Token = "0x17000EF9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F3F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EFA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F41")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyUpdateBoard_003Ed__195(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F3D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F3E")]
		[Address(RVA = "0xA6F2C0", Offset = "0xA6E4C0", VA = "0x180A6F2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F40")]
		[Address(RVA = "0xA6F890", Offset = "0xA6EA90", VA = "0x180A6F890", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000FAF")]
	[CompilerGenerated]
	private sealed class _003CyZoomBoard_003Ed__196 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiceRallyWidget _003C_003E4__this;

		[Token(Token = "0x400AA3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 originPos;

		[Token(Token = "0x400AA3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 targetPos;

		[Token(Token = "0x400AA40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 targetScale;

		[Token(Token = "0x17000EFB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F45")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EFC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F47")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F42")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyZoomBoard_003Ed__196(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F43")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F44")]
		[Address(RVA = "0xA6F8D0", Offset = "0xA6EAD0", VA = "0x180A6F8D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F46")]
		[Address(RVA = "0xA6FB50", Offset = "0xA6ED50", VA = "0x180A6FB50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A97D")]
	internal const string k_PrefPath = "Prefabs/DiceRally/DiceRallyBoard";

	[Token(Token = "0x400A97E")]
	internal const string k_SettingPath = "Definition/DiceRally/DiceRallySettings";

	[Token(Token = "0x400A97F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400A980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string IMG_SEARCH_LABEL;

	[Token(Token = "0x400A981")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string IMG_CARD_LABEL;

	[Token(Token = "0x400A982")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string IMG_CONTENT_LABEL;

	[Token(Token = "0x400A983")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly string IMG_CONTENT_2_LABEL;

	[Token(Token = "0x400A984")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly string IMG_PREMIUM_LABEL;

	[Token(Token = "0x400A985")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly string IMG_MIGHTY_LABEL;

	[Token(Token = "0x400A986")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly string IMG_MIGHTY_ICON;

	[Token(Token = "0x400A987")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly string BOARD_GROUP_LABEL;

	[Token(Token = "0x400A988")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x400A989")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly string DEFAULT_BG_LABEL;

	[Token(Token = "0x400A98A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly string CLEAR_BG_LABEL;

	[Token(Token = "0x400A98B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly string BTN_MOVE_BOARD;

	[Token(Token = "0x400A98C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly string PLAYER_ICON_HOLDER;

	[Token(Token = "0x400A98D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly string POP_ICON_HOLDER;

	[Token(Token = "0x400A98E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly string ICON_HOLDER;

	[Token(Token = "0x400A98F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly string IMG_EDGE_LABEL;

	[Token(Token = "0x400A990")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly string IMG_EDGE_SHADOW_LABEL;

	[Token(Token = "0x400A991")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly string SCROLL_VIEW_LABEL;

	[Token(Token = "0x400A992")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly string RARITY_GROUP_LABEL;

	[Token(Token = "0x400A993")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly string RARITY_GROUP_PREMIUM_LABEL;

	[Token(Token = "0x400A994")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly string BG_SPHERE_LABEL;

	[Token(Token = "0x400A995")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string LABEL_REWARD_GROUP;

	[Token(Token = "0x400A996")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string LABEL_REWARD_IMAGE;

	[Token(Token = "0x400A997")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string LABEL_REWARD_INFO;

	[Token(Token = "0x400A998")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string TMP_SPACE_LABEL;

	[Token(Token = "0x400A999")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string TWEEN_LABEL_SHOW;

	[Token(Token = "0x400A99A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TWEEN_LABEL_MOVE;

	[Token(Token = "0x400A99B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string TWEEN_LABEL_ZOOM;

	[Token(Token = "0x400A99C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string TWEEN_LABEL_FADEIN;

	[Token(Token = "0x400A99D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string TWEEN_LABEL_FADEOUT;

	[Token(Token = "0x400A99E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string TWEEN_LABEL_PUSH;

	[Token(Token = "0x400A99F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string TWEEN_LABEL_POP;

	[Token(Token = "0x400A9A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string TWEEN_LABEL_SWAPIN;

	[Token(Token = "0x400A9A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private int m_MapRange;

	[Token(Token = "0x400A9A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private int m_LapCount;

	[Token(Token = "0x400A9A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private int m_LapMax;

	[Token(Token = "0x400A9A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private int m_IconId;

	[Token(Token = "0x400A9A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private int m_FrameId;

	[Token(Token = "0x400A9A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private int m_DiceCount;

	[Token(Token = "0x400A9A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int m_DistanceSpace;

	[Token(Token = "0x400A9A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private int m_DistanceEdge;

	[Token(Token = "0x400A9A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int m_InitialSpaceId;

	[Token(Token = "0x400A9AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private int m_RarityUpCount;

	[Token(Token = "0x400A9AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private bool m_ActiveSearchIcon;

	[Token(Token = "0x400A9AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
	private bool m_IsSearch;

	[Token(Token = "0x400A9AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
	private bool m_IsFirstCreate;

	[Token(Token = "0x400A9AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
	private bool m_IsWheel;

	[Token(Token = "0x400A9AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private bool m_IsEffect;

	[Token(Token = "0x400A9B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
	private bool m_IsOpenDuelDialog;

	[Token(Token = "0x400A9B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
	private bool m_IsOpenNextReward;

	[Token(Token = "0x400A9B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
	private bool m_IsFinishCreate;

	[Token(Token = "0x400A9B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private bool m_IsGoal;

	[Token(Token = "0x400A9B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
	private bool m_IsFocus;

	[Token(Token = "0x400A9B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x162")]
	private bool m_IsFirstSlide;

	[Token(Token = "0x400A9B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x163")]
	private bool m_IsZoomSmall;

	[Token(Token = "0x400A9B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private bool m_IsSendPresent;

	[Token(Token = "0x400A9B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x165")]
	private bool m_IsFinishZoom;

	[Token(Token = "0x400A9B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x166")]
	private bool m_IsMouseButtonDown;

	[Token(Token = "0x400A9BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private float m_RatioSmall;

	[Token(Token = "0x400A9BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private float m_RatioMedium;

	[Token(Token = "0x400A9BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private float m_RatioLarge;

	[Token(Token = "0x400A9BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private float m_AnalogSpeed;

	[Token(Token = "0x400A9BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private float m_ZoomRatio;

	[Token(Token = "0x400A9BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private float m_ScrollSensitivity;

	[Token(Token = "0x400A9C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private float m_InputMagnitude;

	[Token(Token = "0x400A9C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private float m_MapCreateTime;

	[Token(Token = "0x400A9C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float m_StartFocusTime;

	[Token(Token = "0x400A9C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private float m_MapAngle;

	[Token(Token = "0x400A9C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private float m_BaseDeltaSec;

	[Token(Token = "0x400A9C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private Vector2 m_CanvasVec;

	[Token(Token = "0x400A9C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private Vector2 m_ScreenSize;

	[Token(Token = "0x400A9C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private Vector2 m_ScreenSizeOrigin;

	[Token(Token = "0x400A9C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private Vector2 m_ScrollRectOrigin;

	[Token(Token = "0x400A9C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private Vector2 m_ScreenMax;

	[Token(Token = "0x400A9CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private Vector2 m_ScreenMin;

	[Token(Token = "0x400A9CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private Vector2 m_ScreenPos;

	[Token(Token = "0x400A9CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private Vector2 m_AnchoredPos;

	[Token(Token = "0x400A9CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private Vector2 m_UpdatePos;

	[Token(Token = "0x400A9CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private Vector2 m_CurrentZoomTypePos;

	[Token(Token = "0x400A9CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private Vector2 m_DuelDialogOpenPos;

	[Token(Token = "0x400A9D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	private Vector2 m_NextRewardOpenPos;

	[Token(Token = "0x400A9D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private Vector3 m_PlayerIconRelativePosition;

	[Token(Token = "0x400A9D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private GameObject m_FadeBg;

	[Token(Token = "0x400A9D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private GameObject m_PlayerIcon;

	[Token(Token = "0x400A9D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private GameObject m_IconHolder;

	[Token(Token = "0x400A9D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private GameObject m_SearchIcon;

	[Token(Token = "0x400A9D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private Dictionary<string, GameObject> m_TemplateSpaceMap;

	[Token(Token = "0x400A9D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private Image m_ImageForCanvas;

	[Token(Token = "0x400A9D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private Transform m_BoardTf;

	[Token(Token = "0x400A9D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private RectTransform m_BoardRect;

	[Token(Token = "0x400A9DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private RectTransform m_ScrollRect;

	[Token(Token = "0x400A9DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private RectTransform m_CanvasRect;

	[Token(Token = "0x400A9DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private DiceRallySpace m_CurrentSpace;

	[Token(Token = "0x400A9DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private DiceRallySpace m_SelectedSpace;

	[Token(Token = "0x400A9DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private List<int> m_CoroutineOrderList;

	[Token(Token = "0x400A9DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private List<int> m_DiceNumbers;

	[Token(Token = "0x400A9E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private List<DiceRallyReward> m_Rewards;

	[Token(Token = "0x400A9E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private List<DiceRallyReward> m_DiceCountRewards;

	[Token(Token = "0x400A9E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private List<Coroutine> m_CoroutineList;

	[Token(Token = "0x400A9E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private List<Coroutine> m_EffectCoroutineList;

	[Token(Token = "0x400A9E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private List<DiceRallySpace> m_SpaceList;

	[Token(Token = "0x400A9E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private DiceRallyUtil.ZoomType m_ZoomType;

	[Token(Token = "0x400A9E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400A9E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private ElementObjectManager m_NextRewardEom;

	[Token(Token = "0x400A9E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private Action m_DecideSpaceCallback;

	[Token(Token = "0x400A9E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private Action m_UpdateBoardCallback;

	[Token(Token = "0x400A9EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private Action m_UpdateDuelDialogCallback;

	[Token(Token = "0x400A9EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private Action<DiceRallyWidget> m_OnFinishedCallback;

	[Token(Token = "0x400A9EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	private Action<bool> m_HideButtons;

	[Token(Token = "0x400A9ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private Selector m_Selector;

	[Token(Token = "0x400A9EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private SelectionButton m_MoveBoardButton;

	[Token(Token = "0x400A9EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private SelectionButton m_ZoomButton;

	[Token(Token = "0x400A9F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private ScrollRect m_Scroll;

	[Token(Token = "0x400A9F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private DiceRallyDice m_Dice;

	[Token(Token = "0x400A9F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private GameObject m_BGSphere;

	[Token(Token = "0x400A9F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private DiceRallySetting m_Setting;

	[Token(Token = "0x400A9F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private DiceRallyReward m_NextReward;

	[Token(Token = "0x400A9F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private Coroutine m_NextRewardCoroutine;

	[Token(Token = "0x400A9F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private DiceRallyWidget m_Widget;

	[Token(Token = "0x400A9F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	private GoalInfomationWidget m_GoalInfomationWidget;

	[Token(Token = "0x400A9F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private List<ExtendedTextMeshProUGUI> m_GoalInfoList;

	[Token(Token = "0x400A9F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private DiceRallyMiniMap m_MiniMap;

	[Token(Token = "0x400A9FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	private DiceRallyPopIcon m_PopIcon;

	[Token(Token = "0x400A9FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	private ColosseumDialogMangaer m_DuelDialog;

	[Token(Token = "0x17000EEA")]
	public DiceRallySetting Setting
	{
		[Token(Token = "0x6005EB7")]
		[Address(RVA = "0x49BED0", Offset = "0x49B0D0", VA = "0x18049BED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005EB8")]
		[Address(RVA = "0x49C5D0", Offset = "0x49B7D0", VA = "0x18049C5D0")]
		set
		{
		}
	}

	[Token(Token = "0x6005EB9")]
	[Address(RVA = "0xA3A0A0", Offset = "0xA392A0", VA = "0x180A3A0A0")]
	public static void CreateWidget(Transform parentTf, GameObject miniMapArea, Dictionary<string, object> dic, Action onDecideSpaceCallback, Action onUpdateBoardCallback, Action<DiceRallyWidget> onFinishedCallback, int initialId, int rarityUpCount, ElementObjectManager nextRewardEom, SelectionButton zoomButton, [Optional] DiceRallyReward nextReward, int lapCount = 1, [Optional] GoalInfomationWidget goalInfoWidget)
	{
	}

	[Token(Token = "0x6005EBA")]
	[Address(RVA = "0xA39D60", Offset = "0xA38F60", VA = "0x180A39D60")]
	public void CreateView(Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x6005EBB")]
	[Address(RVA = "0xA3D740", Offset = "0xA3C940", VA = "0x180A3D740")]
	public void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6005EBC")]
	[Address(RVA = "0xA3DA80", Offset = "0xA3CC80", VA = "0x180A3DA80")]
	public void RollDice(List<int> numbers, List<DiceRallyReward> rewards, bool isGoal = false, [Optional] List<DiceRallyReward> diceCountRewards, bool isSendPresentBox = false)
	{
	}

	[Token(Token = "0x6005EBD")]
	[Address(RVA = "0xA3DB70", Offset = "0xA3CD70", VA = "0x180A3DB70")]
	public void RollDice(int number)
	{
	}

	[Token(Token = "0x6005EBE")]
	[Address(RVA = "0x6D4600", Offset = "0x6D3800", VA = "0x1806D4600")]
	public DiceRallySpace GetCurrentSpace()
	{
		return null;
	}

	[Token(Token = "0x6005EBF")]
	[Address(RVA = "0x49BC10", Offset = "0x49AE10", VA = "0x18049BC10")]
	public DiceRallySpace GetSelectedSpace()
	{
		return null;
	}

	[Token(Token = "0x6005EC0")]
	[Address(RVA = "0xA408C0", Offset = "0xA3FAC0", VA = "0x180A408C0")]
	public void ZoomBoard(DiceRallyUtil.ZoomType type, bool immediate = false)
	{
	}

	[Token(Token = "0x6005EC1")]
	[Address(RVA = "0xA3AAC0", Offset = "0xA39CC0", VA = "0x180A3AAC0")]
	public void FocusSpace(bool isFocus, [Optional] DiceRallySpace space, bool isDice = false, bool isPlaySelectSE = false, bool isFirst = false)
	{
	}

	[Token(Token = "0x6005EC2")]
	[Address(RVA = "0xA40860", Offset = "0xA3FA60", VA = "0x180A40860")]
	public void WheelBoard(Vector2 input)
	{
	}

	[Token(Token = "0x6005EC3")]
	[Address(RVA = "0xA3B4D0", Offset = "0xA3A6D0", VA = "0x180A3B4D0")]
	public bool GetIsEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EC4")]
	[Address(RVA = "0xA3B4E0", Offset = "0xA3A6E0", VA = "0x180A3B4E0")]
	public bool GetIsOpenDuelDialog()
	{
		return default(bool);
	}

	[Token(Token = "0x6005EC5")]
	[Address(RVA = "0xA3E050", Offset = "0xA3D250", VA = "0x180A3E050")]
	public void SetIsEffect(bool bo)
	{
	}

	[Token(Token = "0x6005EC6")]
	[Address(RVA = "0xA3E060", Offset = "0xA3D260", VA = "0x180A3E060")]
	public void SetIsFirstSlide(bool bo)
	{
	}

	[Token(Token = "0x6005EC7")]
	[Address(RVA = "0x49C140", Offset = "0x49B340", VA = "0x18049C140")]
	public void SetDecideSpaceCallback(Action action)
	{
	}

	[Token(Token = "0x6005EC8")]
	[Address(RVA = "0x4D4300", Offset = "0x4D3500", VA = "0x1804D4300")]
	public void SetUpdateBoardCallback(Action action)
	{
	}

	[Token(Token = "0x6005EC9")]
	[Address(RVA = "0x498130", Offset = "0x497330", VA = "0x180498130")]
	public void SetUpdateDuelDialogCallback(Action action)
	{
	}

	[Token(Token = "0x6005ECA")]
	[Address(RVA = "0x49C340", Offset = "0x49B540", VA = "0x18049C340")]
	public void SetLapCount(int count)
	{
	}

	[Token(Token = "0x6005ECB")]
	[Address(RVA = "0x498150", Offset = "0x497350", VA = "0x180498150")]
	public void SetHideButtons(Action<bool> action)
	{
	}

	[Token(Token = "0x6005ECC")]
	[Address(RVA = "0xA3E300", Offset = "0xA3D500", VA = "0x180A3E300")]
	public void SlideBoard(bool isOpen, bool isSkipTween = false, bool isFirst = false)
	{
	}

	[Token(Token = "0x6005ECD")]
	[Address(RVA = "0xA3F3A0", Offset = "0xA3E5A0", VA = "0x180A3F3A0")]
	public void UpdateBoard(Dictionary<string, object> dic, [Optional] DiceRallyReward nextReward)
	{
	}

	[Token(Token = "0x6005ECE")]
	[Address(RVA = "0xA3DE00", Offset = "0xA3D000", VA = "0x180A3DE00")]
	public void SetDuelDialog(ColosseumDialogMangaer dialog)
	{
	}

	[Token(Token = "0x6005ECF")]
	[Address(RVA = "0xA3DE20", Offset = "0xA3D020", VA = "0x180A3DE20")]
	public void SetFadeBg(GameObject bg)
	{
	}

	[Token(Token = "0x6005ED0")]
	[Address(RVA = "0xA3E070", Offset = "0xA3D270", VA = "0x180A3E070")]
	public void SetMapSphere(int currentLapId)
	{
	}

	[Token(Token = "0x6005ED1")]
	[Address(RVA = "0xA3F910", Offset = "0xA3EB10", VA = "0x180A3F910")]
	private void Update()
	{
	}

	[Token(Token = "0x6005ED2")]
	[Address(RVA = "0xA3C800", Offset = "0xA3BA00", VA = "0x180A3C800")]
	private void InitializeSetting()
	{
	}

	[Token(Token = "0x6005ED3")]
	[Address(RVA = "0xA3CC70", Offset = "0xA3BE70", VA = "0x180A3CC70")]
	private void InitializeTemplates()
	{
	}

	[Token(Token = "0x6005ED4")]
	[Address(RVA = "0xA3C690", Offset = "0xA3B890", VA = "0x180A3C690")]
	private void InitializeScroll()
	{
	}

	[Token(Token = "0x6005ED5")]
	[Address(RVA = "0xA3C510", Offset = "0xA3B710", VA = "0x180A3C510")]
	private void InitializePopIcon()
	{
	}

	[Token(Token = "0x6005ED6")]
	[Address(RVA = "0xA3C200", Offset = "0xA3B400", VA = "0x180A3C200")]
	private void InitializePlayerIcon()
	{
	}

	[Token(Token = "0x6005ED7")]
	[Address(RVA = "0xA3C0D0", Offset = "0xA3B2D0", VA = "0x180A3C0D0")]
	private void InitializeMove()
	{
	}

	[Token(Token = "0x6005ED8")]
	[Address(RVA = "0xA3D0E0", Offset = "0xA3C2E0", VA = "0x180A3D0E0")]
	public bool IsGamePad()
	{
		return default(bool);
	}

	[Token(Token = "0x6005ED9")]
	[Address(RVA = "0xA37B40", Offset = "0xA36D40", VA = "0x180A37B40")]
	private void CreateBoard(Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x6005EDA")]
	[Address(RVA = "0xA3A2D0", Offset = "0xA394D0", VA = "0x180A3A2D0")]
	private void DragBoard(Vector2 target, bool isZoomSmall = false)
	{
	}

	[Token(Token = "0x6005EDB")]
	[Address(RVA = "0xA3D170", Offset = "0xA3C370", VA = "0x180A3D170")]
	private void MoveBoard(Vector2 input)
	{
	}

	[Token(Token = "0x6005EDC")]
	[Address(RVA = "0xA389C0", Offset = "0xA37BC0", VA = "0x180A389C0")]
	private void CreateSpaceTree()
	{
	}

	[Token(Token = "0x6005EDD")]
	[Address(RVA = "0xA3B520", Offset = "0xA3A720", VA = "0x180A3B520")]
	private GameObject GetTemplate(DiceRallySpace space, bool reincarnation = false)
	{
		return null;
	}

	[Token(Token = "0x6005EDE")]
	[Address(RVA = "0xA3B970", Offset = "0xA3AB70", VA = "0x180A3B970")]
	private string GetTitleDesc(DiceRallySpace space)
	{
		return null;
	}

	[Token(Token = "0x6005EDF")]
	[Address(RVA = "0xA3B190", Offset = "0xA3A390", VA = "0x180A3B190")]
	private string GetDetailDesc(DiceRallySpace space)
	{
		return null;
	}

	[Token(Token = "0x6005EE0")]
	[Address(RVA = "0xA3BCB0", Offset = "0xA3AEB0", VA = "0x180A3BCB0")]
	public TweenPosition GetTween(GameObject target, string label)
	{
		return null;
	}

	[Token(Token = "0x6005EE1")]
	[Address(RVA = "0xA3BF60", Offset = "0xA3B160", VA = "0x180A3BF60")]
	private void ImpCoroutine(Transform boardTf, int order, int depth)
	{
	}

	[Token(Token = "0x6005EE2")]
	[Address(RVA = "0xA38DE0", Offset = "0xA37FE0", VA = "0x180A38DE0")]
	private void CreateSpace(GameObject tmpGo, Transform boardTf, int order)
	{
	}

	[Token(Token = "0x6005EE3")]
	[Address(RVA = "0xA376A0", Offset = "0xA368A0", VA = "0x180A376A0")]
	private void ConnectSpace(DiceRallySpace space)
	{
	}

	[Token(Token = "0x6005EE4")]
	[Address(RVA = "0xA3EEB0", Offset = "0xA3E0B0", VA = "0x180A3EEB0")]
	private void TrySelect(bool isChild, bool isParent)
	{
	}

	[Token(Token = "0x6005EE5")]
	[Address(RVA = "0xA3EBB0", Offset = "0xA3DDB0", VA = "0x180A3EBB0")]
	private void TrySelectRightSpace()
	{
	}

	[Token(Token = "0x6005EE6")]
	[Address(RVA = "0xA3EA30", Offset = "0xA3DC30", VA = "0x180A3EA30")]
	private void TrySelectLeftSpace()
	{
	}

	[Token(Token = "0x6005EE7")]
	[Address(RVA = "0xA3ED30", Offset = "0xA3DF30", VA = "0x180A3ED30")]
	private void TrySelectUpSpace()
	{
	}

	[Token(Token = "0x6005EE8")]
	[Address(RVA = "0xA3E8B0", Offset = "0xA3DAB0", VA = "0x180A3E8B0")]
	private void TrySelectDownSpace()
	{
	}

	[Token(Token = "0x6005EE9")]
	[Address(RVA = "0xA3A250", Offset = "0xA39450", VA = "0x180A3A250")]
	private void DispPopIcon(bool active, bool skipPop = false)
	{
	}

	[Token(Token = "0x6005EEA")]
	[Address(RVA = "0xA37340", Offset = "0xA36540", VA = "0x180A37340")]
	private void ClearCoroutineList()
	{
	}

	[Token(Token = "0x6005EEB")]
	[Address(RVA = "0xA374F0", Offset = "0xA366F0", VA = "0x180A374F0")]
	private void ClearEffectCoroutineList()
	{
	}

	[Token(Token = "0x6005EEC")]
	[Address(RVA = "0xA3BD80", Offset = "0xA3AF80", VA = "0x180A3BD80")]
	private void GoalEffect()
	{
	}

	[Token(Token = "0x6005EED")]
	[Address(RVA = "0xA3B140", Offset = "0xA3A340", VA = "0x180A3B140")]
	private void GetCard()
	{
	}

	[Token(Token = "0x6005EEE")]
	[Address(RVA = "0xA3F150", Offset = "0xA3E350", VA = "0x180A3F150")]
	private void UpRarity()
	{
	}

	[Token(Token = "0x6005EEF")]
	[Address(RVA = "0xA3D920", Offset = "0xA3CB20", VA = "0x180A3D920")]
	private void Reincarnation(DiceRallySpace space)
	{
	}

	[Token(Token = "0x6005EF0")]
	[Address(RVA = "0xA3F680", Offset = "0xA3E880", VA = "0x180A3F680")]
	private void UpdateRarity(ElementObjectManager eom, int order, bool skipRarityUp = false)
	{
	}

	[Token(Token = "0x6005EF1")]
	[Address(RVA = "0xA3A5B0", Offset = "0xA397B0", VA = "0x180A3A5B0")]
	private void EffectEnd(bool isGoal = false)
	{
	}

	[Token(Token = "0x6005EF2")]
	[Address(RVA = "0xA3D570", Offset = "0xA3C770", VA = "0x180A3D570")]
	private void NextRewardFinish()
	{
	}

	[Token(Token = "0x6005EF3")]
	[Address(RVA = "0xA3B4F0", Offset = "0xA3A6F0", VA = "0x180A3B4F0")]
	private float GetRatio()
	{
		return default(float);
	}

	[Token(Token = "0x6005EF4")]
	[Address(RVA = "0xA42EB0", Offset = "0xA420B0", VA = "0x180A42EB0")]
	[IteratorStateMachine(typeof(_003CyInstantiateSpace_003Ed__189))]
	private IEnumerator yInstantiateSpace(Transform boardTf, int order, int depth)
	{
		return null;
	}

	[Token(Token = "0x6005EF5")]
	[Address(RVA = "0xA43060", Offset = "0xA42260", VA = "0x180A43060")]
	[IteratorStateMachine(typeof(_003CyNextReward_003Ed__190))]
	private IEnumerator yNextReward()
	{
		return null;
	}

	[Token(Token = "0x6005EF6")]
	[Address(RVA = "0xA42FF0", Offset = "0xA421F0", VA = "0x180A42FF0")]
	[IteratorStateMachine(typeof(_003CyNextRewardFinish_003Ed__191))]
	private IEnumerator yNextRewardFinish()
	{
		return null;
	}

	[Token(Token = "0x6005EF7")]
	[Address(RVA = "0xA42F60", Offset = "0xA42160", VA = "0x180A42F60")]
	[IteratorStateMachine(typeof(_003CyMoveEffect_003Ed__192))]
	private IEnumerator yMoveEffect(int number, bool isDice)
	{
		return null;
	}

	[Token(Token = "0x6005EF8")]
	[Address(RVA = "0xA42D80", Offset = "0xA41F80", VA = "0x180A42D80")]
	[IteratorStateMachine(typeof(_003CyFocusSpace_003Ed__193))]
	private IEnumerator yFocusSpace(DiceRallySpace space, bool isDice, bool isFocus = false, bool isFirst = false)
	{
		return null;
	}

	[Token(Token = "0x6005EF9")]
	[Address(RVA = "0xA42E40", Offset = "0xA42040", VA = "0x180A42E40")]
	[IteratorStateMachine(typeof(_003CyGoalEffect_003Ed__194))]
	private IEnumerator yGoalEffect()
	{
		return null;
	}

	[Token(Token = "0x6005EFA")]
	[Address(RVA = "0xA43140", Offset = "0xA42340", VA = "0x180A43140")]
	[IteratorStateMachine(typeof(_003CyUpdateBoard_003Ed__195))]
	private IEnumerator yUpdateBoard()
	{
		return null;
	}

	[Token(Token = "0x6005EFB")]
	[Address(RVA = "0xA431B0", Offset = "0xA423B0", VA = "0x180A431B0")]
	[IteratorStateMachine(typeof(_003CyZoomBoard_003Ed__196))]
	private IEnumerator yZoomBoard(Vector3 originPos, Vector3 targetPos, Vector3 targetScale)
	{
		return null;
	}

	[Token(Token = "0x6005EFC")]
	[Address(RVA = "0xA430D0", Offset = "0xA422D0", VA = "0x180A430D0")]
	[IteratorStateMachine(typeof(_003CyOpenDuelDialog_003Ed__197))]
	private IEnumerator yOpenDuelDialog(TweenPosition tween)
	{
		return null;
	}

	[Token(Token = "0x6005EFD")]
	[Address(RVA = "0xA423D0", Offset = "0xA415D0", VA = "0x180A423D0")]
	public DiceRallyWidget()
	{
	}
}
