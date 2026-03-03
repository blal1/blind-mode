using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000180")]
internal class CursorManager : ICursorManager
{
	[Token(Token = "0x170001FB")]
	public bool isCursorOverriden
	{
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x2AF41B0", Offset = "0x2AF33B0", VA = "0x182AF41B0", Slot = "4")]
	public void SetCursor(Cursor cursor)
	{
	}

	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x2AF4140", Offset = "0x2AF3340", VA = "0x182AF4140", Slot = "5")]
	public void ResetCursor()
	{
	}

	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CursorManager()
	{
	}
}
