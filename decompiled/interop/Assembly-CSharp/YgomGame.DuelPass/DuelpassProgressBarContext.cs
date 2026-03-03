using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000EC9")]
public class DuelpassProgressBarContext
{
	[Token(Token = "0x17000DC9")]
	public bool HasGoldpass
	{
		[Token(Token = "0x6005990")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005991")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DCA")]
	public GradeContext Grade
	{
		[Token(Token = "0x6005992")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005993")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6005994")]
	[Address(RVA = "0x9F0AB0", Offset = "0x9EFCB0", VA = "0x1809F0AB0")]
	public DuelpassProgressBarContext(int currentGrade, int progressPercent, bool hasGoldpass)
	{
	}
}
