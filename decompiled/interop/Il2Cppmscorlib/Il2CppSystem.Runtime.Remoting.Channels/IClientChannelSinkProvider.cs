using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels;

public class IClientChannelSinkProvider : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0;

	public unsafe virtual IClientChannelSinkProvider Next
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static IClientChannelSinkProvider()
	{
		Il2CppClassPointerStore<IClientChannelSinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IClientChannelSinkProvider");
		NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientChannelSinkProvider>.NativeClassPtr, 100670186);
	}

	public IClientChannelSinkProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
