using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.InfinityScroll;

[Serializable]
[Token(Token = "0x2000595")]
public class EntitySelectorSettings
{
	[Token(Token = "0x4001B61")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private SelectionTransitionSetting m_UpEdgeTransition;

	[Token(Token = "0x4001B62")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SelectionTransitionSetting m_DownEdgeTransition;

	[Token(Token = "0x4001B63")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SelectionTransitionSetting m_RightEdgeTransition;

	[Token(Token = "0x4001B64")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SelectionTransitionSetting m_LeftEdgeTransition;

	[Token(Token = "0x4001B65")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_ScrollAnalogMain;

	[Token(Token = "0x4001B66")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool m_ScrollAnalogSub;

	[Token(Token = "0x4001B67")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_ThresInput;

	[Token(Token = "0x4001B68")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_IsFreeAnalogScroll;

	[Token(Token = "0x4001B69")]
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	private bool m_AllowAnalogSelectOnOuter;

	[Token(Token = "0x4001B6A")]
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	private bool m_IsAnalogScrollConsiderSubIndex;

	[Token(Token = "0x17000427")]
	public bool isScrollByAnalogMain
	{
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000428")]
	public bool isScrollByAnalogSub
	{
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000429")]
	public bool isFreeAnalogScroll
	{
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700042A")]
	public bool allowAnalogSelectOnOuter
	{
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x689960", Offset = "0x688B60", VA = "0x180689960")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700042B")]
	public bool isScrollByAnalogEnabled
	{
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x689980", Offset = "0x688B80", VA = "0x180689980")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700042C")]
	public float thresInput
	{
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x6496D0", Offset = "0x6488D0", VA = "0x1806496D0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700042D")]
	public bool isAnalogScrollConsiderSubIndex
	{
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x689970", Offset = "0x688B70", VA = "0x180689970")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60024D1")]
	[Address(RVA = "0x609030", Offset = "0x608230", VA = "0x180609030")]
	public SelectionTransitionSetting GetDirectionSetting(PadInputDirection direction)
	{
		return null;
	}

	[Token(Token = "0x60024D2")]
	[Address(RVA = "0x6897C0", Offset = "0x6889C0", VA = "0x1806897C0")]
	public void SetTransitionMode(SelectionItem selectionItem, PadInputDirection direction)
	{
	}

	[Token(Token = "0x60024D3")]
	[Address(RVA = "0x689870", Offset = "0x688A70", VA = "0x180689870")]
	public EntitySelectorSettings()
	{
	}
}
