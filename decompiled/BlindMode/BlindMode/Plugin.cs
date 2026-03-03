using System;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;

namespace BlindMode;

[BepInPlugin("radsi.blindmode", "Blind Mode", "2.1.0")]
public class Plugin : BasePlugin
{
	internal static ManualLogSource Log;

	public override void Load()
	{
		Log = ((BasePlugin)this).Log;
		TryLoad();
	}

	private void TryLoad()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ClassInjector.RegisterTypeInIl2Cpp<BaseClass>();
			GameObject val = new GameObject(typeof(BaseClass).FullName);
			Object.DontDestroyOnLoad((Object)(object)val);
			val.AddComponent<BaseClass>();
			((Object)val).hideFlags = (HideFlags)61;
			new Harmony("radsi.blindmode").PatchAll();
			Log.LogInfo((object)"Plugin has been loaded!");
			TryPatch();
		}
		catch (Exception ex)
		{
			Log.LogError((object)"Error loading the plugin!");
			Log.LogError((object)ex);
		}
	}

	private void TryPatch()
	{
		try
		{
			Log.LogInfo((object)"Attempting to patch...");
			Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), (string)null);
			Log.LogInfo((object)"Successfully patched!");
		}
		catch (Exception ex)
		{
			Log.LogError((object)"Error registering patch!");
			Log.LogError((object)ex);
		}
	}
}
