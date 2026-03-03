using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000125")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class PopupField<T> : BasePopupField<T, T>
{
	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId indexProperty;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int m_Index;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x17000188")]
	public override T value
	{
		[Token(Token = "0x6000920")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000921")]
		set
		{
		}
	}

	[Token(Token = "0x17000189")]
	[CreateProperty]
	public int index
	{
		[Token(Token = "0x6000923")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000924")]
		set
		{
		}
	}

	[Token(Token = "0x600091E")]
	internal override string GetValueToDisplay()
	{
		return null;
	}

	[Token(Token = "0x600091F")]
	internal override string GetListItemToDisplay(T value)
	{
		return null;
	}

	[Token(Token = "0x6000922")]
	public override void SetValueWithoutNotify(T newValue)
	{
	}

	[Token(Token = "0x6000925")]
	public PopupField([Optional] string label)
	{
	}

	[Token(Token = "0x6000926")]
	internal override void AddMenuItems(IGenericMenu menu)
	{
	}

	[Token(Token = "0x6000927")]
	private void ChangeValueFromMenu(T menuItem)
	{
	}
}
