using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000505")]
internal sealed class VisualTreeUpdater : IDisposable
{
	[Token(Token = "0x2000506")]
	private class UpdaterArray
	{
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x10")]
		private IVisualTreeUpdater[] m_VisualTreeUpdaters;

		[Token(Token = "0x17000969")]
		public IVisualTreeUpdater this[VisualTreeUpdatePhase phase]
		{
			[Token(Token = "0x600241D")]
			[Address(RVA = "0x4179D0", Offset = "0x416BD0", VA = "0x1804179D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600241C")]
			[Address(RVA = "0x2A3A500", Offset = "0x2A39700", VA = "0x182A3A500")]
			set
			{
			}
		}

		[Token(Token = "0x1700096A")]
		public IVisualTreeUpdater this[int index]
		{
			[Token(Token = "0x600241E")]
			[Address(RVA = "0x4179D0", Offset = "0x416BD0", VA = "0x1804179D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600241B")]
		[Address(RVA = "0x2A3A4A0", Offset = "0x2A396A0", VA = "0x182A3A4A0")]
		public UpdaterArray()
		{
		}
	}

	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x10")]
	private BaseVisualElementPanel m_Panel;

	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x18")]
	private UpdaterArray m_UpdaterArray;

	[Token(Token = "0x6002413")]
	[Address(RVA = "0x2A42AC0", Offset = "0x2A41CC0", VA = "0x182A42AC0")]
	public VisualTreeUpdater(BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6002414")]
	[Address(RVA = "0x2A42390", Offset = "0x2A41590", VA = "0x182A42390", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6002415")]
	[Address(RVA = "0x2A428C0", Offset = "0x2A41AC0", VA = "0x182A428C0")]
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase)
	{
	}

	[Token(Token = "0x6002416")]
	[Address(RVA = "0x2A42500", Offset = "0x2A41700", VA = "0x182A42500")]
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x6002417")]
	[Address(RVA = "0x2A42740", Offset = "0x2A41940", VA = "0x182A42740")]
	public void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
	{
	}

	[Token(Token = "0x6002418")]
	public void SetUpdater<T>(VisualTreeUpdatePhase phase) where T : IVisualTreeUpdater, new()
	{
	}

	[Token(Token = "0x6002419")]
	[Address(RVA = "0x2A424C0", Offset = "0x2A416C0", VA = "0x182A424C0")]
	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
	{
		return null;
	}

	[Token(Token = "0x600241A")]
	[Address(RVA = "0x2A42640", Offset = "0x2A41840", VA = "0x182A42640")]
	private void SetDefaultUpdaters()
	{
	}
}
