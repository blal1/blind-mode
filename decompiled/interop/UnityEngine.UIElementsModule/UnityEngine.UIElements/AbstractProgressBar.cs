using System;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200012A")]
public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float>
{
	[Token(Token = "0x200012B")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x90")]
		private UxmlFloatAttributeDescription m_LowValue;

		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x98")]
		private UxmlFloatAttributeDescription m_HighValue;

		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_Value;

		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlStringAttributeDescription m_Title;

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x2AF1AD0", Offset = "0x2AF0CD0", VA = "0x182AF1AD0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x2AF3430", Offset = "0x2AF2630", VA = "0x182AF3430")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId titleProperty;

	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId lowValueProperty;

	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId highValueProperty;

	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId valueProperty;

	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x260")]
	public static readonly string ussClassName;

	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x268")]
	public static readonly string containerUssClassName;

	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x270")]
	public static readonly string titleUssClassName;

	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x278")]
	public static readonly string titleContainerUssClassName;

	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x280")]
	public static readonly string progressUssClassName;

	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0x288")]
	public static readonly string backgroundUssClassName;

	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x4B8")]
	private readonly VisualElement m_Background;

	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x4C0")]
	private readonly VisualElement m_Progress;

	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x4C8")]
	private readonly Label m_Title;

	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x4D0")]
	private float m_LowValue;

	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x4D4")]
	private float m_HighValue;

	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x4D8")]
	private float m_Value;

	[Token(Token = "0x1700018B")]
	[CreateProperty]
	public string title
	{
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x2ADAD00", Offset = "0x2AD9F00", VA = "0x182ADAD00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x2ADAEC0", Offset = "0x2ADA0C0", VA = "0x182ADAEC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700018C")]
	[CreateProperty]
	public float lowValue
	{
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x2ADACF0", Offset = "0x2AD9EF0", VA = "0x182ADACF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x2ADAE00", Offset = "0x2ADA000", VA = "0x182ADAE00")]
		set
		{
		}
	}

	[Token(Token = "0x1700018D")]
	[CreateProperty]
	public float highValue
	{
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x2ADACE0", Offset = "0x2AD9EE0", VA = "0x182ADACE0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x2ADAD40", Offset = "0x2AD9F40", VA = "0x182ADAD40")]
		set
		{
		}
	}

	[Token(Token = "0x1700018E")]
	[CreateProperty]
	public virtual float value
	{
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x2ADAD30", Offset = "0x2AD9F30", VA = "0x182ADAD30", Slot = "142")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x2ADAFC0", Offset = "0x2ADA1C0", VA = "0x182ADAFC0", Slot = "143")]
		set
		{
		}
	}

	[Token(Token = "0x6000936")]
	[Address(RVA = "0x2ADA990", Offset = "0x2AD9B90", VA = "0x182ADA990")]
	public AbstractProgressBar()
	{
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0x2ADA220", Offset = "0x2AD9420", VA = "0x182ADA220")]
	private void OnGeometryChanged(GeometryChangedEvent e)
	{
	}

	[Token(Token = "0x600093A")]
	[Address(RVA = "0x2ADA3B0", Offset = "0x2AD95B0", VA = "0x182ADA3B0", Slot = "141")]
	public void SetValueWithoutNotify(float newValue)
	{
	}

	[Token(Token = "0x600093B")]
	[Address(RVA = "0x2ADA250", Offset = "0x2AD9450", VA = "0x182ADA250")]
	private void SetProgress(float p)
	{
	}

	[Token(Token = "0x600093C")]
	[Address(RVA = "0x2ADA030", Offset = "0x2AD9230", VA = "0x182ADA030")]
	private float CalculateOppositeProgressWidth(float width)
	{
		return default(float);
	}
}
