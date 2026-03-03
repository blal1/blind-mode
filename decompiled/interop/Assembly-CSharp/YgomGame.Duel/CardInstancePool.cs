using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001980")]
public class CardInstancePool : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x2001981")]
	private enum Step
	{
		[Token(Token = "0x400EC95")]
		Initializing,
		[Token(Token = "0x400EC96")]
		Instantiate,
		[Token(Token = "0x400EC97")]
		Idle,
		[Token(Token = "0x400EC98")]
		Terminating
	}

	[Token(Token = "0x400EC8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x400EC8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UnityEngine.Object srcObject;

	[Token(Token = "0x400EC8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int counter;

	[Token(Token = "0x400EC8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<CardRoot> list;

	[Token(Token = "0x400EC8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Queue<CardRoot> queue;

	[Token(Token = "0x400EC90")]
	private const int NUM_DEFAULT_INSTANCE = 30;

	[Token(Token = "0x170018FA")]
	public string poolKey
	{
		[Token(Token = "0x600A390")]
		[Address(RVA = "0xF07D50", Offset = "0xF06F50", VA = "0x180F07D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018FB")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600A392")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018FC")]
	public bool isInitialized
	{
		[Token(Token = "0x600A395")]
		[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A396")]
		[Address(RVA = "0x8C82C0", Offset = "0x8C74C0", VA = "0x1808C82C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170018FD")]
	public bool isTerminated
	{
		[Token(Token = "0x600A398")]
		[Address(RVA = "0x7CE730", Offset = "0x7CD930", VA = "0x1807CE730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A399")]
		[Address(RVA = "0xD99E80", Offset = "0xD99080", VA = "0x180D99E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170018FE")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x600A39C")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A39D")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A391")]
	[Address(RVA = "0xF07360", Offset = "0xF06560", VA = "0x180F07360", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600A393")]
	[Address(RVA = "0xF06BA0", Offset = "0xF05DA0", VA = "0x180F06BA0")]
	public static CardInstancePool Create(DuelGameObjectManager goManager, GameObject root, string name)
	{
		return null;
	}

	[Token(Token = "0x600A394")]
	[Address(RVA = "0xF06DD0", Offset = "0xF05FD0", VA = "0x180F06DD0")]
	private void Initialize(bool createCard = true)
	{
	}

	[Token(Token = "0x600A397")]
	[Address(RVA = "0xF07840", Offset = "0xF06A40", VA = "0x180F07840")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A39A")]
	[Address(RVA = "0xF076A0", Offset = "0xF068A0", VA = "0x180F076A0")]
	public CardRoot RentInstance()
	{
		return null;
	}

	[Token(Token = "0x600A39B")]
	[Address(RVA = "0xF07720", Offset = "0xF06920", VA = "0x180F07720")]
	public void ReturnInstance(CardRoot cardRoot)
	{
	}

	[Token(Token = "0x600A39E")]
	[Address(RVA = "0xF07BD0", Offset = "0xF06DD0", VA = "0x180F07BD0")]
	private void Update()
	{
	}

	[Token(Token = "0x600A39F")]
	[Address(RVA = "0xF06EA0", Offset = "0xF060A0", VA = "0x180F06EA0")]
	private void InitializingStep()
	{
	}

	[Token(Token = "0x600A3A0")]
	[Address(RVA = "0xF06F10", Offset = "0xF06110", VA = "0x180F06F10")]
	private void InstantiateStep()
	{
	}

	[Token(Token = "0x600A3A1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void IdleStep()
	{
	}

	[Token(Token = "0x600A3A2")]
	[Address(RVA = "0xF079C0", Offset = "0xF06BC0", VA = "0x180F079C0")]
	private void TerminatingStep()
	{
	}

	[Token(Token = "0x600A3A3")]
	[Address(RVA = "0xF069D0", Offset = "0xF05BD0", VA = "0x180F069D0")]
	private void CreateInstance()
	{
	}

	[Token(Token = "0x600A3A4")]
	[Address(RVA = "0xF06D60", Offset = "0xF05F60", VA = "0x180F06D60")]
	private void EnqueueInstance(CardRoot cardRoot)
	{
	}

	[Token(Token = "0x600A3A5")]
	[Address(RVA = "0xF06F30", Offset = "0xF06130", VA = "0x180F06F30")]
	public bool IsEffectPlaying([Optional] CardRoot excludeCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A3A6")]
	[Address(RVA = "0xF07030", Offset = "0xF06230", VA = "0x180F07030")]
	public bool IsEffectPlaying(Type type, [Optional] CardRoot excludeCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A3A7")]
	[Address(RVA = "0xF07240", Offset = "0xF06440", VA = "0x180F07240")]
	public bool IsZoneEffectPlaying(ZoneCard.Zone zone, ZoneCard.Mode mode, [Optional] CardRoot excludeCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A3A8")]
	[Address(RVA = "0xF07140", Offset = "0xF06340", VA = "0x180F07140")]
	public bool IsMoveEffectRequested([Optional] CardRoot excludeCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A3A9")]
	[Address(RVA = "0xF07C90", Offset = "0xF06E90", VA = "0x180F07C90")]
	public CardInstancePool()
	{
	}
}
