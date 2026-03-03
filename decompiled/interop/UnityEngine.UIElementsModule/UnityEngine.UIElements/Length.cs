using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20003C4")]
public struct Length : IEquatable<Length>
{
	[Token(Token = "0x20003C5")]
	private enum Unit
	{
		[Token(Token = "0x4000C9E")]
		Pixel,
		[Token(Token = "0x4000C9F")]
		Percent,
		[Token(Token = "0x4000CA0")]
		Auto,
		[Token(Token = "0x4000CA1")]
		None
	}

	[Token(Token = "0x20003C6")]
	internal class PropertyBag : ContainerPropertyBag<Length>
	{
		[Token(Token = "0x20003C7")]
		private class ValueProperty : Property<Length, float>
		{
			[Token(Token = "0x17000812")]
			public override string Name
			{
				[Token(Token = "0x6001CB8")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000813")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001CB9")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001CBA")]
			[Address(RVA = "0x28F60E0", Offset = "0x28F52E0", VA = "0x1828F60E0", Slot = "14")]
			public override float GetValue(ref Length container)
			{
				return default(float);
			}

			[Token(Token = "0x6001CBB")]
			[Address(RVA = "0x29F04D0", Offset = "0x29EF6D0", VA = "0x1829F04D0", Slot = "15")]
			public override void SetValue(ref Length container, float value)
			{
			}

			[Token(Token = "0x6001CBC")]
			[Address(RVA = "0x29F0500", Offset = "0x29EF700", VA = "0x1829F0500")]
			public ValueProperty()
			{
			}
		}

		[Token(Token = "0x20003C8")]
		private class UnitProperty : Property<Length, LengthUnit>
		{
			[Token(Token = "0x17000814")]
			public override string Name
			{
				[Token(Token = "0x6001CBD")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000815")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001CBE")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001CBF")]
			[Address(RVA = "0x29997E0", Offset = "0x29989E0", VA = "0x1829997E0", Slot = "14")]
			public override LengthUnit GetValue(ref Length container)
			{
				return default(LengthUnit);
			}

			[Token(Token = "0x6001CC0")]
			[Address(RVA = "0x28FBA40", Offset = "0x28FAC40", VA = "0x1828FBA40", Slot = "15")]
			public override void SetValue(ref Length container, LengthUnit value)
			{
			}

			[Token(Token = "0x6001CC1")]
			[Address(RVA = "0x29EE480", Offset = "0x29ED680", VA = "0x1829EE480")]
			public UnitProperty()
			{
			}
		}

		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x29E21B0", Offset = "0x29E13B0", VA = "0x1829E21B0")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000C9A")]
	internal const float k_MaxValue = 8388608f;

	[Token(Token = "0x4000C9B")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private float m_Value;

	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	private Unit m_Unit;

	[Token(Token = "0x17000810")]
	public float value
	{
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x1C3A870", Offset = "0x1C39A70", VA = "0x181C3A870")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x29E1330", Offset = "0x29E0530", VA = "0x1829E1330")]
		set
		{
		}
	}

	[Token(Token = "0x17000811")]
	public LengthUnit unit
	{
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x9D59A0", Offset = "0x9D4BA0", VA = "0x1809D59A0")]
		get
		{
			return default(LengthUnit);
		}
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0xAA0C40", Offset = "0xA9FE40", VA = "0x180AA0C40")]
		set
		{
		}
	}

	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0x29E10B0", Offset = "0x29E02B0", VA = "0x1829E10B0")]
	public static Length Percent(float value)
	{
		return default(Length);
	}

	[Token(Token = "0x6001CA5")]
	[Address(RVA = "0x29E0F50", Offset = "0x29E0150", VA = "0x1829E0F50")]
	public static Length Auto()
	{
		return default(Length);
	}

	[Token(Token = "0x6001CA6")]
	[Address(RVA = "0x29E1090", Offset = "0x29E0290", VA = "0x1829E1090")]
	public static Length None()
	{
		return default(Length);
	}

	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0x29E1070", Offset = "0x29E0270", VA = "0x1829E1070")]
	public bool IsAuto()
	{
		return default(bool);
	}

	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0x29E1080", Offset = "0x29E0280", VA = "0x1829E1080")]
	public bool IsNone()
	{
		return default(bool);
	}

	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0x29E1260", Offset = "0x29E0460", VA = "0x1829E1260")]
	public Length(float value)
	{
	}

	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0x29E1230", Offset = "0x29E0430", VA = "0x1829E1230")]
	public Length(float value, LengthUnit unit)
	{
	}

	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0x29E1230", Offset = "0x29E0430", VA = "0x1829E1230")]
	private Length(float value, Unit unit)
	{
	}

	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0x29E12C0", Offset = "0x29E04C0", VA = "0x1829E12C0")]
	public static implicit operator Length(float value)
	{
		return default(Length);
	}

	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x29E1290", Offset = "0x29E0490", VA = "0x1829E1290")]
	public static bool operator ==(Length lhs, Length rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0x29E1300", Offset = "0x29E0500", VA = "0x1829E1300")]
	public static bool operator !=(Length lhs, Length rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0x29E0F70", Offset = "0x29E0170", VA = "0x1829E0F70", Slot = "4")]
	public bool Equals(Length other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0x29E0FA0", Offset = "0x29E01A0", VA = "0x1829E0FA0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0x29E1050", Offset = "0x29E0250", VA = "0x1829E1050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x29E10F0", Offset = "0x29E02F0", VA = "0x1829E10F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
