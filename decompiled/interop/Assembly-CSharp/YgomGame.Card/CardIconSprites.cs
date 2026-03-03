using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Card;

[Token(Token = "0x2001606")]
public class CardIconSprites : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001607")]
	public class AttributeIconTable
	{
		[Token(Token = "0x400D452")]
		[FieldOffset(Offset = "0x10")]
		public Content.Attribute attr;

		[Token(Token = "0x400D453")]
		[FieldOffset(Offset = "0x18")]
		public Sprite icon;

		[Token(Token = "0x600890F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AttributeIconTable()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001608")]
	public class SpellTrapIconTable
	{
		[Token(Token = "0x400D454")]
		[FieldOffset(Offset = "0x10")]
		public Content.Icon type;

		[Token(Token = "0x400D455")]
		[FieldOffset(Offset = "0x18")]
		public Sprite icon;

		[Token(Token = "0x6008910")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SpellTrapIconTable()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001609")]
	public class TypeIconTable
	{
		[Token(Token = "0x400D456")]
		[FieldOffset(Offset = "0x10")]
		public Content.Type type;

		[Token(Token = "0x400D457")]
		[FieldOffset(Offset = "0x18")]
		public Sprite icon;

		[Token(Token = "0x6008911")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TypeIconTable()
		{
		}
	}

	[Token(Token = "0x400D44D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AttributeIconTable[] attrIcons;

	[Token(Token = "0x400D44E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SpellTrapIconTable[] spelltrapIcons;

	[Token(Token = "0x400D44F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TypeIconTable[] typeIcons;

	[Token(Token = "0x400D450")]
	[FieldOffset(Offset = "0x0")]
	private static CardIconSprites _instance;

	[Token(Token = "0x400D451")]
	private const string path = "Card/ScriptableObjects/CardIconSprites";

	[Token(Token = "0x17001500")]
	public static CardIconSprites instance
	{
		[Token(Token = "0x600890C")]
		[Address(RVA = "0xD462B0", Offset = "0xD454B0", VA = "0x180D462B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008909")]
	[Address(RVA = "0xD460C0", Offset = "0xD452C0", VA = "0x180D460C0")]
	public Sprite GetAttributeIcon(Content.Attribute attr)
	{
		return null;
	}

	[Token(Token = "0x600890A")]
	[Address(RVA = "0xD46120", Offset = "0xD45320", VA = "0x180D46120")]
	public Sprite GetSpellTrapIcon(Content.Icon type)
	{
		return null;
	}

	[Token(Token = "0x600890B")]
	[Address(RVA = "0xD46180", Offset = "0xD45380", VA = "0x180D46180")]
	public Sprite GetTypeIcon(Content.Type type)
	{
		return null;
	}

	[Token(Token = "0x600890D")]
	[Address(RVA = "0xD461E0", Offset = "0xD453E0", VA = "0x180D461E0")]
	public static void Load(Action onLoaded)
	{
	}

	[Token(Token = "0x600890E")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public CardIconSprites()
	{
	}
}
