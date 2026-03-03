using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A29")]
public class DuelFieldNewMaster : DuelFieldBase
{
	[Token(Token = "0x2001A2A")]
	public class HalfMat
	{
		[Token(Token = "0x400F1C3")]
		[FieldOffset(Offset = "0x10")]
		public GameObject root;

		[Token(Token = "0x400F1C4")]
		[FieldOffset(Offset = "0x18")]
		public GameObject matModel;

		[Token(Token = "0x400F1C5")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] monsters;

		[Token(Token = "0x400F1C6")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] magics;

		[Token(Token = "0x400F1C7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject mainDeck;

		[Token(Token = "0x400F1C8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject grave;

		[Token(Token = "0x400F1C9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject exclude;

		[Token(Token = "0x400F1CA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject fieldMagic;

		[Token(Token = "0x400F1CB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject extra;

		[Token(Token = "0x600A955")]
		[Address(RVA = "0xF683E0", Offset = "0xF675E0", VA = "0x180F683E0")]
		public HalfMat()
		{
		}
	}

	[Token(Token = "0x400F1C2")]
	[FieldOffset(Offset = "0xA0")]
	private HalfMat[] mats;

	[Token(Token = "0x17001A13")]
	public override int numMonsterPlaces
	{
		[Token(Token = "0x600A946")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A14")]
	public override int numMagicPlaces
	{
		[Token(Token = "0x600A947")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A15")]
	public override int monsterStartIdx
	{
		[Token(Token = "0x600A948")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A16")]
	public override int monsterEndIdx
	{
		[Token(Token = "0x600A949")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "25")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A17")]
	public override int magicStartIdx
	{
		[Token(Token = "0x600A94A")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "26")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A18")]
	public override int magicEndIdx
	{
		[Token(Token = "0x600A94B")]
		[Address(RVA = "0x3FC090", Offset = "0x3FB290", VA = "0x1803FC090", Slot = "27")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A19")]
	protected override string nearMatResourcePath
	{
		[Token(Token = "0x600A94C")]
		[Address(RVA = "0xF5E630", Offset = "0xF5D830", VA = "0x180F5E630", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A1A")]
	protected override string farMatResourcePath
	{
		[Token(Token = "0x600A94D")]
		[Address(RVA = "0xF5E590", Offset = "0xF5D790", VA = "0x180F5E590", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A1B")]
	protected override Vector3 matSize
	{
		[Token(Token = "0x600A94F")]
		[Address(RVA = "0xF5E5C0", Offset = "0xF5D7C0", VA = "0x180F5E5C0", Slot = "17")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x600A94E")]
	[Address(RVA = "0xF5D340", Offset = "0xF5C540", VA = "0x180F5D340", Slot = "12")]
	protected override void AssignAll(SharedDefinition.Location loc, GameObject parent)
	{
	}

	[Token(Token = "0x600A950")]
	[Address(RVA = "0xF5DBB0", Offset = "0xF5CDB0", VA = "0x180F5DBB0", Slot = "13")]
	protected override GameObject GetFrame(SharedDefinition.Location loc, int position)
	{
		return null;
	}

	[Token(Token = "0x600A951")]
	[Address(RVA = "0xF5E020", Offset = "0xF5D220", VA = "0x180F5E020", Slot = "14")]
	protected override List<GameObject> GetFrames(SharedDefinition.Location loc)
	{
		return null;
	}

	[Token(Token = "0x600A952")]
	[Address(RVA = "0xF5E450", Offset = "0xF5D650", VA = "0x180F5E450", Slot = "15")]
	protected override GameObject GetPlayMat(SharedDefinition.Location loc)
	{
		return null;
	}

	[Token(Token = "0x600A953")]
	[Address(RVA = "0xF5E3E0", Offset = "0xF5D5E0", VA = "0x180F5E3E0", Slot = "16")]
	protected override MeshRenderer GetPlayMatRenderer(SharedDefinition.Location loc)
	{
		return null;
	}

	[Token(Token = "0x600A954")]
	[Address(RVA = "0xF5E490", Offset = "0xF5D690", VA = "0x180F5E490")]
	public DuelFieldNewMaster()
	{
	}
}
