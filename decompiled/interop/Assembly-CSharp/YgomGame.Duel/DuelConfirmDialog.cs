using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001885")]
public class DuelConfirmDialog : DuelDialogBase, IGameObjectPool
{
	[Token(Token = "0x2001886")]
	public enum Result
	{
		[Token(Token = "0x400E61D")]
		Left,
		[Token(Token = "0x400E61E")]
		Right
	}

	[Token(Token = "0x400E611")]
	[FieldOffset(Offset = "0xB0")]
	private Result result;

	[Token(Token = "0x400E612")]
	[FieldOffset(Offset = "0xB8")]
	private Action<Result, bool> resultCallback;

	[Token(Token = "0x400E613")]
	[FieldOffset(Offset = "0xC0")]
	private ExtendedTextMeshProUGUI textMessage;

	[Token(Token = "0x400E614")]
	[FieldOffset(Offset = "0xC8")]
	private ExtendedTextMeshProUGUI textLeftButton;

	[Token(Token = "0x400E615")]
	[FieldOffset(Offset = "0xD0")]
	private ExtendedTextMeshProUGUI textRightButton;

	[Token(Token = "0x400E616")]
	[FieldOffset(Offset = "0xD8")]
	private ContentSizeFitter dialogFitter;

	[Token(Token = "0x400E617")]
	[FieldOffset(Offset = "0xE0")]
	private RectTransform rightButtonRectTransform;

	[Token(Token = "0x400E618")]
	[FieldOffset(Offset = "0xE8")]
	private SelectionButton rightButton;

	[Token(Token = "0x400E619")]
	private const string key = "DuelConmfirmDialog";

	[Token(Token = "0x400E61A")]
	[FieldOffset(Offset = "0xF0")]
	private bool useFieldViewFlag;

	[Token(Token = "0x400E61B")]
	private const string prefabPath = "Prefabs/Duel/DuelConfirmDialog";

	[Token(Token = "0x170017EB")]
	protected override bool useFieldView
	{
		[Token(Token = "0x6009CF9")]
		[Address(RVA = "0xDCD750", Offset = "0xDCC950", VA = "0x180DCD750", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017EC")]
	public string poolKey
	{
		[Token(Token = "0x6009CFA")]
		[Address(RVA = "0xEA3B90", Offset = "0xEA2D90", VA = "0x180EA3B90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017ED")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009CFB")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009CFC")]
	[Address(RVA = "0xEA3330", Offset = "0xEA2530", VA = "0x180EA3330")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelConfirmDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009CFD")]
	[Address(RVA = "0xEA3060", Offset = "0xEA2260", VA = "0x180EA3060", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009CFE")]
	[Address(RVA = "0xEA3550", Offset = "0xEA2750", VA = "0x180EA3550")]
	private void OnDecide(Result result)
	{
	}

	[Token(Token = "0x6009CFF")]
	[Address(RVA = "0xEA34F0", Offset = "0xEA26F0", VA = "0x180EA34F0", Slot = "10")]
	protected override void OnClosed()
	{
	}

	[Token(Token = "0x6009D00")]
	[Address(RVA = "0xEA2C00", Offset = "0xEA1E00", VA = "0x180EA2C00", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009D01")]
	[Address(RVA = "0xEA2690", Offset = "0xEA1890", VA = "0x180EA2690", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009D02")]
	[Address(RVA = "0xEA2F50", Offset = "0xEA2150", VA = "0x180EA2F50", Slot = "20")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6009D03")]
	[Address(RVA = "0xEA34E0", Offset = "0xEA26E0", VA = "0x180EA34E0", Slot = "21")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6009D04")]
	[Address(RVA = "0xEA3700", Offset = "0xEA2900", VA = "0x180EA3700")]
	public void Open(string message, string rightButtonText, string leftButtonText, Action<Result, bool> resultCallback, Action openCallback, bool useFieldView = true)
	{
	}

	[Token(Token = "0x6009D05")]
	[Address(RVA = "0xEA39B0", Offset = "0xEA2BB0", VA = "0x180EA39B0")]
	public void Open(string message, Action<Result, bool> resultCallback, Action openCallback, bool useFieldView = true)
	{
	}

	[Token(Token = "0x6009D06")]
	[Address(RVA = "0xEA2750", Offset = "0xEA1950", VA = "0x180EA2750", Slot = "24")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009D07")]
	[Address(RVA = "0xEA3B80", Offset = "0xEA2D80", VA = "0x180EA3B80")]
	public DuelConfirmDialog()
	{
	}
}
