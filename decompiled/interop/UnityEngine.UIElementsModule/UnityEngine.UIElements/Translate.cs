using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003F4")]
public struct Translate : IEquatable<Translate>
{
	[Token(Token = "0x20003F5")]
	internal class PropertyBag : ContainerPropertyBag<Translate>
	{
		[Token(Token = "0x20003F6")]
		private class XProperty : Property<Translate, Length>
		{
			[Token(Token = "0x1700085C")]
			public override string Name
			{
				[Token(Token = "0x6001E57")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700085D")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001E58")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001E59")]
			[Address(RVA = "0x4FBC50", Offset = "0x4FAE50", VA = "0x1804FBC50", Slot = "14")]
			public override Length GetValue(ref Translate container)
			{
				return default(Length);
			}

			[Token(Token = "0x6001E5A")]
			[Address(RVA = "0x29D84E0", Offset = "0x29D76E0", VA = "0x1829D84E0", Slot = "15")]
			public override void SetValue(ref Translate container, Length value)
			{
			}

			[Token(Token = "0x6001E5B")]
			[Address(RVA = "0x29F3FC0", Offset = "0x29F31C0", VA = "0x1829F3FC0")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x20003F7")]
		private class YProperty : Property<Translate, Length>
		{
			[Token(Token = "0x1700085E")]
			public override string Name
			{
				[Token(Token = "0x6001E5C")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700085F")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001E5D")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001E5E")]
			[Address(RVA = "0x4CAAA0", Offset = "0x4C9CA0", VA = "0x1804CAAA0", Slot = "14")]
			public override Length GetValue(ref Translate container)
			{
				return default(Length);
			}

			[Token(Token = "0x6001E5F")]
			[Address(RVA = "0x29F40A0", Offset = "0x29F32A0", VA = "0x1829F40A0", Slot = "15")]
			public override void SetValue(ref Translate container, Length value)
			{
			}

			[Token(Token = "0x6001E60")]
			[Address(RVA = "0x29F4120", Offset = "0x29F3320", VA = "0x1829F4120")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x20003F8")]
		private class ZProperty : Property<Translate, float>
		{
			[Token(Token = "0x17000860")]
			public override string Name
			{
				[Token(Token = "0x6001E61")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000861")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001E62")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001E63")]
			[Address(RVA = "0x29F4190", Offset = "0x29F3390", VA = "0x1829F4190", Slot = "14")]
			public override float GetValue(ref Translate container)
			{
				return default(float);
			}

			[Token(Token = "0x6001E64")]
			[Address(RVA = "0x29F41A0", Offset = "0x29F33A0", VA = "0x1829F41A0", Slot = "15")]
			public override void SetValue(ref Translate container, float value)
			{
			}

			[Token(Token = "0x6001E65")]
			[Address(RVA = "0x29F41B0", Offset = "0x29F33B0", VA = "0x1829F41B0")]
			public ZProperty()
			{
			}
		}

		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x29E2550", Offset = "0x29E1750", VA = "0x1829E2550")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000CF6")]
	[FieldOffset(Offset = "0x0")]
	private Length m_X;

	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x8")]
	private Length m_Y;

	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x10")]
	private float m_Z;

	[Token(Token = "0x4000CF9")]
	[FieldOffset(Offset = "0x14")]
	private bool m_isNone;

	[Token(Token = "0x17000859")]
	public Length x
	{
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0xF789F0", Offset = "0xF77BF0", VA = "0x180F789F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700085A")]
	public Length y
	{
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x1F9D610", Offset = "0x1F9C810", VA = "0x181F9D610")]
		set
		{
		}
	}

	[Token(Token = "0x1700085B")]
	public float z
	{
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0xA45E80", Offset = "0xA45080", VA = "0x180A45E80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0xA45EA0", Offset = "0xA450A0", VA = "0x180A45EA0")]
		set
		{
		}
	}

	[Token(Token = "0x6001E47")]
	[Address(RVA = "0x29EE0C0", Offset = "0x29ED2C0", VA = "0x1829EE0C0")]
	public Translate(Length x, Length y, float z)
	{
	}

	[Token(Token = "0x6001E48")]
	[Address(RVA = "0x29EE050", Offset = "0x29ED250", VA = "0x1829EE050")]
	internal Translate(Vector3 v)
	{
	}

	[Token(Token = "0x6001E49")]
	[Address(RVA = "0x29EDEB0", Offset = "0x29ED0B0", VA = "0x1829EDEB0")]
	public static Translate None()
	{
		return default(Translate);
	}

	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x29EE0E0", Offset = "0x29ED2E0", VA = "0x1829EE0E0")]
	public static bool operator ==(Translate lhs, Translate rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E51")]
	[Address(RVA = "0x29EE1F0", Offset = "0x29ED3F0", VA = "0x1829EE1F0")]
	public static bool operator !=(Translate lhs, Translate rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E52")]
	[Address(RVA = "0x29EDDA0", Offset = "0x29ECFA0", VA = "0x1829EDDA0", Slot = "4")]
	public bool Equals(Translate other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E53")]
	[Address(RVA = "0x29EDDF0", Offset = "0x29ECFF0", VA = "0x1829EDDF0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E54")]
	[Address(RVA = "0x29ECE00", Offset = "0x29EC000", VA = "0x1829ECE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E55")]
	[Address(RVA = "0x29EDEE0", Offset = "0x29ED0E0", VA = "0x1829EDEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
