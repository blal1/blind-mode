using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200017A")]
public struct Cursor : IEquatable<Cursor>
{
	[Token(Token = "0x200017B")]
	internal class PropertyBag : ContainerPropertyBag<Cursor>
	{
		[Token(Token = "0x200017C")]
		private class TextureProperty : Property<Cursor, Texture2D>
		{
			[Token(Token = "0x170001F5")]
			public override string Name
			{
				[Token(Token = "0x6000B4A")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001F6")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6000B4B")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x4FBC50", Offset = "0x4FAE50", VA = "0x1804FBC50", Slot = "14")]
			public override Texture2D GetValue(ref Cursor container)
			{
				return null;
			}

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x2B00850", Offset = "0x2AFFA50", VA = "0x182B00850", Slot = "15")]
			public override void SetValue(ref Cursor container, Texture2D value)
			{
			}

			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x2B00860", Offset = "0x2AFFA60", VA = "0x182B00860")]
			public TextureProperty()
			{
			}
		}

		[Token(Token = "0x200017D")]
		private class HotspotProperty : Property<Cursor, Vector2>
		{
			[Token(Token = "0x170001F7")]
			public override string Name
			{
				[Token(Token = "0x6000B4F")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001F8")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6000B50")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x2AF7D70", Offset = "0x2AF6F70", VA = "0x182AF7D70", Slot = "14")]
			public override Vector2 GetValue(ref Cursor container)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x29F40A0", Offset = "0x29F32A0", VA = "0x1829F40A0", Slot = "15")]
			public override void SetValue(ref Cursor container, Vector2 value)
			{
			}

			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x2AF7D90", Offset = "0x2AF6F90", VA = "0x182AF7D90")]
			public HotspotProperty()
			{
			}
		}

		[Token(Token = "0x200017E")]
		private class DefaultCursorIdProperty : Property<Cursor, int>
		{
			[Token(Token = "0x170001F9")]
			public override string Name
			{
				[Token(Token = "0x6000B54")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001FA")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6000B55")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x20118A0", Offset = "0x2010AA0", VA = "0x1820118A0", Slot = "14")]
			public override int GetValue(ref Cursor container)
			{
				return default(int);
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x2AF47E0", Offset = "0x2AF39E0", VA = "0x182AF47E0", Slot = "15")]
			public override void SetValue(ref Cursor container, int value)
			{
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x2AF47F0", Offset = "0x2AF39F0", VA = "0x182AF47F0")]
			public DefaultCursorIdProperty()
			{
			}
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x2AFCE60", Offset = "0x2AFC060", VA = "0x182AFCE60")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x170001F2")]
	public Texture2D texture
	{
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170001F3")]
	public Vector2 hotspot
	{
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x1C3A970", Offset = "0x1C39B70", VA = "0x181C3A970")]
		[CompilerGenerated]
		readonly get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x1F9D610", Offset = "0x1F9C810", VA = "0x181F9D610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170001F4")]
	internal int defaultCursorId
	{
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x2AF42E0", Offset = "0x2AF34E0", VA = "0x182AF42E0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x2AF4410", Offset = "0x2AF3610", VA = "0x182AF4410", Slot = "4")]
	public bool Equals(Cursor other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x2AF44C0", Offset = "0x2AF36C0", VA = "0x182AF44C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x2AF4720", Offset = "0x2AF3920", VA = "0x182AF4720")]
	public static bool operator ==(Cursor style1, Cursor style2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x2AF46A0", Offset = "0x2AF38A0", VA = "0x182AF46A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
