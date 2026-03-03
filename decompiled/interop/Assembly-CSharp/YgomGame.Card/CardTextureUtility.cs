using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomGame.Card;

[Token(Token = "0x200162D")]
public static class CardTextureUtility
{
	[Token(Token = "0x400D518")]
	public const int INVALIDCARDSYSTEMID = -1;

	[Token(Token = "0x400D519")]
	public const int DUMMYCARDID = 0;

	[Token(Token = "0x400D51A")]
	public const int CARDRENDERQUEUE_HIGH = 3000;

	[Token(Token = "0x400D51B")]
	public const int CARDRENDERQUEUE_LOW = 1999;

	[Token(Token = "0x400D51C")]
	public const string CARDSHADERCONTAINERPATH = "Shaders/CardShader/CardShaderContainer";

	[Token(Token = "0x400D51D")]
	private const float FADETIME = 0.1f;

	[Token(Token = "0x400D51E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CardIllustManager cardIllustManager;

	[Token(Token = "0x400D51F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static CardMaterialManager cardMaterialManager;

	[Token(Token = "0x400D520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static CardPictureManager cardPictureManager;

	[Token(Token = "0x400D521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static CardMaskManager cardMaskManager;

	[Token(Token = "0x400D522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static AssetContainer cardShaderContainer;

	[Token(Token = "0x400D523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Dictionary<int, Texture2D> SPIllustTable;

	[Token(Token = "0x400D524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static bool initialized;

	[Token(Token = "0x17001521")]
	public static int cardSystemId
	{
		[Token(Token = "0x60089F9")]
		[Address(RVA = "0xD56790", Offset = "0xD55990", VA = "0x180D56790")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60089F8")]
		[Address(RVA = "0xD568E0", Offset = "0xD55AE0", VA = "0x180D568E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x140000BA")]
	public static event UnityAction onCardSystemResetBefore
	{
		[Token(Token = "0x60089FA")]
		[Address(RVA = "0xD56690", Offset = "0xD55890", VA = "0x180D56690")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60089FB")]
		[Address(RVA = "0xD567E0", Offset = "0xD559E0", VA = "0x180D567E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60089FC")]
	[Address(RVA = "0xD54850", Offset = "0xD53A50", VA = "0x180D54850")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60089FD")]
	[Address(RVA = "0xD562A0", Offset = "0xD554A0", VA = "0x180D562A0")]
	public static void SetCardQuality(CardQuality quality)
	{
	}

	[Token(Token = "0x60089FE")]
	[Address(RVA = "0xD54760", Offset = "0xD53960", VA = "0x180D54760")]
	public static void IgnoreCardIllust(bool enable)
	{
	}

	[Token(Token = "0x60089FF")]
	[Address(RVA = "0xD55A00", Offset = "0xD54C00", VA = "0x180D55A00")]
	public static void SetCardIllustAsync(this GameObject gob, List<int> cardidList, UnityAction<int, Texture2D> onFinish, [Optional] UnityAction<Dictionary<int, Texture2D>> onFinishAll)
	{
	}

	[Token(Token = "0x6008A00")]
	[Address(RVA = "0xD556B0", Offset = "0xD548B0", VA = "0x180D556B0")]
	public static void SetCardIllustAsync(this RawImage rawImage, int cardid, [Optional] UnityAction onFinish, bool isAutoRelease = false, bool immediateOnReuse = false)
	{
	}

	[Token(Token = "0x6008A01")]
	[Address(RVA = "0xD53AF0", Offset = "0xD52CF0", VA = "0x180D53AF0")]
	public static void GetCardIllustAsync(this GameObject gob, int cardid, UnityAction<Texture2D> onFinish, bool immediateOnReuse = false)
	{
	}

	[Token(Token = "0x6008A02")]
	[Address(RVA = "0xD55B60", Offset = "0xD54D60", VA = "0x180D55B60")]
	public static void SetCardMaterialAsync(this RawImage rawImage, int cardid, int finishid = 1, [Optional] UnityAction onFinish, bool isResetParent = true)
	{
	}

	[Token(Token = "0x6008A03")]
	[Address(RVA = "0xD55F90", Offset = "0xD55190", VA = "0x180D55F90")]
	public static void SetCardPictureAsync(this GameObject gob, List<int> cardidList, [Optional] List<UnityAction<Texture2D>> onFinishList, [Optional] UnityAction onFinishAll)
	{
	}

	[Token(Token = "0x6008A04")]
	[Address(RVA = "0xD56180", Offset = "0xD55380", VA = "0x180D56180")]
	public static void SetCardPictureAsync(this GameObject gob, int cardid, [Optional] UnityAction<Texture2D> onFinish)
	{
	}

	[Token(Token = "0x6008A05")]
	[Address(RVA = "0xD55D80", Offset = "0xD54F80", VA = "0x180D55D80")]
	public static void SetCardMaterialAsync(this MeshRenderer meshRenderer, int matid, int cardid, int finishid = 1, [Optional] UnityAction onFinish, bool isResetParent = true, bool lowRenderQueue = false)
	{
	}

	[Token(Token = "0x6008A06")]
	[Address(RVA = "0xD56390", Offset = "0xD55590", VA = "0x180D56390")]
	public static void SetInsight(this MeshRenderer meshRenderer, int matId, bool enable)
	{
	}

	[Token(Token = "0x6008A07")]
	[Address(RVA = "0xD53A40", Offset = "0xD52C40", VA = "0x180D53A40")]
	public static void ClearAllCache()
	{
	}

	[Token(Token = "0x6008A08")]
	[Address(RVA = "0xD553D0", Offset = "0xD545D0", VA = "0x180D553D0")]
	public static void ResetAll()
	{
	}

	[Token(Token = "0x6008A09")]
	[Address(RVA = "0xD552C0", Offset = "0xD544C0", VA = "0x180D552C0")]
	public static void RecreateCardCreaters()
	{
	}

	[Token(Token = "0x6008A0A")]
	[Address(RVA = "0xD55520", Offset = "0xD54720", VA = "0x180D55520")]
	public static void SetCacheActive(bool enable)
	{
	}

	[Token(Token = "0x6008A0B")]
	[Address(RVA = "0xD555D0", Offset = "0xD547D0", VA = "0x180D555D0")]
	public static void SetCardIllustAspectRatio(this AspectRatioFitter aspectRatioFitter, int cardid)
	{
	}

	[Token(Token = "0x6008A0C")]
	[Address(RVA = "0xD551F0", Offset = "0xD543F0", VA = "0x180D551F0")]
	public static bool PreLoadCardPictureAsync(int cardid, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A0D")]
	[Address(RVA = "0xD55360", Offset = "0xD54560", VA = "0x180D55360")]
	public static void ReleaseCardMaterial(Material mat)
	{
	}

	[Token(Token = "0x6008A0E")]
	[Address(RVA = "0xD55150", Offset = "0xD54350", VA = "0x180D55150")]
	public static bool IsCardCreating()
	{
		return default(bool);
	}

	[Token(Token = "0x6008A0F")]
	[Address(RVA = "0xD53870", Offset = "0xD52A70", VA = "0x180D53870")]
	private static void AddTweenShaderFloat(GameObject gob)
	{
	}

	[Token(Token = "0x6008A10")]
	[Address(RVA = "0xD53CA0", Offset = "0xD52EA0", VA = "0x180D53CA0")]
	public static string GetTextureInfo()
	{
		return null;
	}

	[Token(Token = "0x6008A11")]
	[Address(RVA = "0xD564A0", Offset = "0xD556A0", VA = "0x180D564A0")]
	public static void SetMaterialShader(Material material, bool isForUi, AssetContainer shaderContainer)
	{
	}
}
