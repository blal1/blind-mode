using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Properties.Internal;

[Token(Token = "0x2000075")]
internal class Vector2PropertyBag : ContainerPropertyBag<Vector2>
{
	[Token(Token = "0x2000076")]
	private class XProperty : Property<Vector2, float>
	{
		[Token(Token = "0x17000059")]
		public override string Name
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x28FB8D0", Offset = "0x28FAAD0", VA = "0x1828FB8D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x28F60E0", Offset = "0x28F52E0", VA = "0x1828F60E0", Slot = "14")]
		public override float GetValue(ref Vector2 container)
		{
			return default(float);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x28F60F0", Offset = "0x28F52F0", VA = "0x1828F60F0", Slot = "15")]
		public override void SetValue(ref Vector2 container, float value)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x28FB710", Offset = "0x28FA910", VA = "0x1828FB710")]
		public XProperty()
		{
		}
	}

	[Token(Token = "0x2000077")]
	private class YProperty : Property<Vector2, float>
	{
		[Token(Token = "0x1700005B")]
		public override string Name
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x28FBD00", Offset = "0x28FAF00", VA = "0x1828FBD00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x28D8890", Offset = "0x28D7A90", VA = "0x1828D8890", Slot = "14")]
		public override float GetValue(ref Vector2 container)
		{
			return default(float);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x28D88A0", Offset = "0x28D7AA0", VA = "0x1828D88A0", Slot = "15")]
		public override void SetValue(ref Vector2 container, float value)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x28FBB90", Offset = "0x28FAD90", VA = "0x1828FBB90")]
		public YProperty()
		{
		}
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x28FAF70", Offset = "0x28FA170", VA = "0x1828FAF70")]
	public Vector2PropertyBag()
	{
	}
}
