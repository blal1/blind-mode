using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem;

[Token(Token = "0x20001A5")]
public class CanvasToSpriteMaskRect2DBehaviour : ICanvasToSpriteMaskBehaviour
{
	[Token(Token = "0x40009E3")]
	private const int k_MaskTexSize = 2;

	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x10")]
	private RectMask2D m_SourceMask;

	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x18")]
	private SpriteMask m_SpriteMask;

	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x20")]
	private SpriteMask[] m_SpriteMasks;

	[Token(Token = "0x1700011A")]
	public CanvasToSpriteMask.BehaviourType behaviourType
	{
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "8")]
		get
		{
			return default(CanvasToSpriteMask.BehaviourType);
		}
	}

	[Token(Token = "0x1700011B")]
	public bool exists
	{
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xC025A0", Offset = "0xC017A0", VA = "0x180C025A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700011C")]
	public Component sourceMask
	{
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700011D")]
	public Canvas sourceMaskCanvas
	{
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xC02630", Offset = "0xC01830", VA = "0x180C02630", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700011E")]
	public IReadOnlyList<SpriteMask> allSpriteMasks
	{
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0xC02360", Offset = "0xC01560", VA = "0x180C02360")]
	public bool IsValidMask(RectMask2D targetMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0xC022B0", Offset = "0xC014B0", VA = "0x180C022B0")]
	public bool IsCachedMask(RectMask2D targetMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0xC016F0", Offset = "0xC008F0", VA = "0x180C016F0", Slot = "4")]
	public bool ApplyMask(RectTransform parent, Component sourceMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0xC01C60", Offset = "0xC00E60", VA = "0x180C01C60", Slot = "5")]
	public void ApplyTranLocate()
	{
	}

	[Token(Token = "0x6000A90")]
	[Address(RVA = "0xC01900", Offset = "0xC00B00", VA = "0x180C01900", Slot = "6")]
	public void ApplyRect2DClip(Rect clipScreenRect, Camera canvasCamera, RectTransform canvasRootRt, RectTransform maskRootRt)
	{
	}

	[Token(Token = "0x6000A91")]
	[Address(RVA = "0xC023B0", Offset = "0xC015B0", VA = "0x180C023B0", Slot = "7")]
	public void ReleaseResources()
	{
	}

	[Token(Token = "0x6000A92")]
	[Address(RVA = "0xC01EC0", Offset = "0xC010C0", VA = "0x180C01EC0")]
	private SpriteMask CreateSpriteMask(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000A93")]
	[Address(RVA = "0xC01C70", Offset = "0xC00E70", VA = "0x180C01C70")]
	private Sprite CreateMaskSprite()
	{
		return null;
	}

	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CanvasToSpriteMaskRect2DBehaviour()
	{
	}
}
