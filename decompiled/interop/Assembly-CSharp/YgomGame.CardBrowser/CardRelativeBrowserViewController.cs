using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Duel;
using YgomGame.Menu;

namespace YgomGame.CardBrowser;

[Token(Token = "0x20015E0")]
public class CardRelativeBrowserViewController : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x20015E1")]
	[CompilerGenerated]
	private sealed class _003CyInitRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardRelativeBrowserViewController _003C_003E4__this;

		[Token(Token = "0x170014E4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60087DF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014E5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60087E1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60087DC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitRoutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60087DD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60087DE")]
		[Address(RVA = "0xD1A970", Offset = "0xD19B70", VA = "0x180D1A970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60087E0")]
		[Address(RVA = "0xD1ADB0", Offset = "0xD19FB0", VA = "0x180D1ADB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CFFE")]
	private const string k_ArgKey_Mrk = "mrk";

	[Token(Token = "0x400CFFF")]
	internal const string k_ArgKeySwap = "swap";

	[Token(Token = "0x400D000")]
	internal const string k_ArgKey_SkipSwapTransition = "SkipSwapTransition";

	[Token(Token = "0x400D001")]
	internal const string k_ArgKey_CardBrowserArgs = "CardBrowserArgs";

	[Token(Token = "0x400D002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelCloseButton;

	[Token(Token = "0x400D003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelContentRoot;

	[Token(Token = "0x400D004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int m_Mrk;

	[Token(Token = "0x400D005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private IEnumerator m_InitRoutine;

	[Token(Token = "0x400D006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private CardInfoDetailPool.RelativeList m_RelativeList;

	[Token(Token = "0x170014E3")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x60087D3")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60087D4")]
	[Address(RVA = "0xD0CF60", Offset = "0xD0C160", VA = "0x180D0CF60")]
	public static void Open(int mrk, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60087D5")]
	[Address(RVA = "0xD0CD60", Offset = "0xD0BF60", VA = "0x180D0CD60", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60087D6")]
	[Address(RVA = "0xD0D100", Offset = "0xD0C300", VA = "0x180D0D100", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x60087D7")]
	[Address(RVA = "0xD0D3C0", Offset = "0xD0C5C0", VA = "0x180D0D3C0")]
	[IteratorStateMachine(typeof(_003CyInitRoutine_003Ed__14))]
	private IEnumerator yInitRoutine()
	{
		return null;
	}

	[Token(Token = "0x60087D8")]
	[Address(RVA = "0xD0CEE0", Offset = "0xD0C0E0", VA = "0x180D0CEE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60087D9")]
	[Address(RVA = "0xD0D330", Offset = "0xD0C530", VA = "0x180D0D330")]
	public CardRelativeBrowserViewController()
	{
	}
}
