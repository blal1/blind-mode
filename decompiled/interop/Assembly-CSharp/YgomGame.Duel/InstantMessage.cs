using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018E7")]
public class InstantMessage : DuelUIBase, IGameObjectPool
{
	[Token(Token = "0x20018E8")]
	private class OperationInfo
	{
		[Token(Token = "0x20018E9")]
		public enum Operation
		{
			[Token(Token = "0x400E93C")]
			Open,
			[Token(Token = "0x400E93D")]
			Wait,
			[Token(Token = "0x400E93E")]
			Close
		}

		[Token(Token = "0x400E938")]
		[FieldOffset(Offset = "0x10")]
		public Operation operation;

		[Token(Token = "0x400E939")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x400E93A")]
		[FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x600A089")]
		[Address(RVA = "0xEE4E80", Offset = "0xEE4080", VA = "0x180EE4E80")]
		public static OperationInfo OpenOperation(string message)
		{
			return null;
		}

		[Token(Token = "0x600A08A")]
		[Address(RVA = "0xEE4D50", Offset = "0xEE3F50", VA = "0x180EE4D50")]
		public static OperationInfo CloseOperation()
		{
			return null;
		}

		[Token(Token = "0x600A08B")]
		[Address(RVA = "0xEE4F00", Offset = "0xEE4100", VA = "0x180EE4F00")]
		public static OperationInfo WaitOperation(float time)
		{
			return null;
		}

		[Token(Token = "0x600A08C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public OperationInfo()
		{
		}
	}

	[Token(Token = "0x400E92F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400E930")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E931")]
	[FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshProUGUI textMessage;

	[Token(Token = "0x400E932")]
	[FieldOffset(Offset = "0x50")]
	private float currentTime;

	[Token(Token = "0x400E933")]
	private const string prefabPath = "Prefabs/Duel/InstantMessage";

	[Token(Token = "0x400E934")]
	private const float DefaultShowTime = 3f;

	[Token(Token = "0x400E935")]
	private const string key = "InstantMessage";

	[Token(Token = "0x400E936")]
	[FieldOffset(Offset = "0x58")]
	private Queue<OperationInfo> operationQueue;

	[Token(Token = "0x400E937")]
	[FieldOffset(Offset = "0x60")]
	private OperationInfo currentOperation;

	[Token(Token = "0x1700185E")]
	protected override UITransitionUtil.BlockType openCloseBlockType
	{
		[Token(Token = "0x600A07B")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "4")]
		get
		{
			return default(UITransitionUtil.BlockType);
		}
	}

	[Token(Token = "0x1700185F")]
	public string poolKey
	{
		[Token(Token = "0x600A07C")]
		[Address(RVA = "0xEDE960", Offset = "0xEDDB60", VA = "0x180EDE960", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001860")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600A07D")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A07E")]
	[Address(RVA = "0xEDE0B0", Offset = "0xEDD2B0", VA = "0x180EDE0B0")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<InstantMessage> finishCallback)
	{
	}

	[Token(Token = "0x600A07F")]
	[Address(RVA = "0xEDDFB0", Offset = "0xEDD1B0", VA = "0x180EDDFB0", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x600A080")]
	[Address(RVA = "0xEDD650", Offset = "0xEDC850", VA = "0x180EDD650", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x600A081")]
	[Address(RVA = "0xEDDA80", Offset = "0xEDCC80", VA = "0x180EDDA80", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x600A082")]
	[Address(RVA = "0xEDE420", Offset = "0xEDD620", VA = "0x180EDE420")]
	public void ReqOpen(string message, float showTime = 3f)
	{
	}

	[Token(Token = "0x600A083")]
	[Address(RVA = "0xEDE320", Offset = "0xEDD520", VA = "0x180EDE320")]
	public void ReqForceClose()
	{
	}

	[Token(Token = "0x600A084")]
	[Address(RVA = "0xEDE2D0", Offset = "0xEDD4D0", VA = "0x180EDE2D0")]
	private void Open(string message)
	{
	}

	[Token(Token = "0x600A085")]
	[Address(RVA = "0xEDE750", Offset = "0xEDD950", VA = "0x180EDE750", Slot = "16")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600A086")]
	[Address(RVA = "0xEDE5D0", Offset = "0xEDD7D0", VA = "0x180EDE5D0")]
	private void UpdateOperation()
	{
	}

	[Token(Token = "0x600A087")]
	[Address(RVA = "0xEDE260", Offset = "0xEDD460", VA = "0x180EDE260", Slot = "19")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600A088")]
	[Address(RVA = "0xEDE8E0", Offset = "0xEDDAE0", VA = "0x180EDE8E0")]
	public InstantMessage()
	{
	}
}
