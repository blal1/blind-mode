using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001499")]
public class RegulationLogoResourceBinder : ResourceBinderBase
{
	[Serializable]
	[Token(Token = "0x200149A")]
	public class RegulationLogoPathData
	{
		[Token(Token = "0x400C704")]
		[FieldOffset(Offset = "0x10")]
		public string m_RegulationLogoPath;

		[Token(Token = "0x6007FDD")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RegulationLogoPathData()
		{
		}
	}

	[Token(Token = "0x400C703")]
	[FieldOffset(Offset = "0x10")]
	private RegulationLogoPathData m_PathData;

	[Token(Token = "0x6007FD9")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(RegulationLogoPathData pathData)
	{
	}

	[Token(Token = "0x6007FDA")]
	[Address(RVA = "0xC7A850", Offset = "0xC79A50", VA = "0x180C7A850")]
	public string GetLogoPath(int id)
	{
		return null;
	}

	[Token(Token = "0x6007FDB")]
	[Address(RVA = "0xC7A680", Offset = "0xC79880", VA = "0x180C7A680")]
	public BindingImageEx BindEventLogo(Image target, int id, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007FDC")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RegulationLogoResourceBinder()
	{
	}
}
