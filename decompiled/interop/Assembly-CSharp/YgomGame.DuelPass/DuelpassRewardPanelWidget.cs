using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000EE4")]
public class DuelpassRewardPanelWidget
{
	[Token(Token = "0x2000EEA")]
	[CompilerGenerated]
	private sealed class _003CSnapCoroutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelpassRewardPanelWidget _003C_003E4__this;

		[Token(Token = "0x400A56A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int snapSpan;

		[Token(Token = "0x400A56B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onCompleteAction;

		[Token(Token = "0x400A56C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _003CelappsedSnapingTime_003E5__2;

		[Token(Token = "0x400A56D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _003CstartPosition_003E5__3;

		[Token(Token = "0x400A56E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _003CendPosition_003E5__4;

		[Token(Token = "0x17000DF5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005A84")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DF6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005A86")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A81")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSnapCoroutine_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005A82")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005A83")]
		[Address(RVA = "0xA14CF0", Offset = "0xA13EF0", VA = "0x180A14CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005A85")]
		[Address(RVA = "0xA14F80", Offset = "0xA14180", VA = "0x180A14F80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A54A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private InfinityScrollView infinityScroll;

	[Token(Token = "0x400A54B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ScrollRect scrollRect;

	[Token(Token = "0x400A54C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<GameObject, DuelpassRewardColumnWidget> templateToWidgetDict;

	[Token(Token = "0x400A54D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject lockedIcon;

	[Token(Token = "0x400A54E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SelectionButton backButton;

	[Token(Token = "0x400A54F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SelectionButton nextButton;

	[Token(Token = "0x400A550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SelectionButton toDuelResultButton;

	[Token(Token = "0x400A551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float snapDurationTime;

	[Token(Token = "0x400A552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int attentionEntityIdx;

	[Token(Token = "0x400A553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int currentGrade;

	[Token(Token = "0x400A554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int achievedGrade;

	[Token(Token = "0x400A555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int duelpassScrollentityNum;

	[Token(Token = "0x400A556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int attentionEntityIdxMax;

	[Token(Token = "0x400A557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int target;

	[Token(Token = "0x400A558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool isFirstChangeGrade;

	[Token(Token = "0x400A559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool isReceivable;

	[Token(Token = "0x400A55A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	private bool isLockedPageButton;

	[Token(Token = "0x400A55B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<DuelpassRewardColumnContext> entityContextList;

	[Token(Token = "0x400A55C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<int, DuelpassRewardColumnWidget> gradeToWidgetDict;

	[Token(Token = "0x400A55D")]
	private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

	[Token(Token = "0x400A55E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isPlayingAnimation;

	[Token(Token = "0x6005A58")]
	[Address(RVA = "0x9F6E30", Offset = "0x9F6030", VA = "0x1809F6E30")]
	public DuelpassRewardPanelWidget(ElementObjectManager duelpassUIeom, [Optional] SelectionButton okButton)
	{
	}

	[Token(Token = "0x6005A59")]
	[Address(RVA = "0x9F6470", Offset = "0x9F5670", VA = "0x1809F6470")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x6005A5A")]
	[Address(RVA = "0x9F68D0", Offset = "0x9F5AD0", VA = "0x1809F68D0")]
	public void ReceiveFunctionOff()
	{
	}

	[Token(Token = "0x6005A5B")]
	[Address(RVA = "0x9F5BF0", Offset = "0x9F4DF0", VA = "0x1809F5BF0")]
	public void MoveToGradeBeforeDuel()
	{
	}

	[Token(Token = "0x6005A5C")]
	[Address(RVA = "0x9F58A0", Offset = "0x9F4AA0", VA = "0x1809F58A0")]
	public void MoveToAchievedGrade()
	{
	}

	[Token(Token = "0x6005A5D")]
	[Address(RVA = "0x9F60F0", Offset = "0x9F52F0", VA = "0x1809F60F0")]
	public void OnGradeUp(int grade)
	{
	}

	[Token(Token = "0x6005A5E")]
	[Address(RVA = "0x9F52A0", Offset = "0x9F44A0", VA = "0x1809F52A0")]
	private int GetAttentionEntityIdx(int grade)
	{
		return default(int);
	}

	[Token(Token = "0x6005A5F")]
	[Address(RVA = "0x9F6C50", Offset = "0x9F5E50", VA = "0x1809F6C50")]
	public void UpdateContents()
	{
	}

	[Token(Token = "0x6005A60")]
	[Address(RVA = "0x9F54F0", Offset = "0x9F46F0", VA = "0x1809F54F0")]
	private void MakeScrollEntityList()
	{
	}

	[Token(Token = "0x6005A61")]
	[Address(RVA = "0x9F5DF0", Offset = "0x9F4FF0", VA = "0x1809F5DF0")]
	private void OnEntityCreate(GameObject duplicatedTemplate)
	{
	}

	[Token(Token = "0x6005A62")]
	[Address(RVA = "0x9F5F20", Offset = "0x9F5120", VA = "0x1809F5F20")]
	private void OnEntityUpdate(GameObject duplicatedTemplate, int entityIdx)
	{
	}

	[Token(Token = "0x6005A63")]
	[Address(RVA = "0x9F5DD0", Offset = "0x9F4FD0", VA = "0x1809F5DD0")]
	private void OnClickBackButton()
	{
	}

	[Token(Token = "0x6005A64")]
	[Address(RVA = "0x9F5DE0", Offset = "0x9F4FE0", VA = "0x1809F5DE0")]
	private void OnClickNextButton()
	{
	}

	[Token(Token = "0x6005A65")]
	[Address(RVA = "0x9F6980", Offset = "0x9F5B80", VA = "0x1809F6980")]
	private void SnapPage(int dir)
	{
	}

	[Token(Token = "0x6005A66")]
	[Address(RVA = "0x9F68E0", Offset = "0x9F5AE0", VA = "0x1809F68E0")]
	[IteratorStateMachine(typeof(_003CSnapCoroutine_003Ed__34))]
	private IEnumerator SnapCoroutine(int snapSpan, [Optional] Action onCompleteAction)
	{
		return null;
	}

	[Token(Token = "0x6005A67")]
	[Address(RVA = "0x9F6C10", Offset = "0x9F5E10", VA = "0x1809F6C10")]
	public void UnLockGoldPass()
	{
	}

	[Token(Token = "0x6005A68")]
	[Address(RVA = "0x9F4F30", Offset = "0x9F4130", VA = "0x1809F4F30")]
	private IReadOnlyList<(SelectionItem, int, int)> CustomCollectSelectionItemsFunc(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6005A69")]
	[Address(RVA = "0x9F54E0", Offset = "0x9F46E0", VA = "0x1809F54E0")]
	private bool IsSelectableDataIndexFunc(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A6A")]
	[Address(RVA = "0x9F4B60", Offset = "0x9F3D60", VA = "0x1809F4B60")]
	private int CalcLeftEdge()
	{
		return default(int);
	}

	[Token(Token = "0x6005A6B")]
	[Address(RVA = "0x9F6500", Offset = "0x9F5700", VA = "0x1809F6500")]
	private void OnScrollValueChanged()
	{
	}

	[Token(Token = "0x6005A6C")]
	[Address(RVA = "0x9F6BA0", Offset = "0x9F5DA0", VA = "0x1809F6BA0")]
	public void StartProgress()
	{
	}

	[Token(Token = "0x6005A6D")]
	[Address(RVA = "0x9F50B0", Offset = "0x9F42B0", VA = "0x1809F50B0")]
	public void EndProgress()
	{
	}

	[Token(Token = "0x6005A6E")]
	[Address(RVA = "0x9F6D40", Offset = "0x9F5F40", VA = "0x1809F6D40")]
	private void UpdatePageButton()
	{
	}

	[Token(Token = "0x6005A6F")]
	[Address(RVA = "0x9F4BB0", Offset = "0x9F3DB0", VA = "0x1809F4BB0")]
	private int CalcRelativeIdx(int x)
	{
		return default(int);
	}

	[Token(Token = "0x6005A70")]
	[Address(RVA = "0x9F51A0", Offset = "0x9F43A0", VA = "0x1809F51A0")]
	private void FocusRelativePos(int diff, int y)
	{
	}

	[Token(Token = "0x6005A71")]
	[Address(RVA = "0x9F4C10", Offset = "0x9F3E10", VA = "0x1809F4C10")]
	private (int, int) CheckCurrentButtonPos()
	{
		return default((int, int));
	}
}
