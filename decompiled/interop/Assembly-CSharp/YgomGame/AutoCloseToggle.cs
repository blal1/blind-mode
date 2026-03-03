using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame;

[Token(Token = "0x20006CE")]
public class AutoCloseToggle : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x4002226")]
	private const string PREFAB_PATH = "Prefabs/Duel/UI/AutoCloseToggle";

	[Token(Token = "0x4002227")]
	[FieldOffset(Offset = "0x20")]
	private DuelClient m_Host;

	[Token(Token = "0x4002228")]
	[FieldOffset(Offset = "0x28")]
	protected ElementObjectManager m_Eom;

	[Token(Token = "0x4002229")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_AutoClose;

	[Token(Token = "0x400222A")]
	[FieldOffset(Offset = "0x38")]
	protected ElementObjectManager m_AutoCloseButtonEom;

	[Token(Token = "0x400222B")]
	[FieldOffset(Offset = "0x40")]
	protected GameObject m_AutoCloseButtonRoot;

	[Token(Token = "0x400222C")]
	[FieldOffset(Offset = "0x48")]
	protected SelectionButton m_AutoCloseButton;

	[Token(Token = "0x400222D")]
	[FieldOffset(Offset = "0x50")]
	protected GameObject m_AutoCloseOn;

	[Token(Token = "0x400222E")]
	[FieldOffset(Offset = "0x58")]
	protected GameObject m_AutoCloseOff;

	[Token(Token = "0x400222F")]
	[FieldOffset(Offset = "0x60")]
	protected GameObject m_TimerRoot;

	[Token(Token = "0x4002230")]
	[FieldOffset(Offset = "0x68")]
	protected ExtendedTextMeshProUGUI m_TimerText;

	[Token(Token = "0x17000595")]
	public bool autoCloseEnabled
	{
		[Token(Token = "0x6002D46")]
		[Address(RVA = "0x6FF730", Offset = "0x6FE930", VA = "0x1806FF730")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000596")]
	public string poolKey
	{
		[Token(Token = "0x6002D47")]
		[Address(RVA = "0x6FF750", Offset = "0x6FE950", VA = "0x1806FF750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000597")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6002D49")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x6FF3D0", Offset = "0x6FE5D0", VA = "0x1806FF3D0", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0x6FEDE0", Offset = "0x6FDFE0", VA = "0x1806FEDE0")]
	public static void Create(DuelClient host, Transform parent, UnityAction<AutoCloseToggle> onFinish)
	{
	}

	[Token(Token = "0x6002D4B")]
	[Address(RVA = "0x6FEF90", Offset = "0x6FE190", VA = "0x1806FEF90")]
	protected void InitializeOnCreated()
	{
	}

	[Token(Token = "0x6002D4C")]
	[Address(RVA = "0x6FF260", Offset = "0x6FE460", VA = "0x1806FF260")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x6002D4D")]
	[Address(RVA = "0x6FF590", Offset = "0x6FE790", VA = "0x1806FF590")]
	public void SetAutoClose(bool autoClose)
	{
	}

	[Token(Token = "0x6002D4E")]
	[Address(RVA = "0x6FF3E0", Offset = "0x6FE5E0", VA = "0x1806FF3E0")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x6002D4F")]
	[Address(RVA = "0x6FED00", Offset = "0x6FDF00", VA = "0x1806FED00")]
	private void CheckIsInputing()
	{
	}

	[Token(Token = "0x6002D50")]
	[Address(RVA = "0x6FF6B0", Offset = "0x6FE8B0", VA = "0x1806FF6B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002D51")]
	[Address(RVA = "0x6FF640", Offset = "0x6FE840", VA = "0x1806FF640")]
	public void SetSelectorPriority(int priority)
	{
	}

	[Token(Token = "0x6002D52")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public AutoCloseToggle()
	{
	}
}
