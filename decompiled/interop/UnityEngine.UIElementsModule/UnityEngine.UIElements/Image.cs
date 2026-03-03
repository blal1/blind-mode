using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000DD")]
public class Image : VisualElement
{
	[Token(Token = "0x20000DE")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Image, UxmlTraits>
	{
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2AD8A50", Offset = "0x2AD7C50", VA = "0x182AD8A50")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000DF")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2AD9F30", Offset = "0x2AD9130", VA = "0x182AD9F30")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId imageProperty;

	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId spriteProperty;

	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId vectorImageProperty;

	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId sourceRectProperty;

	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x260")]
	internal static readonly BindingId uvProperty;

	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x2F8")]
	internal static readonly BindingId scaleModeProperty;

	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x390")]
	internal static readonly BindingId tintColorProperty;

	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x4A8")]
	private ScaleMode m_ScaleMode;

	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x4B0")]
	private Texture m_Image;

	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x4B8")]
	private Sprite m_Sprite;

	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x4C0")]
	private VectorImage m_VectorImage;

	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x4C8")]
	private Rect m_UV;

	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x4D8")]
	private Color m_TintColor;

	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x4E8")]
	internal bool m_ImageIsInline;

	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x4E9")]
	private bool m_ScaleModeIsInline;

	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x4EA")]
	private bool m_TintColorIsInline;

	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x428")]
	public static readonly string ussClassName;

	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x430")]
	private static CustomStyleProperty<Texture2D> s_ImageProperty;

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x438")]
	private static CustomStyleProperty<Sprite> s_SpriteProperty;

	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x440")]
	private static CustomStyleProperty<VectorImage> s_VectorImageProperty;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x448")]
	private static CustomStyleProperty<string> s_ScaleModeProperty;

	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x450")]
	private static CustomStyleProperty<Color> s_TintColorProperty;

	[Token(Token = "0x170000F7")]
	[CreateProperty]
	public Texture image
	{
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2A999A0", Offset = "0x2A98BA0", VA = "0x182A999A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2ACB2F0", Offset = "0x2ACA4F0", VA = "0x182ACB2F0")]
		set
		{
		}
	}

	[Token(Token = "0x170000F8")]
	[CreateProperty]
	public Sprite sprite
	{
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x29FCCC0", Offset = "0x29FBEC0", VA = "0x1829FCCC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2ACB640", Offset = "0x2ACA840", VA = "0x182ACB640")]
		set
		{
		}
	}

	[Token(Token = "0x170000F9")]
	[CreateProperty]
	public VectorImage vectorImage
	{
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2AAE730", Offset = "0x2AAD930", VA = "0x182AAE730")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2ACB970", Offset = "0x2ACAB70", VA = "0x182ACB970")]
		set
		{
		}
	}

	[Token(Token = "0x170000FA")]
	[CreateProperty]
	public Rect sourceRect
	{
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2ACB2A0", Offset = "0x2ACA4A0", VA = "0x182ACB2A0")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2ACB4C0", Offset = "0x2ACA6C0", VA = "0x182ACB4C0")]
		set
		{
		}
	}

	[Token(Token = "0x170000FB")]
	[CreateProperty]
	public Rect uv
	{
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x2ACB2E0", Offset = "0x2ACA4E0", VA = "0x182ACB2E0")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2ACB8A0", Offset = "0x2ACAAA0", VA = "0x182ACB8A0")]
		set
		{
		}
	}

	[Token(Token = "0x170000FC")]
	[CreateProperty]
	public ScaleMode scaleMode
	{
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2ACB290", Offset = "0x2ACA490", VA = "0x182ACB290")]
		get
		{
			return default(ScaleMode);
		}
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2ACB490", Offset = "0x2ACA690", VA = "0x182ACB490")]
		set
		{
		}
	}

	[Token(Token = "0x170000FD")]
	[CreateProperty]
	public Color tintColor
	{
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2ACB2D0", Offset = "0x2ACA4D0", VA = "0x182ACB2D0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2ACB800", Offset = "0x2ACAA00", VA = "0x182ACB800")]
		set
		{
		}
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x2ACB0C0", Offset = "0x2ACA2C0", VA = "0x182ACB0C0")]
	public Image()
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x2AC9700", Offset = "0x2AC8900", VA = "0x182AC9700")]
	private Vector2 GetTextureDisplaySize(Texture texture)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x2AC97F0", Offset = "0x2AC89F0", VA = "0x182AC97F0")]
	private Vector2 GetTextureDisplaySize(Sprite sprite)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x2AC9140", Offset = "0x2AC8340", VA = "0x182AC9140", Slot = "135")]
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x2AC9980", Offset = "0x2AC8B80", VA = "0x182AC9980")]
	private void OnGenerateVisualContent(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x2AC9940", Offset = "0x2AC8B40", VA = "0x182AC9940")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x2AC9F60", Offset = "0x2AC9160", VA = "0x182AC9F60")]
	private void ReadCustomProperties(ICustomStyle customStyleProvider)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60006CB")]
	private void SetProperty<T0, T1, T2>(T0 src, ref T0 dst, ref T1 alt0, ref T2 alt1, BindingId binding) where T0 : Object where T1 : Object where T2 : Object
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x2AC8CE0", Offset = "0x2AC7EE0", VA = "0x182AC8CE0")]
	private void ClearProperty()
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x2ACA710", Offset = "0x2AC9910", VA = "0x182ACA710")]
	private void SetScaleMode(ScaleMode mode)
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x2ACA7A0", Offset = "0x2AC99A0", VA = "0x182ACA7A0")]
	private void SetTintColor(Color color)
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x2AC8B00", Offset = "0x2AC7D00", VA = "0x182AC8B00")]
	private void CalculateUV(Rect srcRect)
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x2AC9500", Offset = "0x2AC8700", VA = "0x182AC9500")]
	private Rect GetSourceRect()
	{
		return default(Rect);
	}
}
