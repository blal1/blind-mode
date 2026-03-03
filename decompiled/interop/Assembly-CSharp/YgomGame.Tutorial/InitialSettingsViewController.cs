using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Tutorial;

[Token(Token = "0x20007A0")]
public class InitialSettingsViewController : BaseMenuViewController
{
	[Token(Token = "0x20007A3")]
	[CompilerGenerated]
	private sealed class _003CSelectDelayOK_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400262E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400262F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002630")]
		[FieldOffset(Offset = "0x20")]
		public InitialSettingsViewController _003C_003E4__this;

		[Token(Token = "0x1700062E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60031E8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60031EA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSelectDelayOK_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60031E6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x759DB0", Offset = "0x758FB0", VA = "0x180759DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60031E9")]
		[Address(RVA = "0x759E60", Offset = "0x759060", VA = "0x180759E60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20007A4")]
	[CompilerGenerated]
	private sealed class _003CVerifyName_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002631")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002632")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002633")]
		[FieldOffset(Offset = "0x20")]
		public string newName;

		[Token(Token = "0x4002634")]
		[FieldOffset(Offset = "0x28")]
		public InitialSettingsViewController _003C_003E4__this;

		[Token(Token = "0x4002635")]
		[FieldOffset(Offset = "0x30")]
		public Action<bool> onEnd;

		[Token(Token = "0x17000630")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60031EE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000631")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60031F0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60031EB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CVerifyName_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60031EC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60031ED")]
		[Address(RVA = "0x75D290", Offset = "0x75C490", VA = "0x18075D290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x75D560", Offset = "0x75C760", VA = "0x18075D560", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002621")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string INPUT_LABEL;

	[Token(Token = "0x4002622")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x4002623")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string BTN_CAUTION_LABEL;

	[Token(Token = "0x4002624")]
	[FieldOffset(Offset = "0xE8")]
	private SelectionButton m_ButtonOK;

	[Token(Token = "0x4002625")]
	[FieldOffset(Offset = "0xF0")]
	private InputFieldWidget _inputFieldWidget;

	[Token(Token = "0x4002626")]
	[FieldOffset(Offset = "0xF8")]
	private string _nameCanditate;

	[Token(Token = "0x1700062D")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60031CF")]
		[Address(RVA = "0x74F720", Offset = "0x74E920", VA = "0x18074F720", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60031D1")]
	[Address(RVA = "0x74E7D0", Offset = "0x74D9D0", VA = "0x18074E7D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60031D2")]
	[Address(RVA = "0x74F590", Offset = "0x74E790", VA = "0x18074F590")]
	[IteratorStateMachine(typeof(_003CVerifyName_003Ed__10))]
	private IEnumerator VerifyName(string newName, Action<bool> onEnd)
	{
		return null;
	}

	[Token(Token = "0x60031D3")]
	[Address(RVA = "0x74EA90", Offset = "0x74DC90", VA = "0x18074EA90")]
	private void OpenCautionDialog()
	{
	}

	[Token(Token = "0x60031D4")]
	[Address(RVA = "0x74EC50", Offset = "0x74DE50", VA = "0x18074EC50")]
	[IteratorStateMachine(typeof(_003CSelectDelayOK_003Ed__12))]
	private IEnumerator SelectDelayOK()
	{
		return null;
	}

	[Token(Token = "0x60031D5")]
	[Address(RVA = "0x74F640", Offset = "0x74E840", VA = "0x18074F640")]
	public InitialSettingsViewController()
	{
	}
}
