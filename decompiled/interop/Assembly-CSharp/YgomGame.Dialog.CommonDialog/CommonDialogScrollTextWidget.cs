using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FD6")]
public class CommonDialogScrollTextWidget : ContentWidgetBase<CommonDialogScrollTextWidget, EntryScrollTextData>
{
	[Token(Token = "0x2000FD7")]
	[CompilerGenerated]
	private sealed class _003CApplayHeight_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AB2F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AB30")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AB31")]
		[FieldOffset(Offset = "0x20")]
		public CommonDialogScrollTextWidget _003C_003E4__this;

		[Token(Token = "0x400AB32")]
		[FieldOffset(Offset = "0x28")]
		public int minHeight;

		[Token(Token = "0x17000F1C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006004")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F1D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006006")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006001")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CApplayHeight_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006002")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006003")]
		[Address(RVA = "0xA6B9D0", Offset = "0xA6ABD0", VA = "0x180A6B9D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006005")]
		[Address(RVA = "0xA6BBB0", Offset = "0xA6ADB0", VA = "0x180A6BBB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400AB2D")]
	[FieldOffset(Offset = "0x30")]
	private TMP_Text m_Text;

	[Token(Token = "0x400AB2E")]
	[FieldOffset(Offset = "0x38")]
	private LayoutElement m_Layout;

	[Token(Token = "0x6005FFC")]
	[Address(RVA = "0xA577A0", Offset = "0xA569A0", VA = "0x180A577A0")]
	public static CommonDialogScrollTextWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005FFD")]
	[Address(RVA = "0xA576D0", Offset = "0xA568D0", VA = "0x180A576D0", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005FFE")]
	[Address(RVA = "0xA577E0", Offset = "0xA569E0", VA = "0x180A577E0", Slot = "24")]
	protected override void InnerBinding(EntryScrollTextData entryData)
	{
	}

	[Token(Token = "0x6005FFF")]
	[Address(RVA = "0xA57650", Offset = "0xA56850", VA = "0x180A57650")]
	[IteratorStateMachine(typeof(_003CApplayHeight_003Ed__5))]
	private IEnumerator ApplayHeight(int minHeight)
	{
		return null;
	}

	[Token(Token = "0x6006000")]
	[Address(RVA = "0xA579B0", Offset = "0xA56BB0", VA = "0x180A579B0")]
	public CommonDialogScrollTextWidget()
	{
	}
}
