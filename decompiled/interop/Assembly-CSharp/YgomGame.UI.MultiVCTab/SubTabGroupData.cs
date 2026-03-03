using Il2CppDummyDll;

namespace YgomGame.UI.MultiVCTab;

[Token(Token = "0x200071C")]
public class SubTabGroupData : ISubTabGruopData
{
	[Token(Token = "0x400236A")]
	[FieldOffset(Offset = "0x10")]
	private int m_GroupId;

	[Token(Token = "0x400236B")]
	[FieldOffset(Offset = "0x18")]
	private string m_LabelTextId;

	[Token(Token = "0x400236C")]
	[FieldOffset(Offset = "0x20")]
	private string m_Param;

	[Token(Token = "0x170005CE")]
	public int groupId
	{
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005CF")]
	public string labelTextId
	{
		[Token(Token = "0x6002ED3")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D0")]
	public virtual string labelText
	{
		[Token(Token = "0x6002ED4")]
		[Address(RVA = "0x722C30", Offset = "0x721E30", VA = "0x180722C30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D1")]
	public string param
	{
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
	public void SetGroupId(int id)
	{
	}

	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
	public void SetLabelTextId(string id)
	{
	}

	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetParam(string param)
	{
	}

	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SubTabGroupData()
	{
	}
}
