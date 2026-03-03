using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x200024D")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BaseFieldMouseDragger
{
	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x2B27260", Offset = "0x2B26460", VA = "0x182B27260")]
	public void SetDragZone(VisualElement dragElement)
	{
	}

	[Token(Token = "0x6000FEA")]
	public abstract void SetDragZone(VisualElement dragElement, Rect hotZone);

	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected BaseFieldMouseDragger()
	{
	}
}
