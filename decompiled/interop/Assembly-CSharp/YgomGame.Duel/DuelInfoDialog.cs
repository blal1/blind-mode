using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20018A8")]
public class DuelInfoDialog : DuelInfoDialogBase, IGameObjectPool
{
	[Token(Token = "0x20018A9")]
	private class InfoDialogOperationInfo : OperationInfo
	{
		[Token(Token = "0x6009E99")]
		[Address(RVA = "0xEC9A20", Offset = "0xEC8C20", VA = "0x180EC9A20")]
		public static OperationInfo OpenOperation(DuelInfoDialog dialog, string message, Place place, bool cancelable, Action cancelCallback, [Optional] Action closeCallback, bool decidable = false, [Optional] Action decisionCallback, [Optional] Action actCallback)
		{
			return null;
		}

		[Token(Token = "0x6009E9A")]
		[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
		public InfoDialogOperationInfo()
		{
		}
	}

	[Token(Token = "0x400E73F")]
	private const string prefabPath = "Prefabs/Duel/DuelInfoDialog";

	[Token(Token = "0x400E740")]
	private const string key = "DuelInfoDialog";

	[Token(Token = "0x17001820")]
	public string poolKey
	{
		[Token(Token = "0x6009E91")]
		[Address(RVA = "0xEB8630", Offset = "0xEB7830", VA = "0x180EB8630", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001821")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009E92")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009E93")]
	[Address(RVA = "0xEB8430", Offset = "0xEB7630", VA = "0x180EB8430")]
	public void ReqOpen(string message, Place place, bool cancelable, Action cancelCallback, [Optional] Action closeCallback, bool decidable = false, [Optional] Action decisionCallback, [Optional] Action actCallback)
	{
	}

	[Token(Token = "0x6009E94")]
	[Address(RVA = "0xEB80F0", Offset = "0xEB72F0", VA = "0x180EB80F0")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelInfoDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009E95")]
	[Address(RVA = "0xEB82A0", Offset = "0xEB74A0", VA = "0x180EB82A0", Slot = "5")]
	public override void Initialize(RunEffectWorker effectWorker, bool createUI = true)
	{
	}

	[Token(Token = "0x6009E96")]
	[Address(RVA = "0xEB7F70", Offset = "0xEB7170", VA = "0x180EB7F70", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009E97")]
	[Address(RVA = "0xEB8380", Offset = "0xEB7580", VA = "0x180EB8380", Slot = "19")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009E98")]
	[Address(RVA = "0xEB7F60", Offset = "0xEB7160", VA = "0x180EB7F60")]
	public DuelInfoDialog()
	{
	}
}
