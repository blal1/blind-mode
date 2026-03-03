using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x2000399")]
public abstract class ComponentsRegisterBase<T> : ComponentsRegisterInterface where T : Behaviour
{
	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected List<T> m_Targets;

	[Token(Token = "0x1700023F")]
	public List<T> targets
	{
		[Token(Token = "0x60015FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000240")]
	public override IList targetObjs
	{
		[Token(Token = "0x60015FD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60015FE")]
	public override void CollectTargets(bool includeInactive = false)
	{
	}

	[Token(Token = "0x60015FF")]
	protected ComponentsRegisterBase()
	{
	}
}
