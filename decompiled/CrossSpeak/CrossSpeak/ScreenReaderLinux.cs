namespace CrossSpeak;

internal class ScreenReaderLinux : IScreenReader
{
	private bool _initialized;

	public bool Initialize()
	{
		if (IsLoaded())
		{
			Close();
		}
		int num = LibSpeechdWrapperAPI.Initialize();
		_initialized = num == 1;
		return _initialized;
	}

	public bool Speak(string text, bool interrupt = true)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return false;
		}
		if (!_initialized)
		{
			return false;
		}
		return LibSpeechdWrapperAPI.Speak(new LibSpeechdWrapperAPI.GoString(text, text.Length), interrupt) == 1;
	}

	public bool IsLoaded()
	{
		return _initialized;
	}

	public float GetVolume()
	{
		return 0f;
	}

	public void SetVolume(float volume)
	{
	}

	public float GetRate()
	{
		return 0f;
	}

	public void SetRate(float rate)
	{
	}

	public string DetectScreenReader()
	{
		return null;
	}

	public bool HasSpeech()
	{
		return IsLoaded();
	}

	public bool Output(string text, bool interrupt)
	{
		if (!Speak(text, interrupt))
		{
			return Braille(text);
		}
		return true;
	}

	public bool IsSpeaking()
	{
		return false;
	}

	public void TrySAPI(bool trySAPI)
	{
	}

	public void PreferSAPI(bool preferSAPI)
	{
	}

	public bool HasBraille()
	{
		return false;
	}

	public bool Braille(string text)
	{
		return false;
	}

	public bool Silence()
	{
		return false;
	}

	public void Close()
	{
		if (_initialized)
		{
			LibSpeechdWrapperAPI.Close();
			_initialized = false;
		}
	}
}
