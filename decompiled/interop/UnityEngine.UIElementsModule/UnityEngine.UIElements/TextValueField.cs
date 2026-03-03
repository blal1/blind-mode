using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x200015A")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class TextValueField<TValueType> : TextInputBaseField<TValueType>, IValueField<TValueType>
{
	[Token(Token = "0x200015B")]
	protected abstract class TextValueInput : TextInputBase
	{
		[Token(Token = "0x170001CB")]
		private TextValueField<TValueType> textValueFieldParent
		{
			[Token(Token = "0x6000A8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CC")]
		protected abstract string allowedCharacters
		{
			[Token(Token = "0x6000A8F")]
			get;
		}

		[Token(Token = "0x170001CD")]
		public string formatString
		{
			[Token(Token = "0x6000A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A91")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000A8D")]
		protected TextValueInput()
		{
		}

		[Token(Token = "0x6000A8E")]
		internal override bool AcceptCharacter(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A92")]
		public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);

		[Token(Token = "0x6000A93")]
		public void StartDragging()
		{
		}

		[Token(Token = "0x6000A94")]
		public void StopDragging()
		{
		}

		[Token(Token = "0x6000A95")]
		protected abstract string ValueToString(TValueType value);

		[Token(Token = "0x6000A96")]
		protected override TValueType StringToValue(string str)
		{
			return (TValueType)null;
		}
	}

	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId formatStringProperty;

	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x0")]
	private BaseFieldMouseDragger m_Dragger;

	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x0")]
	private bool m_ForceUpdateDisplay;

	[Token(Token = "0x170001C9")]
	private TextValueInput textValueInput
	{
		[Token(Token = "0x6000A79")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001CA")]
	[CreateProperty]
	public string formatString
	{
		[Token(Token = "0x6000A7A")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A7B")]
		set
		{
		}
	}

	[Token(Token = "0x6000A7C")]
	protected TextValueField(string label, int maxLength, TextValueInput textValueInput)
	{
	}

	[Token(Token = "0x6000A7D")]
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);

	[Token(Token = "0x6000A7E")]
	public void StartDragging()
	{
	}

	[Token(Token = "0x6000A7F")]
	public void StopDragging()
	{
	}

	[Token(Token = "0x6000A80")]
	internal override void UpdateValueFromText()
	{
	}

	[Token(Token = "0x6000A81")]
	internal override void UpdateTextFromValue()
	{
	}

	[Token(Token = "0x6000A82")]
	private void OnIsReadOnlyChanged(bool newValue)
	{
	}

	[Token(Token = "0x6000A83")]
	internal virtual bool CanTryParse(string textString)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A84")]
	protected void AddLabelDragger<TDraggerType>()
	{
	}

	[Token(Token = "0x6000A85")]
	private void EnableLabelDragger(bool enable)
	{
	}

	[Token(Token = "0x6000A86")]
	public override void SetValueWithoutNotify(TValueType newValue)
	{
	}

	[Token(Token = "0x6000A87")]
	[EventInterest(new Type[]
	{
		typeof(BlurEvent),
		typeof(FocusEvent)
	})]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x6000A88")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6000A89")]
	internal override void RegisterEditingCallbacks()
	{
	}

	[Token(Token = "0x6000A8A")]
	internal override void UnregisterEditingCallbacks()
	{
	}
}
