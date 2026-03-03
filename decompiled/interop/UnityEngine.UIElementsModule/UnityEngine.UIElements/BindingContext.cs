using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200001E")]
public readonly struct BindingContext
{
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x0")]
	private readonly VisualElement m_TargetElement;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x8")]
	private readonly BindingId m_BindingId;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0xA0")]
	private readonly PropertyPath m_DataSourcePath;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x130")]
	private readonly object m_DataSource;

	[Token(Token = "0x1700001D")]
	public VisualElement targetElement
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public BindingId bindingId
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1C3AA40", Offset = "0x1C39C40", VA = "0x181C3AA40")]
		get
		{
			return default(BindingId);
		}
	}

	[Token(Token = "0x1700001F")]
	public PropertyPath dataSourcePath
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2975830", Offset = "0x2974A30", VA = "0x182975830")]
		get
		{
			return default(PropertyPath);
		}
	}

	[Token(Token = "0x17000020")]
	public object dataSource
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0xABF8A0", Offset = "0xABEAA0", VA = "0x180ABF8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x29756D0", Offset = "0x29748D0", VA = "0x1829756D0")]
	internal BindingContext(VisualElement targetElement, in BindingId bindingId, in PropertyPath resolvedDataSourcePath, object resolvedDataSource)
	{
	}
}
