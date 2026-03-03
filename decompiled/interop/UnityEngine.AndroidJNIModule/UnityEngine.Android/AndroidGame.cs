using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Android;

public static class AndroidGame
{
	public static class Automatic
	{
	}

	private delegate void StartLoadingDelegate(int label);

	private delegate void StopLoadingDelegate(int label);

	private static readonly StartLoadingDelegate StartLoadingDelegateField = IL2CPP.ResolveICall<StartLoadingDelegate>("UnityEngine.Android.AndroidGame::StartLoading");

	private static readonly StopLoadingDelegate StopLoadingDelegateField = IL2CPP.ResolveICall<StopLoadingDelegate>("UnityEngine.Android.AndroidGame::StopLoading");

	public static AndroidGameMode GameMode
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public static void StartLoading(int label)
	{
		StartLoadingDelegateField(label);
	}

	public static void StopLoading(int label)
	{
		StopLoadingDelegateField(label);
	}

	public static AndroidJavaObject GetUnityGameManager()
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static AndroidJavaObject GetUnityGameState()
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static void SetGameState(bool isLoading, AndroidGameState gameState)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static void SetGameState(bool isLoading, AndroidGameState gameState, int label, int quality)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
