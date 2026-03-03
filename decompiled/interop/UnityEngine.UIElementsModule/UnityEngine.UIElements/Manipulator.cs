using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000278")]
public abstract class Manipulator : IManipulator
{
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x10")]
	private VisualElement m_Target;

	[Token(Token = "0x17000333")]
	public VisualElement target
	{
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x1B5CB80", Offset = "0x1B5BD80", VA = "0x181B5CB80", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x2B33D10", Offset = "0x2B32F10", VA = "0x182B33D10", Slot = "4")]
		set
		{
		}
	}

	[Token(Token = "0x6001132")]
	protected abstract void RegisterCallbacksOnTarget();

	[Token(Token = "0x6001133")]
	protected abstract void UnregisterCallbacksFromTarget();

	[Token(Token = "0x6001136")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected Manipulator()
	{
	}
}
