using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomGame.Duel;

[Token(Token = "0x2001A9F")]
public abstract class SummonEffectBase
{
	[Token(Token = "0x400F4FC")]
	[FieldOffset(Offset = "0x10")]
	protected Texture2D destTextureFront;

	[Token(Token = "0x400F4FD")]
	[FieldOffset(Offset = "0x18")]
	protected Material destProtectorMaterial;

	[Token(Token = "0x400F4FE")]
	[FieldOffset(Offset = "0x20")]
	protected Texture2D[] matTextureFront;

	[Token(Token = "0x400F4FF")]
	[FieldOffset(Offset = "0x28")]
	protected Material[] matProtectorMaterials;

	[Token(Token = "0x400F500")]
	[FieldOffset(Offset = "0x30")]
	protected Transform destCard;

	[Token(Token = "0x400F501")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 destCardPosition;

	[Token(Token = "0x400F502")]
	[FieldOffset(Offset = "0x44")]
	private Quaternion destCardRotation;

	[Token(Token = "0x400F503")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 destCardScale;

	[Token(Token = "0x400F504")]
	[FieldOffset(Offset = "0x60")]
	protected Action onStartCard;

	[Token(Token = "0x400F505")]
	[FieldOffset(Offset = "0x68")]
	protected Action onFinished;

	[Token(Token = "0x400F507")]
	[FieldOffset(Offset = "0x78")]
	protected int materialNum;

	[Token(Token = "0x400F508")]
	[FieldOffset(Offset = "0x7C")]
	protected int loadCounter;

	[Token(Token = "0x400F50C")]
	[FieldOffset(Offset = "0x88")]
	protected PlayableDirector mainTimeline;

	[Token(Token = "0x400F50D")]
	[FieldOffset(Offset = "0x90")]
	protected GameObject autoReleaseCardPicture;

	[Token(Token = "0x400F50E")]
	[FieldOffset(Offset = "0x98")]
	protected List<int> cardidList;

	[Token(Token = "0x400F50F")]
	[FieldOffset(Offset = "0xA0")]
	protected List<UnityAction<Texture2D>> onFinishList;

	[Token(Token = "0x400F510")]
	[FieldOffset(Offset = "0xA8")]
	protected bool monsterCutinInvoked;

	[Token(Token = "0x400F511")]
	[FieldOffset(Offset = "0xA9")]
	private bool startCardInvoked;

	[Token(Token = "0x400F512")]
	[FieldOffset(Offset = "0xAA")]
	protected bool skipped;

	[Token(Token = "0x400F513")]
	[FieldOffset(Offset = "0xAB")]
	protected bool isTerminated;

	[Token(Token = "0x400F514")]
	[FieldOffset(Offset = "0xB0")]
	protected List<string> loadedTimelineList;

	[Token(Token = "0x17001AD0")]
	public MonsterCutinEffect monsterCutinEffect
	{
		[Token(Token = "0x600AD17")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600AD18")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001AD1")]
	public bool isLoading
	{
		[Token(Token = "0x600AD19")]
		[Address(RVA = "0x449810", Offset = "0x448A10", VA = "0x180449810")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001AD2")]
	public bool isEffectReady
	{
		[Token(Token = "0x600AD1A")]
		[Address(RVA = "0x449800", Offset = "0x448A00", VA = "0x180449800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AD1B")]
		[Address(RVA = "0x449850", Offset = "0x448A50", VA = "0x180449850")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001AD3")]
	public bool isEffectPlaying
	{
		[Token(Token = "0x600AD1C")]
		[Address(RVA = "0x4497F0", Offset = "0x4489F0", VA = "0x1804497F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AD1D")]
		[Address(RVA = "0x449840", Offset = "0x448A40", VA = "0x180449840")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001AD4")]
	public int destCardUniqueID
	{
		[Token(Token = "0x600AD1E")]
		[Address(RVA = "0x4497E0", Offset = "0x4489E0", VA = "0x1804497E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600AD1F")]
		[Address(RVA = "0x449830", Offset = "0x448A30", VA = "0x180449830")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001AD5")]
	public abstract Engine.SpSummonType spSummonType
	{
		[Token(Token = "0x600AD20")]
		get;
	}

	[Token(Token = "0x600AD21")]
	[Address(RVA = "0x447B00", Offset = "0x446D00", VA = "0x180447B00", Slot = "5")]
	public virtual void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
	{
	}

	[Token(Token = "0x600AD22")]
	[Address(RVA = "0x447990", Offset = "0x446B90", VA = "0x180447990")]
	protected void LoadCardFront()
	{
	}

	[Token(Token = "0x600AD23")]
	[Address(RVA = "0x4478D0", Offset = "0x446AD0", VA = "0x1804478D0")]
	protected void LoadCardBack(int sleeveID, UnityAction<Material> onFinished)
	{
	}

	[Token(Token = "0x600AD24")]
	[Address(RVA = "0x448BD0", Offset = "0x447DD0", VA = "0x180448BD0")]
	protected void TerminateCard()
	{
	}

	[Token(Token = "0x600AD25")]
	[Address(RVA = "0x4484A0", Offset = "0x4476A0", VA = "0x1804484A0")]
	public void Play(Action onFinished, Action onStartCard)
	{
	}

	[Token(Token = "0x600AD26")]
	protected abstract bool PlayEffect(Action onFinished);

	[Token(Token = "0x600AD27")]
	[Address(RVA = "0x448410", Offset = "0x447610", VA = "0x180448410")]
	protected PlayableDirector PlayTimeline(string label, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600AD28")]
	[Address(RVA = "0x448380", Offset = "0x447580", VA = "0x180448380")]
	protected void PlayTimeline(string path, UnityAction<PlayableDirector> onLoaded, Action onFinished)
	{
	}

	[Token(Token = "0x600AD29")]
	[Address(RVA = "0x447A20", Offset = "0x446C20", VA = "0x180447A20")]
	protected void LoadTimeline(string path)
	{
	}

	[Token(Token = "0x600AD2A")]
	[Address(RVA = "0x447530", Offset = "0x446730", VA = "0x180447530")]
	public (Vector3, Quaternion, Vector3) GetDestCardPlace()
	{
		return default((Vector3, Quaternion, Vector3));
	}

	[Token(Token = "0x600AD2B")]
	[Address(RVA = "0x449240", Offset = "0x448440", VA = "0x180449240")]
	public void UpdateDestCardPlace()
	{
	}

	[Token(Token = "0x600AD2C")]
	[Address(RVA = "0x4485F0", Offset = "0x4477F0", VA = "0x1804485F0")]
	protected void SetupEventCallback()
	{
	}

	[Token(Token = "0x600AD2D")]
	[Address(RVA = "0x448320", Offset = "0x447520", VA = "0x180448320")]
	private void PlayStartCard()
	{
	}

	[Token(Token = "0x600AD2E")]
	[Address(RVA = "0x4481F0", Offset = "0x4473F0", VA = "0x1804481F0")]
	private void PlayMonsterCutin()
	{
	}

	[Token(Token = "0x600AD2F")]
	[Address(RVA = "0x4473F0", Offset = "0x4465F0", VA = "0x1804473F0", Slot = "7")]
	protected virtual void Finish()
	{
	}

	[Token(Token = "0x600AD30")]
	[Address(RVA = "0x449080", Offset = "0x448280", VA = "0x180449080")]
	public void UnloadResources()
	{
	}

	[Token(Token = "0x600AD31")]
	[Address(RVA = "0x4486E0", Offset = "0x4478E0", VA = "0x1804486E0", Slot = "8")]
	public virtual bool Skip()
	{
		return default(bool);
	}

	[Token(Token = "0x600AD32")]
	[Address(RVA = "0x4475D0", Offset = "0x4467D0", VA = "0x1804475D0")]
	protected TimelineClip GetStrongSummonEvent(PlayableDirector timeline)
	{
		return null;
	}

	[Token(Token = "0x600AD33")]
	[Address(RVA = "0x448830", Offset = "0x447A30", VA = "0x180448830")]
	protected void StopSE(PlayableDirector timeline)
	{
	}

	[Token(Token = "0x600AD34")]
	[Address(RVA = "0x448DA0", Offset = "0x447FA0", VA = "0x180448DA0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600AD35")]
	[Address(RVA = "0x449760", Offset = "0x448960", VA = "0x180449760")]
	protected SummonEffectBase()
	{
	}
}
