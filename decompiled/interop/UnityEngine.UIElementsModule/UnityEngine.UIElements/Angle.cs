using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002C1")]
public struct Angle : IEquatable<Angle>
{
	[Token(Token = "0x20002C2")]
	private enum Unit
	{
		[Token(Token = "0x4000B1D")]
		Degree,
		[Token(Token = "0x4000B1E")]
		Gradian,
		[Token(Token = "0x4000B1F")]
		Radian,
		[Token(Token = "0x4000B20")]
		Turn,
		[Token(Token = "0x4000B21")]
		None
	}

	[Token(Token = "0x20002C3")]
	internal class PropertyBag : ContainerPropertyBag<Angle>
	{
		[Token(Token = "0x20002C4")]
		private class ValueProperty : Property<Angle, float>
		{
			[Token(Token = "0x170003A7")]
			public override string Name
			{
				[Token(Token = "0x600133A")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003A8")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x600133B")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600133C")]
			[Address(RVA = "0x28F60E0", Offset = "0x28F52E0", VA = "0x1828F60E0", Slot = "14")]
			public override float GetValue(ref Angle container)
			{
				return default(float);
			}

			[Token(Token = "0x600133D")]
			[Address(RVA = "0x28F60F0", Offset = "0x28F52F0", VA = "0x1828F60F0", Slot = "15")]
			public override void SetValue(ref Angle container, float value)
			{
			}

			[Token(Token = "0x600133E")]
			[Address(RVA = "0x2B72FE0", Offset = "0x2B721E0", VA = "0x182B72FE0")]
			public ValueProperty()
			{
			}
		}

		[Token(Token = "0x20002C5")]
		private class UnitProperty : Property<Angle, AngleUnit>
		{
			[Token(Token = "0x170003A9")]
			public override string Name
			{
				[Token(Token = "0x600133F")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003AA")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001340")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001341")]
			[Address(RVA = "0x29997E0", Offset = "0x29989E0", VA = "0x1829997E0", Slot = "14")]
			public override AngleUnit GetValue(ref Angle container)
			{
				return default(AngleUnit);
			}

			[Token(Token = "0x6001342")]
			[Address(RVA = "0x28FBA40", Offset = "0x28FAC40", VA = "0x1828FBA40", Slot = "15")]
			public override void SetValue(ref Angle container, AngleUnit value)
			{
			}

			[Token(Token = "0x6001343")]
			[Address(RVA = "0x2B72BC0", Offset = "0x2B71DC0", VA = "0x182B72BC0")]
			public UnitProperty()
			{
			}
		}

		[Token(Token = "0x6001339")]
		[Address(RVA = "0x2B6C3E0", Offset = "0x2B6B5E0", VA = "0x182B6C3E0")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x0")]
	private float m_Value;

	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x4")]
	private Unit m_Unit;

	[Token(Token = "0x170003A5")]
	public float value
	{
		[Token(Token = "0x600132B")]
		[Address(RVA = "0x1C3A870", Offset = "0x1C39A70", VA = "0x181C3A870")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600132C")]
		[Address(RVA = "0x240EB30", Offset = "0x240DD30", VA = "0x18240EB30")]
		set
		{
		}
	}

	[Token(Token = "0x170003A6")]
	public AngleUnit unit
	{
		[Token(Token = "0x600132D")]
		[Address(RVA = "0x9D59A0", Offset = "0x9D4BA0", VA = "0x1809D59A0")]
		get
		{
			return default(AngleUnit);
		}
		[Token(Token = "0x600132E")]
		[Address(RVA = "0xAA0C40", Offset = "0xA9FE40", VA = "0x180AA0C40")]
		set
		{
		}
	}

	[Token(Token = "0x600132A")]
	[Address(RVA = "0x2B59510", Offset = "0x2B58710", VA = "0x182B59510")]
	internal static Angle None()
	{
		return default(Angle);
	}

	[Token(Token = "0x600132F")]
	[Address(RVA = "0x1800AC0", Offset = "0x17FFCC0", VA = "0x181800AC0")]
	public Angle(float value, AngleUnit unit)
	{
	}

	[Token(Token = "0x6001330")]
	[Address(RVA = "0x1800AC0", Offset = "0x17FFCC0", VA = "0x181800AC0")]
	private Angle(float value, Unit unit)
	{
	}

	[Token(Token = "0x6001331")]
	[Address(RVA = "0x2B59530", Offset = "0x2B58730", VA = "0x182B59530")]
	public float ToDegrees()
	{
		return default(float);
	}

	[Token(Token = "0x6001332")]
	[Address(RVA = "0x29E7650", Offset = "0x29E6850", VA = "0x1829E7650")]
	public static implicit operator Angle(float value)
	{
		return default(Angle);
	}

	[Token(Token = "0x6001333")]
	[Address(RVA = "0x29E1290", Offset = "0x29E0490", VA = "0x1829E1290")]
	public static bool operator ==(Angle lhs, Angle rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001334")]
	[Address(RVA = "0x29E1300", Offset = "0x29E0500", VA = "0x1829E1300")]
	public static bool operator !=(Angle lhs, Angle rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001335")]
	[Address(RVA = "0x29E0F70", Offset = "0x29E0170", VA = "0x1829E0F70", Slot = "4")]
	public bool Equals(Angle other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001336")]
	[Address(RVA = "0x2B59460", Offset = "0x2B58660", VA = "0x182B59460", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001337")]
	[Address(RVA = "0x29E1050", Offset = "0x29E0250", VA = "0x1829E1050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001338")]
	[Address(RVA = "0x2B59590", Offset = "0x2B58790", VA = "0x182B59590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
