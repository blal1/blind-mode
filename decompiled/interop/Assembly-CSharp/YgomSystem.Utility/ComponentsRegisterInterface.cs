using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x2000398")]
public abstract class ComponentsRegisterInterface : MonoBehaviour
{
	[Token(Token = "0x1700023E")]
	public abstract IList targetObjs
	{
		[Token(Token = "0x60015F9")]
		get;
	}

	[Token(Token = "0x60015FA")]
	public abstract void CollectTargets(bool includeInactive = false);

	[Token(Token = "0x60015FB")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected ComponentsRegisterInterface()
	{
	}
}
