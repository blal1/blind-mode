using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000071")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BaseCompositeField<TValueType, TField, TFieldValue> : BaseField<TValueType> where TField : TextValueField<TFieldValue>, new()
{
	[Token(Token = "0x2000072")]
	internal struct FieldDescription
	{
		[Token(Token = "0x2000073")]
		public delegate void WriteDelegate(ref TValueType val, TFieldValue fieldValue);

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x0")]
		internal readonly string name;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x0")]
		internal readonly string ussName;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x0")]
		internal readonly Func<TValueType, TFieldValue> read;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x0")]
		internal readonly WriteDelegate write;

		[Token(Token = "0x600041A")]
		public FieldDescription(string name, string ussName, Func<TValueType, TFieldValue> read, WriteDelegate write)
		{
		}
	}

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x0")]
	private List<TField> m_Fields;

	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x0")]
	private bool m_ShouldUpdateDisplay;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x0")]
	private bool m_ForceUpdateDisplay;

	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string spacerUssClassName;

	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string multilineVariantUssClassName;

	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string fieldGroupUssClassName;

	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string fieldUssClassName;

	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string firstFieldVariantUssClassName;

	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string twoLinesVariantUssClassName;

	[Token(Token = "0x6000412")]
	private VisualElement GetSpacer()
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	internal abstract FieldDescription[] DescribeFields();

	[Token(Token = "0x6000414")]
	protected BaseCompositeField(string label, int fieldsByLine)
	{
	}

	[Token(Token = "0x6000415")]
	private void UpdateDisplay()
	{
	}

	[Token(Token = "0x6000416")]
	public override void SetValueWithoutNotify(TValueType newValue)
	{
	}

	[Token(Token = "0x6000417")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6000418")]
	protected override void UpdateMixedValueContent()
	{
	}
}
