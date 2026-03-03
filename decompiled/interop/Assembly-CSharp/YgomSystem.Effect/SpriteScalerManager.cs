using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Effect;

[Token(Token = "0x2000327")]
public class SpriteScalerManager : MonoBehaviour
{
	[Token(Token = "0x4001147")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 currentScreenSize;

	[Token(Token = "0x4001148")]
	[FieldOffset(Offset = "0x0")]
	private static List<SpriteScaler> scalerList;

	[Token(Token = "0x170001FD")]
	public static bool reqUpdate
	{
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x52AFA0", Offset = "0x52A1A0", VA = "0x18052AFA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x52AFF0", Offset = "0x52A1F0", VA = "0x18052AFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x52ABD0", Offset = "0x529DD0", VA = "0x18052ABD0")]
	private void Update()
	{
	}

	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x52AA80", Offset = "0x529C80", VA = "0x18052AA80")]
	public static void Add(SpriteScaler screen)
	{
	}

	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x52AB50", Offset = "0x529D50", VA = "0x18052AB50")]
	public static void Remove(SpriteScaler screen)
	{
	}

	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x52AF40", Offset = "0x52A140", VA = "0x18052AF40")]
	public SpriteScalerManager()
	{
	}
}
