using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x200156E")]
public class SequenceController : IReadOnlySequenceController
{
	[Token(Token = "0x400CCB2")]
	[FieldOffset(Offset = "0x10")]
	public readonly SequenceBehaviourWork work;

	[Token(Token = "0x400CCB3")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<ISequenceBehaviour> behaviourList;

	[Token(Token = "0x400CCB4")]
	[FieldOffset(Offset = "0x20")]
	private int m_BehaviourIdx;

	[Token(Token = "0x17001437")]
	public bool isDone
	{
		[Token(Token = "0x600845B")]
		[Address(RVA = "0xCE0EB0", Offset = "0xCE00B0", VA = "0x180CE0EB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600845C")]
	[Address(RVA = "0xCE0E10", Offset = "0xCE0010", VA = "0x180CE0E10")]
	public SequenceController(SequenceBehaviourWork work)
	{
	}

	[Token(Token = "0x600845D")]
	[Address(RVA = "0xCE0D00", Offset = "0xCDFF00", VA = "0x180CE0D00")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600845E")]
	[Address(RVA = "0xCE0A20", Offset = "0xCDFC20", VA = "0x180CE0A20")]
	public bool IsSkippableAll()
	{
		return default(bool);
	}

	[Token(Token = "0x600845F")]
	[Address(RVA = "0xCE0BD0", Offset = "0xCDFDD0", VA = "0x180CE0BD0")]
	public void Skip()
	{
	}

	[Token(Token = "0x6008460")]
	[Address(RVA = "0xCE06E0", Offset = "0xCDF8E0", VA = "0x180CE06E0", Slot = "4")]
	public void CalcPackProgressInfo(out int packIdxRes, out int packTotalRes)
	{
	}

	[Token(Token = "0x6008461")]
	[Address(RVA = "0xCE07E0", Offset = "0xCDF9E0", VA = "0x180CE07E0", Slot = "5")]
	public int CalcTotalFoundedKey()
	{
		return default(int);
	}

	[Token(Token = "0x6008462")]
	[Address(RVA = "0xCE0B30", Offset = "0xCDFD30", VA = "0x180CE0B30")]
	public bool OnBack()
	{
		return default(bool);
	}
}
