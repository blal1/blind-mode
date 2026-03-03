using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000013")]
public struct BackgroundSize : IEquatable<BackgroundSize>
{
	[Token(Token = "0x2000014")]
	internal class PropertyBag : ContainerPropertyBag<BackgroundSize>
	{
		[Token(Token = "0x2000015")]
		private class SizeTypeProperty : Property<BackgroundSize, BackgroundSizeType>
		{
			[Token(Token = "0x17000013")]
			public override string Name
			{
				[Token(Token = "0x6000066")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6000067")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0x28FB6E0", Offset = "0x28FA8E0", VA = "0x1828FB6E0", Slot = "14")]
			public override BackgroundSizeType GetValue(ref BackgroundSize container)
			{
				return default(BackgroundSizeType);
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2997E60", Offset = "0x2997060", VA = "0x182997E60", Slot = "15")]
			public override void SetValue(ref BackgroundSize container, BackgroundSizeType value)
			{
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x2997EC0", Offset = "0x29970C0", VA = "0x182997EC0")]
			public SizeTypeProperty()
			{
			}
		}

		[Token(Token = "0x2000016")]
		private class XProperty : Property<BackgroundSize, Length>
		{
			[Token(Token = "0x17000015")]
			public override string Name
			{
				[Token(Token = "0x600006B")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000016")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x600006C")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0x29996E0", Offset = "0x29988E0", VA = "0x1829996E0", Slot = "14")]
			public override Length GetValue(ref BackgroundSize container)
			{
				return default(Length);
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x29996F0", Offset = "0x29988F0", VA = "0x1829996F0", Slot = "15")]
			public override void SetValue(ref BackgroundSize container, Length value)
			{
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2999700", Offset = "0x2998900", VA = "0x182999700")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x2000017")]
		private class YProperty : Property<BackgroundSize, Length>
		{
			[Token(Token = "0x17000017")]
			public override string Name
			{
				[Token(Token = "0x6000070")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6000071")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000072")]
			[Address(RVA = "0x29997F0", Offset = "0x29989F0", VA = "0x1829997F0", Slot = "14")]
			public override Length GetValue(ref BackgroundSize container)
			{
				return default(Length);
			}

			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2999800", Offset = "0x2998A00", VA = "0x182999800", Slot = "15")]
			public override void SetValue(ref BackgroundSize container, Length value)
			{
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2999810", Offset = "0x2998A10", VA = "0x182999810")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2997BA0", Offset = "0x2996DA0", VA = "0x182997BA0")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x0")]
	private BackgroundSizeType m_SizeType;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x4")]
	private Length m_X;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0xC")]
	private Length m_Y;

	[Token(Token = "0x17000010")]
	public BackgroundSizeType sizeType
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1500B10", Offset = "0x14FFD10", VA = "0x181500B10")]
		get
		{
			return default(BackgroundSizeType);
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2975410", Offset = "0x2974610", VA = "0x182975410")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public Length x
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2975470", Offset = "0x2974670", VA = "0x182975470")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2975580", Offset = "0x2974780", VA = "0x182975580")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public Length y
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2975480", Offset = "0x2974680", VA = "0x182975480")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2975590", Offset = "0x2974790", VA = "0x182975590")]
		set
		{
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2975400", Offset = "0x2974600", VA = "0x182975400")]
	public BackgroundSize(Length sizeX, Length sizeY)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2975410", Offset = "0x2974610", VA = "0x182975410")]
	public BackgroundSize(BackgroundSizeType sizeType)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x29752E0", Offset = "0x29744E0", VA = "0x1829752E0")]
	internal static BackgroundSize Initial()
	{
		return default(BackgroundSize);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2975160", Offset = "0x2974360", VA = "0x182975160", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2975230", Offset = "0x2974430", VA = "0x182975230", Slot = "4")]
	public bool Equals(BackgroundSize other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2975290", Offset = "0x2974490", VA = "0x182975290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2975490", Offset = "0x2974690", VA = "0x182975490")]
	public static bool operator ==(BackgroundSize style1, BackgroundSize style2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2975500", Offset = "0x2974700", VA = "0x182975500")]
	public static bool operator !=(BackgroundSize style1, BackgroundSize style2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2975340", Offset = "0x2974540", VA = "0x182975340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
