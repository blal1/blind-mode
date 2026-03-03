using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomGame.Card;

[Token(Token = "0x2001631")]
public static class ProtectorUtility
{
	[Token(Token = "0x400D530")]
	public const int DEFAULTPROTECTORID = 1;

	[Token(Token = "0x400D531")]
	private const string LABEL_SD_SHOWCARD = "SHOWCARD_ON";

	[Token(Token = "0x400D532")]
	private const string LABEL_SD_CARDPICTURE = "_CardPicture";

	[Token(Token = "0x400D533")]
	private const string PATH_PROTECTORSHADERCONTAINER = "Protector/Shaders/ProtectorShaderContainer";

	[Token(Token = "0x400D534")]
	private const string LABEL_SD_ZWRITE = "_ZWrite";

	[Token(Token = "0x400D535")]
	public const int RENDERQUEUE_UI = -1;

	[Token(Token = "0x400D536")]
	public const int RENDERQUEUE_HIGH = 3000;

	[Token(Token = "0x400D537")]
	public const int RENDERQUEUE_LOW = 1998;

	[Token(Token = "0x400D538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ProtectorManager protectorManager_LowRenderQueue;

	[Token(Token = "0x400D539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ProtectorManager protectorManager_HighRenderQueue;

	[Token(Token = "0x400D53A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static AssetContainer protectorShaderContainer;

	[Token(Token = "0x6008A1F")]
	[Address(RVA = "0xD581D0", Offset = "0xD573D0", VA = "0x180D581D0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6008A20")]
	[Address(RVA = "0xD58360", Offset = "0xD57560", VA = "0x180D58360")]
	public static void ReloadShaderContainer()
	{
	}

	[Token(Token = "0x6008A21")]
	[Address(RVA = "0xD585B0", Offset = "0xD577B0", VA = "0x180D585B0")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6008A22")]
	[Address(RVA = "0xD588A0", Offset = "0xD57AA0", VA = "0x180D588A0")]
	public static void SetProtectorAsync(this RawImage rawImage, int protectorId, [Optional] UnityAction onFinish)
	{
	}

	[Token(Token = "0x6008A23")]
	[Address(RVA = "0xD58A40", Offset = "0xD57C40", VA = "0x180D58A40")]
	public static void SetProtectorAsync(this Image image, int protectorId, [Optional] UnityAction onFinish)
	{
	}

	[Token(Token = "0x6008A24")]
	[Address(RVA = "0xD586D0", Offset = "0xD578D0", VA = "0x180D586D0")]
	public static void SetProtectorAsync(this MeshRenderer meshRenderer, int matId, int protectorId, [Optional] UnityAction onFinish, bool isLowRenderQueue = false)
	{
	}

	[Token(Token = "0x6008A25")]
	[Address(RVA = "0xD57F50", Offset = "0xD57150", VA = "0x180D57F50")]
	public static void GetProtectorAsync(int protectorId, [Optional] UnityAction<Material, int> onFinish)
	{
	}

	[Token(Token = "0x6008A26")]
	[Address(RVA = "0xD57E60", Offset = "0xD57060", VA = "0x180D57E60")]
	public static void GetProtectorAsyncUI(int protectorId, [Optional] UnityAction<Material, int> onFinish)
	{
	}

	[Token(Token = "0x6008A27")]
	[Address(RVA = "0xD58F60", Offset = "0xD58160", VA = "0x180D58F60")]
	private static void SetProtectorForRawImageImpl(RawImage rawImage, Material mat, [Optional] UnityAction onFinish)
	{
	}

	[Token(Token = "0x6008A28")]
	[Address(RVA = "0xD58BE0", Offset = "0xD57DE0", VA = "0x180D58BE0")]
	private static void SetProtectorForImageImpl(Image image, Material mat, [Optional] UnityAction onFinish)
	{
	}

	[Token(Token = "0x6008A29")]
	[Address(RVA = "0xD58D30", Offset = "0xD57F30", VA = "0x180D58D30")]
	private static void SetProtectorForMeshRendererImpl(MeshRenderer meshRenderer, int matId, Material mat, [Optional] UnityAction onFinish)
	{
	}

	[Token(Token = "0x6008A2A")]
	[Address(RVA = "0xD57D90", Offset = "0xD56F90", VA = "0x180D57D90")]
	public static string GetName(int sid)
	{
		return null;
	}

	[Token(Token = "0x6008A2B")]
	[Address(RVA = "0xD58040", Offset = "0xD57240", VA = "0x180D58040")]
	public static string GetShortName(int sid)
	{
		return null;
	}
}
