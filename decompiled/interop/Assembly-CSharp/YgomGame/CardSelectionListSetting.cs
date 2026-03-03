using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame;

[Token(Token = "0x20006CD")]
[CreateAssetMenu(menuName = "Scriptable Object/CardSelectionListSetting")]
public class CardSelectionListSetting : ScriptableObject
{
	[Token(Token = "0x4002223")]
	[FieldOffset(Offset = "0x0")]
	private static CardSelectionListSetting m_Instance;

	[Token(Token = "0x4002224")]
	private const string PATH = "Duel/ScriptableObject/CardSelectionListSetting";

	[Token(Token = "0x4002225")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int[] m_SkipSortEffectIdList;

	[Token(Token = "0x17000594")]
	protected static CardSelectionListSetting Instance
	{
		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x700200", Offset = "0x6FF400", VA = "0x180700200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x700140", Offset = "0x6FF340", VA = "0x180700140")]
	public static bool CheckIfSkipByCardid(int cardid)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public CardSelectionListSetting()
	{
	}
}
