using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001994")]
public abstract class CardPlace
{
	[Token(Token = "0x2001995")]
	private enum Step
	{
		[Token(Token = "0x400ED08")]
		Idle,
		[Token(Token = "0x400ED09")]
		InitLoadCard,
		[Token(Token = "0x400ED0A")]
		WaitLoadCard
	}

	[Token(Token = "0x2001996")]
	private enum CommandPower
	{
		[Token(Token = "0x400ED0C")]
		None,
		[Token(Token = "0x400ED0D")]
		Low,
		[Token(Token = "0x400ED0E")]
		Middle,
		[Token(Token = "0x400ED0F")]
		High
	}

	[Token(Token = "0x400ECF4")]
	[FieldOffset(Offset = "0x10")]
	public DuelFieldBase duelField;

	[Token(Token = "0x400ECF5")]
	[FieldOffset(Offset = "0x18")]
	public int team;

	[Token(Token = "0x400ECF6")]
	[FieldOffset(Offset = "0x1C")]
	public int position;

	[Token(Token = "0x400ECF8")]
	[FieldOffset(Offset = "0x28")]
	protected Dictionary<int, CardLocator> cardLocators;

	[Token(Token = "0x400ECFA")]
	[FieldOffset(Offset = "0x34")]
	private Step step;

	[Token(Token = "0x400ECFB")]
	[FieldOffset(Offset = "0x38")]
	private SimpleEffect affectTargetEff;

	[Token(Token = "0x400ECFC")]
	[FieldOffset(Offset = "0x40")]
	private SimpleEffect affectRelativeEff;

	[Token(Token = "0x400ECFD")]
	[FieldOffset(Offset = "0x48")]
	protected int currentLoadIdx;

	[Token(Token = "0x400ECFE")]
	[FieldOffset(Offset = "0x4C")]
	protected int numLoadCards;

	[Token(Token = "0x400ECFF")]
	[FieldOffset(Offset = "0x50")]
	private int numIncomings;

	[Token(Token = "0x400ED00")]
	[FieldOffset(Offset = "0x54")]
	private int numOutgoings;

	[Token(Token = "0x400ED02")]
	[FieldOffset(Offset = "0x60")]
	private Action onFinishedCardMove;

	[Token(Token = "0x400ED03")]
	[FieldOffset(Offset = "0x68")]
	private Action onFinishedPrepare;

	[Token(Token = "0x400ED04")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<Engine.CommandType, CommandPower> commandPowerList;

	[Token(Token = "0x400ED06")]
	[FieldOffset(Offset = "0x80")]
	protected CardLocator typicalLocator;

	[Token(Token = "0x17001915")]
	public bool isSelected
	{
		[Token(Token = "0x600A426")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A427")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001916")]
	public bool incoming
	{
		[Token(Token = "0x600A435")]
		[Address(RVA = "0xF0C8B0", Offset = "0xF0BAB0", VA = "0x180F0C8B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001917")]
	public bool outgoing
	{
		[Token(Token = "0x600A436")]
		[Address(RVA = "0xF0C900", Offset = "0xF0BB00", VA = "0x180F0C900")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001918")]
	public bool turning
	{
		[Token(Token = "0x600A437")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A438")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001919")]
	public bool cardMoving
	{
		[Token(Token = "0x600A439")]
		[Address(RVA = "0xF0C890", Offset = "0xF0BA90", VA = "0x180F0C890")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700191A")]
	public int incomingFromPosition
	{
		[Token(Token = "0x600A43A")]
		[Address(RVA = "0x42D5A0", Offset = "0x42C7A0", VA = "0x18042D5A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A43B")]
		[Address(RVA = "0x42D670", Offset = "0x42C870", VA = "0x18042D670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700191B")]
	protected virtual int loadStartIdx
	{
		[Token(Token = "0x600A449")]
		[Address(RVA = "0xF0C8F0", Offset = "0xF0BAF0", VA = "0x180F0C8F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700191C")]
	protected virtual int loadIndexIncValue
	{
		[Token(Token = "0x600A44A")]
		[Address(RVA = "0x4C9EF0", Offset = "0x4C90F0", VA = "0x1804C9EF0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700191D")]
	protected virtual bool loadIsOver
	{
		[Token(Token = "0x600A44B")]
		[Address(RVA = "0xF0C8E0", Offset = "0xF0BAE0", VA = "0x180F0C8E0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700191E")]
	public bool isPrepared
	{
		[Token(Token = "0x600A44C")]
		[Address(RVA = "0x9B6370", Offset = "0x9B5570", VA = "0x1809B6370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A44D")]
		[Address(RVA = "0xE3AEF0", Offset = "0xE3A0F0", VA = "0x180E3AEF0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700191F")]
	public bool isReady
	{
		[Token(Token = "0x600A44E")]
		[Address(RVA = "0xF0C8C0", Offset = "0xF0BAC0", VA = "0x180F0C8C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001920")]
	public virtual bool isStatusVisible
	{
		[Token(Token = "0x600A44F")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A428")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public virtual void OnUpdate()
	{
	}

	[Token(Token = "0x600A429")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "5")]
	public virtual bool UpdateInitialize()
	{
		return default(bool);
	}

	[Token(Token = "0x600A42A")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "6")]
	public virtual bool UpdateTerminate()
	{
		return default(bool);
	}

	[Token(Token = "0x600A42B")]
	[Address(RVA = "0xF0B4B0", Offset = "0xF0A6B0", VA = "0x180F0B4B0", Slot = "7")]
	public virtual CardLocator GetCardLocator(int index, bool create, bool insert)
	{
		return null;
	}

	[Token(Token = "0x600A42C")]
	[Address(RVA = "0xF0A880", Offset = "0xF09A80", VA = "0x180F0A880")]
	protected void AddCardLocator(int index, CardLocator cardLocator)
	{
	}

	[Token(Token = "0x600A42D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	protected virtual void UpdateLocators()
	{
	}

	[Token(Token = "0x600A42E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	protected virtual void SetupCardLocator(CardLocator cardLocator)
	{
	}

	[Token(Token = "0x600A42F")]
	[Address(RVA = "0xF0B620", Offset = "0xF0A820", VA = "0x180F0B620", Slot = "10")]
	protected virtual CardRoot GetCardRoot(int index)
	{
		return null;
	}

	[Token(Token = "0x600A430")]
	[Address(RVA = "0xF0BBB0", Offset = "0xF0ADB0", VA = "0x180F0BBB0", Slot = "11")]
	protected virtual CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return null;
	}

	[Token(Token = "0x600A431")]
	[Address(RVA = "0xF0BBF0", Offset = "0xF0ADF0", VA = "0x180F0BBF0", Slot = "12")]
	protected virtual bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return default(bool);
	}

	[Token(Token = "0x600A432")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	protected virtual void OnRegister(CardRoot cardRoot, int index, bool withEffect)
	{
	}

	[Token(Token = "0x600A433")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected virtual void OnUnregister(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600A434")]
	[Address(RVA = "0x3D4830", Offset = "0x3D3A30", VA = "0x1803D4830", Slot = "15")]
	public virtual Vector3 GetScreenPos(int index, Vector2 ofsRate)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A43C")]
	[Address(RVA = "0xF0C610", Offset = "0xF0B810", VA = "0x180F0C610")]
	public CardPlace(DuelFieldBase duelField, int team, int position)
	{
	}

	[Token(Token = "0x600A43D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "16")]
	public virtual void Terminate()
	{
	}

	[Token(Token = "0x600A43E")]
	[Address(RVA = "0xF0AFC0", Offset = "0xF0A1C0", VA = "0x180F0AFC0")]
	public CardLocator Enter(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return null;
	}

	[Token(Token = "0x600A43F")]
	[Address(RVA = "0xF0BB90", Offset = "0xF0AD90", VA = "0x180F0BB90")]
	public void Leave(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
	}

	[Token(Token = "0x600A440")]
	[Address(RVA = "0xF0BDB0", Offset = "0xF0AFB0", VA = "0x180F0BDB0")]
	public void Register(CardRoot cardRoot, int index, bool withEffect)
	{
	}

	[Token(Token = "0x600A441")]
	[Address(RVA = "0xF0C420", Offset = "0xF0B620", VA = "0x180F0C420")]
	public void Unregister(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600A442")]
	[Address(RVA = "0xF0ABD0", Offset = "0xF09DD0", VA = "0x180F0ABD0")]
	protected void AddOnFinishedCardMove(Action onFinished)
	{
	}

	[Token(Token = "0x600A443")]
	[Address(RVA = "0xF0C580", Offset = "0xF0B780", VA = "0x180F0C580")]
	public void Update()
	{
	}

	[Token(Token = "0x600A444")]
	[Address(RVA = "0xF0B990", Offset = "0xF0AB90", VA = "0x180F0B990")]
	private void InitLoadCardStep()
	{
	}

	[Token(Token = "0x600A445")]
	[Address(RVA = "0xF0BD90", Offset = "0xF0AF90", VA = "0x180F0BD90")]
	public void PrepareToDuel()
	{
	}

	[Token(Token = "0x600A446")]
	[Address(RVA = "0xF0BCA0", Offset = "0xF0AEA0", VA = "0x180F0BCA0", Slot = "17")]
	protected virtual void OnPrepareToDuel(bool startAtZero, Action onFinished)
	{
	}

	[Token(Token = "0x600A447")]
	[Address(RVA = "0xF0BEF0", Offset = "0xF0B0F0", VA = "0x180F0BEF0")]
	public void ShowUp(bool playEffect, Action onFinished)
	{
	}

	[Token(Token = "0x600A448")]
	[Address(RVA = "0xF0AE80", Offset = "0xF0A080", VA = "0x180F0AE80", Slot = "18")]
	protected virtual void OnShowUp(bool playEffect, Action onFinished)
	{
	}

	[Token(Token = "0x600A450")]
	[Address(RVA = "0xF0B660", Offset = "0xF0A860", VA = "0x180F0B660", Slot = "23")]
	public virtual Vector3 GetTypicalPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A451")]
	[Address(RVA = "0xF0B730", Offset = "0xF0A930", VA = "0x180F0B730", Slot = "24")]
	public virtual Quaternion GetTypicalRot()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600A452")]
	[Address(RVA = "0xF0B7C0", Offset = "0xF0A9C0", VA = "0x180F0B7C0", Slot = "25")]
	public virtual Vector3 GetTypicalScale()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A453")]
	[Address(RVA = "0xF0BF10", Offset = "0xF0B110", VA = "0x180F0BF10")]
	public void Shuffle(Action onFinished)
	{
	}

	[Token(Token = "0x600A454")]
	[Address(RVA = "0xCEE820", Offset = "0xCEDA20", VA = "0x180CEE820", Slot = "26")]
	protected virtual void ShuffleImpl(Action onFinished)
	{
	}

	[Token(Token = "0x600A455")]
	[Address(RVA = "0xF0B850", Offset = "0xF0AA50", VA = "0x180F0B850", Slot = "27")]
	public virtual void HighlightIfAvailable(bool available, uint cmdBit, Action onFinished)
	{
	}

	[Token(Token = "0x600A456")]
	[Address(RVA = "0xF0B850", Offset = "0xF0AA50", VA = "0x180F0B850")]
	public void ReqHighlight(bool available, uint cmdBit, Action onFinished)
	{
	}

	[Token(Token = "0x600A457")]
	[Address(RVA = "0xF0BE00", Offset = "0xF0B000", VA = "0x180F0BE00", Slot = "28")]
	protected virtual void ReqHighlightImpl(bool available, uint cmdBit, Action onFinished)
	{
	}

	[Token(Token = "0x600A458")]
	[Address(RVA = "0xF0B310", Offset = "0xF0A510", VA = "0x180F0B310")]
	protected SharedDefinition.ActivateAura GetActivateAura(int index, uint activeCommandBit)
	{
		return default(SharedDefinition.ActivateAura);
	}

	[Token(Token = "0x600A459")]
	[Address(RVA = "0xF0B1E0", Offset = "0xF0A3E0", VA = "0x180F0B1E0")]
	public void FlipTurn(int index, bool isFace, bool isAttack, bool immediate, Action onFinished)
	{
	}

	[Token(Token = "0x600A45A")]
	[Address(RVA = "0xF0B000", Offset = "0xF0A200", VA = "0x180F0B000", Slot = "29")]
	protected virtual void FlipTurnImpl(int index, bool isFace, bool isAttack, bool immediate, Action onFinished)
	{
	}

	[Token(Token = "0x600A45B")]
	[Address(RVA = "0xF0B190", Offset = "0xF0A390", VA = "0x180F0B190", Slot = "30")]
	protected virtual void FlipTurnStartImpl(CardRoot cardRoot, bool isFace)
	{
	}

	[Token(Token = "0x600A45C")]
	[Address(RVA = "0xF0BDE0", Offset = "0xF0AFE0", VA = "0x180F0BDE0")]
	public void ReqDecideEffect(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600A45D")]
	[Address(RVA = "0xF0AE80", Offset = "0xF0A080", VA = "0x180F0AE80", Slot = "31")]
	protected virtual void ReqDecideEffectImpl(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600A45E")]
	[Address(RVA = "0xF0AEA0", Offset = "0xF0A0A0", VA = "0x180F0AEA0")]
	public void EndSacrificeTargetEffect(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600A45F")]
	[Address(RVA = "0xF0AE80", Offset = "0xF0A080", VA = "0x180F0AE80", Slot = "32")]
	protected virtual void EndSacrificeTargetEffectImpl(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600A460")]
	[Address(RVA = "0xF0C300", Offset = "0xF0B500", VA = "0x180F0C300", Slot = "33")]
	public virtual void StartAffectRelativeEffect(Engine.AffectType affectType, Action onFinished)
	{
	}

	[Token(Token = "0x600A461")]
	[Address(RVA = "0xF0C020", Offset = "0xF0B220", VA = "0x180F0C020", Slot = "34")]
	protected virtual void StartAffectRelativeEffectImpl(Engine.AffectType affectType, Action onFinished)
	{
	}

	[Token(Token = "0x600A462")]
	[Address(RVA = "0xF0AD70", Offset = "0xF09F70", VA = "0x180F0AD70", Slot = "35")]
	public virtual void EndAffectEffect(Action onFinished)
	{
	}

	[Token(Token = "0x600A463")]
	[Address(RVA = "0xF0AC70", Offset = "0xF09E70", VA = "0x180F0AC70", Slot = "36")]
	public virtual void EndAffectEffectImpl(Action onFinished)
	{
	}

	[Token(Token = "0x600A464")]
	[Address(RVA = "0xF0C470", Offset = "0xF0B670", VA = "0x180F0C470")]
	public void UpdateState(Action onFinished)
	{
	}

	[Token(Token = "0x600A465")]
	[Address(RVA = "0xF0C440", Offset = "0xF0B640", VA = "0x180F0C440", Slot = "37")]
	protected virtual void UpdateStateImpl(Action onFinished)
	{
	}

	[Token(Token = "0x600A466")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "38")]
	public virtual void OnSelected()
	{
	}

	[Token(Token = "0x600A467")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "39")]
	public virtual void OnDeselected()
	{
	}

	[Token(Token = "0x600A468")]
	[Address(RVA = "0x913950", Offset = "0x912B50", VA = "0x180913950", Slot = "40")]
	public virtual int GetIndexByViewIndex(int viewIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600A469")]
	[Address(RVA = "0x913950", Offset = "0x912B50", VA = "0x180913950", Slot = "41")]
	public virtual int GetViewIndex(int index)
	{
		return default(int);
	}
}
