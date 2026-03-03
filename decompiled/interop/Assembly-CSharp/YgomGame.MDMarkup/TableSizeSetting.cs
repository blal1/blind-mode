using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000CA7")]
public class TableSizeSetting
{
	[Token(Token = "0x4009BC5")]
	[FieldOffset(Offset = "0x10")]
	public int colLength;

	[Token(Token = "0x4009BC6")]
	[FieldOffset(Offset = "0x18")]
	public List<float> colSizes;

	[Token(Token = "0x6004CD4")]
	[Address(RVA = "0x948210", Offset = "0x947410", VA = "0x180948210")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004CD5")]
	[Address(RVA = "0x948410", Offset = "0x947610", VA = "0x180948410")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004CD6")]
	[Address(RVA = "0x948650", Offset = "0x947850", VA = "0x180948650")]
	public TableSizeSetting()
	{
	}
}
