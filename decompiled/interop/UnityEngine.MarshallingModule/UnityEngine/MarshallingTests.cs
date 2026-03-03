using Il2CppInterop.Runtime;

namespace UnityEngine;

public static class MarshallingTests
{
	private delegate void DisableMarshallingTestsVerificationDelegate();

	private static readonly DisableMarshallingTestsVerificationDelegate DisableMarshallingTestsVerificationDelegateField = IL2CPP.ResolveICall<DisableMarshallingTestsVerificationDelegate>("UnityEngine.MarshallingTests::DisableMarshallingTestsVerification");

	public static void DisableMarshallingTestsVerification()
	{
		DisableMarshallingTestsVerificationDelegateField();
	}
}
