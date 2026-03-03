using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Device;

public static class Screen
{
	public static float brightness
	{
		get
		{
			return UnityEngine.Screen.brightness;
		}
		set
		{
			UnityEngine.Screen.brightness = value;
		}
	}

	public static bool autorotateToLandscapeLeft
	{
		get
		{
			return UnityEngine.Screen.autorotateToLandscapeLeft;
		}
		set
		{
			UnityEngine.Screen.autorotateToLandscapeLeft = value;
		}
	}

	public static bool autorotateToLandscapeRight
	{
		get
		{
			return UnityEngine.Screen.autorotateToLandscapeRight;
		}
		set
		{
			UnityEngine.Screen.autorotateToLandscapeRight = value;
		}
	}

	public static bool autorotateToPortrait
	{
		get
		{
			return UnityEngine.Screen.autorotateToPortrait;
		}
		set
		{
			UnityEngine.Screen.autorotateToPortrait = value;
		}
	}

	public static bool autorotateToPortraitUpsideDown
	{
		get
		{
			return UnityEngine.Screen.autorotateToPortraitUpsideDown;
		}
		set
		{
			UnityEngine.Screen.autorotateToPortraitUpsideDown = value;
		}
	}

	public static Resolution currentResolution => UnityEngine.Screen.currentResolution;

	public static Il2CppStructArray<Rect> cutouts => UnityEngine.Screen.cutouts;

	public static float dpi => UnityEngine.Screen.dpi;

	public static bool fullScreen
	{
		get
		{
			return UnityEngine.Screen.fullScreen;
		}
		set
		{
			UnityEngine.Screen.fullScreen = value;
		}
	}

	public static FullScreenMode fullScreenMode
	{
		get
		{
			return UnityEngine.Screen.fullScreenMode;
		}
		set
		{
			UnityEngine.Screen.fullScreenMode = value;
		}
	}

	public static int height => UnityEngine.Screen.height;

	public static int width => UnityEngine.Screen.width;

	public static ScreenOrientation orientation
	{
		get
		{
			return UnityEngine.Screen.orientation;
		}
		set
		{
			UnityEngine.Screen.orientation = value;
		}
	}

	public static Il2CppStructArray<Resolution> resolutions => UnityEngine.Screen.resolutions;

	public static Rect safeArea => UnityEngine.Screen.safeArea;

	public static int sleepTimeout
	{
		get
		{
			return UnityEngine.Screen.sleepTimeout;
		}
		set
		{
			UnityEngine.Screen.sleepTimeout = value;
		}
	}

	public static Vector2Int mainWindowPosition => UnityEngine.Screen.mainWindowPosition;

	public static int msaaSamples => UnityEngine.Screen.msaaSamples;

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
	{
		UnityEngine.Screen.SetResolution(width, height, fullscreenMode, preferredRefreshRate);
	}

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
	{
		if (preferredRefreshRate < 0)
		{
			preferredRefreshRate = 0;
		}
		UnityEngine.Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
		{
			numerator = (uint)preferredRefreshRate,
			denominator = 1u
		});
	}

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
	{
		SetResolution(width, height, fullscreenMode, new RefreshRate
		{
			numerator = 0u,
			denominator = 1u
		});
	}

	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
	{
		if (preferredRefreshRate < 0)
		{
			preferredRefreshRate = 0;
		}
		SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, new RefreshRate
		{
			numerator = (uint)preferredRefreshRate,
			denominator = 1u
		});
	}

	public static void SetResolution(int width, int height, bool fullscreen)
	{
		SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, new RefreshRate
		{
			numerator = 0u,
			denominator = 1u
		});
	}

	public static void SetMSAASamples(int numSamples)
	{
		UnityEngine.Screen.SetMSAASamples(numSamples);
	}
}
