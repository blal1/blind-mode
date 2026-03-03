using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.UI.MultiVCTab;

[Token(Token = "0x200071D")]
public class SubTabGroupTreeData<T> : SubTabGroupData where T : class, ISubTabGruopData
{
	[Token(Token = "0x400236D")]
	[FieldOffset(Offset = "0x0")]
	private T[] m_Children;

	[Token(Token = "0x400236E")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, T> m_ChildrenMap;

	[Token(Token = "0x6002EDA")]
	public T[] GetChildren()
	{
		return null;
	}

	[Token(Token = "0x6002EDB")]
	public T GetGroupData(int groupId)
	{
		return null;
	}

	[Token(Token = "0x6002EDC")]
	public void AddChildrenData(T data)
	{
	}

	[Token(Token = "0x6002EDD")]
	public SubTabGroupTreeData()
	{
	}
}
