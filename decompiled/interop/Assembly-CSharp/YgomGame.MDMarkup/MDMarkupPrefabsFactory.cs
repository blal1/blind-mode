using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CCA")]
public class MDMarkupPrefabsFactory : MDMarkupWidgetFactoryBase
{
	[Token(Token = "0x4009C2A")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<string, GameObject> m_TemplateMap;

	[Token(Token = "0x17000AFA")]
	public IReadOnlyDictionary<string, GameObject> templateMap
	{
		[Token(Token = "0x6004D70")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004D71")]
	[Address(RVA = "0x958670", Offset = "0x957870", VA = "0x180958670")]
	public MDMarkupPrefabsFactory(Dictionary<string, GameObject> templateMap)
	{
	}

	[Token(Token = "0x6004D72")]
	[Address(RVA = "0x9585F0", Offset = "0x9577F0", VA = "0x1809585F0", Slot = "5")]
	public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
	{
		return null;
	}
}
