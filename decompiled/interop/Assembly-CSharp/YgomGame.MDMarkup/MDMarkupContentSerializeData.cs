using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C92")]
public class MDMarkupContentSerializeData
{
	[Token(Token = "0x4009B89")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	protected string tp;

	[Token(Token = "0x4009B8A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected string data;

	[Token(Token = "0x6004C35")]
	[Address(RVA = "0x93C930", Offset = "0x93BB30", VA = "0x18093C930")]
	public MDMarkupContentSerializeData(IMDMarkupContent content)
	{
	}

	[Token(Token = "0x6004C36")]
	[Address(RVA = "0x93C8C0", Offset = "0x93BAC0", VA = "0x18093C8C0")]
	public MDMarkupDef.MarkupType GetMarkupType()
	{
		return default(MDMarkupDef.MarkupType);
	}

	[Token(Token = "0x6004C37")]
	[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
	public string GetData()
	{
		return null;
	}
}
