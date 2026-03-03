using Il2CppInterop.Runtime;

namespace UnityEngine;

public class FieldBoundPropertyTests
{
	private delegate int get_StaticPropDelegate();

	private delegate void set_StaticPropDelegate(int value);

	private delegate int get_StaticAccessorPropDelegate();

	private delegate void set_StaticAccessorPropDelegate(int value);

	private static readonly get_StaticPropDelegate get_StaticPropDelegateField = IL2CPP.ResolveICall<get_StaticPropDelegate>("UnityEngine.FieldBoundPropertyTests::get_StaticProp");

	private static readonly set_StaticPropDelegate set_StaticPropDelegateField = IL2CPP.ResolveICall<set_StaticPropDelegate>("UnityEngine.FieldBoundPropertyTests::set_StaticProp");

	private static readonly get_StaticAccessorPropDelegate get_StaticAccessorPropDelegateField = IL2CPP.ResolveICall<get_StaticAccessorPropDelegate>("UnityEngine.FieldBoundPropertyTests::get_StaticAccessorProp");

	private static readonly set_StaticAccessorPropDelegate set_StaticAccessorPropDelegateField = IL2CPP.ResolveICall<set_StaticAccessorPropDelegate>("UnityEngine.FieldBoundPropertyTests::set_StaticAccessorProp");

	public static int StaticProp
	{
		get
		{
			return get_StaticPropDelegateField();
		}
		set
		{
			set_StaticPropDelegateField(value);
		}
	}

	public static int StaticAccessorProp
	{
		get
		{
			return get_StaticAccessorPropDelegateField();
		}
		set
		{
			set_StaticAccessorPropDelegateField(value);
		}
	}
}
