using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002AB")]
public class ResourceLoader
{
	[Token(Token = "0x20002AC")]
	public enum LoadType
	{
		[Token(Token = "0x4000F15")]
		None,
		[Token(Token = "0x4000F16")]
		BuiltIn,
		[Token(Token = "0x4000F17")]
		AssetBundle,
		[Token(Token = "0x4000F18")]
		Binary,
		[Token(Token = "0x4000F19")]
		Network,
		[Token(Token = "0x4000F1A")]
		StreamingBinary,
		[Token(Token = "0x4000F1B")]
		PlayAssetDelivery
	}

	[Token(Token = "0x4000F12")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, IResourceLoader> loaderDic;

	[Token(Token = "0x4000F13")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Resource.Type, LoadType> resourceTypeToLoaderDic;

	[Token(Token = "0x6001045")]
	[Address(RVA = "0xE77120", Offset = "0xE76320", VA = "0x180E77120")]
	public void Initialize(ResourceManager.ProgressHandler progressHandler, ResourceManager.RetryHandler retryHandler, float HttpTimeOut)
	{
	}

	[Token(Token = "0x6001046")]
	[Address(RVA = "0xE76EA0", Offset = "0xE760A0", VA = "0x180E76EA0")]
	public IResourceLoader GetLoader(Resource.Type resType)
	{
		return null;
	}

	[Token(Token = "0x6001047")]
	[Address(RVA = "0xE77590", Offset = "0xE76790", VA = "0x180E77590")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6001048")]
	[Address(RVA = "0xE76C70", Offset = "0xE75E70", VA = "0x180E76C70")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x6001049")]
	[Address(RVA = "0xE76E30", Offset = "0xE76030", VA = "0x180E76E30")]
	public void Destroy()
	{
	}

	[Token(Token = "0x600104A")]
	[Address(RVA = "0xE76F80", Offset = "0xE76180", VA = "0x180E76F80")]
	public string GetPathFromSpriteTagName(string tag)
	{
		return null;
	}

	[Token(Token = "0x600104B")]
	[Address(RVA = "0xE77750", Offset = "0xE76950", VA = "0x180E77750")]
	public ResourceLoader()
	{
	}
}
