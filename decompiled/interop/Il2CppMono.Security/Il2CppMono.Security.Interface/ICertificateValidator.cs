using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppMono.Security.Interface;

public class ICertificateValidator : Il2CppObjectBase
{
	static ICertificateValidator()
	{
		Il2CppClassPointerStore<ICertificateValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "ICertificateValidator");
	}

	public ICertificateValidator(IntPtr pointer)
		: base(pointer)
	{
	}
}
