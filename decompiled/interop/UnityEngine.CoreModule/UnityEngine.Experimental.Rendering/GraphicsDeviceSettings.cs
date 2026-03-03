using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering;

public static class GraphicsDeviceSettings
{
	private delegate WaitForPresentSyncPoint get_waitForPresentSyncPointDelegate();

	private delegate void set_waitForPresentSyncPointDelegate(WaitForPresentSyncPoint value);

	private delegate GraphicsJobsSyncPoint get_graphicsJobsSyncPointDelegate();

	private delegate void set_graphicsJobsSyncPointDelegate(GraphicsJobsSyncPoint value);

	private static readonly get_waitForPresentSyncPointDelegate get_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<get_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_waitForPresentSyncPoint");

	private static readonly set_waitForPresentSyncPointDelegate set_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<set_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_waitForPresentSyncPoint");

	private static readonly get_graphicsJobsSyncPointDelegate get_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<get_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_graphicsJobsSyncPoint");

	private static readonly set_graphicsJobsSyncPointDelegate set_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<set_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_graphicsJobsSyncPoint");

	public static WaitForPresentSyncPoint waitForPresentSyncPoint
	{
		get
		{
			return get_waitForPresentSyncPointDelegateField();
		}
		set
		{
			set_waitForPresentSyncPointDelegateField(value);
		}
	}

	public static GraphicsJobsSyncPoint graphicsJobsSyncPoint
	{
		get
		{
			return get_graphicsJobsSyncPointDelegateField();
		}
		set
		{
			set_graphicsJobsSyncPointDelegateField(value);
		}
	}
}
