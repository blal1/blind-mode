using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200046E")]
public class AnalogDirectionListener : MonoBehaviour
{
	[Token(Token = "0x40015A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly float k_Threshhold;

	[Token(Token = "0x40015A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private readonly int k_IntervalStepMax;

	[Token(Token = "0x40015A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SelectionItem m_SelectionItem;

	[Token(Token = "0x40015A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_OnlySelected;

	[Token(Token = "0x40015A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SelectorManager.AnalogType[] m_AnalogTypes;

	[Token(Token = "0x40015A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PadInputDirection m_CurrentInputDir;

	[Token(Token = "0x40015A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private SelectorManager.AnalogType m_CurrentAnalogType;

	[Token(Token = "0x40015AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int m_IntervalStep;

	[Token(Token = "0x40015AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float m_InputIntervalTime;

	[Token(Token = "0x40015AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action<SelectorManager.AnalogType, PadInputDirection> m_OnInputCallback;

	[Token(Token = "0x170002C4")]
	public SelectionItem selectionItem
	{
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C5")]
	public PadInputDirection currentInputDir
	{
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		get
		{
			return default(PadInputDirection);
		}
	}

	[Token(Token = "0x170002C6")]
	public SelectorManager.AnalogType currentAnalogType
	{
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x5FA7A0", Offset = "0x5F99A0", VA = "0x1805FA7A0")]
		get
		{
			return default(SelectorManager.AnalogType);
		}
	}

	[Token(Token = "0x170002C7")]
	public Action<SelectorManager.AnalogType, PadInputDirection> onInputCallback
	{
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		set
		{
		}
	}

	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0x5FA210", Offset = "0x5F9410", VA = "0x1805FA210")]
	public static AnalogDirectionListener Assign(GameObject owner, SelectionItem selectionItem, bool onlySelected = false, [Optional] Action<SelectorManager.AnalogType, PadInputDirection> onInputCallback, params SelectorManager.AnalogType[] analogTypes)
	{
		return null;
	}

	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0x5FA550", Offset = "0x5F9750", VA = "0x1805FA550")]
	private void Start()
	{
	}

	[Token(Token = "0x6001CA0")]
	[Address(RVA = "0x5FA2B0", Offset = "0x5F94B0", VA = "0x1805FA2B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0x5FA2B0", Offset = "0x5F94B0", VA = "0x1805FA2B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0x5FA2B0", Offset = "0x5F94B0", VA = "0x1805FA2B0")]
	private void Clear()
	{
	}

	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0x5FA500", Offset = "0x5F9700", VA = "0x1805FA500")]
	private void ResetInterval()
	{
	}

	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0x5FA300", Offset = "0x5F9500", VA = "0x1805FA300")]
	private float GetInputIntervalTime(int intervalStep)
	{
		return default(float);
	}

	[Token(Token = "0x6001CA5")]
	[Address(RVA = "0x5FA700", Offset = "0x5F9900", VA = "0x1805FA700")]
	private PadInputDirection VecToDirection(Vector2 vec)
	{
		return default(PadInputDirection);
	}

	[Token(Token = "0x6001CA6")]
	[Address(RVA = "0x5FA380", Offset = "0x5F9580", VA = "0x1805FA380")]
	private bool OnAnalogInput(Vector2 vec, SelectorManager.AnalogType analogType)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CA7")]
	[Address(RVA = "0x5FA780", Offset = "0x5F9980", VA = "0x1805FA780")]
	public AnalogDirectionListener()
	{
	}
}
