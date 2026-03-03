using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x200024E")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class FieldMouseDragger<T> : BaseFieldMouseDragger
{
	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x0")]
	private readonly IValueField<T> m_DrivenField;

	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x0")]
	private VisualElement m_DragElement;

	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x0")]
	private Rect m_DragHotZone;

	[Token(Token = "0x170002E5")]
	public bool dragging
	{
		[Token(Token = "0x6000FED")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FEE")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002E6")]
	public T startValue
	{
		[Token(Token = "0x6000FEF")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000FEC")]
	public FieldMouseDragger(IValueField<T> drivenField)
	{
	}

	[Token(Token = "0x6000FF1")]
	public sealed override void SetDragZone(VisualElement dragElement, Rect hotZone)
	{
	}

	[Token(Token = "0x6000FF2")]
	private bool CanStartDrag(int button, Vector2 localPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF3")]
	private void UpdateValueOnPointerDown(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x6000FF4")]
	private void ProcessDownEvent(EventBase evt)
	{
	}

	[Token(Token = "0x6000FF5")]
	private void UpdateValueOnPointerMove(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x6000FF6")]
	private void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition)
	{
	}

	[Token(Token = "0x6000FF7")]
	private void UpdateValueOnPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x6000FF8")]
	private void ProcessUpEvent(EventBase evt, int pointerId)
	{
	}

	[Token(Token = "0x6000FF9")]
	private void UpdateValueOnKeyDown(KeyDownEvent evt)
	{
	}
}
