using System.Collections;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview;

[Token(Token = "0x2000E2B")]
public interface IPreviewPlayerController
{
	[Token(Token = "0x17000CCE")]
	ControllerType controllerType
	{
		[Token(Token = "0x60055D8")]
		get;
	}

	[Token(Token = "0x60055D9")]
	IEnumerator yInitialize();

	[Token(Token = "0x60055DA")]
	void Terminate();

	[Token(Token = "0x60055DB")]
	void Release();
}
