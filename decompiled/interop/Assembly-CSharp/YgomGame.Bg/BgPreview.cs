using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D67")]
public class BgPreview : MonoBehaviour
{
	[Token(Token = "0x2001D68")]
	[CompilerGenerated]
	private sealed class _003CInitializedCheck_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40103A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40103A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40103A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BgPreview _003C_003E4__this;

		[Token(Token = "0x17001C11")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BCB4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C12")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BCB6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BCB1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializedCheck_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BCB2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BCB3")]
		[Address(RVA = "0x58FAA0", Offset = "0x58ECA0", VA = "0x18058FAA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BCB5")]
		[Address(RVA = "0x58FB60", Offset = "0x58ED60", VA = "0x18058FB60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x401039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private BgManager mng;

	[Token(Token = "0x40103A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action onInitilizeFinish;

	[Token(Token = "0x40103A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool IsInitialized;

	[Token(Token = "0x600BCAD")]
	[Address(RVA = "0x5832E0", Offset = "0x5824E0", VA = "0x1805832E0")]
	public static BgPreview Create(Transform root, [Optional] Action onFinish, params int[] ids)
	{
		return null;
	}

	[Token(Token = "0x600BCAE")]
	[Address(RVA = "0x583710", Offset = "0x582910", VA = "0x180583710")]
	[IteratorStateMachine(typeof(_003CInitializedCheck_003Ed__4))]
	private IEnumerator InitializedCheck()
	{
		return null;
	}

	[Token(Token = "0x600BCAF")]
	[Address(RVA = "0x583780", Offset = "0x582980", VA = "0x180583780")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600BCB0")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BgPreview()
	{
	}
}
