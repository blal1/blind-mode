using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000079")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BasePopupField<TValueType, TValueChoice> : BaseField<TValueType>
{
	[Token(Token = "0x200007A")]
	private class PopupTextElement : TextElement
	{
		[Token(Token = "0x6000473")]
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000474")]
		public PopupTextElement()
		{
		}
	}

	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId choicesProperty;

	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId textProperty;

	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x0")]
	internal List<TValueChoice> m_Choices;

	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x0")]
	private TextElement m_TextElement;

	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x0")]
	private VisualElement m_ArrowElement;

	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x0")]
	private IVisualElementScheduledItem m_ScheduledShowMenuItem;

	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x0")]
	internal Func<TValueChoice, string> m_FormatSelectedValueCallback;

	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x0")]
	internal Func<TValueChoice, string> m_FormatListItemCallback;

	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x0")]
	internal Func<IGenericMenu> createMenuCallback;

	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x0")]
	internal IGenericMenu m_GenericMenu;

	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x0")]
	internal bool m_AutoCloseMenu;

	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string textUssClassName;

	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string arrowUssClassName;

	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x170000A2")]
	protected TextElement textElement
	{
		[Token(Token = "0x6000461")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A3")]
	[CreateProperty]
	public virtual List<TValueChoice> choices
	{
		[Token(Token = "0x6000465")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000466")]
		set
		{
		}
	}

	[Token(Token = "0x170000A4")]
	[CreateProperty(ReadOnly = true)]
	public string text
	{
		[Token(Token = "0x6000468")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000462")]
	internal abstract string GetValueToDisplay();

	[Token(Token = "0x6000463")]
	internal abstract string GetListItemToDisplay(TValueType item);

	[Token(Token = "0x6000464")]
	internal abstract void AddMenuItems(IGenericMenu menu);

	[Token(Token = "0x6000467")]
	public override void SetValueWithoutNotify(TValueType newValue)
	{
	}

	[Token(Token = "0x6000469")]
	internal BasePopupField(string label)
	{
	}

	[Token(Token = "0x600046A")]
	private void OnPointerDownEvent(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x600046B")]
	private void OnPointerUpEvent(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x600046C")]
	private void OnPointerMoveEvent(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x600046D")]
	private bool ContainsPointer(int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x600046E")]
	private void ProcessPointerDown<T>(PointerEventBase<T> evt) where T : PointerEventBase<T>, new()
	{
	}

	[Token(Token = "0x600046F")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	[Token(Token = "0x6000470")]
	internal void ShowMenu()
	{
	}

	[Token(Token = "0x6000471")]
	protected override void UpdateMixedValueContent()
	{
	}
}
