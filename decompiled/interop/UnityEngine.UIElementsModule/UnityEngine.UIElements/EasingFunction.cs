using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002D3")]
public struct EasingFunction : IEquatable<EasingFunction>
{
	[Token(Token = "0x20002D4")]
	internal class PropertyBag : ContainerPropertyBag<EasingFunction>
	{
		[Token(Token = "0x20002D5")]
		private class ModeProperty : Property<EasingFunction, EasingMode>
		{
			[Token(Token = "0x1700040F")]
			public override string Name
			{
				[Token(Token = "0x6001435")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000410")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001436")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001437")]
			[Address(RVA = "0xD17EA0", Offset = "0xD170A0", VA = "0x180D17EA0", Slot = "14")]
			public override EasingMode GetValue(ref EasingFunction container)
			{
				return default(EasingMode);
			}

			[Token(Token = "0x6001438")]
			[Address(RVA = "0x28FB700", Offset = "0x28FA900", VA = "0x1828FB700", Slot = "15")]
			public override void SetValue(ref EasingFunction container, EasingMode value)
			{
			}

			[Token(Token = "0x6001439")]
			[Address(RVA = "0x2B69AF0", Offset = "0x2B68CF0", VA = "0x182B69AF0")]
			public ModeProperty()
			{
			}
		}

		[Token(Token = "0x6001434")]
		[Address(RVA = "0x2B6C570", Offset = "0x2B6B770", VA = "0x182B6C570")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x0")]
	private EasingMode m_Mode;

	[Token(Token = "0x1700040E")]
	public EasingMode mode
	{
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		get
		{
			return default(EasingMode);
		}
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60")]
		set
		{
		}
	}

	[Token(Token = "0x600142D")]
	[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60")]
	public EasingFunction(EasingMode mode)
	{
	}

	[Token(Token = "0x600142E")]
	[Address(RVA = "0x28002E0", Offset = "0x27FF4E0", VA = "0x1828002E0")]
	public static implicit operator EasingFunction(EasingMode easingMode)
	{
		return default(EasingFunction);
	}

	[Token(Token = "0x600142F")]
	[Address(RVA = "0x27FEAA0", Offset = "0x27FDCA0", VA = "0x1827FEAA0")]
	public static bool operator ==(EasingFunction lhs, EasingFunction rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001430")]
	[Address(RVA = "0x2B5DF90", Offset = "0x2B5D190", VA = "0x182B5DF90", Slot = "4")]
	public bool Equals(EasingFunction other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001431")]
	[Address(RVA = "0x2B5DF00", Offset = "0x2B5D100", VA = "0x182B5DF00", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001432")]
	[Address(RVA = "0x2B5DFA0", Offset = "0x2B5D1A0", VA = "0x182B5DFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001433")]
	[Address(RVA = "0x1500B10", Offset = "0x14FFD10", VA = "0x181500B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
