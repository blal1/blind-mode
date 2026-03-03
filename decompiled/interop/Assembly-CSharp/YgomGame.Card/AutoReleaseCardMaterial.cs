using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card;

[Token(Token = "0x200163B")]
public class AutoReleaseCardMaterial : MonoBehaviour
{
	[Token(Token = "0x200163C")]
	public enum InstanceType
	{
		[Token(Token = "0x400D573")]
		None,
		[Token(Token = "0x400D574")]
		RawImage,
		[Token(Token = "0x400D575")]
		MeshRenderer
	}

	[Token(Token = "0x400D564")]
	private const string PROTECTORMATTAG = "PMat";

	[Token(Token = "0x400D565")]
	[FieldOffset(Offset = "0x20")]
	public Func<bool> IdleWhenInvisible;

	[Token(Token = "0x400D566")]
	[FieldOffset(Offset = "0x28")]
	public bool autoReleaseWhenDisable;

	[Token(Token = "0x400D568")]
	[FieldOffset(Offset = "0x30")]
	private CardMaterialManager cardMaterialManager;

	[Token(Token = "0x400D569")]
	[FieldOffset(Offset = "0x38")]
	private int m_Cardid;

	[Token(Token = "0x400D56A")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Finishid;

	[Token(Token = "0x400D56B")]
	[FieldOffset(Offset = "0x40")]
	private int refCardSystemId;

	[Token(Token = "0x400D56C")]
	[FieldOffset(Offset = "0x44")]
	private bool m_ResetMatWhenVisible;

	[Token(Token = "0x400D56D")]
	[FieldOffset(Offset = "0x45")]
	private bool m_ResetMatWhenEnable;

	[Token(Token = "0x400D56E")]
	[FieldOffset(Offset = "0x46")]
	private bool m_LowRenderQueue;

	[Token(Token = "0x400D56F")]
	[FieldOffset(Offset = "0x48")]
	private InstanceType m_Type;

	[Token(Token = "0x400D570")]
	[FieldOffset(Offset = "0x4C")]
	private float m_FakeBlendCache;

	[Token(Token = "0x400D571")]
	[FieldOffset(Offset = "0x50")]
	private UnityAction m_OnFinish;

	[Token(Token = "0x17001522")]
	public bool Initialized
	{
		[Token(Token = "0x6008A48")]
		[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008A49")]
		[Address(RVA = "0x631700", Offset = "0x630900", VA = "0x180631700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001523")]
	private bool m_IsVisible
	{
		[Token(Token = "0x6008A4A")]
		[Address(RVA = "0xD449F0", Offset = "0xD43BF0", VA = "0x180D449F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001524")]
	private Material m_Material
	{
		[Token(Token = "0x6008A4B")]
		[Address(RVA = "0xD44A50", Offset = "0xD43C50", VA = "0x180D44A50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A4C")]
		[Address(RVA = "0xD44B10", Offset = "0xD43D10", VA = "0x180D44B10")]
		set
		{
		}
	}

	[Token(Token = "0x6008A4D")]
	[Address(RVA = "0xD43FE0", Offset = "0xD431E0", VA = "0x180D43FE0")]
	public void Initialize(CardMaterialManager cardMaterialManager, bool isResetParent)
	{
	}

	[Token(Token = "0x6008A4E")]
	[Address(RVA = "0xD44720", Offset = "0xD43920", VA = "0x180D44720")]
	public void UpdateMateriaInfo(int cardid, int finishid, InstanceType type, UnityAction onFinish, bool lowRenderQueue)
	{
	}

	[Token(Token = "0x6008A4F")]
	[Address(RVA = "0xD44490", Offset = "0xD43690", VA = "0x180D44490")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6008A50")]
	[Address(RVA = "0xD443B0", Offset = "0xD435B0", VA = "0x180D443B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6008A51")]
	[Address(RVA = "0xD442D0", Offset = "0xD434D0", VA = "0x180D442D0")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x6008A52")]
	[Address(RVA = "0xD441E0", Offset = "0xD433E0", VA = "0x180D441E0")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6008A53")]
	[Address(RVA = "0xD44620", Offset = "0xD43820", VA = "0x180D44620")]
	private void SetCardPicture()
	{
	}

	[Token(Token = "0x6008A54")]
	[Address(RVA = "0xD43F60", Offset = "0xD43160", VA = "0x180D43F60")]
	private bool CheckIsProtectorMaterial()
	{
		return default(bool);
	}

	[Token(Token = "0x6008A55")]
	[Address(RVA = "0xD44560", Offset = "0xD43760", VA = "0x180D44560")]
	private void ReleaseCardMaterial()
	{
	}

	[Token(Token = "0x6008A56")]
	[Address(RVA = "0xD44390", Offset = "0xD43590", VA = "0x180D44390")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008A57")]
	[Address(RVA = "0xD448C0", Offset = "0xD43AC0", VA = "0x180D448C0")]
	public AutoReleaseCardMaterial()
	{
	}
}
