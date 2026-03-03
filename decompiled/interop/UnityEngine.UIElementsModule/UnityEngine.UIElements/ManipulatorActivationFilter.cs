using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000276")]
public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter>
{
	[Token(Token = "0x1700032F")]
	public MouseButton button
	{
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		[CompilerGenerated]
		readonly get
		{
			return default(MouseButton);
		}
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000330")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x9D59A0", Offset = "0x9D4BA0", VA = "0x1809D59A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(EventModifiers);
		}
		[Token(Token = "0x6001129")]
		[Address(RVA = "0xAA0C40", Offset = "0xA9FE40", VA = "0x180AA0C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000331")]
	public readonly int clickCount
	{
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x130E8C0", Offset = "0x130DAC0", VA = "0x18130E8C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600112B")]
	[Address(RVA = "0x2B339B0", Offset = "0x2B32BB0", VA = "0x182B339B0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600112C")]
	[Address(RVA = "0x284B3B0", Offset = "0x284A5B0", VA = "0x18284B3B0", Slot = "4")]
	public bool Equals(ManipulatorActivationFilter other)
	{
		return default(bool);
	}

	[Token(Token = "0x600112D")]
	[Address(RVA = "0x2B33A60", Offset = "0x2B32C60", VA = "0x182B33A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600112E")]
	[Address(RVA = "0x2B33C40", Offset = "0x2B32E40", VA = "0x182B33C40")]
	public bool Matches(IPointerEvent e)
	{
		return default(bool);
	}

	[Token(Token = "0x600112F")]
	[Address(RVA = "0x2B33AD0", Offset = "0x2B32CD0", VA = "0x182B33AD0")]
	private bool HasModifiers(IPointerEvent e)
	{
		return default(bool);
	}

	[Token(Token = "0x6001130")]
	[Address(RVA = "0x2B33BC0", Offset = "0x2B32DC0", VA = "0x182B33BC0")]
	private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command)
	{
		return default(bool);
	}
}
