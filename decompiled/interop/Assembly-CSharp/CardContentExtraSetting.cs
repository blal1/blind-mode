using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000030")]
[CreateAssetMenu(menuName = "Scriptable Object/CardContentExtraSetting")]
public class CardContentExtraSetting : ScriptableObject
{
	[Token(Token = "0x40000C1")]
	private const string PATH = "Card/ScriptableObjects/CardContentExtraSetting";

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x0")]
	private static CardContentExtraSetting m_Instance;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int[] noStarCardIds;

	[Token(Token = "0x17000011")]
	public static CardContentExtraSetting Instance
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x3D4F40", Offset = "0x3D4140", VA = "0x1803D4F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x3D4DB0", Offset = "0x3D3FB0", VA = "0x1803D4DB0")]
	public static void CreateInstance()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x3D4ED0", Offset = "0x3D40D0", VA = "0x1803D4ED0")]
	public bool IsNoStarCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public CardContentExtraSetting()
	{
	}
}
