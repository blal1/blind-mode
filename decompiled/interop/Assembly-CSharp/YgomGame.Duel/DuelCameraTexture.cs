using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001B83")]
public class DuelCameraTexture : MonoBehaviour
{
	[Token(Token = "0x400F9AF")]
	private const string BLURMATERIALPATH = "Duel/Models/Materials/UIBlur";

	[Token(Token = "0x400F9B0")]
	private const string BLURMATERIALPATH2 = "Duel/Timeline/Materials/UIBlur00";

	[Token(Token = "0x400F9B1")]
	[FieldOffset(Offset = "0x0")]
	public static RenderTexture renderTexture;

	[Token(Token = "0x400F9B2")]
	[FieldOffset(Offset = "0x8")]
	private static int m_RefCounrt;

	[Token(Token = "0x600B300")]
	[Address(RVA = "0x4A1E40", Offset = "0x4A1040", VA = "0x1804A1E40")]
	public static void Initialize(Camera camera)
	{
	}

	[Token(Token = "0x600B301")]
	[Address(RVA = "0x4A2140", Offset = "0x4A1340", VA = "0x1804A2140")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600B302")]
	[Address(RVA = "0x4A2100", Offset = "0x4A1300", VA = "0x1804A2100")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600B303")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelCameraTexture()
	{
	}
}
