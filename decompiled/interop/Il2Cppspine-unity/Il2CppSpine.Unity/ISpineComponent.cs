using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSpine.Unity;

public class ISpineComponent : Il2CppObjectBase
{
	static ISpineComponent()
	{
		Il2CppClassPointerStore<ISpineComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "ISpineComponent");
	}

	public ISpineComponent(IntPtr pointer)
		: base(pointer)
	{
	}
}
