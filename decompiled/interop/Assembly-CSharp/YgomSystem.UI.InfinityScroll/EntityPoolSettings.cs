using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.InfinityScroll;

[Serializable]
[Token(Token = "0x200058F")]
public class EntityPoolSettings
{
	[Token(Token = "0x2000590")]
	public enum Alignment
	{
		[Token(Token = "0x4001B37")]
		Begin,
		[Token(Token = "0x4001B38")]
		Center,
		[Token(Token = "0x4001B39")]
		End
	}

	[Token(Token = "0x4001B33")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private GridLayoutGroup.Axis m_ScrollAxis;

	[Token(Token = "0x4001B34")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private Alignment m_Alignment;

	[Token(Token = "0x4001B35")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_InstantiateAllTemplates;

	[Token(Token = "0x17000415")]
	public GridLayoutGroup.Axis scrollAxis
	{
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(GridLayoutGroup.Axis);
		}
	}

	[Token(Token = "0x17000416")]
	public Alignment alignment
	{
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		get
		{
			return default(Alignment);
		}
	}

	[Token(Token = "0x17000417")]
	public bool isInstaintiateAllTemplates
	{
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		set
		{
		}
	}

	[Token(Token = "0x600247F")]
	[Address(RVA = "0x662750", Offset = "0x661950", VA = "0x180662750")]
	public EntityPoolSettings()
	{
	}
}
