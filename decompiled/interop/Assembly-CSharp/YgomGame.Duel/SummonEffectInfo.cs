using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20017A5")]
internal class SummonEffectInfo
{
	[Token(Token = "0x170016AD")]
	public List<int> summonTargetUniqueID
	{
		[Token(Token = "0x60094CB")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60094CC")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60094CD")]
	[Address(RVA = "0xDEE3D0", Offset = "0xDED5D0", VA = "0x180DEE3D0")]
	public void SetSummonTargetUniqueID(int[] uniqueIDs)
	{
	}

	[Token(Token = "0x60094CE")]
	[Address(RVA = "0xDEE430", Offset = "0xDED630", VA = "0x180DEE430")]
	public void SetSummonTargetUniqueID(int uniqueID)
	{
	}

	[Token(Token = "0x60094CF")]
	[Address(RVA = "0xDEE260", Offset = "0xDED460", VA = "0x180DEE260")]
	public void ClearSummonTargetUniqueID()
	{
	}

	[Token(Token = "0x60094D0")]
	[Address(RVA = "0xDEE350", Offset = "0xDED550", VA = "0x180DEE350")]
	public void RemoveSummonTargetUniqueID(int uniqueID)
	{
	}

	[Token(Token = "0x60094D1")]
	[Address(RVA = "0xDEE2F0", Offset = "0xDED4F0", VA = "0x180DEE2F0")]
	public bool IsContains(int uniqueID)
	{
		return default(bool);
	}

	[Token(Token = "0x60094D2")]
	[Address(RVA = "0xDEE2B0", Offset = "0xDED4B0", VA = "0x180DEE2B0")]
	public int GetSummonTargetCount()
	{
		return default(int);
	}

	[Token(Token = "0x60094D3")]
	[Address(RVA = "0xDEE4D0", Offset = "0xDED6D0", VA = "0x180DEE4D0")]
	public SummonEffectInfo()
	{
	}
}
