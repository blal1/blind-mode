using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003EB")]
public struct TimeValue : IEquatable<TimeValue>
{
	[Token(Token = "0x20003EC")]
	internal class PropertyBag : ContainerPropertyBag<TimeValue>
	{
		[Token(Token = "0x20003ED")]
		private class ValueProperty : Property<TimeValue, float>
		{
			[Token(Token = "0x1700084C")]
			public override string Name
			{
				[Token(Token = "0x6001E1E")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700084D")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001E1F")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001E20")]
			[Address(RVA = "0x28F60E0", Offset = "0x28F52E0", VA = "0x1828F60E0", Slot = "14")]
			public override float GetValue(ref TimeValue container)
			{
				return default(float);
			}

			[Token(Token = "0x6001E21")]
			[Address(RVA = "0x28F60F0", Offset = "0x28F52F0", VA = "0x1828F60F0", Slot = "15")]
			public override void SetValue(ref TimeValue container, float value)
			{
			}

			[Token(Token = "0x6001E22")]
			[Address(RVA = "0x29F0570", Offset = "0x29EF770", VA = "0x1829F0570")]
			public ValueProperty()
			{
			}
		}

		[Token(Token = "0x20003EE")]
		private class UnitProperty : Property<TimeValue, TimeUnit>
		{
			[Token(Token = "0x1700084E")]
			public override string Name
			{
				[Token(Token = "0x6001E23")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700084F")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001E24")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001E25")]
			[Address(RVA = "0x29997E0", Offset = "0x29989E0", VA = "0x1829997E0", Slot = "14")]
			public override TimeUnit GetValue(ref TimeValue container)
			{
				return default(TimeUnit);
			}

			[Token(Token = "0x6001E26")]
			[Address(RVA = "0x28FBA40", Offset = "0x28FAC40", VA = "0x1828FBA40", Slot = "15")]
			public override void SetValue(ref TimeValue container, TimeUnit value)
			{
			}

			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x29EE410", Offset = "0x29ED610", VA = "0x1829EE410")]
			public UnitProperty()
			{
			}
		}

		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x29E29F0", Offset = "0x29E1BF0", VA = "0x1829E29F0")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000CE7")]
	[FieldOffset(Offset = "0x0")]
	private float m_Value;

	[Token(Token = "0x4000CE8")]
	[FieldOffset(Offset = "0x4")]
	private TimeUnit m_Unit;

	[Token(Token = "0x1700084A")]
	public float value
	{
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x1C3A870", Offset = "0x1C39A70", VA = "0x181C3A870")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x240EB30", Offset = "0x240DD30", VA = "0x18240EB30")]
		set
		{
		}
	}

	[Token(Token = "0x1700084B")]
	public TimeUnit unit
	{
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x9D59A0", Offset = "0x9D4BA0", VA = "0x1809D59A0")]
		get
		{
			return default(TimeUnit);
		}
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0xAA0C40", Offset = "0xA9FE40", VA = "0x180AA0C40")]
		set
		{
		}
	}

	[Token(Token = "0x6001E14")]
	[Address(RVA = "0x29E75F0", Offset = "0x29E67F0", VA = "0x1829E75F0")]
	public TimeValue(float value)
	{
	}

	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x1800AC0", Offset = "0x17FFCC0", VA = "0x181800AC0")]
	public TimeValue(float value, TimeUnit unit)
	{
	}

	[Token(Token = "0x6001E16")]
	[Address(RVA = "0x29E7650", Offset = "0x29E6850", VA = "0x1829E7650")]
	public static implicit operator TimeValue(float value)
	{
		return default(TimeValue);
	}

	[Token(Token = "0x6001E17")]
	[Address(RVA = "0x29E1290", Offset = "0x29E0490", VA = "0x1829E1290")]
	public static bool operator ==(TimeValue lhs, TimeValue rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E18")]
	[Address(RVA = "0x29E1300", Offset = "0x29E0500", VA = "0x1829E1300")]
	public static bool operator !=(TimeValue lhs, TimeValue rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E19")]
	[Address(RVA = "0x29E0F70", Offset = "0x29E0170", VA = "0x1829E0F70", Slot = "4")]
	public bool Equals(TimeValue other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E1A")]
	[Address(RVA = "0x29EC110", Offset = "0x29EB310", VA = "0x1829EC110", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E1B")]
	[Address(RVA = "0x29E1050", Offset = "0x29E0250", VA = "0x1829E1050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E1C")]
	[Address(RVA = "0x29EC1C0", Offset = "0x29EB3C0", VA = "0x1829EC1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
