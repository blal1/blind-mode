using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018C3")]
public class DuelOkDialog : DuelDialogBase, IGameObjectPool
{
	[Token(Token = "0x400E861")]
	[FieldOffset(Offset = "0xB0")]
	private Action<bool> resultCallback;

	[Token(Token = "0x400E862")]
	[FieldOffset(Offset = "0xB8")]
	private ExtendedTextMeshProUGUI textMessage;

	[Token(Token = "0x400E863")]
	[FieldOffset(Offset = "0xC0")]
	private ExtendedTextMeshProUGUI textButton;

	[Token(Token = "0x400E864")]
	[FieldOffset(Offset = "0xC8")]
	private ContentSizeFitter dialogFitter;

	[Token(Token = "0x400E865")]
	private const string key = "DuelOkDialog";

	[Token(Token = "0x400E866")]
	private const string prefabPath = "Prefabs/Duel/DuelOkDialog";

	[Token(Token = "0x1700183A")]
	protected override bool useFieldView
	{
		[Token(Token = "0x6009F80")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700183B")]
	public string poolKey
	{
		[Token(Token = "0x6009F81")]
		[Address(RVA = "0xED35B0", Offset = "0xED27B0", VA = "0x180ED35B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700183C")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009F82")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009F83")]
	[Address(RVA = "0xED2F80", Offset = "0xED2180", VA = "0x180ED2F80")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelOkDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009F84")]
	[Address(RVA = "0xED2DF0", Offset = "0xED1FF0", VA = "0x180ED2DF0", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009F85")]
	[Address(RVA = "0xED3130", Offset = "0xED2330", VA = "0x180ED3130")]
	private void OnClickOk()
	{
	}

	[Token(Token = "0x6009F86")]
	[Address(RVA = "0xED3190", Offset = "0xED2390", VA = "0x180ED3190", Slot = "10")]
	protected override void OnClosed()
	{
	}

	[Token(Token = "0x6009F87")]
	[Address(RVA = "0xEA2C00", Offset = "0xEA1E00", VA = "0x180EA2C00", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009F88")]
	[Address(RVA = "0xEA2690", Offset = "0xEA1890", VA = "0x180EA2690", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009F89")]
	[Address(RVA = "0xED2D90", Offset = "0xED1F90", VA = "0x180ED2D90", Slot = "20")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6009F8A")]
	[Address(RVA = "0xED3130", Offset = "0xED2330", VA = "0x180ED3130", Slot = "21")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6009F8B")]
	[Address(RVA = "0xED31F0", Offset = "0xED23F0", VA = "0x180ED31F0")]
	public void Open(string message, string buttonText, Action<bool> resultCallback, Action openCallback)
	{
	}

	[Token(Token = "0x6009F8C")]
	[Address(RVA = "0xED33A0", Offset = "0xED25A0", VA = "0x180ED33A0")]
	public void Open(string message, Action<bool> resultCallback, Action openCallback)
	{
	}

	[Token(Token = "0x6009F8D")]
	[Address(RVA = "0xEA2750", Offset = "0xEA1950", VA = "0x180EA2750", Slot = "24")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009F8E")]
	[Address(RVA = "0xED35A0", Offset = "0xED27A0", VA = "0x180ED35A0")]
	public DuelOkDialog()
	{
	}
}
