using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomSystem.UI;

[Token(Token = "0x2000529")]
public class CanvasAlphaSyncer : UIBehaviour
{
	[Serializable]
	[Token(Token = "0x200052A")]
	private class TargetData
	{
		[Token(Token = "0x4001932")]
		[FieldOffset(Offset = "0x10")]
		public Renderer renderer;

		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x18")]
		public string alphaParamName;

		[Token(Token = "0x600218A")]
		[Address(RVA = "0x6381E0", Offset = "0x6373E0", VA = "0x1806381E0")]
		public TargetData()
		{
		}
	}

	[Token(Token = "0x400192E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TargetData> m_Targets;

	[Token(Token = "0x400192F")]
	[FieldOffset(Offset = "0x28")]
	protected float m_LastAlpha;

	[Token(Token = "0x4001930")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_CanvasGroupDirty;

	[Token(Token = "0x4001931")]
	[FieldOffset(Offset = "0x30")]
	private List<CanvasGroup> m_CanvasGroups;

	[Token(Token = "0x600217E")]
	[Address(RVA = "0x6352A0", Offset = "0x6344A0", VA = "0x1806352A0", Slot = "11")]
	protected override void OnBeforeTransformParentChanged()
	{
	}

	[Token(Token = "0x600217F")]
	[Address(RVA = "0x6352D0", Offset = "0x6344D0", VA = "0x1806352D0", Slot = "14")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x6002180")]
	[Address(RVA = "0x6352A0", Offset = "0x6344A0", VA = "0x1806352A0", Slot = "15")]
	protected override void OnCanvasHierarchyChanged()
	{
	}

	[Token(Token = "0x6002181")]
	[Address(RVA = "0x6352A0", Offset = "0x6344A0", VA = "0x1806352A0", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x6002182")]
	[Address(RVA = "0x6352A0", Offset = "0x6344A0", VA = "0x1806352A0", Slot = "12")]
	protected override void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x6002183")]
	[Address(RVA = "0x6346D0", Offset = "0x6338D0", VA = "0x1806346D0")]
	private void OnDirtyAlpha()
	{
	}

	[Token(Token = "0x6002184")]
	[Address(RVA = "0x5F5C60", Offset = "0x5F4E60", VA = "0x1805F5C60")]
	private void OnDirtyTransformTree()
	{
	}

	[Token(Token = "0x6002185")]
	[Address(RVA = "0x635230", Offset = "0x634430", VA = "0x180635230")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002186")]
	[Address(RVA = "0x634E30", Offset = "0x634030", VA = "0x180634E30", Slot = "17")]
	public virtual void Apply()
	{
	}

	[Token(Token = "0x6002187")]
	[Address(RVA = "0x6350F0", Offset = "0x6342F0", VA = "0x1806350F0", Slot = "18")]
	protected virtual void CollectCanvasGroups()
	{
	}

	[Token(Token = "0x6002188")]
	[Address(RVA = "0x634FB0", Offset = "0x6341B0", VA = "0x180634FB0")]
	private float CalcSourceAlpha()
	{
		return default(float);
	}

	[Token(Token = "0x6002189")]
	[Address(RVA = "0x635300", Offset = "0x634500", VA = "0x180635300")]
	public CanvasAlphaSyncer()
	{
	}
}
