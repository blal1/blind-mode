using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003E7")]
internal class StyleValuePropertyBag<TContainer, TValue> : ContainerPropertyBag<TContainer> where TContainer : IStyleValue<TValue>
{
	[Token(Token = "0x20003E8")]
	private class ValueProperty : Property<TContainer, TValue>
	{
		[Token(Token = "0x17000846")]
		public override string Name
		{
			[Token(Token = "0x6001E06")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000847")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001E07")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001E08")]
		public override TValue GetValue(ref TContainer container)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6001E09")]
		public override void SetValue(ref TContainer container, TValue value)
		{
		}

		[Token(Token = "0x6001E0A")]
		public ValueProperty()
		{
		}
	}

	[Token(Token = "0x20003E9")]
	private class KeywordProperty : Property<TContainer, StyleKeyword>
	{
		[Token(Token = "0x17000848")]
		public override string Name
		{
			[Token(Token = "0x6001E0B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000849")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001E0C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001E0D")]
		public override StyleKeyword GetValue(ref TContainer container)
		{
			return default(StyleKeyword);
		}

		[Token(Token = "0x6001E0E")]
		public override void SetValue(ref TContainer container, StyleKeyword value)
		{
		}

		[Token(Token = "0x6001E0F")]
		public KeywordProperty()
		{
		}
	}

	[Token(Token = "0x6001E05")]
	public StyleValuePropertyBag()
	{
	}
}
