namespace Coon.Text
{
    public class TextOf : IText
    {
        private readonly string _input;

        public TextOf(string input)
        {
            _input = input;
        }
        
        public string AsString()
        {
            throw new System.NotImplementedException();
        }

        public int CompareTo(IText text)
        {
            throw new System.NotImplementedException();
        }
    }
}