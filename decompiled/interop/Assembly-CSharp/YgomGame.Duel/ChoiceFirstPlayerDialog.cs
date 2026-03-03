using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001876")]
public class ChoiceFirstPlayerDialog : DuelUIBase
{
	[Token(Token = "0x2001877")]
	private class OperationInfo
	{
		[Token(Token = "0x2001878")]
		public enum Operation
		{
			[Token(Token = "0x400E5E2")]
			Open,
			[Token(Token = "0x400E5E3")]
			Wait,
			[Token(Token = "0x400E5E4")]
			Close
		}

		[Token(Token = "0x400E5DC")]
		[FieldOffset(Offset = "0x10")]
		public Operation operation;

		[Token(Token = "0x400E5DD")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x400E5DE")]
		[FieldOffset(Offset = "0x20")]
		public bool face;

		[Token(Token = "0x400E5DF")]
		[FieldOffset(Offset = "0x24")]
		public float waitTime;

		[Token(Token = "0x400E5E0")]
		[FieldOffset(Offset = "0x28")]
		public int choicePlayer;

		[Token(Token = "0x6009CB3")]
		[Address(RVA = "0xEB38D0", Offset = "0xEB2AD0", VA = "0x180EB38D0")]
		public static OperationInfo OpenOperation(string message, bool face, int choicePlayer)
		{
			return null;
		}

		[Token(Token = "0x6009CB4")]
		[Address(RVA = "0xEB3870", Offset = "0xEB2A70", VA = "0x180EB3870")]
		public static OperationInfo CloseOperation()
		{
			return null;
		}

		[Token(Token = "0x6009CB5")]
		[Address(RVA = "0xEB3970", Offset = "0xEB2B70", VA = "0x180EB3970")]
		public static OperationInfo WaitOperation(float time)
		{
			return null;
		}

		[Token(Token = "0x6009CB6")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public OperationInfo()
		{
		}
	}

	[Token(Token = "0x400E5D3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400E5D4")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E5D5")]
	[FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshProUGUI textMessage;

	[Token(Token = "0x400E5D6")]
	[FieldOffset(Offset = "0x50")]
	private Image coinImage;

	[Token(Token = "0x400E5D7")]
	[FieldOffset(Offset = "0x58")]
	private float currentTime;

	[Token(Token = "0x400E5D8")]
	private const string prefabPath = "Prefabs/Duel/ChoiceFirstPlayerDialog";

	[Token(Token = "0x400E5D9")]
	private const float DefaultShowTime = 3f;

	[Token(Token = "0x400E5DA")]
	[FieldOffset(Offset = "0x60")]
	private Queue<OperationInfo> operationQueue;

	[Token(Token = "0x400E5DB")]
	[FieldOffset(Offset = "0x68")]
	private OperationInfo currentOperation;

	[Token(Token = "0x170017E7")]
	protected override UITransitionUtil.BlockType openCloseBlockType
	{
		[Token(Token = "0x6009CA8")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "4")]
		get
		{
			return default(UITransitionUtil.BlockType);
		}
	}

	[Token(Token = "0x6009CA9")]
	[Address(RVA = "0xE9DF90", Offset = "0xE9D190", VA = "0x180E9DF90")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<ChoiceFirstPlayerDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009CAA")]
	[Address(RVA = "0xE9DE40", Offset = "0xE9D040", VA = "0x180E9DE40", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009CAB")]
	[Address(RVA = "0xE9E090", Offset = "0xE9D290", VA = "0x180E9E090", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009CAC")]
	[Address(RVA = "0xE9E540", Offset = "0xE9D740", VA = "0x180E9E540", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009CAD")]
	[Address(RVA = "0xE9E2B0", Offset = "0xE9D4B0", VA = "0x180E9E2B0")]
	public void ReqOpen(int choicePlayer, int firstPlayer, bool coinFace, float showTime = 3f)
	{
	}

	[Token(Token = "0x6009CAE")]
	[Address(RVA = "0xE9E1B0", Offset = "0xE9D3B0", VA = "0x180E9E1B0")]
	public void ReqForceClose()
	{
	}

	[Token(Token = "0x6009CAF")]
	[Address(RVA = "0xE9E0D0", Offset = "0xE9D2D0", VA = "0x180E9E0D0")]
	private void Open(string message, bool face, int player)
	{
	}

	[Token(Token = "0x6009CB0")]
	[Address(RVA = "0xE9E770", Offset = "0xE9D970", VA = "0x180E9E770", Slot = "16")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6009CB1")]
	[Address(RVA = "0xE9E580", Offset = "0xE9D780", VA = "0x180E9E580")]
	private void UpdateOperation()
	{
	}

	[Token(Token = "0x6009CB2")]
	[Address(RVA = "0xE9E790", Offset = "0xE9D990", VA = "0x180E9E790")]
	public ChoiceFirstPlayerDialog()
	{
	}
}
