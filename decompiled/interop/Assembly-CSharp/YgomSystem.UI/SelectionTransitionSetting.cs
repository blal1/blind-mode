using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Serializable]
[Token(Token = "0x200049D")]
public class SelectionTransitionSetting
{
	[Token(Token = "0x4001688")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private SelectionItem.TransitionMode m_Mode;

	[Token(Token = "0x4001689")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SelectionItem m_ManualItem;

	[Token(Token = "0x400168A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Selector m_ManualSelector;

	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<MonoBehaviour> m_CustomHandlers;

	[Token(Token = "0x170002ED")]
	public SelectionItem.TransitionMode mode
	{
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(SelectionItem.TransitionMode);
		}
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		set
		{
		}
	}

	[Token(Token = "0x170002EE")]
	public SelectionItem manualItem
	{
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		set
		{
		}
	}

	[Token(Token = "0x170002EF")]
	public Selector manualSelector
	{
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x170002F0")]
	public List<MonoBehaviour> customHandlers
	{
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		set
		{
		}
	}

	[Token(Token = "0x6001E3A")]
	[Address(RVA = "0x616700", Offset = "0x615900", VA = "0x180616700")]
	public void SetTransitionSetting(PadInputDirection direction, SelectionItem target)
	{
	}

	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0x616770", Offset = "0x615970", VA = "0x180616770", Slot = "4")]
	public virtual bool TryTransitionBySetting(PadInputDirection direction, SelectionItem target, bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0x616CF0", Offset = "0x615EF0", VA = "0x180616CF0")]
	public SelectionTransitionSetting()
	{
	}
}
