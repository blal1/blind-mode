using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Certification;

[Token(Token = "0x20014C5")]
public class CertificationMatePostEffect : MonoBehaviour
{
	[Token(Token = "0x400C843")]
	[FieldOffset(Offset = "0x0")]
	private static CertificationMatePostEffect k_Instance;

	[Token(Token = "0x400C844")]
	[FieldOffset(Offset = "0x20")]
	private List<ViewController> m_Owners;

	[Token(Token = "0x400C845")]
	[FieldOffset(Offset = "0x28")]
	private List<ViewController> m_RemoveSearchList;

	[Token(Token = "0x60080C3")]
	[Address(RVA = "0xC8DE00", Offset = "0xC8D000", VA = "0x180C8DE00")]
	public static void Activate(ViewController owner)
	{
	}

	[Token(Token = "0x60080C4")]
	[Address(RVA = "0xC8E0E0", Offset = "0xC8D2E0", VA = "0x180C8E0E0")]
	public static void Deactivate(ViewController owner)
	{
	}

	[Token(Token = "0x60080C5")]
	[Address(RVA = "0xC8E580", Offset = "0xC8D780", VA = "0x180C8E580")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60080C6")]
	[Address(RVA = "0xC8E620", Offset = "0xC8D820", VA = "0x180C8E620")]
	private static void SetMainCameraPostEffect(bool isOn)
	{
	}

	[Token(Token = "0x60080C7")]
	[Address(RVA = "0xC8E680", Offset = "0xC8D880", VA = "0x180C8E680")]
	public CertificationMatePostEffect()
	{
	}
}
