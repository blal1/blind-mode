using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x2001127")]
public class TransitionCard : CardBase
{
	[Token(Token = "0x2001128")]
	public enum TraceTargetType
	{
		[Token(Token = "0x400B515")]
		Transform,
		[Token(Token = "0x400B516")]
		Position
	}

	[Token(Token = "0x2001129")]
	public enum MotionMode
	{
		[Token(Token = "0x400B518")]
		Linear,
		[Token(Token = "0x400B519")]
		BezierAdd,
		[Token(Token = "0x400B51A")]
		BezierRemove,
		[Token(Token = "0x400B51B")]
		NoMove
	}

	[Token(Token = "0x200112A")]
	public enum Size
	{
		[Token(Token = "0x400B51D")]
		NoChange,
		[Token(Token = "0x400B51E")]
		ToLarge,
		[Token(Token = "0x400B51F")]
		ToSmall
	}

	[Token(Token = "0x200112B")]
	private enum Step
	{
		[Token(Token = "0x400B521")]
		Idle,
		[Token(Token = "0x400B522")]
		Moving,
		[Token(Token = "0x400B523")]
		FadeOut
	}

	[Token(Token = "0x400B4FE")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private BezierMotionContainer bezierMotionAdd;

	[Token(Token = "0x400B4FF")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private BezierMotionContainer bezierMotionRemove;

	[Token(Token = "0x400B500")]
	[FieldOffset(Offset = "0xC8")]
	private ElementObjectManager elements;

	[Token(Token = "0x400B501")]
	[FieldOffset(Offset = "0xD0")]
	private List<RawImage> cardImages;

	[Token(Token = "0x400B502")]
	[FieldOffset(Offset = "0xD8")]
	private List<Tween> tweenIn;

	[Token(Token = "0x400B503")]
	[FieldOffset(Offset = "0xE0")]
	private List<Tween> tweenOut;

	[Token(Token = "0x400B504")]
	[FieldOffset(Offset = "0xE8")]
	private List<Tween> tweenOutFade;

	[Token(Token = "0x400B505")]
	[FieldOffset(Offset = "0xF0")]
	private List<Tween> tweenLargeSize;

	[Token(Token = "0x400B506")]
	[FieldOffset(Offset = "0xF8")]
	private List<Tween> tweenSmallSize;

	[Token(Token = "0x400B507")]
	[FieldOffset(Offset = "0x100")]
	private Transform pivot;

	[Token(Token = "0x400B508")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 basePosition;

	[Token(Token = "0x400B509")]
	[FieldOffset(Offset = "0x118")]
	private Transform targetTransform;

	[Token(Token = "0x400B50A")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 targetPosition;

	[Token(Token = "0x400B50B")]
	[FieldOffset(Offset = "0x130")]
	private Vector3[] positionHistory;

	[Token(Token = "0x400B50C")]
	[FieldOffset(Offset = "0x138")]
	private float remainTime;

	[Token(Token = "0x400B50D")]
	private const float traceTime = 0.5f;

	[Token(Token = "0x400B50E")]
	[FieldOffset(Offset = "0x140")]
	private ChainedBezierMotion motion;

	[Token(Token = "0x400B50F")]
	[FieldOffset(Offset = "0x148")]
	private bool outFade;

	[Token(Token = "0x400B510")]
	[FieldOffset(Offset = "0x150")]
	private Action onTraceFinishedCallback;

	[Token(Token = "0x400B511")]
	[FieldOffset(Offset = "0x158")]
	private TraceTargetType traceTargetType;

	[Token(Token = "0x400B512")]
	[FieldOffset(Offset = "0x15C")]
	private MotionMode mode;

	[Token(Token = "0x400B513")]
	[FieldOffset(Offset = "0x160")]
	private Step step;

	[Token(Token = "0x17001120")]
	private Vector3 target
	{
		[Token(Token = "0x6006B85")]
		[Address(RVA = "0xB3AE20", Offset = "0xB3A020", VA = "0x180B3AE20")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001121")]
	private bool isAvailableTarget
	{
		[Token(Token = "0x6006B86")]
		[Address(RVA = "0xB3ADB0", Offset = "0xB39FB0", VA = "0x180B3ADB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006B87")]
	[Address(RVA = "0xB38B00", Offset = "0xB37D00", VA = "0x180B38B00")]
	public static TransitionCard Create(TransitionCard prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6006B88")]
	[Address(RVA = "0xB38B90", Offset = "0xB37D90", VA = "0x180B38B90")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6006B89")]
	[Address(RVA = "0xB398C0", Offset = "0xB38AC0", VA = "0x180B398C0")]
	public void SetData(int id, int style)
	{
	}

	[Token(Token = "0x6006B8A")]
	[Address(RVA = "0xB39740", Offset = "0xB38940", VA = "0x180B39740")]
	public void SetData(CardBaseData cbd)
	{
	}

	[Token(Token = "0x6006B8B")]
	[Address(RVA = "0xB39930", Offset = "0xB38B30", VA = "0x180B39930")]
	public void SetPosition(Vector3 position)
	{
	}

	[Token(Token = "0x6006B8C")]
	[Address(RVA = "0xB39DA0", Offset = "0xB38FA0", VA = "0x180B39DA0")]
	public void StartCardTracing(MotionMode mode, Vector3 basePosition, Transform target, bool outFade, Size size, Action onFinished)
	{
	}

	[Token(Token = "0x6006B8D")]
	[Address(RVA = "0xB39EC0", Offset = "0xB390C0", VA = "0x180B39EC0")]
	public void StartPositionTracing(MotionMode mode, Vector3 basePosition, Vector3 target, bool outFade, Size size, Action onFinished)
	{
	}

	[Token(Token = "0x6006B8E")]
	[Address(RVA = "0xB39E40", Offset = "0xB39040", VA = "0x180B39E40")]
	public void StartPositionTracingEx(MotionMode mode, Vector3 basePosition, Vector3 target, bool inAnim, bool outFade, Size size, Action onFinished)
	{
	}

	[Token(Token = "0x6006B8F")]
	[Address(RVA = "0xB39C30", Offset = "0xB38E30", VA = "0x180B39C30")]
	public void StartAddEffect(Transform target, Size size, Action onFinished)
	{
	}

	[Token(Token = "0x6006B90")]
	[Address(RVA = "0xB39F40", Offset = "0xB39140", VA = "0x180B39F40")]
	private void StartTracing(MotionMode mode, Vector3 basePosition, bool inAnim, bool outFade, Size size, Action onFinished)
	{
	}

	[Token(Token = "0x6006B91")]
	[Address(RVA = "0xB3A880", Offset = "0xB39A80", VA = "0x180B3A880")]
	private void Update()
	{
	}

	[Token(Token = "0x6006B92")]
	[Address(RVA = "0xB3A5E0", Offset = "0xB397E0", VA = "0x180B3A5E0")]
	private void UpdatePivotPosition()
	{
	}

	[Token(Token = "0x6006B93")]
	[Address(RVA = "0xB3A550", Offset = "0xB39750", VA = "0x180B3A550")]
	private void UpdateMoving()
	{
	}

	[Token(Token = "0x6006B94")]
	[Address(RVA = "0xB3A430", Offset = "0xB39630", VA = "0x180B3A430")]
	private void UpdateFadeOut()
	{
	}

	[Token(Token = "0x6006B95")]
	[Address(RVA = "0xB3A480", Offset = "0xB39680", VA = "0x180B3A480")]
	private void UpdateHistory()
	{
	}

	[Token(Token = "0x6006B96")]
	[Address(RVA = "0xB3A340", Offset = "0xB39540", VA = "0x180B3A340")]
	private void UpdateCardPosition()
	{
	}

	[Token(Token = "0x6006B97")]
	[Address(RVA = "0xB395A0", Offset = "0xB387A0", VA = "0x180B395A0")]
	private void OnTraceFinished()
	{
	}

	[Token(Token = "0x6006B98")]
	[Address(RVA = "0xB39600", Offset = "0xB38800", VA = "0x180B39600")]
	private void PlayTween(List<Tween> tweenList)
	{
	}

	[Token(Token = "0x6006B99")]
	[Address(RVA = "0xB39B20", Offset = "0xB38D20", VA = "0x180B39B20")]
	public void SetTweenDuration(List<Tween> tweenList, float duration)
	{
	}

	[Token(Token = "0x6006B9A")]
	[Address(RVA = "0xB39460", Offset = "0xB38660", VA = "0x180B39460")]
	private bool IsTweenPlaying(List<Tween> tweenList)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B9B")]
	[Address(RVA = "0xB3ABD0", Offset = "0xB39DD0", VA = "0x180B3ABD0")]
	public TransitionCard()
	{
	}
}
