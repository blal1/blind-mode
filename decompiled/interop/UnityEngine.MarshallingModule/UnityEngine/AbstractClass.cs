using Il2CppInterop.Runtime;

namespace UnityEngine;

public abstract class AbstractClass
{
	private delegate int MethodInAbstractClassDelegate();

	private static readonly MethodInAbstractClassDelegate MethodInAbstractClassDelegateField = IL2CPP.ResolveICall<MethodInAbstractClassDelegate>("UnityEngine.AbstractClass::MethodInAbstractClass");

	public static int MethodInAbstractClass()
	{
		return MethodInAbstractClassDelegateField();
	}
}
