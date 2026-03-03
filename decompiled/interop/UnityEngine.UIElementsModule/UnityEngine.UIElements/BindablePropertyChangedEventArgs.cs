using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000044")]
public readonly struct BindablePropertyChangedEventArgs
{
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x0")]
	private readonly BindingId m_PropertyName;

	[Token(Token = "0x17000041")]
	public BindingId propertyName
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1C25540", Offset = "0x1C24740", VA = "0x181C25540")]
		get
		{
			return default(BindingId);
		}
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x29A6220", Offset = "0x29A5420", VA = "0x1829A6220")]
	public BindablePropertyChangedEventArgs(in BindingId propertyName)
	{
	}
}
