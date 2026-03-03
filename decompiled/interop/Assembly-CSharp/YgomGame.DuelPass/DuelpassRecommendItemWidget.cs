using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000EDA")]
public class DuelpassRecommendItemWidget : MonoBehaviour
{
	[Token(Token = "0x2000EDD")]
	[CompilerGenerated]
	private sealed class _003CSwapCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A516")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A517")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A518")]
		[FieldOffset(Offset = "0x20")]
		public DuelpassRecommendItemWidget _003C_003E4__this;

		[Token(Token = "0x400A519")]
		[FieldOffset(Offset = "0x28")]
		public float swapSpan;

		[Token(Token = "0x17000DE6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005A18")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DE7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005A1A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A15")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSwapCoroutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005A16")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x9FDEC0", Offset = "0x9FD0C0", VA = "0x1809FDEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005A19")]
		[Address(RVA = "0x9FE4F0", Offset = "0x9FD6F0", VA = "0x1809FE4F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A509")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public GameObject[] itemHolders;

	[Token(Token = "0x400A50A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject holderParent;

	[Token(Token = "0x400A50B")]
	[FieldOffset(Offset = "0x30")]
	private List<(DuelpassRewardContext, GameObject, GameObject)> recommends;

	[Token(Token = "0x400A50C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SelectionButton mateButton;

	[Token(Token = "0x400A50D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TMP_Text gradeText;

	[Token(Token = "0x400A50E")]
	[FieldOffset(Offset = "0x48")]
	private readonly string LABEL_ITEMBINDER;

	[Token(Token = "0x400A50F")]
	[FieldOffset(Offset = "0x50")]
	private readonly string LABEL_WALLPAPERBG;

	[Token(Token = "0x400A510")]
	[FieldOffset(Offset = "0x58")]
	private int nowItemIdx;

	[Token(Token = "0x400A511")]
	[FieldOffset(Offset = "0x5C")]
	private int nextItemIdx;

	[Token(Token = "0x6005A05")]
	[Address(RVA = "0x9F1380", Offset = "0x9F0580", VA = "0x1809F1380")]
	public void Init()
	{
	}

	[Token(Token = "0x6005A06")]
	[Address(RVA = "0x9F1870", Offset = "0x9F0A70", VA = "0x1809F1870")]
	private void Start()
	{
	}

	[Token(Token = "0x6005A07")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005A08")]
	[Address(RVA = "0x9F1830", Offset = "0x9F0A30", VA = "0x1809F1830")]
	public void StartSwap()
	{
	}

	[Token(Token = "0x6005A09")]
	[Address(RVA = "0x9F0F00", Offset = "0x9F0100", VA = "0x1809F0F00")]
	public void BindAll()
	{
	}

	[Token(Token = "0x6005A0A")]
	[Address(RVA = "0x9F1B10", Offset = "0x9F0D10", VA = "0x1809F1B10")]
	[IteratorStateMachine(typeof(_003CSwapCoroutine_003Ed__14))]
	private IEnumerator SwapCoroutine(float swapSpan)
	{
		return null;
	}

	[Token(Token = "0x6005A0B")]
	[Address(RVA = "0x9F1030", Offset = "0x9F0230", VA = "0x1809F1030")]
	private void BindItem(DuelpassRewardContext context, GameObject holderTemplate, GameObject binder)
	{
	}

	[Token(Token = "0x6005A0C")]
	[Address(RVA = "0x9F1B90", Offset = "0x9F0D90", VA = "0x1809F1B90")]
	private void TweenTargetItemBinderPlayLabel(GameObject template, string label)
	{
	}

	[Token(Token = "0x6005A0D")]
	[Address(RVA = "0x9F18C0", Offset = "0x9F0AC0", VA = "0x1809F18C0")]
	public void StopTween()
	{
	}

	[Token(Token = "0x6005A0E")]
	[Address(RVA = "0x9F1C70", Offset = "0x9F0E70", VA = "0x1809F1C70")]
	public DuelpassRecommendItemWidget()
	{
	}
}
