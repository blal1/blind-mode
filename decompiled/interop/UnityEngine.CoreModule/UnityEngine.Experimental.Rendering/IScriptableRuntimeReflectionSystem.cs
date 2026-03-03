using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Experimental.Rendering;

public class IScriptableRuntimeReflectionSystem : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0;

	static IScriptableRuntimeReflectionSystem()
	{
		Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "IScriptableRuntimeReflectionSystem");
		NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr, 100668944);
	}

	[CallerCount(0)]
	public unsafe virtual bool TickRealtimeProbes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IScriptableRuntimeReflectionSystem(IntPtr pointer)
		: base(pointer)
	{
	}
}
