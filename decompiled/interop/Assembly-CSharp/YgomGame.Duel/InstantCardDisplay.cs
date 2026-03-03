using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20018E3")]
public class InstantCardDisplay : DuelUIBase, IGameObjectPool
{
	[Token(Token = "0x20018E4")]
	private class OperationInfo
	{
		[Token(Token = "0x20018E5")]
		public enum Operation
		{
			[Token(Token = "0x400E929")]
			Open,
			[Token(Token = "0x400E92A")]
			Wait,
			[Token(Token = "0x400E92B")]
			Close
		}

		[Token(Token = "0x400E924")]
		[FieldOffset(Offset = "0x10")]
		public Operation operation;

		[Token(Token = "0x400E925")]
		[FieldOffset(Offset = "0x14")]
		public int cardID;

		[Token(Token = "0x400E926")]
		[FieldOffset(Offset = "0x18")]
		public float waitTime;

		[Token(Token = "0x400E927")]
		[FieldOffset(Offset = "0x1C")]
		public bool applyEffect;

		[Token(Token = "0x600A075")]
		[Address(RVA = "0xEE4E10", Offset = "0xEE4010", VA = "0x180EE4E10")]
		public static OperationInfo OpenOperation(int cardID)
		{
			return null;
		}

		[Token(Token = "0x600A076")]
		[Address(RVA = "0xEE4DB0", Offset = "0xEE3FB0", VA = "0x180EE4DB0")]
		public static OperationInfo CloseOperation()
		{
			return null;
		}

		[Token(Token = "0x600A077")]
		[Address(RVA = "0xEE4F70", Offset = "0xEE4170", VA = "0x180EE4F70")]
		public static OperationInfo WaitOperation(float time, bool applyEffect)
		{
			return null;
		}

		[Token(Token = "0x600A078")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public OperationInfo()
		{
		}
	}

	[Token(Token = "0x400E91A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400E91B")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E91C")]
	[FieldOffset(Offset = "0x48")]
	private RawImage cardPicture;

	[Token(Token = "0x400E91D")]
	[FieldOffset(Offset = "0x50")]
	private ParticleSystem applyEffectRoot;

	[Token(Token = "0x400E91E")]
	[FieldOffset(Offset = "0x58")]
	private float currentTime;

	[Token(Token = "0x400E91F")]
	private const string prefabPath = "Prefabs/Duel/InstantCardDisplay";

	[Token(Token = "0x400E920")]
	private const float DefaultShowTime = 3f;

	[Token(Token = "0x400E921")]
	private const string key = "InstantCardDisplay";

	[Token(Token = "0x400E922")]
	[FieldOffset(Offset = "0x60")]
	private Queue<OperationInfo> operationQueue;

	[Token(Token = "0x400E923")]
	[FieldOffset(Offset = "0x68")]
	private OperationInfo currentOperation;

	[Token(Token = "0x1700185B")]
	protected override UITransitionUtil.BlockType openCloseBlockType
	{
		[Token(Token = "0x600A066")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "4")]
		get
		{
			return default(UITransitionUtil.BlockType);
		}
	}

	[Token(Token = "0x1700185C")]
	public string poolKey
	{
		[Token(Token = "0x600A067")]
		[Address(RVA = "0xEDDF80", Offset = "0xEDD180", VA = "0x180EDDF80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700185D")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600A068")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A069")]
	[Address(RVA = "0xEDD4A0", Offset = "0xEDC6A0", VA = "0x180EDD4A0")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<InstantCardDisplay> finishCallback)
	{
	}

	[Token(Token = "0x600A06A")]
	[Address(RVA = "0xEDD350", Offset = "0xEDC550", VA = "0x180EDD350", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x600A06B")]
	[Address(RVA = "0xEDD650", Offset = "0xEDC850", VA = "0x180EDD650", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x600A06C")]
	[Address(RVA = "0xEDDA80", Offset = "0xEDCC80", VA = "0x180EDDA80", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x600A06D")]
	[Address(RVA = "0xEDD8C0", Offset = "0xEDCAC0", VA = "0x180EDD8C0")]
	public void ReqOpen(int cardID, bool applyEffect, float showTime = 3f)
	{
	}

	[Token(Token = "0x600A06E")]
	[Address(RVA = "0xEDD700", Offset = "0xEDC900", VA = "0x180EDD700")]
	private void Open(int cardID)
	{
	}

	[Token(Token = "0x600A06F")]
	[Address(RVA = "0xEDDD00", Offset = "0xEDCF00", VA = "0x180EDDD00")]
	private void Wait(bool applyEffect)
	{
	}

	[Token(Token = "0x600A070")]
	[Address(RVA = "0xEDD7C0", Offset = "0xEDC9C0", VA = "0x180EDD7C0")]
	public void ReqForceClose()
	{
	}

	[Token(Token = "0x600A071")]
	[Address(RVA = "0xEDDCC0", Offset = "0xEDCEC0", VA = "0x180EDDCC0", Slot = "16")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600A072")]
	[Address(RVA = "0xEDDAC0", Offset = "0xEDCCC0", VA = "0x180EDDAC0")]
	private void UpdateOperation()
	{
	}

	[Token(Token = "0x600A073")]
	[Address(RVA = "0xEDD690", Offset = "0xEDC890", VA = "0x180EDD690", Slot = "19")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600A074")]
	[Address(RVA = "0xEDDF00", Offset = "0xEDD100", VA = "0x180EDDF00")]
	public InstantCardDisplay()
	{
	}
}
