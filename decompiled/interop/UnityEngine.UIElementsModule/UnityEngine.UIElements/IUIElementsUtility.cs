using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000471")]
internal interface IUIElementsUtility
{
	[Token(Token = "0x60021A3")]
	bool TakeCapture();

	[Token(Token = "0x60021A4")]
	bool ReleaseCapture();

	[Token(Token = "0x60021A5")]
	bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled);

	[Token(Token = "0x60021A6")]
	bool CleanupRoots();

	[Token(Token = "0x60021A7")]
	bool EndContainerGUIFromException(Exception exception);

	[Token(Token = "0x60021A8")]
	bool MakeCurrentIMGUIContainerDirty();
}
