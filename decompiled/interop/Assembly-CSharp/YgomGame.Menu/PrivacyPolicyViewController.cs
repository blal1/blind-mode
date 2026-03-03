using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20011F6")]
public class PrivacyPolicyViewController : CommonScreenViewController
{
	[Token(Token = "0x20011F9")]
	[CompilerGenerated]
	private sealed class _003CopenGDPRPrivacyNotice_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B9A2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B9A3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B9A4")]
		[FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x400B9A5")]
		[FieldOffset(Offset = "0x28")]
		public PrivacyPolicyViewController _003C_003E4__this;

		[Token(Token = "0x170011AC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600704B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011AD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600704D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007048")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CopenGDPRPrivacyNotice_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007049")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600704A")]
		[Address(RVA = "0xB802C0", Offset = "0xB7F4C0", VA = "0x180B802C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600704C")]
		[Address(RVA = "0xB803E0", Offset = "0xB7F5E0", VA = "0x180B803E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B998")]
	[FieldOffset(Offset = "0x118")]
	private UserAgreementType m_type;

	[Token(Token = "0x400B999")]
	[FieldOffset(Offset = "0x120")]
	private SelectionButton m_agreeButton;

	[Token(Token = "0x400B99A")]
	[FieldOffset(Offset = "0x128")]
	private IEnumerator m_openGDPRPrivacyNotice;

	[Token(Token = "0x400B99B")]
	[FieldOffset(Offset = "0x130")]
	private Action<int> m_resultCallback;

	[Token(Token = "0x6007033")]
	[Address(RVA = "0xB7DBB0", Offset = "0xB7CDB0", VA = "0x180B7DBB0")]
	private void setupButton(string element, string text, Action callback)
	{
	}

	[Token(Token = "0x6007034")]
	[Address(RVA = "0xB7DAA0", Offset = "0xB7CCA0", VA = "0x180B7DAA0")]
	private void closeButton(string element)
	{
	}

	[Token(Token = "0x6007035")]
	[Address(RVA = "0xB7DB20", Offset = "0xB7CD20", VA = "0x180B7DB20")]
	[IteratorStateMachine(typeof(_003CopenGDPRPrivacyNotice_003Ed__6))]
	private IEnumerator openGDPRPrivacyNotice(string url)
	{
		return null;
	}

	[Token(Token = "0x6007036")]
	[Address(RVA = "0xB7CD90", Offset = "0xB7BF90", VA = "0x180B7CD90", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007037")]
	[Address(RVA = "0xB7CE30", Offset = "0xB7C030", VA = "0x180B7CE30", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007038")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x6007039")]
	[Address(RVA = "0xB70F20", Offset = "0xB70120", VA = "0x180B70F20", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600703A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private static void debugLog(string str)
	{
	}

	[Token(Token = "0x600703B")]
	[Address(RVA = "0xB513D0", Offset = "0xB505D0", VA = "0x180B513D0")]
	public PrivacyPolicyViewController()
	{
	}
}
