using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables;

public class IPlayableOutput : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0;

	static IPlayableOutput()
	{
		Il2CppClassPointerStore<IPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayableOutput");
		NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableOutput>.NativeClassPtr, 100667400);
	}

	[CallerCount(0)]
	public unsafe virtual PlayableOutputHandle GetHandle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutputHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IPlayableOutput(IntPtr pointer)
		: base(pointer)
	{
	}
}
