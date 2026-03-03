using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels;

[DefaultMember("Item")]
public class IChannelDataStore : Il2CppObjectBase
{
	static IChannelDataStore()
	{
		Il2CppClassPointerStore<IChannelDataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannelDataStore");
	}

	public IChannelDataStore(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
