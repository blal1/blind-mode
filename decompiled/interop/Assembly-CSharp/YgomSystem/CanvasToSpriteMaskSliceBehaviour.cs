using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem;

[Token(Token = "0x20001A6")]
public class CanvasToSpriteMaskSliceBehaviour : ICanvasToSpriteMaskBehaviour
{
	[Token(Token = "0x20001A7")]
	private enum SlicePos
	{
		[Token(Token = "0x40009F6")]
		BottomLeft,
		[Token(Token = "0x40009F7")]
		BottomCenter,
		[Token(Token = "0x40009F8")]
		BottomRight,
		[Token(Token = "0x40009F9")]
		MiddleLeft,
		[Token(Token = "0x40009FA")]
		MiddleCenter,
		[Token(Token = "0x40009FB")]
		MiddleRight,
		[Token(Token = "0x40009FC")]
		TopLeft,
		[Token(Token = "0x40009FD")]
		TopCenter,
		[Token(Token = "0x40009FE")]
		TopRight
	}

	[Token(Token = "0x40009E7")]
	private const int k_SliceSizeMin = 2;

	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0x10")]
	private Mask m_SourceMask;

	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0x18")]
	private Sprite m_SourceMaskSprite;

	[Token(Token = "0x40009EA")]
	[FieldOffset(Offset = "0x20")]
	private float m_SourcePixelsPerUnitRate;

	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 m_SourceBorderSize;

	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 m_SourceSliceSize;

	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 m_SourceRectSize;

	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 m_SourceSliceScale;

	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform m_SliceMaskLocator;

	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x50")]
	private SpriteMask[] m_SliceMasks;

	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x58")]
	private Vector2[] m_SliceMasksPos;

	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x60")]
	private Vector2[] m_SliceMasksScale;

	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x68")]
	private Color[][] m_SliceMasksColors;

	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x70")]
	private bool[][] m_SliceMasksClipCache;

	[Token(Token = "0x1700011F")]
	public CanvasToSpriteMask.BehaviourType behaviourType
	{
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "8")]
		get
		{
			return default(CanvasToSpriteMask.BehaviourType);
		}
	}

	[Token(Token = "0x17000120")]
	public bool exists
	{
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xC05930", Offset = "0xC04B30", VA = "0x180C05930", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000121")]
	public Component sourceMask
	{
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000122")]
	public Canvas sourceMaskCanvas
	{
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xC059C0", Offset = "0xC04BC0", VA = "0x180C059C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000123")]
	public IReadOnlyList<SpriteMask> allSpriteMasks
	{
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0xC04C70", Offset = "0xC03E70", VA = "0x180C04C70")]
	public bool IsValidMask(Mask targetMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0xC04B30", Offset = "0xC03D30", VA = "0x180C04B30")]
	public bool IsCachedMask(Mask targetMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0xC02690", Offset = "0xC01890", VA = "0x180C02690", Slot = "4")]
	public bool ApplyMask(RectTransform parent, Component sourceMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0xC03970", Offset = "0xC02B70", VA = "0x180C03970", Slot = "5")]
	public void ApplyTranLocate()
	{
	}

	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0xC02C70", Offset = "0xC01E70", VA = "0x180C02C70", Slot = "6")]
	public void ApplyRect2DClip(Rect clipScreenRect, Camera canvasCamera, RectTransform canvasRootRt, RectTransform maskRootRt)
	{
	}

	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0xC05540", Offset = "0xC04740", VA = "0x180C05540", Slot = "7")]
	public void ReleaseResources()
	{
	}

	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0xC04690", Offset = "0xC03890", VA = "0x180C04690")]
	private Texture2D CreateSourceTexture(Sprite sourceSprite)
	{
		return null;
	}

	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0xC03F40", Offset = "0xC03140", VA = "0x180C03F40")]
	private SpriteMask CreateSlicedSpriteMask(Transform parent, SlicePos slicePos, Texture2D sourceTex)
	{
		return null;
	}

	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0xC04140", Offset = "0xC03340", VA = "0x180C04140")]
	private Sprite CreateSlicedSprite(SlicePos slicePos, Texture2D sourceTex, out int slicedPosX, out int slicedPosY)
	{
		return null;
	}

	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0xC04E40", Offset = "0xC04040", VA = "0x180C04E40")]
	private void ReadSourceSpriteInfo(Mask sourceMask)
	{
	}

	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0xC04D70", Offset = "0xC03F70", VA = "0x180C04D70")]
	private void ReadSourceRectInfo()
	{
	}

	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0xC05050", Offset = "0xC04250", VA = "0x180C05050")]
	private void RefreshMasksTranLocate()
	{
	}

	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0xC03C70", Offset = "0xC02E70", VA = "0x180C03C70")]
	private static void CalcSlicedTexSize(Sprite sourceSprite, SlicePos slicePos, out int width, out int height)
	{
	}

	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0xC03A50", Offset = "0xC02C50", VA = "0x180C03A50")]
	private static void CalcSlicedTexPos(Sprite sourceSprite, SlicePos slicePos, out int posX, out int posY)
	{
	}

	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0xC05840", Offset = "0xC04A40", VA = "0x180C05840")]
	public CanvasToSpriteMaskSliceBehaviour()
	{
	}
}
