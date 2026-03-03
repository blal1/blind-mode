using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000042")]
public interface IDataSourceProvider
{
	[Token(Token = "0x1700003F")]
	object dataSource
	{
		[Token(Token = "0x60001FD")]
		get;
	}

	[Token(Token = "0x17000040")]
	PropertyPath dataSourcePath
	{
		[Token(Token = "0x60001FE")]
		get;
	}
}
