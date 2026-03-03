using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace YgomSystem;

[Token(Token = "0x20001A3")]
[ExecuteAlways]
public class CanvasToSpriteMask : UIBehaviour
{
	[Token(Token = "0x20001A4")]
	public enum BehaviourType
	{
		[Token(Token = "0x40009E0")]
		None,
		[Token(Token = "0x40009E1")]
		Rect2D,
		[Token(Token = "0x40009E2")]
		Image
	}

	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BehaviourType m_BehaviourType;

	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Mask m_SourceImageMask;

	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectMask2D m_SourceRectMask2D;

	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 1f)]
	[SerializeField]
	private float m_AlphaCutoff;

	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool m_IsCustomRangeActive;

	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int m_FrontSortingLayerID;

	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int m_FrontSortingOrder;

	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int m_BackSortingLayerID;

	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int m_BackSortingOrder;

	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private uint m_RenderingLayerMask;

	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x58")]
	private ICanvasToSpriteMaskBehaviour m_Behaviour;

	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform m_SpriteMaskRoot;

	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x68")]
	private List<RectMask2D> m_ClipMasksSearch;

	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x70")]
	private List<RectMask2D> m_ClipMasks;

	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 m_LastWorldPos;

	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x84")]
	private Vector2 m_LastScreenSize;

	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_LaunchDirty;

	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x8D")]
	private bool m_TranLocateDirty;

	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x8E")]
	private bool m_Rect2DClipDirty;

	[Token(Token = "0x17000117")]
	public BehaviourType behaviourType
	{
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(BehaviourType);
		}
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xC07840", Offset = "0xC06A40", VA = "0x180C07840")]
		set
		{
		}
	}

	[Token(Token = "0x17000118")]
	private Component sourceMask
	{
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xC07820", Offset = "0xC06A20", VA = "0x180C07820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000119")]
	private bool exists
	{
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xC077D0", Offset = "0xC069D0", VA = "0x180C077D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000A74")]
	[Address(RVA = "0xC06270", Offset = "0xC05470", VA = "0x180C06270", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000A75")]
	[Address(RVA = "0xC07300", Offset = "0xC06500", VA = "0x180C07300")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A76")]
	[Address(RVA = "0xC06050", Offset = "0xC05250", VA = "0x180C06050")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000A77")]
	[Address(RVA = "0xC061C0", Offset = "0xC053C0", VA = "0x180C061C0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000A78")]
	[Address(RVA = "0xC05EF0", Offset = "0xC050F0", VA = "0x180C05EF0")]
	private ICanvasToSpriteMaskBehaviour CreateBehaviour(BehaviourType behaviourType)
	{
		return null;
	}

	[Token(Token = "0x6000A79")]
	[Address(RVA = "0xC07190", Offset = "0xC06390", VA = "0x180C07190")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0xC07330", Offset = "0xC06530", VA = "0x180C07330")]
	public bool VerifySourceMask()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0xC05D50", Offset = "0xC04F50", VA = "0x180C05D50")]
	public bool ApplyMask(Component setMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0xC068D0", Offset = "0xC05AD0", VA = "0x180C068D0")]
	public void RefreshSpriteMaskRoot(Component setMask)
	{
	}

	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0xC05A10", Offset = "0xC04C10", VA = "0x180C05A10")]
	public void ApplyMaskSettingBySortingGroup(SortingGroup sortingGroup, bool isCustomRangeActive = false)
	{
	}

	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0xC05AB0", Offset = "0xC04CB0", VA = "0x180C05AB0")]
	public void ApplyMaskSetting()
	{
	}

	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0xC07100", Offset = "0xC06300", VA = "0x180C07100")]
	public void RefreshTranLocate()
	{
	}

	[Token(Token = "0x6000A80")]
	[Address(RVA = "0xC062B0", Offset = "0xC054B0", VA = "0x180C062B0")]
	public void RefreshRect2DClip()
	{
	}

	[Token(Token = "0x6000A81")]
	[Address(RVA = "0xC07260", Offset = "0xC06460", VA = "0x180C07260")]
	public void ReleaseResources()
	{
	}

	[Token(Token = "0x6000A82")]
	[Address(RVA = "0xC061A0", Offset = "0xC053A0", VA = "0x180C061A0", Slot = "14")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x6000A83")]
	[Address(RVA = "0xC061A0", Offset = "0xC053A0", VA = "0x180C061A0", Slot = "15")]
	protected override void OnCanvasHierarchyChanged()
	{
	}

	[Token(Token = "0x6000A84")]
	[Address(RVA = "0xC06290", Offset = "0xC05490", VA = "0x180C06290", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x6000A85")]
	[Address(RVA = "0xC061A0", Offset = "0xC053A0", VA = "0x180C061A0", Slot = "12")]
	protected override void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x6000A86")]
	[Address(RVA = "0xC07720", Offset = "0xC06920", VA = "0x180C07720")]
	public CanvasToSpriteMask()
	{
	}
}
