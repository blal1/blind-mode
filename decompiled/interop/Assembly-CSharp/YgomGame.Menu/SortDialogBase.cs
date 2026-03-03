using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200117E")]
public abstract class SortDialogBase<RESULT> : SelectDialogViewControllerBase<RESULT>, IBokeSupported
{
	[Token(Token = "0x400B79C")]
	private const string k_EButtonFooter = "ButtonFooter";

	[Token(Token = "0x400B79D")]
	private const string k_ESortButtonsArea = "SortButtonsArea";

	[Token(Token = "0x400B79E")]
	private const string k_ETextTitle = "TextTitle";

	[Token(Token = "0x400B79F")]
	[FieldOffset(Offset = "0x0")]
	private RectTransform sortButtonArea;

	[Token(Token = "0x400B7A0")]
	[FieldOffset(Offset = "0x0")]
	private SelectionButton cancelButton;

	[Token(Token = "0x400B7A1")]
	[FieldOffset(Offset = "0x0")]
	private List<string> m_MethodLabelList;

	[Token(Token = "0x1700114A")]
	private RectTransform m_SortButtonArea
	{
		[Token(Token = "0x6006DB3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700114B")]
	private SelectionButton m_CancelButton
	{
		[Token(Token = "0x6006DB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006DB5")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006DB6")]
	protected abstract List<string> InitializeMethodLabelList();

	[Token(Token = "0x6006DB7")]
	protected abstract string GetText(string label);

	[Token(Token = "0x6006DB8")]
	protected abstract void OnClickAscCallback(string label);

	[Token(Token = "0x6006DB9")]
	protected abstract void OnClickDescCallback(string label);

	[Token(Token = "0x6006DBA")]
	protected abstract bool IsAscOn(string label);

	[Token(Token = "0x6006DBB")]
	protected abstract bool IsDescOn(string label);

	[Token(Token = "0x6006DBC")]
	protected abstract string GetTitle();

	[Token(Token = "0x6006DBD")]
	protected virtual bool IsUnorderedMethod(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DBE")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006DBF")]
	private void InitScroll()
	{
	}

	[Token(Token = "0x6006DC0")]
	protected SortDialogBase()
	{
	}
}
