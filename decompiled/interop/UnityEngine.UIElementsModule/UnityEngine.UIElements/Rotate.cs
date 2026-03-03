using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003C9")]
public struct Rotate : IEquatable<Rotate>
{
	[Token(Token = "0x20003CA")]
	internal class PropertyBag : ContainerPropertyBag<Rotate>
	{
		[Token(Token = "0x20003CB")]
		private class AngleProperty : Property<Rotate, Angle>
		{
			[Token(Token = "0x17000818")]
			public override string Name
			{
				[Token(Token = "0x6001CD2")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000819")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001CD3")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001CD4")]
			[Address(RVA = "0x4FBC50", Offset = "0x4FAE50", VA = "0x1804FBC50", Slot = "14")]
			public override Angle GetValue(ref Rotate container)
			{
				return default(Angle);
			}

			[Token(Token = "0x6001CD5")]
			[Address(RVA = "0x29D84E0", Offset = "0x29D76E0", VA = "0x1829D84E0", Slot = "15")]
			public override void SetValue(ref Rotate container, Angle value)
			{
			}

			[Token(Token = "0x6001CD6")]
			[Address(RVA = "0x29D84F0", Offset = "0x29D76F0", VA = "0x1829D84F0")]
			public AngleProperty()
			{
			}
		}

		[Token(Token = "0x20003CC")]
		private class AxisProperty : Property<Rotate, Vector3>
		{
			[Token(Token = "0x1700081A")]
			public override string Name
			{
				[Token(Token = "0x6001CD7")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700081B")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001CD8")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001CD9")]
			[Address(RVA = "0x29D8560", Offset = "0x29D7760", VA = "0x1829D8560", Slot = "14")]
			public override Vector3 GetValue(ref Rotate container)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6001CDA")]
			[Address(RVA = "0x29D8580", Offset = "0x29D7780", VA = "0x1829D8580", Slot = "15")]
			public override void SetValue(ref Rotate container, Vector3 value)
			{
			}

			[Token(Token = "0x6001CDB")]
			[Address(RVA = "0x29D85A0", Offset = "0x29D77A0", VA = "0x1829D85A0")]
			public AxisProperty()
			{
			}
		}

		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x29E2760", Offset = "0x29E1960", VA = "0x1829E2760")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000CA6")]
	[FieldOffset(Offset = "0x0")]
	private Angle m_Angle;

	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0x8")]
	private Vector3 m_Axis;

	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsNone;

	[Token(Token = "0x17000816")]
	public Angle angle
	{
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		get
		{
			return default(Angle);
		}
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0xF789F0", Offset = "0xF77BF0", VA = "0x180F789F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000817")]
	internal Vector3 axis
	{
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x2408280", Offset = "0x2407480", VA = "0x182408280")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x29E5A60", Offset = "0x29E4C60", VA = "0x1829E5A60")]
		set
		{
		}
	}

	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x29E5830", Offset = "0x29E4A30", VA = "0x1829E5830")]
	public Rotate(Angle angle)
	{
	}

	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0x29E57B0", Offset = "0x29E49B0", VA = "0x1829E57B0")]
	internal Rotate(Quaternion quaternion)
	{
	}

	[Token(Token = "0x6001CC4")]
	[Address(RVA = "0x29E55B0", Offset = "0x29E47B0", VA = "0x1829E55B0")]
	internal static Rotate Initial()
	{
		return default(Rotate);
	}

	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0x29E5640", Offset = "0x29E4840", VA = "0x1829E5640")]
	public static Rotate None()
	{
		return default(Rotate);
	}

	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0x29E5880", Offset = "0x29E4A80", VA = "0x1829E5880")]
	public static bool operator ==(Rotate lhs, Rotate rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0x29E5970", Offset = "0x29E4B70", VA = "0x1829E5970")]
	public static bool operator !=(Rotate lhs, Rotate rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CCC")]
	[Address(RVA = "0x29E5420", Offset = "0x29E4620", VA = "0x1829E5420", Slot = "4")]
	public bool Equals(Rotate other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CCD")]
	[Address(RVA = "0x29E5380", Offset = "0x29E4580", VA = "0x1829E5380", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0x29E5500", Offset = "0x29E4700", VA = "0x1829E5500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x29E5740", Offset = "0x29E4940", VA = "0x1829E5740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x29E56E0", Offset = "0x29E48E0", VA = "0x1829E56E0")]
	internal Quaternion ToQuaternion()
	{
		return default(Quaternion);
	}
}
