using Il2CppDummyDll;
using UnityEngine.UI;

namespace YgomGame.Shop;

[Token(Token = "0x20009CD")]
public interface IRawImageUVSetting
{
	[Token(Token = "0x6003BC1")]
	void ImportRawImage(RawImage rawImage);

	[Token(Token = "0x6003BC2")]
	void ExportRawImage(RawImage rawImage);
}
