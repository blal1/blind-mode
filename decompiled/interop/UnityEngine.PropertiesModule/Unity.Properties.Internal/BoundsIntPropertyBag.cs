using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Properties.Internal;

[Token(Token = "0x2000095")]
internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
{
	[Token(Token = "0x2000096")]
	private class PositionProperty : Property<BoundsInt, Vector3Int>
	{
		[Token(Token = "0x17000089")]
		public override string Name
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x28D9220", Offset = "0x28D8420", VA = "0x1828D9220", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x28D7F70", Offset = "0x28D7170", VA = "0x1828D7F70", Slot = "14")]
		public override Vector3Int GetValue(ref BoundsInt container)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x28D7F90", Offset = "0x28D7190", VA = "0x1828D7F90", Slot = "15")]
		public override void SetValue(ref BoundsInt container, Vector3Int value)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x28D91E0", Offset = "0x28D83E0", VA = "0x1828D91E0")]
		public PositionProperty()
		{
		}
	}

	[Token(Token = "0x2000097")]
	private class SizeProperty : Property<BoundsInt, Vector3Int>
	{
		[Token(Token = "0x1700008B")]
		public override string Name
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x28F6F80", Offset = "0x28F6180", VA = "0x1828F6F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x28D8700", Offset = "0x28D7900", VA = "0x1828D8700", Slot = "14")]
		public override Vector3Int GetValue(ref BoundsInt container)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x28D8720", Offset = "0x28D7920", VA = "0x1828D8720", Slot = "15")]
		public override void SetValue(ref BoundsInt container, Vector3Int value)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x28F6F40", Offset = "0x28F6140", VA = "0x1828F6F40")]
		public SizeProperty()
		{
		}
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x28D7C50", Offset = "0x28D6E50", VA = "0x1828D7C50")]
	public BoundsIntPropertyBag()
	{
	}
}
