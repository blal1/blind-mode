using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000562")]
[RequireComponent(typeof(SortingGroup))]
public class UISpriteMaskLocator : UIBehaviour
{
	[Token(Token = "0x4001A3C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SpriteMask m_SpriteMaskPref;

	[Token(Token = "0x4001A3D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("ランタイムで自動セット")]
	private SpriteMask m_SpriteMask;

	[Token(Token = "0x4001A3E")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_SpriteMaskRoot;

	[Token(Token = "0x4001A3F")]
	[FieldOffset(Offset = "0x38")]
	private Canvas m_ParentCanvas;

	[Token(Token = "0x4001A40")]
	[FieldOffset(Offset = "0x40")]
	private List<RectMask2D> m_Masks;

	[Token(Token = "0x4001A41")]
	[FieldOffset(Offset = "0x48")]
	private List<ParticleSystemRenderer> m_Particles;

	[Token(Token = "0x4001A42")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_LastWorldPos;

	[Token(Token = "0x4001A43")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_Dirty;

	[Token(Token = "0x170003BF")]
	public SpriteMask spriteMaskPref
	{
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x659200", Offset = "0x658400", VA = "0x180659200", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60022E9")]
	[Address(RVA = "0x658620", Offset = "0x657820", VA = "0x180658620", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x6583E0", Offset = "0x6575E0", VA = "0x1806583E0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x658580", Offset = "0x657780", VA = "0x180658580", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x6586C0", Offset = "0x6578C0", VA = "0x1806586C0")]
	private void RefreshComponents()
	{
	}

	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x658D00", Offset = "0x657F00", VA = "0x180658D00")]
	private void RefreshTransform()
	{
	}

	[Token(Token = "0x60022EE")]
	[Address(RVA = "0x658F40", Offset = "0x658140", VA = "0x180658F40")]
	private void SettingSpriteMask(RectMask2D selfMask)
	{
	}

	[Token(Token = "0x60022EF")]
	[Address(RVA = "0x658BA0", Offset = "0x657DA0", VA = "0x180658BA0")]
	public void RefreshSortingGruop()
	{
	}

	[Token(Token = "0x60022F0")]
	[Address(RVA = "0x658860", Offset = "0x657A60", VA = "0x180658860")]
	private void RefreshMaskRoot()
	{
	}

	[Token(Token = "0x60022F1")]
	[Address(RVA = "0x6584D0", Offset = "0x6576D0", VA = "0x1806584D0", Slot = "14")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x60022F2")]
	[Address(RVA = "0x6584D0", Offset = "0x6576D0", VA = "0x1806584D0", Slot = "15")]
	protected override void OnCanvasHierarchyChanged()
	{
	}

	[Token(Token = "0x60022F3")]
	[Address(RVA = "0x6584D0", Offset = "0x6576D0", VA = "0x1806584D0", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x60022F4")]
	[Address(RVA = "0x6584D0", Offset = "0x6576D0", VA = "0x1806584D0", Slot = "12")]
	protected override void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x60022F5")]
	[Address(RVA = "0x6584F0", Offset = "0x6576F0", VA = "0x1806584F0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60022F6")]
	[Address(RVA = "0x659230", Offset = "0x658430", VA = "0x180659230")]
	public UISpriteMaskLocator()
	{
	}
}
