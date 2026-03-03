using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomSample;

[Token(Token = "0x2001DB5")]
public class ChangeDigitUITest : MonoBehaviour
{
	[Token(Token = "0x2001DB6")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40104C9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40104CA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40104CB")]
		[FieldOffset(Offset = "0x20")]
		public ChangeDigitUITest _003C_003E4__this;

		[Token(Token = "0x17001C2D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BDF7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C2E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BDF9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BDF4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BDF5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BDF6")]
		[Address(RVA = "0x5914D0", Offset = "0x5906D0", VA = "0x1805914D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BDF8")]
		[Address(RVA = "0x591640", Offset = "0x590840", VA = "0x180591640", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40104C6")]
	[FieldOffset(Offset = "0x20")]
	private ViewController _vc;

	[Token(Token = "0x40104C7")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager _eom;

	[Token(Token = "0x40104C8")]
	[FieldOffset(Offset = "0x30")]
	private ExtendedTextMeshProUGUI _dispText;

	[Token(Token = "0x600BDEF")]
	[Address(RVA = "0x588BC0", Offset = "0x587DC0", VA = "0x180588BC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BDF0")]
	[Address(RVA = "0x588E20", Offset = "0x588020", VA = "0x180588E20")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__4))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600BDF1")]
	[Address(RVA = "0x588D00", Offset = "0x587F00", VA = "0x180588D00")]
	private void OnInputDigitStart()
	{
	}

	[Token(Token = "0x600BDF2")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ChangeDigitUITest()
	{
	}
}
