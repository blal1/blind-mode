using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Properties.Internal;

[Token(Token = "0x2000078")]
internal class Vector3PropertyBag : ContainerPropertyBag<Vector3>
{
	[Token(Token = "0x2000079")]
	private class XProperty : Property<Vector3, float>
	{
		[Token(Token = "0x1700005D")]
		public override string Name
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x28FB990", Offset = "0x28FAB90", VA = "0x1828FB990", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x28F60E0", Offset = "0x28F52E0", VA = "0x1828F60E0", Slot = "14")]
		public override float GetValue(ref Vector3 container)
		{
			return default(float);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x28F60F0", Offset = "0x28F52F0", VA = "0x1828F60F0", Slot = "15")]
		public override void SetValue(ref Vector3 container, float value)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x28FB750", Offset = "0x28FA950", VA = "0x1828FB750")]
		public XProperty()
		{
		}
	}

	[Token(Token = "0x200007A")]
	private class YProperty : Property<Vector3, float>
	{
		[Token(Token = "0x1700005F")]
		public override string Name
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x28FBD30", Offset = "0x28FAF30", VA = "0x1828FBD30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x28D8890", Offset = "0x28D7A90", VA = "0x1828D8890", Slot = "14")]
		public override float GetValue(ref Vector3 container)
		{
			return default(float);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x28D88A0", Offset = "0x28D7AA0", VA = "0x1828D88A0", Slot = "15")]
		public override void SetValue(ref Vector3 container, float value)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x28FBB10", Offset = "0x28FAD10", VA = "0x1828FBB10")]
		public YProperty()
		{
		}
	}

	[Token(Token = "0x200007B")]
	private class ZProperty : Property<Vector3, float>
	{
		[Token(Token = "0x17000061")]
		public override string Name
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x28FBE50", Offset = "0x28FB050", VA = "0x1828FBE50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x28D7BC0", Offset = "0x28D6DC0", VA = "0x1828D7BC0", Slot = "14")]
		public override float GetValue(ref Vector3 container)
		{
			return default(float);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x28D7BD0", Offset = "0x28D6DD0", VA = "0x1828D7BD0", Slot = "15")]
		public override void SetValue(ref Vector3 container, float value)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x28FBDE0", Offset = "0x28FAFE0", VA = "0x1828FBDE0")]
		public ZProperty()
		{
		}
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x28FB210", Offset = "0x28FA410", VA = "0x1828FB210")]
	public Vector3PropertyBag()
	{
	}
}
