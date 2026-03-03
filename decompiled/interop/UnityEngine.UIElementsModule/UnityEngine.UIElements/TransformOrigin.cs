using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003EF")]
public struct TransformOrigin : IEquatable<TransformOrigin>
{
	[Token(Token = "0x20003F0")]
	internal class PropertyBag : ContainerPropertyBag<TransformOrigin>
	{
		[Token(Token = "0x20003F1")]
		private class XProperty : Property<TransformOrigin, Length>
		{
			[Token(Token = "0x17000853")]
			public override string Name
			{
				[Token(Token = "0x6001E38")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000854")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001E39")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001E3A")]
			[Address(RVA = "0x4FBC50", Offset = "0x4FAE50", VA = "0x1804FBC50", Slot = "14")]
			public override Length GetValue(ref TransformOrigin container)
			{
				return default(Length);
			}

			[Token(Token = "0x6001E3B")]
			[Address(RVA = "0x29D84E0", Offset = "0x29D76E0", VA = "0x1829D84E0", Slot = "15")]
			public override void SetValue(ref TransformOrigin container, Length value)
			{
			}

			[Token(Token = "0x6001E3C")]
			[Address(RVA = "0x29F4030", Offset = "0x29F3230", VA = "0x1829F4030")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x20003F2")]
		private class YProperty : Property<TransformOrigin, Length>
		{
			[Token(Token = "0x17000855")]
			public override string Name
			{
				[Token(Token = "0x6001E3D")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000856")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001E3E")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001E3F")]
			[Address(RVA = "0x4CAAA0", Offset = "0x4C9CA0", VA = "0x1804CAAA0", Slot = "14")]
			public override Length GetValue(ref TransformOrigin container)
			{
				return default(Length);
			}

			[Token(Token = "0x6001E40")]
			[Address(RVA = "0x29F40A0", Offset = "0x29F32A0", VA = "0x1829F40A0", Slot = "15")]
			public override void SetValue(ref TransformOrigin container, Length value)
			{
			}

			[Token(Token = "0x6001E41")]
			[Address(RVA = "0x29F40B0", Offset = "0x29F32B0", VA = "0x1829F40B0")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x20003F3")]
		private class ZProperty : Property<TransformOrigin, float>
		{
			[Token(Token = "0x17000857")]
			public override string Name
			{
				[Token(Token = "0x6001E42")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000858")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001E43")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001E44")]
			[Address(RVA = "0x29F4190", Offset = "0x29F3390", VA = "0x1829F4190", Slot = "14")]
			public override float GetValue(ref TransformOrigin container)
			{
				return default(float);
			}

			[Token(Token = "0x6001E45")]
			[Address(RVA = "0x29F41A0", Offset = "0x29F33A0", VA = "0x1829F41A0", Slot = "15")]
			public override void SetValue(ref TransformOrigin container, float value)
			{
			}

			[Token(Token = "0x6001E46")]
			[Address(RVA = "0x29F4220", Offset = "0x29F3420", VA = "0x1829F4220")]
			public ZProperty()
			{
			}
		}

		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x29E2340", Offset = "0x29E1540", VA = "0x1829E2340")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000CED")]
	[FieldOffset(Offset = "0x0")]
	private Length m_X;

	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x8")]
	private Length m_Y;

	[Token(Token = "0x4000CEF")]
	[FieldOffset(Offset = "0x10")]
	private float m_Z;

	[Token(Token = "0x17000850")]
	public Length x
	{
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0xF789F0", Offset = "0xF77BF0", VA = "0x180F789F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000851")]
	public Length y
	{
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x1F9D610", Offset = "0x1F9C810", VA = "0x181F9D610")]
		set
		{
		}
	}

	[Token(Token = "0x17000852")]
	public float z
	{
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0xA45E80", Offset = "0xA45080", VA = "0x180A45E80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0xA45EA0", Offset = "0xA450A0", VA = "0x180A45EA0")]
		set
		{
		}
	}

	[Token(Token = "0x6001E28")]
	[Address(RVA = "0x29ED070", Offset = "0x29EC270", VA = "0x1829ED070")]
	public TransformOrigin(Length x, Length y, float z)
	{
	}

	[Token(Token = "0x6001E29")]
	[Address(RVA = "0x29ED080", Offset = "0x29EC280", VA = "0x1829ED080")]
	internal TransformOrigin(Vector3 vector)
	{
	}

	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0x29ECE80", Offset = "0x29EC080", VA = "0x1829ECE80")]
	public static TransformOrigin Initial()
	{
		return default(TransformOrigin);
	}

	[Token(Token = "0x6001E31")]
	[Address(RVA = "0x29ED0F0", Offset = "0x29EC2F0", VA = "0x1829ED0F0")]
	public static bool operator ==(TransformOrigin lhs, TransformOrigin rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E32")]
	[Address(RVA = "0x29ED190", Offset = "0x29EC390", VA = "0x1829ED190")]
	public static bool operator !=(TransformOrigin lhs, TransformOrigin rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E33")]
	[Address(RVA = "0x29ECC40", Offset = "0x29EBE40", VA = "0x1829ECC40", Slot = "4")]
	public bool Equals(TransformOrigin other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E34")]
	[Address(RVA = "0x29ECCE0", Offset = "0x29EBEE0", VA = "0x1829ECCE0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E35")]
	[Address(RVA = "0x29ECE00", Offset = "0x29EC000", VA = "0x1829ECE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E36")]
	[Address(RVA = "0x29ECF00", Offset = "0x29EC100", VA = "0x1829ECF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
