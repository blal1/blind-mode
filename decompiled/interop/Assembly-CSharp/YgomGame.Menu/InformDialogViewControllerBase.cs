using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu;

[Token(Token = "0x2001253")]
public abstract class InformDialogViewControllerBase : DialogViewControllerBase
{
	[Token(Token = "0x600723F")]
	[Address(RVA = "0xB95290", Offset = "0xB94490", VA = "0x180B95290")]
	protected static void InnerOpen(string prefabPath, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007240")]
	[Address(RVA = "0xB952F0", Offset = "0xB944F0", VA = "0x180B952F0")]
	protected static void InnerOpen(GameObject prefab, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007241")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	protected InformDialogViewControllerBase()
	{
	}
}
[Token(Token = "0x2001254")]
public abstract class InformDialogViewControllerBase<ARG> : InformDialogViewControllerBase
{
	[Token(Token = "0x400BB25")]
	protected const string k_DefaultArgkey1 = "arg1";

	[Token(Token = "0x17001206")]
	protected virtual ARG arg1
	{
		[Token(Token = "0x6007242")]
		get
		{
			return (ARG)null;
		}
	}

	[Token(Token = "0x6007243")]
	protected static void InnerOpen(string prefabPath, ARG arg, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007244")]
	protected static void InnerOpen(GameObject prefab, ARG arg, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007245")]
	protected InformDialogViewControllerBase()
	{
	}
}
[Token(Token = "0x2001255")]
public abstract class InformDialogViewControllerBase<ARG1, ARG2> : InformDialogViewControllerBase<ARG1>
{
	[Token(Token = "0x400BB26")]
	protected const string k_DefaultArgkey2 = "arg2";

	[Token(Token = "0x17001207")]
	protected virtual ARG2 arg2
	{
		[Token(Token = "0x6007246")]
		get
		{
			return (ARG2)null;
		}
	}

	[Token(Token = "0x6007247")]
	protected static void InnerOpen(string prefabPath, ARG1 arg1, ARG2 arg2, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007248")]
	protected static void InnerOpen(GameObject prefab, ARG1 arg1, ARG2 arg2, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007249")]
	protected InformDialogViewControllerBase()
	{
	}
}
[Token(Token = "0x2001256")]
public abstract class InformDialogViewControllerBase<ARG1, ARG2, ARG3> : InformDialogViewControllerBase<ARG1, ARG2>
{
	[Token(Token = "0x400BB27")]
	protected const string k_DefaultArgkey3 = "arg3";

	[Token(Token = "0x17001208")]
	protected virtual ARG3 arg3
	{
		[Token(Token = "0x600724A")]
		get
		{
			return (ARG3)null;
		}
	}

	[Token(Token = "0x600724B")]
	protected static void InnerOpen(string prefabPath, ARG1 arg1, ARG2 arg2, ARG3 arg3, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600724C")]
	protected static void InnerOpen(GameObject prefab, ARG1 arg1, ARG2 arg2, ARG3 arg3, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600724D")]
	protected InformDialogViewControllerBase()
	{
	}
}
[Token(Token = "0x2001257")]
public abstract class InformDialogViewControllerBase<ARG1, ARG2, ARG3, ARG4> : InformDialogViewControllerBase<ARG1, ARG2, ARG3>
{
	[Token(Token = "0x400BB28")]
	protected const string k_DefaultArgkey4 = "arg4";

	[Token(Token = "0x17001209")]
	protected virtual ARG4 arg4
	{
		[Token(Token = "0x600724E")]
		get
		{
			return (ARG4)null;
		}
	}

	[Token(Token = "0x600724F")]
	protected static void InnerOpen(string prefabPath, ARG1 arg1, ARG2 arg2, ARG3 arg3, ARG4 arg4, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007250")]
	protected static void InnerOpen(GameObject prefab, ARG1 arg1, ARG2 arg2, ARG3 arg3, ARG4 arg4, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007251")]
	protected InformDialogViewControllerBase()
	{
	}
}
