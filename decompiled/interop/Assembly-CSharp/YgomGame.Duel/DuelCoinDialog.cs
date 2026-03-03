using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001880")]
public class DuelCoinDialog : DuelDialogBase, IGameObjectPool
{
	[Token(Token = "0x2001881")]
	public enum Result
	{
		[Token(Token = "0x400E605")]
		Back,
		[Token(Token = "0x400E606")]
		Front,
		[Token(Token = "0x400E607")]
		None
	}

	[Token(Token = "0x2001882")]
	private class CoinInfo
	{
		[Token(Token = "0x400E608")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager coin;

		[Token(Token = "0x400E609")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x400E60A")]
		[FieldOffset(Offset = "0x1C")]
		public Result result;

		[Token(Token = "0x6009CF2")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CoinInfo()
		{
		}
	}

	[Token(Token = "0x400E5FB")]
	[FieldOffset(Offset = "0xB0")]
	private Action<Result, bool> resultCallback;

	[Token(Token = "0x400E5FC")]
	[FieldOffset(Offset = "0xB8")]
	private Result result;

	[Token(Token = "0x400E5FD")]
	[FieldOffset(Offset = "0xC0")]
	private ExtendedTextMeshProUGUI textMessage;

	[Token(Token = "0x400E5FE")]
	[FieldOffset(Offset = "0xC8")]
	private List<CoinInfo> coinList;

	[Token(Token = "0x400E5FF")]
	[FieldOffset(Offset = "0xD0")]
	private SelectionButton decideButton;

	[Token(Token = "0x400E600")]
	[FieldOffset(Offset = "0xD8")]
	private BindingCoin[] coinBinder;

	[Token(Token = "0x400E601")]
	[FieldOffset(Offset = "0xE0")]
	private Image[] coinImage;

	[Token(Token = "0x400E602")]
	private const string key = "DuelCoinDialog";

	[Token(Token = "0x400E603")]
	private const string prefabPath = "Prefabs/Duel/DuelCoinDialog";

	[Token(Token = "0x170017E8")]
	protected override bool useFieldView
	{
		[Token(Token = "0x6009CD9")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017E9")]
	public string poolKey
	{
		[Token(Token = "0x6009CDA")]
		[Address(RVA = "0xEA2F20", Offset = "0xEA2120", VA = "0x180EA2F20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017EA")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009CDB")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009CDC")]
	[Address(RVA = "0xEA24E0", Offset = "0xEA16E0", VA = "0x180EA24E0")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelCoinDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009CDD")]
	[Address(RVA = "0xEA1CE0", Offset = "0xEA0EE0", VA = "0x180EA1CE0", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009CDE")]
	[Address(RVA = "0xEA2A90", Offset = "0xEA1C90", VA = "0x180EA2A90")]
	private void SelectItem(Result result)
	{
	}

	[Token(Token = "0x6009CDF")]
	[Address(RVA = "0xEA2A20", Offset = "0xEA1C20", VA = "0x180EA2A20")]
	private void SelectDecideButton()
	{
	}

	[Token(Token = "0x6009CE0")]
	[Address(RVA = "0xEA2BB0", Offset = "0xEA1DB0", VA = "0x180EA2BB0")]
	private void SetResult(Result result)
	{
	}

	[Token(Token = "0x6009CE1")]
	[Address(RVA = "0xEA1C50", Offset = "0xEA0E50", VA = "0x180EA1C50")]
	private void CancelResult()
	{
	}

	[Token(Token = "0x6009CE2")]
	[Address(RVA = "0xEA2D00", Offset = "0xEA1F00", VA = "0x180EA2D00")]
	private void UpdateCoinList()
	{
	}

	[Token(Token = "0x6009CE3")]
	[Address(RVA = "0xEA2E50", Offset = "0xEA2050", VA = "0x180EA2E50")]
	private void UpdateDecideButton()
	{
	}

	[Token(Token = "0x6009CE4")]
	[Address(RVA = "0xEA26E0", Offset = "0xEA18E0", VA = "0x180EA26E0", Slot = "10")]
	protected override void OnClosed()
	{
	}

	[Token(Token = "0x6009CE5")]
	[Address(RVA = "0xEA2C00", Offset = "0xEA1E00", VA = "0x180EA2C00", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009CE6")]
	[Address(RVA = "0xEA2690", Offset = "0xEA1890", VA = "0x180EA2690", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009CE7")]
	[Address(RVA = "0xEA1BD0", Offset = "0xEA0DD0", VA = "0x180EA1BD0", Slot = "20")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6009CE8")]
	[Address(RVA = "0xEA26D0", Offset = "0xEA18D0", VA = "0x180EA26D0", Slot = "21")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6009CE9")]
	[Address(RVA = "0xEA2840", Offset = "0xEA1A40", VA = "0x180EA2840")]
	public void ReleaseResources()
	{
	}

	[Token(Token = "0x6009CEA")]
	[Address(RVA = "0xEA2780", Offset = "0xEA1980", VA = "0x180EA2780")]
	public void Open(string message, Action<Result, bool> resultCallback, Action openCallback)
	{
	}

	[Token(Token = "0x6009CEB")]
	[Address(RVA = "0xEA2750", Offset = "0xEA1950", VA = "0x180EA2750", Slot = "24")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009CEC")]
	[Address(RVA = "0xEA2E90", Offset = "0xEA2090", VA = "0x180EA2E90")]
	public DuelCoinDialog()
	{
	}
}
