using System;
using Il2CppDummyDll;

namespace Unity.Properties.Internal;

[Token(Token = "0x2000098")]
internal class SystemVersionPropertyBag : ContainerPropertyBag<Version>
{
	[Token(Token = "0x2000099")]
	private class MajorProperty : Property<Version, int>
	{
		[Token(Token = "0x1700008D")]
		public override string Name
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x28D8E10", Offset = "0x28D8010", VA = "0x1828D8E10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x28D8D80", Offset = "0x28D7F80", VA = "0x1828D8D80")]
		public MajorProperty()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x28D8D60", Offset = "0x28D7F60", VA = "0x1828D8D60", Slot = "14")]
		public override int GetValue(ref Version container)
		{
			return default(int);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
		public override void SetValue(ref Version container, int value)
		{
		}
	}

	[Token(Token = "0x200009A")]
	private class MinorProperty : Property<Version, int>
	{
		[Token(Token = "0x1700008F")]
		public override string Name
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x28D8EF0", Offset = "0x28D80F0", VA = "0x1828D8EF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x28D8E60", Offset = "0x28D8060", VA = "0x1828D8E60")]
		public MinorProperty()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x28D8E40", Offset = "0x28D8040", VA = "0x1828D8E40", Slot = "14")]
		public override int GetValue(ref Version container)
		{
			return default(int);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
		public override void SetValue(ref Version container, int value)
		{
		}
	}

	[Token(Token = "0x200009B")]
	private class BuildProperty : Property<Version, int>
	{
		[Token(Token = "0x17000091")]
		public override string Name
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x28D7F40", Offset = "0x28D7140", VA = "0x1828D7F40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x28D7EB0", Offset = "0x28D70B0", VA = "0x1828D7EB0")]
		public BuildProperty()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x28D7E90", Offset = "0x28D7090", VA = "0x1828D7E90", Slot = "14")]
		public override int GetValue(ref Version container)
		{
			return default(int);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
		public override void SetValue(ref Version container, int value)
		{
		}
	}

	[Token(Token = "0x200009C")]
	private class RevisionProperty : Property<Version, int>
	{
		[Token(Token = "0x17000093")]
		public override string Name
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x28F6F10", Offset = "0x28F6110", VA = "0x1828F6F10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x28F6E80", Offset = "0x28F6080", VA = "0x1828F6E80")]
		public RevisionProperty()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x28F6E60", Offset = "0x28F6060", VA = "0x1828F6E60", Slot = "14")]
		public override int GetValue(ref Version container)
		{
			return default(int);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
		public override void SetValue(ref Version container, int value)
		{
		}
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x28F6FB0", Offset = "0x28F61B0", VA = "0x1828F6FB0")]
	public SystemVersionPropertyBag()
	{
	}
}
