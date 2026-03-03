using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x200054C")]
[ExecuteAlways]
public class RectClippingMaskUpdater : UIBehaviour
{
	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<CanvasRenderer> m_CanvasRenderers;

	[Token(Token = "0x40019B2")]
	[FieldOffset(Offset = "0x28")]
	private List<RectMask2D> m_Masks;

	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0x30")]
	private bool m_MaskDirty;

	[Token(Token = "0x6002259")]
	[Address(RVA = "0x64D4B0", Offset = "0x64C6B0", VA = "0x18064D4B0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600225A")]
	[Address(RVA = "0x64D410", Offset = "0x64C610", VA = "0x18064D410")]
	[ContextMenu("CollectCanvasRenderers")]
	public void CollectCanvasRenderers()
	{
	}

	[Token(Token = "0x600225B")]
	[Address(RVA = "0x64D790", Offset = "0x64C990", VA = "0x18064D790")]
	public void UpdateMasks()
	{
	}

	[Token(Token = "0x600225C")]
	[Address(RVA = "0x64D5C0", Offset = "0x64C7C0", VA = "0x18064D5C0")]
	public void UpdateClipping()
	{
	}

	[Token(Token = "0x600225D")]
	[Address(RVA = "0x64D5A0", Offset = "0x64C7A0", VA = "0x18064D5A0", Slot = "15")]
	protected override void OnCanvasHierarchyChanged()
	{
	}

	[Token(Token = "0x600225E")]
	[Address(RVA = "0x64D5A0", Offset = "0x64C7A0", VA = "0x18064D5A0", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x600225F")]
	[Address(RVA = "0x64D5A0", Offset = "0x64C7A0", VA = "0x18064D5A0", Slot = "12")]
	protected override void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x6002260")]
	[Address(RVA = "0x64D870", Offset = "0x64CA70", VA = "0x18064D870")]
	public RectClippingMaskUpdater()
	{
	}
}
