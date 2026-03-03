using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CF8")]
public class MDMarkupImageWidget : MDMarkupWidgetBase, IMDMarkupFreeScrollHandler
{
	[Token(Token = "0x2000CF9")]
	[CompilerGenerated]
	private sealed class _003CWaitFreeScrollVeiw_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009D03")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009D04")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009D05")]
		[FieldOffset(Offset = "0x20")]
		public MDMarkupImageWidget _003C_003E4__this;

		[Token(Token = "0x4009D06")]
		[FieldOffset(Offset = "0x28")]
		public WidgetButtonCollector collector;

		[Token(Token = "0x17000B14")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004E55")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B15")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004E57")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWaitFreeScrollVeiw_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004E53")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004E54")]
		[Address(RVA = "0x9614A0", Offset = "0x9606A0", VA = "0x1809614A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x961590", Offset = "0x960790", VA = "0x180961590", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009CFE")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelImage;

	[Token(Token = "0x4009CFF")]
	[FieldOffset(Offset = "0x30")]
	public readonly Image m_Image;

	[Token(Token = "0x4009D00")]
	[FieldOffset(Offset = "0x38")]
	private FreeScrollView m_FreeScroll;

	[Token(Token = "0x4009D01")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsReady;

	[Token(Token = "0x4009D02")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_CreatedObject;

	[Token(Token = "0x17000B13")]
	public override bool isReady
	{
		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004E49")]
	[Address(RVA = "0x955930", Offset = "0x954B30", VA = "0x180955930")]
	public MDMarkupImageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004E4A")]
	[Address(RVA = "0x955290", Offset = "0x954490", VA = "0x180955290", Slot = "17")]
	public override void BindContentData(IMDMarkupContent mdMarkupContent)
	{
	}

	[Token(Token = "0x6004E4B")]
	[Address(RVA = "0x9556C0", Offset = "0x9548C0", VA = "0x1809556C0", Slot = "18")]
	public override void OnReady()
	{
	}

	[Token(Token = "0x6004E4C")]
	[Address(RVA = "0x9558A0", Offset = "0x954AA0", VA = "0x1809558A0")]
	[IteratorStateMachine(typeof(_003CWaitFreeScrollVeiw_003Ed__10))]
	private IEnumerator WaitFreeScrollVeiw(WidgetButtonCollector collector)
	{
		return null;
	}

	[Token(Token = "0x6004E4D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "19")]
	public void AssignSelectionItem(SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x6004E4E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "20")]
	public void ProgressSelectionPosY()
	{
	}

	[Token(Token = "0x6004E4F")]
	[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520", Slot = "21")]
	public void SetFreeScrollView(FreeScrollView scroll)
	{
	}
}
