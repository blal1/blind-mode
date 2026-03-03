using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.CardFile;

[Token(Token = "0x20015A5")]
public class CardFileNinePocket : CardFileBase
{
	[Token(Token = "0x20015A6")]
	public class CardLocation
	{
		[Token(Token = "0x400CE32")]
		[FieldOffset(Offset = "0x10")]
		public GameObject root;

		[Token(Token = "0x400CE33")]
		[FieldOffset(Offset = "0x18")]
		public GameObject[] position;

		[Token(Token = "0x6008620")]
		[Address(RVA = "0xCF9BC0", Offset = "0xCF8DC0", VA = "0x180CF9BC0")]
		public CardLocation()
		{
		}
	}

	[Token(Token = "0x400CE31")]
	[FieldOffset(Offset = "0x50")]
	private CardLocation[] cardLocations;

	[Token(Token = "0x600861D")]
	[Address(RVA = "0xCEE210", Offset = "0xCED410", VA = "0x180CEE210", Slot = "4")]
	protected override void AssignAll(CardFileDefinition.Location loc, GameObject parent)
	{
	}

	[Token(Token = "0x600861E")]
	[Address(RVA = "0xCEE730", Offset = "0xCED930", VA = "0x180CEE730", Slot = "5")]
	protected override GameObject GetFrame(CardFileDefinition.Location loc, int position)
	{
		return null;
	}

	[Token(Token = "0x600861F")]
	[Address(RVA = "0xCEE780", Offset = "0xCED980", VA = "0x180CEE780")]
	public CardFileNinePocket()
	{
	}
}
