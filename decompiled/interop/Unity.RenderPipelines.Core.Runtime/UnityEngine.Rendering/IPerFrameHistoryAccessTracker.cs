using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering;

public class IPerFrameHistoryAccessTracker : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_RequestAccess_Public_Abstract_Virtual_New_Void_0<Type>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RequestAccess_Public_Abstract_Virtual_New_Void_0, Il2CppClassPointerStore<IPerFrameHistoryAccessTracker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestAccess_Public_Abstract_Virtual_New_Void_0;

	static IPerFrameHistoryAccessTracker()
	{
		Il2CppClassPointerStore<IPerFrameHistoryAccessTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IPerFrameHistoryAccessTracker");
		NativeMethodInfoPtr_RequestAccess_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPerFrameHistoryAccessTracker>.NativeClassPtr, 100663455);
	}

	[CallerCount(0)]
	public unsafe virtual void RequestAccess<Type>() where Type : ContextItem
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_RequestAccess_Public_Abstract_Virtual_New_Void_0<Type>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IPerFrameHistoryAccessTracker(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
