using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000012")]
public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue>
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly PropertyGetter<TContainer, TValue> m_Getter;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly PropertySetter<TContainer, TValue> m_Setter;

	[Token(Token = "0x17000003")]
	public override string Name
	{
		[Token(Token = "0x6000027")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public override bool IsReadOnly
	{
		[Token(Token = "0x6000028")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000029")]
	public DelegateProperty(string name, PropertyGetter<TContainer, TValue> getter, [Optional] PropertySetter<TContainer, TValue> setter)
	{
	}

	[Token(Token = "0x600002A")]
	public override TValue GetValue(ref TContainer container)
	{
		return (TValue)null;
	}

	[Token(Token = "0x600002B")]
	public override void SetValue(ref TContainer container, TValue value)
	{
	}
}
