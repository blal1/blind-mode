using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.CardPack.Open.Widget;

[Token(Token = "0x2001553")]
[ExecuteInEditMode]
public class LocalPositionLayoutGroup : MonoBehaviour
{
	[Token(Token = "0x400CC58")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_XSpace;

	[Token(Token = "0x400CC59")]
	[FieldOffset(Offset = "0x24")]
	private float m_LastXSpace;

	[Token(Token = "0x17001419")]
	public float xSpace
	{
		[Token(Token = "0x60083CE")]
		[Address(RVA = "0x64BF80", Offset = "0x64B180", VA = "0x18064BF80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60083CF")]
		[Address(RVA = "0xCBF460", Offset = "0xCBE660", VA = "0x180CBF460")]
		set
		{
		}
	}

	[Token(Token = "0x60083D0")]
	[Address(RVA = "0xCBF430", Offset = "0xCBE630", VA = "0x180CBF430")]
	private void Update()
	{
	}

	[Token(Token = "0x60083D1")]
	[Address(RVA = "0xCBF210", Offset = "0xCBE410", VA = "0x180CBF210")]
	[ContextMenu("UpdateLayout")]
	public void UpdateLayout()
	{
	}

	[Token(Token = "0x60083D2")]
	[Address(RVA = "0xCBF450", Offset = "0xCBE650", VA = "0x180CBF450")]
	public LocalPositionLayoutGroup()
	{
	}
}
