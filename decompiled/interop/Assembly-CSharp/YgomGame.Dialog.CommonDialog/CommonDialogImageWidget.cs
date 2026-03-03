using System;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FCD")]
public class CommonDialogImageWidget : ContentWidgetBase<CommonDialogImageWidget, EntryImageData>, IContentWidgetAsyncLoader
{
	[Token(Token = "0x400AAFA")]
	[FieldOffset(Offset = "0x30")]
	private Image m_Image;

	[Token(Token = "0x400AAFB")]
	[FieldOffset(Offset = "0x38")]
	private LayoutElement m_LayoutElement;

	[Token(Token = "0x400AAFC")]
	[FieldOffset(Offset = "0x40")]
	private Action m_OnCompleteCallback;

	[Token(Token = "0x6005FC0")]
	[Address(RVA = "0xA54430", Offset = "0xA53630", VA = "0x180A54430")]
	public static CommonDialogImageWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005FC1")]
	[Address(RVA = "0xA54380", Offset = "0xA53580", VA = "0x180A54380", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005FC2")]
	[Address(RVA = "0xA54470", Offset = "0xA53670", VA = "0x180A54470", Slot = "24")]
	protected override void InnerBinding(EntryImageData entryData)
	{
	}

	[Token(Token = "0x6005FC3")]
	[Address(RVA = "0xA54310", Offset = "0xA53510", VA = "0x180A54310", Slot = "25")]
	public void AsyncBinding(IEntryData entryData, Action onComplete)
	{
	}

	[Token(Token = "0x6005FC4")]
	[Address(RVA = "0xA545A0", Offset = "0xA537A0", VA = "0x180A545A0")]
	private void RefreshLayoutElement()
	{
	}

	[Token(Token = "0x6005FC5")]
	[Address(RVA = "0xA54580", Offset = "0xA53780", VA = "0x180A54580", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x6005FC6")]
	[Address(RVA = "0xA548C0", Offset = "0xA53AC0", VA = "0x180A548C0")]
	public CommonDialogImageWidget()
	{
	}
}
