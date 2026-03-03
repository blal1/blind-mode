using HarmonyLib;
using UnityEngine;
using YgomSystem.UI;

namespace BlindMode;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
internal class PatchColorContainerImage
{
	[HarmonyPostfix]
	private static void Postfix(ColorContainerImage __instance)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		try
		{
			if ((int)((ColorContainer)__instance).currentStatusMode == 2)
			{
				BaseClass.textToCopy = "";
				string name = ((Object)((Component)__instance).transform.parent.parent.parent).name;
				string text = name;
				if (text == "DuelMenuButton")
				{
					BaseClass.textToCopy = "Menu button";
				}
				if (BaseClass.textToCopy != "")
				{
					BaseClass.SpeakText();
				}
			}
		}
		catch
		{
		}
	}
}
