using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x200191E")]
public class MessageDialog : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x400EAB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400EAB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ElementObjectManager ui;

	[Token(Token = "0x400EABA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ExtendedTextMeshProUGUI msgText;

	[Token(Token = "0x400EABB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Image icon;

	[Token(Token = "0x400EABD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string key;

	[Token(Token = "0x400EABE")]
	private const string prefabPathNoResponse = "Prefabs/Duel/MessageDialogNoResponse";

	[Token(Token = "0x400EABF")]
	private const string prefabPathNoOperation = "Prefabs/Duel/MessageDialogNoOperation";

	[Token(Token = "0x400EAC0")]
	private const string keyNoResponse = "MessageDialogNoResponse";

	[Token(Token = "0x400EAC1")]
	private const string keyNoOperation = "MessageDialogNoOperation";

	[Token(Token = "0x170018C2")]
	public bool isShowing
	{
		[Token(Token = "0x600A1DF")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A1E0")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170018C3")]
	public string poolKey
	{
		[Token(Token = "0x600A1E1")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C4")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600A1E2")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A1E3")]
	[Address(RVA = "0xEF5780", Offset = "0xEF4980", VA = "0x180EF5780")]
	public static void CreateNoResponse(Transform parent, Action<MessageDialog> onLoaded)
	{
	}

	[Token(Token = "0x600A1E4")]
	[Address(RVA = "0xEF5710", Offset = "0xEF4910", VA = "0x180EF5710")]
	public static void CreateNoOperation(Transform parent, Action<MessageDialog> onLoaded)
	{
	}

	[Token(Token = "0x600A1E5")]
	[Address(RVA = "0xEF57F0", Offset = "0xEF49F0", VA = "0x180EF57F0")]
	public static void Create(string prefabPath, Transform parent, Action<MessageDialog> onLoaded, string key)
	{
	}

	[Token(Token = "0x600A1E6")]
	[Address(RVA = "0xEF59F0", Offset = "0xEF4BF0", VA = "0x180EF59F0")]
	private void Initialize(bool createUI = true)
	{
	}

	[Token(Token = "0x600A1E7")]
	[Address(RVA = "0xEF5B80", Offset = "0xEF4D80", VA = "0x180EF5B80")]
	public void Open()
	{
	}

	[Token(Token = "0x600A1E8")]
	[Address(RVA = "0xEF56D0", Offset = "0xEF48D0", VA = "0x180EF56D0")]
	public void Close(bool force = false)
	{
	}

	[Token(Token = "0x600A1E9")]
	[Address(RVA = "0xCFA500", Offset = "0xCF9700", VA = "0x180CFA500")]
	public void SetMessage(string msg)
	{
	}

	[Token(Token = "0x600A1EA")]
	[Address(RVA = "0xEF5BE0", Offset = "0xEF4DE0", VA = "0x180EF5BE0")]
	public void SetIcon(bool disp, [Optional] Sprite icon)
	{
	}

	[Token(Token = "0x600A1EB")]
	[Address(RVA = "0xEF5B40", Offset = "0xEF4D40", VA = "0x180EF5B40", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600A1EC")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public MessageDialog()
	{
	}
}
