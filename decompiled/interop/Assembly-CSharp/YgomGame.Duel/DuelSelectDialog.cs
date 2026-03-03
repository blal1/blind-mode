using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20018D1")]
public class DuelSelectDialog : DuelDialogBase, IGameObjectPool
{
	[Token(Token = "0x20018D2")]
	public struct Info
	{
		[Token(Token = "0x400E8A9")]
		[FieldOffset(Offset = "0x0")]
		public string message;

		[Token(Token = "0x400E8AA")]
		[FieldOffset(Offset = "0x8")]
		public bool isEnable;
	}

	[Token(Token = "0x400E89A")]
	[FieldOffset(Offset = "0xB0")]
	private int result;

	[Token(Token = "0x400E89B")]
	[FieldOffset(Offset = "0xB8")]
	private Action<int, bool> resultCallback;

	[Token(Token = "0x400E89C")]
	[FieldOffset(Offset = "0xC0")]
	private TMP_Text textMessage;

	[Token(Token = "0x400E89D")]
	[FieldOffset(Offset = "0xC8")]
	private TMP_Text textEffectMessage;

	[Token(Token = "0x400E89E")]
	[FieldOffset(Offset = "0xD0")]
	private ExtendedScrollRect textScroll;

	[Token(Token = "0x400E89F")]
	[FieldOffset(Offset = "0xD8")]
	private ContentSizeFitter contentFitter;

	[Token(Token = "0x400E8A0")]
	[FieldOffset(Offset = "0xE0")]
	private ElementObjectManager tabTemplate;

	[Token(Token = "0x400E8A1")]
	[FieldOffset(Offset = "0xE8")]
	private RectTransform tabParent;

	[Token(Token = "0x400E8A2")]
	[FieldOffset(Offset = "0xF0")]
	private SelectionButton decideButton;

	[Token(Token = "0x400E8A3")]
	[FieldOffset(Offset = "0xF8")]
	private Image disableScreen;

	[Token(Token = "0x400E8A4")]
	[FieldOffset(Offset = "0x100")]
	private int cancelTabIndex;

	[Token(Token = "0x400E8A5")]
	[FieldOffset(Offset = "0x108")]
	private List<ElementObjectManager> tabList;

	[Token(Token = "0x400E8A6")]
	[FieldOffset(Offset = "0x110")]
	private List<Info> infoList;

	[Token(Token = "0x400E8A7")]
	private const string key = "DuelSelectDialog";

	[Token(Token = "0x400E8A8")]
	private const string prefabPath = "Prefabs/Duel/DuelSelectDialog";

	[Token(Token = "0x17001848")]
	protected override bool useFieldView
	{
		[Token(Token = "0x6009FE4")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001849")]
	public string poolKey
	{
		[Token(Token = "0x6009FE5")]
		[Address(RVA = "0xED8890", Offset = "0xED7A90", VA = "0x180ED8890", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700184A")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009FE6")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009FE7")]
	[Address(RVA = "0xED72E0", Offset = "0xED64E0", VA = "0x180ED72E0")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelSelectDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009FE8")]
	[Address(RVA = "0xED6E40", Offset = "0xED6040", VA = "0x180ED6E40", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009FE9")]
	[Address(RVA = "0xED7D50", Offset = "0xED6F50", VA = "0x180ED7D50")]
	private void SetupTab(int tabNum)
	{
	}

	[Token(Token = "0x6009FEA")]
	[Address(RVA = "0xED7490", Offset = "0xED6690", VA = "0x180ED7490")]
	private bool DecideEffect(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6009FEB")]
	[Address(RVA = "0xED7BA0", Offset = "0xED6DA0", VA = "0x180ED7BA0")]
	private void SetResult(int index)
	{
	}

	[Token(Token = "0x6009FEC")]
	[Address(RVA = "0xED86E0", Offset = "0xED78E0", VA = "0x180ED86E0")]
	private void UpdateTab()
	{
	}

	[Token(Token = "0x6009FED")]
	[Address(RVA = "0xED8570", Offset = "0xED7770", VA = "0x180ED8570")]
	private void UpdateMessage(int effectIndex)
	{
	}

	[Token(Token = "0x6009FEE")]
	[Address(RVA = "0xED7660", Offset = "0xED6860", VA = "0x180ED7660", Slot = "10")]
	protected override void OnClosed()
	{
	}

	[Token(Token = "0x6009FEF")]
	[Address(RVA = "0xEA2C00", Offset = "0xEA1E00", VA = "0x180EA2C00", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009FF0")]
	[Address(RVA = "0xEA2690", Offset = "0xEA1890", VA = "0x180EA2690", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009FF1")]
	[Address(RVA = "0xED6DD0", Offset = "0xED5FD0", VA = "0x180ED6DD0", Slot = "20")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6009FF2")]
	[Address(RVA = "0xED7580", Offset = "0xED6780", VA = "0x180ED7580", Slot = "21")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6009FF3")]
	[Address(RVA = "0xED7800", Offset = "0xED6A00", VA = "0x180ED7800")]
	public void Open(string message, List<Info> infoList, int defaultIndex, Action<int, bool> resultCallback, Action openCallback)
	{
	}

	[Token(Token = "0x6009FF4")]
	[Address(RVA = "0xED76D0", Offset = "0xED68D0", VA = "0x180ED76D0", Slot = "24")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009FF5")]
	[Address(RVA = "0xED8800", Offset = "0xED7A00", VA = "0x180ED8800")]
	public DuelSelectDialog()
	{
	}
}
