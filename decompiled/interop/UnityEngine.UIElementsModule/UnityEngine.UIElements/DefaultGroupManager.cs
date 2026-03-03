using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000269")]
internal class DefaultGroupManager : IGroupManager
{
	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x10")]
	private List<IGroupBoxOption> m_GroupOptions;

	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x18")]
	private IGroupBoxOption m_SelectedOption;

	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x20")]
	private IGroupBox m_GroupBox;

	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380", Slot = "4")]
	public void Init(IGroupBox groupBox)
	{
	}

	[Token(Token = "0x60010E4")]
	[Address(RVA = "0x2B29ED0", Offset = "0x2B290D0", VA = "0x182B29ED0", Slot = "5")]
	public void OnOptionSelectionChanged(IGroupBoxOption selectedOption)
	{
	}

	[Token(Token = "0x60010E5")]
	[Address(RVA = "0x2B2A0A0", Offset = "0x2B292A0", VA = "0x182B2A0A0", Slot = "6")]
	public void RegisterOption(IGroupBoxOption option)
	{
	}

	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x2B2A1A0", Offset = "0x2B293A0", VA = "0x182B2A1A0", Slot = "7")]
	public void UnregisterOption(IGroupBoxOption option)
	{
	}

	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x2B2A220", Offset = "0x2B29420", VA = "0x182B2A220")]
	public DefaultGroupManager()
	{
	}
}
