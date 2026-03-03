using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F93")]
public class DiceRallyMiniMap
{
	[Token(Token = "0x2000F94")]
	[CompilerGenerated]
	private sealed class _003CyZoomRange_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A90A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A90B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A90C")]
		[FieldOffset(Offset = "0x20")]
		public DiceRallyMiniMap _003C_003E4__this;

		[Token(Token = "0x400A90D")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 originPos;

		[Token(Token = "0x400A90E")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 targetPos;

		[Token(Token = "0x400A90F")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 targetSize;

		[Token(Token = "0x17000EE8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005E94")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005E96")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E91")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyZoomRange_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005E92")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005E93")]
		[Address(RVA = "0xA4EB10", Offset = "0xA4DD10", VA = "0x180A4EB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E95")]
		[Address(RVA = "0xA4EDF0", Offset = "0xA4DFF0", VA = "0x180A4EDF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A8FA")]
	[FieldOffset(Offset = "0x10")]
	private readonly string LABEL_ON;

	[Token(Token = "0x400A8FB")]
	[FieldOffset(Offset = "0x18")]
	private readonly string LABEL_OFF;

	[Token(Token = "0x400A8FC")]
	[FieldOffset(Offset = "0x20")]
	private readonly string LABEL_RANGE;

	[Token(Token = "0x400A8FD")]
	[FieldOffset(Offset = "0x28")]
	private readonly string LABEL_TMP_SPACE;

	[Token(Token = "0x400A8FE")]
	[FieldOffset(Offset = "0x30")]
	private readonly string LABEL_TMP_EDGE;

	[Token(Token = "0x400A8FF")]
	[FieldOffset(Offset = "0x38")]
	private readonly string LABEL_TWEEN_ZOOM;

	[Token(Token = "0x400A900")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurrentIndex;

	[Token(Token = "0x400A901")]
	[FieldOffset(Offset = "0x44")]
	private float m_Ratio;

	[Token(Token = "0x400A902")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 m_RangeSizeOrigin;

	[Token(Token = "0x400A903")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 m_ScreenPos;

	[Token(Token = "0x400A904")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 m_Diff;

	[Token(Token = "0x400A905")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_Area;

	[Token(Token = "0x400A906")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_Range;

	[Token(Token = "0x400A907")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform m_Rect;

	[Token(Token = "0x400A908")]
	[FieldOffset(Offset = "0x78")]
	private RectTransform m_RangeRect;

	[Token(Token = "0x400A909")]
	[FieldOffset(Offset = "0x80")]
	private List<GameObject> m_SpaceList;

	[Token(Token = "0x6005E7D")]
	[Address(RVA = "0xA35430", Offset = "0xA34630", VA = "0x180A35430")]
	public DiceRallyMiniMap(GameObject area)
	{
	}

	[Token(Token = "0x6005E7E")]
	[Address(RVA = "0xA349E0", Offset = "0xA33BE0", VA = "0x180A349E0")]
	public void Create(List<DiceRallySpace> spaceList, DiceRallySpace currentSpace, Vector2 screenMax, Vector2 screenMin, Vector2 screenSizeOrigin)
	{
	}

	[Token(Token = "0x6005E7F")]
	[Address(RVA = "0xA35040", Offset = "0xA34240", VA = "0x180A35040")]
	public Vector2 GetPos()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005E80")]
	[Address(RVA = "0xA350E0", Offset = "0xA342E0", VA = "0x180A350E0")]
	public Vector2 GetSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005E81")]
	[Address(RVA = "0xA350C0", Offset = "0xA342C0", VA = "0x180A350C0")]
	public Vector2 GetRangeSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005E82")]
	[Address(RVA = "0xA350A0", Offset = "0xA342A0", VA = "0x180A350A0")]
	public Vector2 GetRangeSizeOrigin()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005E83")]
	[Address(RVA = "0xA35060", Offset = "0xA34260", VA = "0x180A35060")]
	public Vector3 GetRangePos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005E84")]
	[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
	public List<GameObject> GetList()
	{
		return null;
	}

	[Token(Token = "0x6005E85")]
	[Address(RVA = "0xA35100", Offset = "0xA34300", VA = "0x180A35100")]
	public GameObject GetSpace(int index)
	{
		return null;
	}

	[Token(Token = "0x6005E86")]
	[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
	public int GetCurrentIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6005E87")]
	[Address(RVA = "0x416670", Offset = "0x415870", VA = "0x180416670")]
	public float GetRatio()
	{
		return default(float);
	}

	[Token(Token = "0x6005E88")]
	[Address(RVA = "0xA35180", Offset = "0xA34380", VA = "0x180A35180")]
	public TweenPosition GetTween(string label)
	{
		return null;
	}

	[Token(Token = "0x6005E89")]
	[Address(RVA = "0xA35300", Offset = "0xA34500", VA = "0x180A35300")]
	public void SetPos(Vector2 pos, bool keepX = false, bool keepY = false)
	{
	}

	[Token(Token = "0x6005E8A")]
	[Address(RVA = "0xA352F0", Offset = "0xA344F0", VA = "0x180A352F0")]
	public void SetDiff(Vector2 pos)
	{
	}

	[Token(Token = "0x6005E8B")]
	[Address(RVA = "0xA35410", Offset = "0xA34610", VA = "0x180A35410")]
	public void SetRangeSize(Vector2 pos)
	{
	}

	[Token(Token = "0x6005E8C")]
	[Address(RVA = "0xA35360", Offset = "0xA34560", VA = "0x180A35360")]
	public void SetRangePos(Vector2 pos, bool xKeep = false, bool yKeep = false)
	{
	}

	[Token(Token = "0x6005E8D")]
	[Address(RVA = "0x4166D0", Offset = "0x4158D0", VA = "0x1804166D0")]
	public void SetRatio(float ratio)
	{
	}

	[Token(Token = "0x6005E8E")]
	[Address(RVA = "0xA35260", Offset = "0xA34460", VA = "0x180A35260")]
	public void SetAreaActive(bool active)
	{
	}

	[Token(Token = "0x6005E8F")]
	[Address(RVA = "0xA34900", Offset = "0xA33B00", VA = "0x180A34900")]
	public void ChangeColor(GameObject obj, int index, bool isOn)
	{
	}

	[Token(Token = "0x6005E90")]
	[Address(RVA = "0xA35560", Offset = "0xA34760", VA = "0x180A35560")]
	[IteratorStateMachine(typeof(_003CyZoomRange_003Ed__35))]
	public IEnumerator yZoomRange(Vector3 originPos, Vector3 targetPos, Vector3 targetSize)
	{
		return null;
	}
}
