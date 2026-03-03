using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000618")]
public class MinMaxSliderWidget : ElementWidgetBehaviourBase<MinMaxSliderWidget>
{
	[Token(Token = "0x2000619")]
	public enum StepType
	{
		[Token(Token = "0x4001D73")]
		Smooth,
		[Token(Token = "0x4001D74")]
		Step,
		[Token(Token = "0x4001D75")]
		StepSmooth
	}

	[Token(Token = "0x4001D55")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Tooltip("Pad操作時のスライダーの動作")]
	private StepType m_StepType;

	[Token(Token = "0x4001D56")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string k_ELabelSlider_Min;

	[Token(Token = "0x4001D57")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string k_ELabelSlider_Max;

	[Token(Token = "0x4001D58")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("スライダー減少のボタン")]
	private SelectorManager.KeyType subButton;

	[Token(Token = "0x4001D59")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Tooltip("スライダー増加のボタン")]
	private SelectorManager.KeyType addButton;

	[Token(Token = "0x4001D5A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Tooltip("選択中にMinスライダーを操作")]
	private SelectionButton selectionButton_Min;

	[Token(Token = "0x4001D5B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Tooltip("選択中にMaxスライダーを操作")]
	private SelectionButton selectionButton_Max;

	[Token(Token = "0x4001D5C")]
	[FieldOffset(Offset = "0x58")]
	[Header("[スライダーのデフォルト値]")]
	[SerializeField]
	private Slider.Direction direction;

	[Token(Token = "0x4001D5D")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private bool wholeNumbers;

	[Token(Token = "0x4001D5F")]
	[FieldOffset(Offset = "0x60")]
	private float m_SlideStepSmoothTime;

	[Token(Token = "0x4001D60")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float m_SlideStepSmoothLimit;

	[Token(Token = "0x4001D61")]
	[FieldOffset(Offset = "0x68")]
	public float MinValue;

	[Token(Token = "0x4001D62")]
	[FieldOffset(Offset = "0x6C")]
	public float MaxValue;

	[Token(Token = "0x4001D63")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float m_SlideStepSize;

	[Token(Token = "0x4001D64")]
	private const string k_ELabelShortcutIconGroup_Min = "MinSliderShortcutIconGroup";

	[Token(Token = "0x4001D65")]
	private const string k_ELabelShortcutIconGroup_Max = "MaxSliderShortcutIconGroup";

	[Token(Token = "0x4001D66")]
	private const string k_ELabelHighLightHandle_Min = "MinHighLightHandle";

	[Token(Token = "0x4001D67")]
	private const string k_ELabelHighLightHandle_Max = "MaxHighLightHandle";

	[Token(Token = "0x4001D68")]
	[FieldOffset(Offset = "0x74")]
	private bool m_StartSlide;

	[Token(Token = "0x4001D69")]
	[FieldOffset(Offset = "0x75")]
	private bool m_OneInputEnable;

	[Token(Token = "0x4001D6A")]
	[FieldOffset(Offset = "0x76")]
	private bool m_SmoothEnable;

	[Token(Token = "0x4001D6B")]
	[FieldOffset(Offset = "0x78")]
	private float m_SmoothValue;

	[Token(Token = "0x4001D6C")]
	[FieldOffset(Offset = "0x80")]
	private Slider m_SliderCache_Min;

	[Token(Token = "0x4001D6D")]
	[FieldOffset(Offset = "0x88")]
	private Slider m_SliderCache_Max;

	[Token(Token = "0x4001D6E")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_ShortcutIconGroup_Min;

	[Token(Token = "0x4001D6F")]
	[FieldOffset(Offset = "0x98")]
	private GameObject m_ShortcutIconGroup_Max;

	[Token(Token = "0x4001D70")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_HighLightHandle_Min;

	[Token(Token = "0x4001D71")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_HighLightHandle_Max;

	[Token(Token = "0x170004FF")]
	public bool enableStep
	{
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x6ADBD0", Offset = "0x6ACDD0", VA = "0x1806ADBD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x6ADD60", Offset = "0x6ACF60", VA = "0x1806ADD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000500")]
	public Slider slider_Min
	{
		[Token(Token = "0x6002819")]
		[Address(RVA = "0x6ADCA0", Offset = "0x6ACEA0", VA = "0x1806ADCA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000501")]
	public Slider slider_Max
	{
		[Token(Token = "0x600281A")]
		[Address(RVA = "0x6ADBE0", Offset = "0x6ACDE0", VA = "0x1806ADBE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600281B")]
	[Address(RVA = "0x6ACD50", Offset = "0x6ABF50", VA = "0x1806ACD50")]
	private void Awake()
	{
	}

	[Token(Token = "0x600281C")]
	[Address(RVA = "0x6AD630", Offset = "0x6AC830", VA = "0x1806AD630")]
	private void Start()
	{
	}

	[Token(Token = "0x600281D")]
	[Address(RVA = "0x6AD480", Offset = "0x6AC680", VA = "0x1806AD480")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x600281E")]
	[Address(RVA = "0x6ACD50", Offset = "0x6ABF50", VA = "0x1806ACD50")]
	private void SliderInitialize()
	{
	}

	[Token(Token = "0x600281F")]
	[Address(RVA = "0x6ACE70", Offset = "0x6AC070", VA = "0x1806ACE70")]
	private void ButtonCallback()
	{
	}

	[Token(Token = "0x6002820")]
	[Address(RVA = "0x6ADB20", Offset = "0x6ACD20", VA = "0x1806ADB20")]
	public MinMaxSliderWidget()
	{
	}
}
