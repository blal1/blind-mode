using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using BepInEx;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using CrossSpeak;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace BlindMode;

public class BaseClass : MonoBehaviour
{
	public enum Menus
	{
		NONE,
		DUEL,
		DECK,
		SOLO,
		SHOP,
		Missions,
		Notifications,
		Settings,
		DuelPass
	}

	public class CardCustomInfo
	{
		public GameObject cardObject { get; set; } = null;


		public string Link { get; set; } = string.Empty;


		public string Stars { get; set; } = string.Empty;


		public string Atk { get; set; } = string.Empty;


		public string Def { get; set; } = string.Empty;


		public string PendulumScale { get; set; } = string.Empty;


		public string Attributes { get; set; } = string.Empty;


		public string SpellType { get; set; } = string.Empty;


		public string Element { get; set; } = string.Empty;


		public string Owned { get; set; } = string.Empty;


		public bool IsInHand { get; set; } = true;

	}

	public class PreviewElement
	{
		public CardCustomInfo cardInfo { get; set; } = new CardCustomInfo();


		public string Name { get; set; } = string.Empty;


		public string Description { get; set; } = string.Empty;


		public string TimeLeft { get; set; } = string.Empty;


		public string Price { get; set; } = string.Empty;


		public void Clear()
		{
			PropertyInfo[] properties = GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.PropertyType == typeof(string))
				{
					propertyInfo.SetValue(this, string.Empty);
				}
			}
		}

		public void LogValues()
		{
			PropertyInfo[] properties = GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				Console.WriteLine($"{propertyInfo.Name}: {propertyInfo.GetValue(this)}");
			}
		}

		public void CopyValuesFrom(PreviewElement source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			PropertyInfo[] properties = GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.CanRead && propertyInfo.CanWrite)
				{
					object value = propertyInfo.GetValue(source);
					if (propertyInfo.Name == "cardInfo" && value is CardCustomInfo source2)
					{
						cardInfo = DeepCopy(source2);
					}
					else
					{
						propertyInfo.SetValue(this, value);
					}
				}
			}
		}

		private static T DeepCopy<T>(T source) where T : class, new()
		{
			if (source == null)
			{
				return null;
			}
			T val = new T();
			PropertyInfo[] properties = typeof(T).GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.CanRead && propertyInfo.CanWrite)
				{
					object value = propertyInfo.GetValue(source);
					propertyInfo.SetValue(val, value);
				}
			}
			return val;
		}
	}

	private enum Attribute
	{
		Light = 1,
		Dark,
		Water,
		Fire,
		Earth,
		Wind,
		Divine
	}

	private enum Rarity
	{
		Normal,
		Rare,
		SuperRare,
		UltraRare
	}

	private enum DuelPositions
	{
		Normal,
		Rare,
		SuperRare,
		UltraRare
	}

	public static BaseClass Instance;

	public static List<string> textRecord = new List<string>();

	public static List<CardRoot> cardsInDuel = new List<CardRoot>();

	public static PreviewElement currenElement = new PreviewElement();

	public static Dictionary<string, Menus> menuNames = new Dictionary<string, Menus>
	{
		{
			"DUEL",
			Menus.DUEL
		},
		{
			"DECK",
			Menus.DECK
		},
		{
			"SOLO",
			Menus.SOLO
		},
		{
			"SHOP",
			Menus.SHOP
		},
		{
			"MISSION",
			Menus.Missions
		},
		{
			"Notifications",
			Menus.Notifications
		},
		{
			"Game Settings",
			Menus.Settings
		},
		{
			"Duel Pass",
			Menus.DuelPass
		}
	};

	public static Menus currentMenu = Menus.NONE;

	public static List<string> bannedText = new List<string> { "00:00", "You can add new Cards to your Deck." };

	public static string textToCopy;

	public static string old_copiedText;

	public static bool IsInDuel = false;

	public static DateTime lastExecutionTime;

	public static readonly TimeSpan cooldown = TimeSpan.FromSeconds(0.10000000149011612);

	public static bool UsingMouse = false;

	public static SnapContentManager SnapContentManager;

	public void Awake()
	{
		Instance = this;
		CrossSpeakManager.Instance.Initialize();
	}

	public void Start()
	{
		if (!Directory.Exists(Path.Join(Paths.PluginPath, "dependencies")))
		{
			string text = Path.Combine(Paths.PluginPath, "directories.zip");
			using (FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write))
			{
				fileStream.Write(Resource1.dependencies);
				fileStream.Close();
			}
			ZipFile.ExtractToDirectory(text, Paths.PluginPath);
			File.Delete(text);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"Start-Sleep -Seconds 2; Start-Process 'steam://run/1449850'\"",
				CreateNoWindow = true,
				UseShellExecute = false
			};
			Process.Start(startInfo);
			Application.Quit();
		}
	}

	public void OnApplicationQuit()
	{
		CrossSpeakManager.Instance.Close();
	}

	public void Update()
	{
		if (!IsInDuel)
		{
			return;
		}
		if (Input.GetKeyDown((KeyCode)32))
		{
			List<DuelLP> list = ((IEnumerable<DuelLP>)Object.FindObjectsOfType<DuelLP>()).ToList();
			SpeakText($"Your life points: {list.Find((DuelLP e) => e.m_IsNear).currentLP}\nOpponent's life points: {list.Find((DuelLP e) => !e.m_IsNear).currentLP}");
		}
		if (Input.GetKeyDown((KeyCode)308))
		{
			currenElement.Clear();
			CardInfo val = Object.FindObjectOfType<CardInfo>();
			if (!((Component)val).gameObject.activeInHierarchy)
			{
				((Component)val).gameObject.SetActive(true);
			}
			CopyUI();
		}
	}

	internal static void SpeakText(string text = "")
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		if (text == "")
		{
			text = textToCopy;
		}
		if (DateTime.Now - lastExecutionTime >= cooldown && (string.IsNullOrEmpty(old_copiedText) || !old_copiedText.Equals(text)) && !string.IsNullOrEmpty(text?.Trim()) && !bannedText.Contains(text))
		{
			text = Regex.Replace(text, "<[^>]+>", "");
			ManualLogSource log = Plugin.Log;
			bool flag = default(bool);
			BepInExInfoLogInterpolatedStringHandler val = new BepInExInfoLogInterpolatedStringHandler(15, 1, ref flag);
			if (flag)
			{
				((BepInExLogInterpolatedStringHandler)val).AppendLiteral("text to speak: ");
				((BepInExLogInterpolatedStringHandler)val).AppendFormatted<string>(text);
			}
			log.LogInfo(val);
			CrossSpeakManager.Instance.Speak(text, true);
			textRecord.Add(text);
			old_copiedText = text;
			lastExecutionTime = DateTime.Now;
		}
	}

	public static void GetUITextElements()
	{
		switch (currentMenu)
		{
		case Menus.DuelPass:
			if (textRecord.Count == 0)
			{
				textToCopy = "Pass grade: " + FindExtendedTextElement(null, "UI/ContentCanvas/ContentManager/DuelPass/DuelPassUI(Clone)/DuelPassArea/RootInfo/GradeAreaWidget/TextDuelPassLevel0") + ", Time left: " + FindExtendedTextElement(null, "UI/ContentCanvas/ContentManager/DuelPass/DuelPassUI(Clone)/DuelPassArea/RootInfo/LimitArea/LimitDateBase/LimitDateTextTMP");
				return;
			}
			break;
		case Menus.DECK:
			if (textRecord.Last().Contains("Create card"))
			{
				if (FindExtendedTextElement(null, "UI/OverlayCanvas/DialogManager/CommonDialog/CommonDialogUI(Clone)/Window/Content/TitleGrp/Text").Contains("Unable"))
				{
					textToCopy = "Unable to create card";
				}
				SpeakText();
			}
			break;
		}
		if ((Object)(object)SnapContentManager == (Object)null && currentMenu != Menus.DECK && currentMenu != Menus.SOLO && currentMenu != Menus.DUEL)
		{
			List<(string, string)> list = FindListExtendedTextElement(null, "UI/OverlayCanvas/DialogManager/ItemPreview/ItemPreviewUI(Clone)/Root/RootMainArea/DescArea/RootDesc/", useRegex: false);
			currenElement.Name = ((list.Count > 2) ? (list.First().Item2 + " - ") : "") + list[list.Count - 2].Item2;
			currenElement.Description = list.Last().Item2;
			return;
		}
		List<(string, bool)> list2 = new List<(string, bool)>
		{
			("UI/OverlayCanvas/DialogManager/CardBrowser/CardBrowserUI(Clone)/Scroll View/Viewport/Content/Template(Clone){0}/CardInfoDetail_Browser(Clone)/Root/Window/StatusArea", (Object)(object)SnapContentManager != (Object)null),
			("UI/ContentCanvas/ContentManager/DeckEdit/DeckEditUI(Clone)/CardDetail/Root/Window", (Object)(object)GameObject.Find("UI/ContentCanvas/ContentManager/DeckEdit/") != (Object)null),
			("UI/ContentCanvas/ContentManager/DeckBrowser/DeckBrowserUI(Clone)/Root/CardDetail/Root/Window", (Object)(object)GameObject.Find("UI/ContentCanvas/ContentManager/DeckBrowser/") != (Object)null),
			("UI/ContentCanvas/ContentManager/DuelClient/CardInfo/CardInfo(Clone)/Root/Window", true)
		};
		foreach (var item in list2)
		{
			if (!item.Item2)
			{
				continue;
			}
			var (text, _) = item;
			if (item.Item1 == list2[0].Item1)
			{
				text = string.Format(item.Item1, SnapContentManager.currentPage % 3);
			}
			List<(string, string)> list3 = FindListExtendedTextElement(null, text);
			currenElement.Name = list3[0].Item2;
			currenElement.Description = list3.Find(((string, string) e) => e.Item1.Contains("DescriptionValue")).Item2 ?? "";
			currenElement.cardInfo.Stars = list3.Find(((string, string) e) => e.Item1.Contains("Rank") || e.Item1.Contains("Level")).Item2 ?? "";
			currenElement.cardInfo.Atk = list3.Find(((string, string) e) => e.Item1.Contains("Atk")).Item2 ?? "";
			currenElement.cardInfo.Def = list3.Find(((string, string) e) => e.Item1.Contains("Def")).Item2 ?? "";
			currenElement.cardInfo.PendulumScale = list3.Find(((string, string) e) => e.Item1.Contains("Pendulum")).Item2 ?? "";
			currenElement.cardInfo.Link = list3.Find(((string, string) e) => e.Item1.Contains("Link")).Item2 ?? "";
			currenElement.cardInfo.Element = GetElement(((Object)GameObject.Find(text + "/" + (list2[0].Item2 ? "TitleAreaGroup/TitleArea/IconAttribute" : (list2[1].Item2 ? "TitleArea/PlateTitle/IconAttribute" : "TitleArea/AttributeRoot/IconAttribute"))).GetComponent<Image>().sprite).name) ?? "";
			currenElement.cardInfo.Attributes = list3.Find(((string, string) e) => e.Item1.Contains("DescriptionItem")).Item2 ?? "";
			currenElement.cardInfo.SpellType = list3.Find(((string, string) e) => e.Item1.Contains("SpellTrap")).Item2 ?? "";
			currenElement.cardInfo.Owned = list3.Find(((string, string) e) => e.Item1.Contains("CardNum")).Item2 ?? "";
			break;
		}
	}

	public static string FormatInfo()
	{
		if (string.IsNullOrWhiteSpace(currenElement.Name))
		{
			return string.Empty;
		}
		List<string> source = new List<string>
		{
			(!string.IsNullOrEmpty(currenElement.Name)) ? ("Name: " + currenElement.Name) : null,
			(!string.IsNullOrEmpty(currenElement.Description)) ? ("Description: " + currenElement.Description) : null
		};
		if ((Object)(object)SnapContentManager != (Object)null || currentMenu == Menus.SOLO || currentMenu == Menus.DUEL || currentMenu == Menus.DECK)
		{
			List<string> obj = new List<string>
			{
				(!string.IsNullOrEmpty(currenElement.Name)) ? ("Name: " + currenElement.Name) : null,
				(!currenElement.cardInfo.IsInHand && IsInDuel) ? $"Is faced down?: {!GetCardRootOfCurrentCard().isFace}" : null,
				(!string.IsNullOrEmpty(currenElement.cardInfo.Atk)) ? ("Attack: " + currenElement.cardInfo.Atk) : null,
				(!string.IsNullOrEmpty(currenElement.cardInfo.Link)) ? ("Link level: " + currenElement.cardInfo.Link) : null,
				(!string.IsNullOrEmpty(currenElement.cardInfo.Def)) ? ("Defense: " + currenElement.cardInfo.Def) : null,
				(!string.IsNullOrEmpty(currenElement.cardInfo.Stars)) ? ("Stars: " + currenElement.cardInfo.Stars) : null,
				(!string.IsNullOrEmpty(currenElement.cardInfo.Element)) ? ("Element: " + currenElement.cardInfo.Element) : null,
				(!string.IsNullOrEmpty(currenElement.cardInfo.PendulumScale)) ? ("Pendulum scale: " + currenElement.cardInfo.PendulumScale) : null
			};
			object item2;
			if (string.IsNullOrEmpty(currenElement.cardInfo.Attributes))
			{
				item2 = null;
			}
			else
			{
				string text;
				if (currentMenu != Menus.DECK)
				{
					text = currenElement.cardInfo.Attributes;
				}
				else
				{
					string attributes = currenElement.cardInfo.Attributes;
					text = attributes.Substring(1, attributes.Length - 1 - 1);
				}
				item2 = "Attributes: " + text;
			}
			obj.Add((string)item2);
			obj.Add((!string.IsNullOrEmpty(currenElement.cardInfo.SpellType)) ? ("Spell type: " + currenElement.cardInfo.SpellType) : null);
			obj.Add((!string.IsNullOrEmpty(currenElement.cardInfo.Owned)) ? ("Owned: " + currenElement.cardInfo.Owned) : null);
			obj.Add((!string.IsNullOrEmpty(currenElement.Description)) ? ("Description: " + currenElement.Description) : FindExtendedTextElement(null, "UI/ContentCanvas/ContentManager/DuelClient/CardInfo/CardInfo(Clone)/Root/Window/DescriptionArea/TextArea/Viewport/TextDescriptionValue/"));
			source = obj;
		}
		else if (currentMenu == Menus.SHOP)
		{
			source = new List<string>
			{
				"Name: " + currenElement.Name,
				"Category: " + currenElement.Description,
				"Time left: " + currenElement.TimeLeft,
				"Price: " + currenElement.Price
			};
		}
		source = source.Where((string item) => item?.Trim() != null).ToList();
		return string.Join("\n", source);
	}

	public void CopyUI()
	{
		GetUITextElements();
		SpeakText(FormatInfo());
	}

	internal static void DeselectButton()
	{
		old_copiedText = "";
	}

	internal static void ProcessProfile(SelectionButton __instance)
	{
		if (((Object)__instance).name.Equals("ButtonPlayer"))
		{
			textToCopy = textToCopy + ", level " + FindExtendedTextElement(((Component)((Component)__instance).transform.GetChild(0).GetChild(1).GetChild(1)
				.GetChild(1)).gameObject, null, useRegex: false);
		}
	}

	internal static void ProcessFriendsMenu(SelectionButton __instance)
	{
		string name = ((Object)__instance).name;
		string text = name;
		if (!(text == "SearchButton"))
		{
			if (text == "OpenToggle")
			{
				textToCopy = FindExtendedTextElement(((Component)((Component)__instance).transform.parent).gameObject);
			}
		}
		else
		{
			textToCopy = "Add friend button";
		}
	}

	internal static void ProcessDailyReward(SelectionButton __instance)
	{
		if (textToCopy.Equals("Day"))
		{
			textToCopy = textToCopy + " " + FindExtendedTextElement(((Component)((Component)__instance).transform.GetChild(3).GetChild(1)).gameObject) + ", Recieved: " + (((Component)((Component)__instance).transform.Find("RecievedCover")).gameObject.activeInHierarchy ? "Yes" : "No");
		}
	}

	internal static void ProcessPacks(SelectionButton __instance)
	{
		if (((Object)((Component)__instance).transform.parent).name.Contains("Shop"))
		{
			List<(string, string)> list = new List<(string, string)>();
			list = FindListExtendedTextElement(((Component)__instance).gameObject);
			currenElement.Name = $"{list.Find(((string, string) e) => e.Item1.Contains("PickupMessage")).Item2 ?? ""} - {list.Find(((string, string) e) => e.Item1.Contains("Name")).Item2} ({list.Find(((string, string) e) => e.Item1.Contains("New")).Item2 ?? ""})";
			currenElement.Description = FindExtendedTextElement(null, "UI/ContentCanvas/ContentManager/Shop/ShopUI(Clone)/Root/Main/ProductsRoot/ShowcaseWidget/ListRoot/ProductList/Viewport/Mask/Content/ShopGroupHeaderWidget(Clone)/Label", useRegex: false) ?? "";
			currenElement.TimeLeft = (list.Find(((string, string) e) => e.Item1.Contains("Limit")).Item2 ?? "None") ?? "";
			currenElement.Price = (list.Find(((string, string) e) => e.Item1.Contains("PriceGroup")).Item2 ?? "") ?? "";
			SpeakText(FormatInfo());
		}
	}

	internal static void ProcessDuelMenu(SelectionButton __instance)
	{
		try
		{
			if (((Object)((Component)__instance).transform.parent.parent.parent.parent.parent.parent).name.Equals("SettingMenuArea"))
			{
				ProcessSettingsMenu(__instance);
			}
			if (((Component)__instance).transform.childCount > 0 && ((Object)((Component)__instance).transform.GetChild(0)).name.Equals("Main"))
			{
				List<(string, string)> list = FindListExtendedTextElement(((Component)__instance).gameObject, "", useRegex: false);
				textToCopy = list.Last().Item2 + ", " + list.Find(((string, string) e) => e.Item1.Contains("Complete")).Item2;
			}
		}
		catch
		{
		}
	}

	internal static void ProcessDuelGame(SelectionButton __instance)
	{
		if (!IsInDuel || (!((Object)__instance).name.Contains("HandCard") && !((Object)__instance).name.Contains("Anchor_")))
		{
			return;
		}
		currenElement.cardInfo.cardObject = ((Component)__instance).gameObject;
		if (((Object)__instance).name.Contains("Anchor_"))
		{
			currenElement.cardInfo.IsInHand = false;
			try
			{
				CardRoot cardRootOfCurrentCard = GetCardRootOfCurrentCard();
				if (!cardRootOfCurrentCard.isFace && cardRootOfCurrentCard.team != 0)
				{
					SpeakText("Opponent's face down card!");
				}
				return;
			}
			catch
			{
				return;
			}
		}
		currenElement.cardInfo.IsInHand = true;
	}

	internal static void ProcessMissionsMenu(SelectionButton __instance)
	{
		if (((Object)__instance).name.Equals("Locator"))
		{
			Transform parent = ((Component)__instance).transform.parent.parent.parent.parent.parent.parent.parent.parent.parent;
			if ((Object)(object)parent != (Object)null && parent.childCount > 0)
			{
				string text = FindExtendedTextElement(((Component)((Component)__instance).transform.GetChild(0).GetChild(2)).gameObject, null, useRegex: false);
				string text2 = text;
				text = "x" + text2.Substring(1, text2.Length - 1);
				textToCopy = $"{FindExtendedTextElement(((Component)parent).gameObject, null, useRegex: false)}\n Reward: {text}\n Time left: {FindExtendedTextElement(((Component)parent.GetChild(1).GetChild(0).GetChild(3).GetChild(0)).gameObject, null, useRegex: false) ?? "None"}";
			}
		}
	}

	public static void ProcessDecksMenu(SelectionButton __instance)
	{
		if (((Object)__instance).name.Equals("ImageCard"))
		{
			if (!UsingMouse)
			{
				Instance.CopyUI();
			}
			else
			{
				textToCopy = "Owned: " + textToCopy + ", rarity: " + GetRarity(((Object)((Component)((Component)__instance).transform.Find("IconRarity")).GetComponent<Image>().sprite).name);
			}
		}
		if (((Object)((Component)__instance).transform.parent.parent.parent).name.Equals("Category"))
		{
			textToCopy = textToCopy + ", category: " + FindExtendedTextElement(((Component)((Component)__instance).transform.parent.parent).gameObject);
		}
		if (((Object)((Component)__instance).transform.parent.parent.parent).name.Equals("InputButton"))
		{
			textToCopy = "Rename deck button";
		}
		if (((Object)((Component)__instance).transform.parent.parent.parent).name.Equals("AutoBuildButton"))
		{
			textToCopy = "Auto-build button";
		}
	}

	internal static void ProcessSettingsMenu(SelectionButton __instance)
	{
		if (!(((Object)((Component)__instance).transform.parent.parent).name == "Layout") && !(((Object)((Component)__instance).transform.parent.parent.parent).name == "EntryButtonsScrollView") && !(((Object)__instance).name == "CancelButton"))
		{
			string text = "";
			Slider componentInChildren = ((Component)__instance).GetComponentInChildren<Slider>();
			textToCopy = string.Concat(str2: (!((Object)(object)componentInChildren != (Object)null)) ? ((TMP_Text)((IEnumerable<ExtendedTextMeshProUGUI>)((Component)__instance).GetComponentsInChildren<ExtendedTextMeshProUGUI>()).Where((ExtendedTextMeshProUGUI e) => ((Object)e).name == "ModeText").First()).text : $"{componentInChildren.value} of {componentInChildren.maxValue}", str0: textToCopy, str1: "\nValue is ");
		}
	}

	internal static void ProcessCardPack(SelectionButton __instance)
	{
		if (((Object)__instance).name.Equals("CardPict"))
		{
			string text = FindExtendedTextElement(((Component)((Component)__instance).transform.parent.Find("NumTextArea")).gameObject);
			string text2 = text;
			text = "x" + text2.Substring(1, text2.Length - 1);
			textToCopy = $"Rarity: {GetRarity(((Object)((Component)((Component)__instance).transform.parent.Find("IconRarity")).GetComponent<Image>().sprite).name)}, New: {(((Component)((Component)__instance).transform.parent.Find("NewIcon")).gameObject.activeInHierarchy ? "Yes" : "No")}, Owned: {text}";
		}
	}

	internal static void ProcessNotifications(SelectionButton __instance)
	{
		if (Object.op_Implicit((Object)(object)((Component)__instance).transform.Find("BaseCategory")))
		{
			textToCopy = FindExtendedTextElement(((Component)((Component)__instance).transform.Find("TextBody")).gameObject, null, useRegex: false);
			if (((Component)((Component)__instance).transform.Find("BaseCategory")).gameObject.activeInHierarchy)
			{
				textToCopy = textToCopy + "\nStatus: " + ((TMP_Text)((Component)((Component)__instance).transform.Find("BaseCategory").GetChild(0)).GetComponentInChildren<ExtendedTextMeshProUGUI>()).text;
			}
		}
	}

	internal static void ProcessNotificationsPopup(SelectionButton __instance)
	{
		if (((Object)((Component)__instance).transform.parent.parent.parent.parent.parent.parent).name.Equals("NotificationWidget") && currentMenu == Menus.NONE)
		{
			textToCopy = FindExtendedTextElement(((Component)((Component)__instance).transform.Find("TextBody")).gameObject, null, useRegex: false);
			if (((Component)((Component)__instance).transform.Find("BaseCategory")).gameObject.activeInHierarchy)
			{
				textToCopy = textToCopy + "\nStatus: " + ((TMP_Text)((Component)((Component)__instance).transform.Find("BaseCategory").GetChild(0)).GetComponentInChildren<ExtendedTextMeshProUGUI>()).text;
			}
		}
	}

	internal static void ProcessEventBanner(SelectionButton __instance)
	{
		if (((Object)__instance).name.Equals("DuelShortcut"))
		{
			textToCopy = "Event banner";
		}
	}

	internal static void ProcessTopicsBanner(SelectionButton __instance)
	{
		if (((Object)__instance).name.Equals("ButtonBanner"))
		{
			textToCopy = $"Topic banner, page {((Component)((Component)__instance).transform.parent).GetComponent<ScrollRectPageSnap>().hpage}";
		}
	}

	internal static void ProcessDuelPass(SelectionButton __instance)
	{
		if (((Object)__instance).name.Contains("passRewardButton"))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
			defaultInterpolatedStringHandler.AppendFormatted(((Object)__instance).name.Contains("Normalpass") ? "Normal" : "Gold");
			defaultInterpolatedStringHandler.AppendLiteral(" pass, grade ");
			defaultInterpolatedStringHandler.AppendFormatted(FindExtendedTextElement(((Component)((Component)__instance).transform.parent.parent).gameObject));
			defaultInterpolatedStringHandler.AppendLiteral(", quantity: ");
			string text = textToCopy;
			defaultInterpolatedStringHandler.AppendFormatted("x" + text.Substring(1, text.Length - 1));
			textToCopy = defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	internal static void ProcessNewDeck(SelectionButton __instance)
	{
		Transform val = ((Component)__instance).transform.Find("IconAddDeck");
		if ((Object)(object)val != (Object)null && ((Component)val).gameObject.activeInHierarchy)
		{
			textToCopy = "New deck button";
		}
	}

	internal static CardRoot GetCardRootOfCurrentCard()
	{
		CardRoot val = cardsInDuel.Find((CardRoot e) => e.cardLocator.pos == currenElement.cardInfo.cardObject.transform.position);
		Plugin.Log.LogInfo((object)((Object)val).name);
		return val;
	}

	public static string GetElement(string attrname)
	{
		if (int.TryParse(attrname.Last().ToString(), out var result))
		{
			foreach (object value in Enum.GetValues(typeof(Attribute)))
			{
				Attribute attribute = (Attribute)value;
				if (attribute == (Attribute)result)
				{
					return attribute.ToString();
				}
			}
		}
		return "";
	}

	public static string GetRarity(string rarity)
	{
		if (int.TryParse(rarity.Last().ToString(), out var result))
		{
			foreach (object value in Enum.GetValues(typeof(Rarity)))
			{
				Rarity rarity2 = (Rarity)value;
				if (rarity2 == (Rarity)result)
				{
					return rarity2.ToString();
				}
			}
		}
		return "";
	}

	public static List<(string, string)> FindListExtendedTextElement(GameObject obj, string objPath = "", bool useRegex = true)
	{
		List<(string, string)> list = new List<(string, string)>();
		if ((Object)(object)obj == (Object)null && !string.IsNullOrEmpty(objPath))
		{
			obj = GameObject.Find(objPath);
		}
		ExtendedTextMeshProUGUI val = default(ExtendedTextMeshProUGUI);
		if (obj.TryGetComponent<ExtendedTextMeshProUGUI>(ref val) && !IsBannedText(((Component)val).gameObject, ((TMP_Text)val).text, useRegex))
		{
			list.Add((((Object)((TMP_Text)val).transform.parent).name + "/" + ((Object)val).name, ((TMP_Text)val).text));
		}
		RubyTextGX val2 = default(RubyTextGX);
		if (obj.TryGetComponent<RubyTextGX>(ref val2) && !IsBannedText(((Component)val2).gameObject, ((TMP_Text)val2).text, useRegex))
		{
			list.Add((((Object)((TMP_Text)val2).transform.parent).name + "/" + ((Object)val2).name, ((TMP_Text)val2).text));
		}
		TMP_SubMeshUI val3 = default(TMP_SubMeshUI);
		if (obj.TryGetComponent<TMP_SubMeshUI>(ref val3) && !IsBannedText(((Component)val3).gameObject, ((TMP_Text)val3.m_TextComponent).text, useRegex))
		{
			list.Add((((Object)((Component)val3).transform.parent).name + "/" + ((Object)val3).name, val3.textComponent.text));
		}
		list.AddRange(FindInChildrenList(obj, null, useRegex));
		return list.Distinct().ToList();
	}

	public static string FindExtendedTextElement(GameObject obj, string objPath = "", bool useRegex = true)
	{
		if ((Object)(object)obj == (Object)null && !string.IsNullOrEmpty(objPath))
		{
			obj = GameObject.Find(objPath);
		}
		ExtendedTextMeshProUGUI val = default(ExtendedTextMeshProUGUI);
		if (obj.TryGetComponent<ExtendedTextMeshProUGUI>(ref val) && !IsBannedText(((Component)val).gameObject, ((TMP_Text)val).text, useRegex))
		{
			return ((TMP_Text)val).text;
		}
		RubyTextGX val2 = default(RubyTextGX);
		if (obj.TryGetComponent<RubyTextGX>(ref val2) && !IsBannedText(((Component)val2).gameObject, ((TMP_Text)val2).text, useRegex))
		{
			return ((TMP_Text)val2).text;
		}
		TMP_SubMeshUI val3 = default(TMP_SubMeshUI);
		if (obj.TryGetComponent<TMP_SubMeshUI>(ref val3) && !IsBannedText(((Component)val3).gameObject, ((TMP_Text)val3.m_TextComponent).text, useRegex))
		{
			return ((TMP_Text)val3.m_TextComponent).text;
		}
		return FindInChildren(obj, "", useRegex);
	}

	private static List<(string, string)> FindInChildrenList(GameObject obj, string objPath = "", bool useRegex = true)
	{
		if ((Object)(object)obj == (Object)null && !string.IsNullOrEmpty(objPath))
		{
			obj = GameObject.Find(objPath);
		}
		List<(string, string)> list = new List<(string, string)>();
		ExtendedTextMeshProUGUI val = default(ExtendedTextMeshProUGUI);
		RubyTextGX val2 = default(RubyTextGX);
		TMP_SubMeshUI val3 = default(TMP_SubMeshUI);
		for (int i = 0; i < obj.transform.childCount; i++)
		{
			Transform child = obj.transform.GetChild(i);
			if (((Component)child).TryGetComponent<ExtendedTextMeshProUGUI>(ref val) && !IsBannedText(((Component)val).gameObject, ((TMP_Text)val).text, useRegex))
			{
				list.Add((((Object)((TMP_Text)val).transform.parent).name + "/" + ((Object)val).name, ((TMP_Text)val).text));
			}
			if (((Component)child).TryGetComponent<RubyTextGX>(ref val2) && !IsBannedText(((Component)val2).gameObject, ((TMP_Text)val2).text, useRegex))
			{
				list.Add((((Object)((TMP_Text)val2).transform.parent).name + "/" + ((Object)val2).name, ((TMP_Text)val2).text));
			}
			if (((Component)child).TryGetComponent<TMP_SubMeshUI>(ref val3) && !IsBannedText(((Component)val3).gameObject, val3.textComponent.text, useRegex))
			{
				list.Add((((Object)((Component)val3).transform.parent).name + "/" + ((Object)val3).name, val3.textComponent.text));
			}
			if (child.childCount > 0)
			{
				list.AddRange(FindInChildrenList(((Component)child).gameObject, "", useRegex));
			}
		}
		return list.Distinct().ToList();
	}

	private static string FindInChildren(GameObject obj, string objPath = "", bool useRegex = true)
	{
		if ((Object)(object)obj == (Object)null && !string.IsNullOrEmpty(objPath))
		{
			obj = GameObject.Find(objPath);
		}
		Transform val = null;
		ExtendedTextMeshProUGUI val2 = null;
		RubyTextGX val3 = null;
		TMP_SubMeshUI val4 = null;
		ExtendedTextMeshProUGUI val5 = default(ExtendedTextMeshProUGUI);
		RubyTextGX val6 = default(RubyTextGX);
		TMP_SubMeshUI val7 = default(TMP_SubMeshUI);
		for (int i = 0; i < obj.transform.childCount; i++)
		{
			val = obj.transform.GetChild(i);
			if (((Component)val).TryGetComponent<ExtendedTextMeshProUGUI>(ref val5) && !IsBannedText(((Component)val5).gameObject, ((TMP_Text)val5).text, useRegex))
			{
				return ((TMP_Text)val5).text;
			}
			val2 = ((Component)val).GetComponentInChildren<ExtendedTextMeshProUGUI>();
			if ((Object)(object)val2 != (Object)null && !IsBannedText(((Component)val2).gameObject, ((TMP_Text)val2).text, useRegex))
			{
				return ((TMP_Text)val2).text;
			}
			if (((Component)val).TryGetComponent<RubyTextGX>(ref val6) && !IsBannedText(((Component)val6).gameObject, ((TMP_Text)val6).text, useRegex))
			{
				return ((TMP_Text)val5).text;
			}
			val3 = ((Component)val).GetComponentInChildren<RubyTextGX>();
			if ((Object)(object)val3 != (Object)null && !IsBannedText(((Component)val3).gameObject, ((TMP_Text)val3).text, useRegex))
			{
				return ((TMP_Text)val3).text;
			}
			if (((Component)val).TryGetComponent<TMP_SubMeshUI>(ref val7) && !IsBannedText(((Component)val7).gameObject, val7.textComponent.text, useRegex))
			{
				return val7.textComponent.text;
			}
			val4 = ((Component)val).GetComponentInChildren<TMP_SubMeshUI>();
			if ((Object)(object)val3 != (Object)null && !IsBannedText(((Component)val4).gameObject, val4.textComponent.text, useRegex))
			{
				return val4.textComponent.text;
			}
		}
		return null;
	}

	public static bool IsBannedText(GameObject textElement, string text, bool useRegex)
	{
		if ((Object)(object)textElement == (Object)null || string.IsNullOrEmpty(text) || !textElement.gameObject.activeInHierarchy)
		{
			return true;
		}
		return (useRegex && Regex.IsMatch(text, (currentMenu != 0 || ((Object)textElement).name.Equals("Button")) ? "^\\s*$" : "^\\s*$|[.!]+$")) || bannedText.Contains(text);
	}
}
