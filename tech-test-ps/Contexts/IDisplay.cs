namespace tech_test_ps
{
    public interface IDisplay
    {
        public string ShowLinePrompt(string text);
        public void ShowLinePromptAnyKey(string text);
        public void ShowLine(string text);
        public string Readline();
        public void Clear();
        public void ReadKey();
    }


}
    


