using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000EB3")]
public class PreviewScreenFiller : ElementWidgetBehaviourBase<PreviewScreenFiller>
{
	[Token(Token = "0x400A430")]
	private const string k_ELabel_Sprite = "Sprite";

	[Token(Token = "0x400A431")]
	[FieldOffset(Offset = "0x28")]
	private SpriteRenderer fillSprite;

	[Token(Token = "0x400A432")]
	[FieldOffset(Offset = "0x30")]
	private float time;

	[Token(Token = "0x400A433")]
	[FieldOffset(Offset = "0x34")]
	private float fadeTime;

	[Token(Token = "0x400A434")]
	private const float DefaultFadeTime = 0.2f;

	[Token(Token = "0x400A435")]
	[FieldOffset(Offset = "0x38")]
	private Color startColor;

	[Token(Token = "0x400A436")]
	[FieldOffset(Offset = "0x48")]
	private Color targetColor;

	[Token(Token = "0x400A437")]
	[FieldOffset(Offset = "0x58")]
	private bool isLock;

	[Token(Token = "0x60058F1")]
	[Address(RVA = "0x9FA550", Offset = "0x9F9750", VA = "0x1809FA550")]
	public void Init()
	{
	}

	[Token(Token = "0x60058F2")]
	[Address(RVA = "0x9FA610", Offset = "0x9F9810", VA = "0x1809FA610")]
	public void Setup(Camera renderCamera)
	{
	}

	[Token(Token = "0x60058F3")]
	[Address(RVA = "0x9FA500", Offset = "0x9F9700", VA = "0x1809FA500")]
	public void Clear()
	{
	}

	[Token(Token = "0x60058F4")]
	[Address(RVA = "0x415450", Offset = "0x414650", VA = "0x180415450")]
	public void SetSpriteColor(Color color)
	{
	}

	[Token(Token = "0x60058F5")]
	[Address(RVA = "0x9FA730", Offset = "0x9F9930", VA = "0x1809FA730")]
	public void StartFade(Color targetColor, float fadeTime = 0.2f)
	{
	}

	[Token(Token = "0x60058F6")]
	[Address(RVA = "0x9FA7A0", Offset = "0x9F99A0", VA = "0x1809FA7A0")]
	private void UpdateFade(bool force = false)
	{
	}

	[Token(Token = "0x60058F7")]
	[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
	private void SetLock(bool isLock)
	{
	}

	[Token(Token = "0x60058F8")]
	[Address(RVA = "0x415450", Offset = "0x414650", VA = "0x180415450")]
	public void SetFillColor(Color color)
	{
	}

	[Token(Token = "0x60058F9")]
	[Address(RVA = "0x9FA730", Offset = "0x9F9930", VA = "0x1809FA730")]
	public void StartFillFade(Color color, float fadeTime = 0.2f)
	{
	}

	[Token(Token = "0x60058FA")]
	[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
	public void SetFillLock(bool isLock)
	{
	}

	[Token(Token = "0x60058FB")]
	[Address(RVA = "0x414EA0", Offset = "0x4140A0", VA = "0x180414EA0")]
	private void CheckEnabled()
	{
	}

	[Token(Token = "0x60058FC")]
	[Address(RVA = "0x9FA8E0", Offset = "0x9F9AE0", VA = "0x1809FA8E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60058FD")]
	[Address(RVA = "0x9FA8F0", Offset = "0x9F9AF0", VA = "0x1809FA8F0")]
	public PreviewScreenFiller()
	{
	}
}
