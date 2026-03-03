using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.Utility;

namespace YgomSystem.UI;

[Token(Token = "0x200043E")]
public class UISystem : MonoBehaviour
{
	[Token(Token = "0x40014C2")]
	[FieldOffset(Offset = "0x0")]
	private static UISystem s_Instance;

	[Token(Token = "0x40014C3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InputBlocker m_InputBlocker;

	[Token(Token = "0x40014C4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UINetworkHandler m_UINetworkHandler;

	[Token(Token = "0x40014C5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SystemProgress m_SystemProgress;

	[Token(Token = "0x40014C6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SystemDialog m_SystemDialog;

	[Token(Token = "0x40014C7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private HoldIndicator m_HoldIndicator;

	[Token(Token = "0x40014C8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AssetReferer m_AssetReferer;

	[Token(Token = "0x40014C9")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ResourceBindingPathSetting m_ResourceBindingPathSetting;

	[Token(Token = "0x40014CA")]
	[FieldOffset(Offset = "0x58")]
	private ResourceBindingPathSetting m_CurrentResourceBindingPathSetting;

	[Token(Token = "0x40014CB")]
	[FieldOffset(Offset = "0x60")]
	private StringBuilder m_StringBuilder;

	[Token(Token = "0x1700027D")]
	public static ResourceBindingPathSetting resourceBindingPathSetting
	{
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x5F7200", Offset = "0x5F6400", VA = "0x1805F7200")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x5F7470", Offset = "0x5F6670", VA = "0x1805F7470")]
		set
		{
		}
	}

	[Token(Token = "0x1700027E")]
	public static bool isReady
	{
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x5F7190", Offset = "0x5F6390", VA = "0x1805F7190")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027F")]
	public static InputBlocker inputBlocker
	{
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x5F70C0", Offset = "0x5F62C0", VA = "0x1805F70C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000280")]
	public static UINetworkHandler uiNetworkHandler
	{
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x5F7420", Offset = "0x5F6620", VA = "0x1805F7420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000281")]
	public static SystemProgress systemProgress
	{
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x5F73D0", Offset = "0x5F65D0", VA = "0x1805F73D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000282")]
	public static SystemDialog systemDialog
	{
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x5F7380", Offset = "0x5F6580", VA = "0x1805F7380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000283")]
	public static HoldIndicator holdIndicator
	{
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x5F7070", Offset = "0x5F6270", VA = "0x1805F7070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000284")]
	public static Sprite invisibleSprite
	{
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x5F7110", Offset = "0x5F6310", VA = "0x1805F7110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000285")]
	public static StringBuilder stringBuilder
	{
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x5F72D0", Offset = "0x5F64D0", VA = "0x1805F72D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x5F6F40", Offset = "0x5F6140", VA = "0x1805F6F40")]
	public static void OnDownloadedAssets()
	{
	}

	[Token(Token = "0x6001B3C")]
	[Address(RVA = "0x5F6DA0", Offset = "0x5F5FA0", VA = "0x1805F6DA0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6001B3D")]
	[Address(RVA = "0x5F6CD0", Offset = "0x5F5ED0", VA = "0x1805F6CD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0x5F6E90", Offset = "0x5F6090", VA = "0x1805F6E90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001B3F")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public UISystem()
	{
	}
}
