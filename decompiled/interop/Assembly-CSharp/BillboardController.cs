using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A9")]
public class BillboardController : MonoBehaviour
{
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x20")]
	public string findTag;

	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x28")]
	private Transform target;

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x6715A0", Offset = "0x6707A0", VA = "0x1806715A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x671730", Offset = "0x670930", VA = "0x180671730")]
	private void Update()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x6717E0", Offset = "0x6709E0", VA = "0x1806717E0")]
	public BillboardController()
	{
	}
}
