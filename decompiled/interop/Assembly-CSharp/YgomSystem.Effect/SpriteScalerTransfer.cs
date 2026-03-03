using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Effect;

[Token(Token = "0x2000328")]
public class SpriteScalerTransfer : MonoBehaviour
{
	[Token(Token = "0x400114A")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> transfetTragets;

	[Token(Token = "0x400114B")]
	[FieldOffset(Offset = "0x28")]
	private SpriteScaler m_Scaler;

	[Token(Token = "0x170001FE")]
	public SpriteScaler scaler
	{
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x52B340", Offset = "0x52A540", VA = "0x18052B340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x52B230", Offset = "0x52A430", VA = "0x18052B230")]
	public static SpriteScalerTransfer Assign(SpriteScaler scaler)
	{
		return null;
	}

	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x52B2B0", Offset = "0x52A4B0", VA = "0x18052B2B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x52B050", Offset = "0x52A250", VA = "0x18052B050")]
	public void Apply(bool reflesh = false)
	{
	}

	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x52B2C0", Offset = "0x52A4C0", VA = "0x18052B2C0")]
	public SpriteScalerTransfer()
	{
	}
}
