using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Deck;

[Token(Token = "0x200112C")]
public class FilterSlider : MonoBehaviour
{
	[Token(Token = "0x400B524")]
	[FieldOffset(Offset = "0x20")]
	private UnityAction m_ActionMinSlider;

	[Token(Token = "0x400B525")]
	[FieldOffset(Offset = "0x28")]
	private UnityAction m_ActionMaxSlider;

	[Token(Token = "0x400B526")]
	private const string k_ELabelSlider = "MinMaxSliderWidget/MinMaxSlider";

	[Token(Token = "0x400B527")]
	private const string INPUT_LABEL_MIN = "InputFieldMin";

	[Token(Token = "0x400B528")]
	private const string INPUT_LABEL_MAX = "InputFieldMax";

	[Token(Token = "0x400B529")]
	private const string INPUTOVERRIDE_LABEL = "OverrideText";

	[Token(Token = "0x400B52A")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400B52B")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_EomMin;

	[Token(Token = "0x400B52C")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_EomMax;

	[Token(Token = "0x400B52D")]
	[FieldOffset(Offset = "0x48")]
	private InputFieldWidget m_InputFieldWidgetMin;

	[Token(Token = "0x400B52E")]
	[FieldOffset(Offset = "0x50")]
	private InputFieldWidget m_InputFieldWidgetMax;

	[Token(Token = "0x400B52F")]
	[FieldOffset(Offset = "0x58")]
	private TMP_Text m_InputFieldOverrideTextMin;

	[Token(Token = "0x400B530")]
	[FieldOffset(Offset = "0x60")]
	private TMP_Text m_InputFieldOverrideTextMax;

	[Token(Token = "0x400B531")]
	[FieldOffset(Offset = "0x68")]
	private MinMaxSliderWidget m_Slider;

	[Token(Token = "0x400B532")]
	private const int m_MinValue = 0;

	[Token(Token = "0x400B533")]
	private const int m_MaxValue = 5000;

	[Token(Token = "0x400B534")]
	private const int m_MinQ = -100;

	[Token(Token = "0x400B535")]
	private const int m_MinLimit = -200;

	[Token(Token = "0x400B536")]
	private const int m_MaxLimit = 5100;

	[Token(Token = "0x400B537")]
	[FieldOffset(Offset = "0x70")]
	private bool isInitilaized;

	[Token(Token = "0x17001122")]
	public int NumMin
	{
		[Token(Token = "0x6006B9C")]
		[Address(RVA = "0x3EC970", Offset = "0x3EBB70", VA = "0x1803EC970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B9D")]
		[Address(RVA = "0x3EC980", Offset = "0x3EBB80", VA = "0x1803EC980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001123")]
	public int NumMax
	{
		[Token(Token = "0x6006B9E")]
		[Address(RVA = "0x55E5E0", Offset = "0x55D7E0", VA = "0x18055E5E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B9F")]
		[Address(RVA = "0x55E600", Offset = "0x55D800", VA = "0x18055E600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001124")]
	public SelectionButton m_ButtonMin
	{
		[Token(Token = "0x6006BA0")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006BA1")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001125")]
	public SelectionButton m_ButtonMax
	{
		[Token(Token = "0x6006BA2")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006BA3")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001126")]
	public MinMaxSliderWidget MinMaxSlider
	{
		[Token(Token = "0x6006BA4")]
		[Address(RVA = "0xB2DC90", Offset = "0xB2CE90", VA = "0x180B2DC90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006BA5")]
	[Address(RVA = "0xB2C910", Offset = "0xB2BB10", VA = "0x180B2C910")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6006BA6")]
	[Address(RVA = "0xB2CAB0", Offset = "0xB2BCB0", VA = "0x180B2CAB0")]
	public void Initialize(int minVal, int maxVal)
	{
	}

	[Token(Token = "0x6006BA7")]
	[Address(RVA = "0xB2C900", Offset = "0xB2BB00", VA = "0x180B2C900")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006BA8")]
	[Address(RVA = "0xB2D650", Offset = "0xB2C850", VA = "0x180B2D650")]
	private void Start()
	{
	}

	[Token(Token = "0x6006BA9")]
	[Address(RVA = "0xB2D4B0", Offset = "0xB2C6B0", VA = "0x180B2D4B0")]
	private void SetOnTextMin(int val)
	{
	}

	[Token(Token = "0x6006BAA")]
	[Address(RVA = "0xB2D310", Offset = "0xB2C510", VA = "0x180B2D310")]
	private void SetOnTextMax(int val)
	{
	}

	[Token(Token = "0x6006BAB")]
	[Address(RVA = "0xB2D2A0", Offset = "0xB2C4A0", VA = "0x180B2D2A0")]
	public void SetOnSliderMin(int val)
	{
	}

	[Token(Token = "0x6006BAC")]
	[Address(RVA = "0xB2D230", Offset = "0xB2C430", VA = "0x180B2D230")]
	public void SetOnSliderMax(int val)
	{
	}

	[Token(Token = "0x6006BAD")]
	[Address(RVA = "0xB2D090", Offset = "0xB2C290", VA = "0x180B2D090")]
	private float OnChangeValueMin(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6006BAE")]
	[Address(RVA = "0xB2CF20", Offset = "0xB2C120", VA = "0x180B2CF20")]
	private float OnChangeValueMax(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6006BAF")]
	[Address(RVA = "0xB2D200", Offset = "0xB2C400", VA = "0x180B2D200")]
	private int OnFixValue(int val)
	{
		return default(int);
	}

	[Token(Token = "0x6006BB0")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetCallbackMinSlider(UnityAction callback)
	{
	}

	[Token(Token = "0x6006BB1")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetCallbackMaxSlider(UnityAction callback)
	{
	}

	[Token(Token = "0x6006BB2")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FilterSlider()
	{
	}
}
