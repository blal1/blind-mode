using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering;

public class SplashScreen
{
	public enum StopBehavior
	{
		StopImmediate,
		FadeOut
	}

	private delegate bool get_isFinishedDelegate();

	private delegate void CancelSplashScreenDelegate();

	private delegate void BeginSplashScreenFadeDelegate();

	private delegate void BeginDelegate();

	private delegate void DrawDelegate();

	private delegate void SetTimeDelegate(float time);

	private static readonly get_isFinishedDelegate get_isFinishedDelegateField = IL2CPP.ResolveICall<get_isFinishedDelegate>("UnityEngine.Rendering.SplashScreen::get_isFinished");

	private static readonly CancelSplashScreenDelegate CancelSplashScreenDelegateField = IL2CPP.ResolveICall<CancelSplashScreenDelegate>("UnityEngine.Rendering.SplashScreen::CancelSplashScreen");

	private static readonly BeginSplashScreenFadeDelegate BeginSplashScreenFadeDelegateField = IL2CPP.ResolveICall<BeginSplashScreenFadeDelegate>("UnityEngine.Rendering.SplashScreen::BeginSplashScreenFade");

	private static readonly BeginDelegate BeginDelegateField = IL2CPP.ResolveICall<BeginDelegate>("UnityEngine.Rendering.SplashScreen::Begin");

	private static readonly DrawDelegate DrawDelegateField = IL2CPP.ResolveICall<DrawDelegate>("UnityEngine.Rendering.SplashScreen::Draw");

	private static readonly SetTimeDelegate SetTimeDelegateField = IL2CPP.ResolveICall<SetTimeDelegate>("UnityEngine.Rendering.SplashScreen::SetTime");

	public static bool isFinished => get_isFinishedDelegateField();

	public static void CancelSplashScreen()
	{
		CancelSplashScreenDelegateField();
	}

	public static void BeginSplashScreenFade()
	{
		BeginSplashScreenFadeDelegateField();
	}

	public static void Begin()
	{
		BeginDelegateField();
	}

	public static void Stop(StopBehavior stopBehavior)
	{
		if (stopBehavior == StopBehavior.FadeOut)
		{
			BeginSplashScreenFade();
		}
		else
		{
			CancelSplashScreen();
		}
	}

	public static void Draw()
	{
		DrawDelegateField();
	}

	public static void SetTime(float time)
	{
		SetTimeDelegateField(time);
	}
}
