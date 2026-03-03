using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018C6")]
public class DuelPullDownDialog : DuelDialogBase, IGameObjectPool
{
	[Token(Token = "0x400E86B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Action<List<int>, bool> resultCallback;

	[Token(Token = "0x400E86C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int selectNum;

	[Token(Token = "0x400E86D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<int> result;

	[Token(Token = "0x400E86E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Selector scrollSelector;

	[Token(Token = "0x400E86F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<string> selectionList;

	[Token(Token = "0x400E870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private InfinityScrollView scroll;

	[Token(Token = "0x400E871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private ExtendedTextMeshProUGUI textMessage;

	[Token(Token = "0x400E872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private SelectionButton decideButton;

	[Token(Token = "0x400E873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GameObject counterArea;

	[Token(Token = "0x400E874")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private ExtendedTextMeshProUGUI textCounter;

	[Token(Token = "0x400E875")]
	private const string key = "DuelPullDownDialog";

	[Token(Token = "0x400E876")]
	private const string prefabPath = "Prefabs/Duel/DuelPullDownDialog";

	[Token(Token = "0x1700183D")]
	private int currentResultIndex
	{
		[Token(Token = "0x6009F94")]
		[Address(RVA = "0xED5950", Offset = "0xED4B50", VA = "0x180ED5950")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700183E")]
	protected override bool useFieldView
	{
		[Token(Token = "0x6009F95")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700183F")]
	public string poolKey
	{
		[Token(Token = "0x6009F96")]
		[Address(RVA = "0xED5990", Offset = "0xED4B90", VA = "0x180ED5990", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001840")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009F97")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009F98")]
	[Address(RVA = "0xED3F20", Offset = "0xED3120", VA = "0x180ED3F20")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelPullDownDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009F99")]
	[Address(RVA = "0xED3970", Offset = "0xED2B70", VA = "0x180ED3970", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009F9A")]
	[Address(RVA = "0xED4300", Offset = "0xED3500", VA = "0x180ED4300", Slot = "5")]
	public override void Initialize(RunEffectWorker effectWorker, bool createUI = true)
	{
	}

	[Token(Token = "0x6009F9B")]
	[Address(RVA = "0xED4150", Offset = "0xED3350", VA = "0x180ED4150")]
	private void InitializeScroll()
	{
	}

	[Token(Token = "0x6009F9C")]
	[Address(RVA = "0x705530", Offset = "0x704730", VA = "0x180705530")]
	private void OnCreateEntity(GameObject obj)
	{
	}

	[Token(Token = "0x6009F9D")]
	[Address(RVA = "0xED45E0", Offset = "0xED37E0", VA = "0x180ED45E0")]
	private void OnUpdateEntity(GameObject item, int index)
	{
	}

	[Token(Token = "0x6009F9E")]
	[Address(RVA = "0xED44F0", Offset = "0xED36F0", VA = "0x180ED44F0")]
	private void OnRemoveEntity(GameObject gob, int index, bool h)
	{
	}

	[Token(Token = "0x6009F9F")]
	[Address(RVA = "0xED4E90", Offset = "0xED4090", VA = "0x180ED4E90")]
	private void Select(int index)
	{
	}

	[Token(Token = "0x6009FA0")]
	[Address(RVA = "0xED4E50", Offset = "0xED4050", VA = "0x180ED4E50")]
	private void SelectItem(int index)
	{
	}

	[Token(Token = "0x6009FA1")]
	[Address(RVA = "0xED4E20", Offset = "0xED4020", VA = "0x180ED4E20")]
	private void SelectDecideButton()
	{
	}

	[Token(Token = "0x6009FA2")]
	[Address(RVA = "0xED5190", Offset = "0xED4390", VA = "0x180ED5190")]
	private void SetResult(int result, int index)
	{
	}

	[Token(Token = "0x6009FA3")]
	[Address(RVA = "0xED3750", Offset = "0xED2950", VA = "0x180ED3750")]
	private void CancelLastResult()
	{
	}

	[Token(Token = "0x6009FA4")]
	[Address(RVA = "0xED3800", Offset = "0xED2A00", VA = "0x180ED3800")]
	private void CancelResult(int result)
	{
	}

	[Token(Token = "0x6009FA5")]
	[Address(RVA = "0xED5750", Offset = "0xED4950", VA = "0x180ED5750")]
	private void UpdateCounter()
	{
	}

	[Token(Token = "0x6009FA6")]
	[Address(RVA = "0xED5860", Offset = "0xED4A60", VA = "0x180ED5860")]
	private void UpdateDecideButton()
	{
	}

	[Token(Token = "0x6009FA7")]
	[Address(RVA = "0xED38B0", Offset = "0xED2AB0", VA = "0x180ED38B0", Slot = "8")]
	protected override void Close([Optional] Action closedCallback)
	{
	}

	[Token(Token = "0x6009FA8")]
	[Address(RVA = "0xED4470", Offset = "0xED3670", VA = "0x180ED4470", Slot = "10")]
	protected override void OnClosed()
	{
	}

	[Token(Token = "0x6009FA9")]
	[Address(RVA = "0xEA2C00", Offset = "0xEA1E00", VA = "0x180EA2C00", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009FAA")]
	[Address(RVA = "0xEA2690", Offset = "0xEA1890", VA = "0x180EA2690", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009FAB")]
	[Address(RVA = "0xED35E0", Offset = "0xED27E0", VA = "0x180ED35E0", Slot = "20")]
	public override void Abort()
	{
	}

	[Token(Token = "0x6009FAC")]
	[Address(RVA = "0xED43B0", Offset = "0xED35B0", VA = "0x180ED43B0", Slot = "21")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6009FAD")]
	[Address(RVA = "0xED40D0", Offset = "0xED32D0", VA = "0x180ED40D0", Slot = "19")]
	protected override void FinishFieldView(bool isAbort)
	{
	}

	[Token(Token = "0x6009FAE")]
	[Address(RVA = "0xED4C00", Offset = "0xED3E00", VA = "0x180ED4C00")]
	public void Open(string message, List<string> selectionList, int selectNum, Action<List<int>, bool> resultCallback, Action openCallback)
	{
	}

	[Token(Token = "0x6009FAF")]
	[Address(RVA = "0xEA2750", Offset = "0xEA1950", VA = "0x180EA2750", Slot = "24")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009FB0")]
	[Address(RVA = "0xED58D0", Offset = "0xED4AD0", VA = "0x180ED58D0")]
	public DuelPullDownDialog()
	{
	}
}
