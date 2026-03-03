using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables;

public class IDataPlayer : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Void_DataPlayableOutput_0;

	private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_DataPlayableOutput_0;

	static IDataPlayer()
	{
		Il2CppClassPointerStore<IDataPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.DirectorModule.dll", "UnityEngine.Playables", "IDataPlayer");
		NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Void_DataPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataPlayer>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_DataPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataPlayer>.NativeClassPtr, 100663301);
	}

	[CallerCount(0)]
	public unsafe virtual void Bind(DataPlayableOutput output)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Void_DataPlayableOutput_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Release(DataPlayableOutput output)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_DataPlayableOutput_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IDataPlayer(IntPtr pointer)
		: base(pointer)
	{
	}
}
