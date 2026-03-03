using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Pool;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000131")]
public class RadioButtonGroup : BaseField<int>, IGroupBox
{
	[Token(Token = "0x2000132")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
	{
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x2AEF5F0", Offset = "0x2AEE7F0", VA = "0x182AEF5F0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000133")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UxmlStringAttributeDescription m_Choices;

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x2AF1980", Offset = "0x2AF0B80", VA = "0x182AF1980", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x2AF2D20", Offset = "0x2AF1F20", VA = "0x182AF2D20")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class _003Cget_choices_003Ed__17 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _003C_003E2__current;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RadioButtonGroup _003C_003E4__this;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PooledObject<List<RadioButton>> _003C__003E5__1;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<RadioButton> _003CradioButtons_003E5__2;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<RadioButton>.Enumerator _003C_003Es__3;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RadioButton _003Cbutton_003E5__4;

		[Token(Token = "0x17000193")]
		private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000194")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x59ED60", Offset = "0x59DF60", VA = "0x18059ED60")]
		[DebuggerHidden]
		public _003Cget_choices_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x2AEF3D0", Offset = "0x2AEE5D0", VA = "0x182AEF3D0", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x2AEF010", Offset = "0x2AEE210", VA = "0x182AEF010", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x2AEF4D0", Offset = "0x2AEE6D0", VA = "0x182AEF4D0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x2AEF520", Offset = "0x2AEE720", VA = "0x182AEF520")]
		private void _003C_003Em__Finally2()
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x2AEF390", Offset = "0x2AEE590", VA = "0x182AEF390", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x2AEF2F0", Offset = "0x2AEE4F0", VA = "0x182AEF2F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2AEF2F0", Offset = "0x2AEE4F0", VA = "0x182AEF2F0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId choicesProperty;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static readonly string containerUssClassName;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	internal static readonly string containerName;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	internal static readonly string choicesContainerName;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
	private VisualElement m_ChoiceRadioButtonContainer;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
	private VisualElement m_ContentContainer;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
	private UQueryBuilder<RadioButton> m_GetAllRadioButtonsQuery;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
	private readonly List<RadioButton> m_RegisteredRadioButtons;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
	private RadioButton m_SelectedRadioButton;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
	private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
	private bool m_UpdatingButtons;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
	private List<string> m_Choices;

	[Token(Token = "0x17000190")]
	[CreateProperty]
	public IEnumerable<string> choices
	{
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x2ADEBD0", Offset = "0x2ADDDD0", VA = "0x182ADEBD0")]
		[IteratorStateMachine(typeof(_003Cget_choices_003Ed__17))]
		get
		{
			return null;
		}
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x2ADEC80", Offset = "0x2ADDE80", VA = "0x182ADEC80")]
		set
		{
		}
	}

	[Token(Token = "0x17000191")]
	internal List<string> choicesList
	{
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x2ADEC70", Offset = "0x2ADDE70", VA = "0x182ADEC70")]
		set
		{
		}
	}

	[Token(Token = "0x17000192")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x2ADEC50", Offset = "0x2ADDE50", VA = "0x182ADEC50", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000954")]
	[Address(RVA = "0x2ADD270", Offset = "0x2ADC470", VA = "0x182ADD270")]
	private void RebuildRadioButtonsFromChoices()
	{
	}

	[Token(Token = "0x6000957")]
	[Address(RVA = "0x2ADEBC0", Offset = "0x2ADDDC0", VA = "0x182ADEBC0")]
	public RadioButtonGroup()
	{
	}

	[Token(Token = "0x6000958")]
	[Address(RVA = "0x2ADE7A0", Offset = "0x2ADD9A0", VA = "0x182ADE7A0")]
	public RadioButtonGroup(string label, [Optional] List<string> radioButtonChoices)
	{
	}

	[Token(Token = "0x6000959")]
	[Address(RVA = "0x2ADD010", Offset = "0x2ADC210", VA = "0x182ADD010")]
	private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt)
	{
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0x2ADD920", Offset = "0x2ADCB20", VA = "0x182ADD920", Slot = "155")]
	public override void SetValueWithoutNotify(int newValue)
	{
	}

	[Token(Token = "0x600095B")]
	[Address(RVA = "0x2ADCF40", Offset = "0x2ADC140", VA = "0x182ADCF40")]
	private void GetAllRadioButtons(List<RadioButton> radioButtons)
	{
	}

	[Token(Token = "0x600095C")]
	[Address(RVA = "0x2ADE030", Offset = "0x2ADD230", VA = "0x182ADE030")]
	private void UpdateRadioButtons(bool notify)
	{
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0x2ADD860", Offset = "0x2ADCA60", VA = "0x182ADD860")]
	private void ScheduleRadioButtons()
	{
	}

	[Token(Token = "0x600095E")]
	[Address(RVA = "0x2ADD550", Offset = "0x2ADC750", VA = "0x182ADD550")]
	private void RegisterRadioButton(RadioButton radioButton)
	{
	}

	[Token(Token = "0x600095F")]
	[Address(RVA = "0x2ADDF70", Offset = "0x2ADD170", VA = "0x182ADDF70")]
	private void UnregisterRadioButton(RadioButton radioButton)
	{
	}

	[Token(Token = "0x6000960")]
	[Address(RVA = "0x2ADDD10", Offset = "0x2ADCF10", VA = "0x182ADDD10", Slot = "156")]
	private void UnityEngine_002EUIElements_002EIGroupBox_002EOnOptionAdded(IGroupBoxOption option)
	{
	}

	[Token(Token = "0x6000961")]
	[Address(RVA = "0x2ADDDD0", Offset = "0x2ADCFD0", VA = "0x182ADDDD0", Slot = "157")]
	private void UnityEngine_002EUIElements_002EIGroupBox_002EOnOptionRemoved(IGroupBoxOption option)
	{
	}
}
