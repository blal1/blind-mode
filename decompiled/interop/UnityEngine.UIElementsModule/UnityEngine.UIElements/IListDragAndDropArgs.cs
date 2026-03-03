using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000196")]
internal interface IListDragAndDropArgs
{
	[Token(Token = "0x17000222")]
	int insertAtIndex
	{
		[Token(Token = "0x6000C15")]
		get;
	}

	[Token(Token = "0x17000223")]
	int parentId
	{
		[Token(Token = "0x6000C16")]
		get;
	}

	[Token(Token = "0x17000224")]
	int childIndex
	{
		[Token(Token = "0x6000C17")]
		get;
	}

	[Token(Token = "0x17000225")]
	DragAndDropData dragAndDropData
	{
		[Token(Token = "0x6000C18")]
		get;
	}

	[Token(Token = "0x17000226")]
	DragAndDropPosition dragAndDropPosition
	{
		[Token(Token = "0x6000C19")]
		get;
	}
}
