using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x2001984")]
public abstract class CardMoveEffectBase
{
	[Token(Token = "0x400ECA4")]
	[FieldOffset(Offset = "0x10")]
	protected Material destMaterialFront;

	[Token(Token = "0x400ECA5")]
	[FieldOffset(Offset = "0x18")]
	protected Material destProtectorMaterial;

	[Token(Token = "0x400ECA6")]
	[FieldOffset(Offset = "0x20")]
	protected Transform destCard;

	[Token(Token = "0x400ECA7")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 destCardPosition;

	[Token(Token = "0x400ECA8")]
	[FieldOffset(Offset = "0x34")]
	private Quaternion destCardRotation;

	[Token(Token = "0x400ECA9")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 destCardScale;

	[Token(Token = "0x400ECAA")]
	[FieldOffset(Offset = "0x50")]
	protected Action onStartCard;

	[Token(Token = "0x400ECAB")]
	[FieldOffset(Offset = "0x58")]
	protected Action onGoNext;

	[Token(Token = "0x400ECAC")]
	[FieldOffset(Offset = "0x60")]
	protected Action onFinished;

	[Token(Token = "0x400ECAD")]
	[FieldOffset(Offset = "0x68")]
	protected int loadCounter;

	[Token(Token = "0x400ECB4")]
	[FieldOffset(Offset = "0x80")]
	protected PlayableDirector mainTimeline;

	[Token(Token = "0x400ECB5")]
	[FieldOffset(Offset = "0x88")]
	protected List<int> cardidList;

	[Token(Token = "0x400ECB6")]
	[FieldOffset(Offset = "0x90")]
	protected List<UnityAction<Material>> onFinishList;

	[Token(Token = "0x400ECB7")]
	[FieldOffset(Offset = "0x98")]
	protected GameObject autoReleaseCardPicture;

	[Token(Token = "0x400ECB8")]
	[FieldOffset(Offset = "0xA0")]
	private bool startCardInvoked;

	[Token(Token = "0x400ECB9")]
	[FieldOffset(Offset = "0xA1")]
	private bool goNextInvoked;

	[Token(Token = "0x400ECBA")]
	[FieldOffset(Offset = "0xA2")]
	protected bool skipped;

	[Token(Token = "0x400ECBB")]
	[FieldOffset(Offset = "0xA3")]
	protected bool isTerminated;

	[Token(Token = "0x400ECBC")]
	[FieldOffset(Offset = "0xA8")]
	protected List<string> loadedTimelineList;

	[Token(Token = "0x1700190B")]
	public bool isLoading
	{
		[Token(Token = "0x600A3CA")]
		[Address(RVA = "0xF09E40", Offset = "0xF09040", VA = "0x180F09E40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700190C")]
	public bool isEffectReady
	{
		[Token(Token = "0x600A3CB")]
		[Address(RVA = "0xF09E30", Offset = "0xF09030", VA = "0x180F09E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A3CC")]
		[Address(RVA = "0xF09E60", Offset = "0xF09060", VA = "0x180F09E60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700190D")]
	public bool isEffectPlaying
	{
		[Token(Token = "0x600A3CD")]
		[Address(RVA = "0xF09E20", Offset = "0xF09020", VA = "0x180F09E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A3CE")]
		[Address(RVA = "0xF09E50", Offset = "0xF09050", VA = "0x180F09E50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700190E")]
	public int fromPlayer
	{
		[Token(Token = "0x600A3CF")]
		[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A3D0")]
		[Address(RVA = "0x99DB50", Offset = "0x99CD50", VA = "0x18099DB50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700190F")]
	public int fromPosition
	{
		[Token(Token = "0x600A3D1")]
		[Address(RVA = "0x3EC970", Offset = "0x3EBB70", VA = "0x1803EC970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A3D2")]
		[Address(RVA = "0x3EC980", Offset = "0x3EBB80", VA = "0x1803EC980")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001910")]
	public int destCardID
	{
		[Token(Token = "0x600A3D3")]
		[Address(RVA = "0x55E5E0", Offset = "0x55D7E0", VA = "0x18055E5E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A3D4")]
		[Address(RVA = "0x55E600", Offset = "0x55D800", VA = "0x18055E600")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001911")]
	public int destCardRareID
	{
		[Token(Token = "0x600A3D5")]
		[Address(RVA = "0x55E5F0", Offset = "0x55D7F0", VA = "0x18055E5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A3D6")]
		[Address(RVA = "0x55E610", Offset = "0x55D810", VA = "0x18055E610")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x600A3D7")]
	[Address(RVA = "0xF08AD0", Offset = "0xF07CD0", VA = "0x180F08AD0", Slot = "4")]
	public virtual void Load(int moveCardID, int moveCardSleeveID, int moveCardRareID, int fromPlayer, int fromPosition)
	{
	}

	[Token(Token = "0x600A3D8")]
	[Address(RVA = "0xF08730", Offset = "0xF07930", VA = "0x180F08730")]
	protected void LoadCardFront(int cardID, int rareID, MeshRenderer targetRenderer)
	{
	}

	[Token(Token = "0x600A3D9")]
	[Address(RVA = "0xF08810", Offset = "0xF07A10", VA = "0x180F08810")]
	protected void LoadCardFront(int cardID, Material targetMaterial)
	{
	}

	[Token(Token = "0x600A3DA")]
	[Address(RVA = "0xF08670", Offset = "0xF07870", VA = "0x180F08670")]
	protected void LoadCardBack(int sleeveID, UnityAction<Material> onFinished)
	{
	}

	[Token(Token = "0x600A3DB")]
	[Address(RVA = "0xCCCD80", Offset = "0xCCBF80", VA = "0x180CCCD80")]
	protected void TerminateCard()
	{
	}

	[Token(Token = "0x600A3DC")]
	[Address(RVA = "0xF08E00", Offset = "0xF08000", VA = "0x180F08E00")]
	public void Play(RunEffectWorker worker, Action onFinished, Action onStartCard, Action onGoNext)
	{
	}

	[Token(Token = "0x600A3DD")]
	protected abstract bool PlayEffect(RunEffectWorker worker, Action onFinished);

	[Token(Token = "0x600A3DE")]
	[Address(RVA = "0xF08D70", Offset = "0xF07F70", VA = "0x180F08D70")]
	protected PlayableDirector PlayTimeline(string label, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600A3DF")]
	[Address(RVA = "0xF089F0", Offset = "0xF07BF0", VA = "0x180F089F0")]
	protected void LoadTimeline(string path)
	{
	}

	[Token(Token = "0x600A3E0")]
	[Address(RVA = "0xF085D0", Offset = "0xF077D0", VA = "0x180F085D0")]
	public (Vector3, Quaternion, Vector3) GetDestCardPlace()
	{
		return default((Vector3, Quaternion, Vector3));
	}

	[Token(Token = "0x600A3E1")]
	[Address(RVA = "0xF09850", Offset = "0xF08A50", VA = "0x180F09850")]
	public void UpdateDestCardPlace()
	{
	}

	[Token(Token = "0x600A3E2")]
	[Address(RVA = "0xF08F60", Offset = "0xF08160", VA = "0x180F08F60")]
	protected void SetupEventCallback()
	{
	}

	[Token(Token = "0x600A3E3")]
	[Address(RVA = "0xF08D10", Offset = "0xF07F10", VA = "0x180F08D10")]
	private void PlayStartCard()
	{
	}

	[Token(Token = "0x600A3E4")]
	[Address(RVA = "0xF08CB0", Offset = "0xF07EB0", VA = "0x180F08CB0")]
	private void PlayGoNext()
	{
	}

	[Token(Token = "0x600A3E5")]
	[Address(RVA = "0xF08490", Offset = "0xF07690", VA = "0x180F08490", Slot = "6")]
	protected virtual void Finish()
	{
	}

	[Token(Token = "0x600A3E6")]
	[Address(RVA = "0xF096F0", Offset = "0xF088F0", VA = "0x180F096F0")]
	public void UnloadResources()
	{
	}

	[Token(Token = "0x600A3E7")]
	[Address(RVA = "0xF09050", Offset = "0xF08250", VA = "0x180F09050", Slot = "7")]
	public virtual bool Skip()
	{
		return default(bool);
	}

	[Token(Token = "0x600A3E8")]
	[Address(RVA = "0xF09120", Offset = "0xF08320", VA = "0x180F09120")]
	protected void StopSE(PlayableDirector timeline)
	{
	}

	[Token(Token = "0x600A3E9")]
	[Address(RVA = "0xF094C0", Offset = "0xF086C0", VA = "0x180F094C0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A3EA")]
	[Address(RVA = "0xF09DA0", Offset = "0xF08FA0", VA = "0x180F09DA0")]
	protected CardMoveEffectBase()
	{
	}
}
