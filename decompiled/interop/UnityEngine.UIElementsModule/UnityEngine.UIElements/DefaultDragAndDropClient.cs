using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000190")]
internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop
{
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x18")]
	private readonly Hashtable m_GenericData;

	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x20")]
	private Label m_DraggedInfoLabel;

	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x28")]
	private DragVisualMode m_VisualMode;

	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x30")]
	private IEnumerable<Object> m_UnityObjectReferences;

	[Token(Token = "0x17000219")]
	public override object source
	{
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x2AF5200", Offset = "0x2AF4400", VA = "0x182AF5200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021A")]
	public DragAndDropData data
	{
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x52BB60", Offset = "0x52AD60", VA = "0x18052BB60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x2AF48D0", Offset = "0x2AF3AD0", VA = "0x182AF48D0", Slot = "4")]
	public override object GetGenericData(string key)
	{
		return null;
	}

	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x2AF4940", Offset = "0x2AF3B40", VA = "0x182AF4940", Slot = "7")]
	public void StartDrag(StartDragArgs args, Vector3 pointerPosition)
	{
	}

	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x2AF4FB0", Offset = "0x2AF41B0", VA = "0x182AF4FB0", Slot = "8")]
	public void UpdateDrag(Vector3 pointerPosition)
	{
	}

	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public void AcceptDrag()
	{
	}

	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240", Slot = "11")]
	public void SetVisualMode(DragVisualMode mode)
	{
	}

	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x2AF4860", Offset = "0x2AF3A60", VA = "0x182AF4860", Slot = "10")]
	public void DragCleanup()
	{
	}

	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x2AF5190", Offset = "0x2AF4390", VA = "0x182AF5190")]
	public DefaultDragAndDropClient()
	{
	}
}
