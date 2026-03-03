using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x2000157")]
public class BranchData : ScriptableObject
{
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x18")]
	public string branchName;

	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x20")]
	public string commitHash;

	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x28")]
	public bool isReleaseBranch;

	[Token(Token = "0x600088B")]
	[Address(RVA = "0xAF2290", Offset = "0xAF1490", VA = "0x180AF2290")]
	public void SetData(string branchName, string hash)
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0xAF2320", Offset = "0xAF1520", VA = "0x180AF2320")]
	public BranchData()
	{
	}
}
