namespace CrossSpeak;

public interface IScreenReader
{
	bool Initialize();

	bool IsLoaded();

	bool Speak(string text, bool interrupt = true);

	bool IsSpeaking();

	void Close();

	float GetVolume();

	void SetVolume(float volume);

	float GetRate();

	void SetRate(float rate);

	bool HasSpeech();

	void TrySAPI(bool trySAPI);

	void PreferSAPI(bool preferSAPI);

	string DetectScreenReader();

	bool Output(string text, bool interrupt = true);

	bool HasBraille();

	bool Braille(string text);

	bool Silence();
}
