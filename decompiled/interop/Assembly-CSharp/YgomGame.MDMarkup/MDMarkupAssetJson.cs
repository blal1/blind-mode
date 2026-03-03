using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C70")]
[CreateAssetMenu(menuName = "Scriptable Object/MMA/MMA生成")]
public class MDMarkupAssetJson : ScriptableObject
{
	[Token(Token = "0x4009B26")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string json;

	[Token(Token = "0x6004B69")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public MDMarkupAssetJson()
	{
	}
}
