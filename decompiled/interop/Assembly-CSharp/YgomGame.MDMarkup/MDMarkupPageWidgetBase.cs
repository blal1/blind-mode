using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CFD")]
public class MDMarkupPageWidgetBase : MDMarkupWidgetBase, IMDMarkupPageWidget, IMDMarkupGraphWidget
{
	[Token(Token = "0x4009D19")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelCaption;

	[Token(Token = "0x4009D1A")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelText;

	[Token(Token = "0x4009D1B")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelImage;

	[Token(Token = "0x4009D1C")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelMarkupRoot;

	[Token(Token = "0x4009D1D")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelButtonFormat;

	[Token(Token = "0x4009D1E")]
	[FieldOffset(Offset = "0x50")]
	public readonly GameObject m_ImageTarget;

	[Token(Token = "0x4009D1F")]
	[FieldOffset(Offset = "0x58")]
	public readonly TextMeshProUGUI m_CaptionText;

	[Token(Token = "0x4009D20")]
	[FieldOffset(Offset = "0x60")]
	public readonly TextMeshProUGUI m_Text;

	[Token(Token = "0x4009D21")]
	[FieldOffset(Offset = "0x68")]
	public readonly Transform m_MarkupRoot;

	[Token(Token = "0x4009D22")]
	[FieldOffset(Offset = "0x70")]
	public readonly List<SelectionButton> buttons;

	[Token(Token = "0x17000B18")]
	private List<SelectionButton> YgomGame_002EMDMarkup_002EIMDMarkupPageWidget_002Ebuttons
	{
		[Token(Token = "0x6004E68")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000072")]
	public event Action<bool> onFocusPageEvent
	{
		[Token(Token = "0x6004E69")]
		[Address(RVA = "0x956C30", Offset = "0x955E30", VA = "0x180956C30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004E6A")]
		[Address(RVA = "0x956CE0", Offset = "0x955EE0", VA = "0x180956CE0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6004E6B")]
	[Address(RVA = "0x9568E0", Offset = "0x955AE0", VA = "0x1809568E0")]
	public MDMarkupPageWidgetBase(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004E6C")]
	[Address(RVA = "0x955FD0", Offset = "0x9551D0", VA = "0x180955FD0", Slot = "17")]
	public override void BindContentData(IMDMarkupContent mdMarkupContent)
	{
	}

	[Token(Token = "0x6004E6D")]
	[Address(RVA = "0x9567A0", Offset = "0x9559A0", VA = "0x1809567A0", Slot = "22")]
	public void OutputMarkupGraph(IMDMarkupContent mdMarkupContent, MDMarkupGraphFactory markupGraphFactory, Action onComplete)
	{
	}

	[Token(Token = "0x6004E6E")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "23")]
	protected virtual GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E6F")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "24")]
	protected virtual GlobalTextData GetText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E70")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "25")]
	protected virtual MDMarkupBannerContext GetBannerContext(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E71")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "26")]
	protected virtual string GetResourcePath(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E72")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "27")]
	protected virtual List<URLSchemeButton> GetButtons(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E73")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "28")]
	protected virtual List<IMDMarkupContent> GetMarkupContents(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E74")]
	[Address(RVA = "0x956780", Offset = "0x955980", VA = "0x180956780")]
	public void OnFocusPage(bool isFirst)
	{
	}
}
