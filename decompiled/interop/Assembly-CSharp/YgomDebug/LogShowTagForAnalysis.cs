using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomDebug;

[Token(Token = "0x2000136")]
public class LogShowTagForAnalysis : LogItemBaseForAnalysis
{
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected string m_Label_TagName;

	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170000D9")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x9DA030", Offset = "0x9D9230", VA = "0x1809DA030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x9D9E30", Offset = "0x9D9030", VA = "0x1809D9E30")]
	public void SetData(ShowTagTypeForAnalysis type)
	{
	}

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x9D9F70", Offset = "0x9D9170", VA = "0x1809D9F70")]
	protected void SetTargetTag()
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x9D9D70", Offset = "0x9D8F70", VA = "0x1809D9D70")]
	protected void SetCostTag()
	{
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public LogShowTagForAnalysis()
	{
	}
}
