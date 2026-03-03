using HarmonyLib;
using UnityEngine;
using YgomGame.Duel;

namespace BlindMode;

[HarmonyPatch(typeof(CardInfo), "SetDescriptionArea")]
internal class PatchCardInfoSetCard
{
	[HarmonyPostfix]
	private static void Postfix(CardInfo __instance)
	{
		((MonoBehaviour)BaseClass.Instance).Invoke("CopyUI", ((Component)__instance).gameObject.activeInHierarchy ? 0f : 0.2f);
	}
}
