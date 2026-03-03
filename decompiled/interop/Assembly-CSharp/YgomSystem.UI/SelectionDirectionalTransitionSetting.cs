using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Serializable]
[Token(Token = "0x2000482")]
public class SelectionDirectionalTransitionSetting
{
	[Token(Token = "0x4001618")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[DirectionalProperty(DirectionalPropertyAttribute.Direction.Up)]
	[DirectionalLineProperty(true, "Head Transition")]
	private SelectionTransitionSetting m_UpTransition;

	[Token(Token = "0x4001619")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[DirectionalProperty(DirectionalPropertyAttribute.Direction.Down)]
	[DirectionalLineProperty(false, "Tail Transition")]
	private SelectionTransitionSetting m_DownTransition;

	[Token(Token = "0x400161A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[DirectionalProperty(DirectionalPropertyAttribute.Direction.Right)]
	private SelectionTransitionSetting m_RightTransition;

	[Token(Token = "0x400161B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[DirectionalProperty(DirectionalPropertyAttribute.Direction.Left)]
	private SelectionTransitionSetting m_LeftTransition;

	[Token(Token = "0x170002DE")]
	public SelectionTransitionSetting headTransition
	{
		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DF")]
	public SelectionTransitionSetting tailTransition
	{
		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001D5E")]
	[Address(RVA = "0x609030", Offset = "0x608230", VA = "0x180609030")]
	public SelectionTransitionSetting GetSetting(PadInputDirection direction)
	{
		return null;
	}

	[Token(Token = "0x6001D5F")]
	[Address(RVA = "0x609060", Offset = "0x608260", VA = "0x180609060")]
	public SelectionDirectionalTransitionSetting()
	{
	}
}
