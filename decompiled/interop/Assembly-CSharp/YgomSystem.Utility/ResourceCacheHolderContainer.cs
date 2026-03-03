using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003FA")]
public class ResourceCacheHolderContainer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003FB")]
	public class Holder
	{
		[Token(Token = "0x40013D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string m_GroupLabel;

		[Token(Token = "0x40013D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HashSet<GameObject> m_Owners;

		[Token(Token = "0x40013D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<string> m_CachedPaths;

		[Token(Token = "0x17000266")]
		public string groupLabel
		{
			[Token(Token = "0x6001977")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000267")]
		public bool hasOwners
		{
			[Token(Token = "0x6001978")]
			[Address(RVA = "0x5C7A70", Offset = "0x5C6C70", VA = "0x1805C7A70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000017")]
		public event Action<Holder> onUnregistOwnerEvent
		{
			[Token(Token = "0x6001979")]
			[Address(RVA = "0x5C79C0", Offset = "0x5C6BC0", VA = "0x1805C79C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600197A")]
			[Address(RVA = "0x5C7BB0", Offset = "0x5C6DB0", VA = "0x1805C7BB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600197B")]
		[Address(RVA = "0x5C78E0", Offset = "0x5C6AE0", VA = "0x1805C78E0")]
		public Holder(string groupLabel)
		{
		}

		[Token(Token = "0x600197C")]
		[Address(RVA = "0x5C76C0", Offset = "0x5C68C0", VA = "0x1805C76C0")]
		public void RegistOwner(GameObject owner)
		{
		}

		[Token(Token = "0x600197D")]
		[Address(RVA = "0x5C7870", Offset = "0x5C6A70", VA = "0x1805C7870")]
		public void UnregistOwner(GameObject owner)
		{
		}

		[Token(Token = "0x600197E")]
		[Address(RVA = "0x5C7450", Offset = "0x5C6650", VA = "0x1805C7450")]
		public void LoadChecks(IEnumerable<string> paths)
		{
		}

		[Token(Token = "0x600197F")]
		public void LoadCheck<T>(string path)
		{
		}

		[Token(Token = "0x6001980")]
		[Address(RVA = "0x5C73C0", Offset = "0x5C65C0", VA = "0x1805C73C0")]
		public void LoadCheck(string path, [Optional] Type systemTypeInstance)
		{
		}

		[Token(Token = "0x6001981")]
		[Address(RVA = "0x5C7720", Offset = "0x5C6920", VA = "0x1805C7720")]
		public void Release()
		{
		}
	}

	[Token(Token = "0x40013D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ResourceCacheHolderContainer s_InstanceCache;

	[Token(Token = "0x40013D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, Holder> m_GroupToOwnersMap;

	[Token(Token = "0x6001970")]
	[Address(RVA = "0x5D3460", Offset = "0x5D2660", VA = "0x1805D3460")]
	private static ResourceCacheHolderContainer GetOrCreateInstance()
	{
		return null;
	}

	[Token(Token = "0x6001971")]
	[Address(RVA = "0x5D3600", Offset = "0x5D2800", VA = "0x1805D3600")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001972")]
	[Address(RVA = "0x5D3120", Offset = "0x5D2320", VA = "0x1805D3120")]
	private Holder GetHolder(string groupLabel)
	{
		return null;
	}

	[Token(Token = "0x6001973")]
	[Address(RVA = "0x5D31B0", Offset = "0x5D23B0", VA = "0x1805D31B0")]
	private Holder GetOrCreateHolder(string groupLabel)
	{
		return null;
	}

	[Token(Token = "0x6001974")]
	[Address(RVA = "0x5D37A0", Offset = "0x5D29A0", VA = "0x1805D37A0")]
	public static Holder RentHolder(string groupLabel, GameObject owner)
	{
		return null;
	}

	[Token(Token = "0x6001975")]
	[Address(RVA = "0x5D3650", Offset = "0x5D2850", VA = "0x1805D3650")]
	private void OnHolderUnregistOwner(Holder holder)
	{
	}

	[Token(Token = "0x6001976")]
	[Address(RVA = "0x5D39B0", Offset = "0x5D2BB0", VA = "0x1805D39B0")]
	public ResourceCacheHolderContainer()
	{
	}
}
