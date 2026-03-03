using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Shop;

[Token(Token = "0x20009B0")]
public static class ShopPurchase
{
	[Token(Token = "0x20009B1")]
	public delegate Handle RequestPurchaseDelegate(int shopId, int priceId, int buyCount, Dictionary<string, object> purchaseArgs);

	[Token(Token = "0x20009B2")]
	public class PurchaseHandler
	{
		[Token(Token = "0x4008D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<IEntryData> m_ConfirmDialogEntryDatas;

		[Token(Token = "0x4008D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Action<RequestPurchaseDelegate, Dictionary<string, object>, Action> m_OnRequestPurchaseCallback;

		[Token(Token = "0x4008D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Action<bool> m_OnPostProcessPurchaseCallback;

		[Token(Token = "0x4008D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Action<bool, bool> m_BuyAfterRefresh;

		[Token(Token = "0x4008D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] confirmCheckboxLabels;

		[Token(Token = "0x4008D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RequestPurchaseDelegate m_CustomRequestPurchaseDelegate;

		[Token(Token = "0x6003B2D")]
		public T FindConfirmDialogEntry<T>(string label) where T : class, IEntryData
		{
			return null;
		}

		[Token(Token = "0x6003B2E")]
		public bool InsertConfirmDialogEntry<T>(string insertAtLabel, T entry) where T : class, IEntryData
		{
			return default(bool);
		}

		[Token(Token = "0x6003B2F")]
		public void AddConfirmDialogEntry<T>(T entry) where T : class, IEntryData
		{
		}

		[Token(Token = "0x6003B30")]
		public bool RemoveConfirmDialogEntry<T>(T dialogEntry) where T : class, IEntryData
		{
			return default(bool);
		}

		[Token(Token = "0x6003B31")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		public void SetCustomRequestPurchaseFunc(RequestPurchaseDelegate customRequestPurchaseFunc)
		{
		}

		[Token(Token = "0x6003B32")]
		[Address(RVA = "0x5955C0", Offset = "0x5947C0", VA = "0x1805955C0")]
		public PurchaseHandler(List<IEntryData> confirmDialogEntryDatas, Action<RequestPurchaseDelegate, Dictionary<string, object>, Action> onRequestPurchaseCallback, Action<bool> onPostProcessPurchaseCallback, Action<bool, bool> buyAfterRefresh)
		{
		}

		[Token(Token = "0x6003B33")]
		[Address(RVA = "0x818FD0", Offset = "0x8181D0", VA = "0x180818FD0")]
		public void OpenConfirm(Action onDecided, Action onCanceled)
		{
		}

		[Token(Token = "0x6003B34")]
		[Address(RVA = "0x819210", Offset = "0x818410", VA = "0x180819210")]
		private void SetupConfirmCheckboxLabel()
		{
		}

		[Token(Token = "0x6003B35")]
		[Address(RVA = "0x8190E0", Offset = "0x8182E0", VA = "0x1808190E0")]
		public void RequestPurchase(Dictionary<string, object> purchaseArgs, Action onComplete)
		{
		}

		[Token(Token = "0x6003B36")]
		[Address(RVA = "0x8190B0", Offset = "0x8182B0", VA = "0x1808190B0")]
		public void PostProcessPurchase(bool skipResult = false)
		{
		}

		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x818FA0", Offset = "0x8181A0", VA = "0x180818FA0")]
		public void CallBuyAfterRefresh(bool isSuccess, bool tryFocus)
		{
		}

		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x8195C0", Offset = "0x8187C0", VA = "0x1808195C0")]
		public void SwapPayInfoToMini()
		{
		}
	}

	[Token(Token = "0x4008D58")]
	internal const string k_ConfirmDialogEntry_MessageText = "MessageText";

	[Token(Token = "0x4008D59")]
	internal const string k_ConfirmDialogEntry_PayItem = "PayItem";

	[Token(Token = "0x4008D5A")]
	internal const string k_ConfirmDialogEntry_PayText = "PayText";

	[Token(Token = "0x4008D5B")]
	internal const string k_ConfirmDialogEntry_CheckboxGruop = "CheckboxGroup";

	[Token(Token = "0x4008D5C")]
	internal const string k_ConfirmDialogEntry_CancelButton = "CancelButton";

	[Token(Token = "0x4008D5D")]
	internal const string k_ConfirmDialogEntry_DecideButton = "DecideButton";

	[Token(Token = "0x4008D5E")]
	internal const string k_RouteKey_PurchaseHandler = "purchaseHandler";

	[Token(Token = "0x6003B25")]
	[Address(RVA = "0x81B320", Offset = "0x81A520", VA = "0x18081B320")]
	public static void RunOnComplete(ViewController owner, [Optional] Action onCompleteCallback)
	{
	}

	[Token(Token = "0x6003B26")]
	[Address(RVA = "0x81B190", Offset = "0x81A390", VA = "0x18081B190")]
	public static void Request(RequestPurchaseDelegate requestPurchaseDelegate, int shopId, int priceId, int buyCount, [Optional] Dictionary<string, object> purchaseArgs, [Optional] Action onCompleteCallback, [Optional] Action<Handle> onFailedCallback, [Optional] Action onSectionMainteCallback)
	{
	}

	[Token(Token = "0x6003B27")]
	[Address(RVA = "0x81A9E0", Offset = "0x819BE0", VA = "0x18081A9E0")]
	public static void HandlePurchaseCompleteCode(Handle h, [Optional] Action onSuccessCallback, [Optional] Action onFailedCallback)
	{
	}

	[Token(Token = "0x6003B28")]
	[Address(RVA = "0x81B0A0", Offset = "0x81A2A0", VA = "0x18081B0A0")]
	public static bool LaunchResultOnSuccess([Optional] ViewController onResultSwapTarget, [Optional] Dictionary<string, object> forwardPackResultArgs)
	{
		return default(bool);
	}
}
