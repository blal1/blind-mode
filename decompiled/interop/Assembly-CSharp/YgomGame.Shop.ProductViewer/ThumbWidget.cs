using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop.ProductViewer;

[Token(Token = "0x20009F2")]
public class ThumbWidget : ElementWidgetBase
{
	[Token(Token = "0x4008E7B")]
	private const string k_GLabel_DXIcon_Default = "DXIcon_Default";

	[Token(Token = "0x4008E7C")]
	private const string k_GLabel_DXIcon_UpperLimitDate = "DXIcon_UpperLimitDate";

	[Token(Token = "0x4008E7D")]
	private const string k_ELabel_ViewerInfoGroup = "ViewerInfoGroup";

	[Token(Token = "0x4008E7E")]
	private const string k_ELabel_ViewerInfoText = "ViewerInfoText";

	[Token(Token = "0x4008E7F")]
	private const string k_ELabel_DXIcon_Root = "DXIconRoot";

	[Token(Token = "0x4008E80")]
	private const string k_ELabel_DXIcon_Based = "DXIconImage";

	[Token(Token = "0x4008E81")]
	private const string k_ELabel_DXIcon_Floating = "DXIconFloatingImage";

	[Token(Token = "0x4008E82")]
	[FieldOffset(Offset = "0x20")]
	public readonly BindingShopProductThumb bindingShopThumb;

	[Token(Token = "0x4008E83")]
	[FieldOffset(Offset = "0x28")]
	public readonly BindingMateRenderTexture mateBinder;

	[Token(Token = "0x4008E84")]
	[FieldOffset(Offset = "0x30")]
	public readonly RawImage summonRawImage;

	[Token(Token = "0x4008E85")]
	[FieldOffset(Offset = "0x38")]
	public readonly CanvasGroup canvasGroup;

	[Token(Token = "0x4008E86")]
	[FieldOffset(Offset = "0x40")]
	public readonly GameObject dxIconRoot;

	[Token(Token = "0x4008E87")]
	[FieldOffset(Offset = "0x48")]
	private readonly GameObject viewerInfoGroup;

	[Token(Token = "0x4008E88")]
	[FieldOffset(Offset = "0x50")]
	private readonly TMP_Text viewerInfoText;

	[Token(Token = "0x4008E89")]
	[FieldOffset(Offset = "0x58")]
	public SelectionButton mateButton;

	[Token(Token = "0x1700080E")]
	public GameObject dxIcon_Based
	{
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x8402B0", Offset = "0x83F4B0", VA = "0x1808402B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700080F")]
	public GameObject dxIcon_Floating
	{
		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x840300", Offset = "0x83F500", VA = "0x180840300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CAD")]
	[Address(RVA = "0x83F7F0", Offset = "0x83E9F0", VA = "0x18083F7F0")]
	public void ForceFinishTween()
	{
	}

	[Token(Token = "0x6003CAE")]
	[Address(RVA = "0x83F6D0", Offset = "0x83E8D0", VA = "0x18083F6D0", Slot = "9")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6003CAF")]
	[Address(RVA = "0x83F880", Offset = "0x83EA80", VA = "0x18083F880")]
	public bool IsExistsThumb()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CB0")]
	[Address(RVA = "0x83F860", Offset = "0x83EA60", VA = "0x18083F860")]
	public bool IsExistsSummon()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CB1")]
	[Address(RVA = "0x840350", Offset = "0x83F550", VA = "0x180840350")]
	public bool isReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CB2")]
	[Address(RVA = "0x8400A0", Offset = "0x83F2A0", VA = "0x1808400A0")]
	public ThumbWidget(ElementObjectManager eom, bool isMain)
	{
	}

	[Token(Token = "0x6003CB3")]
	[Address(RVA = "0x83FFC0", Offset = "0x83F1C0", VA = "0x18083FFC0")]
	public void SwitchDXIconOverriderGroup(bool isExistsLimitDate)
	{
	}

	[Token(Token = "0x6003CB4")]
	[Address(RVA = "0x83F980", Offset = "0x83EB80", VA = "0x18083F980")]
	public void SetActivateByContext(HighlightContext context)
	{
	}

	[Token(Token = "0x6003CB5")]
	[Address(RVA = "0x83F9C0", Offset = "0x83EBC0", VA = "0x18083F9C0")]
	public void SetActivateToMate()
	{
	}

	[Token(Token = "0x6003CB6")]
	[Address(RVA = "0x83FB40", Offset = "0x83ED40", VA = "0x18083FB40")]
	public void SetActivateToSummon(bool duelPreview)
	{
	}

	[Token(Token = "0x6003CB7")]
	[Address(RVA = "0x83FD20", Offset = "0x83EF20", VA = "0x18083FD20")]
	public void SetActivateToThumb()
	{
	}

	[Token(Token = "0x6003CB8")]
	[Address(RVA = "0x83FEA0", Offset = "0x83F0A0", VA = "0x18083FEA0")]
	private void SetViewerInformTest(string text)
	{
	}

	[Token(Token = "0x6003CB9")]
	[Address(RVA = "0x83EFA0", Offset = "0x83E1A0", VA = "0x18083EFA0")]
	public IAsyncProgressContent ApplyContext(HighlightContext highlightContext)
	{
		return null;
	}

	[Token(Token = "0x6003CBA")]
	[Address(RVA = "0x83F360", Offset = "0x83E560", VA = "0x18083F360")]
	public void CaptureTo(ThumbWidget target)
	{
	}

	[Token(Token = "0x6003CBB")]
	[Address(RVA = "0x83F8C0", Offset = "0x83EAC0", VA = "0x18083F8C0")]
	public void ReleaseResources()
	{
	}
}
