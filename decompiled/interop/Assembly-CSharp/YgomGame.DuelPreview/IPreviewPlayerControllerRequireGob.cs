using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelPreview;

[Token(Token = "0x2000E2C")]
public interface IPreviewPlayerControllerRequireGob : IPreviewPlayerController
{
	[Token(Token = "0x60055DC")]
	void BindGob(params GameObject[] gobs);

	[Token(Token = "0x60055DD")]
	void UnbindGob();
}
