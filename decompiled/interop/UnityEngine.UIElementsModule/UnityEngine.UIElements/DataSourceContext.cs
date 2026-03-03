using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000040")]
public readonly struct DataSourceContext
{
	[Token(Token = "0x1700003D")]
	public object dataSource
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public PropertyPath dataSourcePath
	{
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x29AA330", Offset = "0x29A9530", VA = "0x1829AA330")]
		[CompilerGenerated]
		get
		{
			return default(PropertyPath);
		}
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x29AA290", Offset = "0x29A9490", VA = "0x1829AA290")]
	public DataSourceContext(object dataSource, in PropertyPath dataSourcePath)
	{
	}
}
