using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FDC")]
public abstract class ContentWidgetBase<T, ENTRY> : ElementWidgetUIBehaviourBase<T>, IContentWidget where T : ContentWidgetBase<T, ENTRY> where ENTRY : class, IEntryData
{
	[Token(Token = "0x400AB43")]
	[FieldOffset(Offset = "0x0")]
	private CommonDialogContentContainerWidget m_ParentWidget;

	[Token(Token = "0x17000F1E")]
	public CommonDialogContentContainerWidget parentWidget
	{
		[Token(Token = "0x6006013")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006014")]
	public void Initialize(CommonDialogContentContainerWidget parentWidget)
	{
	}

	[Token(Token = "0x6006015")]
	public IContentWidget DuplicateInstantiate()
	{
		return null;
	}

	[Token(Token = "0x6006016")]
	public void Binding(IEntryData entryData)
	{
	}

	[Token(Token = "0x6006017")]
	protected abstract void InnerBinding(ENTRY entryData);

	[Token(Token = "0x6006018")]
	protected ContentWidgetBase()
	{
	}

	[Token(Token = "0x6006019")]
	private GameObject YgomGame_002EDialog_002ECommonDialog_002EIContentWidget_002Eget_gameObject()
	{
		return null;
	}

	[Token(Token = "0x600601A")]
	private Transform YgomGame_002EDialog_002ECommonDialog_002EIContentWidget_002Eget_transform()
	{
		return null;
	}
}
