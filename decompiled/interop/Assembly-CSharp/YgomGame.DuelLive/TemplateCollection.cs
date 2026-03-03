using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F52")]
public class TemplateCollection
{
	[Token(Token = "0x2000F53")]
	public class Info
	{
		[Token(Token = "0x400A77D")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x400A77E")]
		[FieldOffset(Offset = "0x18")]
		public GameObject templateObj;

		[Token(Token = "0x400A77F")]
		[FieldOffset(Offset = "0x20")]
		public bool isSelectable;

		[Token(Token = "0x400A780")]
		[FieldOffset(Offset = "0x28")]
		public string label;

		[Token(Token = "0x6005D25")]
		[Address(RVA = "0xA1E160", Offset = "0xA1D360", VA = "0x180A1E160")]
		public Info(int index, GameObject templateObj, bool isSelectable, string name)
		{
		}

		[Token(Token = "0x6005D26")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		private Info()
		{
		}
	}

	[Token(Token = "0x400A77B")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, Info> m_templateInfos;

	[Token(Token = "0x400A77C")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, Info> m_templateInfosByLabel;

	[Token(Token = "0x17000EAB")]
	public int dataNum
	{
		[Token(Token = "0x6005D1F")]
		[Address(RVA = "0xA2B7E0", Offset = "0xA2A9E0", VA = "0x180A2B7E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005D20")]
	[Address(RVA = "0xA2B410", Offset = "0xA2A610", VA = "0x180A2B410")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005D21")]
	[Address(RVA = "0xA2B640", Offset = "0xA2A840", VA = "0x180A2B640")]
	public void RegisterTemplate(Info info)
	{
	}

	[Token(Token = "0x6005D22")]
	[Address(RVA = "0xA2B460", Offset = "0xA2A660", VA = "0x180A2B460")]
	public Info GetInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x6005D23")]
	[Address(RVA = "0xA2B4F0", Offset = "0xA2A6F0", VA = "0x180A2B4F0")]
	public List<GameObject> GetOrderedTemplateList()
	{
		return null;
	}

	[Token(Token = "0x6005D24")]
	[Address(RVA = "0xA2B720", Offset = "0xA2A920", VA = "0x180A2B720")]
	public TemplateCollection()
	{
	}
}
