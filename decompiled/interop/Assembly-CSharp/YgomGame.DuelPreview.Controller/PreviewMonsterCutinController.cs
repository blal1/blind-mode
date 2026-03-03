using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000EA2")]
public class PreviewMonsterCutinController : IPreviewPlayerController
{
	[Token(Token = "0x2000EA3")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x400A403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool donePlay;

		[Token(Token = "0x600587C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600587D")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CPlay_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000EA4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x400A404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool doneSetup;

		[Token(Token = "0x600587E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600587F")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CySetup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000EA5")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PreviewMonsterCutinController _003C_003E4__this;

		[Token(Token = "0x400A408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float screenWidth;

		[Token(Token = "0x400A409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float screenHeight;

		[Token(Token = "0x400A40A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Camera targetCamera;

		[Token(Token = "0x400A40B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		[Token(Token = "0x17000D9A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005883")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D9B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005885")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005880")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005881")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005882")]
		[Address(RVA = "0x9FCCA0", Offset = "0x9FBEA0", VA = "0x1809FCCA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005884")]
		[Address(RVA = "0x9FCE30", Offset = "0x9FC030", VA = "0x1809FCE30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EA6")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A40C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A40D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D9C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005889")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D9D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600588B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005886")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005887")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005888")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600588A")]
		[Address(RVA = "0x9FFFB0", Offset = "0x9FF1B0", VA = "0x1809FFFB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EA7")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A40E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A40F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PreviewMonsterCutinController _003C_003E4__this;

		[Token(Token = "0x400A411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int mrk;

		[Token(Token = "0x400A412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		[Token(Token = "0x17000D9E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600588F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D9F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005891")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600588C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600588D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600588E")]
		[Address(RVA = "0xA00CC0", Offset = "0x9FFEC0", VA = "0x180A00CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005890")]
		[Address(RVA = "0xA00E40", Offset = "0xA00040", VA = "0x180A00E40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly DuelPreviewPlayer.Option m_Option;

	[Token(Token = "0x400A402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MonsterCutinEffect m_MonsterCutinEffect;

	[Token(Token = "0x17000D99")]
	public ControllerType controllerType
	{
		[Token(Token = "0x6005875")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "4")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x6005874")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public PreviewMonsterCutinController(DuelPreviewPlayer.Option option)
	{
	}

	[Token(Token = "0x6005876")]
	[Address(RVA = "0x9B4D30", Offset = "0x9B3F30", VA = "0x1809B4D30")]
	public bool IsSupported(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x6005877")]
	[Address(RVA = "0x9F7F80", Offset = "0x9F7180", VA = "0x1809F7F80", Slot = "5")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__6))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005878")]
	[Address(RVA = "0x9F7F40", Offset = "0x9F7140", VA = "0x1809F7F40", Slot = "6")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6005879")]
	[Address(RVA = "0x9F7F40", Offset = "0x9F7140", VA = "0x1809F7F40", Slot = "7")]
	public void Release()
	{
	}

	[Token(Token = "0x600587A")]
	[Address(RVA = "0x9F7FD0", Offset = "0x9F71D0", VA = "0x1809F7FD0")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__9))]
	public IEnumerator ySetup(int mrk)
	{
		return null;
	}

	[Token(Token = "0x600587B")]
	[Address(RVA = "0x9F7E90", Offset = "0x9F7090", VA = "0x1809F7E90")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__10))]
	public IEnumerator Play(float screenWidth, float screenHeight, [Optional] Camera targetCamera)
	{
		return null;
	}
}
