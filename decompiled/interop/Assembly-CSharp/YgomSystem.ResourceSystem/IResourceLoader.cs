using System.Collections;
using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002BF")]
public interface IResourceLoader
{
	[Token(Token = "0x170001AC")]
	bool DisablePathForErrorHandler
	{
		[Token(Token = "0x60010C6")]
		get;
	}

	[Token(Token = "0x60010C7")]
	void Initialize();

	[Token(Token = "0x60010C8")]
	void Load(Resource res, uint crc);

	[Token(Token = "0x60010C9")]
	IEnumerator LoadAsync(Resource res, uint key);

	[Token(Token = "0x60010CA")]
	void LateUpdate();

	[Token(Token = "0x60010CB")]
	void ClearCache();
}
