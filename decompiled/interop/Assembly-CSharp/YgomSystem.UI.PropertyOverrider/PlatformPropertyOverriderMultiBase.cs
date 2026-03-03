using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005BE")]
public abstract class PlatformPropertyOverriderMultiBase<Target> : PropertyOverriderBase<Target>, IPlatformPropertyOverrider where Target : Component
{
	[Token(Token = "0x4001BD1")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private Target m_Target;

	[Token(Token = "0x60025D8")]
	protected override Target GetTargetComponent()
	{
		return null;
	}

	[Token(Token = "0x60025D9")]
	protected PlatformPropertyOverriderMultiBase()
	{
	}
}
