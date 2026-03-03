using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000600")]
internal class ColumnResizer : PointerManipulator
{
	[Token(Token = "0x4001613")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 m_Start;

	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_Active;

	[Token(Token = "0x4001615")]
	[FieldOffset(Offset = "0x31")]
	private bool m_Resizing;

	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0x38")]
	private MultiColumnCollectionHeader m_Header;

	[Token(Token = "0x4001617")]
	[FieldOffset(Offset = "0x40")]
	private Column m_Column;

	[Token(Token = "0x4001618")]
	[FieldOffset(Offset = "0x48")]
	private VisualElement m_PreviewElement;

	[Token(Token = "0x17000AC6")]
	public ColumnLayout columnLayout
	{
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AC7")]
	public bool preview
	{
		[Token(Token = "0x60029D1")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60029D3")]
	[Address(RVA = "0x2A94BC0", Offset = "0x2A93DC0", VA = "0x182A94BC0")]
	public ColumnResizer(Column column)
	{
	}

	[Token(Token = "0x60029D4")]
	[Address(RVA = "0x2A94680", Offset = "0x2A93880", VA = "0x182A94680", Slot = "5")]
	protected override void RegisterCallbacksOnTarget()
	{
	}

	[Token(Token = "0x60029D5")]
	[Address(RVA = "0x2A94880", Offset = "0x2A93A80", VA = "0x182A94880", Slot = "6")]
	protected override void UnregisterCallbacksFromTarget()
	{
	}

	[Token(Token = "0x60029D6")]
	[Address(RVA = "0x2A93F50", Offset = "0x2A93150", VA = "0x182A93F50")]
	private void OnKeyDown(KeyDownEvent e)
	{
	}

	[Token(Token = "0x60029D7")]
	[Address(RVA = "0x2A93FF0", Offset = "0x2A931F0", VA = "0x182A93FF0")]
	private void OnPointerDown(PointerDownEvent e)
	{
	}

	[Token(Token = "0x60029D8")]
	[Address(RVA = "0x2A94390", Offset = "0x2A93590", VA = "0x182A94390")]
	private void OnPointerMove(PointerMoveEvent e)
	{
	}

	[Token(Token = "0x60029D9")]
	[Address(RVA = "0x2A944E0", Offset = "0x2A936E0", VA = "0x182A944E0")]
	private void OnPointerUp(PointerUpEvent e)
	{
	}

	[Token(Token = "0x60029DA")]
	[Address(RVA = "0x2A93E40", Offset = "0x2A93040", VA = "0x182A93E40")]
	private void BeginDragResize(float pos)
	{
	}

	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x2A93E90", Offset = "0x2A93090", VA = "0x182A93E90")]
	private void DragResize(float pos)
	{
	}

	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x2A94A80", Offset = "0x2A93C80", VA = "0x182A94A80")]
	private void UpdatePreviewPosition()
	{
	}

	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x2A93EE0", Offset = "0x2A930E0", VA = "0x182A93EE0")]
	private void EndDragResize(float pos, bool cancelled)
	{
	}
}
