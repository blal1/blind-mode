using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Certification;

[Token(Token = "0x200151F")]
public class CertificationDuelFieldSettings : ScriptableObject
{
	[Token(Token = "0x2001520")]
	public enum AffectType
	{
		[Token(Token = "0x400CB3C")]
		Null = 0,
		[Token(Token = "0x400CB3D")]
		Equip = 1,
		[Token(Token = "0x400CB3E")]
		Permanent = 2,
		[Token(Token = "0x400CB3F")]
		Field = 3,
		[Token(Token = "0x400CB40")]
		Bind = 4,
		[Token(Token = "0x400CB41")]
		Power = 5,
		[Token(Token = "0x400CB42")]
		Target = 6,
		[Token(Token = "0x400CB43")]
		Disable = 7,
		[Token(Token = "0x400CB44")]
		Chain = 256
	}

	[Token(Token = "0x2001521")]
	public enum FieldPostion
	{
		[Token(Token = "0x400CB46")]
		monsterLeft2,
		[Token(Token = "0x400CB47")]
		monsterLeft1,
		[Token(Token = "0x400CB48")]
		monsterCenter,
		[Token(Token = "0x400CB49")]
		monsterRight1,
		[Token(Token = "0x400CB4A")]
		monsterRight2,
		[Token(Token = "0x400CB4B")]
		ExLeft,
		[Token(Token = "0x400CB4C")]
		ExRight,
		[Token(Token = "0x400CB4D")]
		MagicLeft2,
		[Token(Token = "0x400CB4E")]
		MagicLeft1,
		[Token(Token = "0x400CB4F")]
		MagicCenter,
		[Token(Token = "0x400CB50")]
		MagicRight1,
		[Token(Token = "0x400CB51")]
		MagicRight2,
		[Token(Token = "0x400CB52")]
		Field,
		[Token(Token = "0x400CB53")]
		Hand,
		[Token(Token = "0x400CB54")]
		DeckEx,
		[Token(Token = "0x400CB55")]
		Deck,
		[Token(Token = "0x400CB56")]
		Grave,
		[Token(Token = "0x400CB57")]
		exclusion,
		[Token(Token = "0x400CB58")]
		special
	}

	[Serializable]
	[Token(Token = "0x2001522")]
	public class IconData
	{
		[Token(Token = "0x400CB59")]
		[FieldOffset(Offset = "0x10")]
		public string paramName;

		[Token(Token = "0x400CB5A")]
		[FieldOffset(Offset = "0x18")]
		public int player;

		[Token(Token = "0x400CB5B")]
		[FieldOffset(Offset = "0x1C")]
		public FieldPostion position;

		[Token(Token = "0x400CB5C")]
		[FieldOffset(Offset = "0x20")]
		public AffectType affectType;

		[Token(Token = "0x60082A8")]
		[Address(RVA = "0xCBF1C0", Offset = "0xCBE3C0", VA = "0x180CBF1C0")]
		public IconData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001523")]
	public class DuelFieldInfo
	{
		[Token(Token = "0x400CB5D")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400CB5E")]
		[FieldOffset(Offset = "0x18")]
		public long quizID;

		[Token(Token = "0x400CB5F")]
		[FieldOffset(Offset = "0x20")]
		public string jsonData;

		[Token(Token = "0x400CB60")]
		[FieldOffset(Offset = "0x28")]
		public List<IconData> iconDataList;

		[Token(Token = "0x400CB61")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 scroll;

		[Token(Token = "0x60082A9")]
		[Address(RVA = "0xCBDC90", Offset = "0xCBCE90", VA = "0x180CBDC90")]
		public DuelFieldInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x60082AA")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DuelFieldInfo()
		{
		}
	}

	[Token(Token = "0x400CB38")]
	private const string duelFieldSettingPath = "Prefabs/Certification/ScriptableObject/CertificationDuelFieldSettings";

	[Token(Token = "0x400CB39")]
	[FieldOffset(Offset = "0x0")]
	private static CertificationDuelFieldSettings setting;

	[Token(Token = "0x400CB3A")]
	[FieldOffset(Offset = "0x18")]
	public List<DuelFieldInfo> infoList;

	[Token(Token = "0x60082A6")]
	[Address(RVA = "0xCBD170", Offset = "0xCBC370", VA = "0x180CBD170")]
	public static void Load(Action<CertificationDuelFieldSettings> onFinish)
	{
	}

	[Token(Token = "0x60082A7")]
	[Address(RVA = "0xCBD2F0", Offset = "0xCBC4F0", VA = "0x180CBD2F0")]
	public CertificationDuelFieldSettings()
	{
	}
}
