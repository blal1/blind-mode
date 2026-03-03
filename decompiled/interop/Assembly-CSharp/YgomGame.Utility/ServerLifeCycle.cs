using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Token(Token = "0x2000914")]
public class ServerLifeCycle : MonoBehaviour
{
	[Token(Token = "0x4008991")]
	[FieldOffset(Offset = "0x0")]
	private static ServerLifeCycle instance;

	[Token(Token = "0x6003683")]
	[Address(RVA = "0x7C8160", Offset = "0x7C7360", VA = "0x1807C8160")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003684")]
	[Address(RVA = "0x7C8260", Offset = "0x7C7460", VA = "0x1807C8260")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003685")]
	[Address(RVA = "0x7C82B0", Offset = "0x7C74B0", VA = "0x1807C82B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003686")]
	[Address(RVA = "0x7C8200", Offset = "0x7C7400", VA = "0x1807C8200")]
	private void OnCallMaintenance(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6003687")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ServerLifeCycle()
	{
	}
}
