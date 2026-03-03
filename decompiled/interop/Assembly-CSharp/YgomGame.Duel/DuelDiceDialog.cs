using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001890")]
public class DuelDiceDialog : DuelDialogBase, IGameObjectPool
{
	[Token(Token = "0x2001891")]
	private class DiceInfo
	{
		[Token(Token = "0x400E672")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager dice;

		[Token(Token = "0x400E673")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x400E674")]
		[FieldOffset(Offset = "0x1C")]
		public int pip;

		[Token(Token = "0x6009D83")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DiceInfo()
		{
		}
	}

	[Token(Token = "0x400E668")]
	[FieldOffset(Offset = "0xB0")]
	private Action<List<int>, bool> resultCallback;

	[Token(Token = "0x400E669")]
	[FieldOffset(Offset = "0xB8")]
	private List<int> result;

	[Token(Token = "0x400E66A")]
	[FieldOffset(Offset = "0xC0")]
	private int selectNum;

	[Token(Token = "0x400E66B")]
	[FieldOffset(Offset = "0xC8")]
	private ExtendedTextMeshProUGUI textMessage;

	[Token(Token = "0x400E66C")]
	[FieldOffset(Offset = "0xD0")]
	private List<DiceInfo> diceList;

	[Token(Token = "0x400E66D")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject counterArea;

	[Token(Token = "0x400E66E")]
	[FieldOffset(Offset = "0xE0")]
	private ExtendedTextMeshProUGUI textCounter;

	[Token(Token = "0x400E66F")]
	[FieldOffset(Offset = "0xE8")]
	private SelectionButton decideButton;

	[Token(Token = "0x400E670")]
	private const string key = "DuelDiceDialog";

	[Token(Token = "0x400E671")]
	private const string prefabPath = "Prefabs/Duel/DuelDiceDialog";

	[Token(Token = "0x170017F3")]
	private int currentResultIndex
	{
		[Token(Token = "0x6009D67")]
		[Address(RVA = "0xEAA2B0", Offset = "0xEA94B0", VA = "0x180EAA2B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170017F4")]
	protected override bool useFieldView
	{
		[Token(Token = "0x6009D68")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017F5")]
	public string poolKey
	{
		[Token(Token = "0x6009D69")]
		[Address(RVA = "0xEAA2F0", Offset = "0xEA94F0", VA = "0x180EAA2F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017F6")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009D6A")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009D6B")]
	[Address(RVA = "0xEA9350", Offset = "0xEA8550", VA = "0x180EA9350")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelDiceDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009D6C")]
	[Address(RVA = "0xEA8D90", Offset = "0xEA7F90", VA = "0x180EA8D90", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009D6D")]
	[Address(RVA = "0xEA9730", Offset = "0xEA8930", VA = "0x180EA9730")]
	private void SelectItem(int index)
	{
	}

	[Token(Token = "0x6009D6E")]
	[Address(RVA = "0xEA96C0", Offset = "0xEA88C0", VA = "0x180EA96C0")]
	private void SelectDecideButton()
	{
	}

	[Token(Token = "0x6009D6F")]
	[Address(RVA = "0xEA97E0", Offset = "0xEA89E0", VA = "0x180EA97E0")]
	private void SetResult(int result, int index)
	{
	}

	[Token(Token = "0x6009D70")]
	[Address(RVA = "0xEA8C40", Offset = "0xEA7E40", VA = "0x180EA8C40")]
	private void CancelLastResult()
	{
	}

	[Token(Token = "0x6009D71")]
	[Address(RVA = "0xEA8CF0", Offset = "0xEA7EF0", VA = "0x180EA8CF0")]
	private void CancelResult(int result)
	{
	}

	[Token(Token = "0x6009D72")]
	[Address(RVA = "0xEAA080", Offset = "0xEA9280", VA = "0x180EAA080")]
	private void UpdateDiceList()
	{
	}

	[Token(Token = "0x6009D73")]
	[Address(RVA = "0xEA9F00", Offset = "0xEA9100", VA = "0x180EA9F00")]
	private void UpdateCounter()
	{
	}

	[Token(Token = "0x6009D74")]
	[Address(RVA = "0xEAA010", Offset = "0xEA9210", VA = "0x180EAA010")]
	private void UpdateDecideButton()
	{
	}

	[Token(Token = "0x6009D75")]
	[Address(RVA = "0xEA9510", Offset = "0xEA8710", VA = "0x180EA9510", Slot = "10")]
	protected override void OnClosed()
	{
	}

	[Token(Token = "0x6009D76")]
	[Address(RVA = "0xEA2C00", Offset = "0xEA1E00", VA = "0x180EA2C00", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009D77")]
	[Address(RVA = "0xEA2690", Offset = "0xEA1890", VA = "0x180EA2690", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009D78")]
	[Address(RVA = "0xEA8BC0", Offset = "0xEA7DC0", VA = "0x180EA8BC0", Slot = "20")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6009D79")]
	[Address(RVA = "0xEA9500", Offset = "0xEA8700", VA = "0x180EA9500", Slot = "21")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6009D7A")]
	[Address(RVA = "0xEA95B0", Offset = "0xEA87B0", VA = "0x180EA95B0")]
	public void Open(string message, List<int> selectionList, int selectNum, Action<List<int>, bool> resultCallback, Action openCallback)
	{
	}

	[Token(Token = "0x6009D7B")]
	[Address(RVA = "0xEA9970", Offset = "0xEA8B70", VA = "0x180EA9970")]
	private void SetupDiceList(List<int> selectionList)
	{
	}

	[Token(Token = "0x6009D7C")]
	[Address(RVA = "0xEA2750", Offset = "0xEA1950", VA = "0x180EA2750", Slot = "24")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009D7D")]
	[Address(RVA = "0xEAA1E0", Offset = "0xEA93E0", VA = "0x180EAA1E0")]
	public DuelDiceDialog()
	{
	}
}
