using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200140C")]
public interface IAsyncProgressContainer
{
	[Token(Token = "0x17001314")]
	IReadOnlyList<IAsyncProgressContent> asyncProgressContents
	{
		[Token(Token = "0x6007CA9")]
		get;
	}
}
