using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x200018D")]
public class SafeAreaManager : MonoBehaviour
{
	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x0")]
	private static List<SafeAreaScreen> screenList;

	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x20")]
	private Rect currentSafeArea;

	[Token(Token = "0x17000103")]
	public static bool reqUpdate
	{
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xB03380", Offset = "0xB02580", VA = "0x180B03380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xB033D0", Offset = "0xB025D0", VA = "0x180B033D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60009D4")]
	[Address(RVA = "0xB02F10", Offset = "0xB02110", VA = "0x180B02F10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009D5")]
	[Address(RVA = "0xB02FC0", Offset = "0xB021C0", VA = "0x180B02FC0")]
	private void Update()
	{
	}

	[Token(Token = "0x60009D6")]
	[Address(RVA = "0xB02E40", Offset = "0xB02040", VA = "0x180B02E40")]
	public static void Add(SafeAreaScreen screen)
	{
	}

	[Token(Token = "0x60009D7")]
	[Address(RVA = "0xB02F40", Offset = "0xB02140", VA = "0x180B02F40")]
	public static void Remove(SafeAreaScreen screen)
	{
	}

	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SafeAreaManager()
	{
	}
}
